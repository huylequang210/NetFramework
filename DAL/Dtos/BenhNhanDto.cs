using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class BenhNhanDto
    {
        public int BenhNhanId { get; set; }
        public string Name { get; set; }

        public string Benh { get; set; }

        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string HomeTown { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string InsuranceNumber { get; set; }
        public string IDCard { get; set; }
    }
}
