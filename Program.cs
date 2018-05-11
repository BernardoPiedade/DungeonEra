using System;
using System.Threading;
using System.IO;

namespace DungeonEra
{
    class MainClass
    {
        static string HeroSheet = File.ReadAllText(@"Hero.txt");
        static string[] array = HeroSheet.Split('\n');
        static string[] a1;
        static string[] HeroName = new String[1];
        static string[] HeroClass = new String[1];
        static int[] HeroLevel = new int[1];
        static int[] WeaponAtk = new int[1];
        static string[] WeaponName = new String[1];
        static int[] ArmorDef = new int[1];
        static string[] ArmorName = new String[1];
        static int[] HeroGold = new int[1];



        public static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu(){

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Clear();

            Console.WriteLine("\n\n");
            Console.WriteLine("\n\n");
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t\t[1] New Game");
            Console.WriteLine("\t\t\t\t[2] Load Game");
            Console.WriteLine("\t\t\t\t[0] Exit Game");

            var r = Console.ReadLine();
            if (string.IsNullOrEmpty(r))
            {
                MainMenu();
            }

            int op = Int32.Parse(r);

            if(op == 1){
                NewGame();
            }else if (op == 2){
                LoadGame();
            }else if(op == 0){
                Environment.Exit(0);
            } else {
                MainMenu();
            }
        }

        public static void NewGame(){

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("\n\n");
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t\t Dungeon Era");
            Console.WriteLine("\t\t\t\tUndead Village");
            Thread.Sleep(900);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Hello adventurer!");
            Thread.Sleep(900);
            Console.WriteLine("I'm Klurk Pythjin");
            Console.WriteLine("My class is Dwarf");
            Thread.Sleep(900);
            Console.WriteLine("What's your name adventurer?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("I'm ");
            HeroName[0] = Console.ReadLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Hello adventurer!");
            Console.WriteLine("I'm Klurk Pythjin");
            Console.WriteLine("My class is Dwarf");
            Console.WriteLine("What's your name adventurer?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I'm "+HeroName[0]);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(900);
            Console.WriteLine("Great name!");
            Thread.Sleep(900);
            Console.WriteLine("Can you tell me your class?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("I'm a/an ");
            HeroClass[0] = Console.ReadLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Hello adventurer!");
            Console.WriteLine("I'm Klurk Pythjin");
            Console.WriteLine("My class is Dwarf");
            Console.WriteLine("What's your name adventurer?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I'm " + HeroName[0]);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Great name!");
            Console.WriteLine("Can you tell me your class?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I'm a/an "+HeroClass[0]);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(900);
            Console.WriteLine("You're now ready to start your adventure!");
            Thread.Sleep(900);
            Console.WriteLine("As a gift I'll give you a 'Small Sword +1' and 50 gold");
            Thread.Sleep(1000);
            Console.WriteLine("Good luck on your adventure!");
            Thread.Sleep(1050);

            WeaponName[0] = "Small Sword";
            WeaponAtk[0] = 1;
            HeroGold[0] = 50;
            HeroLevel[0] = 1;

            GameMenu();


        }

        public static void LoadGame(){

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < array.Length; i++)
            {
                if (!array[i].Equals(""))
                {
                    a1 = array[i].Split('|');

                    HeroName[i] = a1[0];
                    HeroClass[i] = a1[1];
                    HeroLevel[i] = Int32.Parse(a1[2]);
                    WeaponName[i] = a1[3];
                    WeaponAtk[i] = Int32.Parse(a1[4]);
                    ArmorName[i] = a1[5];
                    ArmorDef[i] = Int32.Parse(a1[6]);
                    HeroGold[i] = Int32.Parse(a1[7]);
                }

            }

            Console.WriteLine("Reading file");
            Thread.Sleep(1000);
            GameMenu();

        }

        public static void GameMenu(){

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Hero Name: "+HeroName[0]+"\t\tClass: "+HeroClass[0]+"\t\tHero Level: "+HeroLevel[0]+"\nWeapon Name: "+WeaponName[0]+"\t\tWeapon Atack: +"+WeaponAtk[0]+"\nArmor Name: "+ArmorName[0]+"\t\tArmor Defense: +"+ArmorDef[0]+"\nGold: "+HeroGold[0]);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("[1] Tavern");
            Console.WriteLine("[2] Inn");
            Console.WriteLine("[3] Dungeon");
            Console.WriteLine("[4] Death South Valey");
            Console.WriteLine("[5] City of the Sols");
            Console.WriteLine("[6] Save Game");
            Console.WriteLine("[7] Exit Game");

            var r = Console.ReadLine();
            if(string.IsNullOrEmpty(r)){
                GameMenu();
            }

            string op = r;

            if(op.Equals("1")){
                Tavern();
            }else if (op.Equals("2")){
                Inn();
            }else if (op.Equals("3")){
                Dungeon();
            }else if (op.Equals("4")){
                DeathSV();
            }else if (op.Equals("5")){
                CityOTS();
            }else if (op.Equals("6")){
                SaveGame();
            }else if (op.Equals("7")){
                Console.Clear();
                Environment.Exit(0);
            }else {
                GameMenu();
            }


        }

        public static void Tavern(){
            
        }

        public static void Inn(){
            
        }

        public static void Dungeon(){
            
        }

        public static void DeathSV(){
            
        }

        public static void CityOTS(){
            
        }

        public static void SaveGame(){
            
        }
    }
}