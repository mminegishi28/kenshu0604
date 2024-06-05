using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("指スマ～～!!");
            Console.WriteLine("あなたの名前を入力してください");
            string input = Console.ReadLine();


             Chara p2 = new Chara("ゲームマスター",1);
             p2.show();

            Chara p1 = new Chara(input, 22);
            p1.show2();

           
            while (true)
            {
                Console.WriteLine("あなたの予想を入力してください");
                string yosou = Console.ReadLine();

                //stringをintに変更
                int yosouInt = int.Parse(yosou);


                Guess a1 = new Guess();
                a1.guess = yosouInt;


                Console.WriteLine("指スマ");
                Console.WriteLine("１本→1  両方→２  ０本→0");

                // 入力内容を待つ
                p1.Hand = int.Parse(Console.ReadLine());

               
                //相手の手を作る→Ramdomクラスを使って乱数を用意
                Random random = new Random();

                //最小値、最大値未満でNextメソッドを使用
                p2.Hand = random.Next(0, 3);


                //お互いの目を確認する→カプセル化しているのでプロパティで設定
                p1.show(p1.Name, p1.Hand);
                p2.show(p2.Name, p2.Hand);

                Console.WriteLine("合計："+(p1.Hand + p2.Hand));
           

                //条件分岐
                if ((p1.Hand + p2.Hand) == a1.guess)
                {

                    Console.WriteLine("予想的中！！！あと1回！！");

                    if (p2.NowHand == 1) // p1.Hand が 1 かどうかをチェックします
                    {
                        Console.WriteLine("おめでとうございます");
                        break; // ループを抜けます
                    }

                    p2.NowHand--;
                }
                else
                {
                    Console.WriteLine("残念!!");
                }

            }
        }
    }
}
                
               


            

            


    
