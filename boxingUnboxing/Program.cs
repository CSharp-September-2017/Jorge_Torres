using System;
using System.Collections.Generic;
using System.Linq;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> mixdata = new List <object>();
            mixdata.Add(7);
            mixdata.Add(28);
            mixdata.Add(-1);
            mixdata.Add(true);
            mixdata.Add("chair");
            int total =0;
            foreach (var list in mixdata)
            {
                if (list is int){
                    total += (int)list;
                    
                }
                // Console.WriteLine(item);
            }
            Console.WriteLine("The total from the int list: {0}", total);
            
        }
    }
}
