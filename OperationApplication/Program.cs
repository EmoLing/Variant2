using System;

namespace OperationApplication // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.Error.WriteLine("Некорректное количество аргументов на вход!");
                Console.ReadLine();

                return;
            }

            string operation = args[(int)Arg.Operation].ToLower();
            double number1 = Convert.ToDouble(args[(int)Arg.Number1]);
            double number2 = Convert.ToDouble(args[(int)Arg.Number2]);

            char @operator = operation switch
            {
                "plus" => '+',
                "minus" => '-',
                "multiple" => '*',
                "divide" => '/',
                _ => '0'
            };

            if (@operator == '0')
            {
                Console.Error.WriteLine("Неизместный оператор!");
                Console.ReadLine();

                return;
            }

            if (@operator == '/' && number2 == 0)
            {
                Console.Error.WriteLine("Деление на нуль!");
                Console.ReadLine();

                return;
            }

            double result = @operator switch
            {
                '+' => number1 + number2,
                '-' => number1 - number2,
                '*' => number1 * number2,
                '/' => number1 / number2,
                _ => throw new NotImplementedException(),
            };

            Console.WriteLine($"{number1} {@operator} {number2} = {result}");
            Console.ReadLine();
        }

        enum Arg
        {
            Operation,
            Number1,
            Number2,
        }
    }
}