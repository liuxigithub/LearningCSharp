//for循环
using System;

namespace sum_ts {
    class sum_me {
        static public void Main() {
            int N, j, k, SUM = 0;
            Console.WriteLine("input N ");
            N = Convert.ToInt32(Console.ReadLine());
            // for loop
            for (int i = 0; i < N+1; i++)
            {
                SUM += i;
            }
            Console.WriteLine("sum = {0} (for)",SUM);
            
            j = 0; SUM = 0;
            // while loop
            while (j<N+1) {
                SUM += j;
                j++;
            }
            Console.WriteLine("sum = {0} (while)",SUM);
            
            k = 0; SUM = 0;
            do {
                SUM += k;
                k++;
            }
            while (k<N+1);
            Console.WriteLine("sum = {0} (do while)",SUM);
            Console.ReadLine();
        }
            
    }
}