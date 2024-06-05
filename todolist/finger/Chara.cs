using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finger
{
    public class Chara
    {
        protected string name;
        protected int hand;
        protected int nowHand;

        public Chara(string name, int hand)
        {
            this.name = name;
            this.hand = hand;
            this.nowHand = 2;
        }

        public string Name 
        {
            get { return name; }
        }

         public int Hand
        { 
            get { return hand; }
            set { hand = value; }
        }
        public int NowHand
        {
            get { return nowHand; }
            set { nowHand = value; }
        }

       public void show()
        {
            Console.WriteLine("私はゲームマスターです");
        }
        public void show2()
        {
            Console.WriteLine("あなたは{0}さんですね", this.name);
            Console.WriteLine("それでは早速ゲームを始めましょう");
            Console.WriteLine("");
        }

        public void show(string name, int hand)
        {
            switch (hand)
            {

                case 1:
                    Console.WriteLine("{0}は１本上げました", name);
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("{0}は両方上げました", name);
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("{0}は０本上げました", name);
                    Console.WriteLine("");
                    break;
            }

        }
    }

    public class Guess
    {
        public int guess;

    public void feel()
        {
            Console.WriteLine("予想は{0}です。",guess);
        }
    }

    public class Goukei
    {
      
    }


}
