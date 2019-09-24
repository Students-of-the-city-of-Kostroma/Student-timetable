namespace TimetableOfClasses
{
    partial class AddTypesOfOccupations
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btCreateAndClean = new System.Windows.Forms.Button();
            this.btCreateAndClose = new System.Windows.Forms.Button();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbShortName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(37, 120);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(80, 35);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // btCreateAndClean
            // 
            this.btCreateAndClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateAndClean.Location = new System.Drawing.Point(123, 120);
            this.btCreateAndClean.Name = "btCreateAndClean";
            this.btCreateAndClean.Size = new System.Drawing.Size(80, 35);
            this.btCreateAndClean.TabIndex = 3;
            this.btCreateAndClean.Text = "Создать и очистить";
            this.btCreateAndClean.UseVisualStyleBackColor = true;
            this.btCreateAndClean.Click += new System.EventHandler(this.BtCreateAndClean_Click);
            // 
            // btCreateAndClose
            // 
            this.btCreateAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateAndClose.Location = new System.Drawing.Point(209, 120);
            this.btCreateAndClose.Name = "btCreateAndClose";
            this.btCreateAndClose.Size = new System.Drawing.Size(80, 35);
            this.btCreateAndClose.TabIndex = 4;
            this.btCreateAndClose.Text = "Создать и закрыть";
            this.btCreateAndClose.UseVisualStyleBackColor = true;
            this.btCreateAndClose.Click += new System.EventHandler(this.BtCreateAndClose_Click);
            // 
            // tbFullName
            // 
            this.tbFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFullName.Location = new System.Drawing.Point(12, 25);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(277, 20);
            this.tbFullName.TabIndex = 5;
            // 
            // tbShortName
            // 
            this.tbShortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShortName.Location = new System.Drawing.Point(12, 77);
            this.tbShortName.Name = "tbShortName";
            this.tbShortName.Size = new System.Drawing.Size(277, 20);
            this.tbShortName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Полное название вида занятия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Краткое название вида занятия";
            // 
            // AddTypesOfOccupations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 161);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbShortName);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.btCreateAndClose);
            this.Controls.Add(this.btCreateAndClean);
            this.Controls.Add(this.btCancel);
            this.MinimumSize = new System.Drawing.Size(316, 200);
            this.Name = "AddTypesOfOccupations";
            this.Text = "Добавить вид занятия";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCreateAndClean;
        private System.Windows.Forms.Button btCreateAndClose;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbShortName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}