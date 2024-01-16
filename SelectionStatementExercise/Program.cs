namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise1

            var r = new Random();
            var favNumber = r.Next(1, 100);
            var upper = 100;
            var lower = 1;
            bool found = false;

            while (found == false)
            {
                Console.WriteLine($"Guess the number between {lower} and {upper}: ");
                var userInput = int.Parse(Console.ReadLine());
                if(userInput > favNumber )
                {
                    Console.WriteLine("The number is too high.\n");
                    upper = userInput;
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("The number is too low.\n");
                    lower = userInput;
                }
                else
                {
                    Console.WriteLine($"The number {userInput} is correct!");
                    found = true;
                }
            }

            //Exercise2

            Console.WriteLine("\nWhat is your favorite school subject?");
            string userClass = Console.ReadLine();

            switch(userClass.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is fun.");
                    break;
                case "science":
                    Console.WriteLine("Science is intresting.");
                    break; 
                case "history":
                    Console.WriteLine("History is relaxing.");
                    break;
                case "gym":
                case "pe":
                    Console.WriteLine("Dodgeball is competative.");
                    break;
                default:
                    Console.WriteLine($"{userClass} is a cool class.");
                    break;
            }

        }
    }
}
