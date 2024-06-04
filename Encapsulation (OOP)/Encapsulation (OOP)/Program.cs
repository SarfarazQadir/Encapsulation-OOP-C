using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation__OOP_
{
    internal class Encapsulatte
    {
        int product_value = 2341;

        public void setter(int value)
        {
            if (product_value < 0)
            {
                Console.WriteLine("Enter a positive value");
            }
            else
            {
                product_value = value;
            }
        }

        public void getter_method()
        {
            Console.WriteLine("Your amount is" + product_value);
        }
    }

    internal class Encapsulation{
        int product_amount = 10;

        public int get_set
        {
            set{
                if (value < 0)
                {
                    Console.WriteLine("PLease Enter A Positive Number");
                }
                else
                {
                    product_amount = value;
                }
               }
            get
            {
                return product_amount;
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Encapsulatte obj = new Encapsulatte();
            Encapsulation obj1 = new Encapsulation();
            obj.setter(5500);
            obj.getter_method();
            Console.ReadLine();
            obj1.get_set=4345423;
            Console.WriteLine("Your Get Set Amount is {0} " ,obj1.get_set);
            Console.ReadKey();
        }
    }
}
