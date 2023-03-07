using SuaBaiTapvenha.entity;
using SuaBaiTapvenha.Helper;
using SuaBaiTapvenha.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaBaiTapvenha.Dal
{
    internal class DalProduct : IProduct
    {
        public List<Product> list { get; set; } = new();
        public void Add()
        {
            var n = Validate<int>.Input("Please enter number of list");
            for (int i = 0; i < n; i++)
            {
                Product pro = new();
                pro.Id = Validate<string>.Input("Please enter id");
                pro.Name = Validate<string>.Input("Please enter name");
                pro.Price = Validate<double>.Input("Please enter double");
                pro.Quantity = Validate<int>.Input("Please enter quantity");
                pro.Mfg = Validate<DateTime>.Input("Please enter mfg");
                list.Add(pro);
            }
        }
        public void Show()
        {
            list.ForEach(Console.WriteLine);
        }
    }
}
