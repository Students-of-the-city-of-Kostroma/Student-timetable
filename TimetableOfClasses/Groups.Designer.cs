namespace TimetableOfClasses
{
    partial class Groups
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
            this.DG_Group = new System.Windows.Forms.DataGridView();
            this.Шифр = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Численность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Group)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Group
            // 
            this.DG_Group.AllowUserToAddRows = false;
            this.DG_Group.AllowUserToDeleteRows = false;
            this.DG_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Group.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Шифр,
            this.Численность});
            this.DG_Group.Location = new System.Drawing.Point(12, 12);
            this.DG_Group.Name = "DG_Group";
            this.DG_Group.ReadOnly = true;
            this.DG_Group.Size = new System.Drawing.Size(375, 365);
            this.DG_Group.TabIndex = 0;
            // 
            // Шифр
            // 
            this.Шифр.HeaderText = "Шифр";
            this.Шифр.Name = "Шифр";
            this.Шифр.ReadOnly = true;
            this.Шифр.Width = 61;
            // 
            // Численность
            // 
            this.Численность.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Численность.HeaderText = "Численность";
            this.Численность.Name = "Численность";
            this.Численность.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 389);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DG_Group);
            this.Name = "Groups";
            this.Text = "Группы";
            ((System.ComponentModel.ISupportInitialize)(this.DG_Group)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Шифр;
        private System.Windows.Forms.DataGridViewTextBoxColumn Численность;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}