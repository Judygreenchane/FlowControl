namespace FlowControl.Helper
{
    public class Util
    {
        public static string AskForString(string prompt)
        {
            bool success = false;
            string answer;
            do
            {
                Console.Write($"{prompt} ");
                answer = Console.ReadLine();
                 
                if (string.IsNullOrWhiteSpace(answer)) 
                    {
                    Console.WriteLine($"You must enter a valid age");
                }
                else
                {
                    success = true;
                }
            } while (!success);
            return answer;
        }

        public static uint AskForUInt(string prompt)
        {
            do
            {
                string input=AskForString(prompt);
                if(uint.TryParse(input, out uint result))
                {
                    if(result <= 150)
                    return result;
                    else
                    Console.WriteLine($"You must enter a valid age in between 0 and 150");

                }
                else
                    Console.WriteLine($"You must enter a valid positive age in between 0 and 150");
            } while(true);
        }
    }
}
