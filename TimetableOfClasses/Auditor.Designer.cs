namespace TimetableOfClasses
{
    partial class Auditor
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
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cafedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Audit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vmestit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Korpus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Number,
            this.Cafedra,
            this.Audit,
            this.Vmestit,
            this.Korpus});
			this.DataGridAuditor.Location = new System.Drawing.Point(12, 12);
			this.DataGridAuditor.Name = "DataGridAuditor";
			this.DataGridAuditor.RowHeadersVisible = false;
			this.DataGridAuditor.Size = new System.Drawing.Size(467, 237);
			this.DataGridAuditor.TabIndex = 1;
			// 
			// Number
			// 
			this.Number.HeaderText = "";
			this.Number.Name = "Number";
			this.Number.Width = 21;
			// 
			// Cafedra
			// 
			this.Cafedra.HeaderText = "Кафедра";
			this.Cafedra.Name = "Cafedra";
			this.Cafedra.Width = 77;
			// 
			// Audit
			// 
			this.Audit.HeaderText = "Аудитория";
			this.Audit.Name = "Audit";
			this.Audit.Width = 85;
			// 
			// Vmestit
			// 
			this.Vmestit.HeaderText = "Число мест";
			this.Vmestit.Name = "Vmestit";
			this.Vmestit.Width = 92;
			// 
			// Korpus
			// 
			this.Korpus.HeaderText = "Корпус";
			this.Korpus.Name = "Korpus";
			this.Korpus.Width = 68;
			// 
			// Auditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 261);
			this.Controls.Add(this.DataGridAuditor);
			this.Name = "Auditor";
			this.Text = "Аудитории";
			((System.ComponentModel.ISupportInitialize)(this.DataGridAuditor)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridAuditor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cafedra;
		private System.Windows.Forms.DataGridViewTextBoxColumn Audit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vmestit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Korpus;
	}
}