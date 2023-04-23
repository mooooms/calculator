namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите операцию");
            string read = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            int b=Convert.ToInt32(Console.ReadLine());

            switch (read)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;

                default: Console.WriteLine("такой операции нет");
                    break;
            }

        }

    }
}