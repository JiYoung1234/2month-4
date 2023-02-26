using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 키우기
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("예술(Q), 운동(W), 외모(E), 공부(R) 원하는 것을 선택하세요.");
            //총 8칸의 배열 만들기
            List<string> art = new List<string>();
            List<string> sport = new List<string>();
            List<string> beauty = new List<string>();
            List<string> study = new List<string>();

            //List<string> stringlist = new List<string>();
            //stringlist.Add(Console.ReadLine());
            //for (int index = 0; index < stringlist.Count; index++)
            //{
            //    Console.WriteLine(stringlist[index]);
            //}
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Q:

                        art.Add("ㅁ");
                        Console.Write($"예술: {art[0]} ");
                        break;
                        
                    case ConsoleKey.W:
                        sport.Add("ㅁ");
                        Console.Write($"운동: {sport[0]} ");
                        break;

                    case ConsoleKey.E:
                        beauty.Add("ㅁ");
                        Console.Write($"외모: {beauty[0]} ");
                        break;

                    case ConsoleKey.R:
                        study.Add("ㅁ");
                        Console.Write($"공부: {study[0]} ");
                        break;
                }



                if (art.Count() > 6 && art.Count() < 8)
                {
                    Console.WriteLine("끝났습니다1");
                    break;

                }
                else if (sport.Count() > 6 && sport.Count() < 8)
                {
                    Console.WriteLine("끝났습니다2");
                    break;
                }
                else if (beauty.Count() > 6 && beauty.Count() < 8)
                {
                    Console.WriteLine("끝났습니다3");
                    break;
                }
                else if (study.Count() > 6 && study.Count() < 8)
                {
                    Console.WriteLine("끝났습니다4");
                    break;
                }
                //ConsoleKeyInfo key = Console.ReadKey(true);
                //switch (key.Key)
                //{
                //    case ConsoleKey.Q:

                //    break;
                //}
            }
        }
        
        
    }
}
