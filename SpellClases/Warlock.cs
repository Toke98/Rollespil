using System;
using System.Collections.Generic;
using System.Text;

namespace Rollespil.SpellClases
{
    public class Warlock
    {
        public static double HitDie = 8; 

        public static int[] Cantrips = { 1, 2, 4, 7, 9, 10, 14, 15, 19, 21, 22, 33, 34 };
        //1
        public static int[] Level1Spells = { 3, 4, 8, 10, 13, 15, 22, 27, 28, 38, 42, 48, 56, 62, 63 };
        //2
        public static int[] Level2Spells = { 8, 11, 12, 15, 16, 18, 20, 23, 31, 32, 42, 43, 47, 53, 55, 59, 62 };
        //3
        public static int[] Level3Spells = { 5, 7, 10, 14, 17, 19, 21, 22, 25, 26, 30, 31, 37, 39, 41, 47, 49, 50 };
        //4
        public static int[] Level4Spells = { 3, 4, 11, 13, 14, 15, 17, 21, 23, 37 };
        //5
        public static int[] Level5Spells = { 12, 18, 19, 20, 23, 24, 37, 40 };
        //6
        public static int[] Level6Spells = { 0, 4, 5, 7, 10, 12, 18, 19, 20, 21, 23, 32 };
        //7
        public static int[] Level7Spells = { 3, 4, 6, 10 };
        //8
        public static int[] Level8Spells = { 6, 7, 9, 10, 15 };
        //9
        public static int[] Level9Spells = { 0, 1, 3, 6, 11 };

        public static string[] Invocations = { "Agonizing Blast: Prerequisite - Eldritch Blast Cantrip, ", "Armor of Shadows, ", "Ascendant Step: Prerequisite - 9'th Level, ", "Beast Speech, ", "Beguiling Influence, ", "Bewitching Whispers: Prerequisite - 7'th Level, ", "Book of Ancient Secrets: Prerequisite - Pact of the Tome feature, ", "Chains of Carceri: Prerequisite - 15'th Level and Pact of the Chain feature, ", "Devil's Sight, ", "Dreadful Word: Prerequisite - 7'th Level, ", "Eldritch Sight, ", "Eyes of the Rune Keeper, ", "Fiendish Vigor, ", "Gaze of two Minds, ", "Lifedrinker: Prerequisite - 12th level and Pact of the Blade feature, ", "Mask of many Faces, ", "Master of Myriad Forms, ", "Minions of Chaos: Prerequisite - 9'th Level, ", "Mire the Mind: Prerequisite - 5'th Level, ", "Otherwolrdly Leap: Prerequisite - 9'th Level, ", "Repelling Blast: Prerequisite Eldritch Blast, ", "Sculptor of Flesh: Prerequisite7'th Level, ", "Sign of Ill Omen: Prerequisite 5'th Level, ", "Theif of Five Fates, ", "Thirsting Blade:Prerequisite - 5'th level and Pact of the Blade feature, ", "Visions of Distant Ralms: Prerequisites - 15'th Level, ", "Voice of the Chainmaster: Prerequisite - Pact of the Chain Feature, ", "Whispers of the Grave: Prerequisite - 9'th Level, ", "Witch Sight: Prerequisite 15'th Level" };

        //Skils you can lern you know, cuz' warlock
        public static int[] SkillsFromWarlock = { 2, 4, 6, 7, 13, 14 };

    }
}
