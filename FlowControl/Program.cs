
using FlowControl.Helper;
using System.Text.RegularExpressions;
namespace FlowControl
{
    internal class Program
    {
        static bool programQuit = false;
        static void Main(string[] args)
        {
            
            Console.WriteLine(" You have reached a Menu! \n Enter any number given below to navigate through the options");
            do
            {
                MainMenu();
            } while (programQuit == false);
            
        }
        static void MainMenu()
        {


            Console.WriteLine("1 : Check whether you are a pensioner or youth");
            Console.WriteLine("2 : Calculate the price for an entire party");
            Console.WriteLine("3 : Repeat ten times");
            Console.WriteLine("4 : Enter a string having atleast 3 words, to get third word");
            Console.WriteLine("0 : To quit program");

            Console.WriteLine("Enter your choice");
            string userInput = Console.ReadLine();

           



            switch (userInput)
            {
                case "0":
                    Console.WriteLine("The program is ending");
                    programQuit = true;
                    break;
                case "1":
                    CheckPensionerOrYouth();
                    break;
                case "2":
                    CalculateTotalCost();                                  // To find total cost for the entire party
                    break;
                case "3":
                    FeedBack();                                            // For repeating 10 times.
                    break;
                case "4":
                    ThirdWord();                                           //  To find third word of a string .
                    break;
                default:
                    Console.WriteLine("Your choice is not valid, try again.");
                    break;
            }
        }
        static void CheckPensionerOrYouth()
        {
           

            uint int_age = Util.AskForUInt($"Enter your age : ");
            
             
            if ((int_age < 5) || (int_age > 100)) 
                Console.WriteLine("It is free for you.No need to pay");
                else if (int_age < 20)
                Console.WriteLine("Your Price : SEK 80");
            else if (int_age > 64)
                Console.WriteLine("Pensioner  Price : SEK 90");
            else
                Console.WriteLine("Standard  Price  : SEK 120");


        }
        static void CalculateTotalCost()
        {
            int totalCost = 0;
            Console.WriteLine("Enter Number of people going for the cinema");
            Int32.TryParse(Console.ReadLine(), out int noOfPeople);              // If the user enter any other type other than integer,the variable noOfPeople will get a 0 value.
            for (int i = 1; i <= noOfPeople; i++)
            {
               
                uint age = Util.AskForUInt($"Enter Age of person {i} : ");
                
                if ((age < 5) || (age > 100))
                    totalCost += 0;
                else   if (age < 20)
                    totalCost += 80;
                else if (age > 64)
                    totalCost += 90;
                else
                    totalCost += 120;
            }
            Console.WriteLine($"Number of people                     :  {noOfPeople}");
            Console.WriteLine($"Total cost for the entire party      :  {totalCost}");
        }
        static void FeedBack()
        {
            string responses = "";
            int i = 1;
            while (i <=10)
            {
                Console.Write($"Write Your response for Question {i} : ");
                responses += Console.ReadLine()+ " ";
                i++;
            }
           string [] responseArray = responses.Trim().Split(" ");
            for (int j=0;j<responseArray.Length;j++ )
            {
                Console.Write($"{j+1}. {responseArray[j]}   ");
            }
            Console.WriteLine();
           // Console.WriteLine(responses.Trim().ToString());
        }
        static void ThirdWord()                                       // To find third word of a user entered string (It also works if the user enters  multiple spaces between the words)
        {
            int count=0;
            Console.WriteLine("Enter a string");
            string inputString=Console.ReadLine();
            var  words = inputString.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {

                // Checking for multiple spaces
                if (words[i] !=string.Empty)   
                {
                    count++;
                    if (count == 3)
                    {
                        Console.WriteLine($"The third word is {words[i].ToString()}");
                        break;
                    }
                } 

            }
            

        }
    }
}
