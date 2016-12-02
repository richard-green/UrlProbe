using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrlProbe
{
    public partial class frmMain : Form
    {
        #region Members

        Queue<string> urisToProbe = new Queue<string>();

        #endregion Members

        #region Constructor

        public frmMain()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                                                 | SecurityProtocolType.Tls11
                                                 | SecurityProtocolType.Tls
                                                 | SecurityProtocolType.Ssl3;

            InitializeComponent();
        }

        #endregion Constructor

        #region User Events

        private void dgURIs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                var originalHostname = (string)dgURIs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                var hostname = GetValidURI(originalHostname);

                if (originalHostname.Equals(hostname) == false)
                {
                    dgURIs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = hostname;
                }

                EnqueueURI(hostname);
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            dgURIs.Rows.Clear();
        }

        private void btnProbeAll_Click(object sender, EventArgs e)
        {
            foreach (var hostname in GetCurrentURIs())
            {
                EnqueueURI(hostname);
            }
        }

        private void btnPasteFromClipboard_Click(object sender, EventArgs e)
        {
            var entries = Clipboard.GetText();

            var hostnames = entries.Split(new string[] { ",", "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).Select(s => GetValidURI(s));

            DataGridViewRow row;

            foreach (var hostname in hostnames)
            {
                row = new DataGridViewRow();
                row.CreateCells(dgURIs, hostname, "");
                dgURIs.Rows.Add(row);
            }

            foreach (var hostname in hostnames.Distinct())
            {
                EnqueueURI(hostname);
            }
        }

        #endregion User Events

        #region Private Methods

        private void EnqueueURI(string hostname)
        {
            lock (urisToProbe)
            {
                urisToProbe.Enqueue(hostname.Trim());
                UpdateResponse(hostname, "Pending...");
            }
        }

        private void UpdateResponse(string hostname, string newValue)
        {
            this.InvokeAction(@this =>
                {
                    for (int i = 0; i < dgURIs.Rows.Count; i++)
                    {
                        if (hostname.Equals(((string)dgURIs.Rows[i].Cells[0].Value), StringComparison.CurrentCultureIgnoreCase))
                        {
                            dgURIs.Rows[i].Cells[1].Value = newValue;
                        }
                    }
                });
        }

        private IEnumerable<string> GetCurrentURIs()
        {
            var hostnames = new List<string>();

            for (int i = 0; i < dgURIs.Rows.Count; i++)
            {
                var hostname = (string)dgURIs.Rows[i].Cells[0].Value;

                if (String.IsNullOrEmpty(hostname) == false)
                {
                    hostnames.Add(hostname);
                }
            }

            return hostnames.Distinct();
        }

        private string GetValidURI(string hostname)
        {
            return hostname.Trim();
        }

        #endregion Private Methods

        #region Events

        private void tmrQueuePoll_Tick(object sender, EventArgs e)
        {
            tmrQueuePoll.Enabled = false;

            var task = Task.Run(() =>
            {
                try
                {
                    lock (urisToProbe)
                    {
                        if (urisToProbe.Any())
                        {
                            SemaphoreSlim semaphore = new SemaphoreSlim(5);

                            while (urisToProbe.Any())
                            {
                                semaphore.Wait(Timeout.Infinite);

                                var uri = urisToProbe.Dequeue();

                                UpdateResponse(uri, "Probing...");

                                WebClient client = new WebClient();
                                var downloadTask = client.DownloadStringTaskAsync(uri);

                                downloadTask.ContinueWith(_ =>
                                {
                                    try
                                    {
                                        if (_.IsFaulted)
                                        {
                                            UpdateResponse(uri, _.Exception.InnerExceptions[0].Message);
                                        }
                                        else if (_.IsCompleted)
                                        {
                                            UpdateResponse(uri, "OK");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        UpdateResponse(uri, ex.Message);
                                    }
                                    finally
                                    {
                                        semaphore.Release();
                                    }
                                });
                            }
                        }
                    }
                }
                finally
                {
                    this.InvokeAction(_ =>
                    {
                        tmrQueuePoll.Enabled = true;
                    });
                }
            });
        }

        #endregion Events
    }
}
