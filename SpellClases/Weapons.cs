using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Rollespil.SpellClases
{
    class Weapons
    {
        //Weapon
        public static string[] allWeapons = { "Antimatter rifle", "Bad news", "Battle axe", "Blowgun", "Blunderbuss", "Boomerang", "Club", "Crossbow,Hand", "Crossbow, Heavy", "Crossbow, Light", "Dagger", "Dart", "Double-Bladed scimitar", "Flail", "Glaive", "Greataxe",
            "Greatclub","Greatsword", "Halberd", "Hand mortar", "Hand axe", "Javelin", "Lance", "Laser pistol", "Laser rifle", "Light hammer", "Longbow", "Longsword", "Mace", "Maul", "Morningstar", "Musket", "Musket (Exandria)", "Net", "Palm pistol", "Pepperbox",
            "Pike", "Pistol", "Pistol (Exandria)","Pistol, Automatic", "Quarterstaff", "Rapier", "Revolver", "Rifle, Automatic", "Rifle, Hunting", "Scimitar", "Shortbow", "Shortsword", "Shotgun", "Sickle", "Sling", "Spear", "Trident", "War pick", "War hammer", "Whip", "Yklwa" };
        ///Damage
        
        //Damage dice
        public static int[] numberOfDice = { 6, 2, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 2, 1, 2, 1, 1, 1, 3, 3, 1, 1, 1, 1, 2, 1, 1, 1, 0, 1, 1, 1, 1, 1, 2, 1, 1, 2, 2, 2, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1 };
        public static int[] damageDie = { 8, 12, 8, 1, 8, 4, 4, 6, 10, 8, 4, 4, 4, 8, 10, 12, 8, 6, 10, 8, 6, 6, 12, 6, 8, 4, 8, 8, 6, 6, 8, 12, 12, 0, 8, 10, 10, 10, 10, 6, 6, 8, 8, 8, 10, 6, 6, 6, 8, 4, 4, 6, 6, 8, 8, 4, 8 };
        
        //Damage type
        public static int[] bludgeoning = { 5, 6, 13, 16, 25, 28, 29, 33, 40, 50, 54 };
        public static int[] fire = { 19 };
        public static int[] necrotic = { 0 };
        public static int[] piercing = { 1, 3, 4, 7, 8, 9, 10, 11, 12, 21, 22, 26, 30, 31, 32, 34, 35, 36, 37, 38, 39, 41, 42, 43, 44, 46, 47, 48, 51, 52, 53, 56 };
        public static int[] radiant = { 23, 24 };
        public static int[] slashing = { 2, 14, 15, 17, 18, 20, 27, 45, 49, 55 };


        //Properties
        public static int[] ammunition = { 0, 1, 3, 4, 7, 8, 9, 19, 23, 24, 26, 31, 32, 34, 35, 37, 38, 39, 42, 43, 44, 46, 48, 50 };
        public static int[] burstFire = { 43 };
        public static int[] explosive = { 19 };
        public static int[] finesse = { 10, 11, 41, 45, 47, 55 };
        public static int[] heavy = { 8, 14, 15, 17, 18, 26, 29, 36 };
        public static int[] light = { 6, 7, 10, 20, 25, 34, 45, 47, 49 };
        public static int[] loading = { 3, 7, 8, 9, 31, 37, 43 };
        public static int[] misfire = { 1, 4, 19, 32, 34, 35, 38 };
        public static int[] reach = { 14, 18, 22, 36, 55 };
        public static int[] reload = { 0, 1, 4, 19, 23, 24, 32, 34, 35, 38, 39, 42, 43, 44, 48 };
        public static int[] special = { 12, 22, 33 };
        public static int[] thrown = { 10, 11, 20, 21, 25, 33, 51, 52, 56 };
        public static int[] twoHanded = { 0, 1, 8, 9, 14, 15, 16, 17, 18, 24, 26, 29, 31, 32, 36, 43, 44, 46, 48 };
        public static int[] versatile = { 2, 27, 40, 51, 52, 54 };


        //Range
        public static int[] ranged = { 0, 1, 3, 4, 7, 8, 9, 11, 19, 23, 24, 26, 31, 32, 33, 34, 35, 37, 38, 39, 42, 43, 44, 46, 48, 50 };
        public static int[] melee = { 2, 6, 10, 12, 13, 14, 15, 16, 17, 18, 20, 21, 22, 25, 27, 28, 29, 30, 36, 40, 41, 45, 47, 49, 51, 52, 53, 54, 55, 56 };

        //Complexity
        public static int[] simple =   { 5, 6, 9, 10, 11, 16, 20, 21, 25, 28, 40, 46, 49, 50, 51, 56 };
        public static int[] martial =  { 2, 3, 7, 8, 12, 13, 14, 15, 17, 18, 22, 26, 27, 29, 30, 33, 36, 41, 45, 47, 52, 53, 54, 55 };
        public static int[] firearms = { 0, 1, 4, 19, 23, 24, 31, 32, 34, 35, 37, 38, 39, 42, 43, 44, 48 };




    }
}
