using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTests")]
[assembly: InternalsVisibleTo("Gui")]

namespace Lab2_KO
{
    internal class Problem
    {
        private int _n;
        public List<Item> items = new List<Item>();
        private int _capacity;
        public List<Item> _sorted_items = new List<Item>();
        public Result _result;
        public List<int> _result_items = new List<int>();
        public int _endweight;
        public int _endvalue;
        public Problem(int seed, int n) 
        { 
            _n = n;
            Random random = new Random(seed);
            for (int i = 0; i < _n; i++)
            {
                int v = random.Next(9);
                v++;
                int w = random.Next(9);
                w++;
                Item temp_item = new Item(w, v);
                items.Add(temp_item);
            }
            
        }

        public bool IsFitting(Item item)
        {

            if (item.weight <= _capacity) 
            {
                _capacity -= item.weight;
                return true; 
            } 
            return false; 
        }
        public void Solve(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException("Capacity cannot be negative.", nameof(capacity));
            }

            _capacity = capacity;
            if (items == null)
            {
                throw new NullReferenceException("List of items cannot be null.");
            }
            _sorted_items = items.OrderByDescending(item => item.ratio).ToList();
            int i = 0;
            foreach (var item in _sorted_items)
            {
                if (capacity == 0)
                {
                    break;
                }
                if (IsFitting(item))
                {
                    _result_items.Add(i);
                }
                i++;
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
            _endvalue = endvalue;
            _endweight = endweight;
            Console.WriteLine($"Total value: {endvalue}, Total weight: {endweight}");
        }
    }


}

