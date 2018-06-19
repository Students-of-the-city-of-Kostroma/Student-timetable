namespace TimetableOfClasses
{
    partial class Discipline
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
            this.DG_Disc = new System.Windows.Forms.DataGridView();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Disc)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Disc
            // 
            this.DG_Disc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Disc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod,
            this.Naim});
            this.DG_Disc.Location = new System.Drawing.Point(12, 12);
            this.DG_Disc.Name = "DG_Disc";
            this.DG_Disc.Size = new System.Drawing.Size(394, 156);
            this.DG_Disc.TabIndex = 0;
            this.DG_Disc.SelectionChanged += new System.EventHandler(this.DG_Disc_SelectionChanged);
            // 
            // Kod
            // 
            this.Kod.HeaderText = "Код";
            this.Kod.Name = "Kod";
            // 
            // Naim
            // 
            this.Naim.HeaderText = "Наименование";
            this.Naim.Name = "Naim";
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Delete.Location = new System.Drawing.Point(167, 175);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Discipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 203);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.DG_Disc);
            this.Name = "Discipline";
            this.Text = "Дисциплины";
            ((System.ComponentModel.ISupportInitialize)(this.DG_Disc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naim;
        private System.Windows.Forms.Button Delete;
    }
}