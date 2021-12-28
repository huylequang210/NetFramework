using DAL;
using DAL.Dtos;
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
    public partial class BenhAnForm : Form
    {
        public BenhAnForm()
        {
            InitializeComponent();

            using (var context = new BenhNhanContext())
            {
                var benhs = context.Benhs.ToList();

                var benhNhan = context.BenhNhans.
                    Select(y => new BenhNhanNameDto {
                        Id = y.BenhNhanId,
                        Name = y.Name,
                        InsuranceNumber = y.InsuranceNumber,
                        IDCard = y.IDCard
                    }).ToList();

                BoxBenh.DataSource = benhs;
                BoxBenh.DisplayMember = "Name";
                BoxBenh.ValueMember = "BenhId";

                GridBenhNhan.DataSource = benhNhan;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(GridBenhNhan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn bệnh nhân");
                return;
            }

            var benhNhanId = GridBenhNhan.SelectedRows[0].Cells["Id"].Value;
            var benhId = BoxBenh.SelectedValue;

            bool isStart = DateTime.TryParse(TextStart.Text, out DateTime start);
            bool isEnd = DateTime.TryParse(TextEnd.Text, out DateTime end);

            if (!isStart || !isEnd)
            {
                MessageBox.Show("Dữ liệu vào không hợp lệ");
                return;
            }

            var benhan = new BenhAn()
            {
                Note = TextNote.Text,
                StartDate = start,
                EndDate = end,
                BenhNhanId = (int)benhNhanId,
                BenhId = (int)benhId
            };

            try
            {
                using (var context = new BenhNhanContext())
                {
                    context.BenhAns.Add(benhan);
                    context.SaveChanges();
                    MessageBox.Show("Thêm bệnh nhân thành công");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
