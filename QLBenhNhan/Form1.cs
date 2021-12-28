using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace QLBenhNhan
{
    public partial class Form1 : Form
    {
        private Button currentPanelButton = new Button();
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            ButtonBenhNhan.Font = new Font("Microsoft Sans Serif", 16);
            ButtonBenhNhan.ForeColor = Color.DarkGray;
            ButtonBenhNhan.Cursor = Cursors.Hand;
            ButtonAdd.Font = new Font("Microsoft Sans Serif", 16);
            ButtonAdd.Cursor = Cursors.Hand;
            ButtonBenhAn.Font = new Font("Microsoft Sans Serif", 16);
            ButtonBenhAn.Cursor = Cursors.Hand;

            OpenChildForm(new BenhNhanForm());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            this.PanelDesktop.Controls.Add(childForm);
            this.PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                DeactiveButton();
                if (currentPanelButton != (Button)btnSender)
                {
                    currentPanelButton = (Button)btnSender;
                    currentPanelButton.ForeColor = Color.DarkGray;
                    currentPanelButton.Font = new Font("Microsoft Sans Serif", 16);
                }
            }
        }

        private void DeactiveButton()
        {
            foreach (Control control in PanelButton.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.ForeColor = Color.Black;
                    control.Font = new Font("Microsoft Sans Serif", 15);
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new AddBenhNhan());
        }

        private void ButtonBenhAn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new BenhAnForm());
        }

        private void ButtonBenhNhan_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new BenhNhanForm());
        }
    }
}
