using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhNhan
{
    public partial class AddBenhNhan : Form
    {
        public AddBenhNhan()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            bool isAge = Int32.TryParse(InputAge.Text, out int age);
            bool isDate = DateTime.TryParse(InputBirthDate.Text, out DateTime date);

            if (!isAge || !isDate) {
                MessageBox.Show("Dữ liệu vào không hợp lệ");
                return;
            }

            var benhNhan = new BenhNhan()
            {
                Name = InputName.Text,
                Age = age,
                BirthDate = date,
                HomeTown = InputHomeTown.Text,
                Address = InputAddress.Text,
                PhoneNumber = InputPhoneNumber.Text,
                InsuranceNumber = InputInsurance.Text,
                IDCard = InputIDCard.Text
            };

            try
            {
                using (var context = new BenhNhanContext())
                {
                    context.BenhNhans.Add(benhNhan);
                    context.SaveChanges();
                    MessageBox.Show("Thêm bệnh án thành công");
                }
            }
            catch
            {
                MessageBox.Show("Không thể lưu bệnh nhân");
            }
        }
    }
}
