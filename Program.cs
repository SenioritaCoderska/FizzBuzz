using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMethod();
        }

        private static void MainMethod()
        {
            //Operate over user input
            try
            {
                // Ask nicely
                Console.WriteLine($"{Environment.NewLine} Hello! { Environment.NewLine} Please provide one number...");
                //Collect input and veriify the number
                Console.WriteLine(new FizzBuzzVerification().GetResult);
                //Ask what to do next?
                UserActionsManagment();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MainMethod();
            }
        }

        private static void UserActionsManagment()
        {
            //What do you want to do next?
            Console.WriteLine("What do you want to do next ? For exit press (e) to continue press (c).");
            //Perfomr an action depend on user input
            var keyInput = Console.ReadKey().Key.ToString().ToLower();
            switch (keyInput)
            {
                case "e":
                    Environment.Exit(0);
                    break;
                case "c":
                    MainMethod();
                    break;
                default:
                    Console.WriteLine($"{Environment.NewLine} No appropriate action chosen!");
                    UserActionsManagment();
                    break;
            }
        }
    }
}