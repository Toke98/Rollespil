using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Rollespil
{
    public class SpellList
    {
        //Skills
        public static string[] Skills = { "Acrobatics: ", "Animal Handling: ", "Arcana: ", "Athletics: ", "Deception: ", "History: ", "Insight: ", "Intimidation: ", "Investigation: ", "Medicine: ", "Nature: ", "Perception: ", "Perfermance: ", "Persuasion: ", "Religion: ", "Sleight of hand: ", "Stealth: ", "Survival: " };


        //35
        public static string[] Cantrips = { "Acid Splash", "Blade Ward", "Chill Touch", "Control Flames", "Create Bonfire", "Dancing Lights", "Druidcraft", "Eldrith Blast", "Fire Bolt", "Friends", "Frostbite", "Guidance", "Gust", "Light", "Mage Hand", "Magic Stone", "Mending", "Message", "Minor Illusion", "Mold Earth", "Poison Spray", "Prestidigitation", "Produce Flame", "Ray of Frost", "Resistance", "Sacred Flame", "Shape Water", "Shillelagh", "Shocking Grasp", "Spare the Dying", "Thaumaturgy", "Thorn Whip", "Thunderclap", "True Strike", "Vicious Mockery" };
        
        //66
        public static string[] Level1Spells = { "Absorb Elements", "Alarm", "Animal Friendship", "Armor of Agathys","Arms of Hadar", "Bane", "Beast Bond", "Bless", "Burning Hands", "Catapult", "Charm Person", "Chromatic Orb", "Color Spray", "Command", "Compelled Duel", "Comprehend Languages", "Create or Destroy Water", "Cure Wounds", "Detect Evil And Good", "Detect Magic", "Detect Poison and Disease", "Disguise Self", "Dissonant Whispers", "Divine Favor", "Earth Tremor", "Ensnaring Strike", "Entangle", "Expeditious Retreat", "Faerie Fire", "False Life", "Feather Fall", "Find Familiar", "Fog Cloud", "Goodberry", "Grease", "Guiding Bolt", "Hail of Thorns", "Healing Word", "Hellish Rebuke", "Heroism", "Hex", "Hunter's Mark", "Ice Knife", "Identify", "Illusory Script", "Inflict Wounds", "Jump", "Longstrider", "Mage Amor", "Magic Missile", "Protection from Evil and Good", "Purify Food and Drink", "Ray of Sickness", "Sanctuary", "Searing Smite", "Shield", "Shield of Faith", "Silent Image", "Sleep", "Speak with Animals", "Tasha's Hideous Laughter", "Tenser's Floating Disk", "Thunderous Smite", "Thunderwave", "Unseen Servant", "Witch Bolt", "Wrathful Smite" };
        
        //67
        public static string[] Level2Spells = { "Aganazzar's Scorcher", "Aid", "Alter Self", "Animal Messenger", "Arcane Lock", "Augury", "Barkskin", "Beast Sence", "Blindness/Deafness", "Blur", "Branding Smite", "Calm Emotions", "Cloud of Daggers", "Continual Flame", "Cordan of Arrows", "Crown of Madness", "Darkness", "Darkvision", "Detect Thoughts", "Dust Devil", "Earthbind", "Enhance Ability", "Enlarge/Reduce", "Entrhall", "Find Steed", "Find Traps", "Flame Blade", "Flaming Sphere", "Gentle Repose", "Gust of Wind", "Heat Metal", "Hold Person", "Invisibility", "Knock", "Lesser Restoration", "Levitate", "Locate Animals or Plants", "Locate Object", "Magic Mouth", "Magic Weapon", "Maximilian's Earthen Grasp", "Melf's Acid Arrow", "Mirror Image", "Misty Step", "Moonbeam", "Nystul's Magic Aura", "Pass Without Trace", "Phantasmal Force", "Prayer of Healing", "Protection from Poison", "Pyrotechnics", "Ray of Enfeeblement", "Rope Trick", "Scorching Ray", "See Invisibility", "Shatter", "Silence", "Skywrite", "Snilloc's Snowball Swarm", "Spider Climb", "Spike Growth", "Spiritual Weapon", "Suggestion", "Warding Bond", "Warding Wind", "Web", "Zone of Truth" };
        
        //56
        public static string[] Level3Spells = { "Animate Dead", "Aura of Vitality", "Beacon of Hope", "Bestow Curse", "Blinding Smite", "Blink", "Call Lightning", "Clairvoyance", "Conjure Animals", "Conjure Barrage", "Counterspell", "Create Food and Water", "Crusader's Mantle", "Daylight", "Dispel Magic", "Elemental Weapon", "Erupting Eath", "Fear", "Feign Death", "Fireball", "Flame Arrows", "Fly", "Gaseous Form", "Glyph of Warding", "Haste", "Hunger of Hadar", "Hypnotic Pattern", "Leomund's Tiny Hut", "Lightning Arrow", "Lightning Bolt", "Magic Circle", "Major Image", "Mass Healing Word", "Meld Into Stone", "Melf's Minute Meteors", "Nondetection", "Phantom Steed", "Plant Growth", "Protection from Energy", "Remove Curse", "Revivify", "Sending", "Sleet Storm", "Slow", "Speak with Dead", "Speak with Plants", "Spirit Guardians", "Stinking Cloud", "Tidal Wave", "Tongues", "Vampiric Touch", "Wall of Sand", "Wall of Water", "Water Breathing", "Water Walk", "Wind Wall" };
       
        //39
        public static string[] Level4Spells = { "Arcane Eye", "Aura of Life", "Aura of Purity", "Banishment", "Blight", "Compulsion", "Confusion", "Conjure Minor Elementals", "Conjure Woodland Beings", "Control Water", "Death Ward", "Dimension Door", "Divination", "Dominate Beast", "Elemental Bane", "Evard's Black Tentacales", "Fabricate", "Fire Shield", "Freedom of Movement", "Giant Insect", "Grasping Vine", "Greater Invisibility", "Guardian of Faith", "Hallucinatory Terrain", "Ice Storm", "Leomund's Secret Chest", "Locate Creature", "Mordenkainen's Faithful Hound", "Mordenkainen's Private Sanctum", "Otiluke's Resilient Sphere", "Phantasmal Killer", "Polymorph", "Staggering Smite", "Stone Shape", "Stoneskin", "Strom Sphere", "Vitriolic Sphere", "Wall of Fire", "Watery Sphere" };
       
        //46
        public static string[] Level5Spells = { "Animate Object", "Antilife Shell", "Awaken", "Banishing Smite", "Bigby's Hand", "Circle of Power", "Cloudkill", "Commune", "Commune with Nature", "Cone of Cold", "Conjure Elemental", "Conjure Volley", "Contact Other Plane", "Contagion", "Control Winds", "Creation", "Destructive Wave", "Dispel Evil amd Good", "Dominate Person", "Dream", "Flame Strike", "Geas", "Greater Restoration", "Hallow", "Hold Monster", "Immolation", "Insect Plague", "Legend Lore", "Maelstrom", "Mass Curse Wounds", "Mislead", "Modify Memory", "Passwall", "Planar Binding", "Raise Dead", "Rary's Telepathic Bond", "Reincarnate", "Scrying", "Seeming", "Swift Quiver", "Telekinesis", "Teleportation Circle", "Transmute Rock", "Tree Stride", "Wall of Force", "Wall of Stone" };
       
        //37
        public static string[] Level6Spells = { "Arcane Gate", "Blade Barrier", "Bones of the Earth", "Chain Lightning", "Circle of Death", "Conjure Fey", "Contingency", "Create Undead", "Disintegrate", "Drawmij's Instant Summon", "Eyebite", "Find Path", "Flesh to Stone", "Forbiddance", "Globe of Invulnerability", "Harm", "Heal", "Heroes' Feast", "Investiture of Flame", "Investiture of Ice", "Investiture of Stone", "Investiture of Wind", "Magic Jar", "Mass Suggestion", "Move Earth", "Otiluke's Freezing Sphere", "Otto's Irresistible Dance", "Planar Ally", "Primordial Ward", "Programmed Illusion", "Sunbeam", "Transport via Plants", "True Seeing", "Wall of Ice", "Wall of Thorns", "Wind Walk", "Word of Recall" };
        
        //21
        public static string[] Level7Spells = { "Conjure Celestial", "Delayed Blast Fireball", "Divine Word", "Etherealness", "Finger of Death", "Fire Storm", "Forcecage", "Mirage Arcane", "Mordenkainen's MagnificentMansion", "Mordenkainen's Sword", "Plane Shift", "Prismatic Spray", "Project Image", "Regenerate", "Resurrection", "Reverse Gravity", "Sequester", "Simulacrum", "Symbol", "Teleport", "Whirlwind" };
       
        //19
        public static string[] Level8Spells = { "Abi-Dalzim's Horrid Wilting", "Animal Shapes", "Antimagic Field", "Antipathy/Sympathy", "Clone", "Control Weather", "Demiplane", "Dominate Monster", "Earthquake", "Feeblemind", "Glibness", "Holy Aura", "Incendiary Cloud", "Maze", "Mind Blank", "Power Word Stund", "Sunburst", "Telepathy", "Tsunami" };
      
        //15
        public static string[] Level9Spells = { "Astral Projection", "Foresight", "Gate", "Imprisonment", "Mass Heal", "Power Word Heal", "Power Word Kill", "Prismatic Wall", "Shapechange", "Storm of Vengeance", "Time Stop", "True Polymorph", "True Resurrection", "Weird", "Wish" };
    
        //Add Classes
        //to the spells
        //fx: Warlock [0,3,9,10,...]
    
    }
}
