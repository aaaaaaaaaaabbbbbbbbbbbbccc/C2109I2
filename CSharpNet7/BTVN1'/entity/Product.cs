using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_.entity
{
    internal class Product
    {
        public int MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public Boolean GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(MaSinhVien)}={MaSinhVien.ToString()}, {nameof(TenSinhVien)}={TenSinhVien}, {nameof(GioiTinh)}={GioiTinh.ToString()}, {nameof(NgaySinh)}={NgaySinh.ToString()}}}";
        }
    }
}
