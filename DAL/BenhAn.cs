using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BenhAn
    {
        public int BenhAnId { get; set; }
        public string Note { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EndDate { get; set; }

        // relationship
        public int BenhNhanId { get; set; }
        public int BenhId { get; set; }
        public Benh Benh { get; set; }
    }
}
