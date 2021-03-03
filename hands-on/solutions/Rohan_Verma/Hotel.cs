using System;

namespace FirstDayTraining
{
    class Program
    {

        static void Main(string[] args)
        {
            int bill = 0, itemQ;
            char wantMore = 'n';
            do
            {
                int choice;
                Console.WriteLine("1. Pizza \n2. CocaCola \n3. Pasta \n4. Garlic Bread");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How many pizzas do you want");
                        itemQ = Convert.ToInt32(Console.ReadLine());
                        bill += 200 * itemQ;
                        break;
                    case 2:
                        Console.WriteLine("How many CocaColas do you want");
                        itemQ = Convert.ToInt32(Console.ReadLine());
                        bill += 40 * itemQ;
                        break;
                    case 3:
                        Console.WriteLine("How many pastas do you want");
                        itemQ = Convert.ToInt32(Console.ReadLine());
                        bill += 120 * itemQ;
                        break;
                    case 4:
                        Console.WriteLine("How many Garlic Breads do you want");
                        itemQ = Convert.ToInt32(Console.ReadLine());
                        bill += 100 * itemQ;
                        break;
                    default:
                        Console.WriteLine("Wrong Option!!");
                        break;
                }
                Console.WriteLine("Want anything else? (y/n) ");
                wantMore = Convert.ToChar(Console.ReadLine());
            } while (wantMore == 'y');


            Console.WriteLine("Total amount is : {0}", bill);
        }
    }
}
