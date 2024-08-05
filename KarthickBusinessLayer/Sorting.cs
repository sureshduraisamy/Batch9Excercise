using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarthickBusinessLayer
{
  public  class Sorting
    {
        int[] var =new int[]{2,12,3,23,1,21};
        public void BubbleSort() {
            int n = var.Length;
            for (int i=0;i<n-1;i++)
            {
                for (int j = 0; j < n - 1 -i; j++)
                {
                    if (var[j]>var[j+1]) {
                        int temp = var[j];
                        var[j] = var[j + 1];
                        var[j + 1] = temp;
                    }
                    
                }
            }

            foreach (int t in var)
            {
                Console.WriteLine(t);
            }
        }
       
    }
}
