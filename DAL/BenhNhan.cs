using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BenhNhan
    {
        public int BenhNhanId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }
        public string HomeTown { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string InsuranceNumber { get; set; }
        public string IDCard { get; set; }

        public ICollection<BenhAn> BenhAns { get; set; }
    }
}
