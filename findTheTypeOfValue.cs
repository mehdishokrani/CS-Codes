using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter any value: ");
                string value = Console.ReadLine();
                Console.WriteLine("Press 1 for String\nPress 2 for Integer\nPress 3 for Boolean");
                int type = Convert.ToInt32(Console.ReadLine());

                switch (type)
                {
                    case 1:
                        bool flag = true;
                        foreach (char c in value)
                        {
                            if (char.IsLetter(c))
                            {
                                flag = true;
                                break;
                            }
                            flag = false;
                           
                        }
                        if(flag)
                        Console.WriteLine("The value is {0} and IS of type STRING", value);
                        else
                            Console.WriteLine("The value is {0} and is NOT of type STRING", value);
                        break;
                    case 2:
                        if (int.TryParse(value, out _))
                            Console.WriteLine("The value {0} is of type INTEGER", value);
                        else
                            Console.WriteLine("The value {0} is NOT type INTEGER", value);
                        break;
                    case 3:
                        if (bool.TryParse(value.ToLower(), out _))
                            Console.WriteLine("The value {0} is of type Boolean", value);
                        else
                            Console.WriteLine("The value {0} is NOT type Boolean", value);
                        break;

                    default:
                        Console.WriteLine("The value {0} is NOT of above mentioned types", value);
                        break;
                }


                Console.ReadKey();
            }
        }
    }
}
