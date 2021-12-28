namespace QLBenhNhan
{
    partial class Form1
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
            this.PanelButton = new System.Windows.Forms.Panel();
            this.ButtonBenhNhan = new System.Windows.Forms.Button();
            this.ButtonBenhAn = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.PanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.ButtonBenhNhan);
            this.PanelButton.Controls.Add(this.ButtonBenhAn);
            this.PanelButton.Controls.Add(this.ButtonAdd);
            this.PanelButton.Location = new System.Drawing.Point(0, 0);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(153, 399);
            this.PanelButton.TabIndex = 0;
            // 
            // ButtonBenhNhan
            // 
            this.ButtonBenhNhan.Location = new System.Drawing.Point(0, 0);
            this.ButtonBenhNhan.Name = "ButtonBenhNhan";
            this.ButtonBenhNhan.Size = new System.Drawing.Size(154, 100);
            this.ButtonBenhNhan.TabIndex = 0;
            this.ButtonBenhNhan.Text = "Danh sách bệnh nhân";
            this.ButtonBenhNhan.UseVisualStyleBackColor = true;
            this.ButtonBenhNhan.Click += new System.EventHandler(this.ButtonBenhNhan_Click);
            // 
            // ButtonBenhAn
            // 
            this.ButtonBenhAn.Location = new System.Drawing.Point(0, 212);
            this.ButtonBenhAn.Name = "ButtonBenhAn";
            this.ButtonBenhAn.Size = new System.Drawing.Size(154, 100);
            this.ButtonBenhAn.TabIndex = 2;
            this.ButtonBenhAn.Text = "Thêm Bệnh án";
            this.ButtonBenhAn.UseVisualStyleBackColor = true;
            this.ButtonBenhAn.Click += new System.EventHandler(this.ButtonBenhAn_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(0, 106);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(154, 100);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Thêm bệnh nhân";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.Location = new System.Drawing.Point(152, 0);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(731, 399);
            this.PanelDesktop.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 400);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.PanelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelButton;
        private System.Windows.Forms.Button ButtonBenhAn;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.Button ButtonBenhNhan;
    }
}

