using System;
using System.Collections.Generic;


namespace Arrayfunction
{
    class Arraycondition
    {

        public void Arrayfun()
        {

            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int A = 0; A < 10; A++)
            {
                Console.WriteLine(num[A]);

            }





        }

    }
    class Studentdetails
    {
        public string[] student = new string[10];


        public void StudentData()
        {
            Console.WriteLine("enter student names");
            for (int info = 0; info < 10; info++)
            {
                student[info] = Console.ReadLine();
            }
            Console.WriteLine("these are the students of class ");
            for (int info = 0; info < 10; info++)
            {
                Console.WriteLine(student[info]);
            }
        }


    }
    class Summing 
    { 
         public  int Addition(int a ,int b ,int c ,int d ,int e ,int f,int g,int h,int z,int j)
        {
          int[] number = new int[10] { a,b,c,d,e,f,g,h,z,j};

         int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                  sum = sum + number[i];

            }
            return(sum);
        }
    }
    class Productsales

    {
        int sum = 0;
        public void Monthlysales()
        {
            string[] months = new string[4];
            Console.WriteLine("enter the months");
            for (int i = 0; i<4; i++)
            {
                
                months[i] = Console.ReadLine();

            }
            int[] sales = new int[4];
                Console.WriteLine("enter the salesamount");
            for (int i = 0; i < 4; i++)
            {
                
                sales[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for(int i = 0; i < 4; i++)
            {
                var total = months[i] +"="+ sales[i];
                Console.WriteLine(total);
               
            }
            Console.WriteLine("total revenue =");
            for (int i = 0; i < 4; i++)
            {
                
                
                sum = sum + sales[i];
                
            }
            Console.WriteLine(sum);
        }
    }
}
