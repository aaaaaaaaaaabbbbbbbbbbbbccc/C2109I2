using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaBaiTapvenha.entity
{
    internal class Product
    {
        internal string Id;

        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Mfg { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(ID)}={ID}, {nameof(Name)}={Name}, {nameof(Price)}={Price.ToString()}, {nameof(Quantity)}={Quantity.ToString()}, {nameof(Mfg)}={Mfg.ToString()}}}";
        }
    }
}
