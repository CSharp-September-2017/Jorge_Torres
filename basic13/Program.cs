using System;
using System.Linq;
// pretty good job overall, Jorge. Next time I would recommend you build functions to do all the Basic 13 challenges.  It helps you understand a lot more!
namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            int max =255;
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine(i);
                
            }
            for(int x=1; x<=max; x++)
             {  
                if( x%2 == 0  ){ <--- This is checking evens actually
                    Console.WriteLine("Odd {0}", x);
                }
             }
             int sum = 0;
             for (int y=0; y<=max; y++){
                 sum += y;
                 Console.WriteLine("The number {0}, Sum {1}", y, sum);
             }

             int[] x = new int[]{
                 1,3,5,7,9,13
                };
                foreach (int item in x)
                    {
                        Console.WriteLine(item);
                    }
            int[] a = new int[3]{
                -3, -5, -7
            };
            int maxValue = a.Max();
            Console.WriteLine("The max Value in the array is: {1}",a, maxValue);
           

           int sum =0;
           int[] av = new int[]{
             2, 10, 3   
           };
           int size = av.Length;
           foreach(int val in av){
               sum += val;
                //Console.WriteLine(val);
              }
            Console.WriteLine("The sum of the array is {0}", sum);
            Console.WriteLine("The Average is {0}", sum/size);   
           

        for(int x=1; x<=255; x++){
            if(x % 2 != 0){
                int[] y = new int[]{ x }; <-- It seems like you are creating a new array of integers every time you encounter an odd number?
                foreach(int arr in y){ <-- Then you are iterating through it?  You've created as many single-value integer arrays as there are odd numbers
                    Console.WriteLine(arr);
                }
            }
        }

        int y=1;
        int[] arr = new int[]{1, 3, 5, 7};

        for (int i=0; i<arr.Length; i++){
            if(arr[i] > y){
                Console.WriteLine("Greater than Y({0}), {1}",y, arr[i]);
            }
        } <-- you need to have a total number of values greater than y don't forget.
        
        int[] x = new[]{1, 5, 10, -2};
        Console.WriteLine("The doables are:");
            for(int i=0; i<x.Length; i++){
               int res = Math.Pow(x[i], 2); <-- Are you affecting the original array x or just creating an integer and printing it? Challenge yourself to alter the array itself.
               Console.WriteLine(res);
            }
        int[] x = new[]{1, -1, 10, -2};
        Console.WriteLine("Eliminated Negative Numbers");
        for (int n = 0; n<x.Length; n++){ 
            if(x[n] < 0){ <--- Nice job handling this.  This is 'in-place'
                x[n] = 0;
            }
            Console.WriteLine(x[n]);
        }

            
        int[] x = new int[]{1, 5, 10, -2};
        int max = 0;
        max = x.Max();
        int min = x.Min();
        double av = x.Average();
        Console.WriteLine("Max value:{0},\n Min Value:{1},\n Average Value:{2}", max, min, av);

        
       //  this part is no Running Correctly 

        int[] x = new int[]{1, 5, 10, 7, -2};

            // for(int y=0; y<x.Length-1; y++){ 
            //     x[y] = x[y] + 1; <-- x[y] = x[y+1]; 
            // }    
             x[x.Length -1]=0;
            foreach(int q in x){
                Console.WriteLine(q);
            }
        */


object[] k = new object[]{-1, -3, 2};
        Console.WriteLine(" Number to string");
        for (int n = 0; n<k.Length; n++){
            if((int)k[n] < 0){
                k[n] = "Dojo";
            }
            Console.WriteLine(k[n]);
        }

    

           
        }//End of the Main
        
    }
}
