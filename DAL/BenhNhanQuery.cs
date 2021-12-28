using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class BenhNhanQuery
    {
        public static IQueryable<BenhNhanNameDto> MapBenhNhan(this IQueryable<BenhNhan> benhNhan)
        {
            return benhNhan.Select(b => new BenhNhanNameDto
            {
                Name = b.BenhAns.Select(x => x.Benh.Name).AsEnumerable().Aggregate((x,y) => (x + ", " + y))
            });
        }
    }
}
