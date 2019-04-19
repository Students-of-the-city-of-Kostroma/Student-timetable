namespace TimetableOfClasses
{
    partial class AddGroup
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
			this.B_Сancel = new System.Windows.Forms.Button();
			this.tbVixodnie = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbNaprav = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNameGroup = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupAdd = new System.Windows.Forms.Button();
			this.nudSemest = new System.Windows.Forms.NumericUpDown();
			this.nudMinPar = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.nudMaxPar = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.nudCountStudents = new System.Windows.Forms.NumericUpDown();
			this.nudSmena = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudSemest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinPar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxPar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCountStudents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSmena)).BeginInit();
			this.SuspendLayout();
			// 
			// B_Сancel
			// 
			this.B_Сancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.B_Сancel.Location = new System.Drawing.Point(82, 461);
			this.B_Сancel.Name = "B_Сancel";
			this.B_Сancel.Size = new System.Drawing.Size(77, 32);
			this.B_Сancel.TabIndex = 32;
			this.B_Сancel.Text = "Отмена";
			this.B_Сancel.UseVisualStyleBackColor = true;
			this.B_Сancel.Click += new System.EventHandler(this.B_Сancel_Click);
			// 
			// tbVixodnie
			// 
			this.tbVixodnie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbVixodnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbVixodnie.Location = new System.Drawing.Point(11, 421);
			this.tbVixodnie.MaxLength = 70;
			this.tbVixodnie.Name = "tbVixodnie";
			this.tbVixodnie.Size = new System.Drawing.Size(235, 22);
			this.tbVixodnie.TabIndex = 28;
			this.tbVixodnie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress3);
			this.tbVixodnie.Leave += new System.EventHandler(this.SelectionOfLetters2);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(11, 402);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 16);
			this.label5.TabIndex = 27;
			this.label5.Text = "Выходные";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(11, 230);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 16);
			this.label4.TabIndex = 25;
			this.label4.Text = "Студентов";
			// 
			// tbNaprav
			// 
			this.tbNaprav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbNaprav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbNaprav.Location = new System.Drawing.Point(11, 139);
			this.tbNaprav.MaxLength = 100;
			this.tbNaprav.Name = "tbNaprav";
			this.tbNaprav.Size = new System.Drawing.Size(235, 22);
			this.tbNaprav.TabIndex = 24;
			this.tbNaprav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress2);
			this.tbNaprav.Leave += new System.EventHandler(this.SelectionOfLetters2);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 16);
			this.label3.TabIndex = 23;
			this.label3.Text = "Смена";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 21;
			this.label2.Text = "Семестр";
			// 
			// tbNameGroup
			// 
			this.tbNameGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbNameGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbNameGroup.Location = new System.Drawing.Point(12, 29);
			this.tbNameGroup.MaxLength = 10;
			this.tbNameGroup.Name = "tbNameGroup";
			this.tbNameGroup.Size = new System.Drawing.Size(235, 22);
			this.tbNameGroup.TabIndex = 20;
			this.tbNameGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress1);
			this.tbNameGroup.Leave += new System.EventHandler(this.SelectionOfLetters1);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "Группа";
			// 
			// groupAdd
			// 
			this.groupAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupAdd.Location = new System.Drawing.Point(165, 461);
			this.groupAdd.Name = "groupAdd";
			this.groupAdd.Size = new System.Drawing.Size(83, 32);
			this.groupAdd.TabIndex = 18;
			this.groupAdd.Text = "Сохранить";
			this.groupAdd.UseVisualStyleBackColor = true;
			this.groupAdd.Click += new System.EventHandler(this.createAndClose_Click);
			// 
			// nudSemest
			// 
			this.nudSemest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudSemest.Location = new System.Drawing.Point(12, 85);
			this.nudSemest.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudSemest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudSemest.Name = "nudSemest";
			this.nudSemest.ReadOnly = true;
			this.nudSemest.Size = new System.Drawing.Size(236, 20);
			this.nudSemest.TabIndex = 33;
			this.nudSemest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudSemest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress4);
			// 
			// nudMinPar
			// 
			this.nudMinPar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudMinPar.Location = new System.Drawing.Point(11, 305);
			this.nudMinPar.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.nudMinPar.Name = "nudMinPar";
			this.nudMinPar.Size = new System.Drawing.Size(236, 20);
			this.nudMinPar.TabIndex = 35;
			this.nudMinPar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress4);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(11, 286);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 16);
			this.label7.TabIndex = 34;
			this.label7.Text = "Пар/день min";
			// 
			// nudMaxPar
			// 
			this.nudMaxPar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudMaxPar.Location = new System.Drawing.Point(11, 363);
			this.nudMaxPar.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.nudMaxPar.Name = "nudMaxPar";
			this.nudMaxPar.Size = new System.Drawing.Size(236, 20);
			this.nudMaxPar.TabIndex = 37;
			this.nudMaxPar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress4);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(11, 344);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(97, 16);
			this.label8.TabIndex = 36;
			this.label8.Text = "Пар/день max";
			// 
			// nudCountStudents
			// 
			this.nudCountStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudCountStudents.Location = new System.Drawing.Point(11, 249);
			this.nudCountStudents.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudCountStudents.Name = "nudCountStudents";
			this.nudCountStudents.Size = new System.Drawing.Size(236, 20);
			this.nudCountStudents.TabIndex = 38;
			this.nudCountStudents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress4);
			// 
			// nudSmena
			// 
			this.nudSmena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudSmena.Location = new System.Drawing.Point(11, 193);
			this.nudSmena.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.nudSmena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudSmena.Name = "nudSmena";
			this.nudSmena.Size = new System.Drawing.Size(236, 20);
			this.nudSmena.TabIndex = 40;
			this.nudSmena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudSmena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress4);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(177, 16);
			this.label6.TabIndex = 39;
			this.label6.Text = "Направление подготовки";
			// 
			// AddGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 497);
			this.Controls.Add(this.nudSmena);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nudCountStudents);
			this.Controls.Add(this.nudMaxPar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.nudMinPar);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.nudSemest);
			this.Controls.Add(this.B_Сancel);
			this.Controls.Add(this.tbVixodnie);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbNaprav);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbNameGroup);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupAdd);
			this.Name = "AddGroup";
			this.Text = "Добавление группы";
			((System.ComponentModel.ISupportInitialize)(this.nudSemest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinPar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxPar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCountStudents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSmena)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button B_Сancel;
		private System.Windows.Forms.TextBox tbVixodnie;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbNaprav;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNameGroup;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button groupAdd;
		private System.Windows.Forms.NumericUpDown nudSemest;
		private System.Windows.Forms.NumericUpDown nudMinPar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown nudMaxPar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown nudCountStudents;
		private System.Windows.Forms.NumericUpDown nudSmena;
		private System.Windows.Forms.Label label6;
	}
}