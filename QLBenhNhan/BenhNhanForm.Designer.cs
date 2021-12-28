namespace QLBenhNhan
{
    partial class BenhNhanForm
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
            this.GridBenhNhan = new System.Windows.Forms.DataGridView();
            this.ButtonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // GridBenhNhan
            // 
            this.GridBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBenhNhan.Location = new System.Drawing.Point(2, 2);
            this.GridBenhNhan.Name = "GridBenhNhan";
            this.GridBenhNhan.Size = new System.Drawing.Size(727, 298);
            this.GridBenhNhan.TabIndex = 0;
            this.GridBenhNhan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridBenhNhan_CellValueChanged);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(47, 306);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(120, 40);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.Text = "Xóa";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // BenhNhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 375);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.GridBenhNhan);
            this.Name = "BenhNhanForm";
            this.Text = "BenhNhan";
            ((System.ComponentModel.ISupportInitialize)(this.GridBenhNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridBenhNhan;
        private System.Windows.Forms.Button ButtonDelete;
    }
}