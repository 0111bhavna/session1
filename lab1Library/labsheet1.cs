using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Library
{
    public class labsheet1
    {

        public static void Display()
        {
            int previous = 0;
            foreach (var cat in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine("Category" + cat + "has the range of" + previous + " - " + (int)cat);
                previous = (int)cat + 1;

            }

        }


        public static void Check()
        {
            int value = 0;

            do
            {
                Display();
                Console.Write("Enter a value: ");
                value = int.Parse(Console.ReadLine());
                Category userCategory = new Category();





                int i = 0;
                foreach (int cat in Enum.GetValues(typeof(Category)))
                {
                    int previousValue = 0;
                    previousValue = (int)cat + 1;
                    if (i == 0)
                    {
                        //userCategory = cat;

                        if (cat >= previousValue && cat <= value)
                        {
                            Console.WriteLine("Your category: " + userCategory);
                            previousValue = value + 1;
                        }


                    }

                }

            } while (value != 1);


        }
    }
}
