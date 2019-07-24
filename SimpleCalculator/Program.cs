using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string end = null;
            while (end != "exit")
            {
                Console.WriteLine("-- Welcome to a simple calculator -- \n");

                Console.Write(" Please enter your first number: ");
                string num1 = Console.ReadLine();
                var x = CheckNumber1(num1);

                Console.Write("\n Enter your operand:");
                string op = Console.ReadLine();
                var z = CheckOperand(op);

                Console.Write("\n Please enter your second number: ");
                string num2 = Console.ReadLine();
                var y = CheckNumber2(num2);

                int answer = Calc(x, y, z);

                Console.WriteLine($"\n");
                Console.WriteLine($"     {x}");
                Console.WriteLine($"  {z}  {y}");
                Console.WriteLine("  ----------");
                Console.WriteLine($"     {answer}");
                Console.WriteLine("\n Type exit if you want to end, if not press enter to start again:");
                end = Console.ReadLine();
            }
        }

            static string CheckNumber1(string n)
            {
                int value;
                string entry;
                bool check = false;

                while (check != true)
                {

                    if (int.TryParse(n, out value))
                    {
                        if (value < 0)
                        {
                            Console.WriteLine("\n Please enter a positive intiger.");
                            Console.Write("Please enter your first number: ");
                            n = Console.ReadLine();
                        }
                        else
                        {
                            check = true;
                            Console.WriteLine($"You entered {n}");
                            return entry = n;
                        }
                    }
                    Console.WriteLine("\n You've entered an invalid character.");
                    Console.Write("Please enter your first number: ");
                    n = Console.ReadLine();
                }

                return n;
            }

            static string CheckOperand(string o)
            {
                bool check = false;
                while (check != true)
                {
                    if (o == "x" || o == "/" || o == "+" || o == "-" || o == "%")
                    {
                        Console.WriteLine($"You've entered {o}");
                        return o;
                    }
                    else
                    {
                        Console.WriteLine("You've enter an invalid operand, please use +, -, x, / or %");
                        Console.Write("\n Enter your operand:");
                        o = Console.ReadLine();
                    }
                }
                return o;
            }

            static string CheckNumber2(string n)
            {
                int value;
                string entry;
                bool check = false;

                while (check != true)
                {

                    if (int.TryParse(n, out value))
                    {
                        if (value < 0)
                        {
                            Console.WriteLine("\n Please enter a positive intiger.");
                            Console.Write("Please enter your second number: ");
                            n = Console.ReadLine();
                        }
                        else
                        {
                            check = true;
                            Console.WriteLine($"You entered {n}");
                            return entry = n;
                        }
                    }
                    Console.WriteLine("\n You've entered an invalid character.");
                    Console.Write("Please enter your second number: ");
                    n = Console.ReadLine();
                }

                return n;
            }

            static int Calc(string x, string y, string z)
            {
                int solution;
                int a = Int32.Parse(x);
                int b = Int32.Parse(y);

                switch (z)
                {
                    case "x":
                        return solution = a * b;

                    case "/":
                        return solution = a / b;

                    case "+":
                        return solution = a + b;

                    case "-":
                        return solution = a - b;

                    case "%":
                        return solution = a % b;

                }
                return 0;
            }
        }
    }
