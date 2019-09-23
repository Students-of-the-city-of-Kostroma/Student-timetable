namespace TimetableOfClasses {
    partial class Departments {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.DepartmentGridView = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ShortTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentHead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Institute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmentGridView
            // 
            this.DepartmentGridView.AllowUserToAddRows = false;
            this.DepartmentGridView.AllowUserToDeleteRows = false;
            this.DepartmentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DepartmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShortTitle,
            this.FullTitle,
            this.DepartmentHead,
            this.Institute});
            this.DepartmentGridView.Location = new System.Drawing.Point(12, 12);
            this.DepartmentGridView.MultiSelect = false;
            this.DepartmentGridView.Name = "DepartmentGridView";
            this.DepartmentGridView.ReadOnly = true;
            this.DepartmentGridView.RowHeadersWidth = 60;
            this.DepartmentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepartmentGridView.Size = new System.Drawing.Size(460, 408);
            this.DepartmentGridView.TabIndex = 1;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBtn.Location = new System.Drawing.Point(316, 426);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Изменить";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtnClick);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(397, 426);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtnClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.Location = new System.Drawing.Point(235, 426);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtnClick);
            // 
            // ShortTitle
            // 
            this.ShortTitle.DataPropertyName = "ShortName";
            this.ShortTitle.FillWeight = 70F;
            this.ShortTitle.HeaderText = "Сокращенное название";
            this.ShortTitle.MinimumWidth = 70;
            this.ShortTitle.Name = "ShortTitle";
            this.ShortTitle.ReadOnly = true;
            // 
            // FullTitle
            // 
            this.FullTitle.DataPropertyName = "FullName";
            this.FullTitle.HeaderText = "Полное название";
            this.FullTitle.MinimumWidth = 100;
            this.FullTitle.Name = "FullTitle";
            this.FullTitle.ReadOnly = true;
            // 
            // DepartmentHead
            // 
            this.DepartmentHead.DataPropertyName = "DepartmentHead";
            this.DepartmentHead.FillWeight = 60F;
            this.DepartmentHead.HeaderText = "Заведующий кафедрой";
            this.DepartmentHead.MinimumWidth = 60;
            this.DepartmentHead.Name = "DepartmentHead";
            this.DepartmentHead.ReadOnly = true;
            // 
            // Institute
            // 
            this.Institute.DataPropertyName = "Institute";
            this.Institute.FillWeight = 60F;
            this.Institute.HeaderText = "Институт";
            this.Institute.MinimumWidth = 60;
            this.Institute.Name = "Institute";
            this.Institute.ReadOnly = true;
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.DepartmentGridView);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Departments";
            this.Text = "Кафедры";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DepartmentGridView;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn Institute;
    }
}