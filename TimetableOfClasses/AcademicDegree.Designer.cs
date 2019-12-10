﻿namespace TimetableOfClasses
{
    partial class AcademicDegree
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
            this.DG_AcademicDegree = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_AcademicDegree)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_AcademicDegree
            // 
            this.DG_AcademicDegree.AllowUserToAddRows = false;
            this.DG_AcademicDegree.AllowUserToDeleteRows = false;
            this.DG_AcademicDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_AcademicDegree.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_AcademicDegree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_AcademicDegree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Reduction});
            this.DG_AcademicDegree.Location = new System.Drawing.Point(16, 15);
            this.DG_AcademicDegree.Margin = new System.Windows.Forms.Padding(4);
            this.DG_AcademicDegree.Name = "DG_AcademicDegree";
            this.DG_AcademicDegree.ReadOnly = true;
            this.DG_AcademicDegree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_AcademicDegree.Size = new System.Drawing.Size(492, 216);
            this.DG_AcademicDegree.TabIndex = 0;
            this.DG_AcademicDegree.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DG_RowPrePaint);
            this.DG_AcademicDegree.DoubleClick += new System.EventHandler(this.DG_AcademicDegree_DoubleClick);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Полная запись ученой степени";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Reduction
            // 
            this.Reduction.DataPropertyName = "Reduction";
            this.Reduction.HeaderText = "Сокращенная запись учёной степени";
            this.Reduction.Name = "Reduction";
            this.Reduction.ReadOnly = true;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(433, 239);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(267, 239);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeButton.Location = new System.Drawing.Point(350, 239);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 3;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // AcademicDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 272);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DG_AcademicDegree);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AcademicDegree";
            this.Text = "Ученые степени";
            ((System.ComponentModel.ISupportInitialize)(this.DG_AcademicDegree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_AcademicDegree;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reduction;
    }
}