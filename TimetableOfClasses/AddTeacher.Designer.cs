namespace TimetableOfClasses
{
    partial class AddTeacher
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
			this.createAndClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.firstName = new System.Windows.Forms.TextBox();
			this.secondName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.patronymic = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.B_Сancel = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.department = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.metodDays = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.windows = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.weekends = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.checkPatronymic = new System.Windows.Forms.CheckBox();
			this.academicDegree = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.academicTitle = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// createAndClose
			// 
			this.createAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.createAndClose.Location = new System.Drawing.Point(203, 532);
			this.createAndClose.Name = "createAndClose";
			this.createAndClose.Size = new System.Drawing.Size(75, 34);
			this.createAndClose.TabIndex = 0;
			this.createAndClose.Text = "Сохранить";
			this.createAndClose.UseVisualStyleBackColor = true;
			this.createAndClose.Click += new System.EventHandler(this.createAndClose_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Имя";
			// 
			// firstName
			// 
			this.firstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.firstName.Location = new System.Drawing.Point(12, 28);
			this.firstName.MaxLength = 25;
			this.firstName.Name = "firstName";
			this.firstName.Size = new System.Drawing.Size(266, 22);
			this.firstName.TabIndex = 2;
			this.firstName.TextChanged += new System.EventHandler(this.fieldChanged);
			this.firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress1);
			this.firstName.Leave += new System.EventHandler(this.SelectionOfLetters2);
			// 
			// secondName
			// 
			this.secondName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.secondName.Location = new System.Drawing.Point(12, 84);
			this.secondName.MaxLength = 50;
			this.secondName.Name = "secondName";
			this.secondName.Size = new System.Drawing.Size(266, 22);
			this.secondName.TabIndex = 4;
			this.secondName.TextChanged += new System.EventHandler(this.fieldChanged);
			this.secondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress1);
			this.secondName.Leave += new System.EventHandler(this.SelectionOfLetters2);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Фамилия";
			// 
			// patronymic
			// 
			this.patronymic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.patronymic.Location = new System.Drawing.Point(12, 137);
			this.patronymic.MaxLength = 30;
			this.patronymic.Name = "patronymic";
			this.patronymic.Size = new System.Drawing.Size(266, 22);
			this.patronymic.TabIndex = 6;
			this.patronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress1);
			this.patronymic.Leave += new System.EventHandler(this.SelectionOfLetters2);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Отчество";
			// 
			// B_Сancel
			// 
			this.B_Сancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.B_Сancel.Location = new System.Drawing.Point(127, 532);
			this.B_Сancel.Name = "B_Сancel";
			this.B_Сancel.Size = new System.Drawing.Size(70, 34);
			this.B_Сancel.TabIndex = 17;
			this.B_Сancel.Text = "Отмена";
			this.B_Сancel.UseVisualStyleBackColor = true;
			this.B_Сancel.Click += new System.EventHandler(this.B_Сancel_Click);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 16);
			this.label4.TabIndex = 18;
			this.label4.Text = "Учёная степень";
			// 
			// department
			// 
			this.department.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.department.Location = new System.Drawing.Point(12, 305);
			this.department.MaxLength = 100;
			this.department.Name = "department";
			this.department.Size = new System.Drawing.Size(266, 22);
			this.department.TabIndex = 21;
			this.department.TextChanged += new System.EventHandler(this.fieldChanged);
			this.department.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress3);
			this.department.Leave += new System.EventHandler(this.SelectionOfLetters3);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 286);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 16);
			this.label5.TabIndex = 20;
			this.label5.Text = "Кафедра";
			// 
			// metodDays
			// 
			this.metodDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metodDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.metodDays.Location = new System.Drawing.Point(12, 362);
			this.metodDays.MaxLength = 70;
			this.metodDays.Name = "metodDays";
			this.metodDays.Size = new System.Drawing.Size(266, 22);
			this.metodDays.TabIndex = 23;
			this.metodDays.TextChanged += new System.EventHandler(this.fieldChanged);
			this.metodDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress3);
			this.metodDays.Leave += new System.EventHandler(this.SelectionOfLetters1);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 343);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(131, 16);
			this.label6.TabIndex = 22;
			this.label6.Text = "Методические дни";
			// 
			// windows
			// 
			this.windows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.windows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.windows.Location = new System.Drawing.Point(12, 416);
			this.windows.MaxLength = 70;
			this.windows.Name = "windows";
			this.windows.Size = new System.Drawing.Size(266, 22);
			this.windows.TabIndex = 25;
			this.windows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress3);
			this.windows.Leave += new System.EventHandler(this.SelectionOfLetters1);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(12, 397);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 16);
			this.label7.TabIndex = 24;
			this.label7.Text = "Окна";
			// 
			// weekends
			// 
			this.weekends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.weekends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.weekends.Location = new System.Drawing.Point(12, 467);
			this.weekends.MaxLength = 70;
			this.weekends.Name = "weekends";
			this.weekends.Size = new System.Drawing.Size(266, 22);
			this.weekends.TabIndex = 27;
			this.weekends.TextChanged += new System.EventHandler(this.fieldChanged);
			this.weekends.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress3);
			this.weekends.Leave += new System.EventHandler(this.SelectionOfLetters1);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(12, 448);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 16);
			this.label8.TabIndex = 26;
			this.label8.Text = "Выходные";
			// 
			// checkPatronymic
			// 
			this.checkPatronymic.AutoSize = true;
			this.checkPatronymic.Location = new System.Drawing.Point(12, 508);
			this.checkPatronymic.Name = "checkPatronymic";
			this.checkPatronymic.Size = new System.Drawing.Size(93, 17);
			this.checkPatronymic.TabIndex = 28;
			this.checkPatronymic.Text = "Нет отчества";
			this.checkPatronymic.UseVisualStyleBackColor = true;
			this.checkPatronymic.CheckedChanged += new System.EventHandler(this.checkPatronymic_CheckedChanged);
			// 
			// academicDegree
			// 
			this.academicDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.academicDegree.FormattingEnabled = true;
			this.academicDegree.Location = new System.Drawing.Point(12, 192);
			this.academicDegree.Name = "academicDegree";
			this.academicDegree.Size = new System.Drawing.Size(266, 24);
			this.academicDegree.TabIndex = 29;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(12, 230);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(108, 16);
			this.label9.TabIndex = 30;
			this.label9.Text = "Учёное звание";
			// 
			// academicTitle
			// 
			this.academicTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.academicTitle.FormattingEnabled = true;
			this.academicTitle.Location = new System.Drawing.Point(12, 250);
			this.academicTitle.Name = "academicTitle";
			this.academicTitle.Size = new System.Drawing.Size(266, 24);
			this.academicTitle.TabIndex = 31;
			// 
			// AddTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(290, 568);
			this.Controls.Add(this.academicTitle);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.academicDegree);
			this.Controls.Add(this.checkPatronymic);
			this.Controls.Add(this.weekends);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.windows);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.metodDays);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.department);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.B_Сancel);
			this.Controls.Add(this.patronymic);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.secondName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.firstName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.createAndClose);
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(249, 427);
			this.Name = "AddTeacher";
			this.Text = "Добавить преподавателя";
			this.Load += new System.EventHandler(this.AddTeacher_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAndClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox secondName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button B_Сancel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox department;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox metodDays;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox windows;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox weekends;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox checkPatronymic;
		private System.Windows.Forms.ComboBox academicDegree;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox academicTitle;
	}
}
