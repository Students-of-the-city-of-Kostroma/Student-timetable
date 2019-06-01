namespace TimetableOfClasses
{
    partial class AddDepartment
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
			this.label1 = new System.Windows.Forms.Label();
			this.shortTitle = new System.Windows.Forms.TextBox();
			this.fullTitle = new System.Windows.Forms.TextBox();
			this.departmentHead = new System.Windows.Forms.TextBox();
			this.institute = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.B_Сancel = new System.Windows.Forms.Button();
			this.createAndClose = new System.Windows.Forms.Button();
			this.tooltip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Краткое название";
			// 
			// shortTitle
			// 
			this.shortTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.shortTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.shortTitle.Location = new System.Drawing.Point(12, 32);
			this.shortTitle.MaxLength = 10;
			this.shortTitle.Name = "shortTitle";
			this.shortTitle.Size = new System.Drawing.Size(266, 22);
			this.shortTitle.TabIndex = 3;
			this.shortTitle.TextChanged += new System.EventHandler(this.ShortTitleTextChanged);
			// 
			// fullTitle
			// 
			this.fullTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.fullTitle.Location = new System.Drawing.Point(12, 92);
			this.fullTitle.MaxLength = 64;
			this.fullTitle.Name = "fullTitle";
			this.fullTitle.Size = new System.Drawing.Size(266, 22);
			this.fullTitle.TabIndex = 4;
			this.fullTitle.TextChanged += new System.EventHandler(this.FullTitleTextChanged);
			// 
			// departmentHead
			// 
			this.departmentHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.departmentHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.departmentHead.Location = new System.Drawing.Point(12, 156);
			this.departmentHead.MaxLength = 200;
			this.departmentHead.Name = "departmentHead";
			this.departmentHead.Size = new System.Drawing.Size(266, 22);
			this.departmentHead.TabIndex = 5;
			this.departmentHead.TextChanged += new System.EventHandler(this.DepartmentHeadTextChanged);
			// 
			// institute
			// 
			this.institute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.institute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.institute.Location = new System.Drawing.Point(12, 226);
			this.institute.MaxLength = 64;
			this.institute.Name = "institute";
			this.institute.Size = new System.Drawing.Size(266, 22);
			this.institute.TabIndex = 6;
			this.institute.TextChanged += new System.EventHandler(this.InstituteTextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label2.Location = new System.Drawing.Point(13, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Полное название";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label3.Location = new System.Drawing.Point(13, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Заведующий кафедрой";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label4.Location = new System.Drawing.Point(13, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "Институт";
			// 
			// B_Сancel
			// 
			this.B_Сancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.B_Сancel.Location = new System.Drawing.Point(127, 342);
			this.B_Сancel.Name = "B_Сancel";
			this.B_Сancel.Size = new System.Drawing.Size(70, 34);
			this.B_Сancel.TabIndex = 19;
			this.B_Сancel.Text = "Отмена";
			this.B_Сancel.UseVisualStyleBackColor = true;
			this.B_Сancel.Click += new System.EventHandler(this.СancelClick);
			// 
			// createAndClose
			// 
			this.createAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.createAndClose.Location = new System.Drawing.Point(203, 342);
			this.createAndClose.Name = "createAndClose";
			this.createAndClose.Size = new System.Drawing.Size(75, 34);
			this.createAndClose.TabIndex = 18;
			this.createAndClose.Text = "Сохранить";
			this.createAndClose.UseVisualStyleBackColor = true;
			this.createAndClose.Click += new System.EventHandler(this.CreateAndCloseClick);
			// 
			// AddDepartment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 388);
			this.Controls.Add(this.B_Сancel);
			this.Controls.Add(this.createAndClose);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.institute);
			this.Controls.Add(this.departmentHead);
			this.Controls.Add(this.fullTitle);
			this.Controls.Add(this.shortTitle);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(249, 427);
			this.Name = "AddDepartment";
			this.Text = "Добавить кафедру";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shortTitle;
        private System.Windows.Forms.TextBox fullTitle;
        private System.Windows.Forms.TextBox departmentHead;
        private System.Windows.Forms.TextBox institute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_Сancel;
        private System.Windows.Forms.Button createAndClose;
		private System.Windows.Forms.ToolTip tooltip;
	}
}