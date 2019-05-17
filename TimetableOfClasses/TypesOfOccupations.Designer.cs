namespace TimetableOfClasses
{
	partial class TypesOfOccupations
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
            this.DG_TypesOfOccupations = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TypesOfOccupations)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_TypesOfOccupations
            // 
            this.DG_TypesOfOccupations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_TypesOfOccupations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_TypesOfOccupations.Location = new System.Drawing.Point(9, 9);
            this.DG_TypesOfOccupations.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.DG_TypesOfOccupations.Name = "DG_TypesOfOccupations";
            this.DG_TypesOfOccupations.Size = new System.Drawing.Size(557, 307);
            this.DG_TypesOfOccupations.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(491, 322);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Location = new System.Drawing.Point(329, 322);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(410, 322);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 3;
            this.btChange.Text = "Изменить";
            this.btChange.UseVisualStyleBackColor = true;
            // 
            // TypesOfOccupations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 357);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.DG_TypesOfOccupations);
            this.Name = "TypesOfOccupations";
            this.Text = "Виды занятий";
            ((System.ComponentModel.ISupportInitialize)(this.DG_TypesOfOccupations)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView DG_TypesOfOccupations;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btChange;
    }
}