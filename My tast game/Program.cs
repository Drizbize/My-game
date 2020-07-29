using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_tast_game
{
    class Program
    {       
        static bool isDead = false;
        static void Main(string[] args)
        {            
            bool Rule = AskYesOrNo("Show the rules of the game?");
            if(Rule)
            {
                Console.WriteLine("Hey. In this game you have to get 3 diamonds to craft a Diamond Pickaxe. Good luck!");
                bool ContinueGame = AskYesOrNo("Continue Game?");
                if (ContinueGame) //yes
                {

                }
                else
                {
                    Console.WriteLine("Ok as you want");
                    Console.ReadKey();
                }
            }            
            bool difficulty = AskYesOrNo("Difficulty of the game hard?");

            if (difficulty)
            {
                PrintMessage("sorry, the difficulty hard is not yet =)"); //yes
                Console.ReadKey();
            }
            else
            {
                bool IronPickaxe = AskYesOrNo("Do you want to take an iron pickaxe?");//no
                {
                    if (IronPickaxe)
                    {
                        bool IronSword = AskYesOrNo("do you want to take also an iron sword?"); //no,yes
                        if (IronSword) //yes
                        {
                            bool NeedToMine = AskYesOrNo("Okay, you have an iron sword and a pickaxe, you need to go to the mine, should you go to the mine?");//no,yes,yes
                            if (NeedToMine) //yes
                            {
                                bool AskKillZombie = AskYesOrNo(AskZombie());//no,yes,yes,yes
                                if (AskKillZombie) //yes
                                {
                                    bool KillZombie = AskYesOrNo("You killed a zombie and got 1 diamond. And you found an abandoned mine. Search it?");//no,yes,yes,yes,yes
                                    if (KillZombie) //yes
                                    {
                                        Console.WriteLine("After searching the mine you broke a pickaxe and found 1 diamond. You have only 2 diamonds. And you need 3! Bad luck.");
                                        isDead = true;
                                    }
                                    else  //no
                                    {
                                        bool What_Height = WhatHeight("You didn't open the chest. And he went to dig. How high are you going to dig?");//no,yes,yes,yes,yes,no
                                        if (What_Height) //yes
                                        {
                                            Console.WriteLine("You dug at height 24. But I did not find diamonds, but only iron and gold, and the pickaxe also broke");
                                            isDead = true;
                                        }
                                        else  //no
                                        {
                                            Console.WriteLine("You dug at height 11 and found 1 diamond and the pickaxe broke.");
                                            isDead = true;
                                        }
                                    }
                                }
                                else  //no
                                {
                                    bool NokillZombie = AskYesOrNo(NoKillZombie());//no,yes,yes,yes,no
                                    if (NokillZombie) //yes
                                    {
                                        Console.WriteLine("You opened the trap chest and died.");
                                        isDead = true;
                                    }
                                    else  //no
                                    {
                                        bool What_Height = WhatHeight("You didn't open the chest. And he went to dig. How high are you going to dig?");//no,yes,yes,yes,no,no
                                        if (What_Height) //yes
                                        {
                                            Console.WriteLine("You dug at height 24. But I did not find diamonds, but only iron and gold, and the pickaxe also broke.");
                                            isDead = true;
                                        }
                                        else  //no
                                        {
                                            Console.WriteLine("You dug at the 11th height and found 2 diamonds! You crafted a diamond pickaxe!");
                                            Console.WriteLine("You are win!");
                                            Console.ReadKey();
                                        }
                                    }
                                }
                            }
                            else  //no
                            {
                                GameOverMine();
                                isDead = true;
                            }
                        }
                        else  //no
                        {
                            bool NeedToMine = AskYesOrNo("Okay you have an iron pick, you need to go to the mine, should you go to the mine?");//no,yes,no
                            if (NeedToMine) //yes
                            {
                                bool AskKillZombie = AskYesOrNo(AskZombie());//no,yes,no,yes
                                if (AskKillZombie) //yes
                                {
                                    Console.WriteLine("How do you kill him with a pickaxe?");
                                    isDead = true;
                                }
                                else  //no
                                {
                                    bool NoKillZombie = AskYesOrNo(FoundChestAndZombie());//no,yes,no,yes,no
                                    if (NoKillZombie) //yes
                                    {
                                        Console.WriteLine("Digging it up, you found a skeleton spawner. The skeletons killed you.");
                                        isDead = true;
                                    }
                                    else  //no
                                    {
                                        Console.WriteLine("You can't kill a zombie with a pickaxe!");
                                        isDead = true;
                                    }
                                }
                            }
                            else  //no
                            {
                                GameOverMine();
                                isDead = true;
                            }
                        }
                    }
                    else
                    {
                        bool SwordOrPickaxe = AskSwordOrPickaxe("then do you want to take an iron sword or an iron pickaxe?");//no,no
                        if (SwordOrPickaxe)  //yes
                        {
                            bool NeedToMine = AskYesOrNo("Okay, you have an iron sword, but what are you going to do with it in the mine? Go to the mine?");//no,no,yes
                            if (NeedToMine) //yes
                            {
                                bool AskKillZombie = AskYesOrNo(AskZombie());//no,no,yes,yes
                                if (AskKillZombie) //yes
                                {
                                    bool KillZombie = AskYesOrNo("You killed a zombie and got 1 diamond. And you found an abandoned mine. Search it?");//no,no,yes,yes,yes
                                    if (KillZombie) //yes
                                    {
                                        Console.WriteLine("You searched the mine and found 1 diamond. But you don't have a pickaxe =(.");
                                        isDead = true;
                                    }
                                    else  //no
                                    {
                                        Console.WriteLine("You went to dig your mine. But you don't have a pickaxe.");
                                        isDead = true;
                                    }
                                }
                                else  //no
                                {
                                    bool NoKillZombie = AskYesOrNo(NoKillZombiAndFoundChest());//no,no,yes,yes,no
                                    if (NoKillZombie) //yes
                                    {
                                        Console.WriteLine("You opened the trap chest and died.");
                                        isDead = true;
                                    }
                                    else  //no
                                    {
                                        Console.WriteLine("You didn't open the chest. And he went to dig. But you don't have a pickaxe.");
                                        isDead = true;
                                    }
                                }
                            }
                            else  //no
                            {
                                GameOverMine();
                                isDead = true;
                            }
                        }
                        else   //no
                        {
                            bool NeedToMine = AskYesOrNo("Okay, you have an iron pickaxe. Should you go to the mine?");//no,no,no
                            if (NeedToMine) //yes
                            {
                                bool AskKillZombie = AskYesOrNo(AskZombie());//no,no,no,yes
                                if (AskKillZombie) //yes
                                {
                                    Console.WriteLine("You tried to kill the zombies but you died, you didn't have a sword.");//no,no,no,yes,yes
                                }
                                else  //no
                                {
                                    bool NoKillZombie = AskYesOrNo(FoundChestAndZombie());//no,no,no,yes,no
                                    if (NoKillZombie) //yes
                                    {
                                        Console.WriteLine("Digging it up, you found a skeleton spawner. The skeletons killed you.");
                                        isDead = true;
                                    }
                                    else  //no
                                    {
                                        Console.WriteLine("You can't kill a zombie with a pickaxe!");                                       
                                        isDead = true;
                                    }
                                }
                            }
                            else  //no
                            {
                                GameOverMine();
                                isDead = true;
                            }
                        }
                    }
                }
            }                     
            if (isDead)
            {
                Console.WriteLine("Game over!");
                Console.ReadLine();
                return;
            }

        }
        static bool AskYesOrNo(string msg)
        {
            Console.WriteLine($"{msg} (yes/no)");

            bool isAnswered = false;
            while(isAnswered == false)
            {
                string Answer = Console.ReadLine();
                if (Answer == "yes")
                {
                    return true;
                }
                else if (Answer == "no")
                {
                    return false;
                }                
                else
                {
                    PrintMessage("you should answer 'yes' or 'no'!");
                }
            }
            return false;
        }
        static bool WhatHeight(string msg)
        {
            Console.WriteLine($"{msg} (24/11)");

            bool isAnswered = false;
            while (isAnswered == false)
            {
                string Answer = Console.ReadLine();
                if (Answer == "24")
                {
                    return true;
                }
                else if (Answer == "11")
                {
                    return false;
                }
                else
                {
                    PrintMessage("you should answer '11' or '24'!");
                }
            }
            return false;
        }
            static bool AskSwordOrPickaxe(string msg)
        {
            Console.WriteLine($"{msg} (sword/pickaxe)");

            bool isAnswered = false;
            while (isAnswered == false)
            {
                string Answer = Console.ReadLine();
                if (Answer == "sword")
                {
                    return true;
                }
                else if (Answer == "pickaxe")
                {
                    return false;
                }
                else
                {
                    PrintMessage("you should answer 'sword' or 'pickaxe'!");
                }
            }
            return false;
        }
        static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        static void GameOverMine()
        {
            Console.WriteLine("You didn't go to the mine, diamonds can only be mined there!");
        }

        static string AskZombie()
        {
            return "You are already going into the mine, and on the way you meet zombie. Do you need to kill him?";
        }

        static string NoKillZombie()
        {
            return "You bypassed the zombies and went to another mine. There was a buried chest in it, with 2 diamonds in the cator. You meet a zombie and kill him. You see another chest. Open it?";
        }

        static string FoundChestAndZombie()
        {
            return "You bypassed the zombies and went to another mine. There was a buried chest in it, with 2 diamonds in the cator. You meet a zombie. Bypass him?";
        }

        static string NoKillZombiAndFoundChest()
        {
            return "You bypassed the zombies and went to another mine. There was a buried chest in it, since you don't have a pickaxe you can't dig it up. You went ahead and met a zombie and you kill him and found the chest. Open it?";
        }       
    }   
}