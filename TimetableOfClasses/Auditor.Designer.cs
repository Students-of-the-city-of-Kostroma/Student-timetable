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
			this.Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Korpus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vmestit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bt1 = new System.Windows.Forms.Button();
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
            this.Stage,
            this.Korpus,
            this.Vmestit});
			this.DataGridAuditor.Location = new System.Drawing.Point(12, 12);
			this.DataGridAuditor.Name = "DataGridAuditor";
			this.DataGridAuditor.Size = new System.Drawing.Size(467, 237);
			this.DataGridAuditor.TabIndex = 1;
			// 
			// Number
			// 
			this.Number.HeaderText = "Номер";
			this.Number.Name = "Number";
			this.Number.Width = 66;
			// 
			// Stage
			// 
			this.Stage.HeaderText = "Этаж";
			this.Stage.Name = "Stage";
			this.Stage.Width = 58;
			// 
			// Korpus
			// 
			this.Korpus.HeaderText = "Корпус";
			this.Korpus.Name = "Korpus";
			this.Korpus.Width = 68;
			// 
			// Vmestit
			// 
			this.Vmestit.HeaderText = "Вместительность";
			this.Vmestit.Name = "Vmestit";
			this.Vmestit.Width = 122;
			// 
			// bt1
			// 
			this.bt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt1.Location = new System.Drawing.Point(411, 228);
			this.bt1.Name = "bt1";
			this.bt1.Size = new System.Drawing.Size(68, 21);
			this.bt1.TabIndex = 2;
			this.bt1.Text = "Добавить";
			this.bt1.UseVisualStyleBackColor = true;
			this.bt1.Click += new System.EventHandler(this.bt1_Click);
			// 
			// Auditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 261);
			this.Controls.Add(this.bt1);
			this.Controls.Add(this.DataGridAuditor);
			this.Name = "Auditor";
			this.Text = "Аудитории";
			((System.ComponentModel.ISupportInitialize)(this.DataGridAuditor)).EndInit();
			this.ResumeLayout(false);


        #endregion

        private System.Windows.Forms.DataGridView DataGridAuditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korpus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vmestit;
		    private System.Windows.Forms.Button bt1;
	}
}