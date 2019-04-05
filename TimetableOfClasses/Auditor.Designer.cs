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
			this.NameOfAud = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cafedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Spacious = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
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
            this.NameOfAud,
            this.Cafedra,
            this.Spacious,
            this.Building});
			this.DataGridAuditor.Location = new System.Drawing.Point(12, 12);
			this.DataGridAuditor.Name = "DataGridAuditor";
			this.DataGridAuditor.RowHeadersVisible = false;
			this.DataGridAuditor.Size = new System.Drawing.Size(467, 225);
			this.DataGridAuditor.TabIndex = 1;
			// 
			// Number
			// 
			this.Number.HeaderText = "";
			this.Number.Name = "Number";
			this.Number.Width = 21;
			// 
			// NameOfAud
			// 
			this.NameOfAud.DataPropertyName = "NameOfAuditor";
			this.NameOfAud.HeaderText = "Аудитория";
			this.NameOfAud.Name = "NameOfAud";
			this.NameOfAud.Width = 85;
			// 
			// Cafedra
			// 
			this.Cafedra.DataPropertyName = "Cafedra";
			this.Cafedra.HeaderText = "Кафедра";
			this.Cafedra.Name = "Cafedra";
			this.Cafedra.Width = 77;
			// 
			// Spacious
			// 
			this.Spacious.DataPropertyName = "Spacious";
			this.Spacious.HeaderText = "Число мест";
			this.Spacious.Name = "Spacious";
			this.Spacious.Width = 92;
			// 
			// Building
			// 
			this.Building.DataPropertyName = "Building";
			this.Building.HeaderText = "Корпус";
			this.Building.Name = "Building";
			this.Building.Width = 68;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(12, 241);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Auditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 268);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.DataGridAuditor);
			this.Name = "Auditor";
			this.Text = "Аудитории";
			((System.ComponentModel.ISupportInitialize)(this.DataGridAuditor)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridAuditor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameOfAud;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cafedra;
		private System.Windows.Forms.DataGridViewTextBoxColumn Spacious;
		private System.Windows.Forms.DataGridViewTextBoxColumn Building;
		private System.Windows.Forms.Button button1;
	}
}