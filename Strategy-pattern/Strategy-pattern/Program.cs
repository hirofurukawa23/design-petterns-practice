using System;

namespace Strategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Taro", new WinningStrategy(234));
            Player player2 = new Player("Hana", new WinningStrategy(563));
            for(var i = 0; i < 1000; i++)
            {
                Hand nextHand1 = player1.NextHand();
                Hand nextHand2 = player2.NextHand();
                if (nextHand1.IsStrongerThan(nextHand2))
                {
                    Console.WriteLine($"Winner:{ player1 }");
                    player1.Win();
                    player2.Lose();
                }
                else if (nextHand2.IsStrongerThan(nextHand1))
                {
                    Console.WriteLine($"Winner:{ player2 }");
                    player1.Lose();
                    player2.Win();
                }
                else
                {
                    Console.WriteLine($"Even...");
                    player1.Even();
                    player2.Even();
                }
            }

            Console.WriteLine("Total result:");
            Console.WriteLine(player1.ToString());
            Console.WriteLine(player2.ToString());
            Console.ReadLine();
        }
    }
}
