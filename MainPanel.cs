using Rollespil.Races; 
using Rollespil.SpellCalses;
using Rollespil.SpellClases;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
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
        public static int change = 0;

        public static string yourClass = "";
        public static string yesOrNo;
        public static string name;
        public static string MagicalClass;
        public static string yourRace;

        //Die and chi stuff
        public static int numberOfSides;
        public static int dieResult;
        public static int numberOfRolls;
        public static int totalDieResult;

        public static List<double> Position = new List<double>();
        public static List<double> Expected = new List<double>();
        public static List<double> Observed = new List<double>();
        public static List<double> OE = new List<double>();
        public static List<double> OELifted = new List<double>();
        public static List<double> OELiftedAndDivided = new List<double>();

        public static bool advantageOrNot = false;
        public static bool disadvantageOrNot = false;

        ///Uniques
        //Barbarian
        public static bool barbarianOrNot = false;
        public static int rages;

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



        //Spells
        public static int[] levelSpellSlots = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] trueSpellslots = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static string YourSpells;
        public static string[] allSpellLevels = { "1'st Level Spells: ", "2'nd Level Spells: ", "3rd Level Spells: ", "4'th Level Spells: ", "5'th Level Spells: ", "6'th Level Spells: ", "7'th Level Spells: ", "8'th Level Spells: ", "9'th Level Spells: " };

        public static bool levelUpSpells = false;

        public static List<string> Spells = new List<string>();

        ///Weapons
        public static string searchTool;

        //Damage type
        public static int searchIntBlud;
        public static int searchFire;
        public static int searchNec;
        public static int searchPier;
        public static int searchRadiant;
        public static int searchSlash;

        //Range
        public static int Melee;
        public static int Ranged;

        //Properties
        public static int Ammu;
        public static int Burst;
        public static int Expl;
        public static int Fine;
        public static int Heavy;
        public static int Light;
        public static int Load;
        public static int Mis;
        public static int Reach;
        public static int Re;
        public static int Special;
        public static int Thrown;
        public static int Two;
        public static int Ver;

        //Complexity
        public static int searchMartial;
        public static int searchSimple;
        public static int searchFirearms;

        //Classes and Races
        public static string[] Classess = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
        public static double[] HitDice = { 12, 8, 8, 8, 10, 8, 10, 10, 8, 6, 8, 6 };
        public static string[] Races = { "Dwarf", "Elf", "Halfling", "Human", "Dragonborn", "Gnome", "Half-Elf", "Half-Orc", "Tiefling" };

        public static bool SpeelsOrNot = false;
        public static bool SpellTotal = false;

        public static double[] SavingThrows = { 0, 0, 0, 0, 0, 0 };
        public static bool[] deathSavingProfieciency = { false, false, false, false, false, false };


        //Stats and Skills
        public static string[] AllThings = { "Strength: ", "Dexterity: ", "Constitition: ", "Intelligence: ", "Wisdom: ", "Charisma: " };
        public static int[] StatValue = { 0, 0, 0, 0, 0, 0 };

        public static string Str = "Athletics: ";
        public static double[] StrMods = { 0 };
        public static bool[] strProOrNot = { false };

        public static string[] Dex = { "Acrobatics: ", "Sleight of hand: ", "Stealth: " };
        public static double[] DexMods = { 0, 0, 0 };
        public static bool[] dexProOrNot = { false, false, false };

        public static string[] Int = { "Arcana: ", "History: ", "Investigation: ", "Nature: ", "Religion: " };
        public static double[] IntMods = { 0, 0, 0, 0, 0 };
        public static bool[] IntProOrNot = { false, false, false, false, false };

        public static string[] Wis = { "Animal Handling: ", "Insight: ", "Medicine: ", "Perception: ", "Survival: " };
        public static double[] WisMods = { 0, 0, 0, 0, 0 };
        public static bool[] wisProOrNot = { false, false, false, false, false };

        public static string[] Cha = { "Deception: ", "Intimidation: ", "Perfermance: ", "Persuasion: " };
        public static double[] ChaMods = { 0, 0, 0, 0 };
        public static bool[] chaProOrNot = { false, false, false, false };


        //Modifiers
        public static double[] Modifier = { 0, 0, 0, 0, 0, 0 };

        public static int atributes = 0;


        ///Rando
        // A-Z
        public static string[] AZ = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Z" };

        //a-z
        public static string[] az = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "z" };

        //Stats
        public static string RandoName;
        public static string firstLetter;
        public static string letter;
        public static string restName;
        public static string firstName;
        public static string lastName;

        public static int nameLetters;


        //No spell class
        public static void BarbarianInThisClass()
        {
            SpellTotal = false;
            SpeelsOrNot = false;
            SorcererOrNot = false;

            deathSavingProfieciency[0] = true;
            deathSavingProfieciency[2] = true;

        }

        public static void BardInThisClass()
        {
            deathSavingProfieciency[1] = true;
            deathSavingProfieciency[5] = true;
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

            deathSavingProfieciency[4] = true;
            deathSavingProfieciency[5] = true;
        }

        public static void DruidInThisClass()
        {
            deathSavingProfieciency[3] = true;
            deathSavingProfieciency[4] = true;
        }

        //No spell class
        public static void FighterInThisClass()
        {
            SpellTotal = false;
            SpeelsOrNot = false;
            SorcererOrNot = false;

            deathSavingProfieciency[0] = true;
            deathSavingProfieciency[2] = true;
        }

        //No spell class
        public static void MonkInThisClass()
        {
            deathSavingProfieciency[0] = true;
            deathSavingProfieciency[1] = true;
        }

        public static void PaladinInThisClass()
        {
            deathSavingProfieciency[4] = true;
            deathSavingProfieciency[5] = true;
        }

        public static void RangerInThisClass()
        {
            deathSavingProfieciency[0] = true;
            deathSavingProfieciency[1] = true;
        }

        //No spell class
        public static void RogueInThisClass()
        {
            SpellTotal = false;
            SpeelsOrNot = false;
            SorcererOrNot = false;


            deathSavingProfieciency[3] = true;
            deathSavingProfieciency[1] = true;
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


            deathSavingProfieciency[3] = true;
            deathSavingProfieciency[5] = true;

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
            {
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
            }

            //Spells from Your Level
            {
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

                //Invications
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

                //What Spells you can lern
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
            {
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
            }

            trueSpellSlot = spellSlots;
            //Arcadiums
            {
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
            }

            // levelSpellSlots[5, 6, 7, 8]

            //Savingthrows

            deathSavingProfieciency[4] = true;
            deathSavingProfieciency[5] = true;

        }

        public static void WizardInThisClass()
        {

            deathSavingProfieciency[4] = true;
            deathSavingProfieciency[3] = true;

        }

        public static void Random()
        {
            do
            {
                atributes = 0;

                firstName = "";
                lastName = "";
                restName = "";

                //First letter of firstname
                firstLetter = AZ[rng.Next(0, AZ.Length)];

                //Lenght of firstname
                nameLetters = rng.Next(1, 8);

                //Letters in firstname
                for (int i = 0; i < nameLetters; i++)
                {
                    letter = az[rng.Next(0, az.Length)];
                    restName = restName + letter;
                }

                //First Name
                firstName = firstLetter + restName;

                //First letter of lastname
                firstLetter = AZ[rng.Next(0, AZ.Length)];

                //Lenght of name of lastname
                nameLetters = rng.Next(1, 8);

                //Letters in the lastname
                for (int i = 0; i < nameLetters; i++)
                {
                    letter = az[rng.Next(0, az.Length)];
                    restName = restName + letter;
                }

                //lastame
                lastName = firstLetter + restName;

                //Fullname
                RandoName = firstName + " " + lastName;

                Console.Write("Is " + RandoName + " good: ");
                yesOrNo = Console.ReadLine();
            } while (yesOrNo != "yes" && yesOrNo != "Yes" && yesOrNo != "YES");

            ////
            ////
            ////

            yourRace = Races[rng.Next(0, Races.Length)];
            Console.WriteLine("Race: " + yourRace);

            MagicalClass = Classess[rng.Next(0, Classess.Length)];
            Console.WriteLine("Class: " + MagicalClass);

            Level = rng.Next(1, 21);
            Console.WriteLine("Level: " + Level);

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
            {
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
            }
            Console.WriteLine();

            //Calculation of Modifieres
            foreach (string Abillity in AllThings)
            {

                StatValue[atributes] = rng.Next(8, 20);
                Console.WriteLine(Abillity + StatValue[atributes]);

                atributes++;
            }


            //Modifiers
            foreach (int stat in StatValue)
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

            if (MaxHealth < YourHitDice)
            {
                MaxHealth = YourHitDice + (Level - 1);
            }

            //Skills
            counter = 0;
            Console.WriteLine();
            Console.WriteLine("Are you trained in this? (Y for yes, N for no) ");
            Console.WriteLine();
            counter = 0;

            // Class Spells
            {
                //Bard
                if (yourClass == Classess[1])
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

                // Cleric
                if (yourClass == Classess[2])
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

                // Druid
                if (yourClass == Classess[3])
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

                // Paladin
                if (yourClass == Classess[6])
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

                // Ranger
                if (yourClass == Classess[7])
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

                // Sorcerer
                if (yourClass == Classess[9])
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

                // Warlock
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

                // Wizard
                if (yourClass == Classess[11])
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
            }

            Console.WriteLine();
            Console.WriteLine();
            counter = 0;
            // Skill proficiancies
            {
                //Str
                {
                    Console.WriteLine(AllThings[0]);
                    Console.Write(Str);
                    yesOrNo = Convert.ToString(rng.Next(1, 3));

                    if (yesOrNo == "1")
                    {
                        yesOrNo = "y";
                    }

                    if (yesOrNo == "2")
                    {
                        yesOrNo = "n";
                    }

                    if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                    {
                        strProOrNot[counter] = true;
                        StrMods[counter] = Modifier[0] + ProficiencyBonus;
                        counter++;
                    }

                    if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                    {
                        StrMods[counter] = Modifier[0];
                        counter++;
                    }
                }

                //Dex
                counter = 0;

                Console.WriteLine();
                Console.WriteLine(AllThings[1]);
                foreach (string skill in Dex)
                {
                    Console.WriteLine(skill);
                    yesOrNo = Convert.ToString(rng.Next(1, 3));

                    if (yesOrNo == "1")
                    {
                        yesOrNo = "y";
                    }

                    if (yesOrNo == "2")
                    {
                        yesOrNo = "n";
                    }

                    if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                    {
                        dexProOrNot[counter] = true;
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
                    Console.WriteLine(skill);
                    yesOrNo = Convert.ToString(rng.Next(1, 3));

                    if (yesOrNo == "1")
                    {
                        yesOrNo = "y";
                    }

                    if (yesOrNo == "2")
                    {
                        yesOrNo = "n";
                    }

                    if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                    {
                        IntProOrNot[counter] = true;
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
                    Console.WriteLine(skill);
                    yesOrNo = Convert.ToString(rng.Next(1, 3));

                    if (yesOrNo == "1")
                    {
                        yesOrNo = "y";
                    }

                    if (yesOrNo == "2")
                    {
                        yesOrNo = "n";
                    }

                    if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                    {
                        wisProOrNot[counter] = true;
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
                    yesOrNo = Convert.ToString(rng.Next(1, 3));

                    if (yesOrNo == "1")
                    {
                        yesOrNo = "y";
                    }

                    if (yesOrNo == "2")
                    {
                        yesOrNo = "n";
                    }

                    if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                    {
                        chaProOrNot[counter] = true;
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

        public static void Essentials()
        {
            SorcererOrNot = false;
            warlockOrNot = false;

            atributes = 0;

            Console.Write("Name: ");
            name = Console.ReadLine();

            //Rando have entered the building
            if (name == "Rando")
            {
                Random();
            }

            if (name != "Rando")
            {

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
                    StatValue[atributes] = Convert.ToInt32(Console.ReadLine());

                    atributes++;
                }


                //Modifiers
                foreach (int stat in StatValue)
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

                // Class Spells
                {
                    //Bard
                    if (yourClass == Classess[1])
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

                    // Cleric
                    if (yourClass == Classess[2])
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

                    // Druid
                    if (yourClass == Classess[3])
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

                    // Paladin
                    if (yourClass == Classess[6])
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

                    // Ranger
                    if (yourClass == Classess[7])
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

                    // Sorcerer
                    if (yourClass == Classess[9])
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

                    // Warlock
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

                    // Wizard
                    if (yourClass == Classess[11])
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
                }

                Console.WriteLine();
                Console.WriteLine();
                counter = 0;
                // Skill proficiancies
                {
                    //Str
                    {
                        Console.WriteLine(AllThings[0]);
                        Console.Write(Str);
                        yesOrNo = Console.ReadLine();

                        if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                        {
                            strProOrNot[counter] = true;
                            StrMods[counter] = Modifier[0] + ProficiencyBonus;
                            counter++;
                        }

                        if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                        {
                            StrMods[counter] = Modifier[0];
                            counter++;
                        }
                    }

                    //Dex
                    {
                        counter = 0;

                        Console.WriteLine();
                        Console.WriteLine(AllThings[1]);
                        foreach (string skill in Dex)
                        {
                            Console.Write(skill);
                            yesOrNo = Console.ReadLine();

                            if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                            {
                                dexProOrNot[counter] = true;
                                DexMods[counter] = Modifier[1] + ProficiencyBonus;
                                counter++;
                            }

                            if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                            {
                                DexMods[counter] = Modifier[1];
                                counter++;
                            }
                        }
                    }

                    //Int
                    {
                        counter = 0;

                        Console.WriteLine();
                        Console.WriteLine(AllThings[3]);
                        foreach (string skill in Int)
                        {
                            Console.Write(skill);
                            yesOrNo = Console.ReadLine();

                            if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                            {
                                IntProOrNot[counter] = true;
                                IntMods[counter] = Modifier[3] + ProficiencyBonus;
                                counter++;
                            }

                            if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                            {
                                IntMods[counter] = Modifier[3];
                                counter++;
                            }
                        }
                    }

                    //Wis
                    {
                        counter = 0;

                        Console.WriteLine();
                        Console.WriteLine(AllThings[4]);
                        foreach (string skill in Wis)
                        {
                            Console.Write(skill);
                            yesOrNo = Console.ReadLine();

                            if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                            {
                                wisProOrNot[counter] = true;
                                WisMods[counter] = Modifier[4] + ProficiencyBonus;
                                counter++;
                            }

                            if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                            {
                                WisMods[counter] = Modifier[4];
                                counter++;
                            }
                        }
                    }

                    //Cha
                    {
                        counter = 0;

                        Console.WriteLine();
                        Console.WriteLine(AllThings[5]);
                        foreach (string skill in Cha)
                        {
                            Console.Write(skill);
                            yesOrNo = Console.ReadLine();

                            if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                            {
                                chaProOrNot[counter] = true;
                                ChaMods[counter] = Modifier[5] + ProficiencyBonus;
                                counter++;
                            }

                            if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                            {
                                ChaMods[counter] = Modifier[5];
                                counter++;
                            }
                        }
                    }

                    counter = 0;
                }
                Console.WriteLine();
                Console.WriteLine("Is this your savingthrow (Y for yes, N for no) ");

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
            if (name == RandoName)
            {
                name = RandoName;
            }
        }

        public static void Print()
        {
            ////////////////
            Console.Clear();
            ////////////////


            /// Character Print

            ///Name, Class, Health and Level
            if (name != "Rando")
            {
                Console.WriteLine(name + " The " + yourRace + "-" + MagicalClass + " " + "Level: " + Level + "         Health: " + Health + "/" + MaxHealth);
                Console.WriteLine();
                Console.WriteLine("Amor class: " + AC + "      Initiative: " + Initiative + "      Speed: " + WalkingSpeed);
            }

            //Rando
            if (name == "Rando")
            {
                Console.WriteLine(RandoName + " The " + yourRace + "-" + MagicalClass + " " + "Level: " + Level + "         Health: " + Health + "/" + MaxHealth);
                Console.WriteLine();
                Console.WriteLine("Amor class: " + AC + "      Initiative: " + Initiative + "      Speed: " + WalkingSpeed);
            }

            Console.WriteLine();

            //Sorcerer points 
            {
                if (SorcererOrNot == true)
                {
                    Console.WriteLine("You have " + SorcererPoints + " ready for use");
                }

                if (SpeelsOrNot == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("spellAttackBonus: " + spellAttackBonus + "      " + "Spell Sacve DC: " + SpellSacveDC + "      " + "SpellcastingAbility: " + SpellcastingAbility + "       ");
                    Console.WriteLine();
                    if (warlockOrNot == true)
                    {
                        Console.WriteLine("Spell slots: " + spellSlots);
                        Console.WriteLine();
                    }
                }

                if (SorcererOrNot == true)
                {
                    Console.WriteLine("You have " + SorcererPoints + " to spend");
                }
            }

            //Modifiers
            foreach (int stat in StatValue)
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

            //Modifiers
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


            counter = 0;
            foreach (string things in AllThings)
            {
                if (deathSavingProfieciency[counter] == false)
                {
                    SavingThrows[counter] = Modifier[counter];
                }

                if (deathSavingProfieciency[counter] == true)
                {
                    SavingThrows[counter] = (Modifier[counter ] + ProficiencyBonus);
                  
                }
                counter++;
            }
            counter = 0;

            foreach (string thing in AllThings)
            {
                Console.WriteLine(thing + SavingThrows[counter]);
                counter++;
            }

            //Passive Perception
            Console.WriteLine();
            Console.WriteLine("Passive Wisdom (Perception): " + (WisMods[3] + 10));
            Console.WriteLine();

            //Skills Calc
            {
                counter = 0;
                //Str
                {
                    foreach (int skill in StrMods)
                    {
                        if (strProOrNot [counter]==true )
                        {
                            StrMods [counter ] = Modifier[0] + ProficiencyBonus;
                        }

                        if (strProOrNot[counter] == false )
                        {
                            StrMods[counter] = Modifier[0];
                        }
                        counter++;
                    }
                }

                counter = 0;
                //Dex
                {
                    foreach (int skill in DexMods)
                    {
                        if (dexProOrNot[counter] == true)
                        {
                            DexMods[counter] = Modifier[1] + ProficiencyBonus;
                        }


                        if (dexProOrNot[counter] == false)
                        {
                            DexMods[counter] = Modifier[1];
                        }
                        counter++;
                    }
                }

                counter = 0;
                //Int
                {
                    foreach (int skill in IntMods)
                    {
                        if (IntProOrNot[counter] == true)
                        {
                            IntMods[counter] = Modifier[3] + ProficiencyBonus;
                        }


                        if (IntProOrNot[counter] == false)
                        {
                            IntMods[counter] = Modifier[3];
                        }
                        counter++;
                    }
                }

                counter = 0;
                //Wis
                {
                    foreach (int skill in WisMods)
                    {
                        if (wisProOrNot[counter ] == true)
                        {
                            WisMods[counter] = Modifier[4] + ProficiencyBonus;
                        }

                        if (wisProOrNot[counter] ==false )
                        {
                            WisMods[counter] = Modifier[4];
                        }
                        counter++;
                    }
                }

                counter = 0;
                //Cha
                {
                    foreach (int skill in ChaMods)
                    {
                        if (chaProOrNot[counter ] == true)
                        {
                            ChaMods[counter] = Modifier[5] + ProficiencyBonus;
                        }

                        if (chaProOrNot[counter] ==false )
                        {
                            ChaMods[counter] = Modifier[5];
                        }
                        counter++;
                    }
                }
            }

            ///Skills print
            Console.WriteLine("Skills in:");
            Console.WriteLine();
            Console.WriteLine(AllThings[0]);

            //Str skills
            Console.WriteLine(Str + StrMods[0]);

            Console.WriteLine();
            Console.WriteLine(AllThings[1]);

            counter = 0;

            //Dex skills
            foreach (string skill in Dex)
            {
                Console.WriteLine(skill + DexMods[counter]);
                counter++;
            }

            counter = 0;

            //Int mods
            Console.WriteLine();
            Console.WriteLine(AllThings[3]);
            foreach (string skill in Int)
            {
                Console.WriteLine(skill + IntMods[counter]);
                counter++;
            }

            counter = 0;

            //Wis skills
            Console.WriteLine();
            Console.WriteLine(AllThings[4]);
            foreach (string skill in Wis)
            {
                Console.WriteLine(skill + WisMods[counter]);
                counter++;
            }

            counter = 0;

            //Cha skills
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
            if (warlockOrNot == true)
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

            //Modifiers
            foreach (int stat in StatValue)
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
            if (warlockOrNot == true)
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
            Console.WriteLine();
            Console.WriteLine("d4");
            Console.WriteLine("d6");
            Console.WriteLine("d8");
            Console.WriteLine("d10");
            Console.WriteLine("d12");
            Console.WriteLine("d20");
            Console.WriteLine("d100");
            Console.WriteLine();
            Console.Write("How many sides on the dice // ");
            numberOfSides = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many dice // ");
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

        public static void keyNumberManipulator()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            Console.WriteLine("What would you like to change ");
            Console.WriteLine("|Skill| for skill modifiers");
            Console.WriteLine("|Mod| for modifiers");
            Console.WriteLine("|Save| for saving throws");
            Console.Write("// ");
            makeShiftString = Console.ReadLine();
            ///Skills
            if (makeShiftString == "Skills" || makeShiftString == "skills" || makeShiftString == "Skill" || makeShiftString == "skill" || makeShiftString == "s" || makeShiftString == "S")
            {
                Console.WriteLine("What kind of skills would you like to increase ");
                Console.WriteLine("|S| for str skills");
                Console.WriteLine("|D| for dex skills");
                Console.WriteLine("|I| for int skills");
                Console.WriteLine("|W| for wis skills");
                Console.WriteLine("|C| for cha skills");
                Console.WriteLine("|A| for all skills");
                Console.Write("// ");
                makeShiftString = Console.ReadLine();

                Console.Write("How much: ");

                //Str (S)
                if (makeShiftString == "s" || makeShiftString == "S")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    StrMods[0] = StrMods[0] + change;

                }
                counter = 0;
                //Dex (D)
                if (makeShiftString == "s" || makeShiftString == "S")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    foreach (int stat in DexMods)
                    {
                        DexMods[counter] = DexMods[counter] + change;
                        counter++;
                    }
                }

                counter = 0;
                //Int (I)
                if (makeShiftString == "i" || makeShiftString == "I")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    foreach (int stat in IntMods)
                    {
                        IntMods[counter] = IntMods[counter] + change;
                        counter++;
                    }
                }

                counter = 0;
                //Wis (W)
                if (makeShiftString == "w" || makeShiftString == "W")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    foreach (int stat in WisMods)
                    {
                        WisMods[counter] = WisMods[counter] + change;
                        counter++;
                    }
                }

                counter = 0;
                //Cha (C)
                if (makeShiftString == "c" || makeShiftString == "C")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    foreach (int stat in ChaMods)
                    {
                        ChaMods[counter] = ChaMods[counter] + change;
                        counter++;
                    }
                }

                counter = 0;
                //ALL (A)
                if (makeShiftString == "a" || makeShiftString == "A")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    foreach (int stat in StrMods)
                    {
                        StrMods[counter] = StrMods[counter] + change;
                        counter++;
                    }

                    counter = 0;

                    foreach (int stat in DexMods)
                    {
                        DexMods[counter] = DexMods[counter] + change;
                        counter++;
                    }

                    counter = 0;

                    foreach (int stat in IntMods)
                    {
                        IntMods[counter] = IntMods[counter] + change;
                        counter++;
                    }

                    counter = 0;

                    foreach (int stat in WisMods)
                    {
                        WisMods[counter] = WisMods[counter] + change;
                        counter++;
                    }

                    counter = 0;

                    foreach (int stat in ChaMods)
                    {
                        ChaMods[counter] = ChaMods[counter] + change;
                        counter++;
                    }

                    counter = 0;

                }

                change = 0;
                makeShiftString = "";
            }

            ///Mods
            if (makeShiftString == "Mod" || makeShiftString == "mod")
            {
                Console.WriteLine("What kind of skills would you like to increase ");
                Console.WriteLine("|Str| for str mods");
                Console.WriteLine("|Dex| for dex mods");
                Console.WriteLine("|Con| for cha mods");
                Console.WriteLine("|Int| for int mods");
                Console.WriteLine("|Wis| for wis mods");
                Console.WriteLine("|Cha| for cha mods");
                Console.WriteLine("|All| for all mods");
                Console.Write("// ");
                makeShiftString = Console.ReadLine();

                Console.Write("How much: ");
                counter = 0;
                //Str (Str)
                if (makeShiftString == "str" || makeShiftString == "Str")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    StatValue[0] = StatValue[0] + change;

                }

                //Dex (Dex)
                if (makeShiftString == "Dex" || makeShiftString == "dex")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    StatValue[1] = StatValue[1] + change;
                }

                //Con (con)
                if (makeShiftString == "con" || makeShiftString == "Con")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    StatValue[2] = StatValue[2] + change;
                }

                //Int (Int)
                if (makeShiftString == "int" || makeShiftString == "Int")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    StatValue[3] = StatValue[3] + change;
                }

                //Wis (Wis)
                if (makeShiftString == "wis" || makeShiftString == "Wis")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    StatValue[4] = StatValue[4] + change;
                }

                //Cha (Cha)
                if (makeShiftString == "cha" || makeShiftString == "Cha")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    StatValue[5] = StatValue[5] + change;
                }

                //ALL (All)
                if (makeShiftString == "all" || makeShiftString == "All")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    foreach (int stat in StatValue)
                    {
                        StatValue[counter] = StatValue[counter] + change;
                        counter++;
                    }

                    counter = 0;
                }

                change = 0;
                makeShiftString = "";
            }

            ///saves
            if (makeShiftString == "Save" || makeShiftString == "save")
            {
                Console.WriteLine("What kind of skills would you like to increase ");
                Console.WriteLine("|Str| for str save");
                Console.WriteLine("|Dex| for dex save");
                Console.WriteLine("|Con| for cha save");
                Console.WriteLine("|Int| for int save");
                Console.WriteLine("|Wis| for wis save");
                Console.WriteLine("|Cha| for cha save");
                Console.WriteLine("|All| for all save");
                Console.Write("// ");
                makeShiftString = Console.ReadLine();

                Console.Write("How much: ");
                counter = 0;
                //Str (Str)
                if (makeShiftString == "str" || makeShiftString == "Str")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    SavingThrows[0] = SavingThrows[0] + change;

                }

                //Dex (Dex)
                if (makeShiftString == "Dex" || makeShiftString == "dex")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    SavingThrows[1] = SavingThrows[1] + change;
                }

                //Con (con)
                if (makeShiftString == "con" || makeShiftString == "Con")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    SavingThrows[2] = SavingThrows[2] + change;
                }

                //Int (Int)
                if (makeShiftString == "int" || makeShiftString == "Int")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    SavingThrows[3] = SavingThrows[3] + change;
                }

                //Wis (Wis)
                if (makeShiftString == "wis" || makeShiftString == "Wis")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    SavingThrows[4] = SavingThrows[4] + change;
                }

                //Cha (Cha)
                if (makeShiftString == "cha" || makeShiftString == "Cha")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    SavingThrows[5] = SavingThrows[5] + change;
                }

                //ALL (All)
                if (makeShiftString == "all" || makeShiftString == "All")
                {
                    change = Convert.ToInt32(Console.ReadLine());
                    foreach (int stat in StatValue)
                    {
                        SavingThrows[counter] = SavingThrows[counter] + change;
                        counter++;
                    }

                    counter = 0;
                }

                change = 0;
                makeShiftString = "";
            }
        }

        // Useless
        public static void DieTester()
        {
            Console.Clear();
            Console.Write("What kind of dice would you like to test, a d");
            numberOfSides = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many rolls (the more the better) // ");
            numberOfRolls = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfSides; i++)
            {
                counter++;
                Position.Add(counter);
            }

            numberOfSides++;
            for (int i = 0; i < numberOfRolls; i++)
            {
                double qq = 1 / (numberOfSides - 1);
                Expected.Add(qq);
                dieResult = rng.Next(1, numberOfSides);
                Observed.Add(dieResult);
            }

            counter = 0;
            for (int i = 0; i < numberOfRolls; i++)
            {
                OE.Add(Expected[counter] - Observed[counter]);
                counter++;
            }

            counter = 0;

            for (int i = 0; i < numberOfSides - 1; i++)
            {
                Console.Write(Position[counter] + "|");
                counter++;
            }

            Console.WriteLine();
            counter = 0;

            for (int i = 0; i < numberOfSides - 1; i++)
            {
                Console.Write(Expected[counter] + "|");
                counter++;

            }

            //Console.WriteLine();
            //Position.ForEach(Console.Write);

            //Console.WriteLine();
            //Expected.ForEach(Console.Write);

            //Console.WriteLine();
            //Observed.ForEach(Console.Write);

        }

        public static void weaponShop()
        {
            Console.Clear();

            Console.WriteLine("Pick a weapon type:");

            //Damage type
            {
                Console.WriteLine("Damage type:");
                Console.WriteLine("Bludgeoning");
                Console.WriteLine("Fire");
                Console.WriteLine("Necrotic");
                Console.WriteLine("Piercing");
                Console.WriteLine("Radiant");
                Console.WriteLine("Slashing");
                Console.WriteLine();
            }

            //Properties
            {
                Console.WriteLine("Properties:");
                Console.WriteLine("Ammunition");
                Console.WriteLine("BurstFire");
                Console.WriteLine("Explosive");
                Console.WriteLine("Finesse");
                Console.WriteLine("Heavy");
                Console.WriteLine("Light");
                Console.WriteLine("Loading");
                Console.WriteLine("Misfire");
                Console.WriteLine("Reach");
                Console.WriteLine("Reload");
                Console.WriteLine("Special");
                Console.WriteLine("Thrown");
                Console.WriteLine("TwoHanded");
                Console.WriteLine("Versatile");
                Console.WriteLine();
            }

            //Range
            {
                Console.WriteLine("Range:");
                Console.WriteLine("Ranged");
                Console.WriteLine("Melee");
                Console.WriteLine();
            }

            //Complexity
            {
                Console.WriteLine("Complexity:");
                Console.WriteLine("Simple");
                Console.WriteLine("Martial");
                Console.WriteLine("Firearms");
                Console.WriteLine();
            }

            //All
            {
                Console.WriteLine("All");
            }

            //Search
            {
                //All
                {
                    Console.Write("// ");
                    searchTool = Console.ReadLine();

                    counter = 0;
                    if (searchTool == "All")
                    {
                        foreach (string things in Weapons.allWeapons)
                        {
                            Console.WriteLine(things + ":");

                            //Complexity
                            {
                                if (Weapons.firearms.Length > searchFirearms)
                                {
                                    if (Weapons.firearms[searchFirearms] == counter)
                                    {
                                        Console.Write(" Firearms");
                                        searchFirearms++;
                                    }
                                }

                                if (Weapons.martial.Length > searchMartial)
                                {
                                    if (Weapons.martial[searchMartial] == counter)
                                    {
                                        Console.Write(" Martial");
                                        searchMartial++;
                                    }
                                }

                                if (Weapons.simple.Length > searchSimple)
                                {
                                    if (Weapons.simple[searchSimple] == counter)
                                    {
                                        Console.Write(" Simple");
                                        searchSimple++;
                                    }
                                }
                            }

                            //Damage
                            {
                                Console.Write(" " + Weapons.numberOfDice[counter] + "d" + Weapons.damageDie[counter]);

                                //Damage type
                                if (Weapons.bludgeoning.Length > searchIntBlud)
                                {
                                    if (Weapons.bludgeoning[searchIntBlud] == counter)
                                    {
                                        Console.Write(" Bludgeoning");
                                        searchIntBlud++;
                                    }
                                }

                                if (Weapons.fire.Length > searchFire)
                                {
                                    if (Weapons.fire[searchFire] == counter)
                                    {
                                        Console.Write(" Fire");
                                        searchFire++;
                                    }
                                }

                                if (Weapons.necrotic.Length > searchNec)
                                {
                                    if (Weapons.necrotic[searchNec] == counter)
                                    {
                                        Console.Write(" Necrotic");
                                        searchNec++;
                                    }
                                }

                                if (Weapons.piercing.Length > searchPier)
                                {
                                    if (Weapons.piercing[searchPier] == counter)
                                    {
                                        Console.Write(" Piercing");
                                        searchPier++;
                                    }
                                }

                                if (Weapons.radiant.Length > searchRadiant)
                                {
                                    if (Weapons.radiant[searchRadiant] == counter)
                                    {
                                        Console.Write(" Radiant");
                                        searchRadiant++;
                                    }
                                }

                                if (Weapons.slashing.Length > searchSlash)
                                {
                                    if (Weapons.slashing[searchSlash] == counter)
                                    {
                                        Console.Write(" Slashing");
                                        searchSlash++;
                                    }
                                }
                            }

                            //Range
                            {
                                if (Weapons.ranged.Length > Ranged)
                                {
                                    if (Weapons.ranged[Ranged] == counter)
                                    {
                                        Console.Write(" Ranged");
                                        Ranged++;
                                    }
                                }

                                if (Weapons.melee.Length > Melee)
                                {
                                    if (Weapons.melee[Melee] == counter)
                                    {
                                        Console.Write(" Melee");
                                        Melee++;
                                    }
                                }
                            }

                            Console.WriteLine();

                            //Properties
                            {
                                if (Weapons.ammunition.Length > Ammu)
                                {
                                    if (Weapons.ammunition[Ammu] == counter)
                                    {
                                        Console.WriteLine(" -Ammunition");
                                        Ammu++;
                                    }
                                }

                                if (Weapons.burstFire.Length > Burst)
                                {
                                    if (Weapons.burstFire[Burst] == counter)
                                    {
                                        Console.WriteLine(" -Burstfire");
                                        Burst++;
                                    }
                                }

                                if (Weapons.explosive.Length > Expl)
                                {
                                    if (Weapons.explosive[Expl] == counter)
                                    {
                                        Console.WriteLine(" -Explosive");
                                        Expl++;
                                    }
                                }

                                if (Weapons.finesse.Length > Fine)
                                {
                                    if (Weapons.finesse[Fine] == counter)
                                    {
                                        Console.WriteLine(" -Finesse");
                                        Fine++;
                                    }
                                }

                                if (Weapons.heavy.Length > Heavy)
                                {
                                    if (Weapons.heavy[Heavy] == counter)
                                    {
                                        Console.WriteLine(" -Heavy");
                                        Heavy++;
                                    }
                                }

                                if (Weapons.light.Length > Light)
                                {
                                    if (Weapons.light[Light] == counter)
                                    {
                                        Console.WriteLine(" -Light");
                                        Light++;
                                    }
                                }

                                if (Weapons.loading.Length > Load)
                                {
                                    if (Weapons.loading[Load] == counter)
                                    {
                                        Console.WriteLine(" -Loading");
                                        Load++;
                                    }
                                }

                                if (Weapons.misfire.Length > Mis)
                                {
                                    if (Weapons.misfire[Mis] == counter)
                                    {
                                        Console.WriteLine(" -Misfire");
                                        Mis++;
                                    }
                                }

                                if (Weapons.reach.Length > Reach)
                                {
                                    if (Weapons.reach[Reach] == counter)
                                    {
                                        Console.WriteLine(" -Reach");
                                        Reach++;
                                    }
                                }

                                if (Weapons.reload.Length > Re)
                                {
                                    if (Weapons.reload[Re] == counter)
                                    {
                                        Console.WriteLine(" -Reload");
                                        Re++;
                                    }
                                }

                                if (Weapons.special.Length > Special)
                                {
                                    if (Weapons.special[Special] == counter)
                                    {
                                        Console.WriteLine(" -Special");
                                        Special++;
                                    }
                                }

                                if (Weapons.thrown.Length > Thrown)
                                {
                                    if (Weapons.thrown[Thrown] == counter)
                                    {
                                        Console.WriteLine(" -Thrown");
                                        Thrown++;
                                    }
                                }

                                if (Weapons.twoHanded.Length > Two)
                                {
                                    if (Weapons.twoHanded[Two] == counter)
                                    {
                                        Console.WriteLine(" -Twohanded");
                                        Two++;
                                    }
                                }

                                if (Weapons.versatile.Length > Ver)
                                {
                                    if (Weapons.versatile[Ver] == counter)
                                    {
                                        Console.WriteLine(" -Versatile");
                                        Ver++;
                                    }
                                }
                            }

                            Console.WriteLine();
                            counter++;


                        }
                    }
                }

                ///Complexity

                //Simple
                {
                    if (searchTool == "Simple")
                    {
                        foreach (int things in Weapons.simple)
                        {
                            Console.WriteLine(Weapons.allWeapons[things] + ":");

                            if (Weapons.bludgeoning[searchIntBlud] < things)
                            {
                                searchIntBlud++;
                            }

                            if (Weapons.bludgeoning[searchIntBlud] == things)
                            {
                                Console.WriteLine(" Bludgeoning");
                                searchIntBlud++;
                            }
                            Console.WriteLine();
                            counter++;
                        }
                    }
                }
                //Martial
                {
                    counter = 0;
                    if (searchTool == "Martial")
                    {
                        foreach (int things in Weapons.martial )
                        {
                            Console.WriteLine(Weapons.allWeapons[things] + ":");

                            //Complexity
                            {
                                if (Weapons.firearms.Length > searchFirearms)
                                {
                                    if (Weapons.firearms [searchFirearms] < things)
                                    {
                                        searchFirearms ++;
                                    }

                                    if (Weapons.firearms[searchFirearms] == things)
                                    {
                                        Console.Write(" Firearms");
                                        searchFirearms++;
                                    }
                                }

                                if (Weapons.martial.Length > searchMartial)
                                {

                                    if (Weapons.martial [searchMartial] < things)
                                    {
                                        searchMartial++;
                                    }

                                    if (Weapons.martial[searchMartial] == things)
                                    {
                                        Console.Write(" Martial");
                                        searchMartial++;
                                    }
                                }

                                if (Weapons.simple.Length > searchSimple)
                                {
                                    if (Weapons.simple [searchSimple] < things)
                                    {
                                        searchSimple ++;
                                    }

                                    if (Weapons.simple[searchSimple] == things)
                                    {
                                        Console.Write(" Simple");
                                        searchSimple++;
                                    }
                                }
                            }

                            //Damage
                            {
                                Console.Write(" " + Weapons.numberOfDice[things] + "d" + Weapons.damageDie[things]);

                                //Damage type
                                if (Weapons.bludgeoning.Length > searchIntBlud)
                                {
                                    if (Weapons.bludgeoning[searchIntBlud] < things)
                                    {
                                        searchIntBlud++;
                                    }

                                    if (Weapons.bludgeoning.Length > searchIntBlud)
                                    {
                                        if (Weapons.bludgeoning[searchIntBlud] == things)
                                        {
                                            Console.Write(" Bludgeoning");
                                            searchIntBlud++;
                                        }
                                    }
                                }

                                if (Weapons.fire.Length > searchFire)
                                {
                                    if (Weapons.fire [searchFire] < things)
                                    {
                                        searchFire++;
                                    }

                                    if (Weapons.fire.Length > searchFire)
                                    {
                                        if (Weapons.fire[searchFire] == things)
                                        {
                                            Console.Write(" Fire");
                                            searchFire++;
                                        }
                                    }
                                }

                                if (Weapons.necrotic.Length > searchNec)
                                {
                                    if (Weapons.necrotic [searchNec] < things)
                                    {
                                        searchNec++;
                                    }

                                    if (Weapons.necrotic .Length > searchNec)
                                    {
                                        if (Weapons.necrotic[searchNec] == things)
                                        {
                                            Console.Write(" Necrotic");
                                            searchNec++;
                                        }
                                    }
                                }

                                if (Weapons.piercing.Length > searchPier)
                                {
                                    if (Weapons.piercing [searchPier] < things)
                                    {
                                        searchPier++;
                                    }

                                    if (Weapons.piercing .Length > searchPier)
                                    {
                                        if (Weapons.piercing[searchPier] == things)
                                        {
                                            Console.Write(" Piercing");
                                            searchPier++;
                                        }
                                    }
                                }

                                if (Weapons.radiant.Length > searchRadiant)
                                {
                                    if (Weapons.radiant [searchRadiant] < things)
                                    {
                                        searchRadiant++;
                                    }

                                    if (Weapons.radiant .Length > searchRadiant)
                                    {
                                        if (Weapons.radiant[searchRadiant] == things)
                                        {
                                            Console.Write(" Radiant");
                                            searchRadiant++;
                                        }
                                    }
                                }

                                if (Weapons.slashing.Length > searchSlash)
                                {
                                    if (Weapons.slashing [searchSlash] < things)
                                    {
                                        searchSlash++;
                                    }

                                    if (Weapons.slashing.Length >= searchSlash)
                                    {
                                        if (Weapons.slashing[searchSlash] == things)
                                        {
                                            Console.Write(" Slashing");
                                            searchSlash++;
                                        }
                                    }
                                }
                            }

                            //Range
                            {
                                if (Weapons.ranged.Length > Ranged)
                                {
                                    if (Weapons.ranged [Ranged] < things)
                                    {
                                        Ranged++;
                                    }

                                    if (Weapons.ranged .Length > Ranged )
                                    {
                                        if (Weapons.ranged[Ranged] == things)
                                        {
                                            Console.Write(" Ranged");
                                            Ranged++;
                                        }
                                    }
                                }

                                if (Weapons.melee.Length > Melee)
                                {
                                    if (Weapons.melee [Melee ] < things)
                                    {
                                        Melee ++;
                                    }

                                    if (Weapons.melee .Length > Melee )
                                    {
                                        if (Weapons.melee[Melee] == things)
                                        {
                                            Console.Write(" Melee");
                                            Melee++;
                                        }
                                    }
                                }
                            }

                            Console.WriteLine();

                            ///MISSING\\\

                            //Properties
                            {
                                if (Weapons.ammunition.Length > Ammu)
                                {
                                    if (Weapons.ammunition[Ammu] == things)
                                    {
                                        Console.WriteLine(" -Ammunition");
                                        Ammu++;
                                    }
                                }

                                if (Weapons.burstFire.Length > Burst)
                                {
                                    if (Weapons.burstFire[Burst] == things)
                                    {
                                        Console.WriteLine(" -Burstfire");
                                        Burst++;
                                    }
                                }

                                if (Weapons.explosive.Length > Expl)
                                {
                                    if (Weapons.explosive[Expl] == things)
                                    {
                                        Console.WriteLine(" -Explosive");
                                        Expl++;
                                    }
                                }

                                if (Weapons.finesse.Length > Fine)
                                {
                                    if (Weapons.finesse[Fine] == things)
                                    {
                                        Console.WriteLine(" -Finesse");
                                        Fine++;
                                    }
                                }

                                if (Weapons.heavy.Length > Heavy)
                                {
                                    if (Weapons.heavy[Heavy] == things)
                                    {
                                        Console.WriteLine(" -Heavy");
                                        Heavy++;
                                    }
                                }

                                if (Weapons.light.Length > Light)
                                {
                                    if (Weapons.light[Light] == things)
                                    {
                                        Console.WriteLine(" -Light");
                                        Light++;
                                    }
                                }

                                if (Weapons.loading.Length > Load)
                                {
                                    if (Weapons.loading[Load] == things)
                                    {
                                        Console.WriteLine(" -Loading");
                                        Load++;
                                    }
                                }

                                if (Weapons.misfire.Length > Mis)
                                {
                                    if (Weapons.misfire[Mis] == things)
                                    {
                                        Console.WriteLine(" -Misfire");
                                        Mis++;
                                    }
                                }

                                if (Weapons.reach.Length > Reach)
                                {
                                    if (Weapons.reach[Reach] == things)
                                    {
                                        Console.WriteLine(" -Reach");
                                        Reach++;
                                    }
                                }

                                if (Weapons.reload.Length > Re)
                                {
                                    if (Weapons.reload[Re] == things)
                                    {
                                        Console.WriteLine(" -Reload");
                                        Re++;
                                    }
                                }

                                if (Weapons.special.Length > Special)
                                {
                                    if (Weapons.special[Special] == things)
                                    {
                                        Console.WriteLine(" -Special");
                                        Special++;
                                    }
                                }

                                if (Weapons.thrown.Length > Thrown)
                                {
                                    if (Weapons.thrown[Thrown] == things)
                                    {
                                        Console.WriteLine(" -Thrown");
                                        Thrown++;
                                    }
                                }

                                if (Weapons.twoHanded.Length > Two)
                                {
                                    if (Weapons.twoHanded[Two] == things)
                                    {
                                        Console.WriteLine(" -Twohanded");
                                        Two++;
                                    }
                                }

                                if (Weapons.versatile.Length > Ver)
                                {
                                    if (Weapons.versatile[Ver] == things)
                                    {
                                        Console.WriteLine(" -Versatile");
                                        Ver++;
                                    }
                                }
                            }

                            Console.WriteLine();
                            counter++;


                        }
                    }
                }
            }
        }

        ///Nice setup
        ///Connect the classes to the spells

        public static void Commands()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Type theese buttons to do stuff:");
            Console.WriteLine("Press |A| to change your AC:");
            Console.WriteLine("Press |D| to take damage:");
            Console.WriteLine("Press |F| to gain full health:");
            Console.WriteLine("Press |H| to Heal:");
            Console.WriteLine("Press |L| to Levelup:");
            Console.WriteLine("Press |M| to Change your modifiers:");
            Console.WriteLine("Press |R| to roll a die:");
            Console.WriteLine("Press |S| to Cast a Spell:");
            Console.WriteLine("Press |W| to add weapon(s):"); ///
            Console.WriteLine("Press |Z| to take a rest:");

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

            //Mod change (M)
            if (Exit.Key == ConsoleKey.M)
            {
                keyNumberManipulator();
            }

            //Roll die (R)
            if (Exit.Key == ConsoleKey.R)
            {
                rollDie();
            }

            //Spell casting (S)
            if (Exit.Key == ConsoleKey.S)
            {
                SpellUse();
            }

            //Weapons (W)
            if (Exit.Key == ConsoleKey.W)
            {
                weaponShop();
            }

            //Rest (Z)
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


        public static void Main(string[] args)
        {
            Essentials();
            Print();
            Commands();
            do
            {
                Print();

                if (DeadOrNot == false)
                {
                    Commands();
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
