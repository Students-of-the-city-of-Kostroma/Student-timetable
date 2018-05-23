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
            // Discipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 181);
            this.Controls.Add(this.DG_Disc);
            this.Name = "Discipline";
            this.Text = "Disciplines";
            ((System.ComponentModel.ISupportInitialize)(this.DG_Disc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naim;
    }
}