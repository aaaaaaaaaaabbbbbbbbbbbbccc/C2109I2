using BTVN1_.entity;
using BTVN1_.Helper;
using BTVN1_.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_.Dal
{
    internal class DalProduct : IProduct
    {


        public List<Product> list { get; set; } = new();   
        public int MaSinhVien { get; private set; }

        public void AddS()
        {
            var n = Validate<int>.Input("Please enter number of list"); 
            for (int i = 0; i < n; i++)
            {
                Product pro = new();
                pro.MaSinhVien = Validate<int>.Input("Please enter MaSinhVien");
                pro.TenSinhVien = Validate<string>.Input("Please enter TenSinhVien");
                pro.GioiTinh = Validate<Boolean>.Input("Please enter GioiTinh");
                pro.NgaySinh = Validate<DateTime>.Input("Please enter NgaySinh");
                list.Add(pro);
            }
        }
        
        public void Show()
        {
            list.ForEach(Console.WriteLine);
        }

        public void Delete()
        {
           
            int MaSinhVien = Validate<int>.Input("Please enter number MaSinhVien to delete");
            var t = list.Where(stu => stu.MaSinhVien == MaSinhVien).ToList();
            if (t.Count() == 0)
            {
                Console.WriteLine("This student was not found!");
            }         
            t.ToList().ForEach(Console.WriteLine);
            foreach (var i in t) list.Remove(i) ;
        }
    }
}
