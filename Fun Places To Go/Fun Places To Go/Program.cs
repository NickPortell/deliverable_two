using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Places_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String Activity, Choice =null, Go=null, Travel=null;
            Int32 People;

            Console.WriteLine("Hello user, what are you in the mood for?");

            Console.WriteLine("Here are your options: " + '\n' + "1) Action \n2) Chilling \n3) Danger \n4) Good Food \n");
            Activity = Console.ReadLine();


                if (Activity == "1")
                {
                    Choice = " an Action-packed experience";
                    Go = "Stock Car Racing";
                }

                else if (Activity == "2")
                {
                    Choice = "chilling";
                    Go = "Hiking";
                }

                else if (Activity == "3")
                {
                    Choice = "a Dangerous activity";
                    Go = "Skydiving";
                }

                else if (Activity == "4")
                {
                    Choice = "a culinary experience";
                    Go = "To Taco Bell";
                }
            else
            {
                Console.WriteLine("Your entry is not one of the choices provided");
            }

                Console.WriteLine("How many people are you bringing with you? (please enter just the number)");
                People = Convert.ToInt32(Console.ReadLine());

                if (People == 0)
                    Travel = "Sneakers";

                if (People >= 1 && People <= 4)
                    Travel = "a sedan";

                if (People >= 5 && People <= 10)
                    Travel = "a Volkswagen bus";

                if (People >= 11)
                    Travel = "an airplane";
            
            Console.WriteLine('\n' + "Okay, if you're in the mood for {0}, then you should go {1}. \nOh, and you will want to travel in {2}!", Choice, Go, Travel);
            Console.WriteLine("Goodbye, and have a wonderful time!");
        }
    }
}
