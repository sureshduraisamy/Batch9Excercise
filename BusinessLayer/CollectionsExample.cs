using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    //Entity /model / DTo
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string[] Ingrediants { get; set; }
    }



    public class CollectionsExample
    {

        public void ArrayExample()
        {
            int[] studentNumber = new int[10];
            int[] studentNumbers = { 10, 23, 45 };


            studentNumber[0] = 20;
            foreach(int a in studentNumbers)
            {
                Console.WriteLine(a);
                    
            }
        }


        public void GenericCollection()
        {
            List<int> studentNumbers = new List<int>();
            studentNumbers[0] = 12;
            studentNumbers[1] = 13;
            studentNumbers.Add(14);
            studentNumbers.AddRange(studentNumbers);
            studentNumbers.Remove(12);
            studentNumbers.RemoveAt(0);
            Console.WriteLine(studentNumbers.Count);

            foreach (int a in studentNumbers)
            {
                Console.WriteLine(a);

            }

            Product[] productsArray = new Product[5];

            Product prod1 = new Product();
            prod1.Name = "Rice";
            prod1.Price = 1546.78;
            //prod1.Ingrediants = new string[2];
            prod1.Ingrediants = new string[] { "Oil", "Rice" };
            prod1.Ingrediants[0] = "Oil";
            prod1.Ingrediants[1] = "Rice";

            productsArray[0] = prod1;

            productsArray[1] = new Product();
            productsArray[1].Name = "oil";
            productsArray[1].Price = 456.23;



            List<Product> productList = new List<Product>();
            productList.Add(prod1);
            Product prod3 = new Product();
            productList.Add(prod3);

            foreach(Product prod in productList)
            {
                Console.WriteLine(prod.Name);
            }

            Console.WriteLine(productList[0].Name);
            Console.WriteLine(productList[1].Price);

            Stack<int> st = new Stack<int>();


        }


        public void NonGenericCollection()
        {
            ArrayList studentNumbers = new ArrayList();

            studentNumbers.Add(10);
            studentNumbers.Add("hai");
            studentNumbers.Add(new Product { Name = "oil" , Price = 45.56 });


            foreach(var a in studentNumbers)
            {
                if( a is int)
                {

                }else if (a is string)
                {

                }else if (a is Product)
                {

                }
            }


            Stack stcklist = new Stack();
        }
    }
}
