using System;

namespace OneSoldierInTheField
{
    //1197++
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] move = new string[n];
            for (int i = 0; i < n; i++)
            {
                move[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
            	var x = (int) (move[i][0] - 'a');
            	var y = (int) (move[i][1] - '1');

            	var mp = new int [] {-1, 1};
            	var sp = new int [] {2, 1};

            	var sum = 0;

            	for (int k = 0; k < sp.Length; ++k)
            	{
            		for (int j = 0; j < 4; ++ j)
            		{
                        var m1 = sp[k];
                        var m2 = mp[j / 2];

                        var x1 = x + m2 * m1;
	            		var y1 = y + mp[j % 2]*sp[(k + 1) % sp.Length];
	
	            		if (x1 >= 0 && x1 < 8 && y1 >= 0 && y1 < 8)
	            		{
	            			++sum;
	            		}
            		}

            	}
               Console.WriteLine(sum);
            }
        }
    }
}
