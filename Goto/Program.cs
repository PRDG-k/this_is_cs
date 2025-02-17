using System;

namespace Goto
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요: ");

            String input = Console.ReadLine();

            int input_number = Int32.Parse(input);

            int exit_number = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k< 3; k++)
                    {
                        if (input_number == exit_number++)
                        {
                            goto EXIT_FOR;
                        }
                        Console.WriteLine(exit_number);
                    }
                }
            }

            goto EXIT_PROGRAM;

        EXIT_FOR:
            Console.WriteLine("\nExit nested for...");

        EXIT_PROGRAM:
            Console.WriteLine("Exit program...");
        }
    }
}
