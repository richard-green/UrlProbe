namespace UrlProbe
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgURIs = new System.Windows.Forms.DataGridView();
            this.Hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProbeAll = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.tmrQueuePoll = new System.Windows.Forms.Timer(this.components);
            this.btnPasteFromClipboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgURIs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgURIs
            // 
            this.dgURIs.AllowUserToResizeRows = false;
            this.dgURIs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgURIs.BackgroundColor = System.Drawing.Color.White;
            this.dgURIs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgURIs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgURIs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgURIs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgURIs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgURIs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hostname,
            this.IPAddress});
            this.dgURIs.Location = new System.Drawing.Point(13, 13);
            this.dgURIs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgURIs.Name = "dgURIs";
            this.dgURIs.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.dgURIs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgURIs.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgURIs.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.dgURIs.Size = new System.Drawing.Size(641, 425);
            this.dgURIs.TabIndex = 0;
            this.dgURIs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgURIs_CellValueChanged);
            // 
            // Hostname
            // 
            this.Hostname.HeaderText = "URL";
            this.Hostname.Name = "Hostname";
            this.Hostname.Width = 450;
            // 
            // IPAddress
            // 
            this.IPAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IPAddress.HeaderText = "Response";
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.ReadOnly = true;
            // 
            // btnProbeAll
            // 
            this.btnProbeAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProbeAll.Location = new System.Drawing.Point(565, 449);
            this.btnProbeAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProbeAll.Name = "btnProbeAll";
            this.btnProbeAll.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnProbeAll.Size = new System.Drawing.Size(91, 32);
            this.btnProbeAll.TabIndex = 1;
            this.btnProbeAll.Text = "Probe All";
            this.btnProbeAll.UseVisualStyleBackColor = true;
            this.btnProbeAll.Click += new System.EventHandler(this.btnProbeAll_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.Location = new System.Drawing.Point(472, 449);
            this.btnClearList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClearList.Size = new System.Drawing.Size(87, 32);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // tmrQueuePoll
            // 
            this.tmrQueuePoll.Enabled = true;
            this.tmrQueuePoll.Interval = 500;
            this.tmrQueuePoll.Tick += new System.EventHandler(this.tmrQueuePoll_Tick);
            // 
            // btnPasteFromClipboard
            // 
            this.btnPasteFromClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasteFromClipboard.Location = new System.Drawing.Point(307, 449);
            this.btnPasteFromClipboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPasteFromClipboard.Name = "btnPasteFromClipboard";
            this.btnPasteFromClipboard.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPasteFromClipboard.Size = new System.Drawing.Size(159, 32);
            this.btnPasteFromClipboard.TabIndex = 4;
            this.btnPasteFromClipboard.Text = "Paste from Clipboard";
            this.btnPasteFromClipboard.UseVisualStyleBackColor = true;
            this.btnPasteFromClipboard.Click += new System.EventHandler(this.btnPasteFromClipboard_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(667, 493);
            this.Controls.Add(this.btnPasteFromClipboard);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnProbeAll);
            this.Controls.Add(this.dgURIs);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "URL Probe";
            ((System.ComponentModel.ISupportInitialize)(this.dgURIs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgURIs;
        private System.Windows.Forms.Button btnProbeAll;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Timer tmrQueuePoll;
        private System.Windows.Forms.Button btnPasteFromClipboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPAddress;
    }
}

