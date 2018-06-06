namespace TimetableOfClasses
{
    partial class Group
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
            this.DataGridAuditor = new System.Windows.Forms.DataGridView();
            this.Shifr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Population = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAuditor)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridAuditor
            // 
            this.DataGridAuditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridAuditor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridAuditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAuditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Shifr,
            this.Population});
            this.DataGridAuditor.Location = new System.Drawing.Point(12, 12);
            this.DataGridAuditor.Name = "DataGridAuditor";
            this.DataGridAuditor.Size = new System.Drawing.Size(441, 250);
            this.DataGridAuditor.TabIndex = 2;
            // 
            // Shifr
            // 
            this.Shifr.HeaderText = "Шифр";
            this.Shifr.Name = "Shifr";
            this.Shifr.Width = 61;
            // 
            // Population
            // 
            this.Population.HeaderText = "Численность";
            this.Population.Name = "Population";
            this.Population.Width = 99;
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 274);
            this.Controls.Add(this.DataGridAuditor);
            this.Name = "Group";
            this.Text = "Group";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAuditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridAuditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shifr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population;
    }
}