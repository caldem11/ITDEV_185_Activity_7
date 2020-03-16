using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_7
{
    class Controler
    {
        public void control()
        {
            select();
        }
        int b = 0;
        int a = 0;
        public void select()
        {
            
            while (true)
            {
                Console.WriteLine("Please Make a Selection");
                Console.WriteLine("1: Add item to Colection");
                Console.WriteLine("2: Exit");

                a = Convert.ToInt32(Console.ReadLine());

                if (a == 2)
                    break;

                switch (a)
                {

                    case 1:
                        Console.WriteLine("Enter Number of item you wwant to input:");
                        b = Convert.ToInt32(Console.ReadLine());
                        string[] word = new string[b];

                        for (int count = 0; count < b; count++)
                        {
                            Console.WriteLine("Enter Word: ");
                            word[count] = Console.ReadLine();
                            
                        }
                        while (true)
                        {
                            int selection2 ;
                        Console.WriteLine("Enter your selection");
                        Console.WriteLine("1: Display words with a lenght:");
                        Console.WriteLine("2: Exit");
                        selection2 = Convert.ToInt32(Console.ReadLine());
                        if (selection2 == 2)
                            break;
                        

                            switch (selection2)
                            {
                                case 1:
                                    int a;
                                    Console.WriteLine("Display words greater then number:");
                                    a = Convert.ToInt32(Console.ReadLine());

                                    var temp1 = Enumerable.Where(word, word1 => word1.Length > a);
                                    var temp2 = Enumerable.OrderBy(temp1, word1 => word1);

                                    IEnumerable<string> query = Enumerable.Select(temp2, word1 => word1.ToUpper());
                                    foreach (string word1 in query)
                                    {
                                        Console.WriteLine(word1);
                                    }

                                    break;
                            }
                        }
                        break;
                }
            }
        }
        public void add()
        {

        }
    }
}
