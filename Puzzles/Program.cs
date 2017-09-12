using System;
using System.Linq;
using System.Collections.Generic;
namespace Puzzles
{
    class Program
    {
       
       public static void RandomArray(){
           Random num = new Random();
           int[] arr = new int[10];
           for(int i=0; i<arr.Length; i++){
               arr[i]= num.Next(5, 25);
            
           }
            int maxVal =0;
            maxVal = arr.Max();
            int MinVal =0;
            MinVal = arr.Min();
            int SumVal =0;
            SumVal =arr.Sum();
            Console.WriteLine("Max Value:{0} \nMin Value:{1}\n The sum is:{2}", maxVal, MinVal, SumVal);
          
        }

        public string TossCoin() {
            Random rand = new Random();
            Console.WriteLine("Tossing a Coin!");
            string result = "Tails";
            if(rand.Next() == 0) {
                result = "Heads";
            }
            Console.WriteLine(result);
            return result;
        }

        public string Names(){
            string[] name = new string[]{
                "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
            };
            Random j = new Random();
            for (int i = 0; i < name.Length -1; i++){

                int rand = j.Next(i + 1, name.Length-1);
                string tmp = name[i];
                name[i] = name[rand];
                name[rand] = tmp;
                Console.WriteLine(name[i]);
             }
             Console.WriteLine(name[name.Length -1]);
        List<string> names = new List<string>();
        foreach(var NameList in names){
            names.Add(NameList);
        }
        return names.ToArray();

        }
     
       
        static void Main(string[] args)
        {
            
            //RandomArray();
            
            
        }

        
    }
}
