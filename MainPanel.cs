using Rollespil.Races;
using Rollespil.SpellCalses;
using Rollespil.SpellClases;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace Rollespil
{
    public class MainPanel
    {
        ///THE MOST IMPORTENT PIECE OF CODE///
        public static int counter = 0;
        public static bool outOfTheApp = false;
        public static bool DeadOrNot = false;

        //Technecal stuff
        public static ConsoleKeyInfo Exit;
        public static Random rng = new Random();
        public static string makeShiftString;

        //Character

        public static double ProficiencyBonus = 0;
        public static double Health = 100;
        public static double MaxHealth = 100;
        public static double YourHitDice = 0;
        public static double SpellcastingAbility = 0;
        public static double SpellSacveDC = 0;
        public static double spellAttackBonus = 0;

        public static int Level = 1;
        public static int numberOfSpells = 0;
        public static int NumberOfCantrips = 0;
        public static int newSpells;
        public static int Initiative;
        public static int spellSlots;
        public static int trueSpellSlot;
        public static int WalkingSpeed;
        public static int AC;
        public static int SpellsKnown;
        public static int SpellCounter;
        public static int SpellUsed;

        //Die stuff
        public static int numberOfSides;
        public static int dieResult;
        public static int numberOfRolls;
        public static int totalDieResult;

        public static bool advantageOrNot = false;
        public static bool disadvantageOrNot = false;

        ///Uniques
        //Sorcerer
        public static bool SorcererOrNot = false;
        public static int SorcererPoints;

        //Warlock
        public static bool warlockOrNot = false;
        public static bool[] Arcadium = { false, false, false, false };


        //Combat
        public static int DamageDone = 0;
        public static int DeathDie;
        public static int LifeDie;
        public static int DeathCounter;

        public static double DeathThreasHold = 0;

        public static string yourClass = "";
        public static string yesOrNo;
        public static string name;
        public static string MagicalClass;
        public static string yourRace;


        //Spells
        public static int[] levelSpellSlots = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] trueSpellslots = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static string YourSpells;
        public static string[] allSpellLevels = { "1'st Level Spells: ", "2'nd Level Spells: ", "3rd Level Spells: ", "4'th Level Spells: ", "5'th Level Spells: ", "6'th Level Spells: ", "7'th Level Spells: ", "8'th Level Spells: ", "9'th Level Spells: " };

        public static bool levelUpSpells = false;

        public static List<string> Spells = new List<string>();

        //Classes and Races
        public static string[] Classess = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
        public static double[] HitDice = { 12, 8, 8, 8, 10, 8, 10, 10, 8, 6, 8, 6 };
        public static string[] Races = { "Dwarf", "Elf", "Halfling", "Human", "Dragonborn", "Gnome", "Half-Elf", "Half-Orc", "Tiefling" };

        public static bool SpeelsOrNot = false;
        public static bool SpellTotal = false;

        //Stats and Skills
        public static string[] AllThings = { "Strength: ", "Dexterity: ", "Constitition: ", "Intelligence: ", "Wisdom: ", "Charisma: " };
        public static string[] StatValue = { "0", "0", "0", "0", "0", "0" };
        public static double[] SavingThrows = { 0, 0, 0, 0, 0, 0 };

        public static string Str = "Athletics: ";
        public static double[] StrMods = { 0 };

        public static string[] Dex = { "Acrobatics: ", "Sleight of hand: ", "Stealth: " };
        public static double[] DexMods = { 0, 0, 0 };

        public static string[] Int = { "Arcana: ", "History: ", "Investigation: ", "Nature: ", "Religion: " };
        public static double[] IntMods = { 0, 0, 0, 0, 0 };

        public static string[] Wis = { "Animal Handling: ", "Insight: ", "Medicine: ", "Perception: ", "Survival: " };
        public static double[] WisMods = { 0, 0, 0, 0, 0 };

        public static string[] Cha = { "Deception: ", "Intimidation: ", "Perfermance: ", "Persuasion: " };
        public static double[] ChaMods = { 0, 0, 0, 0 };

        //Modifiers
        public static double[] Modifier = { 0, 0, 0, 0, 0, 0 };

        public static int atributes = 0;

        //No spell class
        public static void BarbarianInThisClass()
        {
            SpellTotal = false;
            SpeelsOrNot = false;
            SorcererOrNot = false;


        }

        public static void BardInThisClass()
        {

        }

        public static void ClericInThisClass()
        {
            SpellTotal = false;
            SpeelsOrNot = true;
            spellAttackBonus = (ProficiencyBonus + Modifier[4]);
            SpellSacveDC = (8 + ProficiencyBonus + Modifier[4]);
            SpellcastingAbility = Modifier[4];

            //Clculate your spells
            {
                //Cantrips known
                {
                    if (Level <= 3)
                    {
                        NumberOfCantrips = 2;
                    }

                    if (Level > 3 && 10 > Level)
                    {
                        NumberOfCantrips = 4;
                    }

                    if (Level > 9)
                    {
                        NumberOfCantrips = 5;
                    }
                }

                //Spells from Your Level (1'st level spell slot)
                if (Level < 2)
                {
                    levelSpellSlots[0] = 2;
                }
                if (Level > 1 && Level < 3)
                {
                    levelSpellSlots[0] = 3;
                }
                if (Level >= 3)

                {
                    levelSpellSlots[0] = 4;
                }



                //Spells from Your Level (2'nd level spell slot)
                if (Level > 2 && Level < 4)
                {
                    levelSpellSlots[1] = 2;
                }
                if (Level > 3)
                {
                    levelSpellSlots[1] = 3;

                }


                //Spells from Your Level (3'rd level spell slot)
                if (Level > 4 && Level < 6)
                {
                    levelSpellSlots[2] = 2;
                }
                if (Level > 5)
                {
                    levelSpellSlots[2] = 3;

                }


                //Spells from Your Level (4'th level spell slot)
                if (Level > 6 && Level < 8)
                {
                    levelSpellSlots[3] = 1;
                }
                if (Level > 7 && Level < 9)
                {
                    levelSpellSlots[3] = 2;
                }
                if (Level > 8)
                {
                    levelSpellSlots[3] = 3;
                }




                //Spells from Your Level (5'th level spell slot)
                if (Level > 8 && Level < 10)
                {
                    levelSpellSlots[4] = 1;
                }
                if (Level > 9 && Level < 18)
                {
                    levelSpellSlots[4] = 2;
                }
                if (Level > 17)
                {
                    levelSpellSlots[4] = 3;
                }



                //Spells from Your Level (6'th level spell slot)
                if (Level > 10 && Level < 19)
                {
                    levelSpellSlots[5] = 1;
                }
                if (Level > 18)
                {
                    levelSpellSlots[5] = 2;
                }


                //Spells from Your Level (7'th level spell slot)
                if (Level > 13)
                {
                    levelSpellSlots[6] = 1;
                }
                if (Level > 19)
                {
                    levelSpellSlots[6] = 2;
                }


                //Spells from Your Level (8'th level spell slot)
                if (Level > 14)
                {
                    levelSpellSlots[7] = 1;

                }

                //Spells from Your Level (9'th level spell slot)
                if (Level > 16)
                {
                    levelSpellSlots[8] = 1;

                }
            }
            //Write your spells
            {
                Console.WriteLine();
                Console.WriteLine(numberOfSpells);
                Console.WriteLine();

                //What Spells you can lern
                Console.WriteLine("Please enter your " + NumberOfCantrips + " cantrips:");
                Spells.Add("Cantrips: ");
                for (int ii = 1; ii <= NumberOfCantrips; ii++)
                {
                    YourSpells = Console.ReadLine();
                    Spells.Add(YourSpells);
                }
                Spells.Add("");

                Console.WriteLine();
                Console.WriteLine("Please enter your Spells");
                Console.WriteLine();
                counter = 0;

                //Spell slots.add
                {
                    //spell slots for level 1
                    Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                    Spells.Add(allSpellLevels[counter]);
                    Console.WriteLine();
                    for (int i = 1; i <= levelSpellSlots[counter]; i++)
                    {
                        YourSpells = Console.ReadLine();
                        Spells.Add(YourSpells);
                    }
                    Spells.Add("");
                    Console.WriteLine();
                    counter++;

                    //spell slots for level 2
                    if (Level > 2)
                    {
                        Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                        Spells.Add(allSpellLevels[counter]);
                        Console.WriteLine();
                        for (int i = 1; i <= levelSpellSlots[counter]; i++)
                        {
                            YourSpells = Console.ReadLine();
                            Spells.Add(YourSpells);
                        }
                        Spells.Add("");
                        Console.WriteLine();
                        counter++;
                    }

                    //spell slots for level 3
                    if (Level > 4)
                    {
                        Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                        Spells.Add(allSpellLevels[counter]);
                        Console.WriteLine();
                        for (int i = 1; i <= levelSpellSlots[counter]; i++)
                        {
                            YourSpells = Console.ReadLine();
                            Spells.Add(YourSpells);
                        }
                        Spells.Add("");
                        Console.WriteLine();
                        counter++;
                    }

                    //spell slots for level 4
                    if (Level > 6)
                    {
                        Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                        Spells.Add(allSpellLevels[counter]);
                        Console.WriteLine();
                        for (int i = 1; i <= levelSpellSlots[counter]; i++)
                        {
                            YourSpells = Console.ReadLine();
                            Spells.Add(YourSpells);
                        }
                        Spells.Add("");
                        Console.WriteLine();
                        counter++;
                    }

                    //spell slots for level 5
                    if (Level > 8)
                    {
                        Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                        Spells.Add(allSpellLevels[counter]);
                        Console.WriteLine();
                        for (int i = 1; i <= levelSpellSlots[counter]; i++)
                        {
                            YourSpells = Console.ReadLine();
                            Spells.Add(YourSpells);
                        }
                        Spells.Add("");
                        Console.WriteLine();
                        counter++;
                    }

                    //spell slots for level 6
                    if (Level > 10)
                    {
                        Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                        Spells.Add(allSpellLevels[counter]);
                        Console.WriteLine();
                        for (int i = 1; i <= levelSpellSlots[counter]; i++)
                        {
                            YourSpells = Console.ReadLine();
                            Spells.Add(YourSpells);
                        }
                        Spells.Add("");
                        Console.WriteLine();
                        counter++;
                    }

                    //spell slots for level 7
                    if (Level > 12)
                    {
                        Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                        Spells.Add(allSpellLevels[counter]);
                        Console.WriteLine();
                        for (int i = 1; i <= levelSpellSlots[counter]; i++)
                        {
                            YourSpells = Console.ReadLine();
                            Spells.Add(YourSpells);
                        }
                        Spells.Add("");
                        Console.WriteLine();
                        counter++;
                    }

                    //spell slots for level 8
                    if (Level > 14)
                    {
                        Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                        Spells.Add(allSpellLevels[counter]);
                        Console.WriteLine();
                        for (int i = 1; i <= levelSpellSlots[counter]; i++)
                        {
                            YourSpells = Console.ReadLine();
                            Spells.Add(YourSpells);
                        }
                        Spells.Add("");
                        Console.WriteLine();
                        counter++;
                    }

                    //spell slots for level 9
                    if (Level > 16)
                    {
                        Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                        Spells.Add(allSpellLevels[counter]);
                        Console.WriteLine();
                        for (int i = 1; i <= levelSpellSlots[counter]; i++)
                        {
                            YourSpells = Console.ReadLine();
                            Spells.Add(YourSpells);
                        }
                        Spells.Add("");
                        Console.WriteLine();
                        counter++;
                    }
                }
            }

            Console.Write("Do you know more Spells? (Y for Yes, N for No) ");
            yesOrNo = Console.ReadLine();
            if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
            {
                Console.WriteLine("How many more spells do you know?");
                newSpells = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= newSpells; i++)
                {
                    YourSpells = Console.ReadLine();
                    Spells.Add(YourSpells);
                }
            }


        }

        public static void DruidInThisClass()
        {

        }

        //No spell class
        public static void FighterInThisClass()
        {
            SpellTotal = false;
            SpeelsOrNot = false;
            SorcererOrNot = false;
        }

        //No spell class
        public static void MonkInThisClass()
        {

        }

        public static void PaladinInThisClass()
        {

        }

        public static void RangerInThisClass()
        {

        }

        //No spell class
        public static void RogueInThisClass()
        {
            SpellTotal = false;
            SpeelsOrNot = false;
            SorcererOrNot = false;
        }

        public static void SorcererInThisClass()
        {
            SpeelsOrNot = true;
            SpellTotal = true;
            SorcererOrNot = true;

            spellAttackBonus = (ProficiencyBonus + Modifier[5]);
            SpellSacveDC = (8 + ProficiencyBonus + Modifier[5]);
            SpellcastingAbility = Modifier[5];

            //Clculate your spells
            {
                //Cantrips known
                {
                    if (Level <= 3)
                    {
                        NumberOfCantrips = 4;
                    }

                    if (Level > 3 && 10 > Level)
                    {
                        NumberOfCantrips = 5;
                    }

                    if (Level > 9)
                    {
                        NumberOfCantrips = 6;
                    }
                }

                //Spells from Your Level (1'st level spell slot)
                if (Level < 2)
                {
                    levelSpellSlots[0] = 2;
                }
                if (Level > 1 && Level < 3)
                {
                    levelSpellSlots[0] = 3;
                }
                if (Level >= 3)

                {
                    levelSpellSlots[0] = 4;
                }



                //Spells from Your Level (2'nd level spell slot)
                if (Level > 2 && Level < 4)
                {
                    levelSpellSlots[1] = 2;
                }
                if (Level > 3)
                {
                    levelSpellSlots[1] = 3;

                }


                //Spells from Your Level (3'rd level spell slot)
                if (Level > 4 && Level < 6)
                {
                    levelSpellSlots[2] = 2;
                }
                if (Level > 5)
                {
                    levelSpellSlots[2] = 3;

                }


                //Spells from Your Level (4'th level spell slot)
                if (Level > 6 && Level < 8)
                {
                    levelSpellSlots[3] = 1;
                }
                if (Level > 7 && Level < 9)
                {
                    levelSpellSlots[3] = 2;
                }
                if (Level > 8)
                {
                    levelSpellSlots[3] = 3;
                }




                //Spells from Your Level (5'th level spell slot)
                if (Level > 8 && Level < 10)
                {
                    levelSpellSlots[4] = 1;
                }
                if (Level > 9 && Level < 18)
                {
                    levelSpellSlots[4] = 2;
                }
                if (Level > 17)
                {
                    levelSpellSlots[4] = 3;
                }



                //Spells from Your Level (6'th level spell slot)
                if (Level > 10 && Level < 19)
                {
                    levelSpellSlots[5] = 1;
                }
                if (Level > 18)
                {
                    levelSpellSlots[5] = 2;
                }


                //Spells from Your Level (7'th level spell slot)
                if (Level > 13)
                {
                    levelSpellSlots[6] = 1;
                }
                if (Level > 19)
                {
                    levelSpellSlots[6] = 2;
                }


                //Spells from Your Level (8'th level spell slot)
                if (Level > 14)
                {
                    levelSpellSlots[7] = 1;

                }

                //Spells from Your Level (9'th level spell slot)
                if (Level > 16)
                {
                    levelSpellSlots[8] = 1;

                }
            }

            //Write your spells
            {
                Console.WriteLine();
                Console.WriteLine(numberOfSpells);
                Console.WriteLine();

                //Spells known
                if (12 > Level)
                {
                    SpellsKnown++;
                    for (int i = 0; i < Level; i++)
                    {
                        SpellsKnown++;
                    }
                }

                if (Level == 12)
                {
                    SpellsKnown = 12;
                }

                if (12 < Level && 17 > Level)
                {
                    for (int i = 10; i < Level; i = i + 2)
                    {
                        SpellsKnown = i - 1;
                    }
                }

                if (Level > 16)
                {
                    SpellsKnown = 15;
                }

                //What Spells you can lern
                Console.WriteLine("Please enter your " + NumberOfCantrips + " cantrips:");
                Spells.Add("Cantrips: ");
                for (int ii = 1; ii <= NumberOfCantrips; ii++)
                {
                    YourSpells = Console.ReadLine();
                    if (YourSpells != "skip")
                    {
                        Spells.Add(YourSpells);
                    }
                }
                YourSpells = "";
                Spells.Add(YourSpells);

                Console.WriteLine();
                Console.WriteLine("Please enter your Spells");
                Console.WriteLine();
                counter = 0;

                //spell slots for level 1
                Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                Spells.Add(allSpellLevels[counter]);
                Console.WriteLine();
                for (int i = 1; i <= levelSpellSlots[counter]; i++)
                {
                    if (YourSpells != "skip")
                    {
                        YourSpells = Console.ReadLine();
                    }

                    if (YourSpells != "skip")
                    {
                        Spells.Add(YourSpells);
                    }
                }

                YourSpells = "";
                Spells.Add(YourSpells);
                Console.WriteLine();
                counter++;

                //spell slots for level 2
                if (Level > 2)
                {
                    Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                    Spells.Add(allSpellLevels[counter]);
                    Console.WriteLine();
                    for (int i = 1; i <= levelSpellSlots[counter]; i++)
                    {
                        YourSpells = Console.ReadLine();
                        if (YourSpells != "skip")
                        {
                            Spells.Add(YourSpells);
                        }
                    }

                    YourSpells = "";
                    Spells.Add(YourSpells);
                    Console.WriteLine();
                    counter++;
                }

                //spell slots for level 3
                if (Level > 4)
                {
                    Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                    Spells.Add(allSpellLevels[counter]);
                    Console.WriteLine();
                    for (int i = 1; i <= levelSpellSlots[counter]; i++)
                    {
                        YourSpells = Console.ReadLine();
                        if (YourSpells != "skip")
                        {
                            Spells.Add(YourSpells);
                        }
                    }
                    YourSpells = "";
                    Spells.Add(YourSpells);
                    Console.WriteLine();
                    counter++;
                }

                //spell slots for level 4
                if (Level > 6)
                {
                    Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                    Spells.Add(allSpellLevels[counter]);
                    Console.WriteLine();
                    for (int i = 1; i <= levelSpellSlots[counter]; i++)
                    {
                        YourSpells = Console.ReadLine();
                        if (YourSpells != "skip")
                        {
                            Spells.Add(YourSpells);
                        }
                    }
                    YourSpells = "";
                    Spells.Add(YourSpells);
                    Console.WriteLine();
                    counter++;
                }

                //spell slots for level 5
                if (Level > 8)
                {
                    Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                    Spells.Add(allSpellLevels[counter]);
                    Console.WriteLine();
                    for (int i = 1; i <= levelSpellSlots[counter]; i++)
                    {
                        YourSpells = Console.ReadLine();
                        if (YourSpells != "skip")
                        {
                            Spells.Add(YourSpells);
                        }
                    }
                    YourSpells = "";
                    Spells.Add(YourSpells);
                    Console.WriteLine();
                    counter++;
                }

                //spell slots for level 6
                if (Level > 10)
                {
                    Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                    Spells.Add(allSpellLevels[counter]);
                    Console.WriteLine();
                    for (int i = 1; i <= levelSpellSlots[counter]; i++)
                    {
                        YourSpells = Console.ReadLine();
                        if (YourSpells != "skip")
                        {
                            Spells.Add(YourSpells);
                        }
                    }
                    YourSpells = "";
                    Spells.Add(YourSpells);
                    Console.WriteLine();
                    counter++;
                }

                //spell slots for level 7
                if (Level > 12)
                {
                    Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                    Spells.Add(allSpellLevels[counter]);
                    Console.WriteLine();
                    for (int i = 1; i <= levelSpellSlots[counter]; i++)
                    {
                        YourSpells = Console.ReadLine();
                        if (YourSpells != "skip")
                        {
                            Spells.Add(YourSpells);
                        }
                    }
                    YourSpells = "";
                    Spells.Add(YourSpells);
                    Console.WriteLine();
                    counter++;
                }

                //spell slots for level 8
                if (Level > 14)
                {
                    Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                    Spells.Add(allSpellLevels[counter]);
                    Console.WriteLine();
                    for (int i = 1; i <= levelSpellSlots[counter]; i++)
                    {
                        YourSpells = Console.ReadLine();
                        if (YourSpells != "skip")
                        {
                            Spells.Add(YourSpells);
                        }
                    }
                    YourSpells = "";
                    Spells.Add(YourSpells);
                    Console.WriteLine();
                    counter++;
                }

                //spell slots for level 9
                if (Level > 16)
                {
                    Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                    Spells.Add(allSpellLevels[counter]);
                    Console.WriteLine();
                    for (int i = 1; i <= levelSpellSlots[counter]; i++)
                    {
                        YourSpells = Console.ReadLine();
                        if (YourSpells != "skip")
                        {
                            Spells.Add(YourSpells);
                        }
                    }
                    YourSpells = "";
                    Spells.Add(YourSpells);
                    Console.WriteLine();
                    counter++;
                }
            }

            //Sorcer points
            for (int i = 0; i <= Level; i++)
            {
                SorcererPoints = i;
            }

            //More spells
            Console.Write("Do you know more Spells? (Y for Yes, N for No) ");
            yesOrNo = Console.ReadLine();
            if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
            {
                Console.WriteLine("How many more spells do you know?");
                newSpells = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= newSpells; i++)
                {
                    YourSpells = Console.ReadLine();
                    Spells.Add(YourSpells);
                }
            }

        }

        public static void WarlockInThisClass()
        {
            //Warlock lock
            warlockOrNot = true;

            SpellTotal = true;
            SpeelsOrNot = true;

            spellAttackBonus = (ProficiencyBonus + Modifier[5]);
            SpellSacveDC = (8 + ProficiencyBonus + Modifier[5]);
            SpellcastingAbility = Modifier[5];


            //Cantrips known
            if (Level < 3)
            {
                NumberOfCantrips = 2;
            }

            if (Level > 3 && 10 > Level)
            {
                NumberOfCantrips = 3;
            }

            if (Level > 9)
            {
                NumberOfCantrips = 4;
            }

            //Spells from Your Level
            for (int a = 0; a <= Level; a++)
            {
                if (Level < 9)
                {
                    numberOfSpells = (numberOfSpells + 1);
                }

                if (Level == 10)
                {
                    numberOfSpells = 10;
                }

                if (Level > 8 && Level != 10)
                {
                    numberOfSpells = 9;
                    for (int b = 10; b <= Level; b = b + 2)
                    {
                        numberOfSpells = (b - 1);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(numberOfSpells);
            Console.WriteLine();

            //What Spells you can lern
            if (Level > 1)
            {
                Console.WriteLine("All Invocations:");
                Console.WriteLine();
                foreach (string Invocation in Warlock.Invocations)
                {
                    Console.Write(Invocation);
                }
                Console.WriteLine();
            }
            Console.WriteLine("All Warlock Cantrips:");
            Console.WriteLine();

            if (Level > 0)
            {
                foreach (int Cantrips in Warlock.Cantrips)
                {
                    Console.WriteLine(SpellList.Cantrips[Cantrips]);
                }
                Console.WriteLine();

                Console.WriteLine("All 1'st Level Warlock Spells:");
                Console.WriteLine();

                foreach (int Spell in Warlock.Level1Spells)
                {
                    Console.WriteLine(SpellList.Level1Spells[Spell]);
                }
                Console.WriteLine();

                if (2 < Level)
                {
                    Console.WriteLine("All 2'nd Level Warlock Spells:");
                    Console.WriteLine();

                    foreach (int Spell in Warlock.Level2Spells)
                    {
                        Console.WriteLine(SpellList.Level2Spells[Spell]);
                    }
                    Console.WriteLine();

                    if (4 < Level)
                    {
                        Console.WriteLine("All 3'rd Level Warlock Spells:");
                        Console.WriteLine();

                        foreach (int Spell in Warlock.Level3Spells)
                        {
                            Console.WriteLine(SpellList.Level3Spells[Spell]);
                        }
                        Console.WriteLine();

                        if (6 < Level)
                        {
                            Console.WriteLine("All 4'th Level Warlock Spells:");
                            Console.WriteLine();

                            foreach (int Spell in Warlock.Level4Spells)
                            {
                                Console.WriteLine(SpellList.Level4Spells[Spell]);
                            }
                            Console.WriteLine();

                            if (8 < Level)
                            {
                                Console.WriteLine("All 5'th Level Warlock Spells:");
                                Console.WriteLine();

                                foreach (int Spell in Warlock.Level5Spells)
                                {
                                    Console.WriteLine(SpellList.Level5Spells[Spell]);
                                }
                                Console.WriteLine();

                                if (10 < Level)
                                {
                                    Console.WriteLine("All 6'th Level Warlock Spells:");
                                    Console.WriteLine();

                                    foreach (int Spell in Warlock.Level6Spells)
                                    {
                                        Console.WriteLine(SpellList.Level6Spells[Spell]);
                                    }
                                    Console.WriteLine();

                                    if (12 < Level)
                                    {
                                        Console.WriteLine("All 7'th Level Warlock Spells:");
                                        Console.WriteLine();

                                        foreach (int Spell in Warlock.Level7Spells)
                                        {
                                            Console.WriteLine(SpellList.Level7Spells[Spell]);
                                        }
                                        Console.WriteLine();

                                        if (14 < Level)
                                        {
                                            Console.WriteLine("All 8'th Level Warlock Spells:");
                                            Console.WriteLine();

                                            foreach (int Spell in Warlock.Level8Spells)
                                            {
                                                Console.WriteLine(SpellList.Level8Spells[Spell]);
                                            }
                                            Console.WriteLine();
                                            if (16 < Level)
                                            {
                                                Console.WriteLine("All 9'th Level Warlock Spells:");
                                                Console.WriteLine();

                                                foreach (int Spell in Warlock.Level9Spells)
                                                {
                                                    Console.WriteLine(SpellList.Level9Spells[Spell]);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Please enter your cantrips " + NumberOfCantrips + " Spells");
            Spells.Add("Cantrips:");
            for (int ii = 1; ii <= NumberOfCantrips; ii++)
            {
                YourSpells = Console.ReadLine();
                Spells.Add(YourSpells);
            }

            Spells.Add("");

            Console.WriteLine();
            Console.WriteLine("Please enter your " + numberOfSpells + " Spells");
            Spells.Add("Spells:");
            for (int i = 1; i <= numberOfSpells; i++)
            {
                YourSpells = Console.ReadLine();
                Spells.Add(YourSpells);
            }

            Console.Write("Do you know more Spells? (Y for Yes, N for No) ");
            yesOrNo = Console.ReadLine();
            if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
            {
                Console.Write("How many more spells do you know?");
                newSpells = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= newSpells; i++)
                {
                    YourSpells = Console.ReadLine();
                    Spells.Add(YourSpells);
                }
            }

            //Spell slots
            if (Level == 1)
            {
                spellSlots = 1;
            }

            if (Level > 1 && 11 > Level)
            {
                spellSlots = 2;
            }

            if (10 < Level && Level < 17)
            {
                spellSlots = 3;
            }

            if (Level > 16)
            {
                spellSlots = 4;
            }

            trueSpellSlot = spellSlots;
            //Arcadiums
            if (Level > 10)
            {
                Arcadium[0] = true;
            }

            if (Level > 12)
            {
                Arcadium[1] = true;
            }
            if (Level > 14)
            {
                Arcadium[2] = true;
            }

            if (Level > 16)
            {
                Arcadium[3] = true;
            }


            // levelSpellSlots[5, 6, 7, 8]



        }

        public static void WizardInThisClass()
        {

        }

        public static void Essentials()
        {
            SorcererOrNot = false;
            warlockOrNot = false;


            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Race: ");
            yourRace = Console.ReadLine();

            Console.Write("Class: ");
            MagicalClass = Console.ReadLine();

            Console.Write("Level: ");
            Level = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("Amor Class (AC): ");
            // AC = Convert.ToInt32(Console.ReadLine());

            //Finding your class
            counter = 0;
            foreach (string Yourclass in Classess)
            {
                if (MagicalClass == Yourclass)
                {
                    YourHitDice = HitDice[counter];
                    yourClass = Yourclass;
                }
                counter++;
            }
            counter = 0;

            counter = 0;

            //Prof Calc
            if (Level > 0 && Level < 5)
            {
                ProficiencyBonus = 2;
            }
            if (Level >= 5 && Level < 9)
            {
                ProficiencyBonus = 3;
            }
            if (Level >= 9 && Level < 13)
            {
                ProficiencyBonus = 4;
            }
            if (Level >= 13 && Level < 17)
            {
                ProficiencyBonus = 5;
            }
            if (Level >= 17 && Level < 21)
            {
                ProficiencyBonus = 6;
            }

            Console.WriteLine();

            //Calculation of Modifieres
            foreach (string Abillity in AllThings)
            {
                Console.Write(Abillity);
                StatValue[atributes] = Console.ReadLine();
                if (StatValue[atributes] == "")
                {
                    StatValue[atributes] = "10";
                }
                atributes++;
            }

            int[] MyStats = Array.ConvertAll(StatValue, int.Parse);


            //Modifiers
            foreach (int stat in MyStats)
            {
                if (stat > 10)
                {
                    atributes = 0;
                    for (int i = 11; i < stat; i = i + 2)
                    {
                        atributes++;
                    }
                }
                if (stat <= 10)
                {
                    atributes = 0;
                    for (int i = 9; i >= stat; i = i - 2)
                    {
                        atributes--;

                    }
                }

                Modifier[counter] = atributes;
                counter++;

            }

            //Health
            MaxHealth = (YourHitDice + Modifier[2]) + ((Modifier[2] + (((YourHitDice / 2) + 1))) * (Level - 1));

            //Skills
            counter = 0;
            Console.WriteLine();
            Console.WriteLine("Are you trained in this? (Y for yes, N for no) ");
            Console.WriteLine();
            counter = 0;

            if (yourClass == Classess[10])
            {
                foreach (int skills in Warlock.SkillsFromWarlock)
                {
                    Console.Write(SpellList.Skills[skills]);
                    counter++;
                }

                if (yourRace == Races[6])
                {
                    Console.Write(" and " + Half_Elf.Skills);
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            counter = 0;
            // Skill proficiancies
            {
                //Str
                Console.WriteLine(AllThings[0]);
                Console.Write(Str);
                yesOrNo = Console.ReadLine();

                if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                {
                    StrMods[counter] = Modifier[0] + ProficiencyBonus;
                    counter++;
                }

                if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                {
                    StrMods[counter] = Modifier[0];
                    counter++;
                }

                //Dex
                counter = 0;

                Console.WriteLine();
                Console.WriteLine(AllThings[1]);
                foreach (string skill in Dex)
                {
                    Console.Write(skill);
                    yesOrNo = Console.ReadLine();

                    if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                    {
                        DexMods[counter] = Modifier[1] + ProficiencyBonus;
                        counter++;
                    }

                    if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                    {
                        DexMods[counter] = Modifier[1];
                        counter++;
                    }
                }


                //Int
                counter = 0;

                Console.WriteLine();
                Console.WriteLine(AllThings[3]);
                foreach (string skill in Int)
                {
                    Console.Write(skill);
                    yesOrNo = Console.ReadLine();

                    if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                    {
                        IntMods[counter] = Modifier[3] + ProficiencyBonus;
                        counter++;
                    }

                    if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                    {
                        IntMods[counter] = Modifier[3];
                        counter++;
                    }
                }

                //Wis
                counter = 0;

                Console.WriteLine();
                Console.WriteLine(AllThings[4]);
                foreach (string skill in Wis)
                {
                    Console.Write(skill);
                    yesOrNo = Console.ReadLine();

                    if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                    {
                        WisMods[counter] = Modifier[4] + ProficiencyBonus;
                        counter++;
                    }

                    if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                    {
                        WisMods[counter] = Modifier[4];
                        counter++;
                    }
                }

                //Cha
                counter = 0;

                Console.WriteLine();
                Console.WriteLine(AllThings[5]);
                foreach (string skill in Cha)
                {
                    Console.Write(skill);
                    yesOrNo = Console.ReadLine();

                    if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                    {
                        ChaMods[counter] = Modifier[5] + ProficiencyBonus;
                        counter++;
                    }

                    if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                    {
                        ChaMods[counter] = Modifier[5];
                        counter++;
                    }
                }
                counter = 0;
            }
            Console.WriteLine();
            Console.WriteLine("Is this your savingthrow (Y for yes, N for no) ");

            //Savingthrows
            Console.WriteLine("Saving Throws: ");
            foreach (string things in AllThings)
            {
                Console.Write(things);
                yesOrNo = Console.ReadLine();
                if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                {
                    SavingThrows[counter] = (Modifier[counter] + ProficiencyBonus);
                    counter++;
                }
                if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                {
                    SavingThrows[counter] = Modifier[counter];
                    counter++;
                }
            }

            counter = 0;
            //Classes here!
            {
                //Barbarian
                if (yourClass == Classess[0])
                {
                    BardInThisClass();
                }

                //Bard
                if (yourClass == Classess[1])
                {
                    BardInThisClass();
                }

                //Cleric
                if (yourClass == Classess[2])
                {
                    ClericInThisClass();
                }

                //Druid
                if (yourClass == Classess[3])
                {
                    DruidInThisClass();
                }

                //Fighter
                if (yourClass == Classess[4])
                {
                    FighterInThisClass();
                }

                //Monk
                if (yourClass == Classess[5])
                {
                    MonkInThisClass();
                }

                //Paladin
                if (yourClass == Classess[6])
                {
                    PaladinInThisClass();
                }

                //Ranger 
                if (yourClass == Classess[7])
                {
                    RangerInThisClass();
                }

                //Rogue
                if (yourClass == Classess[8])
                {
                    RogueInThisClass();
                }

                //Sorcerer
                if (yourClass == Classess[9])
                {
                    SorcererInThisClass();
                }

                //Warlock
                if (yourClass == Classess[10])
                {
                    WarlockInThisClass();
                }

                //Wizard
                if (yourClass == Classess[11])
                {
                    WizardInThisClass();
                }

            }
            counter = 0;
            Health = MaxHealth;
            DeathThreasHold = 0 - MaxHealth;

        }

        public static void Print()
        {
            ////////////////
            Console.Clear();
            ////////////////


            /// Character Print

            //Name, Class, Health and Level
            Console.WriteLine(name + " The " + MagicalClass + " " + "Level: " + Level + "         Health: " + Health + "/" + MaxHealth);
            Console.WriteLine();
            Console.WriteLine("Amor class: " + AC + "      Initiative: " + Initiative + "      Speed: " + WalkingSpeed);

            //Sorcerer points 
            if (SorcererOrNot == true)
            {
                Console.WriteLine("You have " + SorcererPoints + " ready for use");
            }

            if (SpeelsOrNot == true)
            {
                Console.WriteLine();
                Console.WriteLine("spellAttackBonus: " + spellAttackBonus + "      " + "Spell Sacve DC: " + SpellSacveDC + "      " + "SpellcastingAbility: " + SpellcastingAbility + "       ");
                Console.WriteLine();
                if (warlockOrNot ==true )
                {
                    Console.WriteLine("Spell slots: " + spellSlots);
                    Console.WriteLine();
                }
            }

            if (SorcererOrNot == true)
            {
                Console.WriteLine("You have " + SorcererPoints + " to spend");
            }

            counter = 0;
            foreach (string thing in AllThings)
            {
                Console.WriteLine(thing + StatValue[counter] + " " + "(" + Modifier[counter] + ")");
                counter++;
            }

            //Stats with mods
            Console.WriteLine();
            Console.WriteLine("Proficiency Bonus: " + ProficiencyBonus);

            counter = 0;

            //Saving Throws
            Console.WriteLine();
            Console.WriteLine("Saving Throws:");
            foreach (string thing in AllThings)
            {
                Console.WriteLine(thing + SavingThrows[counter]);
                counter++;
            }

            //Passive Perception
            Console.WriteLine();
            Console.WriteLine("Passive Wisdom (Perception): " + (WisMods[3] + 10));
            Console.WriteLine();

            ///Skills print
            Console.WriteLine("Skills in:");
            Console.WriteLine();
            Console.WriteLine(AllThings[0]);
            Console.WriteLine(Str + StrMods[0]);

            Console.WriteLine();
            Console.WriteLine(AllThings[1]);

            counter = 0;

            foreach (string skill in Dex)
            {
                Console.WriteLine(skill + DexMods[counter]);
                counter++;
            }

            counter = 0;

            Console.WriteLine();
            Console.WriteLine(AllThings[3]);
            foreach (string skill in Int)
            {
                Console.WriteLine(skill + IntMods[counter]);
                counter++;
            }

            counter = 0;

            Console.WriteLine();
            Console.WriteLine(AllThings[4]);
            foreach (string skill in Wis)
            {
                Console.WriteLine(skill + WisMods[counter]);
                counter++;
            }

            counter = 0;

            Console.WriteLine();
            Console.WriteLine(AllThings[5]);
            foreach (string skill in Cha)
            {
                Console.WriteLine(skill + ChaMods[counter]);
                counter++;
            }

            counter = 0;
            //Spells Known
            if (SpellTotal == true)
            {
                Console.WriteLine();
                Console.WriteLine(SpellsKnown);
            }
            //spells
            if (SpeelsOrNot == true)
            {
                Console.WriteLine();
                ////////////////////
                Console.WriteLine();
                Console.WriteLine("Your Spells:");
                Spells.ForEach(Console.WriteLine);
                Console.WriteLine();
            }

            if (warlockOrNot == true)
            {
                counter = 6;
                foreach (bool spell in Arcadium)
                {
                    if (spell == true)
                    {
                        Spells.Add("Arcanum " + counter);
                        YourSpells = Console.ReadLine();
                        Spells.Add(YourSpells);
                        Spells.Add("");
                        counter++;
                    }
                }
            }

            counter = 0;

            //DEATH
            if (Health <= DeathThreasHold)
            {
                DeadOrNot = true;
            }

            //Death Check
            if (Health <= 0 && Health >= DeathThreasHold)
            {
                Health = 0;
                Death();

            }

        }

        public static void SpellUse()
        {
            if (warlockOrNot == false)
            {
                Console.WriteLine("What spellslot do you want to use? (Type the number that you want to use, for cantrips type |0|) ");
                Console.Write("// ");
                SpellUsed = Convert.ToInt32(Console.ReadLine());

                SpellUsed = SpellUsed - 1;

                if (levelSpellSlots[SpellUsed] <= 0 && SpellUsed != 0)
                {
                    Console.WriteLine("The spell failed");
                }

                if (levelSpellSlots[SpellUsed] > 0 && SpellUsed != 0)
                {
                    levelSpellSlots[SpellUsed] = levelSpellSlots[SpellUsed] - 1;
                }

                if (SpellUsed == 0)
                {
                    Console.WriteLine("You did it, you casted a cantrip");
                }
            }
            if (warlockOrNot == true )
            {
                spellSlots = spellSlots - 1;
            }
        }
    
        public static void LevelUp()
        {
            counter = 0;

            //Proficiency update Check
            double newProficiencyBonus = ProficiencyBonus;

            //Prof Calc
            if (Level > 0 && Level < 5)
            {
                ProficiencyBonus = 2;
            }
            if (Level >= 5 && Level < 9)
            {
                ProficiencyBonus = 3;
            }
            if (Level >= 9 && Level < 13)
            {
                ProficiencyBonus = 4;
            }
            if (Level >= 13 && Level < 17)
            {
                ProficiencyBonus = 5;
            }
            if (Level >= 17 && Level < 21)
            {
                ProficiencyBonus = 6;
            }
            counter = 0;
            //Classes here!
            {
                //Barbarian
                if (yourClass == Classess[0])
                {
                    BardInThisClass();
                }

                //Bard
                if (yourClass == Classess[1])
                {
                    BardInThisClass();
                }

                //Cleric
                if (yourClass == Classess[2])
                {
                    ClericInThisClass();
                }

                //Druid
                if (yourClass == Classess[3])
                {
                    DruidInThisClass();
                }

                //Fighter
                if (yourClass == Classess[4])
                {
                    FighterInThisClass();
                }

                //Monk
                if (yourClass == Classess[5])
                {
                    MonkInThisClass();
                }

                //Paladin
                if (yourClass == Classess[6])
                {
                    PaladinInThisClass();
                }

                //Ranger 
                if (yourClass == Classess[7])
                {
                    RangerInThisClass();
                }

                //Rogue
                if (yourClass == Classess[8])
                {
                    RogueInThisClass();
                }

                //Sorcerer
                if (yourClass == Classess[9])
                {
                    SorcererInThisClass();
                }

                //Warlock
                if (yourClass == Classess[10])
                {
                    WarlockInThisClass();
                }

                //Wizard
                if (yourClass == Classess[11])
                {
                    WizardInThisClass();
                }

            }
            counter = 0;


            int[] MyStats = Array.ConvertAll(StatValue, int.Parse);


            //Modifiers
            foreach (int stat in MyStats)
            {
                if (stat > 10)
                {
                    atributes = 0;
                    for (int i = 11; i < stat; i = i + 2)
                    {
                        atributes++;
                    }
                }
                if (stat < 10)
                {
                    atributes = 0;
                    for (int i = 9; i >= stat; i = i - 2)
                    {
                        atributes--;

                    }
                }

                Modifier[counter] = atributes;
                counter++;

            }

            //Health
            MaxHealth = (YourHitDice + Modifier[2]) + ((Modifier[2] + (((YourHitDice / 2) + 1))) * (Level - 1));


            counter = 0;

            //mods
            {
                if (ProficiencyBonus != newProficiencyBonus)
                {
                    StrMods[counter] = StrMods[counter] + 1;
                    counter++;
                }

                //Dex
                counter = 0;
                foreach (string skill in Dex)
                {
                    if (newProficiencyBonus != ProficiencyBonus)
                    {
                        DexMods[counter] = DexMods[counter] + 1;
                        counter++;
                    }
                }

                //Int
                counter = 0;
                foreach (string skill in Int)
                {
                    if (ProficiencyBonus != newProficiencyBonus)
                    {
                        IntMods[counter] = IntMods[counter] + 1;
                        counter++;
                    }
                }

                //Wis
                counter = 0;
                foreach (string skill in Wis)
                {
                    if (ProficiencyBonus != newProficiencyBonus)
                    {
                        WisMods[counter] = WisMods[counter] + 1;
                        counter++;
                    }
                }

                //Cha
                counter = 0;
                foreach (string skill in Cha)
                {
                    if (ProficiencyBonus != newProficiencyBonus)
                    {
                        ChaMods[counter] = ChaMods[counter] + 1;
                        counter++;
                    }
                }
                counter = 0;
            }

            //Savingthrows

            foreach (string things in AllThings)
            {
                if (ProficiencyBonus != newProficiencyBonus)
                {
                    SavingThrows[counter] = (SavingThrows[counter] + (ProficiencyBonus - newProficiencyBonus));
                    counter++;
                }
            }

            counter = 0;
            Health = MaxHealth;
        }

        public static void ShotRest()
        {
            if (warlockOrNot == true )
            {
                spellSlots = trueSpellSlot;
            }
        }

        public static void LongRest()
        {
            if (warlockOrNot == false)
            {
                counter = 0;
                foreach (int spellslot in trueSpellslots)
                {
                    levelSpellSlots[counter] = spellslot;
                    counter++;
                }
            }

            if (warlockOrNot == true)
            {
                spellSlots = trueSpellSlot;
            }
        }

        public static void Death()
        {
            {
                Console.WriteLine();
                Console.WriteLine("                  |||||||||||     ");
                Console.WriteLine("                |||||||||||||||   ");
                Console.WriteLine("               ||||   |||   ||||  ");
                Console.WriteLine("              |||||___|||___||||| ");
                Console.WriteLine("              ||||||||| ||||||||| ");
                Console.WriteLine("              ||||||||___|||||||| ");
                Console.WriteLine("               |||||||||||||||||  ");
                Console.WriteLine("                || || || || ||    ");
                Console.WriteLine("                                  ");
                Console.WriteLine("                || || || || ||    ");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("YOU ARE DYING");
                Console.WriteLine();
            }
                bool WhoShallRoll = false;
            
            do
            {

                LifeDie = 0;
                DeathDie = 0;
                string reroll = "";

                Console.WriteLine("Do you want me to roll for you?");
                Console.WriteLine(" or would you like to do it yourself? ");
                Console.Write("Type |Me| for you or type |You| for me ");

                //Your roll
                yesOrNo = Console.ReadLine();
                if (yesOrNo == "Me" || yesOrNo == "me" || yesOrNo == "ME")
                {
                    do
                    {

                        if (reroll != "yes" || reroll != "Yes" || reroll != "YES")
                        {
                            Console.WriteLine();
                            Console.Write("Your roll: ");
                            DeathCounter = Convert.ToInt32(Console.ReadLine());

                            if (DeathCounter > 9)
                            {
                                LifeDie++;

                                if (DeathCounter == 20)
                                {
                                    Health = 1;
                                    LifeDie = 3;
                                }

                            }

                            if (DeathCounter < 10)
                            {
                                DeathDie++;

                                if (DeathCounter == 1)
                                {
                                    DeathDie = 3;
                                }
                            }
                        }
                        WhoShallRoll = true;
                    } while (3 != DeathDie && 3 != LifeDie);

                    WhoShallRoll = true;
                }

                //Machine roll
                if (yesOrNo == "You" || yesOrNo == "you" || yesOrNo == "YOU")
                {

                    do
                    {
                        if (WhoShallRoll == true)
                        {
                            Console.Write("Wanna Reroll? Yes or No: ");
                            reroll = Console.ReadLine();
                        }

                        if (reroll != "yes" || reroll != "Yes" || reroll != "YES")
                        {
                            DeathCounter = rng.Next(1, 21);
                            if (DeathCounter > 9)
                            {
                                Console.WriteLine("You rolled a " + DeathCounter);
                                LifeDie++;

                                if (DeathCounter == 20)
                                {
                                    Health = 1;
                                    LifeDie = 3;
                                }

                            }
                            if (DeathCounter < 10)
                            {
                                Console.WriteLine("You rolled a " + DeathCounter);
                                DeathDie++;

                                if (DeathCounter == 1)
                                {
                                    DeathDie = 3;

                                }
                            }
                        }
                        WhoShallRoll = true;
                    } while (3 != DeathDie && 3 != LifeDie);
                }
                if (WhoShallRoll == false)
                {
                    Console.WriteLine("Try again, and this time, MAKE A DECISION");
                }
            } while (WhoShallRoll == false);

            if (DeathDie >= 3)
            {
                DeadOrNot = true;
            }

        }

        public static void DeathScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("                  \\\\\\\\        ////   ||||||||||||||||||   ||||          ||||");
            Console.WriteLine("                   \\\\\\\\      ////    ||||||||||||||||||   ||||          ||||");
            Console.WriteLine("                    \\\\\\\\    ////     ||||          ||||   ||||          ||||");
            Console.WriteLine("                     \\\\\\\\  ////      ||||          ||||   ||||          ||||");
            Console.WriteLine("                      \\\\\\\\////       ||||          ||||   ||||          ||||");
            Console.WriteLine("                        ||||         ||||          ||||   ||||          ||||");
            Console.WriteLine("                        ||||         ||||          ||||   ||||          ||||");
            Console.WriteLine("                        ||||         ||||          ||||   ||||          ||||");
            Console.WriteLine("                        ||||         ||||          ||||   ||||          ||||");
            Console.WriteLine("                        ||||         ||||          ||||   ||||          ||||");
            Console.WriteLine("                        ||||         ||||||||||||||||||   ||||||||||||||||||");
            Console.WriteLine("                        ||||         ||||||||||||||||||   ||||||||||||||||||");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                           ||||\\\\\\\\\\    ||||||||   |||||||   ||||\\\\\\\\\\");
            Console.WriteLine("                           |||| \\\\\\\\\\   ||||||||   |||||||   |||| \\\\\\\\\\");
            Console.WriteLine("                           ||||  \\\\\\\\\\    ||||     ||||      ||||  \\\\\\\\\\");
            Console.WriteLine("                           ||||   \\\\\\\\\\   ||||     ||||      ||||   \\\\\\\\\\");
            Console.WriteLine("                           ||||    ||||   ||||     |||||||   ||||   ||||");
            Console.WriteLine("                           ||||    ||||   ||||     |||||||   ||||   ||||");
            Console.WriteLine("                           ||||    ||||   ||||     |||||||   ||||   ||||");
            Console.WriteLine("                           ||||    ||||   ||||     ||||      ||||   ||||");
            Console.WriteLine("                           ||||   ////    ||||     ||||      ||||   ////");
            Console.WriteLine("                           ||||  ////     ||||     ||||      ||||  ////");
            Console.WriteLine("                           |||| ////    ||||||||   |||||||   |||| ////");
            Console.WriteLine("                           ||||////     ||||||||   |||||||   ||||////");
            DeadOrNot = true;
        }

        public static void SpellStuff()
        {
            counter = 0;
            foreach (int spellslot in levelSpellSlots)
            {
                trueSpellslots[counter] = spellslot;
                counter++;
            }
            counter = 0;
        }
        
        public static void rollDie()
        {
            Console.WriteLine("d4");
            Console.WriteLine("d6");
            Console.WriteLine("d8");
            Console.WriteLine("d10");
            Console.WriteLine("d12");
            Console.WriteLine("d20");
            Console.WriteLine("d100");
            Console.WriteLine();
            Console.Write("How many sides on the dice // ");
            numberOfSides = Convert.ToInt32 (Console.ReadLine());

            Console.Write("How many dice //");
            numberOfRolls = Convert.ToInt32(Console.ReadLine());

            numberOfSides++;

                for (int i = 0; i < numberOfRolls; i++)
                {
                    dieResult = rng.Next(1, numberOfSides);
                    totalDieResult = totalDieResult + dieResult;
                    Console.WriteLine(dieResult);
                }
          
                Console.WriteLine("----");
                Console.WriteLine("Total: " + totalDieResult);
                totalDieResult = 0;
            }
        ///Nice setup
        ///Any stat changes (Y,N)
        ///Witch one
        ///Dex, Int, ect
        ///All
        ///Connect the classes to the spells
       
        public static void Commands()
        {
            Console.WriteLine("Type theese buttons to do stuff:");
            Console.WriteLine("Press |A| to change your AC:");
            Console.WriteLine("Press |D| to take damage:");
            Console.WriteLine("Press |F| to gain full health:");
            Console.WriteLine("Press |H| to Heal:");
            Console.WriteLine("Press |L| to Levelup:");
            Console.WriteLine("Press |R| to roll a die:");
            Console.WriteLine("Press |S| to Cast a Spell:");
            Console.WriteLine("Press |Z| to take a rest:");
        }


        public static void Main(string[] args)
        {
            Essentials();
            Print();
            Commands();
            SpellStuff ();

            do
            {

                Print();
                Commands();

                if (DeadOrNot == false)
                {
                    //Change your AC (A)
                    if (Exit.Key == ConsoleKey.A)
                    {
                        Console.Write("What is your AC: ");
                        AC = Convert.ToInt32(Console.ReadLine());
                    }

                    //Damage (D)
                    if (Exit.Key == ConsoleKey.D)
                    {
                        Console.WriteLine();
                        Console.Write("// ");
                        DamageDone = Convert.ToInt32(Console.ReadLine());
                        Health = Health - DamageDone;

                    }

                    //Full health (F)
                    if (Exit.Key == ConsoleKey.F)
                    {
                        Console.WriteLine();
                        Health = MaxHealth;

                    }

                    //Heal (H)
                    if (Exit.Key == ConsoleKey.H)
                    {
                        Console.WriteLine();
                        Console.Write("// ");
                        DamageDone = Convert.ToInt32(Console.ReadLine());
                        Health = Health + DamageDone;

                    }

                    // Level UP (L)
                    if (Exit.Key == ConsoleKey.L)
                    {
                        Level = Level + 1;
                        Console.WriteLine("Are you sure you want to level up? (Y for yes or write N for no) ");
                        Console.WriteLine("// ");
                        yesOrNo = Console.ReadLine();

                        if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                        {
                            LevelUp();
                        }
                    }

                    //Spell casting (R)
                    if (Exit.Key == ConsoleKey.R)
                    {
                        rollDie();
                    }

                    //Spell casting (S)
                    if (Exit.Key == ConsoleKey.S)
                    {
                        SpellUse();
                    }

                    //Rest
                    if (Exit.Key == ConsoleKey.Z)
                    {
                        Console.Write("Do you want to take a |Short| or |Long| rest: // ");
                        makeShiftString = Console.ReadLine();

                        if (makeShiftString == "Long" || makeShiftString == "long")
                        {
                            LongRest();
                            makeShiftString = "";
                        }
                        if (makeShiftString == "Short" || makeShiftString == "short")
                        {
                            ShotRest();
                            makeShiftString = "";
                        }
                    }

                }

                if (DeadOrNot == true)
                {
                    DeathScreen();
                    Console.WriteLine("Press |C| for a complete reset, Press |R| for a normal reset:");

                    // Restart with another Character (C)
                    if (Exit.Key == ConsoleKey.C)
                    {
                        DeadOrNot = false;
                        Spells.Clear();
                        Console.Clear();
                        Essentials();
                        Print();
                    }
                    // Reset your Character (R)
                    if (Exit.Key == ConsoleKey.R)
                    {
                        DeadOrNot = false;
                        Health = MaxHealth;
                    }

                }

                //EXIT
                Exit = Console.ReadKey(true);
                if (Exit.Key == ConsoleKey.Escape)
                {
                    outOfTheApp = true;
                }

            } while (outOfTheApp == false);
        }

    }

}
