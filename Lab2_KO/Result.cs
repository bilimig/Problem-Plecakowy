using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_KO
{
    internal class Result
    {
        public List<string> items;

        public Result(List<int> result) 
        {
            if(result != null)
            {
                items = result.ConvertAll<string>(x => x.ToString());
            }
            
        }

    }
}
