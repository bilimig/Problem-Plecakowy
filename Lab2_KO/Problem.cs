using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_KO
{
    internal class Problem
    {
        private int _n;
        public List<Item> items = new List<Item>();
        private int _capasity;
        public List<Item> _sorted_items = new List<Item>();
        public Result _result;
        public List<int> _result_items = new List<int>();
        public Problem(int seed, int n) 
        { 
            _n = n;
            Random random = new Random(seed);
            for (int i = 0; i < _n; i++)
            {
                int v = random.Next(10);
                int w = random.Next(10);
                Item temp_item = new Item(w, v);
                items.Add(temp_item);
            }
            
        }

        public bool IsFitting(Item item)
        {

            if (item.weight <= _capasity) 
            {
                _capasity -= item.weight;
                return true; 
            } 
            return false; 
        }
        public void Solve(int capasity)
        {
           
            _capasity = capasity;
            _sorted_items = items.OrderByDescending(item => item.ratio).ToList();
            int i = 0;
            foreach ( var item in _sorted_items)
            {
                
                if(capasity == 0)
                {
                    break;
                }
                if (IsFitting(item))
                {
                    _result_items.Add(i);
                }
                i += 1;
            }
            _result = new Result(_result_items);
        }
        public void SeeResult()
        {
            int endweight = 0;
            int endvalue = 0;
            foreach (var item in _result_items)
            {
                Console.WriteLine("Item number: {0} has value: {1} and weight: {2}", item, _sorted_items[item].value, _sorted_items[item].weight);
                endvalue += _sorted_items[item].value;
                endweight += _sorted_items[item].weight;
            }
            Console.WriteLine(endvalue.ToString(), endweight.ToString());
        }
                
    }


}

