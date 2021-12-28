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
    public partial class BenhNhanForm : Form
    {
        public BenhNhanForm()
        {
            InitializeComponent();

            using (var context = new BenhNhanContext())
            {
                var benhnhans = context.BenhNhans
                    .Select(b => new {
                        b.BenhNhanId,
                        b.Name,
                        b.Age,
                        b.BirthDate,
                        b.InsuranceNumber,
                        b.IDCard,
                        b.PhoneNumber,
                        b.Address,                     
                        ListBenh = b.BenhAns.Select(x => x.Benh.Name),
                        b.HomeTown
                    })
                    .AsEnumerable()
                    .Select(b => new BenhNhanDto()
                    {
                        BenhNhanId = b.BenhNhanId,
                        Name = b.Name,
                        Age = b.Age,
                        BirthDate = b.BirthDate,
                        InsuranceNumber = b.InsuranceNumber,
                        PhoneNumber = b.PhoneNumber,
                        IDCard = b.IDCard,
                        Address = b.Address,
                        Benh = string.Join(",", b.ListBenh),
                        HomeTown = b.HomeTown
                    })
                    .ToList();

                GridBenhNhan.DataSource = benhnhans;
            }
        }

        private void GridBenhNhan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int benhNhanId = Int32.Parse(GridBenhNhan.CurrentRow.Cells["BenhNhanId"].Value.ToString());
            int columnIndex = GridBenhNhan.CurrentCell.RowIndex;
            var name = GridBenhNhan.Rows[columnIndex].Cells["Name"].Value.ToString();
            var age = Convert.ToInt32(GridBenhNhan.Rows[columnIndex].Cells["Age"].Value);
            var birthDate = Convert.ToDateTime(GridBenhNhan.Rows[columnIndex].Cells["BirthDate"].Value);
            var insuranceNumber = GridBenhNhan.Rows[columnIndex].Cells["InsuranceNumber"].Value.ToString();
            var phoneNumber = GridBenhNhan.Rows[columnIndex].Cells["PhoneNumber"].Value.ToString();
            var iDCard = GridBenhNhan.Rows[columnIndex].Cells["IDCard"].Value.ToString();
            var address = GridBenhNhan.Rows[columnIndex].Cells["Address"].Value.ToString();

            using (var context = new BenhNhanContext())
            {
                var benhNhan = context.BenhNhans
                    .SingleOrDefault(x => x.BenhNhanId == benhNhanId);
                benhNhan.Name = name;
                benhNhan.Age = age;
                benhNhan.BirthDate = birthDate;
                benhNhan.InsuranceNumber = insuranceNumber;
                benhNhan.PhoneNumber = phoneNumber;
                benhNhan.IDCard = iDCard;
                benhNhan.Address = address;
                context.SaveChanges();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (GridBenhNhan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn bệnh nhân");
                return;
            }

            var benhNhanId = GridBenhNhan.SelectedRows[0].Cells["BenhNhanId"].Value;

            try
            {
                using (var context = new BenhNhanContext())
                {
                    var benhNhan = context.BenhNhans.Find(benhNhanId);
                    context.BenhNhans.Remove(benhNhan);
                    context.SaveChanges();
                    MessageBox.Show("Xóa bệnh nhân thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
