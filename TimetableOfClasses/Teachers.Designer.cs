namespace TimetableOfClasses
{
    partial class Teachers
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
            this.DG = new System.Windows.Forms.DataGridView();
            this.ColFam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcademicDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcademicRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTheSizeOfTeachingExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // DG
            // 
            this.DG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFam,
            this.ColName,
            this.ColSurName,
            this.ColAcademicDegree,
            this.ColAcademicRank,
            this.ColTheSizeOfTeachingExperience});
            this.DG.Location = new System.Drawing.Point(12, 12);
            this.DG.Name = "Teacher";
            this.DG.Size = new System.Drawing.Size(904, 307);
            this.DG.TabIndex = 0;
            // 
            // Fam
            // 
            this.ColFam.HeaderText = "Фамилия";
            this.ColFam.Name = "Fam";
            this.ColFam.Width = 81;
            // 
            // Name
            // 
            this.ColName.HeaderText = "Имя";
            this.ColName.Name = "Name";
            this.ColName.Width = 54;
            // 
            // SurName
            // 
            this.ColSurName.HeaderText = "Отчество";
            this.ColSurName.Name = "SurName";
            this.ColSurName.Width = 79;
            // 
            // AcademicDegree
            // 
            this.ColAcademicDegree.HeaderText = "Ученая степень";
            this.ColAcademicDegree.Name = "AcademicDegree";
            this.ColAcademicDegree.Width = 104;
            // 
            // AcademicRank
            // 
            this.ColAcademicRank.HeaderText = "Ученое звание";
            this.ColAcademicRank.Name = "AcademicRank";
            this.ColAcademicRank.Width = 99;
            // 
            // TheSizeOfTeachingExperience
            // 
            this.ColTheSizeOfTeachingExperience.HeaderText = "Размер педагогического стажа";
            this.ColTheSizeOfTeachingExperience.Name = "TheSizeOfTeachingExperience";
            this.ColTheSizeOfTeachingExperience.Width = 149;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 331);
            this.Controls.Add(this.DG);
            this.Name = "Teachers";
            this.Text = "Teachers";
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAcademicDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAcademicRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTheSizeOfTeachingExperience;
    }
}