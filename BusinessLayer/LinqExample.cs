using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LinqExample
    {

        public void LinqAPIMethods()
        {
            List<int> studentNumbers = new List<int>();
            studentNumbers[0] = 12;
            studentNumbers[1] = 13;
            studentNumbers.Add(14);
            studentNumbers.AddRange(studentNumbers);

            bool isfound = false;
            foreach (int a in studentNumbers)
            {

                if (a == 12)
                {
                    isfound = true;
                    break;
                }
            }

            if (isfound)
                Console.WriteLine("Found");
            else
                Console.WriteLine("Not Found");

            if (studentNumbers.Exists(item => item == 12))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");

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


            var value = productsArray.ToList().Exists(item => item.Name == "Cake" || item.Name == "OIL");
            int count = productsArray.ToList().Where(item => item.Name == "oil").Count();
            List<Product> list = productsArray.ToList().Where(item => item.Name == "oil").ToList();

           

            //Find
            //FindALL

            //First
            //Firtordefault

            //foreach
            //sum
            //min
            //max
            //avg

            //orderby
            //orderbydecending

            //select
            //selectmany

            //single
            //singleordefault

            //Any
            //All




        }
    }
}
