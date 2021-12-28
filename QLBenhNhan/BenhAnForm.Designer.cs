namespace QLBenhNhan
{
    partial class BenhAnForm
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
            this.TextNote = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.BoxBenh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextStart = new System.Windows.Forms.TextBox();
            this.TextEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GridBenhNhan = new System.Windows.Forms.DataGridView();
            this.ButtonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // TextNote
            // 
            this.TextNote.Location = new System.Drawing.Point(26, 25);
            this.TextNote.Name = "TextNote";
            this.TextNote.Size = new System.Drawing.Size(155, 20);
            this.TextNote.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(23, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(86, 13);
            this.Label.TabIndex = 1;
            this.Label.Text = "Ghi chú bệnh án";
            // 
            // BoxBenh
            // 
            this.BoxBenh.FormattingEnabled = true;
            this.BoxBenh.Location = new System.Drawing.Point(26, 74);
            this.BoxBenh.Name = "BoxBenh";
            this.BoxBenh.Size = new System.Drawing.Size(155, 21);
            this.BoxBenh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn bệnh";
            // 
            // TextStart
            // 
            this.TextStart.Location = new System.Drawing.Point(26, 136);
            this.TextStart.Name = "TextStart";
            this.TextStart.Size = new System.Drawing.Size(122, 20);
            this.TextStart.TabIndex = 4;
            // 
            // TextEnd
            // 
            this.TextEnd.Location = new System.Drawing.Point(26, 196);
            this.TextEnd.Name = "TextEnd";
            this.TextEnd.Size = new System.Drawing.Size(122, 20);
            this.TextEnd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày kết thúc";
            // 
            // GridBenhNhan
            // 
            this.GridBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBenhNhan.Location = new System.Drawing.Point(232, 25);
            this.GridBenhNhan.Name = "GridBenhNhan";
            this.GridBenhNhan.Size = new System.Drawing.Size(386, 298);
            this.GridBenhNhan.TabIndex = 8;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(26, 247);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(110, 36);
            this.ButtonAdd.TabIndex = 9;
            this.ButtonAdd.Text = "Thêm bệnh án";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // BenhAnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 400);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.GridBenhNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextEnd);
            this.Controls.Add(this.TextStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxBenh);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TextNote);
            this.Name = "BenhAnForm";
            this.Text = "BenhAn";
            ((System.ComponentModel.ISupportInitialize)(this.GridBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextNote;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.ComboBox BoxBenh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextStart;
        private System.Windows.Forms.TextBox TextEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridBenhNhan;
        private System.Windows.Forms.Button ButtonAdd;
    }
}