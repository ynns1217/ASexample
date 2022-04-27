using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//클래스는 왠만하면 자기의 일은 스스로하자.
//캡슐화

class Fighter
{

    public int AT = 10;
    public int HP = 50;
    public int MAXHP = 100;
    public void StatusRender()
    {
        Console.WriteLine("===============================================");
        Console.Write("공격력:");
        Console.WriteLine(AT);
        Console.Write("체력:");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MAXHP);
        //cpfur : 50/100
        Console.WriteLine("===============================================");
        Console.ReadKey();
    }

    public void MaxHeal(/*Player this*/)
    {
        if (HP >= MAXHP)
        {
            Console.Write("");
            Console.Write("체력이 모드 회복되어있어서 회복할 필요가 없습니다.");
            Console.ReadKey();
        }
        else
        {
            this.HP = MAXHP;
            PrintHP();
        }
    }

    //두번 이상 쓸때는 함수로 만들어라
    public void PrintHP()
    {
        Console.Write("현재 플레이어의 HP는");
        Console.Write(HP);
        Console.WriteLine("입니다.");
        Console.ReadKey();
    }

}

class Player :Fighter
{
    int Heal;
    public void Healing()
    {
        if (HP >= MAXHP)
        {
            Console.Write("");
            Console.Write("체력이 모드 회복되어있어서 회복할 필요가 없습니다.");
            Console.ReadKey();
        }
        else
        {
            this.HP += Heal;
            PrintHP();
        }
    }

}

class Monster:Fighter
{

}
enum STARTSELECT
{ 
    SELECTTOWN,
    SELECTBATTLE,
    NONESELECT
}

namespace TextRpg001
{ 
    class Program
    {
        //시작을 담당하는 함수 /마을,싸움터/
        static STARTSELECT StartSelect()
        {        
            Console.Clear();        //화면지우기
            Console.WriteLine("어디로 가시겠습니까?");
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");

            //return이란 구문은 리턴이 되는 순간 함수를 완전히 종료시킨다.
            //즉 리턴을 한번 했다면 아래 많은 코드가있어도 소용이 없다.

            ConsoleKeyInfo CKI = Console.ReadKey();

            switch(CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("마을 입니다.");
                    return STARTSELECT.SELECTTOWN;
                    Console.ReadKey();
                case ConsoleKey.D2:
                    Console.WriteLine("배틀을 시작합니다..");
                    return STARTSELECT.SELECTBATTLE;
                    Console.ReadKey();
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    return STARTSELECT.NONESELECT;
                    Console.ReadKey();

            }
        } 

        static void Town(Player player)
        {

            while (true)
            {
                Console.Clear();
                player.StatusRender();
                Console.WriteLine("1. 체력을 회복한다");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");
                //초반에 프로그래밍의 전부.
                //객체를 선언해야 할때
                //함수의 분기
                //함수의 합칠때와 쪼갤때

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        player.MaxHeal();
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3: 
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }

        }
        static void Battle()
        {

        }

        static void Main(string[] args)
        {
            //객체지향 프로그래밍이란 결국 클래스로 설계하고 객체로 만들어 나가는 것


            //저는 마을과 싸움터로 나눠서
            //입장하게 하고 싶다면
            //반복문과 조건문중 

            //첫번째 static
            //두번째 
            Player NewPlayer = new Player();            //지역변수

            while (true)
            {
                ////객체화 하지 않고도 쓸 수 있는 static 함수, 정적 멤버변수
                //ConsoleKeyInfo KeyInfo = Console.ReadKey();
                //Console.WriteLine(KeyInfo.Key);  //키보드 위의 전체 키를 이넘화 시킨걸 출력해준다.

               // StartSelect();          //리턴값 = STARTSELECT라는 enum

                //그러나 함수 자체의 용도를 생각해서 정말 한가지의 용도로만 사용할 수 있나?,,아니면 받아서 쓰자
                STARTSELECT SelectCheck = StartSelect();

                switch(SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        break;
                }
 
            }

            //초기 선택
            //1.마을로 간다
            //2.싸움터로간다

            //1.마을 ( 마을에 도착했습니다.)
            //여관에 들른다
            //공격력을 강화한다.
            //나간다

            //2.싸움터 ( 싸움터에 도착했습니다.)
            //몬스터가 등장했다!
            //데미지를 입혔다 . xx는 2의 hp가 남았다.




        }
    }
}
