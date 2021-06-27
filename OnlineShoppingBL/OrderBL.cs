using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingBL
{
    public class OrderBL
    {
        public int housewares, electronics, sports;
        public char orderOptions;
        public void DisplayCategories()
        {
            Console.WriteLine("Pick a letter from the categories below: ");
            Console.WriteLine("a - Housewares");
            Console.WriteLine("b - Electronics");
            Console.WriteLine("c - Sports");
        }
        public void Order()
        {
            orderOptions = Console.ReadLine()[0];
            switch (Char.ToLower(orderOptions))
            {
                case 'a':
                    Console.WriteLine("1-Plate");
                    Console.WriteLine("2-Spoon and Fork");
                    Console.WriteLine("3-Glass");
                    housewares = Convert.ToInt32(Console.ReadLine());
                    if (housewares.Equals(1))
                    {
                        Console.WriteLine("Ordered Successfully");
                        Console.WriteLine("Package will arrive within 7-14 days or earlier guaranteed");
                    }
                    else if (housewares.Equals(2))
                    {
                        Console.WriteLine("Ordered Successfully");
                        Console.WriteLine("Package will arrive within 7-14 days or earlier guaranteed");
                    }
                    else if (housewares.Equals(3))
                    {
                        Console.WriteLine("Ordered Successfully");
                        Console.WriteLine("Package will arrive within 7-14 days or earlier guaranteed");
                    }
                    else
                        Console.WriteLine("Invalid Keyword Please Try again.");

                    break;
                case 'b':
                    Console.WriteLine("1-Earphone");
                    Console.WriteLine("2-Mouse");
                    Console.WriteLine("3-Speaker");
                    electronics = Convert.ToInt32(Console.ReadLine());
                    if (electronics.Equals(1))
                    {
                        Console.WriteLine("Ordered Successfully");
                        Console.WriteLine("Package will arrive within 7-14 days or earlier guaranteed");
                    }
                    else if (electronics.Equals(2))
                    {
                        Console.WriteLine("Ordered Successfully");
                        Console.WriteLine("Package will arrive within 7-14 days or earlier guaranteed");
                    }
                    else if (electronics.Equals(3))
                    {
                        Console.WriteLine("Ordered Successfully");
                        Console.WriteLine("Package will arrive within 7-14 days or earlier guaranteed");
                    }
                    else
                        Console.WriteLine("Invalid Keyword Please Try again.");
                    break;
                case 'c':
                    Console.WriteLine("1-Ball");
                    Console.WriteLine("2-Net");
                    Console.WriteLine("3-Shoes");
                    sports = Convert.ToInt32(Console.ReadLine());
                    if (sports.Equals(1))
                    {
                        Console.WriteLine("Ordered Successfully");
                        Console.WriteLine("Package will arrive within 7-14 days or earlier guaranteed");
                    }
                    else if (sports.Equals(2))
                    {
                        Console.WriteLine("Ordered Successfully");
                        Console.WriteLine("Package will arrive within 7-14 days or earlier guaranteed");
                    }
                    else if (sports.Equals(3))
                    {
                        Console.WriteLine("Ordered Successfully");
                        Console.WriteLine("Package will arrive within 7-14 days or earlier guaranteed");
                    }
                    else
                        Console.WriteLine("Invalid Keyword Please Try again.");
                    break;
             
            }
        }
    }
}