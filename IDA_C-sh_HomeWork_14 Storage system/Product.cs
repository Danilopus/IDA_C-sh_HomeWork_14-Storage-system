using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_HomeWork_14_Storage_system
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
