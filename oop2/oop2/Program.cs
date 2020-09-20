using System;

namespace oop2
{
    class Program
    {
        static void NumberChannel()
        {
            Console.Write("Введите канал: ");
            int channelTry;
            bool isInt = int.TryParse(Console.ReadLine(), out channelTry);
            if (isInt)
            {
                if (channelTry > 999)
                {
                    channelTry = 1;
                }
                if (channelTry < 1)
                {
                    channelTry = 999;
                }
            }
            Channel = channelTry;

            Console.WriteLine($"Текущий канал: {Channel}");
        }

        public static int Channel = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Телевизор");
            Console.WriteLine("Следующий канал: '+' ");
            Console.WriteLine("Предыдущий канал: '-' ");
            Console.WriteLine("Канал по номеру: '=' ");
            bool tv = true;
            while (tv)
            {
                string TV;
                TV = Console.ReadLine();

                if (TV == "-")

                {
                    if (Channel == 1)
                    {
                        Channel = 999;
                    }
                    else
                    {
                        Channel--;
                    }
                    Console.WriteLine($"Текущий канал: {Channel}");
                }
                else if (TV == "+")
                {
                    if (Channel == 999)
                    {
                        Channel = 1;
                    }
                    else
                    {
                        Channel++;
                    }
                    Console.WriteLine($"Текущий канал: {Channel}");
                }
                else if (TV == "=")
                {
                    NumberChannel();
                }
            }
        }
    }
}
