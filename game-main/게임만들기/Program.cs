using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 게임만들기
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int ai1 = rand.Next(1, 3);
            int ai2 = rand.Next(1, 3);
            System.Console.WriteLine("1(가위) 2(바위) 3(보) 입력하세요.");
            string playa = System.Console.ReadLine();
            int play1 = Convert.ToInt32(playa);
            string playb = System.Console.ReadLine();
            int play2 = Convert.ToInt32(playb);
            System.Console.WriteLine($"컴퓨터: {ai1} {ai2}    플레이어: {play1} {play2}");

            string playc;
            int play3, ai3; //최종값
            System.Console.WriteLine("왼손(0) 오른손(1) 선택해 주세요");
            playc = System.Console.ReadLine();
            play3 = Convert.ToInt32(playc);

            while (true)
            {
                if (play3 == 0)
                {
                    play3 = play1;

                }
                else if (play3 == 1)
                {
                    play3 = play2;
                }
                else
                {
                    System.Console.WriteLine("다시 선택하세요");
                    return;
                }
            }

            System.Console.WriteLine($"플레이어는 {play3}");

            ai3 = rand.Next(0, 1);
            if (ai3 == 0)
            {
                ai3 = ai1;
            }
            else
            {
                ai3 = ai2;
            }

            System.Console.WriteLine($"컴퓨터는 {ai3}");


            switch (play3)
            {
                case 1:
                    if (ai3 == 1)
                    {
                        System.Console.WriteLine("비겼습니다");
                    }
                    else if (ai3 == 2)
                    {
                        System.Console.WriteLine("컴퓨터가 이겼습니다");
                    }
                    else
                    {
                        System.Console.WriteLine("플레이어가 이겼습니다");
                    }
                    break;
                case 2:
                    if (ai3 == 1)
                    {
                        System.Console.WriteLine("플레이어가 이겼습니다");
                    }
                    else if (ai3 == 2)
                    {
                        System.Console.WriteLine("비겼습니다");
                    }
                    else
                    {
                        System.Console.WriteLine("컴퓨터가 이겼습니다");
                    }
                    break;
                case 3:
                    if (ai3 == 1)
                    {
                        System.Console.WriteLine("컴퓨터가 이겼습니다");
                    }
                    else if (ai3 == 2)
                    {
                        System.Console.WriteLine("플레이어가 이겼습니다");
                    }
                    else
                    {
                        System.Console.WriteLine("비겼습니다");
                    }
                    break;
            }
            string[] aa = new string[] { "■", "■", "■", "■", "■", "■", "■" };
            Console.Write("□");
            Console.Write("■");
            Console.Read();
            string a = "■";
            foreach (string aaa in aa)
            {
                Console.WriteLine(aaa);
            }
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.Q:
                    for (int r = 0; r < 8; r++)
                    {
                        Console.Write("ㅁ");
                    }
                    break;
            }
        }
    }
}
