using System;
using System.Collections.Generic;

namespace todolist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("今日のやることを入力してください（空行で終了）");
            Console.WriteLine("1→達成（チェック）");

            // やることの入力
            List<string> todos = new List<string>();
            string input = "";
            do
            {
                Console.Write("□今日のやることは：");
                input = Console.ReadLine();

                // 入力が空行でなければリストに追加
                if (!string.IsNullOrEmpty(input))
                {
                    // やることが達成された場合、◆に変更
                    if (input == "1")
                    {
                        todos.Add("◆");
                    }
                    else
                    {
                        todos.Add(input);
                    }
                }
            } while (!string.IsNullOrEmpty(input));

            // やることの表示
            Console.WriteLine();
            Console.WriteLine("やることリスト：");
            foreach (string todo in todos)
            {
                Console.WriteLine("□" + todo);
            }

            // 達成したやることを表示
            Console.WriteLine();
            Console.WriteLine("達成したやること：");
            foreach (string todo in todos)
            {
                if (todo == "◆")
                {
                    Console.WriteLine(todo);
                }
            }

            // カウント結果を表示
            int count = todos.Count;
            Console.WriteLine();
            Console.WriteLine("やることの数：" + count + "個");
        }
    }
}
