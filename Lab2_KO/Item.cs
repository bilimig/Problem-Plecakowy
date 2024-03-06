using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_KO
{
    internal class Item
    {
        public int weight;
        public int value;
        public decimal ratio; 
        public Item(int w, int v)
        {
            weight = w;
            value = v;
            ratio = (decimal)value / weight;
        }


    }
}
