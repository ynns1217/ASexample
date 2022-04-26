using System;

namespace Test
{
    public class TV
    {
        private int Price;
        private int Bonus;
        public TV(int price, int bonus)
        {
            Price = price;
            Bonus = bonus;
        }
        public int GetPri()
        {
            return Price;
        }

        public int GetBon()
        {
            return Bonus;
        }
    }
    class Computer
    {
        private int Price;
        private int Bonus;
        public Computer(int price, int bonus)
        {
            Price = price;
            Bonus = bonus;
        }

        public int GetPri()
        {
            return Price;
        }

        public int GetBon()
        {
            return Bonus;
        }
    }
    class Audio
    {
        private int Price;
        private int Bonus;
        public Audio(int price, int bonus)
        {
            Price = price;
            Bonus = bonus;
        }

        public int GetPri()
        {
            return Price;
        }

        public int GetBon()
        {
            return Bonus;
        }
    }

    class Person
    {
        private int Money;
        private int PerBonus;
        private int TVnum;
        private int Comnum;
        private int Audionum;
        public Person(int money)
        {
            Money = money;
            PerBonus = 0;
            TVnum = 0;
            Comnum = 0;
            Audionum = 0;
        }
        public void SetMoney(int money)
        {
            Money = money;
        }

        public int GetMoney()
        {
            return Money;
        }

        // Bonus
        public void SetBonus(int bonus)
        {
            PerBonus = bonus;
        }

        public int GetBonus()
        {
            return PerBonus;
        }

 


        public void SetTV_num(int num)
        {
            TVnum = num;
        }
        public int GetTV_num()
        {
            return TVnum;
        }

        public void buyTV(int num, int Price, int aBonus)
        {
            if (Money < Price * num)
            {
                Console.WriteLine("금액이 부족합니다.");
            }
            else
            {
                SetMoney(GetMoney() - (Price * num));
                SetBonus(GetBonus() + (aBonus * num));
                SetTV_num(GetTV_num() + num);
                Console.WriteLine($"{num}개의 TV를 샀습니다.");
                Console.WriteLine($"남은 금액은 {Money}입니다.");
                Console.WriteLine($"현재까지의 보너스는 {PerBonus}입니다.\n");


            }
        }

        // Computer
        public void SetComputer_num(int num)
        {
            Comnum = num;
        }

        public int GetComputer_num()
        {
            return Comnum;
        }

        public void buyComputer(int num, int Price, int aBonus)
        {
            if (Money < Price * num)
            {
                Console.WriteLine("금액이 부족합니다.");
            }
            else
            {
                SetMoney(GetMoney() - (Price * num));
                SetBonus(GetBonus() + (aBonus * num));
                SetComputer_num(GetComputer_num() + num);
                Console.WriteLine($"{num}개의 Computer를 샀습니다.");
                Console.WriteLine($"남은 금액은 {Money}입니다.");
                Console.WriteLine($"현재까지의 보너스는 {PerBonus}입니다.\n");


            }
        }

        // Audio
        public void SetAudio_num(int num)
        {
            Audionum = num;
        }

        public int GetAudio_num()
        {
            return Audionum;
        }

        public void buyAudio(int num, int Price, int aBonus)
        {
            if (Money < Price * num)
            {
                Console.WriteLine("금액이 부족합니다.");
            }
            else
            {
                SetMoney(GetMoney() - (Price * num));
                SetBonus(GetBonus() + (aBonus * num));
                SetAudio_num(GetAudio_num() + num);
                Console.WriteLine($"{num}개의 Audio를 샀습니다.");
                Console.WriteLine($"남은 금액은 {Money}입니다.");
                Console.WriteLine($"현재까지의 보너스는 {PerBonus}입니다.\n");

            }
        }

        public void PrintList()
        {
            Console.WriteLine("\n < 현재까지 구매한 물품리스트 >");
            Console.WriteLine($"TV : {TVnum,8}");
            Console.WriteLine($"Computer : {Comnum}");
            Console.WriteLine($"Audio : {Audionum,4}");

        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {

            TV tv = new TV(100, 100);
            Computer computer = new Computer(200, 200);
            Audio audio = new Audio(300, 300);

            Person buyer = new Person(5000);
            buyer.buyTV(5, tv.GetPri(), tv.GetBon());
            buyer.buyComputer(5, computer.GetPri(), computer.GetBon());
            buyer.buyAudio(5, audio.GetPri(), audio.GetBon());
            buyer.buyTV(10, tv.GetPri(), tv.GetBon());
            buyer.buyTV(1000, tv.GetPri(), tv.GetBon());

            buyer.PrintList();

        }
    }
}
