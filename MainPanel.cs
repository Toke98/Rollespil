using Rollespil.Races; 
using Rollespil.SpellClases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rollespil
{
    public class MainPanel
    {
        #region infoboard
        ///THE MOST IMPORTENT PIECE OF CODE///
        public static int counter = 0;
        public static int counterTwoPointO;
        public static bool outOfTheApp = false;
        public static bool DeadOrNot = false;

        ///Game Master Stuff
        #region Game Master
        public static bool GAMEMASTER = false;

        public static bool NPC = false;
        public static bool NPCUse = false;

        //Attacking
        public static bool swarmOrNot = false;
        public static bool hordeOrnot = false;

        public static int size;
        public static int multiplier;
        public static int enemyDie;
        public static int targetAC;
        public static int EnemyToHit;
        public static int howManyHit;
        public static int enemtHiy;
        public static int howManyDies;

        public static bool packTactic = false;
        public static bool bloodFrenzy = false;
        #endregion 

        //Technecal stuff
        #region Technecal stuff
        public static ConsoleKeyInfo Exit;
        public static Random rng = new Random();
        public static string makeShiftString = "";
        #endregion 

        //Totally usless mockery
        public static int idiotCounter;


        //Character
        #region Character
        public static bool player = false;
        public static int ProficiencyBonus = 0;
        public static int Health = 100;
        public static int MaxHealth = 100;
        public static int YourHitDice = 0;
        public static int SpellcastingAbility = 0;
        public static int SpellSacveDC = 0;
        public static int spellAttackBonus = 0;

        public static int Level = 1;
        public static int numberOfSpells = 0;
        public static int NumberOfCantrips = 0;
        public static int newSpells;
        public static int Initiative = 0;
        public static int spellSlots;
        public static int trueSpellSlot;
        public static int WalkingSpeed;
        public static int classWalkingBonus;
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
        #endregion 

        //Die and chi stuff
        #region DieAndStuff
        public static int numberOfSides;
        public static int dieResult;
        public static int numberOfRolls;
        public static int totalDieResult;
        public static int amountOfRolls;

        public static int carnageDice;

        public static int median;
        public static int max;
        public static int min;
        public static bool dieRolledOrNot;
        public static bool advantageOrNot = false;
        public static bool disadvantageOrNot = false;
        public static int advantage;
        #endregion 

        ///Uniques
        #region Uniques
        //Barbarian
        public static bool barbarianOrNot = false;

        public static bool rage = false;
        public static int rages;
        public static int trueRages;
        public static int rageDamage;
        public static int rageTimer;
        public static int undyingRage;
        public static int dyingRage = 10;

        public static int brutalCrit;

        //Bard
        public static bool bardOrNot = false;
        public static int bardicInspirationLeft;
        public static string bardicInspirationDie;

        //Druid
        public static bool druidOrNot = false;
        public static int wildShape;
        public static string maxCr;
        public static bool shapedOrNot;

        //Fighter
        public static bool fighterOrNot = false;
        public static bool[] fightingStyles = { false, false, false, false, false, false };
        public static bool secondWind = false;
        public static bool actionSurge = false;
        public static int surgeCounter;
        public static int extraAttack = 0;
        public static int indomitable;
        public static bool reroll = false;

        //Sorcerer
        public static bool SorcererOrNot = false;
        public static int SorcererPoints;

        //Warlock
        public static bool warlockOrNot = false;
        public static bool[] Arcadium = { false, false, false, false };
        public static string[] Arcanum = { "", "", "", "" };
        #endregion 


        ///Combat
        #region Combat
        public static bool combat = false;

        public static int combatCounter;
        public static int DamageDone = 0;
        public static int damageHolder;

        public static bool attackedOrNot = false;
        public static int attackCounter;
        public static bool spellConcentraition = false;
        public static int spellBreak;
        public static int concentraitionCounter;

        public static int DeathThreasHold = 0;

        ///Death stuff
        public static bool deathSavingThrowEnabled = false;
        public static int DeathDie;
        public static int LifeDie;
        public static int DeathCounter;

        #endregion


        //Spells
        #region Spells
        public static bool dayToDayCaster = false;
        public static int[] levelSpellSlots = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] trueSpellslots = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static string YourSpells;
        public static string[] allSpellLevels = { "1'st Level Spells: ", "2'nd Level Spells: ", "3rd Level Spells: ", "4'th Level Spells: ", "5'th Level Spells: ", "6'th Level Spells: ", "7'th Level Spells: ", "8'th Level Spells: ", "9'th Level Spells: " };

        public static bool levelUpSpells = false;

        public static List<string> Spells = new List<string>();
        #endregion 

        ///Weapons
        #region 
        public static string searchTool;

        //Your weapon
        public static List<int> yourWeapon = new List<int>();
        public static int weaponDamageDealt = 0;
        public static int toHit;
        public static int attackRoll;

        public static List<bool> weaponPro = new List<bool>();
        public static List<bool> rangedWeapon = new List<bool>();
        public static int weaponCounter;
        #endregion

        //Classes and Races
        #region Races and classes
        public static string[] Classess = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
        public static int[] HitDice = { 12, 8, 8, 8, 10, 8, 10, 10, 8, 6, 8, 6 };
        public static string[] Races = { "Dwarf", "Elf", "Halfling", "Human", "Dragonborn", "Gnome", "Half-Elf", "Half-Orc", "Tiefling" };

        public static bool SpeelsOrNot = false;
        public static bool SpellTotal = false;

        public static int[] SavingThrows = { 0, 0, 0, 0, 0, 0 };
        public static bool[] deathSavingProfieciency = { false, false, false, false, false, false };
        #endregion 

        //Skills
        #region Spells
        public static string[] AllThings = { "Strength: ", "Dexterity: ", "Constitition: ", "Intelligence: ", "Wisdom: ", "Charisma: " };
        public static int[] StatValue = { 0, 0, 0, 0, 0, 0 };

        public static string Str = "Athletics: ";
        public static int[] StrMods = { 0 };
        public static bool[] strProOrNot = { false };

        public static string[] Dex = { "Acrobatics: ", "Sleight of hand: ", "Stealth: " };
        public static int[] DexMods = { 0, 0, 0 };
        public static bool[] dexProOrNot = { false, false, false };

        public static string[] Int = { "Arcana: ", "History: ", "Investigation: ", "Nature: ", "Religion: " };
        public static int[] IntMods = { 0, 0, 0, 0, 0 };
        public static bool[] IntProOrNot = { false, false, false, false, false };

        public static string[] Wis = { "Animal Handling: ", "Insight: ", "Medicine: ", "Perception: ", "Survival: " };
        public static int[] WisMods = { 0, 0, 0, 0, 0 };
        public static bool[] wisProOrNot = { false, false, false, false, false };

        public static string[] Cha = { "Deception: ", "Intimidation: ", "Perfermance: ", "Persuasion: " };
        public static int[] ChaMods = { 0, 0, 0, 0 };
        public static bool[] chaProOrNot = { false, false, false, false };
        #endregion

        //Modifiers
        #region Modifiers
        public static int[] Modifier = { 0, 0, 0, 0, 0, 0 };

        public static int atributes = 0;
        #endregion 

        ///Rando
        #region Rando
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
        #endregion 
        #endregion

        #region  Classes
        //No spell class
        //      /
        //    \/
        public static void BarbarianInThisClass()
        {
            barbarianOrNot = true;
            bardOrNot = false;
            SpellTotal = false;
            SpeelsOrNot = false;
            SorcererOrNot = false;

            ///Anger management
            {
                //Rages
                {
                    rages = 2;

                    if (Level > 2)
                    {
                        rages = 3;
                    }

                    if (Level > 5)
                    {
                        rages = 4;
                    }

                    if (Level > 11)
                    {
                        rages = 5;
                    }

                    if (Level > 16)
                    {
                        rages = 6;
                    }

                    if (Level > 19)
                    {
                        rages = 2147483647;
                    }

                    trueRages = rages;
                }

                //Rage Attack
                {
                    rageDamage = 2;

                    if (Level > 7)
                    {
                        rageDamage = 3;
                    }

                    if (Level > 15)
                    {
                        rageDamage = 4;
                    }
                }
            }

            //Crit
            {
                if (Level > 8)
                {
                    brutalCrit = 1;
                }

                if (Level > 12)
                {
                    brutalCrit = 2;
                }

                if (Level > 16)
                {
                    brutalCrit = 3;
                }
            }

            //Walk
            {
                classWalkingBonus = 10;
            }

            deathSavingProfieciency[0] = true;
            deathSavingProfieciency[2] = true;

        }

        //      /
        //    \/
        public static void BardInThisClass()
        {
            bardOrNot = true;
            SpellTotal = true;
            SpeelsOrNot = true;
            spellAttackBonus = ProficiencyBonus + Modifier[5];
            SpellSacveDC = 8 + ProficiencyBonus + Modifier[5];
            SpellcastingAbility = Modifier[5];

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
                        NumberOfCantrips = 3;
                    }

                    if (Level > 9)
                    {
                        NumberOfCantrips = 4;
                    }
                }

                //Spells from Your Level (1'st level spell slot)
                {
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
                }


                //Spells from Your Level (2'nd level spell slot)
                {
                    if (Level > 2 && Level < 4)
                    {
                        levelSpellSlots[1] = 2;
                    }
                    if (Level > 3)
                    {
                        levelSpellSlots[1] = 3;

                    }
                }

                //Spells from Your Level (3'rd level spell slot)
                {
                    if (Level > 4 && Level < 6)
                    {
                        levelSpellSlots[2] = 2;
                    }
                    if (Level > 5)
                    {
                        levelSpellSlots[2] = 3;

                    }
                }

                //Spells from Your Level (4'th level spell slot)
                {
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
                }

                //Spells from Your Level (5'th level spell slot)
                {
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
                }

                //Spells from Your Level (6'th level spell slot)
                {
                    if (Level > 10 && Level < 19)
                    {
                        levelSpellSlots[5] = 1;
                    }
                    if (Level > 18)
                    {
                        levelSpellSlots[5] = 2;
                    }
                }

                //Spells from Your Level (7'th level spell slot)
                {
                    if (Level > 12)
                    {
                        levelSpellSlots[6] = 1;
                    }
                    if (Level > 19)
                    {
                        levelSpellSlots[6] = 2;
                    }
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
                {
                    SpellsKnown = 3;
                    if (10 > Level)
                    {
                        SpellsKnown++;
                        for (int i = 0; i < Level; i++)
                        {
                            SpellsKnown++;
                        }
                    }

                    if (Level == 10)
                    {
                        SpellsKnown = 14;
                    }

                    if (10 < Level && 13 > Level)
                    {
                        SpellsKnown = 15;
                    }

                    if (Level == 13)
                    {
                        SpellsKnown = 16;
                    }

                    if (Level == 14)
                    {
                        SpellsKnown = 18;
                    }

                    if (Level == 15 && Level == 16)
                    {
                        SpellsKnown = 19;
                    }

                    if (Level == 17)
                    {
                        SpellsKnown = 20;
                    }

                    if (Level > 17)
                    {
                        SpellsKnown = 22;
                    }
                }

                ///What Spells you can lern
                {
                    //Cantrips
                    {
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
                    }

                    Console.WriteLine();
                    Console.WriteLine("Please enter your Spells");
                    Console.WriteLine();
                    counter = 0;

                    //spell slots for level 1
                    {
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
                    }

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

            }

            //Jack of trades
            {
                if (Level > 1)
                {
                    if (strProOrNot[0] == false)
                    {
                        StrMods[0] = StrMods[0] + (ProficiencyBonus / 2);
                    }

                    counter = 0;
                    foreach (bool bonusOrNot in dexProOrNot)
                    {
                        if (bonusOrNot == false)
                        {
                            DexMods[counter] = Convert.ToInt32(DexMods[counter] + (ProficiencyBonus / 2));
                        }
                        counter++;
                    }

                    counter = 0;
                    foreach (bool bonusOrNot in wisProOrNot)
                    {
                        if (bonusOrNot == false)
                        {
                            WisMods[counter] = WisMods[counter] + (ProficiencyBonus / 2);
                        }
                        counter++;
                    }

                    counter = 0;
                    foreach (bool bonusOrNot in IntProOrNot)
                    {
                        if (bonusOrNot == false)
                        {
                            IntMods[counter] = IntMods[counter] + (ProficiencyBonus / 2);
                        }
                        counter++;
                    }

                    counter = 0;
                    foreach (bool bonusOrNot in chaProOrNot)
                    {
                        if (bonusOrNot == false)
                        {
                            ChaMods[counter] = ChaMods[counter] + (ProficiencyBonus / 2);
                        }
                        counter++;
                    }
                }
            }

            //Bardic Inspiration
            {
                bardicInspirationLeft = Convert.ToInt32(Modifier[5]);

                if (Level < 5)
                {
                    bardicInspirationDie = "1d6";
                }

                if (Level > 4)
                {
                    bardicInspirationDie = "1d8";
                }

                if (Level > 9)
                {
                    bardicInspirationDie = "1d10";
                }

                if (Level > 14)
                {
                    bardicInspirationDie = "1d12";
                }
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


            deathSavingProfieciency[1] = true;
            deathSavingProfieciency[5] = true;
        }

        //      /
        //    \/
        public static void ClericInThisClass()
        {
            SpellTotal = false;
            SpeelsOrNot = true;
            dayToDayCaster = true;
            spellAttackBonus = ProficiencyBonus + Modifier[4];
            SpellSacveDC = 8 + ProficiencyBonus + Modifier[4];
            SpellcastingAbility = Modifier[4];

            //Clculate your spell slots
            {
                //Cantrips known
                {
                    if (Level <= 3)
                    {
                        NumberOfCantrips = 3;
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
                {
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
                }

                //Spells from Your Level (2'nd level spell slot)
                {
                    if (Level > 2 && Level < 4)
                    {
                        levelSpellSlots[1] = 2;
                    }

                    if (Level > 3)
                    {
                        levelSpellSlots[1] = 3;

                    }
                }

                //Spells from Your Level (3'rd level spell slot)
                {
                    if (Level > 4 && Level < 6)
                    {
                        levelSpellSlots[2] = 2;
                    }

                    if (Level > 5)
                    {
                        levelSpellSlots[2] = 3;

                    }
                }

                //Spells from Your Level (4'th level spell slot)
                {
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
                }

                //Spells from Your Level (5'th level spell slot)
                {
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
                }


                //Spells from Your Level (6'th level spell slot)
                {
                    if (Level > 10 && Level < 19)
                    {
                        levelSpellSlots[5] = 1;
                    }

                    if (Level > 18)
                    {
                        levelSpellSlots[5] = 2;
                    }
                }

                //Spells from Your Level (7'th level spell slot)
                {
                    if (Level > 13)
                    {
                        levelSpellSlots[6] = 1;
                    }

                    if (Level > 19)
                    {
                        levelSpellSlots[6] = 2;
                    }
                }

                //Spells from Your Level (8'th level spell slot)
                {
                    if (Level > 14)
                    {
                        levelSpellSlots[7] = 1;
                    }
                }

                //Spells from Your Level (9'th level spell slot)
                {
                    if (Level > 16)
                    {
                        levelSpellSlots[8] = 1;

                    }
                }
            }

            //Write your spells
            {
                AddSpells();
            }

            deathSavingProfieciency[4] = true;
            deathSavingProfieciency[5] = true;
        }

        //      /
        //    \/
        public static void DruidInThisClass()
        {
            deathSavingProfieciency[3] = true;
            deathSavingProfieciency[4] = true;
            SpeelsOrNot = true;
            druidOrNot = true;
            dayToDayCaster = true;

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
                        NumberOfCantrips = 3;
                    }

                    if (Level > 9)
                    {
                        NumberOfCantrips = 4;
                    }
                }

                //Spells from Your Level (1'st level spell slot)
                {
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
                }

                //Spells from Your Level (2'nd level spell slot)
                {
                    if (Level > 2 && Level < 4)
                    {
                        levelSpellSlots[1] = 2;
                    }
                    if (Level > 3)
                    {
                        levelSpellSlots[1] = 3;

                    }
                }

                //Spells from Your Level (3'rd level spell slot)
                {
                    if (Level > 4 && Level < 6)
                    {
                        levelSpellSlots[2] = 2;
                    }
                    if (Level > 5)
                    {
                        levelSpellSlots[2] = 3;

                    }
                }

                //Spells from Your Level (4'th level spell slot)
                {
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
                }

                //Spells from Your Level (5'th level spell slot)
                {
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
                }

                //Spells from Your Level (6'th level spell slot)
                {
                    if (Level > 10 && Level < 19)
                    {
                        levelSpellSlots[5] = 1;
                    }
                    if (Level > 18)
                    {
                        levelSpellSlots[5] = 2;
                    }
                }

                //Spells from Your Level (7'th level spell slot)
                {
                    if (Level > 13)
                    {
                        levelSpellSlots[6] = 1;
                    }
                    if (Level > 19)
                    {
                        levelSpellSlots[6] = 2;
                    }
                }

                //Spells from Your Level (8'th level spell slot)
                {
                    if (Level > 14)
                    {
                        levelSpellSlots[7] = 1;
                    }
                }

                //Spells from Your Level (9'th level spell slot)
                {
                    if (Level > 16)
                    {
                        levelSpellSlots[8] = 1;

                    }
                }
            }

            //Wild shape
            {
                if (Level > 2)
                {
                    wildShape = 2;
                    maxCr = "Max CR 1/4, No flying or swimming speed";
                }

                if (Level > 3)
                {
                    maxCr = "Max CR 1/2, No flying speed";
                }

                if (Level > 7)
                {
                    maxCr = "Max CR 1";
                }
            }

            AddSpells();
        }

        //No spell class
        public static void FighterInThisClass()
        {
            SpellTotal = false;
            SpeelsOrNot = false;
            SorcererOrNot = false;

            //Action surrge
            {
                if (Level > 1)
                {
                    actionSurge = true;
                    surgeCounter = 1;
                }

                if (Level > 16)
                {
                    surgeCounter = 2;
                }
            }

            //Extra attack
            {
                if (Level > 4)
                {
                    extraAttack = 1;
                }

                if (Level > 10)
                {
                    extraAttack = 2;
                }

                if (Level > 19)
                {
                    extraAttack = 4;
                }
            }

            //fightingstyles
            {
                Console.WriteLine("Choose a fightingstyle");
                Console.WriteLine();
                Console.WriteLine("Type |1| for the: Archery style");
                Console.WriteLine("  Ranged weapons have +2 attack");
                Console.WriteLine();
                Console.WriteLine("Type |2| for the: Defence style");
                Console.WriteLine("  +1 to AC, when wearing amor");
                Console.WriteLine();
                Console.WriteLine("Type |3| for the: Dueling style");
                Console.WriteLine("  When wielding only one weapon +2 to attack");
                Console.WriteLine();
                Console.WriteLine("Type |4| for the: Great weapon fighting style");
                Console.WriteLine("  Twohanded and versatile weapon, when wielded with to hands,");
                Console.WriteLine("  when you roll a 1 or 2 on an attack dice you can reroll");
                Console.WriteLine();
                Console.WriteLine("Type |5| for the: Protection style");
                Console.WriteLine("  when using a shield, you can give an enemy disadvantage,");
                Console.WriteLine("  if it attacks an ally within 5 feet of you");
                Console.WriteLine();
                Console.WriteLine("Type |6| for the: Two-weaponfighting style");
                Console.WriteLine("  When using two weapon fighting,");
                Console.WriteLine("  you can add your abillity modifier to your second attack");
                Console.WriteLine();
                Console.Write("// ");

                makeShiftString = Console.ReadLine();
                fightingStyles[Convert.ToInt32(makeShiftString) - 1] = true;

            }

            //Indomitable
            {
                if (Level > 8)
                {
                    indomitable = 1;
                }

                if (Level > 12)
                {
                    indomitable = 2;
                }

                if (Level > 16)
                {
                    indomitable = 3;
                }
            }

            //Second wind
            {
                secondWind = true;
            }

            //saving throw
            {
                deathSavingProfieciency[0] = true;
                deathSavingProfieciency[2] = true;
            }

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

        //      /
        //    \/
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
                {
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
                }


                //Spells from Your Level (2'nd level spell slot)
                {
                    if (Level > 2 && Level < 4)
                    {
                        levelSpellSlots[1] = 2;
                    }

                    if (Level > 3)
                    {
                        levelSpellSlots[1] = 3;

                    }
                }

                //Spells from Your Level (3'rd level spell slot)
                {
                    if (Level > 4 && Level < 6)
                    {
                        levelSpellSlots[2] = 2;
                    }

                    if (Level > 5)
                    {
                        levelSpellSlots[2] = 3;

                    }
                }

                //Spells from Your Level (4'th level spell slot)
                {
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
                }

                //Spells from Your Level (5'th level spell slot)
                {
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
                }

                //Spells from Your Level (6'th level spell slot)
                {
                    if (Level > 10 && Level < 19)
                    {
                        levelSpellSlots[5] = 1;
                    }

                    if (Level > 18)
                    {
                        levelSpellSlots[5] = 2;
                    }
                }

                //Spells from Your Level (7'th level spell slot)
                {
                    if (Level > 12)
                    {
                        levelSpellSlots[6] = 1;
                    }

                    if (Level > 19)
                    {
                        levelSpellSlots[6] = 2;
                    }
                }

                //Spells from Your Level (8'th level spell slot)
                {
                    if (Level > 14)
                    {
                        levelSpellSlots[7] = 1;

                    }
                }

                //Spells from Your Level (9'th level spell slot)
                {
                    if (Level > 16)
                    {
                        levelSpellSlots[8] = 1;

                    }
                }
            }

            //Write your spells
            {
                Console.WriteLine();
                Console.WriteLine(numberOfSpells);
                Console.WriteLine();

                //Spells known
                {
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
                }

                ///What Spells you can lern
                {
                    //Cantrips
                    {
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
                    }

                    Console.WriteLine();
                    Console.WriteLine("Please enter your Spells");
                    Console.WriteLine();
                    counter = 0;

                    AddSpells();
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

        //      /
        //    \/
        public static void WarlockInThisClass()
        {
            //Warlock lock
            warlockOrNot = true;

            SpellTotal = true;
            SpeelsOrNot = true;

            spellAttackBonus = (ProficiencyBonus + Modifier[5]);
            SpellSacveDC = (8 + ProficiencyBonus + Modifier[5]);
            SpellcastingAbility = Modifier[5];

            //Manual
            {
                if (name != "Rando")
                {
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
                    //Arcanums
                    {
                        if (Level > 10)
                        {
                            Arcadium[0] = true;
                            Console.WriteLine("Please enter your arcanum (6'th level)");
                            Spells.Add(allSpellLevels[counter]);
                            Console.WriteLine();

                            Arcanum[0] = "Mystic Arcanum (6'th level): ";

                            Arcanum[0] = Arcanum[0] + Console.ReadLine();

                            Console.WriteLine();
                        }

                        if (Level > 12)
                        {
                            Arcadium[1] = true;

                            Console.WriteLine("Please enter your arcanum (7'th level)");
                            Spells.Add(allSpellLevels[counter]);
                            Console.WriteLine();

                            Arcanum[1] = "Mystic Arcanum (7'th level): ";

                            Arcanum[1] = Arcanum[1] + Console.ReadLine();

                            Console.WriteLine();
                        }

                        if (Level > 14)
                        {
                            Arcadium[2] = true;

                            Console.WriteLine("Please enter your arcanum (8'th level)");
                            Spells.Add(allSpellLevels[counter]);
                            Console.WriteLine();

                            Arcanum[2] = "Mystic Arcanum (8'th level): ";

                            Arcanum[2] = Arcanum[2] + Console.ReadLine();

                            Console.WriteLine();
                        }

                        if (Level > 16)
                        {
                            Arcadium[3] = true;

                            Console.WriteLine("Please enter your arcanum (9'th level)");
                            Console.WriteLine();

                            Arcanum[3] = "Mystic Arcanum (9'th level): ";

                            Arcanum[3] = Arcanum[3] + Console.ReadLine();

                            Console.WriteLine();
                        }
                    }


                }
            }

            //Random
            {
                if (name == "Rando")
                {
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

                    //Cantrips
                    Spells.Add("");

                    Console.WriteLine("Please enter your cantrips " + NumberOfCantrips + " Spells");
                    Spells.Add("Cantrips:");
                    for (int ii = 1; ii <= NumberOfCantrips; ii++)
                    {

                        do
                        {
                            YourSpells = Convert.ToString(Warlock.Cantrips[rng.Next(0, Warlock.Cantrips.Length)]);
                            YourSpells = SpellList.Cantrips[Convert.ToInt32(YourSpells)];
                            foreach (string spell in Spells)
                            {
                                if (YourSpells == spell)
                                {
                                    makeShiftString = spell;
                                }
                            }

                        } while (makeShiftString == YourSpells);
                        Spells.Add(YourSpells);
                    }

                    Spells.Add("");

                    Console.WriteLine();
                    Console.WriteLine("Please enter your " + numberOfSpells + " Spells");
                    Spells.Add("Spells:");
                    for (int i = 1; i <= numberOfSpells; i++)
                    {
                        YourSpells = Convert.ToString(rng.Next(1, 6));

                        if (YourSpells == "1")
                        {
                            do
                            {
                                YourSpells = Convert.ToString(Warlock.Level1Spells[rng.Next(0, Warlock.Level1Spells.Length)]);
                                YourSpells = SpellList.Level1Spells[Convert.ToInt32(YourSpells)];
                                foreach (string spell in Spells)
                                {
                                    if (YourSpells == spell)
                                    {
                                        makeShiftString = spell;
                                    }
                                }

                            } while (makeShiftString == YourSpells);
                        }

                        if (YourSpells == "2")
                        {
                            do
                            {
                                YourSpells = Convert.ToString(Warlock.Level2Spells[rng.Next(0, Warlock.Level2Spells.Length)]);
                                YourSpells = SpellList.Level2Spells[Convert.ToInt32(YourSpells)];
                                foreach (string spell in Spells)
                                {
                                    if (YourSpells == spell)
                                    {
                                        makeShiftString = spell;
                                    }
                                }

                            } while (makeShiftString == YourSpells);

                        }

                        if (YourSpells == "3")
                        {
                            do
                            {
                                YourSpells = Convert.ToString(Warlock.Level3Spells[rng.Next(0, Warlock.Level3Spells.Length)]);
                                YourSpells = SpellList.Level3Spells[Convert.ToInt32(YourSpells)];
                                foreach (string spell in Spells)
                                {
                                    if (YourSpells == spell)
                                    {
                                        makeShiftString = spell;
                                    }
                                }

                            } while (makeShiftString == YourSpells);
                        }

                        if (YourSpells == "4")
                        {
                            do
                            {
                                YourSpells = Convert.ToString(Warlock.Level4Spells[rng.Next(0, Warlock.Level4Spells.Length)]);
                                YourSpells = SpellList.Level4Spells[Convert.ToInt32(YourSpells)];
                                foreach (string spell in Spells)
                                {
                                    if (YourSpells == spell)
                                    {
                                        makeShiftString = spell;
                                    }
                                }

                            } while (makeShiftString == YourSpells);

                        }

                        if (YourSpells == "5")
                        {
                            do
                            {
                                YourSpells = Convert.ToString(Warlock.Level5Spells[rng.Next(0, Warlock.Level5Spells.Length)]);
                                YourSpells = SpellList.Level5Spells[Convert.ToInt32(YourSpells)];
                                foreach (string spell in Spells)
                                {
                                    if (YourSpells == spell)
                                    {
                                        makeShiftString = spell;
                                    }
                                }

                            } while (makeShiftString == YourSpells);

                        }
                        Spells.Add(YourSpells);
                    }

                    Spells.Add("");


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
                    //Arcanums
                    {
                        if (Level > 10)
                        {
                            Arcadium[0] = true;
                            Console.WriteLine("Please enter your arcanum (6'th level)");

                            Console.WriteLine();

                            Arcanum[0] = "Mystic Arcanum (6'th level): ";

                            Arcanum[0] = Arcanum[0] + SpellList.Level6Spells[Warlock.Level6Spells[rng.Next(0, Warlock.Level6Spells.Length)]];

                            Console.WriteLine();
                        }

                        if (Level > 12)
                        {
                            Arcadium[1] = true;

                            Console.WriteLine("Please enter your arcanum (7'th level)");

                            Console.WriteLine();

                            Arcanum[1] = "Mystic Arcanum (7'th level): ";

                            Arcanum[1] = Arcanum[1] + SpellList.Level7Spells[Warlock.Level7Spells[rng.Next(0, Warlock.Level7Spells.Length)]];

                            Console.WriteLine();
                        }

                        if (Level > 14)
                        {
                            Arcadium[2] = true;

                            Console.WriteLine("Please enter your arcanum (8'th level)");

                            Console.WriteLine();

                            Arcanum[2] = "Mystic Arcanum (8'th level): ";

                            Arcanum[2] = Arcanum[2] + SpellList.Level8Spells[Warlock.Level8Spells[rng.Next(0, Warlock.Level8Spells.Length)]];

                            Console.WriteLine();
                        }

                        if (Level > 16)
                        {
                            Arcadium[3] = true;

                            Console.WriteLine("Please enter your arcanum (9'th level)");
                            Console.WriteLine();

                            Arcanum[3] = "Mystic Arcanum (9'th level): ";

                            Arcanum[3] = Arcanum[3] + SpellList.Level9Spells[Warlock.Level9Spells[rng.Next(0, Warlock.Level9Spells.Length)]];

                            Console.WriteLine();
                        }
                    }



                }
            }
            trueSpellSlot = spellSlots;

            //Savingthrows
            deathSavingProfieciency[4] = true;
            deathSavingProfieciency[5] = true;

        }

        public static void WizardInThisClass()
        {

            deathSavingProfieciency[4] = true;
            deathSavingProfieciency[3] = true;

        }
        #endregion

        //        -->         //////REMBER YOUR RESETS\\\\\\       <---        \\      
        public static void Reset()
        {
            ///THE MOST IMPORTENT PIECE OF CODE///
            {
                counter = 0;
                counterTwoPointO = 0;
                outOfTheApp = false;
                DeadOrNot = false;
            }

            ///Game Master Stuff
            {
                GAMEMASTER = false;
                NPCUse = false;
                NPC = false;

                //Attacking
                swarmOrNot = false;
                hordeOrnot = false;

                size=0;
                multiplier=0;
                enemyDie=0;
                targetAC=0;
                EnemyToHit=0;
                howManyHit=0;
                enemtHiy=0;
                howManyDies=0;

                packTactic = false;
                bloodFrenzy = false;
            }

            ////  Plaer/NPC  /////
            {
                if (NPC == true || player == true)
                {
                    //Attacking
                    {
                        swarmOrNot = false;
                        hordeOrnot = false;

                        size = 0;
                        multiplier = 0;
                        enemyDie = 0;
                        targetAC = 0;
                        EnemyToHit = 0;
                        howManyHit = 0;
                        enemtHiy = 0;
                        howManyDies = 0;

                        packTactic = false;
                        bloodFrenzy = false;
                    }

                    //Technecal stuff
                    makeShiftString = "";
                    Console.ResetColor();

                    //Totaly useless mockery
                    {
                        idiotCounter = 0;
                    }

                    //Character
                    {
                        player = false;
                        ProficiencyBonus = 0;
                        Health = 100;
                        MaxHealth = 100;
                        YourHitDice = 0;
                        SpellcastingAbility = 0;
                        SpellSacveDC = 0;
                        spellAttackBonus = 0;

                        Level = 1;
                        numberOfSpells = 0;
                        NumberOfCantrips = 0;
                        newSpells = 0;
                        Initiative = 0;
                        spellSlots = 0;
                        trueSpellSlot = 0;
                        WalkingSpeed = 0;
                        classWalkingBonus = 0;
                        AC = 0;
                        SpellsKnown = 0;
                        SpellCounter = 0;
                        SpellUsed = 0;
                        change = 0;

                        yourClass = "";
                        yesOrNo = "";
                        name = "";
                        MagicalClass = "";
                        yourRace = "";
                    }

                    //Die and chi stuff
                    {
                        numberOfSides = 0;
                        dieResult = 0;
                        amountOfRolls = 0; ;
                        numberOfRolls = 0;
                        totalDieResult = 0;
                        median = 0;
                        max = 0;
                        min = 0;
                        carnageDice = 0;
                        advantageOrNot = false;
                        disadvantageOrNot = false;
                        advantageOrNot = false;
                    }

                    ///Uniques
                    {
                        //Barbarian
                        {
                            barbarianOrNot = false;

                            rage = false;
                            rages = 0;
                            trueRages = 0;
                            rageDamage = 0;
                            rageTimer = 0;
                            undyingRage = 0;
                            dyingRage = 10;

                            brutalCrit = 0;
                        }

                        //Bard
                        {
                            bardOrNot = false;
                            bardicInspirationLeft = 0;
                            bardicInspirationDie = "";
                        }

                        //Druid
                        {
                            druidOrNot = false;
                            wildShape = 0;
                            maxCr = "";
                            shapedOrNot = false;
                        }

                        //Fighter
                        {
                            counter = 0;
                            foreach (bool style in fightingStyles)
                            {
                                fightingStyles[counter] = false;
                                counter++;
                            }
                            counter = 0;
                            reroll = false;
                            surgeCounter = 0;
                            secondWind = false;
                            actionSurge = false;
                            extraAttack = 0;
                            indomitable = 0;
                        }

                        //Sorcerer
                        {
                            SorcererOrNot = false;
                            SorcererPoints = 0;
                        }

                        //Warlock
                        {
                            counter = 0;
                            warlockOrNot = false;

                            foreach (bool arc in Arcadium)
                            {
                                Arcanum[counter] = "";
                                Arcadium[counter] = false;
                                counter++;
                            }
                            counter = 0;
                        }
                    }

                    ///Combat
                    {
                        combat = false;
                        attackCounter = 0;
                        combatCounter = 0;
                        DamageDone = 0;
                        damageHolder = 0;
                        attackedOrNot = false;
                        spellConcentraition = false;
                        spellBreak = 0;
                        concentraitionCounter = 0;

                        DeathThreasHold = 0;
                    }

                    //Death stuff
                    {
                        deathSavingThrowEnabled = false;

                        DeathDie = 0;
                        LifeDie = 0;
                        DeathCounter = 0;
                    }


                    //Spells
                    {
                        dayToDayCaster = false;
                        counter = 0;
                        foreach (int slot in levelSpellSlots)
                        {
                            levelSpellSlots[counter] = 0;
                            trueSpellslots[counter] = 0;
                            counter++;
                        }

                        YourSpells = "";
                        levelUpSpells = false;

                        Spells.Clear();
                        counter = 0;
                    }

                    ///Weapons
                    {
                        searchTool = "";

                        //Your weapon
                        {
                            yourWeapon.Clear();
                            weaponDamageDealt = 0;
                            toHit = 0;
                            attackRoll = 0;
                            weaponCounter = 0;
                            weaponPro.Clear();
                            rangedWeapon.Clear();
                        }
                    }

                    //Classes and Races
                    {

                        SpeelsOrNot = false;
                        SpellTotal = false;

                        counter = 0;

                        foreach (int saves in SavingThrows)
                        {
                            SavingThrows[counter] = 0;
                            deathSavingProfieciency[counter] = false;
                            counter++;
                        }
                        counter = 0;
                    }

                    //Stats and Skills
                    {
                        // AllThings = { "Strength: ", "Dexterity: ", "Constitition: ", "Intelligence: ", "Wisdom: ", "Charisma: " };
                        counter = 0;
                        foreach (int stats in StatValue)
                        {
                            StatValue[counter] = 0;
                            counter++;
                        }
                        counter = 0;

                        // Str = "Athletics: ";
                        counter = 0;
                        foreach (int mods in StrMods)
                        {
                            StrMods[counter] = 0;
                            strProOrNot[counter] = false;
                            counter++;
                        }
                        counter = 0;

                        // Dex = { "Acrobatics: ", "Sleight of hand: ", "Stealth: " };
                        counter = 0;
                        foreach (int mods in DexMods)
                        {
                            DexMods[counter] = 0;
                            dexProOrNot[counter] = false;
                            counter++;
                        }
                        counter = 0;

                        // Int = { "Arcana: ", "History: ", "Investigation: ", "Nature: ", "Religion: " };
                        counter = 0;
                        foreach (int mods in IntMods)
                        {
                            IntMods[counter] = 0;
                            IntProOrNot[counter] = false;
                            counter++;
                        }
                        counter = 0;

                        // Wis = { "Animal Handling: ", "Insight: ", "Medicine: ", "Perception: ", "Survival: " };
                        counter = 0;
                        foreach (int mods in WisMods)
                        {
                            WisMods[counter] = 0;
                            wisProOrNot[counter] = false;
                            counter++;
                        }
                        counter = 0;

                        // Cha = { "Deception: ", "Intimidation: ", "Perfermance: ", "Persuasion: " };
                        counter = 0;
                        foreach (int mods in ChaMods)
                        {
                            ChaMods[counter] = 0;
                            chaProOrNot[counter] = false;
                            counter++;
                        }
                        counter = 0;
                    }

                    //Modifiers
                    {
                        counter = 0;
                        foreach (int mods in Modifier)
                        {
                            Modifier[counter] = 0;
                            counter++;
                        }
                        counter = 0;

                        atributes = 0;
                    }

                    ///Rando
                    {
                        //Stats
                        RandoName = "";
                        firstLetter = "";
                        letter = "";
                        restName = "";
                        firstName = "";
                        lastName = "";

                        nameLetters = 0;
                    }
                }
            }
        }
        //        -->         \\\\\\REMBER YOUR RESETS//////       <---        //

        public static void Welcome()
        {

            do
            {
                Console.SetWindowSize(150, Console.WindowHeight);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("  \\\\\\                            ///   ||||||||   |||                ///   |||||||||||          ///\\\\        //\\\\\\          ||||||||");
                Console.WriteLine("   \\\\\\                          ///    |||        |||             ///      |||     |||         ///  \\\\      //  \\\\\\         |||");
                Console.WriteLine("    \\\\\\                        ///     |||        |||          ///         |||     |||        ///    \\\\    //    \\\\\\        |||");
                Console.WriteLine("     \\\\\\        ///\\\\\\        ///      ||||||     |||        |||           |||     |||       ///      \\\\  //      \\\\\\       ||||||");
                Console.WriteLine("      \\\\\\      ///  \\\\\\      ///       ||||||     |||        |||           |||     |||      ///        \\\\//        \\\\\\      ||||||");
                Console.WriteLine("       \\\\\\    ///    \\\\\\    ///        |||        |||          \\\\\\         |||     |||     ///                      \\\\\\     |||");
                Console.WriteLine("        \\\\\\  ///      \\\\\\  ///         |||        |||             \\\\\\      |||     |||    ///                        \\\\\\    |||");
                Console.WriteLine("         \\\\\\///        \\\\\\///          ||||||||   ||||||||           \\\\\\   |||||||||||   ///                          \\\\\\   ||||||||");

                Console.WriteLine();
                Console.WriteLine("Are you a |Player| or |GM|");
                Console.Write("// ");
                makeShiftString = Console.ReadLine();

                if (makeShiftString == "Player" || makeShiftString == "player" || makeShiftString == "p" || makeShiftString == "P")
                {
                    player = true;
                }

                if (makeShiftString == "GM" || makeShiftString == "gm" || makeShiftString == "dm" || makeShiftString == "DM" || makeShiftString == "G" || makeShiftString == "g" || makeShiftString == "D" || makeShiftString == "d")
                {
                    GAMEMASTER = true;
                }

                if (GAMEMASTER == false && player == false)
                {
                    Console.WriteLine("Are you sure you typed correctly?");
                    Console.WriteLine("Try again :-)");
                }

            } while (GAMEMASTER == false && player == false);
            Console.Clear();
        }


        public static void Random()
        {
            //Name
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

            //Race
            yourRace = Races[rng.Next(0, Races.Length)];
            Console.WriteLine("Race: " + yourRace);

            //Class
            MagicalClass = Classess[rng.Next(0, Classess.Length)];

            Console.WriteLine("Class: " + MagicalClass);

            //Level
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
            {
                MaxHealth = (YourHitDice + Modifier[2]) + ((Modifier[2] + (((YourHitDice / 2) + 1))) * (Level - 1));

                if (MaxHealth < YourHitDice)
                {
                    MaxHealth = YourHitDice + (Level - 1);
                }
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

            //Weapon select
            yourWeapon.Add(rng.Next(0, Weapons.allWeapons.Length));

            counter = rng.Next(0, 2);
            if (counter == 0)
            {
                weaponPro.Add(true);
            }


            if (counter == 1)
            {
                weaponPro.Add(false);
            }

            counter = 0;


            //Finnese or ranged
            {
                weaponCounter = 0;
                foreach (int bowGun in Weapons.ranged)
                {
                    if (bowGun == yourWeapon[weaponCounter])
                    {
                        rangedWeapon.Add(true);
                        counter++;
                    }
                }

                if (counter > 0)
                {
                    rangedWeapon.Add(false);
                }

                counter = 0;
            }

        }

        ///Player/NPC
        #region Player / NPC
        public static void AddSpells()
        {
            Spells.Clear();
            //If you can't shift your spells daily
            if (dayToDayCaster == false)
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
                    {
                        Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                        Spells.Add(allSpellLevels[counter]);
                        Console.WriteLine();
                        for (int i = 1; i <= levelSpellSlots[counter]; i++)
                        {
                            YourSpells = Console.ReadLine();
                            if (YourSpells != "skip" && YourSpells != "Skip")
                            {
                                Spells.Add(YourSpells);
                            }

                            if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                            {
                                i = 20000;
                            }
                        }
                        Spells.Add("");
                        Console.WriteLine();
                        counter++;
                    }

                    //spell slots for level 2
                    if (Level > 2)
                    {
                        Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                        Spells.Add(allSpellLevels[counter]);
                        Console.WriteLine();
                        for (int i = 1; i <= levelSpellSlots[counter]; i++)
                        {
                            YourSpells = Console.ReadLine();
                            if (YourSpells != "skip" && YourSpells != "Skip")
                            {
                                Spells.Add(YourSpells);
                            }

                            if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                            {
                                i = 20000;
                            }
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
                            if (YourSpells != "skip" && YourSpells != "Skip")
                            {
                                Spells.Add(YourSpells);
                            }

                            if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                            {
                                i = 20000;
                            }
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
                            if (YourSpells != "skip" && YourSpells != "Skip")
                            {
                                Spells.Add(YourSpells);
                            }

                            if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                            {
                                i = 20000;
                            }
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
                            if (YourSpells != "skip" && YourSpells != "Skip")
                            {
                                Spells.Add(YourSpells);
                            }

                            if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                            {
                                i = 20000;
                            }
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
                            if (YourSpells != "skip" && YourSpells != "Skip")
                            {
                                Spells.Add(YourSpells);
                            }

                            if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                            {
                                i = 20000;
                            }
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
                            if (YourSpells != "skip" && YourSpells != "Skip")
                            {
                                Spells.Add(YourSpells);
                            }

                            if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                            {
                                i = 20000;
                            }
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
                            if (YourSpells != "skip" && YourSpells != "Skip")
                            {
                                Spells.Add(YourSpells);
                            }

                            if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                            {
                                i = 20000;
                            }
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
                            if (YourSpells != "skip" && YourSpells != "Skip")
                            {
                                Spells.Add(YourSpells);
                            }

                            if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                            {
                                i = 20000;
                            }
                        }
                        Spells.Add("");
                        Console.WriteLine();
                        counter++;
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
            }

            //If you can shift your spells daily
            {
                if (dayToDayCaster == true)
                {
                    //number of spells you can choose per day
                    numberOfSpells = SpellcastingAbility + Level;
                    if (1 > numberOfSpells)
                    {
                        numberOfSpells = 1;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Choose " + numberOfSpells + " spells:");
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
                    Console.WriteLine("Write |Skip| to move on without adding to your spell list");
                    Console.WriteLine();
                    counter = 0;

                    //Spell slots.add
                    {
                        //spell slots for level 1
                        {
                            Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                            Spells.Add(allSpellLevels[counter]);
                            Console.WriteLine();
                            for (int i = 1; i <= levelSpellSlots[counter]; i++)
                            {
                                YourSpells = Console.ReadLine();
                                if (YourSpells != "skip" && YourSpells != "Skip")
                                {
                                    Spells.Add(YourSpells);
                                }

                                if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                                {
                                    i = 20000;
                                }
                            }
                            Spells.Add("");
                            Console.WriteLine();
                            counter++;
                        }

                        //spell slots for level 2
                        if (Level > 2)
                        {
                            Console.WriteLine("Please enter all of your " + allSpellLevels[counter] + "(" + levelSpellSlots[counter] + ")");
                            Spells.Add(allSpellLevels[counter]);
                            Console.WriteLine();
                            for (int i = 1; i <= levelSpellSlots[counter]; i++)
                            {
                                YourSpells = Console.ReadLine();
                                if (YourSpells != "skip" && YourSpells != "Skip")
                                {
                                    Spells.Add(YourSpells);
                                }

                                if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                                {
                                    i = 20000;
                                }
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
                                if (YourSpells != "skip" && YourSpells != "Skip")
                                {
                                    Spells.Add(YourSpells);
                                }

                                if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                                {
                                    i = 20000;
                                }
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
                                if (YourSpells != "skip" && YourSpells != "Skip")
                                {
                                    Spells.Add(YourSpells);
                                }

                                if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                                {
                                    i = 20000;
                                }
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
                                if (YourSpells != "skip" && YourSpells != "Skip")
                                {
                                    Spells.Add(YourSpells);
                                }

                                if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                                {
                                    i = 20000;
                                }
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
                                if (YourSpells != "skip" && YourSpells != "Skip")
                                {
                                    Spells.Add(YourSpells);
                                }

                                if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                                {
                                    i = 20000;
                                }
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
                                if (YourSpells != "skip" && YourSpells != "Skip")
                                {
                                    Spells.Add(YourSpells);
                                }

                                if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                                {
                                    i = 20000;
                                }
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
                                if (YourSpells != "skip" && YourSpells != "Skip")
                                {
                                    Spells.Add(YourSpells);
                                }

                                if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                                {
                                    i = 20000;
                                }
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
                                if (YourSpells != "skip" && YourSpells != "Skip")
                                {
                                    Spells.Add(YourSpells);
                                }

                                if (YourSpells == "skip" || YourSpells == "Skip" || YourSpells == "")
                                {
                                    i = 20000;
                                }
                            }
                            Spells.Add("");
                            Console.WriteLine();
                            counter++;
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
                }
            }
        }

        public static void Essentials()
        {
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

                //Amor class
                AC = 10 + Modifier[2];

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

                AC = 10 + Modifier[1];
                Initiative = Modifier[1];
                WalkingSpeed = 30;

                counter = 0;
                //Classes here!
                {
                    //Barbarian
                    if (yourClass == Classess[0])
                    {
                        BarbarianInThisClass();
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


                if (player == true)
                {
                    deathSavingThrowEnabled = true;
                }

                if (GAMEMASTER == true)
                {
                    yesOrNo = Console.ReadLine();

                    if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                    {
                        deathSavingThrowEnabled = true;
                    }

                    if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                    {
                        deathSavingThrowEnabled = false;
                    }
                }
            }

            counter = 0;
            foreach (string things in AllThings)
            {
                if (deathSavingProfieciency[counter] == false)
                {
                    SavingThrows[counter] = Modifier[counter];
                }

                if (deathSavingProfieciency[counter] == true)
                {
                    SavingThrows[counter] = (Modifier[counter] + ProficiencyBonus);

                }
                counter++;
            }
            counter = 0;

            //Modifiers
            {
                counter = 0;
                if (change > 0)
                {
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

                        Modifier[counter] = (Modifier[counter] + atributes);
                        counter++;

                    }
                    counter = 0;
                }
            }

            if (name == RandoName)
            {
                name = RandoName;
            }

            if (barbarianOrNot == true)
            {
                AC = 10 + Convert.ToInt32(Modifier[1] + Modifier[2]);
            }

        }

        public static void PlayerPrint()
        {
            //Color
            {
                if (rage == true)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                if (shapedOrNot == true)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                if (combat == false)
                {
                    combatCounter = 0;
                    Initiative = 0;
                    concentraitionCounter = 0;
                }
            }

            DamageDone = 0;

            ////////////////
            Console.Clear();
            ////////////////


            /// Character Print

            ///Name, Class, Health and Level
            {
                if (name != "Rando")
                {
                    Console.WriteLine(name + " The " + yourRace + "-" + MagicalClass + " " + "Level: " + Level + "         Health: " + Health + "/" + MaxHealth);
                    Console.WriteLine();
                    Console.Write("Amor class: " + AC + "      Initiative: " + Initiative);

                    if (barbarianOrNot == false || Level < 5)
                    {
                        Console.Write("      Speed: " + WalkingSpeed);
                    }

                    if (barbarianOrNot == true && Level > 4)
                    {
                        Console.Write("      Speed: " + WalkingSpeed+"("+(WalkingSpeed +classWalkingBonus)+")");
                    }
                }

                //Rando
                if (name == "Rando")
                {
                    Console.WriteLine(RandoName + " The " + yourRace + "-" + MagicalClass + " " + "Level: " + Level + "         Health: " + Health + "/" + MaxHealth);
                    Console.WriteLine();
                    Console.WriteLine("Amor class: " + AC + "      Initiative: " + Initiative + "      Speed: " + WalkingSpeed);
                }
            }

            Console.WriteLine();

            //Sorcerer points and spell table
            {
                if (SorcererOrNot == true)
                {
                    if (SorcererPoints > 1)
                    {
                        Console.WriteLine("You have " + SorcererPoints + " sorcerepoints ready for use");
                    }

                    if (SorcererPoints == 1)
                    {
                        Console.WriteLine("You have " + SorcererPoints + " sorcerepoint ready for use");
                    }
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

            //Modifiers  //Shine up
            {
                counterTwoPointO = 0;
                counter = 0;
                foreach (string thing in AllThings)
                {
                    Console.Write(thing + StatValue[counter] + " " + "(" + Modifier[counter] + ")");
                    if (counter == 0 || counter == 2 || counter == 4)
                    {
                        for (int i = Console.CursorTop; i > counterTwoPointO; counterTwoPointO++) { }

                        Console.SetCursorPosition(20, counterTwoPointO);
                        Console.Write("  ||  ");
                    }

                    if (counter == 1 || counter == 3 || counter == 5)
                    {
                        Console.WriteLine();
                    }

                    counter++;
                }
                counter = 0;
                counterTwoPointO = 0;

                //Stats with mods
                {
                    Console.WriteLine();
                    Console.Write("Proficiency Bonus: " + ProficiencyBonus);

                    Console.WriteLine();
                    counter = 0;

                    //Saving Throws
                    Console.WriteLine();
                    Console.WriteLine("Saving Throws:");

                    counter = 0;

                    foreach (string thing in AllThings)
                    {
                        Console.WriteLine(thing + SavingThrows[counter]);
                        counter++;
                    }
                }
            }

            //Passive Perception
            Console.WriteLine();
            Console.WriteLine("Passive Wisdom (Perception): " + (WisMods[3] + 10));
            Console.WriteLine();



            ///Skills print
            {
                Console.WriteLine("Skills in:");
                Console.WriteLine();
                Console.WriteLine(AllThings[0]);

                //Str skills
                counterTwoPointO = 0;
                Console.WriteLine(Str + StrMods[0]);

                //Dex skills
                {
                    Console.WriteLine();
                    for (int i = Console.CursorTop; i > counterTwoPointO; counterTwoPointO++) { }

                    Console.SetCursorPosition(20, counterTwoPointO - 3);

                    Console.Write("  ||  ");
                    Console.WriteLine(AllThings[1]);
                    counterTwoPointO++;
                    counter = 0;

                    foreach (string skill in Dex)
                    {
                        for (int i = Console.CursorTop; i > counterTwoPointO; counterTwoPointO++) { }

                        Console.SetCursorPosition(20, counterTwoPointO - 3);
                        Console.Write("  ||  ");
                        Console.Write(skill + DexMods[counter]);
                        counter++;
                        counterTwoPointO++;
                    }

                    counter = 0;
                }

                //Int mods
                {
                    Console.WriteLine();

                    Console.SetCursorPosition(0, counterTwoPointO);
                    Console.WriteLine(AllThings[3]);
                    foreach (string skill in Int)
                    {
                        Console.SetCursorPosition(0, counterTwoPointO);
                        Console.WriteLine(skill + IntMods[counter]);
                        counter++;
                        counterTwoPointO++;
                    }

                    counter = 0;
                }

                //Wis skills
                {
                    Console.WriteLine();
                    for (int i = Console.CursorTop; i > counterTwoPointO; counterTwoPointO++) { }

                    Console.SetCursorPosition(20, counterTwoPointO);

                    Console.Write("  ||  ");
                    Console.WriteLine(AllThings[4]);
                    foreach (string skill in Wis)
                    {
                        for (int i = Console.CursorTop; i > counterTwoPointO; counterTwoPointO++) { }

                        Console.SetCursorPosition(20, counterTwoPointO);
                        Console.Write("  ||  ");
                        Console.Write(skill + WisMods[counter]);
                        counter++;
                        counterTwoPointO++;
                    }

                    counter = 0;
                }

                //Cha skills
                {
                    Console.WriteLine();

                    Console.WriteLine(AllThings[5]);
                    foreach (string skill in Cha)
                    {
                        Console.WriteLine(skill + ChaMods[counter]);
                        counter++;
                    }
                }
            }

            counter = 0;

            ///Spells
            {
                //Spells Known
                if (SpellTotal == true)
                {
                    if (warlockOrNot == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine(SpellsKnown);
                    }
                    if (warlockOrNot == true)
                    {
                        Console.WriteLine("You have " + spellSlots + " spellslots left");
                    }
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

                    if (warlockOrNot == false)
                    {
                        foreach (int slot in levelSpellSlots)
                        {
                            Console.Write(slot + ", ");///
                            Console.WriteLine();
                        }
                    }
                }

                if (warlockOrNot == true)
                {
                    counter = 0;
                    foreach (bool spell in Arcadium)
                    {
                        if (spell == true)
                        {
                            Console.WriteLine(Arcanum[counter]);
                            Console.WriteLine();
                        }
                        counter++;
                    }
                }

            }

            counter = 0;

            if (weaponCounter > 0)
            {
                YourWeaponStats();
            }

            PlayerCommands();

            if (combat == true)
            {
                Combat();
            }

            //Relentless rage (Don't wanna die?)
            if (barbarianOrNot == true)
            {
                if (Level > 10)
                {
                    if (Health <= 0)
                    {
                        undyingRage = rng.Next(0, 21);
                        Console.WriteLine("Relentless rage    " + undyingRage + " + " + Modifier[2] + " = " + (undyingRage + Modifier[2]));
                        undyingRage = undyingRage + Convert.ToInt32(Modifier[2]);

                        if (undyingRage >= dyingRage)
                        {
                            Health = 1;
                            dyingRage = dyingRage + 5;
                        }
                    }
                }
            }

            //Death
            if (player == true )
            {
                deathSavingThrowEnabled = true;
            }

            if (deathSavingThrowEnabled == true)
            {
                ///Death
                {
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
            }

            if (deathSavingThrowEnabled == false)
            {
                if (Health <= 0)
                {
                    DeathScreen();
                }
            }


            change = 0;
        }

        public static void SpellUse()
        {
            if (combat == true)
            {
                spellConcentraition = true;

                if (warlockOrNot == false)
                {
                    Console.WriteLine("What spellslot do you want to use? (Type the number that you want to use, for cantrips type |0|) ");
                    Console.Write("// ");
                    SpellUsed = Convert.ToInt32(Console.ReadLine());

                    if (SpellUsed == -1)
                    {
                        Console.WriteLine("You did it, you casted a cantrip");
                    }

                    else if (levelSpellSlots[SpellUsed] <= 0 && SpellUsed != -1)
                    {
                        Console.WriteLine("The spell failed");
                    }

                    else if (levelSpellSlots[SpellUsed] > 0 && SpellUsed != -1)
                    {
                        levelSpellSlots[SpellUsed] = levelSpellSlots[SpellUsed] - 1;
                    }

                    Console.WriteLine("Is this a concentraition spell, |Yes| or |No|");
                    Console.Write("// ");
                    yesOrNo = Console.ReadLine();
                    Console.WriteLine();
                    if (yesOrNo == "Yes" || yesOrNo == "yes" || yesOrNo == "YES" || yesOrNo == "y" || yesOrNo == "Y")
                    {
                        if (concentraitionCounter > 0)
                        {
                            Console.WriteLine("You ended your other concentraition spell");
                        }

                        Console.Write("How many minutes: ");
                        concentraitionCounter = Convert.ToInt32(Console.ReadLine());
                        concentraitionCounter = concentraitionCounter * 10;
                    }

                    SpellUsed--;

                }

                if (warlockOrNot == true)
                {
                    //Arcadiums
                    {
                        counter = 0;
                        if (Arcadium[0] == true || Arcadium[1] == true || Arcadium[2] == true || Arcadium[3] == true)
                        {
                            Console.WriteLine("Do you want to cast an acanum, |Yes| or |No|:");
                            Console.Write("// ");
                            yesOrNo = Console.ReadLine();
                            if (yesOrNo == "Yes" || yesOrNo == "yes" || yesOrNo == "YES" || yesOrNo == "y" || yesOrNo == "Y")
                            {
                                Console.WriteLine("What acanum do you want to use, press the number you want: ");
                                Console.Write("// ");
                                makeShiftString = Console.ReadLine();

                                if (makeShiftString == "1" || makeShiftString == "6")
                                {
                                    Arcadium[0] = false;

                                    spellSlots++;
                                }

                                if (makeShiftString == "2" || makeShiftString == "7")
                                {
                                    Arcadium[1] = false;

                                    spellSlots++;
                                }

                                if (makeShiftString == "3" || makeShiftString == "8")
                                {
                                    Arcadium[2] = false;

                                    spellSlots++;
                                }

                                if (makeShiftString == "4" || makeShiftString == "9")
                                {
                                    Arcadium[3] = false;

                                    spellSlots++;
                                }
                            }
                            counter++;
                        }

                        counter = 0;
                    }

                    // /|\
                    // \|/
                    {

                        //                                           |
                        //                                          /|\
                        //                                         //|\\
                        //                                        ///|\\\
                        //                                       ////|\\\\
                        //                                      /////|\\\\\
                        //                                     //////|\\\\\\
                        //                                    ///////|\\\\\\\
                        //                                   ////////|\\\\\\\\
                        //                                  /////////|\\\\\\\\\
                        //                                 //////////|\\\\\\\\\\
                        //                                ///////////|\\\\\\\\\\\
                        //                               ////////////|\\\\\\\\\\\\
                        //                              /////////////|\\\\\\\\\\\\\
                        //                             //////////////|\\\\\\\\\\\\\\
                        //                            ///////////////|\\\\\\\\\\\\\\\
                        //                           ////////////////|\\\\\\\\\\\\\\\\
                        //                          /////////////////|\\\\\\\\\\\\\\\\\
                        //                         //////////////////|\\\\\\\\\\\\\\\\\\
                        //                        ///////////////////|\\\\\\\\\\\\\\\\\\\
                        //                       ////////////////////|\\\\\\\\\\\\\\\\\\\\
                        //                      /////////////////////|\\\\\\\\\\\\\\\\\\\\\
                        //                     //////////////////////|\\\\\\\\\\\\\\\\\\\\\\
                        //                    ///////////////////////|\\\\\\\\\\\\\\\\\\\\\\\ 
                        //                   ////////////////////////|\\\\\\\\\\\\\\\\\\\\\\\\ 
                        //                  /////////////////////////|\\\\\\\\\\\\\\\\\\\\\\\\\ 
                        //                 //////////////////////////|\\\\\\\\\\\\\\\\\\\\\\\\\\                    
                        //                ////////////////////////// | \\\\\\\\\\\\\\\\\\\\\\\\\\               
                        //               //////////////////////////  |  \\\\\\\\\\\\\\\\\\\\\\\\\\                   
                        //              //////////////////////////   |   \\\\\\\\\\\\\\\\\\\\\\\\\\                  
                        //             //////////////////////////    |    \\\\\\\\\\\\\\\\\\\\\\\\\\                 
                        //            //////////////////////////     |     \\\\\\\\\\\\\\\\\\\\\\\\\\
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            ||||||||||||||||||||||||||     |     ||||||||||||||||||||||||||
                        //            \\\\\\\\\\\\\\\\\\\\\\\\\\     |     //////////////////////////
                        //             \\\\\\\\\\\\\\\\\\\\\\\\\\    |    //////////////////////////
                        //              \\\\\\\\\\\\\\\\\\\\\\\\\\   |   //////////////////////////
                        //               \\\\\\\\\\\\\\\\\\\\\\\\\\  |  //////////////////////////
                        //                \\\\\\\\\\\\\\\\\\\\\\\\\\ | //////////////////////////
                        //                 \\\\\\\\\\\\\\\\\\\\\\\\\\|//////////////////////////
                        //                  \\\\\\\\\\\\\\\\\\\\\\\\\|/////////////////////////
                        //                   \\\\\\\\\\\\\\\\\\\\\\\\|////////////////////////
                        //                    \\\\\\\\\\\\\\\\\\\\\\\|///////////////////////
                        //                     \\\\\\\\\\\\\\\\\\\\\\|//////////////////////
                        //                      \\\\\\\\\\\\\\\\\\\\\|/////////////////////
                        //                       \\\\\\\\\\\\\\\\\\\\|////////////////////
                        //                        \\\\\\\\\\\\\\\\\\\|///////////////////
                        //                         \\\\\\\\\\\\\\\\\\|//////////////////
                        //                          \\\\\\\\\\\\\\\\\|/////////////////
                        //                           \\\\\\\\\\\\\\\\|////////////////
                        //                            \\\\\\\\\\\\\\\|///////////////
                        //                             \\\\\\\\\\\\\\|//////////////
                        //                              \\\\\\\\\\\\\|/////////////
                        //                               \\\\\\\\\\\\|////////////
                        //                                \\\\\\\\\\\|///////////
                        //                                 \\\\\\\\\\|//////////
                        //                                  \\\\\\\\\|/////////
                        //                                   \\\\\\\\|//////// 
                        //                                    \\\\\\\|/////// 
                        //                                     \\\\\\|////// 
                        //                                      \\\\\|/////
                        //                                       \\\\|//// 
                        //                                        \\\|///
                        //                                         \\|//
                        //                                          \|/
                        //                                           |
                    }

                    //Concentraition
                    if (spellSlots > 0)
                    {
                        Console.WriteLine("Is this a concentraition spell, |Yes| or |No|");
                        Console.Write("// ");
                        yesOrNo = Console.ReadLine();
                        Console.WriteLine();
                        if (yesOrNo == "Yes" || yesOrNo == "yes" || yesOrNo == "YES" || yesOrNo == "y" || yesOrNo == "Y")
                        {
                            if (concentraitionCounter > 0)
                            {
                                Console.WriteLine("You ended your other concentraition spell");
                            }

                            Console.Write("How many minutes: ");
                            concentraitionCounter = Convert.ToInt32(Console.ReadLine());
                            concentraitionCounter = concentraitionCounter * 10;
                        }

                        if (spellSlots == 0)
                        {
                            Console.WriteLine("You are out of spell slots");
                        }
                    }
                    spellSlots--;
                }
            }

            if (combat == false)
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
                    //Arcadiums
                    {
                        counter = 0;
                        if (Arcadium[0] == true || Arcadium[1] == true || Arcadium[2] == true || Arcadium[3] == true)
                        {
                            Console.WriteLine("Do you want to cast an acanum, |Yes| or |No|:");
                            Console.Write("// ");
                            yesOrNo = Console.ReadLine();
                            if (yesOrNo == "Yes" || yesOrNo == "yes" || yesOrNo == "YES" || yesOrNo == "y" || yesOrNo == "Y")
                            {
                                Console.WriteLine("What acanum do you want to use, press the number you want: ");
                                Console.Write("// ");
                                makeShiftString = Console.ReadLine();

                                if (makeShiftString == "1" || makeShiftString == "6")
                                {
                                    Arcadium[0] = false;

                                    spellSlots++;
                                }

                                if (makeShiftString == "2" || makeShiftString == "7")
                                {
                                    Arcadium[1] = false;

                                    spellSlots++;
                                }

                                if (makeShiftString == "3" || makeShiftString == "8")
                                {
                                    Arcadium[2] = false;

                                    spellSlots++;
                                }

                                if (makeShiftString == "4" || makeShiftString == "9")
                                {
                                    Arcadium[3] = false;

                                    spellSlots++;
                                }
                            }
                        }

                    }


                    if (spellSlots > 0)
                    {
                        spellSlots = spellSlots - 1;
                    }

                    if (spellSlots == 0)
                    {
                        Console.WriteLine("You are out of spell slots");
                    }
                }
            }
        }

        public static void LevelUp()
        {
            counter = 0;

            //Proficiency update Check
            int newProficiencyBonus = ProficiencyBonus;

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
                counter = 0;
            }

            //Classes here!
            {
                //Barbarian
                if (yourClass == Classess[0])
                {
                    BarbarianInThisClass();
                    if (classWalkingBonus > 0)
                    {
                        classWalkingBonus = classWalkingBonus - 10;
                    }
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
            {
                foreach (string things in AllThings)
                {
                    if (ProficiencyBonus != newProficiencyBonus)
                    {
                        SavingThrows[counter] = (SavingThrows[counter] + (ProficiencyBonus - newProficiencyBonus));
                        counter++;
                    }
                }
            }

            if (barbarianOrNot == true)
            {
                if (Level == 20)
                {
                    StatValue[0] = StatValue[0] + 4;
                    StatValue[2] = StatValue[2] + 4;
                }
            }

            counter = 0;
            Health = MaxHealth;
        }

        public static void AttackIdiocy()
        {
            if (idiotCounter == 6)
            {
                idiotCounter++;
                DamageDone = 0;

                for (int i = 0; i < 100; i++)
                {
                    DamageDone = DamageDone + rng.Next(1, 100);
                }

                Console.WriteLine("Oh, so you think your tough, huh, well then, you take 100D100 damage");
                Console.WriteLine("that is " + DamageDone + " good luck");

                ConsoleDamage();

            }

            if (idiotCounter == 5)
            {
                idiotCounter++;
                DamageDone = 0;

                for (int i = 0; i < 10; i++)
                {
                    DamageDone = DamageDone + rng.Next(1, 10);
                }

                Console.WriteLine("OKAY, YOU KNOW WHAT, SCREW YOU, YOU TAKE 10D10 DAMAGE");

                ConsoleDamage();
            }

            if (idiotCounter == 4)
            {
                Console.WriteLine("Okay you know what, you want to make an attack, fine you deal 1 damage to yourself");
                DamageDone = 1;
                ConsoleDamage();
                idiotCounter++;
            }

            if (idiotCounter == 3)
            {
                idiotCounter++;
                Console.WriteLine("OKAY, YOU STILL DON'T HAVE A WEAPON, WHAT DO YOU WANT FROM ME");
            }

            if (idiotCounter == 2)
            {
                idiotCounter++;
                Console.WriteLine("OK, in order to get a weapon you need to hit |W|, then you need write in the weapon you want, you can even serch for specific weapons");
            }

            if (idiotCounter == 1)
            {
                idiotCounter++;
                Console.WriteLine("YOU STILL DON'T HAVE A WEAPON");
            }

            if (idiotCounter == 0)
            {
                idiotCounter++;
                Console.WriteLine("You don't have a weapon");
            }
        }

        public static void ConsoleDamage()
        {
            Console.WriteLine();
            Health = Health - DamageDone;
        }

        //Rest
        #region Rest
        public static void ShortRest()
        {
            //Warlock
            if (warlockOrNot == true)
            {
                spellSlots = trueSpellSlot;
            }

            //Fighter
            {
                if (fighterOrNot == true)
                {
                    secondWind = true;

                    //Action surrge
                    {
                        if (Level > 1)
                        {
                            actionSurge = true;
                            surgeCounter = 1;
                        }

                        if (Level > 16)
                        {
                            surgeCounter = 2;
                        }
                    }
                }
            }

            //Druid
            {
                if (druidOrNot == true)
                {
                    //Wild shape
                    {
                        if (Level > 2)
                        {
                            wildShape = 2;
                            maxCr = "Max CR 1/4, No flying or swimming speed";
                        }

                        if (Level > 3)
                        {
                            maxCr = "Max CR 1/2, No flying speed";
                        }

                        if (Level > 7)
                        {
                            maxCr = "Max CR 1";
                        }
                    }
                }
            }

            //Barbarian
            if (barbarianOrNot == true)
            {
                dyingRage = 10;
            }
        }

        public static void LongRest()
        {
            //Spell reset
            if (warlockOrNot == false)
            {
                counter = 0;
                foreach (int spellslot in trueSpellslots)
                {
                    levelSpellSlots[counter] = spellslot;
                    counter++;
                }
            }

            //Fighter
            {
                if (fighterOrNot == true)
                {
                    secondWind = true;

                    //Action surrge
                    {
                        if (Level > 1)
                        {
                            actionSurge = true;
                            surgeCounter = 1;
                        }

                        if (Level > 16)
                        {
                            surgeCounter = 2;
                        }
                    }

                    //Indomitable
                    {
                        if (Level > 8)
                        {
                            indomitable = 1;
                        }

                        if (Level > 12)
                        {
                            indomitable = 2;
                        }

                        if (Level > 16)
                        {
                            indomitable = 3;
                        }
                    }
                }
            }

            //Druid
            {
                if (druidOrNot == true)
                {
                    //Wild shape
                    {
                        if (Level > 2)
                        {
                            wildShape = 2;
                            maxCr = "Max CR 1/4, No flying or swimming speed";
                        }

                        if (Level > 3)
                        {
                            maxCr = "Max CR 1/2, No flying speed";
                        }

                        if (Level > 7)
                        {
                            maxCr = "Max CR 1";
                        }
                    }
                }
            }

            //Warlock
            {
                if (warlockOrNot == true)
                {
                    spellSlots = trueSpellSlot;
                }

                counter = 0;
                foreach (bool spell in Arcadium)
                {
                    if (Arcanum[counter] != "")
                    {
                        Arcadium[counter] = true;
                    }
                    counter++;
                }

                counter = 0;
            }

            //Bard
            {
                if (bardOrNot == true)
                {
                    bardicInspirationLeft = Modifier[5];
                }
            }

            //Barbarian
            if (barbarianOrNot == true)
            {
                dyingRage = 10;
                rages = trueRages;
            }
        }
        #endregion

        //Death
        #region Death
        public static void Death()
        {
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
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
                Console.ForegroundColor = ConsoleColor.White;
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

            //You died
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
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
            }

            DeadOrNot = true;

            Console.WriteLine("Press |C| for a complete reset, Press |R| for a normal reset:");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            ///Charakter Reset
            {
                // Restart with another Character (C)
                if (Exit.Key == ConsoleKey.C)
                {
                    Console.Clear();
                    Reset();
                    Essentials();
                    PlayerPrint();
                }

                // Reset your Character (R)
                if (Exit.Key == ConsoleKey.R)
                {
                    DeadOrNot = false;
                    Health = MaxHealth;
                }
            }

        }
        #endregion

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
            //Player Roll
            {
                if (player == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("1d4");
                    Console.WriteLine("1d6");
                    Console.WriteLine("1d8");
                    Console.WriteLine("1d10");
                    Console.WriteLine("1d12");
                    Console.WriteLine("1d20");
                    Console.WriteLine("1d100");
                    Console.WriteLine(); Console.Write("How many dice // ");
                    numberOfRolls = Convert.ToInt32(Console.ReadLine());

                    counter = 0;
                    for (int i = Console.CursorTop; i > counter; counter++) { }

                    if (numberOfRolls > 9)
                    {
                        for (int i = numberOfRolls; i > counterTwoPointO; counterTwoPointO++)
                        {
                            i = i / 10;
                        }
                    }

                    Console.SetCursorPosition(18 + counterTwoPointO, counter - 1);

                    Console.Write("d");
                    numberOfSides = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(); Console.Write("How many times// ");
                    amountOfRolls = Convert.ToInt32(Console.ReadLine());

                    if (numberOfSides > 9)
                    {
                        for (int i = numberOfSides; i > counter; counter++)
                        {
                            i = i / 10;
                        }
                    }
                    counter = 0;
                    counterTwoPointO = 0;

                    numberOfSides++;
                    min = 1000000000;
                    max = 0;
                    median = 0;

                    for (int i = 0; i < amountOfRolls; i++)
                    {
                        for (int p = 0; p < numberOfRolls; p++)
                        {
                            dieResult = rng.Next(1, numberOfSides);
                            totalDieResult = totalDieResult + dieResult;
                            Console.WriteLine(dieResult);


                        }
                        Console.WriteLine("------------");
                        Console.WriteLine("Total: " + totalDieResult);
                        carnageDice = carnageDice + totalDieResult;

                        //Max
                        if (totalDieResult > max)
                        {
                            max = totalDieResult;
                        }

                        //Max
                        if (totalDieResult < min && 0 < totalDieResult)
                        {
                            min = totalDieResult;
                        }

                        totalDieResult = 0;
                        dieRolledOrNot = true;
                        Console.WriteLine();
                    }

                    //Min, Max, Mid
                    if (amountOfRolls > 1)
                    {
                        median = carnageDice / amountOfRolls;
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Max {" + max + "}");
                        Console.WriteLine("Min {" + min + "}");
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Median {" + median + "}");
                        Console.WriteLine("All: " + carnageDice);

                    }
                    carnageDice = 0;
                }
            }

            //Game masters playtime
            {
                if (GAMEMASTER == true)
                {
                    //Swarm
                    if (swarmOrNot == false)
                    {
                        Console.Clear();
                        Console.Write("How many in the swarm: ");
                        size = Convert.ToInt32(Console.ReadLine());

                        Console.Write("What is the to hit bonus: ");
                        EnemyToHit = Convert.ToInt32(Console.ReadLine());

                        Console.Write("How big is the damage die (start with the number of dice): ");
                        howManyDies = Convert.ToInt32(Console.ReadLine());

                        counter = 0;

                        if (howManyDies > 9)
                        {
                            for (int i = howManyDies; i > counter; counter++)
                            {
                                i = i / 10;
                            }
                        }

                        Console.SetCursorPosition(60 + counter, 2);

                        Console.Write("d");
                        enemyDie = Convert.ToInt32(Console.ReadLine());

                        if (enemyDie > 9)
                        {
                            for (int i = enemyDie; i > counter; counter++)
                            {
                                i = i / 10;
                            }
                        }

                        Console.SetCursorPosition(63 + counter, 2);
                        Console.Write("+ ");
                        multiplier = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Target AC: ");
                        targetAC = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("------------");

                        //Swarm attack
                        for (int i = 0; i < size; i++)
                        {
                            //Disadvantage
                            if (disadvantageOrNot == true)
                            {
                                enemtHiy = rng.Next(1, 21);
                                makeShiftString = Convert.ToString(enemtHiy);

                                enemtHiy = rng.Next(1, 21);
                                if (Convert.ToInt32(makeShiftString) < enemtHiy)
                                {
                                    enemtHiy = Convert.ToInt32(makeShiftString);
                                }
                            }

                            //No Buff
                            if ((advantageOrNot == false && disadvantageOrNot == false) || (advantageOrNot == true && disadvantageOrNot == true))
                            {
                                enemtHiy = rng.Next(1, 21);
                            }

                            //Advantage
                            if (advantageOrNot == true)
                            {
                                enemtHiy = rng.Next(1, 21);
                                makeShiftString = Convert.ToString(enemtHiy);

                                enemtHiy = rng.Next(1, 21);
                                if (Convert.ToInt32(makeShiftString) > enemtHiy)
                                {
                                    enemtHiy = Convert.ToInt32(makeShiftString);
                                }
                            }

                            //Swarm not crit
                            if (enemtHiy + EnemyToHit >= targetAC && enemtHiy != 20)
                            {
                                dieResult = (rng.Next(1, enemyDie) * howManyDies) + multiplier;
                                totalDieResult = totalDieResult + dieResult;
                                Console.WriteLine(dieResult);

                                Console.WriteLine("------------");

                                howManyHit++;
                            }

                            //One in swarm crit
                            if (enemtHiy == 20)
                            {
                                dieResult = (2 * (rng.Next(1, enemyDie) * howManyDies)) + +multiplier;
                                totalDieResult = totalDieResult + dieResult;
                                Console.WriteLine(dieResult + " CRIT!!");

                                Console.WriteLine("------------");

                                howManyHit++;
                            }
                        }

                        Console.WriteLine("------------");
                        Console.WriteLine(howManyHit + " Hit");
                        Console.WriteLine("------------");
                        Console.WriteLine("Total: " + totalDieResult + " damage");
                        carnageDice = carnageDice + totalDieResult;
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        totalDieResult = 0;
                        carnageDice = 0;
                        howManyDies = 0;
                        howManyHit = 0;
                        dieResult = 0;
                        targetAC = 0;
                        enemtHiy = 0;
                        enemyDie = 0;
                    }

                    //Horde
                    if (hordeOrnot == true)
                    {
                        Console.Clear();
                        Console.Write("How many in the horde: ");
                        size = Convert.ToInt32(Console.ReadLine());

                        Console.Write("What is the to hit bonus: ");
                        EnemyToHit = Convert.ToInt32(Console.ReadLine());

                        Console.Write("How big is the damage die: d");
                        enemyDie = Convert.ToInt32(Console.ReadLine());

                        Console.Write("How many dice: ");
                        howManyDies = Convert.ToInt32(Console.ReadLine());

                        Console.Write("What is the attack modifiers: ");
                        multiplier = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("------------");

                        //Horde attack
                        for (int i = 0; i < size; i++)
                        {
                            //Disadvantage
                            if (disadvantageOrNot == true)
                            {
                                enemtHiy = rng.Next(1, 21);
                                makeShiftString = Convert.ToString(enemtHiy);

                                enemtHiy = rng.Next(1, 21);
                                if (Convert.ToInt32(makeShiftString) < enemtHiy)
                                {
                                    enemtHiy = Convert.ToInt32(makeShiftString);
                                }
                            }

                            //Vantage
                            if ((advantageOrNot == false && disadvantageOrNot == false) || (advantageOrNot == true && disadvantageOrNot == true))
                            {
                                enemtHiy = rng.Next(1, 21);
                            }

                            //Advantage
                            if (advantageOrNot == true)
                            {
                                enemtHiy = rng.Next(1, 21);
                                makeShiftString = Convert.ToString(enemtHiy);

                                enemtHiy = rng.Next(1, 21);
                                if (Convert.ToInt32(makeShiftString) > enemtHiy)
                                {
                                    enemtHiy = Convert.ToInt32(makeShiftString);
                                }
                            }

                            //Swarm not crit
                            if (enemtHiy != 20)
                            {
                                enemtHiy = enemtHiy + EnemyToHit;
                                dieResult = (rng.Next(1, enemyDie) * howManyDies) + multiplier;
                                totalDieResult = totalDieResult + dieResult;
                                Console.WriteLine("Hit :" + enemtHiy + "  Damage:" + dieResult);

                                Console.WriteLine("------------");


                            }

                            //One in swarm crit
                            if (enemtHiy == 20)
                            {
                                dieResult = (2 * (rng.Next(1, enemyDie) * howManyDies)) + +multiplier;
                                totalDieResult = totalDieResult + dieResult;
                                Console.WriteLine(dieResult + " CRIT!!");

                                Console.WriteLine("------------");

                            }
                        }

                        Console.WriteLine("------------");
                        Console.WriteLine("Total: " + totalDieResult + " damage");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        totalDieResult = 0;
                        carnageDice = 0;
                        howManyDies = 0;
                        dieResult = 0;
                        targetAC = 0;
                        enemtHiy = 0;
                        enemyDie = 0;
                    }
                }
            }
        }

        public static void keyNumberManipulator()
        {
            int[] newModifiers = { 0, 0, 0, 0, 0, 0 };

            counter = 0;
            foreach (int mod in newModifiers)
            {
                newModifiers[counter] = Modifier[counter];
                counter++;
            }
            counter = 0;

            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            Console.WriteLine("What would you like to change ");
            Console.WriteLine("|Skill| for skill modifiers");
            Console.WriteLine("|Score| for abillity scores");
            Console.WriteLine("|Save| for saving throws");
            Console.Write("// ");
            makeShiftString = Console.ReadLine();

            ///Skills
            if (makeShiftString == "Skills" || makeShiftString == "skills" || makeShiftString == "Skill" || makeShiftString == "skill" || makeShiftString == "s" || makeShiftString == "S")
            {

                counter = 1;

                foreach (string skill in SpellList.Skills)
                {
                    Console.WriteLine("|" + counter + "| " + skill);
                    counter++;
                }

                Console.WriteLine("-------------------");
                Console.WriteLine("|S| for str skills");
                Console.WriteLine("|D| for dex skills");
                Console.WriteLine("|I| for int skills");
                Console.WriteLine("|W| for wis skills");
                Console.WriteLine("|C| for cha skills");
                Console.WriteLine("|A| for all skills");
                Console.Write("// ");
                makeShiftString = Console.ReadLine();

                Console.Write("How much: ");

                //Single skill
                {
                    for (int i = 1; i < counter; i++)
                    {
                        if (makeShiftString == Convert.ToString(i))
                        {
                            i--;
                            makeShiftString = Convert.ToString(i);
                            makeShiftString = SpellList.Skills[Convert.ToInt32(makeShiftString)];
                        }
                    }

                    //Str
                    if (makeShiftString == Str)
                    {
                        change = Convert.ToInt32(Console.ReadLine());
                        StrMods[0] = StrMods[0] + change;
                    }

                    //Dex
                    {
                        counter = 0;
                        foreach (string skill in Dex)
                        {
                            if (makeShiftString == skill)
                            {
                                change = Convert.ToInt32(Console.ReadLine());
                                DexMods[counter] = DexMods[counter] + change;
                            }

                            counter++;
                        }
                    }

                    //Int
                    {
                        counter = 0;
                        foreach (string skill in Int)
                        {
                            if (makeShiftString == skill)
                            {
                                change = Convert.ToInt32(Console.ReadLine());
                                IntMods[counter] = IntMods[counter] + change;
                            }

                            counter++;
                        }
                    }

                    //Wis
                    {
                        counter = 0;
                        foreach (string skill in Wis)
                        {
                            if (makeShiftString == skill)
                            {
                                change = Convert.ToInt32(Console.ReadLine());
                                WisMods[counter] = WisMods[counter] + change;
                            }

                            counter++;
                        }
                    }

                    //Cha
                    {
                        counter = 0;
                        foreach (string skill in Cha)
                        {
                            if (makeShiftString == skill)
                            {
                                change = Convert.ToInt32(Console.ReadLine());
                                ChaMods[counter] = ChaMods[counter] + change;
                            }

                            counter++;
                        }
                    }

                }

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

                makeShiftString = "";
            }

            ///Mods
            if (makeShiftString == "Score" || makeShiftString == "score")
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

                makeShiftString = "";
            }

            //New Modifiers
            {
                counter = 0;
                if (change > 0)
                {
                    foreach (int atri in Modifier)
                    {
                        Modifier[counter] = 0;
                        counter++;
                    }
                    counter = 0;
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

                        Modifier[counter] = (Modifier[counter] + atributes);
                        counter++;

                    }
                    counter = 0;
                }
            }

            //New saves
            {
                foreach (int save in SavingThrows)
                {
                    SavingThrows[counter] = SavingThrows[counter] + (Modifier[counter] - newModifiers[counter]);
                    counter++;
                }
            }

            // New Skill proficiancies
            {
                counter = 0;
                if (change > 0)
                {
                    //Str
                    {
                        StrMods[counter] = StrMods[0] + (Modifier[0] - newModifiers[0]);
                        counter = 0;
                    }

                    //Dex
                    {
                        foreach (string skill in Dex)
                        {
                            DexMods[counter] = DexMods[counter] + (Modifier[1] - newModifiers[1]);
                            counter++;
                        }
                        counter = 0;
                    }

                    //Int
                    {
                        foreach (string skill in Int)
                        {
                            IntMods[counter] = IntMods[counter] + (Modifier[3] - newModifiers[3]);
                            counter++;
                        }
                        counter = 0;
                    }

                    //Wis
                    {
                        foreach (string skill in Wis)
                        {
                            WisMods[counter] = WisMods[counter] + (Modifier[4] - newModifiers[4]);
                            counter++;
                        }
                        counter = 0;
                    }

                    //Cha
                    {
                        foreach (string skill in Cha)
                        {
                            ChaMods[counter] = ChaMods[counter] + (Modifier[5] - newModifiers[5]);
                            counter++;
                        }
                        counter = 0;
                    }

                    counter = 0;
                }
            }
        }

        //Weapons and combat
        #region Weapons and combat
        public static void Combat()
        {
            Console.WriteLine();

            Console.Write("Turn: " + combatCounter + "     " + attackCounter + " Attacks this round");
            if (concentraitionCounter > 0)
            {
                Console.Write("            Concentraition counter: " + concentraitionCounter);
            }

            if (rageTimer > 0)
            {
                Console.Write("            Rage Timer: " + rageTimer);
                Console.WriteLine();
                if (DamageDone == 0 || attackedOrNot == false && Level < 14)
                {
                    rageTimer = 0;
                    rage = false;
                }

            }

            //Initiative
            {
                if (barbarianOrNot == false)
                {
                    if (Initiative == 0)
                    {
                        Initiative = rng.Next(1, 21) + Convert.ToInt32(Modifier[1]);
                    }
                    Console.WriteLine("          Initiative: " + Initiative);
                }

                //Barbarian
                if (barbarianOrNot == true)
                {
                    //Advantage as Barbarian
                    if (Level > 6)
                    {
                        if (Initiative == 0)
                        {
                            Initiative = rng.Next(1, 21) + Convert.ToInt32(Modifier[1]);
                            advantage = rng.Next(1, 21) + Convert.ToInt32(Modifier[1]);
                        }
                        if (advantage > Initiative)
                        {
                            Initiative = advantage;
                        }

                        Console.WriteLine("          Initiative: " + Initiative + " " + advantage);
                    }
                }
            }

            //Consentraition
            if (spellConcentraition == true)
            {
                if (DamageDone > 0)
                {
                    DamageDone = DamageDone / 2;
                    Console.WriteLine(DamageDone);

                    if (spellConcentraition == true)
                    {
                        if (DamageDone < 10)
                        {
                            spellBreak = rng.Next(1, 20);
                            if (spellBreak > 10)
                            {
                                Console.WriteLine("Constitution saving throw: " + spellBreak + " + " + Convert.ToInt32(SavingThrows[2]) + " = " + spellBreak + Convert.ToInt32(SavingThrows[2]));
                                Console.WriteLine("You maintain your concentraition");
                            }

                            if (spellBreak < 10)
                            {
                                Console.WriteLine("Constitution saving throw: " + spellBreak + " + " + Convert.ToInt32(SavingThrows[2]) + " = " + (spellBreak + Convert.ToInt32(SavingThrows[2])));
                                Console.WriteLine("You lose your concentraition");
                                concentraitionCounter = 0;
                            }
                        }

                        if (DamageDone > 10)
                        {
                            spellBreak = rng.Next(1, 20);
                            if (spellBreak > DamageDone)
                            {
                                Console.WriteLine("Constitution saving throw: " + spellBreak + " + " + Convert.ToInt32(SavingThrows[2]) + " = " + spellBreak + Convert.ToInt32(SavingThrows[2]));
                                Console.WriteLine("You maintain your concentraition");
                            }

                            if (spellBreak < DamageDone)
                            {
                                Console.WriteLine("Constitution saving throw: " + spellBreak + " + " + Convert.ToInt32(SavingThrows[2]) + " = " + spellBreak + Convert.ToInt32(SavingThrows[2]));
                                Console.WriteLine("You lose your concentraition");
                                concentraitionCounter = 0;
                            }
                        }
                    }
                }
            }

            //advance turn
            if (Exit.Key == ConsoleKey.Enter)
            {
                concentraitionCounter--;
                combatCounter++;

                if (rages < 1351)
                {
                    rageTimer--;
                    if (rageTimer <= 0)
                    {
                        rage = false;
                    }
                }
                attackedOrNot = false;
                attackCounter = 0;
            }
            Console.WriteLine();
            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine("Hit |Enter| to advance the round");
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            Console.WriteLine();
        }

        //Carefull a lot of stuff is going on here...
        //It's a simple search engine
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
                Console.WriteLine();
            }

            //Search
            {
                Console.Write("// ");
                searchTool = Console.ReadLine();

                //All
                {
                    if (searchTool == "All")
                    {
                        for (int range = 0; range < Weapons.allWeapons.Length; range++)
                        {
                            // Martial 
                            foreach (int damageType in Weapons.martial)
                            {
                                if (damageType == range)
                                {
                                    Console.Write(" Martial ");
                                }
                            }

                            // Simple 
                            foreach (int damageType in Weapons.simple)
                            {
                                if (damageType == range)
                                {
                                    Console.Write(" Simple ");
                                }
                            }

                            // Firearms 
                            foreach (int damageType in Weapons.firearms)
                            {
                                if (damageType == range)
                                {
                                    Console.Write(" Firearm ");
                                }
                            }

                            ///Weapon name and damage
                            Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                            ///Damage Type
                            {
                                // bludgeoning 
                                foreach (int damageType in Weapons.bludgeoning)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                //Fire
                                foreach (int damageType in Weapons.fire)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" fire ");
                                    }
                                }

                                //Necrotic
                                foreach (int damageType in Weapons.necrotic)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" necrotic ");
                                    }
                                }

                                //Piercing
                                foreach (int damageType in Weapons.piercing)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" piercing ");
                                    }
                                }

                                //Radiant
                                foreach (int damageType in Weapons.radiant)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" radiant ");
                                    }
                                }

                                //Slashing
                                foreach (int damageType in Weapons.slashing)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" slashing ");
                                    }
                                }
                            }

                            ///Range
                            {
                                //Ranged
                                {
                                    // Ranged 
                                    foreach (int distance in Weapons.ranged)
                                    {
                                        if (distance == range)
                                        {
                                            Console.Write("ranged ");
                                        }
                                    }

                                    //Melee
                                    foreach (int distance in Weapons.melee)
                                    {
                                        if (distance == range)
                                        {
                                            Console.Write("melee ");
                                        }
                                    }

                                    Console.Write("damage ");
                                }
                            }

                            Console.WriteLine();

                            ///Properties
                            {
                                //Ammu
                                foreach (int prop in Weapons.ammunition)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Ammunation ");
                                    }
                                }

                                //Burstfire
                                foreach (int prop in Weapons.burstFire)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Burstfire ");
                                    }
                                }

                                //Explosive
                                foreach (int prop in Weapons.explosive)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Explosive");
                                    }
                                }

                                //Finess
                                foreach (int prop in Weapons.finesse)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Finesse");
                                    }
                                }

                                //Heavy
                                foreach (int prop in Weapons.heavy)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Heavy");
                                    }
                                }

                                //Light
                                foreach (int prop in Weapons.light)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Light");
                                    }
                                }

                                //Loading
                                foreach (int prop in Weapons.loading)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Loading");
                                    }
                                }

                                //Misfire
                                foreach (int prop in Weapons.misfire)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Misfire");
                                    }
                                }

                                //Reach
                                foreach (int prop in Weapons.reach)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Reach");
                                    }
                                }

                                //Reload
                                foreach (int prop in Weapons.reload)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Reaload");
                                    }
                                }

                                //Special
                                foreach (int prop in Weapons.special)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Special");
                                    }
                                }

                                //Thrown
                                foreach (int prop in Weapons.thrown)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Thrown");
                                    }
                                }

                                //Two handed
                                foreach (int prop in Weapons.twoHanded)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Two handed");
                                    }
                                }

                                //Versatile
                                foreach (int prop in Weapons.versatile)
                                {
                                    if (prop == range)
                                    {
                                        Console.WriteLine(" -Versatile");
                                    }
                                }


                            }

                            Console.WriteLine();
                        }
                    }
                }

                ///Complexity
                {
                    //Simple
                    {
                        if (searchTool == "Simple")
                        ///Complexity
                        {
                            //Simple
                            foreach (int complexity in Weapons.simple)
                            {
                                Console.Write("Simple ");

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[complexity] + ": " + Weapons.numberOfDice[complexity] + "d" + Weapons.damageDie[complexity]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == complexity)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == complexity)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Martial
                    {

                        if (searchTool == "Martial")
                        ///Complexity
                        {
                            //Simple
                            foreach (int complexity in Weapons.martial)
                            {
                                Console.Write("Martial ");

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[complexity] + ": " + Weapons.numberOfDice[complexity] + "d" + Weapons.damageDie[complexity]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == complexity)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == complexity)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }


                    //Firearms
                    {

                        if (searchTool == "Firearms")
                        {
                            //Firearm
                            foreach (int complexity in Weapons.firearms)
                            {
                                Console.Write("Firearm ");

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[complexity] + ": " + Weapons.numberOfDice[complexity] + "d" + Weapons.damageDie[complexity]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == complexity)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == complexity)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == complexity)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == complexity)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }
                }

                ///Range
                {
                    //Ranged
                    {
                        if (searchTool == "Ranged")
                        {
                            foreach (int range in Weapons.ranged)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearms ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Melee
                    {
                        if (searchTool == "Melee")
                        {
                            foreach (int range in Weapons.melee)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearms ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }
                }

                ///Damage type
                {
                    //Blud
                    {
                        if (searchTool == "Bludgeoning")
                        {
                            foreach (int range in Weapons.bludgeoning)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Fire
                    {
                        if (searchTool == "Fire")
                        {
                            foreach (int range in Weapons.fire)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Necro
                    {
                        if (searchTool == "Necrotic")
                        {
                            foreach (int range in Weapons.necrotic)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Piercing
                    {
                        if (searchTool == "Piercing")
                        {
                            foreach (int range in Weapons.piercing)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Radiant
                    {
                        if (searchTool == "Radiant")
                        {
                            foreach (int range in Weapons.radiant)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Slashing
                    {
                        if (searchTool == "Slashing")
                        {
                            foreach (int range in Weapons.slashing)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }
                }

                ///Properties
                {
                    //Ammu
                    {
                        if (searchTool == "Ammunition")
                        {
                            foreach (int range in Weapons.ammunition)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firemarm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Burstfire
                    {
                        if (searchTool == "Burstfire")
                        {
                            foreach (int range in Weapons.burstFire)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Explosive
                    {
                        if (searchTool == "Explosive")
                        {
                            foreach (int range in Weapons.explosive)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Finesse
                    {
                        if (searchTool == "Finesse")
                        {
                            foreach (int range in Weapons.finesse)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Heavy
                    {
                        if (searchTool == "Heavy")
                        {
                            foreach (int range in Weapons.heavy)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Light
                    {
                        if (searchTool == "Light")
                        {
                            foreach (int range in Weapons.light)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Loading
                    {
                        if (searchTool == "Loading")
                        {
                            foreach (int range in Weapons.loading)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Misfire
                    {
                        if (searchTool == "Misfire")
                        {
                            foreach (int range in Weapons.misfire)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Reach
                    {
                        if (searchTool == "Reach")
                        {
                            foreach (int range in Weapons.reach)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Reload
                    {
                        if (searchTool == "Reload")
                        {
                            foreach (int range in Weapons.reload)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Special
                    {
                        if (searchTool == "Special")
                        {
                            foreach (int range in Weapons.special)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Thrown
                    {
                        if (searchTool == "Thrown")
                        {
                            foreach (int range in Weapons.thrown)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Two handed
                    {
                        if (searchTool == "Two handed" || searchTool == "TwoHanded" || searchTool == "Twohanded")
                        {
                            foreach (int range in Weapons.twoHanded)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }

                    //Versatile
                    {
                        if (searchTool == "Versatile")
                        {
                            foreach (int range in Weapons.versatile)
                            {
                                // Martial 
                                foreach (int damageType in Weapons.martial)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Martial ");
                                    }
                                }

                                // Simple 
                                foreach (int damageType in Weapons.simple)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Simple ");
                                    }
                                }

                                // Firearms 
                                foreach (int damageType in Weapons.firearms)
                                {
                                    if (damageType == range)
                                    {
                                        Console.Write(" Firearm ");
                                    }
                                }

                                ///Weapon name and damage
                                Console.Write(Weapons.allWeapons[range] + ": " + Weapons.numberOfDice[range] + "d" + Weapons.damageDie[range]);

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == range)
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                ///Range
                                {
                                    //Ranged
                                    {
                                        // Ranged 
                                        foreach (int distance in Weapons.ranged)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("ranged ");
                                            }
                                        }

                                        //Melee
                                        foreach (int distance in Weapons.melee)
                                        {
                                            if (distance == range)
                                            {
                                                Console.Write("melee ");
                                            }
                                        }

                                        Console.Write("damage ");
                                    }
                                }

                                Console.WriteLine();

                                ///Properties
                                {
                                    //Ammu
                                    foreach (int prop in Weapons.ammunition)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Ammunation ");
                                        }
                                    }

                                    //Burstfire
                                    foreach (int prop in Weapons.burstFire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Burstfire ");
                                        }
                                    }

                                    //Explosive
                                    foreach (int prop in Weapons.explosive)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Explosive");
                                        }
                                    }

                                    //Finess
                                    foreach (int prop in Weapons.finesse)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Finesse");
                                        }
                                    }

                                    //Heavy
                                    foreach (int prop in Weapons.heavy)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Heavy");
                                        }
                                    }

                                    //Light
                                    foreach (int prop in Weapons.light)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Light");
                                        }
                                    }

                                    //Loading
                                    foreach (int prop in Weapons.loading)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Loading");
                                        }
                                    }

                                    //Misfire
                                    foreach (int prop in Weapons.misfire)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Misfire");
                                        }
                                    }

                                    //Reach
                                    foreach (int prop in Weapons.reach)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reach");
                                        }
                                    }

                                    //Reload
                                    foreach (int prop in Weapons.reload)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Reaload");
                                        }
                                    }

                                    //Special
                                    foreach (int prop in Weapons.special)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Special");
                                        }
                                    }

                                    //Thrown
                                    foreach (int prop in Weapons.thrown)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Thrown");
                                        }
                                    }

                                    //Two handed
                                    foreach (int prop in Weapons.twoHanded)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Two handed");
                                        }
                                    }

                                    //Versatile
                                    foreach (int prop in Weapons.versatile)
                                    {
                                        if (prop == range)
                                        {
                                            Console.WriteLine(" -Versatile");
                                        }
                                    }


                                }

                                Console.WriteLine();
                            }
                        }
                    }
                }

            }

            //Add Weapon
            {
                Console.WriteLine("Add a weapon");
                Console.Write("// ");
                makeShiftString = Console.ReadLine();
                counter = 0;
                if (makeShiftString != "")
                {
                    foreach (string killThing in Weapons.allWeapons)
                    {
                        if (makeShiftString == Convert.ToString(counter))
                        {
                            yourWeapon.Add(counter);
                        }

                        if (makeShiftString == killThing)
                        {
                            yourWeapon.Add(counter);
                        }
                        counter++;

                    }
                    counter = 0;

                    //Finnese or ranged
                    {
                        foreach (int bowGun in Weapons.ranged)
                        {
                            if (bowGun == yourWeapon[weaponCounter])
                            {
                                rangedWeapon.Add(true);
                                counter++;
                            }
                        }

                        if (counter > 0)
                        {
                            rangedWeapon.Add(false);
                        }

                        counter = 0;
                    }

                    //Weapon proficiant
                    {
                        Console.WriteLine("Are you proficient in this Weapon |Yes| or |No|");
                        Console.Write("// ");

                        yesOrNo = Console.ReadLine();

                        if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                        {
                            weaponPro.Add(true);
                        }

                        if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "NO" || yesOrNo == "No" || yesOrNo == "no" || yesOrNo == "")
                        {
                            weaponPro.Add(false);
                        }


                    }

                }
            }

        }

        public static void Attack()
        {
            weaponCounter = 0;
            foreach (int weapon in yourWeapon)
            {
                Console.WriteLine(Weapons.allWeapons[yourWeapon[weaponCounter]] + ":");

                //To hit
                {
                    if (weaponPro[weaponCounter] == true)
                    {
                        toHit = Convert.ToInt32(Modifier[0] + ProficiencyBonus);
                    }

                    if (weaponPro[weaponCounter] == false)
                    {
                        toHit = Convert.ToInt32(Modifier[0]);
                    }

                    attackRoll = rng.Next(1, 21);

                    if (attackRoll != 1)
                    {
                        if (attackRoll != 20)
                        {
                            Console.WriteLine("To hit " + attackRoll + " + " + toHit + " = " + (attackRoll + toHit));
                        }

                        if (attackRoll == 20)
                        {
                            Console.WriteLine(attackRoll + "20 CRIT!!!");
                        }
                    }
                }

                //Damage roll
                {
                    Console.WriteLine();

                    //Melee
                    if (rangedWeapon[weaponCounter] == false)
                    {
                        counter = 0;
                        //If not a crit
                        do
                        {
                            if (attackRoll != 20 && attackRoll != 1 && rage == false)
                            {
                                for (int i = 0; i < Weapons.numberOfDice[yourWeapon[weaponCounter]]; i++)
                                {
                                    weaponDamageDealt = rng.Next(1, Weapons.damageDie[yourWeapon[weaponCounter]] + 1);
                                    damageHolder = weaponDamageDealt + damageHolder;
                                    if (fighterOrNot == true && fightingStyles[3] == true)
                                    {
                                        if (weaponDamageDealt == 1 || weaponDamageDealt == 2 && reroll == false)
                                        {
                                            reroll = true;
                                        }
                                    }
                                }

                                weaponDamageDealt = damageHolder;
                                damageHolder = 0;

                                if (weaponPro[weaponCounter] == false)
                                {
                                    Console.Write("You dealt " + Weapons.numberOfDice[yourWeapon[weaponCounter]] + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt + "||" + weaponDamageDealt + " + " + Modifier[0] + " = " + (weaponDamageDealt + Modifier[0]));
                                }

                                if (weaponPro[weaponCounter] == true)
                                {
                                    Console.Write("You dealt " + Weapons.numberOfDice[yourWeapon[weaponCounter]] + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt + "||" + weaponDamageDealt + " + " + Modifier[0] + " + " + ProficiencyBonus + " = " + (weaponDamageDealt + Modifier[0] + ProficiencyBonus));
                                }

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }

                                Console.Write("damage");

                                if (counter != 0)
                                {
                                    reroll = false;
                                }

                                if (reroll == true && counter == 0)
                                {
                                    Console.WriteLine("_______________________________");
                                    Console.WriteLine("Do you want to reroll your hit?");
                                    Console.Write("// ");
                                    yesOrNo = Console.ReadLine();
                                    if (yesOrNo == "y" || yesOrNo == "Y" || yesOrNo == "yes" || yesOrNo == "Yes" || yesOrNo == "YES")
                                    {
                                        reroll = true;
                                    }

                                    if (yesOrNo == "n" || yesOrNo == "N" || yesOrNo == "no" || yesOrNo == "No" || yesOrNo == "NO")
                                    {
                                        reroll = false;
                                    }
                                    counter++;
                                }

                            }
                        } while (reroll == true);

                        //If normal crit
                        if (barbarianOrNot == false && Level > 8)
                        {
                            if (attackRoll == 20)
                            {

                                for (int i = 0; i < (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 2); i++)
                                {
                                    weaponDamageDealt = rng.Next(1, Weapons.damageDie[yourWeapon[weaponCounter]] + 1) + weaponDamageDealt;
                                }

                                if (weaponPro[weaponCounter] == true)
                                {
                                    Console.WriteLine("You dealt " + (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 2) + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt);

                                    Console.Write("You dealt " + weaponDamageDealt + " + " + Modifier[0] + " + " + ProficiencyBonus + " = " + (weaponDamageDealt + Modifier[0] + ProficiencyBonus));
                                }

                                if (weaponPro[weaponCounter] == false)
                                {
                                    Console.WriteLine("You dealt " + (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 2) + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt);

                                    Console.Write("You dealt " + weaponDamageDealt + " + " + Modifier[0] + " + " + " = " + (weaponDamageDealt + Modifier[0] + ProficiencyBonus));
                                }

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }
                                Console.Write("damage");
                            }
                        }

                        if (fighterOrNot == true)
                        {
                            if (fightingStyles[3] == true)
                            {

                            }
                        }

                        //Barbarian
                        {
                            //If brutal crit
                            if (barbarianOrNot == true && attackRoll == 20)
                            {
                                if (brutalCrit == 1)
                                {

                                    for (int i = 0; i < (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 3); i++)
                                    {
                                        weaponDamageDealt = rng.Next(1, Weapons.damageDie[yourWeapon[weaponCounter]] + 2) + weaponDamageDealt;
                                    }

                                    if (weaponPro[weaponCounter] == true)
                                    {
                                        Console.WriteLine("You dealt " + (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 3) + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt);

                                        Console.Write("You dealt " + weaponDamageDealt + " + " + Modifier[0] + " + " + ProficiencyBonus + " = " + (weaponDamageDealt + Modifier[0] + ProficiencyBonus));
                                    }

                                    if (weaponPro[weaponCounter] == false)
                                    {
                                        Console.WriteLine("You dealt " + (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 3) + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt);

                                        Console.Write("You dealt " + weaponDamageDealt + " + " + Modifier[0] + " = " + (weaponDamageDealt + Modifier[0] + ProficiencyBonus));
                                    }

                                    ///Damage Type
                                    {
                                        // bludgeoning 
                                        foreach (int damageType in Weapons.bludgeoning)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" bludgeoning ");
                                            }
                                        }

                                        //Fire
                                        foreach (int damageType in Weapons.fire)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" fire ");
                                            }
                                        }

                                        //Necrotic
                                        foreach (int damageType in Weapons.necrotic)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" necrotic ");
                                            }
                                        }

                                        //Piercing
                                        foreach (int damageType in Weapons.piercing)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" piercing ");
                                            }
                                        }

                                        //Radiant
                                        foreach (int damageType in Weapons.radiant)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" radiant ");
                                            }
                                        }

                                        //Slashing
                                        foreach (int damageType in Weapons.slashing)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" slashing ");
                                            }
                                        }
                                    }
                                    Console.Write("damage");
                                }

                                if (brutalCrit == 2)
                                {

                                    for (int i = 0; i < (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 4); i++)
                                    {
                                        weaponDamageDealt = rng.Next(1, Weapons.damageDie[yourWeapon[weaponCounter]] + 3) + weaponDamageDealt;
                                    }

                                    if (weaponPro[weaponCounter] == true)
                                    {
                                        Console.WriteLine("You dealt " + (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 4) + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt);

                                        Console.Write("You dealt " + weaponDamageDealt + " + " + Modifier[0] + " + " + ProficiencyBonus + " = " + (weaponDamageDealt + Modifier[0] + ProficiencyBonus));
                                    }

                                    if (weaponPro[weaponCounter] == false)
                                    {
                                        Console.WriteLine("You dealt " + (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 4) + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt);

                                        Console.Write("You dealt " + weaponDamageDealt + " + " + Modifier[0] + " = " + (weaponDamageDealt + Modifier[0] + ProficiencyBonus));
                                    }

                                    ///Damage Type
                                    {
                                        // bludgeoning 
                                        foreach (int damageType in Weapons.bludgeoning)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" bludgeoning ");
                                            }
                                        }

                                        //Fire
                                        foreach (int damageType in Weapons.fire)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" fire ");
                                            }
                                        }

                                        //Necrotic
                                        foreach (int damageType in Weapons.necrotic)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" necrotic ");
                                            }
                                        }

                                        //Piercing
                                        foreach (int damageType in Weapons.piercing)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" piercing ");
                                            }
                                        }

                                        //Radiant
                                        foreach (int damageType in Weapons.radiant)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" radiant ");
                                            }
                                        }

                                        //Slashing
                                        foreach (int damageType in Weapons.slashing)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" slashing ");
                                            }
                                        }
                                    }
                                    Console.Write("damage");
                                }

                                if (brutalCrit == 3)
                                {

                                    for (int i = 0; i < (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 5); i++)
                                    {
                                        weaponDamageDealt = rng.Next(1, Weapons.damageDie[yourWeapon[weaponCounter]] + 4) + weaponDamageDealt;
                                    }

                                    if (weaponPro[weaponCounter] == true)
                                    {
                                        Console.WriteLine("You dealt " + (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 5) + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt);

                                        Console.Write("You dealt " + weaponDamageDealt + " + " + Modifier[0] + " + " + ProficiencyBonus + " = " + (weaponDamageDealt + Modifier[0] + ProficiencyBonus));
                                    }

                                    if (weaponPro[weaponCounter] == false)
                                    {
                                        Console.WriteLine("You dealt " + (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 5) + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt);

                                        Console.Write("You dealt " + weaponDamageDealt + " + " + Modifier[0] + " = " + (weaponDamageDealt + Modifier[0] + ProficiencyBonus));
                                    }

                                    ///Damage Type
                                    {
                                        // bludgeoning 
                                        foreach (int damageType in Weapons.bludgeoning)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" bludgeoning ");
                                            }
                                        }

                                        //Fire
                                        foreach (int damageType in Weapons.fire)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" fire ");
                                            }
                                        }

                                        //Necrotic
                                        foreach (int damageType in Weapons.necrotic)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" necrotic ");
                                            }
                                        }

                                        //Piercing
                                        foreach (int damageType in Weapons.piercing)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" piercing ");
                                            }
                                        }

                                        //Radiant
                                        foreach (int damageType in Weapons.radiant)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" radiant ");
                                            }
                                        }

                                        //Slashing
                                        foreach (int damageType in Weapons.slashing)
                                        {
                                            if (damageType == yourWeapon[weaponCounter])
                                            {
                                                Console.Write(" slashing ");
                                            }
                                        }
                                    }
                                    Console.Write("damage");
                                }
                            }

                            if (attackRoll != 20 && attackRoll != 1 && rage == true)
                            {
                                for (int i = 0; i < Weapons.numberOfDice[yourWeapon[weaponCounter]]; i++)
                                {
                                    weaponDamageDealt = rng.Next(1, Weapons.damageDie[yourWeapon[weaponCounter]] + 1) + weaponDamageDealt;
                                }

                                if (weaponPro[weaponCounter] == false)
                                {
                                    Console.Write("You dealt " + Weapons.numberOfDice[yourWeapon[weaponCounter]] + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt + "||" + weaponDamageDealt + " + " + Modifier[0] + " + " + rageDamage + " = " + (weaponDamageDealt + Modifier[0] + rageDamage));
                                }

                                if (weaponPro[weaponCounter] == true)
                                {
                                    Console.Write("You dealt " + Weapons.numberOfDice[yourWeapon[weaponCounter]] + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt + "||" + weaponDamageDealt + " + " + Modifier[0] + " + " + ProficiencyBonus + " + " + rageDamage + " = " + (rageDamage + weaponDamageDealt + Modifier[0] + ProficiencyBonus));
                                }

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }
                                Console.Write("damage");

                            }
                        }

                        //Flops
                        if (attackRoll == 1)
                        {
                            Console.WriteLine("A swing and a miss...");
                        }


                        weaponDamageDealt = 0;
                    }

                    //Ranged weapon// Finesse
                    if (rangedWeapon[weaponCounter] == true)
                    {
                        //If not a crit
                        if (attackRoll != 20 && attackRoll != 1)
                        {
                            //Normal hits
                            {
                                for (int i = 0; i < Weapons.numberOfDice[yourWeapon[weaponCounter]]; i++)
                                {
                                    weaponDamageDealt = rng.Next(1, Weapons.damageDie[yourWeapon[weaponCounter]] + 1) + weaponDamageDealt;
                                }

                                if (fighterOrNot == false)
                                {
                                    if (weaponPro[weaponCounter] == false)
                                    {
                                        Console.Write("You dealt " + Weapons.numberOfDice[yourWeapon[weaponCounter]] + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt + "||" + weaponDamageDealt + " + " + Modifier[1] + " = " + (weaponDamageDealt + Modifier[1]));
                                    }

                                    if (weaponPro[weaponCounter] == true)
                                    {
                                        Console.Write("You dealt " + Weapons.numberOfDice[yourWeapon[weaponCounter]] + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt + "||" + weaponDamageDealt + " + " + Modifier[1] + " + " + ProficiencyBonus + " = " + (weaponDamageDealt + Modifier[1] + ProficiencyBonus));
                                    }
                                }
                            }

                            //Fighter
                            if (fighterOrNot == true)
                            {
                                //Archer
                                {
                                    if (fightingStyles[0] == true)
                                    {
                                        if (weaponPro[weaponCounter] == false)
                                        {
                                            Console.Write("You dealt " + Weapons.numberOfDice[yourWeapon[weaponCounter]] + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt + "||" + weaponDamageDealt + " + " + Modifier[1] + " + 2 +" + " = " + (weaponDamageDealt + Modifier[1] + 2));
                                        }

                                        if (weaponPro[weaponCounter] == true)
                                        {
                                            Console.Write("You dealt " + Weapons.numberOfDice[yourWeapon[weaponCounter]] + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt + "||" + weaponDamageDealt + " + " + Modifier[1] + " + " + ProficiencyBonus + " + 2 +" + " = " + (weaponDamageDealt + Modifier[1] + ProficiencyBonus + 2));
                                        }
                                    }
                                }
                            }

                            ///Damage Type
                            {
                                // bludgeoning 
                                foreach (int damageType in Weapons.bludgeoning)
                                {
                                    if (damageType == yourWeapon[weaponCounter])
                                    {
                                        Console.Write(" bludgeoning ");
                                    }
                                }

                                //Fire
                                foreach (int damageType in Weapons.fire)
                                {
                                    if (damageType == yourWeapon[weaponCounter])
                                    {
                                        Console.Write(" fire ");
                                    }
                                }

                                //Necrotic
                                foreach (int damageType in Weapons.necrotic)
                                {
                                    if (damageType == yourWeapon[weaponCounter])
                                    {
                                        Console.Write(" necrotic ");
                                    }
                                }

                                //Piercing
                                foreach (int damageType in Weapons.piercing)
                                {
                                    if (damageType == yourWeapon[weaponCounter])
                                    {
                                        Console.Write(" piercing ");
                                    }
                                }

                                //Radiant
                                foreach (int damageType in Weapons.radiant)
                                {
                                    if (damageType == yourWeapon[weaponCounter])
                                    {
                                        Console.Write(" radiant ");
                                    }
                                }

                                //Slashing
                                foreach (int damageType in Weapons.slashing)
                                {
                                    if (damageType == yourWeapon[weaponCounter])
                                    {
                                        Console.Write(" slashing ");
                                    }
                                }
                            }
                            Console.Write("damage");

                        }

                        //If normal crit
                        {
                            if (attackRoll == 20)
                            {

                                for (int i = 0; i < (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 2); i++)
                                {
                                    weaponDamageDealt = rng.Next(1, Weapons.damageDie[yourWeapon[weaponCounter]] + 1) + weaponDamageDealt;
                                }

                                if (weaponPro[weaponCounter] == true)
                                {
                                    Console.WriteLine("You dealt " + (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 2) + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt);

                                    Console.Write("You dealt " + weaponDamageDealt + " + " + Modifier[1] + " + " + ProficiencyBonus + " = " + (weaponDamageDealt + Modifier[1] + ProficiencyBonus));
                                }

                                if (weaponPro[weaponCounter] == false)
                                {
                                    Console.WriteLine("You dealt " + (Weapons.numberOfDice[yourWeapon[weaponCounter]] * 2) + "d" + Weapons.damageDie[yourWeapon[weaponCounter]] + " = " + weaponDamageDealt);

                                    Console.Write("You dealt " + weaponDamageDealt + " + " + Modifier[1] + " = " + (weaponDamageDealt + Modifier[1] + ProficiencyBonus));
                                }

                                ///Damage Type
                                {
                                    // bludgeoning 
                                    foreach (int damageType in Weapons.bludgeoning)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" bludgeoning ");
                                        }
                                    }

                                    //Fire
                                    foreach (int damageType in Weapons.fire)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" fire ");
                                        }
                                    }

                                    //Necrotic
                                    foreach (int damageType in Weapons.necrotic)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" necrotic ");
                                        }
                                    }

                                    //Piercing
                                    foreach (int damageType in Weapons.piercing)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" piercing ");
                                        }
                                    }

                                    //Radiant
                                    foreach (int damageType in Weapons.radiant)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" radiant ");
                                        }
                                    }

                                    //Slashing
                                    foreach (int damageType in Weapons.slashing)
                                    {
                                        if (damageType == yourWeapon[weaponCounter])
                                        {
                                            Console.Write(" slashing ");
                                        }
                                    }
                                }
                                Console.Write("damage");
                            }
                        }

                        //Flops
                        if (attackRoll == 1)
                        {
                            Console.WriteLine("A swing and a miss...");
                        }

                        weaponDamageDealt = 0;
                    }
                }

                weaponCounter++;
            }

            if (combat == true)
            {
                attackCounter++;
            }
        }
        #endregion 
        public static void YourWeaponStats()
        {
            Console.WriteLine();
            weaponCounter = 0;
            ///Weapons
            {
                foreach (int weapons in yourWeapon)
                {
                    //Firearms
                    foreach (int complexity in Weapons.firearms)
                    {
                        if (complexity == yourWeapon[weaponCounter])
                        {
                            Console.Write("Firearms ");
                        }
                    }

                    //Martial
                    foreach (int complexity in Weapons.martial)
                    {
                        if (complexity == yourWeapon[weaponCounter])
                        {
                            Console.Write("Martial ");
                        }
                    }

                    //Simple
                    foreach (int complexity in Weapons.simple)
                    {
                        if (complexity == yourWeapon[weaponCounter])
                        {
                            Console.Write("Simple ");
                        }
                    }


                    Console.Write(Weapons.allWeapons[yourWeapon[weaponCounter]] + ": " + Weapons.numberOfDice[yourWeapon[weaponCounter]] + "d" + Weapons.damageDie[yourWeapon[weaponCounter]]);
                    ///Damage Type
                    {
                        // bludgeoning 
                        foreach (int damageType in Weapons.bludgeoning)
                        {
                            if (damageType == yourWeapon[weaponCounter])
                            {
                                Console.Write(" bludgeoning ");
                            }
                        }

                        //Fire
                        foreach (int damageType in Weapons.fire)
                        {
                            if (damageType == yourWeapon[weaponCounter])
                            {
                                Console.Write(" fire ");
                            }
                        }

                        //Necrotic
                        foreach (int damageType in Weapons.necrotic)
                        {
                            if (damageType == yourWeapon[weaponCounter])
                            {
                                Console.Write(" necrotic ");
                            }
                        }

                        //Piercing
                        foreach (int damageType in Weapons.piercing)
                        {
                            if (damageType == yourWeapon[weaponCounter])
                            {
                                Console.Write(" piercing ");
                            }
                        }

                        //Radiant
                        foreach (int damageType in Weapons.radiant)
                        {
                            if (damageType == yourWeapon[weaponCounter])
                            {
                                Console.Write(" radiant ");
                            }
                        }

                        //Slashing
                        foreach (int damageType in Weapons.slashing)
                        {
                            if (damageType == yourWeapon[weaponCounter])
                            {
                                Console.Write(" slashing ");
                            }
                        }
                    }

                    ///Range
                    {
                        //Ranged
                        {
                            // Ranged 
                            foreach (int distance in Weapons.ranged)
                            {
                                if (distance == yourWeapon[weaponCounter])
                                {
                                    Console.Write("ranged ");
                                }
                            }

                            // Melee
                            foreach (int distance in Weapons.melee)
                            {
                                if (distance == yourWeapon[weaponCounter])
                                {
                                    Console.Write("melee ");
                                }
                            }

                            Console.Write("damage ");
                        }
                    }

                    Console.WriteLine();

                    ///Properties
                    {
                        //Ammu
                        foreach (int prop in Weapons.ammunition)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Ammunation ");
                            }
                        }

                        //Burstfire
                        foreach (int prop in Weapons.burstFire)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Burstfire ");
                            }
                        }

                        //Explosive
                        foreach (int prop in Weapons.explosive)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Explosive");
                            }
                        }

                        //Finess
                        foreach (int prop in Weapons.finesse)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Finesse");
                            }
                        }

                        //Heavy
                        foreach (int prop in Weapons.heavy)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Heavy");
                            }
                        }

                        //Light
                        foreach (int prop in Weapons.light)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Light");
                            }
                        }

                        //Loading
                        foreach (int prop in Weapons.loading)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Loading");
                            }
                        }

                        //Misfire
                        foreach (int prop in Weapons.misfire)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Misfire");
                            }
                        }

                        //Reach
                        foreach (int prop in Weapons.reach)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Reach");
                            }
                        }

                        //Reload
                        foreach (int prop in Weapons.reload)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Reaload");
                            }
                        }

                        //Special
                        foreach (int prop in Weapons.special)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Special");
                            }
                        }

                        //Thrown
                        foreach (int prop in Weapons.thrown)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Thrown");
                            }
                        }

                        //Two handed
                        foreach (int prop in Weapons.twoHanded)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Two handed");
                            }
                        }

                        //Versatile
                        foreach (int prop in Weapons.versatile)
                        {
                            if (prop == yourWeapon[weaponCounter])
                            {
                                Console.WriteLine("  -Versatile");
                            }
                        }


                    }
                    Console.WriteLine();
                    weaponCounter++;
                }

            }
        }
        #endregion

        ///Nice setup
        ///Connect the classes to the spells

        public static void GMCommands()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            if (NPCUse == false && GAMEMASTER == true)
            {
                //NPC (N)
                {
                    if (NPC == false)
                    {
                        Console.WriteLine("Press |N| to create a NPC");

                        if (Exit .Key == ConsoleKey.N)
                        {
                            Essentials();
                            NPC = true;
                        }
                    }

                    if (NPC == true)
                    {
                        Console.WriteLine("Press |N| to act as your NPC");
                        NPCUse = true;
                    }
                }
            }

            //If NPC
            {
                if (NPC == true)
                {
                    PlayerPrint();

                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine();

                    Console.WriteLine("Type theese buttons to do stuff:");
                    //Attack (A)
                    {
                        if (weaponCounter > 0)
                        {
                            if (MagicalClass != "Fighter")
                            {
                                Console.WriteLine("Press |A| to Attack:");
                            }

                            if (MagicalClass != "Fighter")
                            {
                                Console.WriteLine("Press |A| to Attack, " + (extraAttack + 1) + " per round:");
                            }
                        }
                    }
                    //Bardic inspiration (B)
                    {
                        if (bardOrNot == true)
                        {
                            Console.WriteLine("Press |B| to give a bardic inspiration (" + bardicInspirationLeft + "):");
                        }
                    }
                    ///Combat (C)
                    {
                        //Combat End (C)
                        if (combat == true)
                        {
                            Console.WriteLine("Press |C| to end combat:");
                        }
                        //Combat Start (C)
                        if (combat == false)
                        {
                            Console.WriteLine("Press |C| to enter combat and roll initiative:");
                        }
                    }
                    Console.WriteLine("Press |D| to take damage:");
                    //Exchange spells (E)
                    {
                        if (dayToDayCaster == true)
                        {
                            Console.WriteLine("Press |E| to exchange spells:");
                        }
                    }
                    Console.WriteLine("Press |F| to gain full health:");
                    Console.WriteLine("Press |G| to grapple:");
                    Console.WriteLine("Press |H| to Heal:");
                    Console.WriteLine("Press |L| to Levelup:");
                    Console.WriteLine("Press |M| to Change your modifiers:");
                    //Wild shape
                    if (druidOrNot == true)
                    {
                        if (wildShape > 0)
                        {
                            if (shapedOrNot == false)
                            {
                                Console.ResetColor();
                                if (Level < 19)
                                {
                                    Console.WriteLine("Press |N| to wild shape (" + wildShape + " left); " + maxCr);
                                }

                                if (Level > 19)
                                {
                                    Console.WriteLine("Press |N| to wild shape:");
                                }

                                if (Exit.Key == ConsoleKey.N)
                                {
                                    shapedOrNot = true;
                                    wildShape--;
                                }
                            }

                            if (shapedOrNot == true)
                            {
                                Console.WriteLine("Press |Q| end wild shape:");
                                if (Exit.Key == ConsoleKey.Q)
                                {
                                    shapedOrNot = false;
                                }
                            }
                        }
                    }

                    //Rage (P)
                    if (barbarianOrNot == true)
                    {
                        if (rages > 0)
                        {
                            if (rage == false)
                            {
                                Console.ResetColor();
                                if (Level < 19)
                                {
                                    Console.WriteLine("Press |P| to Rage (" + rages + " left):");
                                }

                                if (Level > 19)
                                {
                                    Console.WriteLine("Press |P| to Rage:");
                                }

                                if (Exit.Key == ConsoleKey.P)
                                {
                                    rage = true;
                                    rages--;
                                    rageTimer = 10;
                                }
                            }

                            if (rage == true)
                            {
                                Console.WriteLine("Press |Q| end Rage (+" + rageDamage + "):");
                                if (Exit.Key == ConsoleKey.Q)
                                {
                                    rage = false;
                                }
                            }
                        }
                    }
                    Console.WriteLine("Press |R| to roll a die:");
                    //Spell (S)
                    {
                        if (SpeelsOrNot == true && warlockOrNot == false)
                        {
                            Console.WriteLine("Press |S| to Cast a Spell:");
                        }

                        //if warlock spell (S)
                        if (spellSlots > 0 && warlockOrNot == true)
                        {
                            Console.WriteLine("Press |S| to Cast a Spell (" + spellSlots + ") :");

                            counter = 0;
                            if (Arcadium[0] == true || Arcadium[1] == true || Arcadium[2] == true || Arcadium[3] == true)
                            {
                                for (int i = 0; i < Arcadium.Length; i++)
                                {
                                    if (Arcadium[counter] == true)
                                    {
                                        if (counter == 0)
                                        {
                                            Console.Write(" Arcanum: ");
                                        }

                                        if (counter == 0)
                                        {
                                            Console.Write(" (Ready)");
                                        }

                                        if (counter != 0)
                                        {
                                            Console.Write(", (Ready)");
                                        }
                                    }

                                    if (Arcadium[counter] == false && Arcanum[counter] != "")
                                    {
                                        if (counter == 0)
                                        {
                                            Console.Write(" Arcanum: ");
                                        }

                                        if (counter == 0)
                                        {
                                            Console.Write(" (Used)");
                                        }

                                        if (counter != 0)
                                        {
                                            Console.Write(", (Used)");
                                        }
                                    }
                                    counter++;
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    Console.WriteLine("Press |W| to add weapon(s):");
                    Console.WriteLine("Press |Z| to take a rest:");
                    Console.WriteLine("---------------------------------------");

                    //Attack (A)
                    {
                        if (weaponCounter > 0)
                        {
                            if (Exit.Key == ConsoleKey.A)
                            {
                                Attack();
                            }

                        }

                        if (weaponCounter == 0)
                        {
                            if (Exit.Key == ConsoleKey.A)
                            {
                                AttackIdiocy();
                            }
                        }
                    }

                    //Bardic Inspiration
                    {
                        if (Exit.Key == ConsoleKey.B)
                        {
                            if (bardOrNot == true)
                            {
                                if (bardicInspirationLeft > 0)
                                {
                                    bardicInspirationLeft--;
                                    Console.WriteLine("You gave " + bardicInspirationDie + " die");
                                }
                            }
                        }
                    }

                    ///Combat (C)
                    {
                        //Combat start
                        if (combat == false)
                        {
                            if (Exit.Key == ConsoleKey.C)
                            {
                                combat = true;
                            }
                        }

                        //Combat End
                        else if (combat == true)
                        {
                            if (Exit.Key == ConsoleKey.C)
                            {
                                Initiative = 0;
                                combat = false;
                            }
                        }
                    }

                    //Damage (D)
                    if (Exit.Key == ConsoleKey.D)
                    {
                        Console.WriteLine();
                        Console.Write("// ");
                        DamageDone = Convert.ToInt32(Console.ReadLine());
                        Health = Health - DamageDone;

                    }

                    //Exchange spells (E)
                    if (dayToDayCaster == true)
                    {
                        if (Exit.Key == ConsoleKey.E)
                        {
                            AddSpells();
                        }
                    }

                    //Full health (F)
                    if (Exit.Key == ConsoleKey.F)
                    {
                        Console.WriteLine();
                        Health = MaxHealth;

                    }

                    //Grapple (G)
                    if (Exit.Key == ConsoleKey.G)
                    {
                        Console.WriteLine(Str + (StrMods[0] + rng.Next(0, 21)));
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
                    if (SpeelsOrNot == true)
                    {
                        if (Exit.Key == ConsoleKey.S)
                        {
                            SpellUse();
                        }
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
                            ShortRest();
                            makeShiftString = "";
                        }
                    }

                }
            }
        }

        public static void PlayerCommands()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Type theese buttons to do stuff:");
            //Attack (A)
            {
                if (weaponCounter > 0)
                {
                    if (MagicalClass != "Fighter")
                    {
                        Console.WriteLine("Press |A| to Attack:");
                    }

                    if (MagicalClass != "Fighter")
                    {
                        Console.WriteLine("Press |A| to Attack, " + (extraAttack + 1) + " per round:");
                    }
                }
            }
            //Bardic inspiration (B)
            {
                if (bardOrNot == true)
                {
                    Console.WriteLine("Press |B| to give a bardic inspiration (" + bardicInspirationLeft + "):");
                }
            }
            ///Combat (C)
            {
                //Combat End (C)
                if (combat == true)
                {
                    Console.WriteLine("Press |C| to end combat:");
                }
                //Combat Start (C)
                if (combat == false)
                {
                    Console.WriteLine("Press |C| to enter combat and roll initiative:");
                }
            }
            Console.WriteLine("Press |D| to take damage:");
            //Exchange spells (E)
            {
                if (dayToDayCaster == true)
                {
                    Console.WriteLine("Press |E| to exchange spells:");
                }
            }
            Console.WriteLine("Press |F| to gain full health:");
            Console.WriteLine("Press |G| to grapple:");
            Console.WriteLine("Press |H| to Heal:");
            Console.WriteLine("Press |L| to Levelup:");
            Console.WriteLine("Press |M| to Change your modifiers:");
            //Wild shape
            if (druidOrNot == true)
            {
                if (wildShape > 0)
                {
                    if (shapedOrNot == false)
                    {
                        Console.ResetColor();
                        if (Level < 19)
                        {
                            Console.WriteLine("Press |N| to wild shape (" + wildShape + " left); " + maxCr);
                        }

                        if (Level > 19)
                        {
                            Console.WriteLine("Press |N| to wild shape:");
                        }

                        if (Exit.Key == ConsoleKey.N)
                        {
                            shapedOrNot = true;
                            wildShape--;
                        }
                    }

                    if (shapedOrNot == true)
                    {
                        Console.WriteLine("Press |Q| end wild shape:");
                        if (Exit.Key == ConsoleKey.Q)
                        {
                            shapedOrNot = false;
                        }
                    }
                }
            }

            //Rage (P)
            if (barbarianOrNot == true)
            {
                if (rages > 0)
                {
                    if (rage == false)
                    {
                        Console.ResetColor();
                        if (Level < 19)
                        {
                            Console.WriteLine("Press |P| to Rage (" + rages + " left):");
                        }

                        if (Level > 19)
                        {
                            Console.WriteLine("Press |P| to Rage:");
                        }

                        if (Exit.Key == ConsoleKey.P)
                        {
                            rage = true;
                            rages--;
                            rageTimer = 10;
                        }
                    }

                    if (rage == true)
                    {
                        Console.WriteLine("Press |Q| end Rage (+" + rageDamage + "):");
                        if (Exit.Key == ConsoleKey.Q)
                        {
                            rage = false;
                        }
                    }
                }
            }
            Console.WriteLine("Press |R| to roll a die:");
            //Spell (S)
            {
                if (SpeelsOrNot == true && warlockOrNot == false)
                {
                    Console.WriteLine("Press |S| to Cast a Spell:");
                }

                //if warlock spell (S)
                if (spellSlots > 0 && warlockOrNot == true)
                {
                    Console.WriteLine("Press |S| to Cast a Spell (" + spellSlots + ") :");

                    counter = 0;
                    if (Arcadium[0] == true || Arcadium[1] == true || Arcadium[2] == true || Arcadium[3] == true)
                    {
                        for (int i = 0; i < Arcadium.Length; i++)
                        {
                            if (Arcadium[counter] == true)
                            {
                                if (counter == 0)
                                {
                                    Console.Write(" Arcanum: ");
                                }

                                if (counter == 0)
                                {
                                    Console.Write(" (Ready)");
                                }

                                if (counter != 0)
                                {
                                    Console.Write(", (Ready)");
                                }
                            }

                            if (Arcadium[counter] == false && Arcanum[counter] != "")
                            {
                                if (counter == 0)
                                {
                                    Console.Write(" Arcanum: ");
                                }

                                if (counter == 0)
                                {
                                    Console.Write(" (Used)");
                                }

                                if (counter != 0)
                                {
                                    Console.Write(", (Used)");
                                }
                            }
                            counter++;
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("Press |W| to add weapon(s):");
            Console.WriteLine("Press |Z| to take a rest:");
            Console.WriteLine("---------------------------------------");

            //Attack (A)
            {
                if (weaponCounter > 0)
                {
                    if (Exit.Key == ConsoleKey.A)
                    {
                        Attack();
                    }

                }

                if (weaponCounter == 0)
                {
                    if (Exit.Key == ConsoleKey.A)
                    {
                        AttackIdiocy();
                    }
                }
            }

            //Bardic Inspiration
            {
                if (Exit.Key == ConsoleKey.B)
                {
                    if (bardOrNot == true)
                    {
                        if (bardicInspirationLeft > 0)
                        {
                            bardicInspirationLeft--;
                            Console.WriteLine("You gave " + bardicInspirationDie + " die");
                        }
                    }
                }
            }

            ///Combat (C)
            {
                //Combat start
                if (combat == false)
                {
                    if (Exit.Key == ConsoleKey.C)
                    {
                        combat = true;
                    }
                }

                //Combat End
                else if (combat == true)
                {
                    if (Exit.Key == ConsoleKey.C)
                    {
                        Initiative = 0;
                        combat = false;
                    }
                }
            }

            //Damage (D)
            if (Exit.Key == ConsoleKey.D)
            {
                Console.WriteLine();
                Console.Write("// ");
                DamageDone = Convert.ToInt32(Console.ReadLine());
                Health = Health - DamageDone;

            }

            //Exchange spells (E)
            if (dayToDayCaster == true)
            {
                if (Exit.Key == ConsoleKey.E)
                {
                    AddSpells();
                }
            }

            //Full health (F)
            if (Exit.Key == ConsoleKey.F)
            {
                Console.WriteLine();
                Health = MaxHealth;

            }

            //Grapple (G)
            if (Exit.Key == ConsoleKey.G)
            {
                Console.WriteLine(Str + (StrMods[0] + rng.Next(0, 21)));
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
            if (SpeelsOrNot == true)
            {
                if (Exit.Key == ConsoleKey.S)
                {
                    SpellUse();
                }
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
                    ShortRest();
                    makeShiftString = "";
                }
            }

        }

        public static void Main(string[] args)
        {
            Welcome();

            //Game master
            {
                if (GAMEMASTER == true)
                {
                    do
                    {
                        Exit = Console.ReadKey(true);
                        GMCommands();
                        //EXIT
                        if (Exit.Key == ConsoleKey.Escape)
                        {
                            outOfTheApp = true;
                        }

                    } while (outOfTheApp == false);
                }
            }

            //Player
            {
                if (player == true)
                {
                    Essentials();
                    PlayerPrint();
                    do
                    {
                        Exit = Console.ReadKey(true);

                        if (DeadOrNot == true)
                        {
                            DeathScreen();
                        }

                        if (DeadOrNot == false)
                        {
                            PlayerPrint();
                        }

                        Console.ResetColor();

                        //EXIT
                        if (Exit.Key == ConsoleKey.Escape)
                        {
                            outOfTheApp = true;
                        }

                    } while (outOfTheApp == false);
                }
            }
        }
    }
}



