using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            String pluggedIn = Console.ReadLine();
            String burntOut = Console.ReadLine();

            Console.WriteLine("Uh oh. I understand that your lamp isn't working. " +
                "Let me try to help. Please enter Yes or No to the following questions.");
            Console.WriteLine("Is the lamp plugged in?: " + pluggedIn);

            if (pluggedIn == "No" || pluggedIn = "no")
            {
                Console.WriteLine("Plug in the lamp.");
            } else if (pluggedIn == "Yes" || pluggedIn == "yes")
            {
                Console.WriteLine("Is the bulb burnt out?: " + burntOut);
                if (burntOut == "No" || burntOut == "no")
                {
                    Console.WriteLine("Please repair your lamp.");
                } else if (burntOut == "Yes" || burntOut == "yes")
                {
                    Console.WriteLine("Please replace the lightbulb.");
                }
            }
        }
    }
}
