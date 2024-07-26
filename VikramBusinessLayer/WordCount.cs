using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikramBusinessLayer
{
    public class WordCount
    {
        string A = "hi i am vikram";

        public void source()
        {
            string[] result = A.Split(' ');
            Console.WriteLine(result.Length);

        }
    }
}
public class countingword
{
    string A = "hi i am vikram";
    int count;
    public void countsword()
    {
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i]==' ')
            {
                count++;
            }
        }
        Console.WriteLine(count + 1);
    }

}


