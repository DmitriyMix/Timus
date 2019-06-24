using System;
using System.Collections.Generic;

namespace Donald1
{
    class Program
    {
       
        static void Main()
        {
            int pos = 1;
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            


            Dictionary<string, int> box1 = new Dictionary<string, int>
            {
                { "Alice", 1},
                {"Ariel", 1 },
                {"Aurora", 1 },
                {"Phil", 1 },
                {"Peter", 1 },
                {"Olaf", 1 },
                {"Phoebus", 1 },
                {"Ralph", 1 },
                {"Robin", 1 },

                { "Bambi", 2 },
                {  "Belle", 2 },
                {  "Bolt", 2 },
                {  "Mulan", 2 },
                {  "Mowgli", 2 },
                {  "Mickey", 2 },
                {  "Silver", 2 },
                {  "Simba", 2 },
                {  "Stitch", 2 },

                {  "Dumbo", 3 },
                {  "Genie", 3 },
                {  "Jiminy", 3 },
                {  "Kuzko", 3 },
                { "Kida", 3 },
                { "Kenai", 3 },
                {  "Tarzan", 3 },
                {  "Tiana", 3 },
                {  "Winnie", 3 }
        };
            var s = "Winnie";
            var z = "Simba";
            var w = "Aurora"; 
            var boxNumber = box1[s];
            var boxNumber1 = box1[z];
            var boxNumber2= box1[w];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                foreach (string c in box1.Keys)
                {
                    if (c == name && boxNumber == 3 && pos == 3)
                    {
                        
                        sum += 2;
                        pos--;
                    }
                    else if (c == name && boxNumber1 == 2 && pos == 2)
                    {
                        
                        sum += 1;
                        
                    }
                    else if(c == name && boxNumber2 == 1 && pos == 1)
                    {
                       
                        sum += 0;
                        pos++;
                    }
                    //if (c.Contains(name))
                    {
                        //foreach(var u in box1.Values)
                        {
                            //if(boxNumber2 == 1)
                            {

                            }
                            //if (u == 1 && pos == 1)
                            {
                                //sum += 0;
                                //if()
                                {
                                    
                                }
                            }
                            
                        }

                    }
                    
                }
            }
            Console.WriteLine(sum);
        }
    }
}




