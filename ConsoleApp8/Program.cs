using System;
using System.Reflection;
using System.Security.Cryptography;

namespace ConsoleApp3
{

    //class enemy
    //{

    //    static void main(string[] args)
    //    {

    //    }
    //}
    class Program
    {
        public static int str = 1, vit = 1, agi = 1, luck = 1, dex = 1, str1 = 1, vit1 = 1, agi1 = 1, luck1 = 1, dex1 = 1, x = 10, exp1, add1, lvluo, battle, difficult;
        public string name;
        public int HP;
        public int exp;
        public int add;
        public int STR;
        public int Battle;
        public int[] EXP;
        public int VIT;
        public int AGI;
        public int LUCK;
        public int DEX;
        public int ARMORE;
        //public Body (int VIT,int AGI,int LUCK,int DEX,int ARMORE);


        //int=0;
        static void Main(string[] args)

        {


            //start game
            Console.WriteLine("Путник, привет давай устроим тебе испытание");
            Console.WriteLine("вы получили одежду быстрее одень ее");
            

            Console.WriteLine("Напиши себе какую сложность тебе поставить в виде цифры");
            difficult = Convert.ToInt32(Console.ReadLine());

            int p = 0;
            //int[] lvl = new int[5] { 50, 100, 150, 200, 250 };
            int[] lvl = new int[99];
            var i2 = 50;

            for (var i = 0; i < lvl.Length; i++)
                {                   
                    i2 = i2+50;
                    lvl[i] = i2;
                }
               /* for (var i = 0; i < lvl.Length; i++)
                {

                    Console.WriteLine(lvl[i]);
                } 
            */
           

            exp1 = 0;


            if
     (exp1 > -1)
            {
                lvluo = LVLup(lvluo);
                Console.WriteLine(lvluo);
            }

            static int Battle(int battle)
            {

                Console.WriteLine("ты наткнулся на монстра");
                Program person = new Program();
                person.HP = 10;
                person.HP = person.HP + vit;

                int[] lvl = new int[5] { 50, 100, 150, 200, 250 };
                Program skelet = new Program();
                skelet.HP = 10+ difficult;
                skelet.STR = 1+ difficult;
                skelet.exp = 30;
                int dexsum = 50 - dex;
                int agisum = 10 + agi;
                int lucksum = 10 + luck; 

                Console.WriteLine($"у врага сейчас {skelet.HP} здоровье");
                Console.WriteLine($"у тебя сейчас {person.HP} здоровье");
                for (; skelet.HP > 0;)
                {
                    Random rndDex = new Random();
                    int valueDex = rndDex.Next(1, 100);
                    Console.WriteLine($"проверка моей точности{valueDex}\t");
                    if (valueDex > dexsum)
                    {
                        Random rndAgi = new Random();
                        int valueAgi = rndAgi.Next(1, 100);
                        Console.WriteLine($"проверка моей ловкости {valueAgi}\t");
                        if (valueAgi < agisum)
                        {
                            Random rndLuck = new Random();
                            int valueLuck = rndLuck.Next(1, 100);
                            Console.WriteLine($"проверка моей удачи{valueLuck}\t");
                            if (valueLuck < lucksum)
                            {

                                skelet.HP -= str * 2;
                                skelet.HP -= str * 2;
                                Console.WriteLine("да ты ловкий перец, что бы так дерзко запихать свои ноги ему в зад!!! уважаю братишка");
                                Console.WriteLine($"у врага осталось {skelet.HP} здоровья\t");
                                
                                if (skelet.HP <= 0)
                                {
                                    Console.WriteLine("Ты убил врага гратц!!!!");
                                    break;
                                }

                            }
                            else if (valueLuck > luck)
                            {
                                skelet.HP -= str;
                                skelet.HP -= str;
                                Console.WriteLine("да ты ловкий перец, что бы так дерзко дать под зад дважды!!! уважаю братишка");
                                Console.WriteLine($"у врага осталось {skelet.HP} здоровья\t");
                                
                                if (skelet.HP <= 0)
                                {
                                    Console.WriteLine("Ты убил врага гратц!!!!");
                                    break;
                                }
                            }

                        }
                        else if (valueAgi > agisum)
                        {
                            skelet.HP -= str;
                            Console.WriteLine("удача ты обошел врага и дал ему под зад");
                            Console.WriteLine($"у врага осталось {skelet.HP} здоровья\t");
                            
                            if (skelet.HP <= 0)
                            {
                                Console.WriteLine("Ты убил врага гратц!!!!");
                                break;
                            }
                        }
                        }
                        else if
                            (valueDex < dexsum)
                        {

                            Console.WriteLine("промах, возможно ты попадешь в следующий раз");
                            Console.WriteLine($"у врага осталось {skelet.HP} здоровья\t");
                            

                        }

                        if (person.HP > 0)
                        {
                            Random rndDex2 = new Random();
                            int valueDex2 = rndDex2.Next(1, 100);
                            Console.Write("проверка точности врага\t");
                            Console.WriteLine(valueDex2);
                            if (valueDex2 > 50)
                            {
                                person.HP -= skelet.STR;
                                Console.WriteLine("удача повернулась к тебе спиной... собирай свои потраха с пола");
                                Console.WriteLine($"у меня осталось {person.HP} здоровья\t");
                                
                                if (person.HP <= 0)
                                {
                                    Console.WriteLine("Ты помер... гроб тебе не закажем");
                                    break;
                                }
                            }
                            else if
                                (valueDex2 < 50)
                            {

                                Console.WriteLine("Враг промазал... да ты везунчик");
                                Console.WriteLine($"у меня осталось {person.HP} здоровья\t");
                                
                            };

                        }
                    }
                    exp1 += skelet.exp;
                Console.WriteLine($"после победы над врагом ты получил {skelet.exp} опыта и теперь у тебя суммарно {exp1} опыта");
                    Console.WriteLine(exp1);
                    Console.WriteLine("/////////////////////////////////////////////БИТВА ЗАКОНЧИЛАСЬ///////////////////");

                    return battle;


                }


                Console.Write("вы хотите найти врага на пустоши этого мира?\t");
                string command = Console.ReadLine();
                command = command.ToLower().Trim().Trim();


                if (command == "да")
                {

                    for (; lvl[p] >= exp1;)
                    {

                        Console.WriteLine(lvl[p]);
                        Console.WriteLine("у тебя опыта ровно", exp1);
                        Console.WriteLine(exp1);

                        while (lvl[p] > exp1)
                        {
                            battle = Battle(battle);
                            Console.WriteLine(battle);

                        }
                        while (lvl[p] <= exp1)
                        {
                            x += 10;
                            lvluo = LVLup(lvluo);
                            Console.WriteLine(lvluo);
                            p += 1;

                        }
                    }
                }
                if (command == "нет")

                {

                 Console.WriteLine("а зачем ты запускал игру?"); 

                }

                Console.ReadLine();
            }
            // end game




            static int LVLup(int lvluo)
            {
            string LVLUP = $"у тебя {x} очков распредели их";
                Console.WriteLine(LVLUP);

                string alert1 = String.Empty, alert2 = String.Empty, alert3 = String.Empty, alert4 = String.Empty, alert5 = String.Empty;

                alert1 = "сила";
                alert2 = "живучесть";
                alert3 = "ловкость";
                alert4 = "удача";
                alert5 = "точность";
                for (; x > 0;)
                {
                var values = ($"{ alert1} = {str}, {alert2}  =  {vit}, {alert3}  =  {agi}, {alert4} = {luck}, {alert5}  =  {dex}." );
               // var values = ( alert1, "=", str, alert2, "=", vit, alert3, "=", agi, alert4, "=", luck, alert5, "=", dex);
                    Console.WriteLine(values);

                    Console.Write("введите к какоЙ характеристике хотите добавить очки?\t");
                   
                    string command = Console.ReadLine();
                    command = command.ToLower().Trim().Trim();


                    if (command == "сила")
                    {
                        str = strLVLup(str);

                    }

                    if (command == "живучесть")
                    {
                        vit = vitLVLup(vit);

                    }

                    if (command == "ловкость")
                    {
                        agi = agiLVLup(agi);

                    }

                    if (command == "удача")
                    {
                        luck = luckLVLup(luck);

                    }

                    if (command == "точность")
                    {
                        dex = dexLVLup(dex);

                    }

                    Console.Write("проверить характеристики?\t");
                    command = Console.ReadLine();
                    command = command.ToLower().Trim().Trim();
                    if
                        (command == "да")
                    {
                        Console.WriteLine(values);
                        if (x > 0)
                        {
                            Console.WriteLine(lvluo);
                        }

                    };

                    if
                        (command == "нет")
                    {
                        
                    }
                }

                return lvluo;
            }
            static int strLVLup(int str)
            {

                Console.Write("сколько добавить силы?\t");

                int add = Convert.ToInt32(Console.ReadLine());
                if (x > 0)
                {

                    if (x > 0)
                    {
                        if (x >= add)
                        {
                            x -= add;
                            Console.WriteLine(x);
                            str1 = str;
                            str1 += add;
                            str = str1;
                            Console.Write("теперь у вас сила равна\t");
                            Console.WriteLine(str);
                            Console.Write("вам осталось распределить очков\t");
                            Console.WriteLine(x);
                            return str1;
                        }
                        else Console.WriteLine("вы перебрали мистер");
                    }
                    else
                        Console.WriteLine("мало очков");
                    return str1;
                }
                else
                    Console.WriteLine("мало очков");
                return str1;
            }

            static int vitLVLup(int vit)
            {
                Console.Write("сколько добавить живучести?\t");

                int add = Convert.ToInt32(Console.ReadLine());
                if (x > 0)
                {

                    if (x > 0)
                    {
                        if (x >= add)
                        {
                            x -= add;
                            Console.WriteLine(x);
                            vit1 = vit;
                            vit1 += add;
                            vit = vit1;
                            Console.Write("теперь у вас живучесть\t");
                            Console.WriteLine(vit);
                            Console.Write("вам осталось распределить очков\t");
                            Console.WriteLine(x);
                            return vit1;
                        }
                        else Console.WriteLine("вы перебрали мистер");
                    }
                    else
                        Console.WriteLine("мало очков");
                    return vit1;
                }
                else
                    Console.WriteLine("мало очков");
                return vit1;
            }

            static int agiLVLup(int agi)
            {
                Console.Write("сколько добавить ловкости?\t");

                int add = Convert.ToInt32(Console.ReadLine());
                if (x > 0)
                {

                    if (x > 0)
                    {
                        if (x >= add)
                        {
                            x -= add;
                            Console.WriteLine(x);
                            agi1 = agi;
                            agi1 += add;
                            agi = agi1;
                            Console.Write("теперь у вас ловкость\t");
                            Console.WriteLine(agi);
                            Console.Write("вам осталось распределить очков\t");
                            Console.WriteLine(x);
                            return agi1;
                        }
                        else Console.WriteLine("вы перебрали мистер");
                    }
                    else
                        Console.WriteLine("мало очков");
                    return agi;
                }
                else
                    Console.WriteLine("мало очков");
                return agi;
            }

            static int luckLVLup(int luck)
            {
                Console.Write("сколько добавить удачи?\t");

                int add = Convert.ToInt32(Console.ReadLine());
                if (x > 0)
                {

                    if (x > 0)
                    {
                        if (x >= add)
                        {
                            x -= add;
                            Console.WriteLine(x);
                            luck1 = luck;
                            luck1 += add;
                            luck = luck1;
                            Console.Write("теперь у вас удачи\t");
                            Console.WriteLine(luck);
                            Console.Write("вам осталось распределить очков\t");
                            Console.WriteLine(x);
                            return luck1;
                        }
                        else Console.WriteLine("вы перебрали мистер");
                    }
                    else
                        Console.WriteLine("мало очков");
                    return luck;
                }
                else
                    Console.WriteLine("мало очков");
                return luck;
            }

            static int dexLVLup(int dex)
            {
                Console.Write("сколько добавить точности?\t");

                int add = Convert.ToInt32(Console.ReadLine());
                if (x > 0)
                {

                    if (x > 0)
                    {
                        if (x >= add)
                        {
                            x -= add;
                            Console.WriteLine(x);
                            dex1 = dex;
                            dex1 += add;
                            dex = dex1;
                            Console.Write("теперь у вас точность\t");
                            Console.WriteLine(dex);
                            Console.Write("вам осталось распределить очков\t");
                            Console.WriteLine(x);
                            return dex1;
                        }
                        else Console.WriteLine("вы перебрали мистер");
                    }
                    else
                        Console.WriteLine("мало очков");
                    return dex;
                }
                else
                    Console.WriteLine("мало очков");
                return dex;
            }

        }
    }



