﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETGItemCards
{
    /// <summary>
    /// Data for the items used in this mod
    /// </summary>
    public class ItemData
    {
        /// <summary>
        /// The id of the item
        /// </summary>
        public readonly int id;

        /// <summary>
        /// The text of the item
        /// </summary>
        public readonly string title;

        public readonly string flavour;

        public readonly string text;

        public readonly Dictionary<string, string> stats;

        public readonly string tag;

        public readonly string quality;

        public readonly string qColor;


        /// <summary>
        /// Create a new item data with the data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="flavour"></param>
        /// <param name="text"></param>
        /// <param name="stats"></param>
        /// <param name="tags"></param>
        public ItemData(int id, string title, string flavour, string text, Dictionary<string, string> stats, string tag)
        {
            this.id = id;
            this.title = title;
            this.flavour = flavour;
            this.text = text;
            this.stats = stats;
            this.tag = tag;
            quality = "n/a";
            if(stats.ContainsKey("Quality"))
            {
                quality = stats["Quality"];
            }
            switch(quality)
            {
                case "D":
                default:
                    qColor = "white";
                    break;
                case "C":
                    qColor = "blue";
                    break;
                case "B":
                    qColor = "green";
                    break;
                case "A":
                    qColor = "Red";
                    break;
                case "S":
                    qColor = "orange";
                    break;
            }
        }

        

        public override string ToString()
        {
            return ETGSettings.CurrentFormat.Format(this);
        }

        private static string GetDictionaryStats(Dictionary<string, string> dic)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var pair in dic)
            {
                sb.AppendLine(pair.Key + ": " + pair.Value);
            }
            return sb.ToString();
        }

        public string GetStats()
        {
            return GetDictionaryStats(stats);
        }

        /// <summary>
        /// This dictionary contains most known items in the game.
        /// It has been scraped from GungeonGod.com
        /// </summary>
        public static Dictionary<int, ItemData> Items = new Dictionary<int, ItemData>(){
{99, new ItemData(
        99,
        @"Rusty Sidearm",
        @"""Still Works. Mostly.""",
        @"The Hunter's starting gun
Cannot reveal secret room doors",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"Infinite"},
{@"Clip size", @"6"},
{@"Quality", @"n/a "},
{@"Damage", @"6"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"16"},
{@"Range", @"16"},
{@"Knockback", @"10"},
{@"Spread", @"7°"},
},
        @"")},

{86, new ItemData(
        86,
        @"Marine Sidearm",
        @"""Always With You""",
        @"The Marine's starting gun
Cannot reveal secret room doors",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"Infinite"},
{@"Clip size", @"10"},
{@"Quality", @"n/a"},
{@"Damage", @"5"},
{@"Fire rate", @"0.25"},
{@"Shot speed", @"25"},
{@"Range", @"18"},
{@"Knockback", @"12"},
{@"Spread", @"5°"},
},
        @"")},

{89, new ItemData(
        89,
        @"Rogue Special",
        @"""Underhanded And Efficient""",
        @"The Pilot's starting gun.
Cannot reveal secret room doors
Has a short range and fires with low accuracy",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"Infinite"},
{@"Clip size", @"8"},
{@"Quality", @"n/a "},
{@"Damage", @"5"},
{@"Fire rate", @"0.25"},
{@"Shot speed", @"22"},
{@"Range", @"13"},
{@"Knockback", @"6"},
{@"Spread", @"10°"},
},
        @"")},

{80, new ItemData(
        80,
        @"Budget Revolver",
        @"""Affordable Arms""",
        @"The Convict's starting gun.
Cannot reveal secret room doors",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"Infinite"},
{@"Clip size", @"5"},
{@"Quality", @"n/a "},
{@"Damage", @"6"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"23"},
{@"Range", @"18"},
{@"Knockback", @"10"},
{@"Spread", @"10°"},
},
        @"")},

{24, new ItemData(
        24,
        @"Dart Gun",
        @"""Sticky""",
        @"The Cultist's starting gun (Co-op only character) which fires sticky darts
Cannot reveal secret room doors",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"Infinite"},
{@"Clip size", @"6"},
{@"Quality", @"n/a "},
{@"Damage", @"6"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"20"},
{@"Range", @"25"},
{@"Knockback", @"2"},
{@"Spread", @"5°"},
},
        @"")},

{88, new ItemData(
        88,
        @"Robot's Right Hand",
        @"""Built To Kill""",
        @"The Robot's starting weapon (Secret unlockable character)
Cannot reveal secret room doors",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"Infinite"},
{@"Clip size", @"20"},
{@"Quality", @"n/a "},
{@"Damage", @"5"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"25"},
{@"Range", @"20"},
{@"Knockback", @"10"},
{@"Spread", @"7°"},
},
        @"")},

{417, new ItemData(
        417,
        @"Blasphemy",
        @"""To The Point""",
        @"A sword that can be used to damage enemies and destroy projectiles (e.g. bullets)
When you are a full health, Blasphemy fires a piercing sword projectile (A reference to The Legend of Zelda)
The Bullet's starting weapon
As of the Supply Drop Update, this weapon's sword swing cannot reveal secret rooms (Still works on Nintendo Switch)
When used as The Robot, this weapon will not fire projectiles as the character has no red health.
UNLOCK: Unlock this weapon by killing High Dragun as The Bullet character",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by killing High Dragun as The Bullet character"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"Infinite"},
{@"Clip size", @"n/a"},
{@"Quality", @"B"},
{@"Damage", @"14"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"26"},
{@"Range", @"Infinite"},
{@"Knockback", @"10"},
{@"Spread", @"10°"},
},
        @"")},

{197, new ItemData(
        197,
        @"Pea Shooter",
        @"""Baby's First Gun""",
        @"A gun which shoots incredibly low damage peas
UNLOCK: Unlock this weapon by completing the tutorial",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing the tutorial"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"1000"},
{@"Clip size", @"6"},
{@"Quality", @"D"},
{@"Damage", @"4"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"20"},
{@"Range", @"20"},
{@"Knockback", @"3"},
{@"Spread", @"10°"},
},
        @"")},

{56, new ItemData(
        56,
        @"38 Special",
        @"""For The Inquisitive""",
        @"A standard semi-automatic gun which fires bullets.",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @"6"},
{@"Quality", @"D"},
{@"Damage", @"5"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"23"},
{@"Range", @"35"},
{@"Knockback", @"10"},
{@"Spread", @"5°"},
},
        @"")},

{378, new ItemData(
        378,
        @"Derringer",
        @"""One Last Trick""",
        @"A small standard semi-automatic pistol based on the real life gun of the same name",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"2"},
{@"Quality", @"D"},
{@"Damage", @"10"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"6°"},
},
        @"")},

{83, new ItemData(
        83,
        @"Unfinished Gun",
        @"""Still Warm""",
        @"Shoots piercing bullets, which will travel through enemies",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @"15"},
{@"Quality", @"D"},
{@"Damage", @"6"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"15"},
{@"Range", @"35"},
{@"Knockback", @"6"},
{@"Spread", @"15°"},
},
        @"")},

{79, new ItemData(
        79,
        @"Makarov",
        @"""The People's Gun""",
        @"A basic pistol, which is stronger than some starting weapons",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @"7"},
{@"Quality", @"D"},
{@"Damage", @"5"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"10"},
{@"Spread", @"4°"},
},
        @"")},

{30, new ItemData(
        30,
        @"M1911",
        @"""Classic""",
        @"Standard pistol that is stronger than most starting weapons.
A reference to the real Colt M1991 pistol",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"7"},
{@"Quality", @"C"},
{@"Damage", @"8"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"6°"},
},
        @"")},

{38, new ItemData(
        38,
        @"Magnum",
        @"""5 Shots Or 6?""",
        @"A powerful pistol, based off the real gun of the same name
Upon reloading, the Magnum will randomly switch between having a clip size of either 5 or 6",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"140"},
{@"Clip size", @"6"},
{@"Quality", @"B"},
{@"Damage", @"13"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"7°"},
},
        @"")},

{62, new ItemData(
        62,
        @"Colt 1851",
        @"""You Dig""",
        @"Fires two shots at the same time in a burst",
        new Dictionary<string, string>(){
{@"Type", @"Burst"},
{@"Max ammo", @"350"},
{@"Clip size", @"12"},
{@"Quality", @"C"},
{@"Damage", @"6"},
{@"Fire rate", @"0.21"},
{@"Shot speed", @"25"},
{@"Range", @"∞"},
{@"Knockback", @"10"},
{@"Spread", @"None"},
},
        @"")},

{50, new ItemData(
        50,
        @"SAA",
        @"""Exhilarating Reload Time""",
        @"A gun which fires bouncing bullets
Has a faster reloading speed",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"6"},
{@"Quality", @"B"},
{@"Damage", @"8 (direct) 12 (bounce)"},
{@"Fire rate", @"0.12"},
{@"Shot speed", @"25"},
{@"Range", @"1000"},
{@"Knockback", @"14"},
{@"Spread", @"0°"},
},
        @"")},

{223, new ItemData(
        223,
        @"Cold 45",
        @"""Shatterday Night Special""",
        @"Bullets fired by Cold 45 have a chance to freeze enemies
UNLOCK: Unlock this weapon by creating 10 guns using the Gun Muncher",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by creating 10 guns using the Gun Muncher"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @"12"},
{@"Quality", @"B"},
{@"Damage", @"6"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"28"},
{@"Range", @"35"},
{@"Knockback", @"10"},
{@"Spread", @"6°"},
},
        @"")},

{97, new ItemData(
        97,
        @"Polaris",
        @"""Storied""",
        @"A gun that can evolve into 3 different stages.
Killing enemies causes Polaris to level up, increasing it's damage.
Taking damage will cause it to level down by 1
UNLOCK: Unlock this weapon by completing the Hollow (Chamber #4) 20 times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing the Hollow (Chamber #4) 20 times"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"400"},
{@"Clip size", @"12"},
{@"Quality", @"B"},
{@"Damage", @"5 (level 1), 12 (level 2), 20 (level 3)"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"40"},
{@"Range", @"1000"},
{@"Knockback", @"30"},
{@"Spread", @"5°"},
},
        @"")},

{47, new ItemData(
        47,
        @"Jolter",
        @""".95 Caliber""",
        @"Fires large rectangular bullets which do a good amount of damage
This is a reference to a Warhammer 40k weapon",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"12"},
{@"Quality", @"B"},
{@"Damage", @"13"},
{@"Fire rate", @"0.25"},
{@"Shot speed", @"25"},
{@"Range", @"25"},
{@"Knockback", @"50"},
{@"Spread", @"10°"},
},
        @"")},

{23, new ItemData(
        23,
        @"Dungeon Eagle",
        @"""Caw!""",
        @"A strong pistol which can be charged up to release a powerful high-damaging shot
This is a reference to the real gun, the Desert Eagle",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"200"},
{@"Clip size", @"9"},
{@"Quality", @"C"},
{@"Damage", @"20 charged, 10 uncharged"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"25"},
{@"Range", @"60"},
{@"Knockback", @"10"},
{@"Spread", @"10°"},
},
        @"")},

{182, new ItemData(
        182,
        @"Grey Mauser",
        @"""Silent and Deadly""",
        @"A gun which makes you invisible every time you reload an empty clip
Doing anything other than walking or stealing items from the shop will remove the invisibility effect
UNLOCK: Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill the Dragun boss 5 times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill the Dragun boss 5 times"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"100"},
{@"Clip size", @"15"},
{@"Quality", @"B"},
{@"Damage", @"8"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{464, new ItemData(
        464,
        @"Shellegun",
        @"""Circle Of Death""",
        @"Reloading this gun will switch between two modes of firing either a pistol or a continous beam
Curse Up while held
UNLOCK: Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 30 Shelletons",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 30 Shelletons"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"300"},
{@"Clip size", @"20 (beam), 12 (pistol)"},
{@"Quality", @"B"},
{@"Damage", @"8"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"25"},
{@"Range", @"30"},
{@"Knockback", @"22"},
{@"Spread", @"5°"},
},
        @"")},

{9, new ItemData(
        9,
        @"Dueling Pistol",
        @"""Ricochet""",
        @"Fires large bullets that bounce twice
A single shot pistol which shoots bullets that can bounce off objects up to a maximum of two times",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"120"},
{@"Clip size", @"1"},
{@"Quality", @"D"},
{@"Damage", @"10"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"30"},
{@"Range", @"1000"},
{@"Knockback", @"15"},
{@"Spread", @"8°"},
},
        @"")},

{53, new ItemData(
        53,
        @"AU Gun",
        @"""Some Assembly Required""",
        @"Fires a single powerful bullet, which will kill a lot of enemies in a single hit",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"22"},
{@"Clip size", @"1"},
{@"Quality", @"S"},
{@"Damage", @"100"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"25"},
{@"Range", @"1000"},
{@"Knockback", @"10"},
{@"Spread", @"0°"},
},
        @"")},

{157, new ItemData(
        157,
        @"Big Iron",
        @"""Heavy""",
        @"Fires three bullets at a time, which spread out in a random fashion",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"150"},
{@"Clip size", @"6"},
{@"Quality", @"B"},
{@"Damage", @"7 x 3 bullets (21 total)"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"16"},
{@"Range", @"16"},
{@"Knockback", @"10"},
{@"Spread", @"4°"},
},
        @"")},

{337, new ItemData(
        337,
        @"Composite Gun",
        @"""Undetectable""",
        @"This gun fires a charged shot which consumes two ammo and will pierce through enemies",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"50"},
{@"Clip size", @"2"},
{@"Quality", @"S"},
{@"Damage", @"40 (uncharged), 100 (charged)"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"25"},
{@"Range", @"1000"},
{@"Knockback", @"10"},
{@"Spread", @"0°"},
},
        @"")},

{275, new ItemData(
        275,
        @"Flare Gun",
        @"""Over Here""",
        @"Fires a bullet that has a chance to set enemies on fire
Ingited enemies take damage over time for a short period",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"150"},
{@"Clip size", @"1"},
{@"Quality", @"D"},
{@"Damage", @"13"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"35"},
{@"Spread", @"6°"},
},
        @"")},

{35, new ItemData(
        35,
        @"Smiley's Revolver",
        @"""All Smiles""",
        @"A semi-automatic gun which gains a fire rate increase for a while after dodge rolling
Decreases shop prices while held",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"B"},
{@"Damage", @"9"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"6°"},
},
        @"")},

{22, new ItemData(
        22,
        @"Shades's Revolver",
        @"""Someone Loses An Eye""",
        @"While held, this gun will increase the player's coolness stat by +3, which reduces the cooldown of active items and increase the chance of getting a pickup or chest drop after clearing a room",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"150"},
{@"Clip size", @"6"},
{@"Quality", @"C"},
{@"Damage", @"15"},
{@"Fire rate", @"0.3"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"6°"},
},
        @"")},

{51, new ItemData(
        51,
        @"Regular Shotgun",
        @"""Cocked and Loaded""",
        @"A standard shotgun, which releases a spread of bullets each time it is fired",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"150"},
{@"Clip size", @"8"},
{@"Quality", @"D"},
{@"Damage", @"4 x 6 (24 total)"},
{@"Fire rate", @"0.6"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"10°"},
},
        @"")},

{93, new ItemData(
        93,
        @"Old Goldie",
        @"""For The Discerning""",
        @"A double-barrel shotgun more powerful than the regular shotgun, which fires a random spread of bullets
+1 Coolness up (decreases active item cooldowns, luck up)",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"70"},
{@"Clip size", @"4"},
{@"Quality", @"A"},
{@"Damage", @"3.5 x 10 (35 total)"},
{@"Fire rate", @"0.5"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"5°"},
},
        @"")},

{202, new ItemData(
        202,
        @"Sawed-Off",
        @"""No Butts About It""",
        @"A shotgun with a low bullet range and wider spread of bullets
One of the Convict's starting weapons",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"150"},
{@"Clip size", @"6"},
{@"Quality", @"D"},
{@"Damage", @"4 x 4 (16 total)"},
{@"Fire rate", @"0.5"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"8°"},
},
        @"")},

{1, new ItemData(
        1,
        @"Winchester",
        @"""Better Than A Box Of Roses""",
        @"A modified shotgun which has the same damage as the regular shotgun, but has a more accurate spread",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"100"},
{@"Clip size", @"8"},
{@"Quality", @"C"},
{@"Damage", @"4 x 6 (24 total)"},
{@"Fire rate", @"0.6"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"7°"},
},
        @"")},

{406, new ItemData(
        406,
        @"Rattler",
        @"""Snakes On A Gun""",
        @"Simultaneously fires a shotgun blast and a beam that has a chance to poison enemies
UNLOCK: Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 30 Lead Maidens",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 30 Lead Maidens"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"8"},
{@"Quality", @"B"},
{@"Damage", @"3 x 7 (21 total)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{82, new ItemData(
        82,
        @"Elephant Gun",
        @"""Shoots Elephants""",
        @"Fires a cone spread of bullets and has strong knockback dealt to any enemies hit by the bullets
UNLOCK: Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 50 Blobulons",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 50 Blobulons"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"120"},
{@"Clip size", @"2"},
{@"Quality", @"C"},
{@"Damage", @"5.5 x 6 (33 total)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{175, new ItemData(
        175,
        @"Tangler",
        @"""Get Wrecktangled""",
        @"Fires a shotgun blast of rectangular bullets that bounce off walls. Enemies hit will be folded into a rectangle
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 10 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 10 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"C"},
{@"Damage", @"6 x 6 (36 total)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{55, new ItemData(
        55,
        @"Void Shotgun",
        @"""CQC""",
        @"A shotgun with low range that fires a cluster of purple bullets",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"120"},
{@"Clip size", @"4"},
{@"Quality", @"B"},
{@"Damage", @"5 x 6 (30 total)"},
{@"Fire rate", @"0.4"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"0°"},
},
        @"")},

{365, new ItemData(
        365,
        @"Mass Shotgun",
        @"""My Favorite Gun""",
        @"The Mass Shotgun fires a single large bullet that splits into a series of smaller bullets, which all continue in a straight line
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 9 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 9 Hegemony Credits"},
{@"Type", @"Automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"1"},
{@"Quality", @"B"},
{@"Damage", @"30 (large bullet), 6 x 12 (72 total for all smaller bullets)"},
{@"Fire rate", @"0.4"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"0°"},
},
        @"")},

{143, new ItemData(
        143,
        @"Shotgun Full of Hate",
        @"""Hate Is Power!""",
        @"A shotgun which fires a cluster of poison bullets, which each leave a pool of poison on the ground
Poisoned enemies take damage over time",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"150"},
{@"Clip size", @"8"},
{@"Quality", @"A"},
{@"Damage", @"6 x 4 (24 total for bullets), 5 (skull), 3 (nail)"},
{@"Fire rate", @"0.5"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"14°"},
},
        @"")},

{379, new ItemData(
        379,
        @"Shotgun Full of Love",
        @"""Kill With Kindness""",
        @"A shotgun that fires a cluster of bullets, which each have a chance to charm any hit enemies
Charmed enemies will attack other enemies instead of players for a short amount of time",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"120"},
{@"Clip size", @"8"},
{@"Quality", @"A"},
{@"Damage", @"5 x 6 (30 total)"},
{@"Fire rate", @"0.5"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"14°"},
},
        @"")},

{347, new ItemData(
        347,
        @"Shotgrub",
        @"""No Worries!""",
        @"A shotgun that fires 5 bullets, each which leave a pool of poison on the ground
Poisoned enemies take damage over time",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"250"},
{@"Clip size", @"8"},
{@"Quality", @"C"},
{@"Damage", @"5 x 5 (25 total)"},
{@"Fire rate", @"0.4"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"0°"},
},
        @"")},

{231, new ItemData(
        231,
        @"Gilded Hydra",
        @"""Heads Up!""",
        @"A semi-automatic gun which fires large bouncy, piercing bullets
By default the Clip size is 1, however this can be increased by 1 for every empty half heart the player is missing.
Filling those empty health containers will reduce the Clip size again
Very good at killing large or multiple part bosses (e.g. Kill Pillars)
UNLOCK: Unlock this weapon by killing the pasts of each of the four starting characters",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by killing the pasts of each of the four starting characters"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"50"},
{@"Clip size", @">= 1"},
{@"Quality", @"S"},
{@"Damage", @"7.5 x 8 (60 total)"},
{@"Fire rate", @"0.4"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"0°"},
},
        @"")},

{122, new ItemData(
        122,
        @"Blunderbuss",
        @"""Shoots Anything""",
        @"A gun which must be charged, and upon release will fire a short-range cluster of bullets
The bullets fired have a wide spread",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"100"},
{@"Clip size", @"4"},
{@"Quality", @"D"},
{@"Damage", @"3 x 10 (30 total)"},
{@"Fire rate", @"0.5"},
{@"Shot speed", @"26"},
{@"Range", @"1000"},
{@"Knockback", @"25"},
{@"Spread", @"20°"},
},
        @"")},

{123, new ItemData(
        123,
        @"Pulse Cannon",
        @"""Time Of Death...""",
        @"A shotgun which fires clusters of 5 bullets per use",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"120"},
{@"Clip size", @"8"},
{@"Quality", @"C"},
{@"Damage", @"4 x 6 (24 total)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{404, new ItemData(
        404,
        @"Siren",
        @"""Mershotgun""",
        @"A shotgun which fires a cluster of water bullets.
Each bullet that makes contact with an enemy or obstacle will place a pool of water on the floor
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"6"},
{@"Quality", @"C"},
{@"Damage", @"6 x 3 (18 total)"},
{@"Fire rate", @"0.4"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"0°"},
},
        @"")},

{329, new ItemData(
        329,
        @"Zilla Shotgun",
        @"""Quadruple the fun!""",
        @"A shotgun which fires a cluster of bullets each time it is used
Can be charged up to fire the entire clip of bullets at once
If fully charged, the bullets will be bouncy and piercing",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"120"},
{@"Clip size", @"6"},
{@"Quality", @"A"},
{@"Damage", @"4 x 8 (32 total when uncharged), 6 x 7 (42 total when charged)"},
{@"Fire rate", @"0.5"},
{@"Shot speed", @"26"},
{@"Range", @"1000"},
{@"Knockback", @"26"},
{@"Spread", @"20°"},
},
        @"")},

{225, new ItemData(
        225,
        @"Ice Breaker",
        @"""Never Let Go""",
        @"A gun with a clip size of 3. 
The first 2 shots of each clip fire a cluster of ice bullets.
The 3rd shot fires a single explosive bullet
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 8 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 8 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"100"},
{@"Clip size", @"3"},
{@"Quality", @"B"},
{@"Damage", @"2 x 5 (10 total), 35 (explosive)"},
{@"Fire rate", @"0.4"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"0°"},
},
        @"")},

{151, new ItemData(
        151,
        @"The Membrane",
        @"""Green Or Yellow?""",
        @"A shotgun which fires a cluster of bouncy bullets
UNLOCK: Unlock this weapon by purchasing it from Professor Goopton's store in The Breach for 10 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Professor Goopton's store in The Breach for 10 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"120"},
{@"Clip size", @"6"},
{@"Quality", @"C"},
{@"Damage", @"24 (before split), 36 (after split)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{346, new ItemData(
        346,
        @"Huntsman",
        @"""Axes Of Evil""",
        @"A gun which fires clusters of bullets like a shotgun
When reloaded, will cause the player to swing the axe infront of them, breaking any projectiles caught in the blade
Curse Up while this gun is held",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"150"},
{@"Clip size", @"6"},
{@"Quality", @"C"},
{@"Damage", @"3.5 x 6 (21 total)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{18, new ItemData(
        18,
        @"Blooper",
        @"""Close Your Bloop""",
        @"A shotgun that fires a cluster of bullets
Has a short range
Bullets deal a lot of knockback to enemies",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"150"},
{@"Clip size", @"5"},
{@"Quality", @"B"},
{@"Damage", @"7 x 6 (42 total)"},
{@"Fire rate", @"0.4"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"0°"},
},
        @"")},

{8, new ItemData(
        8,
        @"Bow",
        @"""Hold Fire To Charge""",
        @"Fires arrows
When fully charged, the arrows will become piercing and do much more damage.",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"100"},
{@"Clip size", @"1"},
{@"Quality", @"C"},
{@"Damage", @"7.5 (uncharged), 30 (charged)"},
{@"Fire rate", @"1"},
{@"Shot speed", @"26"},
{@"Range", @"1000"},
{@"Knockback", @"25"},
{@"Spread", @"0°"},
},
        @"")},

{200, new ItemData(
        200,
        @"Charmed Bow",
        @"""<3-----<<<""",
        @"Fires arrows
Arrows have a chance to charm enemies
Charmed enemies will attack other enemies instead of players for a short amount of time",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"100"},
{@"Clip size", @"1"},
{@"Quality", @"B"},
{@"Damage", @"7.5 (uncharged), 14 (charged)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{12, new ItemData(
        12,
        @"Crossbow",
        @"""The Original""",
        @"A crossbow which fires bolts that deal a lot of damage, however each bolt needs to be loaded individually
The Hunter starts with this weapon
There is a delay between the shot being fired and the auto reload which can be canceled with a manual reload.
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 6 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 6 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"100"},
{@"Clip size", @"1"},
{@"Quality", @"D"},
{@"Damage", @"22"},
{@"Fire rate", @"0.5"},
{@"Shot speed", @"26"},
{@"Range", @"1000"},
{@"Knockback", @"25"},
{@"Spread", @"7°"},
},
        @"")},

{4, new ItemData(
        4,
        @"Sticky Crossbow",
        @"""Reload, Explode""",
        @"A crossbow which fires sticky bolts.
The bolts will explode when you reload the gun, dealing damage to any nearby enemies",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"100"},
{@"Clip size", @"5"},
{@"Quality", @"C"},
{@"Damage", @"5 (bolts), 15 (explosion)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{126, new ItemData(
        126,
        @"Shotbow",
        @"""A Teleporter Accident""",
        @"A shotgun-crossbow combo that fires a cluster of piercing bolts",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"80"},
{@"Clip size", @"3"},
{@"Quality", @"B"},
{@"Damage", @"6 x 6 (36 total)"},
{@"Fire rate", @"1"},
{@"Shot speed", @"26"},
{@"Range", @"1000"},
{@"Knockback", @"25"},
{@"Spread", @"5°"},
},
        @"")},

{381, new ItemData(
        381,
        @"Triple Crossbow",
        @"""3 > 1""",
        @"A crossbow that will either shoot 3 bolts at once, or a single bolt which has a chance to slow enemies
Reloading the Triple Crossbow will switch between the two types",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"100"},
{@"Clip size", @"3"},
{@"Quality", @"C"},
{@"Damage", @"7 (single bolt), 7 x 3 (21 total for tripe bolts)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{52, new ItemData(
        52,
        @"Crescent Crossbow",
        @"""Moon Shot""",
        @"A crossbow which fires star projectiles, which will split into smaller bouncy stars
If fully charged, the it will fire a larger star, which will split twice instead of once",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"100"},
{@"Clip size", @"12"},
{@"Quality", @"A"},
{@"Damage", @"22 (large), 8 (medium), 3 (small)"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"32"},
{@"Range", @"1000"},
{@"Knockback", @"20"},
{@"Spread", @"0°"},
},
        @"")},

{210, new ItemData(
        210,
        @"Gunbow",
        @"""Failed Experiment""",
        @"A gun which can be charged up to fire bouncy bullets that have a high shot speed",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"70"},
{@"Clip size", @"1"},
{@"Quality", @"A"},
{@"Damage", @"35"},
{@"Fire rate", @"0.001"},
{@"Shot speed", @"26"},
{@"Range", @"1000"},
{@"Knockback", @"25"},
{@"Spread", @"0°"},
},
        @"")},

{31, new ItemData(
        31,
        @"Klobbe",
        @"""Everyone's Favorite""",
        @"An automatic gun which rapidly fires weak, inaccurate bullets",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"D"},
{@"Damage", @"1.2"},
{@"Fire rate", @"0.04"},
{@"Shot speed", @"14"},
{@"Range", @"1000"},
{@"Knockback", @"1"},
{@"Spread", @"20°"},
},
        @"")},

{43, new ItemData(
        43,
        @"Machine Pistol",
        @"""Rapid Fire""",
        @"An automatic gun which rapidly fires bullets",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"600"},
{@"Clip size", @"30"},
{@"Quality", @"D"},
{@"Damage", @"3.2"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"23"},
{@"Range", @"16"},
{@"Knockback", @"6"},
{@"Spread", @"10°"},
},
        @"")},

{2, new ItemData(
        2,
        @"Thompson Sub-Machinegun",
        @"""Myeah, See!""",
        @"An automatic sub-machinegun
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 1 Hegemony Credit",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 1 Hegemony Credit"},
{@"Type", @"Automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @"30"},
{@"Quality", @"C"},
{@"Damage", @"5"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{15, new ItemData(
        15,
        @"AK-47",
        @"""Accept No Substitutes""",
        @"A automatic assault rifle. It's good.",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"500"},
{@"Clip size", @"30"},
{@"Quality", @"B"},
{@"Damage", @"5.5"},
{@"Fire rate", @"0.11"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"9"},
{@"Spread", @"4°"},
},
        @"")},

{221, new ItemData(
        221,
        @"AK-47",
        @"""Accept No Substitutes""",
        @"A automatic assault rifle. It's good.",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"500"},
{@"Clip size", @"30"},
{@"Quality", @"B"},
{@"Damage", @"5.5"},
{@"Fire rate", @"0.11"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"9"},
{@"Spread", @"4°"},
},
        @"")},

{95, new ItemData(
        95,
        @"AKEY-47",
        @"""Unlocked And Loaded!""",
        @"A automatic gun which fires keys
Shooting a locked door or chest will unlock it
UNLOCK: Unlock this weapon by fixing the shortcut to the Forge (Chamber #5)",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by fixing the shortcut to the Forge (Chamber #5)"},
{@"Type", @"Automatic"},
{@"Max ammo", @"500"},
{@"Clip size", @"30"},
{@"Quality", @"S"},
{@"Damage", @"5.5"},
{@"Fire rate", @"0.11"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"9"},
{@"Spread", @"4°"},
},
        @"")},

{96, new ItemData(
        96,
        @"M16",
        @"""Underslung""",
        @"A machine gun, which can either fire a burst of 3 bullets or grenades
Reloading will swap between the two firing modes
UNLOCK: Unlock this weapon by purchasing it in The Breach from Trorc for 5 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it in The Breach from Trorc for 5 Hegemony Credits"},
{@"Type", @"Burst"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"A"},
{@"Damage", @"5.5 (bullets), 10 (grenade impact), 25 (explosion)"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"11"},
{@"Spread", @"7°"},
},
        @"")},

{6, new ItemData(
        6,
        @"Zorgun",
        @"""Don't Push The Red Button""",
        @"A gun which rapidly fires homing bullets
The last bullet in each clip fires a random explosive (grenade, rocket, or drill)",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"A"},
{@"Damage", @"5.5"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"9"},
{@"Spread", @"5°"},
},
        @"")},

{29, new ItemData(
        29,
        @"VertebraeK-47",
        @"""Nervous Yet?""",
        @"A gun which fires piercing and homing bullets
Bullets close to one another will link together, damaging enemies that touch the link",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"250"},
{@"Clip size", @"30"},
{@"Quality", @"B"},
{@"Damage", @"4"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"18"},
{@"Range", @"1000"},
{@"Knockback", @"6"},
{@"Spread", @"5°"},
},
        @"")},

{94, new ItemData(
        94,
        @"MAC10",
        @"""$#!^@ Never End""",
        @"A machine gun that fires a burst of four bullets at a time",
        new Dictionary<string, string>(){
{@"Type", @"Burst"},
{@"Max ammo", @"600"},
{@"Clip size", @"30"},
{@"Quality", @"C"},
{@"Damage", @"3.5"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"3"},
{@"Spread", @"10°"},
},
        @"")},

{17, new ItemData(
        17,
        @"Heck Blaster",
        @"""Whoa, Nelly""",
        @"A gun that fires bullets which travel instantly towards their target, appearing to be invisible
Jammed enemies and bosses hit by this gun will revert to regular non-jammed enemies.",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"999"},
{@"Clip size", @"999"},
{@"Quality", @"B"},
{@"Damage", @"2.5"},
{@"Fire rate", @"0.05"},
{@"Shot speed", @"40"},
{@"Range", @"14"},
{@"Knockback", @"3"},
{@"Spread", @"8°"},
},
        @"")},

{98, new ItemData(
        98,
        @"Patriot",
        @"""Gun Eater""",
        @"An automatic gun that fires piercing bullets
Holding down the trigger will greatly increase the fire rate of this gun
UNLOCK: Unlock this weapon by purchasing it in The Breach from Trorc for 12 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it in The Breach from Trorc for 12 Hegemony Credits"},
{@"Type", @"Automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @"50"},
{@"Quality", @"S"},
{@"Damage", @"7"},
{@"Fire rate", @"0.3"},
{@"Shot speed", @"30"},
{@"Range", @"1000"},
{@"Knockback", @"15"},
{@"Spread", @"1°"},
},
        @"")},

{84, new ItemData(
        84,
        @"Vulcan Cannon",
        @"""Boundless Slaughter""",
        @"A gun which rapidly fires inaccurate bullets
Used by the Gatling Gull boss that appears in the first chamber",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"800"},
{@"Clip size", @"800"},
{@"Quality", @"S"},
{@"Damage", @"4"},
{@"Fire rate", @"0.05"},
{@"Shot speed", @"35"},
{@"Range", @"1000"},
{@"Knockback", @"15"},
{@"Spread", @"12°"},
},
        @"")},

{207, new ItemData(
        207,
        @"Plague Pistol",
        @"""Chemical Warfare""",
        @"Fires bullets that leave poison goop on the ground and have a chance to poison enemies
A semi-automatic pistol that fires bullets which have a chance to poison enemies
Poisoned enemies take damage over time for a short period
UNLOCK: Unlock this weapon by purchasing it from Professor Goopton's store in The Breach for 6 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Professor Goopton's store in The Breach for 6 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"12"},
{@"Quality", @"D"},
{@"Damage", @"4"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"20"},
{@"Range", @"25"},
{@"Knockback", @"13"},
{@"Spread", @"5°"},
},
        @"")},

{401, new ItemData(
        401,
        @"Gungine",
        @"""12 Cylinder""",
        @"An automatic gun which when reloaded while standing on a liquid (water, oil etc.) clears it up and refills the ammo of your current clip. This effect doesn't work while flying.
Player movement speed up by 2.25 while held
While held, the player is immune to fire
UNLOCK: Unlock this weapon by fixing the shortcut to the Hollow (Chamber #4)",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by fixing the shortcut to the Hollow (Chamber #4)"},
{@"Type", @"Automatic"},
{@"Max ammo", @"800"},
{@"Clip size", @"100"},
{@"Quality", @"S"},
{@"Damage", @"5"},
{@"Fire rate", @"0.05"},
{@"Shot speed", @"35"},
{@"Range", @"1000"},
{@"Knockback", @"15"},
{@"Spread", @"6°"},
},
        @"")},

{146, new ItemData(
        146,
        @"Dragunfire",
        @"""Roar""",
        @"An automatic gun that fires bullets which have a chance to burn enemies
Burned enemies take damage over time for a short period
UNLOCK: Unlock this weapon by defeating the High Dragun boss for the first time",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by defeating the High Dragun boss for the first time"},
{@"Type", @"Automatic"},
{@"Max ammo", @"600"},
{@"Clip size", @"30"},
{@"Quality", @"A"},
{@"Damage", @"5"},
{@"Fire rate", @"0.05"},
{@"Shot speed", @"25"},
{@"Range", @"1000"},
{@"Knockback", @"27"},
{@"Spread", @"7°"},
},
        @"")},

{49, new ItemData(
        49,
        @"Sniper Rifle",
        @"""Scope Creep""",
        @"A sniper rifle that fires single high-power bullets, which can pierce through enemies",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"80"},
{@"Clip size", @"10"},
{@"Quality", @"C"},
{@"Damage", @"26"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{5, new ItemData(
        5,
        @"A.W.P.",
        @"""Noob Cannon""",
        @"A high powered sniper rifle that fires piercing bullets which deal a lot of damage
UNLOCK: Unlock this weapon by purchasing it in The Breach from Trorc for 10 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it in The Breach from Trorc for 10 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"60"},
{@"Clip size", @"10"},
{@"Quality", @"A"},
{@"Damage", @"40"},
{@"Fire rate", @"1.2"},
{@"Shot speed", @"100"},
{@"Range", @"1000"},
{@"Knockback", @"25"},
{@"Spread", @"5°"},
},
        @"")},

{25, new ItemData(
        25,
        @"M1",
        @"""Bolt Action""",
        @"A semi-automatic gun which fires piercing bullets",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"100"},
{@"Clip size", @"6"},
{@"Quality", @"C"},
{@"Damage", @"20"},
{@"Fire rate", @"0.8"},
{@"Shot speed", @"200"},
{@"Range", @"60"},
{@"Knockback", @"25"},
{@"Spread", @"2°"},
},
        @"")},

{181, new ItemData(
        181,
        @"Winchester Rifle",
        @"""Guns and Deviltry.""",
        @"A semi-automatic rifle that fires powerful bullets at a low rate of fire",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"130"},
{@"Clip size", @"12"},
{@"Quality", @"D"},
{@"Damage", @"15"},
{@"Fire rate", @"0.72"},
{@"Shot speed", @"32"},
{@"Range", @"1000"},
{@"Knockback", @"9"},
{@"Spread", @"5°"},
},
        @"")},

{327, new ItemData(
        327,
        @"Corsair",
        @"""Plot A Course""",
        @"A gun which must be charged to fire bullets which start out slow, but increase in speed over time and bounce around the room",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"200"},
{@"Clip size", @"1"},
{@"Quality", @"C"},
{@"Damage", @"10"},
{@"Fire rate", @""},
{@"Shot speed", @"26"},
{@"Range", @"1000"},
{@"Knockback", @"25"},
{@"Spread", @"5°"},
},
        @"")},

{358, new ItemData(
        358,
        @"Railgun",
        @"""Calibrating""",
        @"A single clip gun that is charged up to fire one highly powerful bouncy, piercing bullet with high shot speed
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 30 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 30 Hegemony Credits"},
{@"Type", @"Charged"},
{@"Max ammo", @"40"},
{@"Clip size", @"1"},
{@"Quality", @"S"},
{@"Damage", @"50"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{370, new ItemData(
        370,
        @"Prototype Railgun",
        @"""DANGER: HIGH VOLTAGE""",
        @"A gun which fires piercing shots with a high shot speed (charge to fire)",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"A"},
{@"Damage", @"75"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{32, new ItemData(
        32,
        @"Void Marshal",
        @"""Acquired Under The Table""",
        @"A highly accurate semi-automatic gun that fires fast-moving lasers",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"250"},
{@"Clip size", @"15"},
{@"Quality", @"B"},
{@"Damage", @"9"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"35"},
{@"Range", @"35"},
{@"Knockback", @"10"},
{@"Spread", @"7°"},
},
        @"")},

{81, new ItemData(
        81,
        @"Deck4rd",
        @"""Unicorn Of Handguns""",
        @"Fires massive powerful bullets that will explode upon impact",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"40"},
{@"Clip size", @"2"},
{@"Quality", @"A"},
{@"Damage", @"5 (bullets), 35 (explosion)"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"20"},
{@"Range", @"1000"},
{@"Knockback", @"22"},
{@"Spread", @"10°"},
},
        @"")},

{184, new ItemData(
        184,
        @"The Judge",
        @"""Hot Shot""",
        @"The final shot of each clip has a chance to apply a random status effect to enemies (poison, freeze or burn)",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"400"},
{@"Clip size", @"9"},
{@"Quality", @"B"},
{@"Damage", @"7.5"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"30"},
{@"Range", @"1000"},
{@"Knockback", @"9"},
{@"Spread", @"7°"},
},
        @"")},

{57, new ItemData(
        57,
        @"Alien Sidearm",
        @"""Shield Breaker""",
        @"A gun which can be charged up to fire larger shots that deal more damage
Can also be rapid fired by quickly firing instead of charging",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"350"},
{@"Clip size", @"10"},
{@"Quality", @"D"},
{@"Damage", @"5 (uncharged), 25 (charged)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{142, new ItemData(
        142,
        @"RUBE-ADYNE Prototype",
        @"""It Never Quits""",
        @"A gun which fires lasers that will bounce 4 times",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"6"},
{@"Quality", @"B"},
{@"Damage", @"7"},
{@"Fire rate", @"0.12"},
{@"Shot speed", @"40"},
{@"Range", @"60"},
{@"Knockback", @"10"},
{@"Spread", @"5°"},
},
        @"")},

{128, new ItemData(
        128,
        @"RUBE-ADYNE MK.II",
        @"""Polished Product""",
        @"A laser pistol that fires bouncy lasers
A better version of the RUBE-ADYNE Prototype",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"300"},
{@"Clip size", @"15"},
{@"Quality", @"A"},
{@"Damage", @"8"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"40"},
{@"Range", @"35"},
{@"Knockback", @"10"},
{@"Spread", @"7°"},
},
        @"")},

{394, new ItemData(
        394,
        @"Mine Cutter",
        @"""Safety First""",
        @"Upon reloading, this gun will alternate between firing three small piercing lasers and single larger lasers
UNLOCK: Unlock this weapon by completing the Black Powder Mine (Chamber #3) 30 times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing the Black Powder Mine (Chamber #3) 30 times"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"250"},
{@"Clip size", @"12"},
{@"Quality", @"B"},
{@"Damage", @"10 (3 laser mode), 8 (single laser mode)"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"7°"},
},
        @"")},

{58, new ItemData(
        58,
        @"Void Core Assault Rifle",
        @"""Rapid Fire""",
        @"An assault rifle that fires bursts of three lasers at a time",
        new Dictionary<string, string>(){
{@"Type", @"Burst"},
{@"Max ammo", @"300"},
{@"Clip size", @"30"},
{@"Quality", @"B"},
{@"Damage", @"6.5"},
{@"Fire rate", @"0.35"},
{@"Shot speed", @"23"},
{@"Range", @"20"},
{@"Knockback", @"15"},
{@"Spread", @"3°"},
},
        @"")},

{383, new ItemData(
        383,
        @"Flash Ray",
        @"""Ah Ahhh!""",
        @"A ray gun that fires piercing lasers
Lasers from this gun have a chance to stun enemies for a brief period of time
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 6 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 6 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @"8"},
{@"Quality", @"D"},
{@"Damage", @"7.5"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"600"},
{@"Range", @"1000"},
{@"Knockback", @"4"},
{@"Spread", @"10°"},
},
        @"")},

{334, new ItemData(
        334,
        @"Wind Up Gun",
        @"""Charge It""",
        @"A semi-automatic gun which fires purple lasers
The first half of bullets in each clip deal 5 damage and pierce enemies
The second half of bullets in each clip deal 2.5 damage and don't pierce enemies",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"600"},
{@"Clip size", @"20"},
{@"Quality", @"D"},
{@"Damage", @"5 (2.5 for second half of clip)"},
{@"Fire rate", @"0.13"},
{@"Shot speed", @"30"},
{@"Range", @"35"},
{@"Knockback", @"10"},
{@"Spread", @"8°"},
},
        @"")},

{91, new ItemData(
        91,
        @"H4mmer",
        @"""Many Bullets""",
        @"A semi-automatic gun that fires bullets rapidly
The last shot in the magazine is a hammer, which deals more damage and has a chance to stun enemies",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"450"},
{@"Clip size", @"30"},
{@"Quality", @"B"},
{@"Damage", @"3.8 (bullets), 20 (hammer)"},
{@"Fire rate", @"0.05"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"6"},
{@"Spread", @"7°"},
},
        @"")},

{360, new ItemData(
        360,
        @"Snakemaker",
        @"""SSSSSSSSSSS""",
        @"An automatic gun which fires bullets that have a chance to transmogrify enemies
UNLOCK: Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 30 Gunzookies",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 30 Gunzookies"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"A"},
{@"Damage", @"12"},
{@"Fire rate", @"0.25"},
{@"Shot speed", @"50"},
{@"Range", @"1000"},
{@"Knockback", @"10"},
{@"Spread", @"0°"},
},
        @"")},

{229, new ItemData(
        229,
        @"Hegemony Carbine",
        @"""All The Same""",
        @"Shoots rapid fire white bolts of energy
Has a very small chance to drop a Hegemony Credit upon killing an enemy
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 3 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 3 Hegemony Credits"},
{@"Type", @"Automatic"},
{@"Max ammo", @"600"},
{@"Clip size", @"25"},
{@"Quality", @"C"},
{@"Damage", @"3.5"},
{@"Fire rate", @"0.13"},
{@"Shot speed", @"?"},
{@"Range", @"?"},
{@"Knockback", @"?"},
{@"Spread", @"?°"},
},
        @"")},

{3, new ItemData(
        3,
        @"Screecher",
        @"""Cover Your Ears!""",
        @"A gun that fires piercing sound waves, which increase in size the further they travel across the room
The sound waves have a chance to stun enemies for a few seconds",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"1000"},
{@"Clip size", @"1000"},
{@"Quality", @"C"},
{@"Damage", @"1.5"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{156, new ItemData(
        156,
        @"Laser Lotus",
        @"""Level 5""",
        @"Laser Lotus is a gun that fires piercing lasers
The lasers electrify any water that they pass over.",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"100"},
{@"Clip size", @"10"},
{@"Quality", @"A"},
{@"Damage", @"16"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"45"},
{@"Range", @"1000"},
{@"Knockback", @"26"},
{@"Spread", @"5°"},
},
        @"")},

{59, new ItemData(
        59,
        @"Hegemony Rifle",
        @"""So Precise""",
        @"A fairly decent damaging semi-automatic gun which is inaccurate",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"B"},
{@"Damage", @"10"},
{@"Fire rate", @"0.25"},
{@"Shot speed", @"35"},
{@"Range", @"15"},
{@"Knockback", @"15"},
{@"Spread", @"13°"},
},
        @"")},

{345, new ItemData(
        345,
        @"Fightsabre",
        @"""Heresy""",
        @"An automatic gun that is swung while reloading. Any bullets nearby while reloading will be reflected away
Curse Up while held",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"500"},
{@"Clip size", @"25"},
{@"Quality", @"S"},
{@"Damage", @"6"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"23"},
{@"Range", @"50"},
{@"Knockback", @"10"},
{@"Spread", @"8°"},
},
        @"")},

{230, new ItemData(
        230,
        @"Helix",
        @"""Splice 'n' Dice""",
        @"Fires two bullets in a helix pattern
Quite powerful, best used on large bosses where the most amount of damage can be dealt per shot",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"250"},
{@"Clip size", @"12"},
{@"Quality", @"C"},
{@"Damage", @"7.5 x 2 (15 total)"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"35"},
{@"Range", @"35"},
{@"Knockback", @"10"},
{@"Spread", @"7°"},
},
        @"")},

{54, new ItemData(
        54,
        @"Laser Rifle",
        @"""Blast Off!""",
        @"A laser rifle that fires a burst of 3 shots",
        new Dictionary<string, string>(){
{@"Type", @"Burst"},
{@"Max ammo", @"500"},
{@"Clip size", @"24"},
{@"Quality", @"C"},
{@"Damage", @"5"},
{@"Fire rate", @"0.5"},
{@"Shot speed", @"200"},
{@"Range", @"60"},
{@"Knockback", @"16"},
{@"Spread", @"5°"},
},
        @"")},

{178, new ItemData(
        178,
        @"Crestfaller",
        @"""Cold Reality""",
        @"A semi-automatic gun that fires bullets which have a chance to slow and freeze enemies",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"250"},
{@"Clip size", @"8"},
{@"Quality", @"C"},
{@"Damage", @"10"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{13, new ItemData(
        13,
        @"Thunderclap",
        @"""Lightning In A Bullet""",
        @"A semi-automatic gun that fires small balls of lightning",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"300"},
{@"Clip size", @"15"},
{@"Quality", @"A"},
{@"Damage", @"8"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"20"},
{@"Range", @"1000"},
{@"Knockback", @"10"},
{@"Spread", @"5°"},
},
        @"")},

{328, new ItemData(
        328,
        @"Charge Shot",
        @"""Hold To Fire""",
        @"Fires a large laser that fires piercing, bouncy bullets",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"50"},
{@"Clip size", @"1"},
{@"Quality", @"B"},
{@"Damage", @"30"},
{@"Fire rate", @"0.01"},
{@"Shot speed", @"26"},
{@"Range", @"1000"},
{@"Knockback", @"25"},
{@"Spread", @"5°"},
},
        @"")},

{274, new ItemData(
        274,
        @"Dark Marker",
        @"""Big Bang""",
        @"This gun can be charged to fire the entire clip at once, creating two projectiles which curve and meet at the same point
When the two fired projectiles meet, they create a blank effect and explosion",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"12"},
{@"Quality", @"S"},
{@"Damage", @"8 (bullets), 80 (explosion)"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"32"},
{@"Range", @"1000"},
{@"Knockback", @"20"},
{@"Spread", @"0°"},
},
        @"")},

{228, new ItemData(
        228,
        @"Particulator",
        @"""Strange Matter""",
        @"Fires seeking bullets in a small spread, which will travel towards nearby enemies",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"60"},
{@"Clip size", @"1"},
{@"Quality", @"S"},
{@"Damage", @"30 (large), 7 (small)"},
{@"Fire rate", @"0.7"},
{@"Shot speed", @"10"},
{@"Range", @"10"},
{@"Knockback", @"8"},
{@"Spread", @"0°"},
},
        @"")},

{330, new ItemData(
        330,
        @"The Emperor",
        @"""Electric Terror""",
        @"A gun that fires a burst of four bullets which are all connected to each other by electricity",
        new Dictionary<string, string>(){
{@"Type", @"Burst"},
{@"Max ammo", @"n/a"},
{@"Clip size", @"30"},
{@"Quality", @"A"},
{@"Damage", @"7"},
{@"Fire rate", @"0.3"},
{@"Shot speed", @"20"},
{@"Range", @"50"},
{@"Knockback", @"10"},
{@"Spread", @"7°"},
},
        @"")},

{39, new ItemData(
        39,
        @"RPG",
        @"""Leveled Up""",
        @"Fires rocket-propelled grenades, which explode on impact
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 5 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 5 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"40"},
{@"Clip size", @"1"},
{@"Quality", @"B"},
{@"Damage", @"20 (impact), 35 (explosion)"},
{@"Fire rate", @"1"},
{@"Shot speed", @"40"},
{@"Range", @"90"},
{@"Knockback", @"10"},
{@"Spread", @"5°"},
},
        @"")},

{19, new ItemData(
        19,
        @"Grenade Launcher",
        @"""Fwomp!""",
        @"Shoots a grenade that bounces off of surfaces and explodes on impact with enemies",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"25"},
{@"Clip size", @"1"},
{@"Quality", @"B"},
{@"Damage", @"10 (impact), 25 (explosion)"},
{@"Fire rate", @"1.2"},
{@"Shot speed", @"20"},
{@"Range", @"20"},
{@"Knockback", @"20"},
{@"Spread", @"4°"},
},
        @"")},

{92, new ItemData(
        92,
        @"Stinger",
        @"""Drone Warfare""",
        @"A semi-automatic launcher that fires homing rockets, which release bees when exploded
Friendly bees will seek out and attack the nearest enemy, dealing damage on contact",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"50"},
{@"Clip size", @"1"},
{@"Quality", @"B"},
{@"Damage", @"10 (impact), 15 (explosion)"},
{@"Fire rate", @"1"},
{@"Shot speed", @"20"},
{@"Range", @"60"},
{@"Knockback", @"10"},
{@"Spread", @"1°"},
},
        @"")},

{129, new ItemData(
        129,
        @"Com4nd0",
        @"""You're Fired""",
        @"Fires homing rockets
Fires very powerful homing rockets, which seek out enemies and explode on contact
UNLOCK: Unlock this weapon by purchasing it in The Breach from Trorc for 8 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it in The Breach from Trorc for 8 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"40"},
{@"Clip size", @"4"},
{@"Quality", @"B"},
{@"Damage", @"20 (impact), 25 (explosion)"},
{@"Fire rate", @"0.6"},
{@"Shot speed", @"14"},
{@"Range", @"90"},
{@"Knockback", @"10"},
{@"Spread", @"5°"},
},
        @"")},

{372, new ItemData(
        372,
        @"RC Rocket",
        @"""Avoid User Error""",
        @"Fires rockets that are controlled by your mouse cursor
UNLOCK: Unlock this weapon by purchasing it in The Breach from Trorc for 15 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it in The Breach from Trorc for 15 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"50"},
{@"Clip size", @"1"},
{@"Quality", @"A"},
{@"Damage", @"100"},
{@"Fire rate", @"0.6"},
{@"Shot speed", @"10"},
{@"Range", @"200"},
{@"Knockback", @"10"},
{@"Spread", @"1°"},
},
        @"")},

{16, new ItemData(
        16,
        @"Yari Launcher",
        @"""Hell. Yes.""",
        @"A gun that rapidly fires homing rockets
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 25 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 25 Hegemony Credits"},
{@"Type", @"Automatic"},
{@"Max ammo", @"80"},
{@"Clip size", @""},
{@"Quality", @"S"},
{@"Damage", @"10 (impact), 15 (explosion)"},
{@"Fire rate", @"0.04"},
{@"Shot speed", @"10"},
{@"Range", @"90"},
{@"Knockback", @"30"},
{@"Spread", @"45°"},
},
        @"")},

{332, new ItemData(
        332,
        @"Lil' Bomber",
        @"""ReFuse To Lose!""",
        @"A gun which must be charged to fire a bomb, which explodes on contact with enemies
The bombs will also bounce off objects and walls
Bomb explosions from this gun can open secret rooms",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"60"},
{@"Clip size", @"3"},
{@"Quality", @"D"},
{@"Damage", @"15 (impact), 25 (explosion)"},
{@"Fire rate", @"1"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"35"},
{@"Spread", @"6°"},
},
        @"")},

{180, new ItemData(
        180,
        @"Grasschopper",
        @"""Noisy""",
        @"Fires a single powerful blast that will knock the player back in recoil
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 8 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 8 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"A"},
{@"Damage", @"20 (impact), 20 (explosion)"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"36"},
{@"Range", @"18"},
{@"Knockback", @"22"},
{@"Spread", @"5°"},
},
        @"")},

{61, new ItemData(
        61,
        @"Bundle of Wands",
        @"""Dark Arts""",
        @"Fires a spread of magic bursts that have a chance to transmogrify enemies upon each successful hit
UNLOCK: Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 40 Gunjurers",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 40 Gunjurers"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"C"},
{@"Damage", @"7 x 3 (21 total)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{395, new ItemData(
        395,
        @"Staff of Firepower",
        @"""Missing Link""",
        @"A gun that will alternate between two modes when reloading: A quick firing pistol and a beam that can set enemies on fire
Burned enemies take damage over time for a short period
UNLOCK: Unlock this weapon by completing the Gungeon Proper (Chamber #2) 40 times",
        new Dictionary<string, string>(){
{@"A gun that will alternate between two modes when reloading", @"A quick firing pistol and a beam that can set enemies on fire"},
{@"UNLOCK", @"Unlock this weapon by completing the Gungeon Proper (Chamber #2) 40 times"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"12 (staff), 6 (gun)"},
{@"Quality", @"A"},
{@"Damage", @"7 (pistol), 12 (beam)"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"25"},
{@"Range", @"1000"},
{@"Knockback", @"12"},
{@"Spread", @"7°"},
},
        @"")},

{145, new ItemData(
        145,
        @"Witch Pistol",
        @"""Spells Your Doom""",
        @"Fires bullets that have a chance to transmogrify enemies upon each successful hit",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @"6"},
{@"Quality", @"C"},
{@"Damage", @"6"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{385, new ItemData(
        385,
        @"Hexagun",
        @"""Light Fantastic""",
        @"A semiautomatic rifle that fires piercing bullets which have a chance to transmogrify enemies on each successful hit",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"75"},
{@"Clip size", @"1"},
{@"Quality", @"B"},
{@"Damage", @"35"},
{@"Fire rate", @"0.001"},
{@"Shot speed", @"200"},
{@"Range", @"1000"},
{@"Knockback", @"25"},
{@"Spread", @"0°"},
},
        @"")},

{384, new ItemData(
        384,
        @"Phoenix",
        @"""Reborn In Flame""",
        @"Firing a bullet also creates a cone of fire in front of the player that sets enemies on fire
Burned enemies take damage over time for a short period",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @"12"},
{@"Quality", @"D"},
{@"Damage", @"4"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"25"},
{@"Range", @"25"},
{@"Knockback", @"13"},
{@"Spread", @"3°"},
},
        @"")},

{198, new ItemData(
        198,
        @"Gunslinger's Ashes",
        @"""Spirit, Willing""",
        @"Each shot releases an armed spirit that attacks enemies
UNLOCK: Unlock this weapon by feeding 10 guns to an Evil Gun Muncher",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by feeding 10 guns to an Evil Gun Muncher"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"80"},
{@"Clip size", @"6"},
{@"Quality", @"C"},
{@"Damage", @"5 x 3 (15 total)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{199, new ItemData(
        199,
        @"Luxin Cannon",
        @"""Omnichrome""",
        @"Rapidly fires laser bullets
When the magazine is emptied, the end of the crystal will be launched forward, dealing extra damage to any enemies it hits",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"600"},
{@"Clip size", @"45"},
{@"Quality", @"C"},
{@"Damage", @"4.5"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{338, new ItemData(
        338,
        @"Gunther",
        @"""Jealous Weapon""",
        @"Gunther is a gun which evolves slowly as each room is cleared
Stage #1: Gunther fires piercing bullets
Stage #2: Bullets gain a damage up and become bouncy
Stage #3: Bullets gain another damage up and seek out enemies (homing effect)
UNLOCK: Unlock this weapon by defeating the High Dragun boss with the Sorceress' blessing",
        new Dictionary<string, string>(){
{@"Stage #1", @"Gunther fires piercing bullets"},
{@"Stage #2", @"Bullets gain a damage up and become bouncy"},
{@"Stage #3", @"Bullets gain another damage up and seek out enemies (homing effect)"},
{@"UNLOCK", @"Unlock this weapon by defeating the High Dragun boss with the Sorceress' blessing"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"Infinite"},
{@"Clip size", @""},
{@"Quality", @"S"},
{@"Damage", @"6, 9, 12 (increases with each stage)"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"16"},
{@"Range", @"50"},
{@"Knockback", @"20"},
{@"Spread", @"10°"},
},
        @"")},

{100, new ItemData(
        100,
        @"Unicorn Horn",
        @"""Fires Friendship""",
        @"Fires a rainbow beam that will bend towards enemies
Curse Up while held
UNLOCK: Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 40 Hollowpoints",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 40 Hollowpoints"},
{@"Type", @"Beam"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"A"},
{@"Damage", @"30 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"30"},
{@"Range", @"30"},
{@"Knockback", @"45"},
{@"Spread", @"0°"},
},
        @"")},

{390, new ItemData(
        390,
        @"Cobalt Hammer",
        @"""Break Stuff""",
        @"A gun which fires blue lasers
Can be charged up to fire lasers in four directions
A reference to twitch.tv streamers Cobaltstreak and Richard Hammer
UNLOCK: Unlock this weapon by completing the Forge (Chamber #5) 10 times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing the Forge (Chamber #5) 10 times"},
{@"Type", @"Charged"},
{@"Max ammo", @"60"},
{@"Clip size", @"6"},
{@"Quality", @"A"},
{@"Damage", @"36 (charged), 26 (uncharged)"},
{@"Fire rate", @"0.3"},
{@"Shot speed", @"100"},
{@"Range", @"1000"},
{@"Knockback", @"80"},
{@"Spread", @"0°"},
},
        @"")},

{387, new ItemData(
        387,
        @"Frost Giant",
        @"""Icy Grasp""",
        @"Firing a bullet also creates a cone of ice in front of the player that has a chance to freeze enemies inside it
Slowed enemies will have reduced movement speed. If applied multiple times, the enemy will freeze solid for a while. Dodge rolling into a frozen enemy will shatter it
UNLOCK: Unlock this weapon by beating the Hollow (Chamber #4) boss without getting hit",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by beating the Hollow (Chamber #4) boss without getting hit"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"130"},
{@"Clip size", @"12"},
{@"Quality", @"B"},
{@"Damage", @"12"},
{@"Fire rate", @"0.001"},
{@"Shot speed", @"20"},
{@"Range", @"30"},
{@"Knockback", @"10"},
{@"Spread", @"12°"},
},
        @"")},

{362, new ItemData(
        362,
        @"Bullet Bore",
        @"""Mind Muncher""",
        @"Fires homing drills, that seek out enemies and stun them for a few seconds
After a while, the drill will then explode
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 14 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 14 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"75"},
{@"Clip size", @"1"},
{@"Quality", @"A"},
{@"Damage", @"10 (bullet), 25 (explosion)"},
{@"Fire rate", @"1"},
{@"Shot speed", @"20"},
{@"Range", @"1000"},
{@"Knockback", @"8"},
{@"Spread", @"5°"},
},
        @"")},

{357, new ItemData(
        357,
        @"Cat Claw",
        @"""Kneadle Your Foes!""",
        @"Fires homing darts which deal no damage on contact, but will explode after a few seconds of being stuck to an enemy
UNLOCK: Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 30 Shambling Rounds",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 30 Shambling Rounds"},
{@"Type", @"Automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"A"},
{@"Damage", @"2 (dart), 10 (explosion)"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"2"},
{@"Spread", @"5°"},
},
        @"")},

{36, new ItemData(
        36,
        @"Megahand",
        @"""-P-""",
        @"A charged gun which can be rapidly fired with low damage bullets, or fully charged to deal a powerful shot",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"200"},
{@"Clip size", @"18"},
{@"Quality", @"B"},
{@"Damage", @"6 (uncharged), 45 (charged)"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"20"},
{@"Range", @"1000"},
{@"Knockback", @"8"},
{@"Spread", @"0°"},
},
        @"")},

{60, new ItemData(
        60,
        @"Demon Head",
        @"""Wanged""",
        @"Fires a continuous beam that has a chance to afflict Burn
Burned enemies take damage over time for a short period",
        new Dictionary<string, string>(){
{@"Type", @"Beam"},
{@"Max ammo", @"500"},
{@"Clip size", @"500"},
{@"Quality", @"B"},
{@"Damage", @"31 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"100"},
{@"Range", @"40"},
{@"Knockback", @"30"},
{@"Spread", @"5°"},
},
        @"")},

{41, new ItemData(
        41,
        @"Heroine",
        @"""Charge Beam Active""",
        @"A charged gun which can be fired quickly with low damage bullets, or fully charged to deal a single powerful shot
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 13 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 13 Hegemony Credits"},
{@"Type", @"Charged"},
{@"Max ammo", @"200"},
{@"Clip size", @"6"},
{@"Quality", @"B"},
{@"Damage", @"5 (level 1 charge), 10 (level 2 charge), 70 (level 3 charge)"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"25"},
{@"Range", @"1000"},
{@"Knockback", @"10"},
{@"Spread", @"0°"},
},
        @"")},

{333, new ItemData(
        333,
        @"Mutation",
        @"""Didn't Need Two Anyway""",
        @"Fires a continuous beam which has heavy recoil for the player
UNLOCK: Unlock this weapon by creating 10 guns using the Gun Muncher",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by creating 10 guns using the Gun Muncher"},
{@"Type", @"Beam"},
{@"Max ammo", @"500"},
{@"Clip size", @"500"},
{@"Quality", @"B"},
{@"Damage", @"45 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"40"},
{@"Range", @"20"},
{@"Knockback", @"50"},
{@"Spread", @"5°"},
},
        @"")},

{125, new ItemData(
        125,
        @"Flame Hand",
        @"""2D6 + Int Mod""",
        @"Fires fireballs that pierce enemies and have a chance to set enemies on fire
Burned enemies take damage over time for a short period",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"B"},
{@"Damage", @"Varies"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"35"},
{@"Spread", @"0°"},
},
        @"")},

{186, new ItemData(
        186,
        @"Machine Fist",
        @"""Avalanche Of Bullets""",
        @"A gun that alternates between two modes of firing upon reloading
Mode 1: A gattling gun
Mode 2: A single shot exploding rocket that is guided by the player's mouse cursor (consumes 10 ammo)",
        new Dictionary<string, string>(){
{@"Mode 1", @"A gattling gun"},
{@"Mode 2", @"A single shot exploding rocket that is guided by the player's mouse cursor (consumes 10 ammo)"},
{@"Type", @"Automatic"},
{@"Max ammo", @"300"},
{@"Clip size", @"70"},
{@"Quality", @"A"},
{@"Damage", @"4 (gattling gun), 20 (rocket impact), 30 (explosion)"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"27"},
{@"Range", @"1000"},
{@"Knockback", @"15"},
{@"Spread", @"6°"},
},
        @"")},

{402, new ItemData(
        402,
        @"Snowballer",
        @"""May Contain Rocks""",
        @"Fires snowballs that have a chance to freeze enemies
Slowed enemies will have reduced movement speed. If applied multiple times, the enemy will freeze solid for a while. Dodge rolling into a frozen enemy will shatter it",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"400"},
{@"Clip size", @"20"},
{@"Quality", @"D"},
{@"Damage", @"3.5"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"28"},
{@"Range", @"35"},
{@"Knockback", @"10"},
{@"Spread", @"10°"},
},
        @"")},

{479, new ItemData(
        479,
        @"Super Meat Gun",
        @"""Very Fast""",
        @"Fires piercing bouncy saw blades
Player movement speed up while held
+1 HP up while held",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"12"},
{@"Quality", @"A"},
{@"Damage", @"6"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"25"},
{@"Range", @"1000"},
{@"Knockback", @"10"},
{@"Spread", @"5°"},
},
        @"")},

{393, new ItemData(
        393,
        @"Anvillain",
        @"""Practical And Safe""",
        @"A charged gun which fires large, slow moving piercing anvils, that will knockback and stun enemies for a few seconds",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"60"},
{@"Clip size", @"3"},
{@"Quality", @"C"},
{@"Damage", @"10"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"20"},
{@"Range", @"1000"},
{@"Knockback", @"8"},
{@"Spread", @"5°"},
},
        @"")},

{196, new ItemData(
        196,
        @"Fossilized Gun",
        @"""Proof That Guns Once Existed""",
        @"While fired, this gun will release a stream of oil on the floor
Reloading will cause the gun to spit fire, which can ignite the oil
UNLOCK: Unlock this weapon by purchasing it from Professor Goopton's store in The Breach for 12 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Professor Goopton's store in The Breach for 12 Hegemony Credits"},
{@"Type", @"Beam"},
{@"Max ammo", @"500"},
{@"Clip size", @"500"},
{@"Quality", @"D"},
{@"Damage", @"15 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"15"},
{@"Range", @"20"},
{@"Knockback", @"40"},
{@"Spread", @"0°"},
},
        @"")},

{87, new ItemData(
        87,
        @"Gamma Ray",
        @"""Mean Green""",
        @"Fires a continuous green laser, which has a chance to poison enemies
Poisoned enemies take damage over time for a short period
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 2 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 2 Hegemony Credits"},
{@"Type", @"Beam"},
{@"Max ammo", @"800"},
{@"Clip size", @"800"},
{@"Quality", @"C"},
{@"Damage", @"15 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"unknown"},
{@"Range", @"50"},
{@"Knockback", @"10"},
{@"Spread", @"0°"},
},
        @"")},

{40, new ItemData(
        40,
        @"Freeze Ray",
        @"""Ice To Meet You""",
        @"Fires a continuous blue laser, which has a chance to freeze enemies
Slowed enemies will have reduced movement speed. If applied multiple times, the enemy will freeze solid for a while. Dodge rolling into a frozen enemy will shatter it
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 7 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 7 Hegemony Credits"},
{@"Type", @"Beam"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"A"},
{@"Damage", @"20 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"60"},
{@"Range", @"30"},
{@"Knockback", @"10"},
{@"Spread", @"0°"},
},
        @"")},

{331, new ItemData(
        331,
        @"Science Cannon",
        @"""Charged Particles""",
        @"A gun which fires a large laser (requires a small time to spin-up before it will fire)
The laser can inflict random status effects on enemies (e.g. burn, freeze, poison)
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 6 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 6 Hegemony Credits"},
{@"Type", @"Beam"},
{@"Max ammo", @"500"},
{@"Clip size", @"500"},
{@"Quality", @"B"},
{@"Damage", @"26 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"90"},
{@"Range", @"500"},
{@"Knockback", @"35"},
{@"Spread", @"0°"},
},
        @"")},

{121, new ItemData(
        121,
        @"Disintegrator",
        @"""Return To Dust""",
        @"A gun which fires a large laser (requires a long time to spin-up before it will fire)",
        new Dictionary<string, string>(){
{@"Type", @"Beam"},
{@"Max ammo", @"500"},
{@"Clip size", @"500"},
{@"Quality", @"S"},
{@"Damage", @"70 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"120"},
{@"Range", @"50"},
{@"Knockback", @"0"},
{@"Spread", @"0°"},
},
        @"")},

{179, new ItemData(
        179,
        @"Proton Backpack",
        @"""Crossing Streams""",
        @"A gun which fires a homing laser, which will seek out and target nearby enemies
Deals bonus damage to ghosts and spectres",
        new Dictionary<string, string>(){
{@"Type", @"Beam"},
{@"Max ammo", @"500"},
{@"Clip size", @"500"},
{@"Quality", @"B"},
{@"Damage", @"50 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"14"},
{@"Range", @"90"},
{@"Knockback", @"30"},
{@"Spread", @"0°"},
},
        @"")},

{10, new ItemData(
        10,
        @"Mega Douser",
        @"""Contents Under Pressure""",
        @"A gun which fires a continuous stream of water, pushing enemies back slightly",
        new Dictionary<string, string>(){
{@"Type", @"Beam"},
{@"Max ammo", @"900"},
{@"Clip size", @"900"},
{@"Quality", @"D"},
{@"Damage", @"15 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"20"},
{@"Range", @"20"},
{@"Knockback", @"40"},
{@"Spread", @"0°"},
},
        @"")},

{208, new ItemData(
        208,
        @"Plunger",
        @"""Take Your Best Shot!""",
        @"Fires a continous stream of poison liquid, which has a chance to poison enemies
Poisoned enemies take damage over time for a short period
Cannot reveal secret rooms
UNLOCK: Unlock this weapon by purchasing it from Professor Goopton's store in The Breach for 7 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Professor Goopton's store in The Breach for 7 Hegemony Credits"},
{@"Type", @"Beam"},
{@"Max ammo", @"500"},
{@"Clip size", @"500"},
{@"Quality", @"C"},
{@"Damage", @"5 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"20"},
{@"Range", @"20"},
{@"Knockback", @"40"},
{@"Spread", @"0°"},
},
        @"")},

{107, new ItemData(
        107,
        @"Raiden Coil",
        @"""Shoot Em' Up""",
        @"A gun which fires a continuous laser which seeks out and damages all enemies currently on screen
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 8 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 8 Hegemony Credits"},
{@"Type", @"Beam"},
{@"Max ammo", @"500"},
{@"Clip size", @"500"},
{@"Quality", @"A"},
{@"Damage", @"15 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"unknown"},
{@"Range", @"30"},
{@"Knockback", @"10"},
{@"Spread", @"5°"},
},
        @"")},

{20, new ItemData(
        20,
        @"Moonscraper",
        @"""Beeeeoooowwww!""",
        @"Fires a continuous laser which will bounce off objects and walls and reflect back across the room",
        new Dictionary<string, string>(){
{@"Type", @"Beam"},
{@"Max ammo", @"500"},
{@"Clip size", @"500"},
{@"Quality", @"C"},
{@"Damage", @"26 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"unknown"},
{@"Range", @"50"},
{@"Knockback", @"20"},
{@"Spread", @"5°"},
},
        @"")},

{7, new ItemData(
        7,
        @"Barrel",
        @"""Nothin' Easier""",
        @"A gun that fires fish, which have a chance to stun enemies for a brief period of time",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"300"},
{@"Clip size", @"9"},
{@"Quality", @"C"},
{@"Damage", @"8"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"20"},
{@"Range", @"1000"},
{@"Knockback", @"13"},
{@"Spread", @"7°"},
},
        @"")},

{363, new ItemData(
        363,
        @"Trick Gun",
        @"""Reload To Transform""",
        @"A gun which will switch between a handgun and a shotgun after each reload",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"6"},
{@"Quality", @"C"},
{@"Damage", @"7 (handgun), 2 x 8 (16 total shotgun)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{28, new ItemData(
        28,
        @"Mailbox",
        @"""Special Delivery""",
        @"A gun that fires mail at enemies
The final shot of each clip is a parcel, which will contain a random effect (confetti, fire, poison or an explosion)
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 5 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 5 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @""},
{@"Quality", @"D"},
{@"Damage", @"5"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"22"},
{@"Range", @"1000"},
{@"Knockback", @"10"},
{@"Spread", @"10°"},
},
        @"")},

{26, new ItemData(
        26,
        @"Nail Gun",
        @"""Pest Control""",
        @"A semi-automatic gun that fires a lot of low damage nails very quickly",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"500"},
{@"Clip size", @""},
{@"Quality", @"D"},
{@"Damage", @"3"},
{@"Fire rate", @"0.12"},
{@"Shot speed", @"26"},
{@"Range", @"12"},
{@"Knockback", @"8"},
{@"Spread", @"10°"},
},
        @"")},

{27, new ItemData(
        27,
        @"Light Gun",
        @"""Third-Party""",
        @"A gun that fires flashes of light
The last bullet in each magazine is a duck, which will seek out the nearest enemy and deal damage to it
If you also have the Stuffed Star active item, the duck will gain a size and damage increase",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"150"},
{@"Clip size", @"6"},
{@"Quality", @"B"},
{@"Damage", @"7"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"400"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"5°"},
},
        @"")},

{339, new ItemData(
        339,
        @"Mahoguny",
        @"""100% Organic""",
        @"A gun that fires damaging leaves and bouncy wooden bullets at the same time",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @"10"},
{@"Quality", @"C"},
{@"Damage", @"5 (bullet), 10 (explosion), 4 (leaves)"},
{@"Fire rate", @"0.4"},
{@"Shot speed", @"15"},
{@"Range", @"30"},
{@"Knockback", @"20"},
{@"Spread", @"0°"},
},
        @"")},

{445, new ItemData(
        445,
        @"The Scrambler",
        @"""Bullet Or The Gun?""",
        @"A single clip gun that fires eggs
Upon hitting an enemy or object, the egg will hatch into a cluster of homing bullets, which will seek out and attack the nearest enemy",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"120"},
{@"Clip size", @"1"},
{@"Quality", @"C"},
{@"Damage", @"6 (egg), 9 x 5 (homing bullets)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{154, new ItemData(
        154,
        @"Trashcannon",
        @"""Take It Out!""",
        @"A gun that fires trash, sending poison in all directions
Poisoned enemies take damage over time for a short period
Can prove to be dangerous and leave poison in unpredictable spots
UNLOCK: Unlock this weapon by reaching the Oubilette floor",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by reaching the Oubilette floor"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @"1"},
{@"Quality", @"C"},
{@"Damage", @"20"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"20"},
{@"Range", @"1000"},
{@"Knockback", @"20"},
{@"Spread", @"5°"},
},
        @"")},

{130, new ItemData(
        130,
        @"Glacier",
        @"""Refill Your Trays""",
        @"A gun that fires bouncy ice cubes that explode and freeze enemies
Frozen enemies will be unable to move for a short period of time. Dodge rolling into a frozen enemy will shatter it",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"120"},
{@"Clip size", @"12"},
{@"Quality", @"A"},
{@"Damage", @"8 (ice cube), 6 (explosion)"},
{@"Fire rate", @"0.5"},
{@"Shot speed", @"18"},
{@"Range", @"35"},
{@"Knockback", @"8"},
{@"Spread", @"5°"},
},
        @"")},

{477, new ItemData(
        477,
        @"Origuni",
        @"""Thousand Cuts""",
        @"A gun that fires piercing paper airplanes, which will shoot out and follow the player's mouse cursor",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"300"},
{@"Clip size", @"8"},
{@"Quality", @"C"},
{@"Damage", @"7.5"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{152, new ItemData(
        152,
        @"The Kiln",
        @"""Fires Pots""",
        @"A gun that fires pots, which upon contact with an enemy or object will break into three bouncy crystals",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"8"},
{@"Quality", @"C"},
{@"Damage", @"8 (pots), 4 (crystals)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{45, new ItemData(
        45,
        @"Skull Splitter",
        @"""Hard Headed""",
        @"Fires homing skulls
A semi-automatic gun that fires homing skulls, which will deviate from their normal path to seek out and damage enemies",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"150"},
{@"Clip size", @"10"},
{@"Quality", @"C"},
{@"Damage", @"10"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{341, new ItemData(
        341,
        @"Buzzkill",
        @"""Sawed On!""",
        @"A semi-automatic gun that fires piercing bouncy sawblades",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @"12"},
{@"Quality", @"C"},
{@"Damage", @"7"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"25"},
{@"Range", @"1000"},
{@"Knockback", @"10"},
{@"Spread", @"5°"},
},
        @"")},

{33, new ItemData(
        33,
        @"Tear Jerker",
        @"""Q_Q""",
        @"A gun that fires tears, which leave a puddle of water on the ground
Tears will shoot slightly to the side depending on which direction the player is currently moving
A reference to The Binding of Isaac, a similar game where tears are the primary weapon",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"100"},
{@"Clip size", @"20"},
{@"Quality", @"C"},
{@"Damage", @"7"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{90, new ItemData(
        90,
        @"Eye of the Beholster",
        @"""What A Beauty!""",
        @"A gun that fires quick lasers
The last shot in each magazine spawns a friendly Beadie familiar",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"B"},
{@"Damage", @"6"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"200"},
{@"Range", @"1000"},
{@"Knockback", @"4"},
{@"Spread", @"4°"},
},
        @"")},

{292, new ItemData(
        292,
        @"Molotov Launcher",
        @"""Exactly What You Think""",
        @"A gun that fires molotov cocktails, which create a large area of fire on the ground where it lands
Burned enemies take damage over time for a short period",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"80"},
{@"Clip size", @"1"},
{@"Quality", @"C"},
{@"Damage", @"6"},
{@"Fire rate", @"1.5"},
{@"Shot speed", @"18"},
{@"Range", @"35"},
{@"Knockback", @"13"},
{@"Spread", @"5°"},
},
        @"")},

{153, new ItemData(
        153,
        @"Shock Rifle",
        @"""Zap""",
        @"A gun that fires zaps of electricity",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"250"},
{@"Clip size", @"15"},
{@"Quality", @"B"},
{@"Damage", @"8"},
{@"Fire rate", @"0.2"},
{@"Shot speed", @"140"},
{@"Range", @"1000"},
{@"Knockback", @"20"},
{@"Spread", @"5°"},
},
        @"")},

{369, new ItemData(
        369,
        @"Bait Launcher",
        @"""Meat Your Maker""",
        @"A gun that fires steaks, which cause a tiger to appear and attack nearby enemies
UNLOCK: Unlock this weapon by defeating the High Dragun with Beastmode turned on",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by defeating the High Dragun with Beastmode turned on"},
{@"Type", @"Charged"},
{@"Max ammo", @"60"},
{@"Clip size", @"1"},
{@"Quality", @"C"},
{@"Damage", @"10"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{376, new ItemData(
        376,
        @"Brick Breaker",
        @"""Wrong Kind Of Mortar""",
        @"A gun that fires bouncy piercing green turtle shells
If you also have the Stuffed Star active item, the shells from this gun gain a size and damage increase
UNLOCK: Unlock this weapon by completing the Keep of a Lead Lord (Chamber #1) 50 times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing the Keep of a Lead Lord (Chamber #1) 50 times"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"5"},
{@"Quality", @"C"},
{@"Damage", @"10"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{380, new ItemData(
        380,
        @"Betrayer's Shield",
        @"""Actually A Gun""",
        @"A gun which generates a protective shield upon reloading, that blocks enemy bullets
The shield is destroyed after it has blocked a number of enemy bullets
UNLOCK: Unlock this weapon by defeating Blockner, a secret boss found in the Black Powder Mine (Chamber #3)",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by defeating Blockner, a secret boss found in the Black Powder Mine (Chamber #3)"},
{@"Type", @"Automatic"},
{@"Max ammo", @"350"},
{@"Clip size", @"12"},
{@"Quality", @"B"},
{@"Damage", @"6"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"23"},
{@"Range", @"18"},
{@"Knockback", @"12"},
{@"Spread", @"5°"},
},
        @"")},

{340, new ItemData(
        340,
        @"Lower Case r",
        @"""Alphabetical!""",
        @"A burst gun that fires 6 bullets at a time, which spell out the word 'bullet' in uppercase (B U L L E T)",
        new Dictionary<string, string>(){
{@"Type", @"Burst"},
{@"Max ammo", @"900"},
{@"Clip size", @"36"},
{@"Quality", @"D"},
{@"Damage", @"2.222"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"25"},
{@"Range", @"1000"},
{@"Knockback", @"14"},
{@"Spread", @"0°"},
},
        @"")},

{377, new ItemData(
        377,
        @"Excaliber",
        @"""Once And Future""",
        @"Fires a burst of three piercing sword projectiles. Reloading swings the sword, destroying nearby bullets
Curse Up while held
UNLOCK: Unlock this weapon by mapping the first 5 chambers for The Lost Adventurer",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by mapping the first 5 chambers for The Lost Adventurer"},
{@"Type", @"Burst"},
{@"Max ammo", @"280"},
{@"Clip size", @"32"},
{@"Quality", @"B"},
{@"Damage", @"7"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"26"},
{@"Range", @"1000"},
{@"Knockback", @"15"},
{@"Spread", @"0°"},
},
        @"")},

{149, new ItemData(
        149,
        @"Face Melter",
        @"""Squiddley-squiddley-wheeyooo!""",
        @"Rapidly fires musical notes in all four directions around the player
Upon reloading, places an amplifier on the ground, which will also fire musical notes in the same pattern
Reloading again will delete the current amplifier and place another
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 10 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 10 Hegemony Credits"},
{@"Type", @"Automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"B"},
{@"Damage", @"3"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"15"},
{@"Range", @"15"},
{@"Knockback", @"13"},
{@"Spread", @"6°"},
},
        @"")},

{444, new ItemData(
        444,
        @"Trident",
        @"""Under The Sea""",
        @"Fires a piercing magic beam which damages enemies
Reloading causes the Trident to destroy nearby bullets and projectiles",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @""},
{@"Quality", @"A"},
{@"Damage", @"8"},
{@"Fire rate", @"0.08"},
{@"Shot speed", @"600"},
{@"Range", @"1000"},
{@"Knockback", @"4"},
{@"Spread", @"0°"},
},
        @"")},

{474, new ItemData(
        474,
        @"Abyssal Tentacle",
        @"""Look Away""",
        @"A gun that fires a tentacle which homes in on enemies and grips them, dealing damage
This gun can grip enemies through walls
UNLOCK: Unlock this weapon by purchasing it from Professor Goopton's store in The Breach for 15 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Professor Goopton's store in The Breach for 15 Hegemony Credits"},
{@"Type", @"Beam"},
{@"Max ammo", @"500"},
{@"Clip size", @"500"},
{@"Quality", @"A"},
{@"Damage", @"22.5 per second"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"unknown"},
{@"Range", @"30"},
{@"Knockback", @"10"},
{@"Spread", @"0°"},
},
        @"")},

{475, new ItemData(
        475,
        @"Quad Laser",
        @"""No One Can Defeat It""",
        @"A semi-automatic gun that fires a large, square bullet which moves very slowly",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"50"},
{@"Clip size", @"1"},
{@"Quality", @"C"},
{@"Damage", @"80"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{336, new ItemData(
        336,
        @"Pitchfork",
        @"""Get Forked!""",
        @"Rapidly fires fireballs which have a chance to Burn enemies
Burned enemies take damage over time for a short period",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"200"},
{@"Quality", @"C"},
{@"Damage", @"4"},
{@"Fire rate", @"0.15"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"35"},
{@"Spread", @"5°"},
},
        @"")},

{176, new ItemData(
        176,
        @"Gungeon Ant",
        @"""What Army?""",
        @"Reloading alternates between firing spreads of bullets that leave behind oil and flaming bullets
A gun with two modes, which can be swapped between by reloading
Mode #1: Fires a spread of bullets which leave behind oil
Mode #2: Fires flaming bullets",
        new Dictionary<string, string>(){
{@"Mode #1", @"Fires a spread of bullets which leave behind oil"},
{@"Mode #2", @"Fires flaming bullets"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"100"},
{@"Clip size", @"6"},
{@"Quality", @"C"},
{@"Damage", @"2 x 3 (6 total oil damage), 1.5 x 3 (4.5 total fire damage)"},
{@"Fire rate", @""},
{@"Shot speed", @"26"},
{@"Range", @"1000"},
{@"Knockback", @"25"},
{@"Spread", @"0°"},
},
        @"")},

{177, new ItemData(
        177,
        @"Alien Engine",
        @"""The Dangerzone""",
        @"A gun with a very short range, which propels the player backwards while firing
Only enemies inside the energy flash will be damaged",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"1000"},
{@"Clip size", @"1000"},
{@"Quality", @"B"},
{@"Damage", @"10"},
{@"Fire rate", @"0.02"},
{@"Shot speed", @"30"},
{@"Range", @"3"},
{@"Knockback", @"10"},
{@"Spread", @"0°"},
},
        @"")},

{476, new ItemData(
        476,
        @"Microtransaction Gun",
        @"""Pay To Win""",
        @"A gun which fires gems, books, and dolls of the Gungeoneers in exchange for one money per shot.
The gun can shoot any of the following things:
Marine figurine: Piercing and bouncy, deals 20 damage
Pilot figurine: Opens locks, deals 15 damage
Convict figurine: Molotov effect on impact, deals 15 damage
Hunter figurine: Homing effect, deals 15 damage
Bulletkin figurine: Charms enemies, deals 8 damage
Green crystal: Deals 15 damage
A book, deals 2 damage
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 100 Hegemony Credits",
        new Dictionary<string, string>(){
{@"Marine figurine", @"Piercing and bouncy, deals 20 damage"},
{@"Pilot figurine", @"Opens locks, deals 15 damage"},
{@"Convict figurine", @"Molotov effect on impact, deals 15 damage"},
{@"Hunter figurine", @"Homing effect, deals 15 damage"},
{@"Bulletkin figurine", @"Charms enemies, deals 8 damage"},
{@"Green crystal", @"Deals 15 damage"},
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 100 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"n/a"},
{@"Clip size", @"Same as your number of held coins"},
{@"Quality", @"A"},
{@"Damage", @"Various, see above"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{513, new ItemData(
        513,
        @"Poxcannon",
        @"""Lousy T-Shirt""",
        @"A gun which fires poisonous t-shirts
Enemies poisoned by this gun leave a pool of poison behind when they die
Poisoned enemies take damage over time for a short period",
        new Dictionary<string, string>(){
{@"Type", @"n/a"},
{@"Max ammo", @"n/a"},
{@"Clip size", @"n/a"},
{@"Quality", @"C"},
{@"Damage", @"15"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{150, new ItemData(
        150,
        @"T-Shirt Cannon",
        @"""Machine Gun Wash Only!""",
        @"Fires t-shirts that deal significant knockback to enemies",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"250"},
{@"Clip size", @"6"},
{@"Quality", @"D"},
{@"Damage", @"8"},
{@"Fire rate", @"0.35"},
{@"Shot speed", @"25"},
{@"Range", @"1000"},
{@"Knockback", @"60"},
{@"Spread", @"5°"},
},
        @"")},

{478, new ItemData(
        478,
        @"Banana",
        @"""Planpain""",
        @"A gun which is charged up and releases an explosive banana, which splits into three more bouncy explosive bananas",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"55"},
{@"Clip size", @"7"},
{@"Quality", @"C"},
{@"Damage", @"10 (impact), 30 (explosion)"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{14, new ItemData(
        14,
        @"Bee Hive",
        @"""Bzzzzzzz!""",
        @"Fires a continuous stream of damaging bees, which home in on enemies",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"300"},
{@"Clip size", @"300"},
{@"Quality", @"B"},
{@"Damage", @"3"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"9"},
{@"Range", @"1000"},
{@"Knockback", @"2"},
{@"Spread", @"90°"},
},
        @"")},

{335, new ItemData(
        335,
        @"Silencer",
        @"""300 Dead Count""",
        @"Fires pillows
Hitting an enemy while swinging the weapon will stun enemies",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"200"},
{@"Clip size", @"8"},
{@"Quality", @"C"},
{@"Damage", @"13"},
{@"Fire rate", @"0.6"},
{@"Shot speed", @"23"},
{@"Range", @"60"},
{@"Knockback", @"30"},
{@"Spread", @"5°"},
},
        @"")},

{481, new ItemData(
        481,
        @"Camera",
        @"""Say Cheese""",
        @"A gun which is charged up and when released, deals damage to all enemies in the current room
The camera flash also knocks back and has a chance to stun enemies",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"60"},
{@"Clip size", @"4"},
{@"Quality", @"C"},
{@"Damage", @"10"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{482, new ItemData(
        482,
        @"Gunzheng",
        @"""Hustle""",
        @"A gun that fires a continuous stream of thick arrows without the need to reload
UNLOCK: Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill the Kill Pillars boss 3 times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill the Kill Pillars boss 3 times"},
{@"Type", @"Automatic"},
{@"Max ammo", @"800"},
{@"Clip size", @"350"},
{@"Quality", @"B"},
{@"Damage", @"6"},
{@"Fire rate", @"0.07"},
{@"Shot speed", @"32"},
{@"Range", @"1000"},
{@"Knockback", @"8"},
{@"Spread", @"35°"},
},
        @"")},

{382, new ItemData(
        382,
        @"Sling",
        @"""Outrageous!""",
        @"Sling allows you to charge up and fire a rock which deals a lot of damage.
Each rock can bounce off a wall once before falling. If a rock hits an enemy after bouncing, it will deal 2.5x damage
A very strong weapon to quickly kill early-game bosses and will kill all weak enemies in one hit in the first few chambers.
UNLOCK: Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 200 Bullet Kins",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 200 Bullet Kins"},
{@"Type", @"Charged"},
{@"Max ammo", @"80"},
{@"Clip size", @"1"},
{@"Quality", @"D"},
{@"Damage", @"25"},
{@"Fire rate", @"0.1"},
{@"Shot speed", @"23"},
{@"Range", @"1000"},
{@"Knockback", @"35"},
{@"Spread", @"0°"},
},
        @"")},

{124, new ItemData(
        124,
        @"Cactus",
        @"""1000 Needles!""",
        @"An automatic gun that fires needles with a very high rate of fire, but low damage",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"1000"},
{@"Clip size", @"1000"},
{@"Quality", @"C"},
{@"Damage", @"2.5"},
{@"Fire rate", @"n/a"},
{@"Shot speed", @"unknown"},
{@"Range", @"n/a"},
{@"Knockback", @"n/a"},
{@"Spread", @"n/a°"},
},
        @"")},

{169, new ItemData(
        169,
        @"Black Hole Gun",
        @"""Won't You Come""",
        @"A charged gun which fires black holes
Black holes attract enemies and their bullets
UNLOCK: Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 20 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Ox and Cadence's store in The Breach for 20 Hegemony Credits"},
{@"Type", @"Charged"},
{@"Max ammo", @"30"},
{@"Clip size", @"1"},
{@"Quality", @"A"},
{@"Damage", @"10"},
{@"Fire rate", @"1"},
{@"Shot speed", @"4"},
{@"Range", @"1000"},
{@"Knockback", @"9"},
{@"Spread", @"0°"},
},
        @"")},

{21, new ItemData(
        21,
        @"BSG",
        @"""Big Shooty Gun""",
        @"Slowly charges up to fire a large high-damage projectile
A gun which is charged up very slowly and fires a large green bullet which explodes after reaching maximum range, dealing a huge amount of damage to all enemies in the room
The bullet will bounce from a wall once before detonating, but will disappear if it bounces more than once before exploding
Will pierce enemies but deal damage to them
Very good at clearing rooms full of enemies",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"25"},
{@"Clip size", @"1"},
{@"Quality", @"S"},
{@"Damage", @"50"},
{@"Fire rate", @"4"},
{@"Shot speed", @"25"},
{@"Range", @"1000"},
{@"Knockback", @"10"},
{@"Spread", @"0°"},
},
        @"")},

{359, new ItemData(
        359,
        @"Compressed Air Tank",
        @"""You Know My Work""",
        @"A gun that fires sharks
The sharks will swim around the room and home in on enemies, eating them whole
Cannot kill bosses in one go
UNLOCK: Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 40 Bullet Sharks",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 40 Bullet Sharks"},
{@"Type", @"Charged"},
{@"Max ammo", @"50"},
{@"Clip size", @"1"},
{@"Quality", @"A"},
{@"Damage", @"50"},
{@"Fire rate", @"0.6"},
{@"Shot speed", @"35"},
{@"Range", @"1000"},
{@"Knockback", @"60"},
{@"Spread", @"6°"},
},
        @"")},

{37, new ItemData(
        37,
        @"Serious Cannon",
        @"""Seriously MENTAL""",
        @"A cannon which fires large bouncy, piercing cannonballs which deal high damage",
        new Dictionary<string, string>(){
{@"Type", @"Charged"},
{@"Max ammo", @"30"},
{@"Clip size", @"1"},
{@"Quality", @"A"},
{@"Damage", @"50"},
{@"Fire rate", @"0.6"},
{@"Shot speed", @"35"},
{@"Range", @"1000"},
{@"Knockback", @"60"},
{@"Spread", @"6°"},
},
        @"")},

{480, new ItemData(
        480,
        @"Makeshift Cannon",
        @"""You Only Get One Shot""",
        @"A charged gun that fires a blast of various colored balls that deal very high damage
UNLOCK: Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 30 Shroomers",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by completing a hunting quest for Frifle and Grey Mauser to kill 30 Shroomers"},
{@"Type", @"Charged"},
{@"Max ammo", @"1"},
{@"Clip size", @"1"},
{@"Quality", @"S"},
{@"Damage", @"1213.3 (ish)"},
{@"Fire rate", @"0.50"},
{@"Shot speed", @"35"},
{@"Range", @"1000"},
{@"Knockback", @"60"},
{@"Spread", @"6°"},
},
        @"")},

{520, new ItemData(
        520,
        @"Balloon Gun",
        @"""Hot Air""",
        @"A gun that fires small tornados which home in on enemies
Grants flight while held
Loses all of its ammo if the player is hit while holding it",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"250"},
{@"Clip size", @"10"},
{@"Quality", @"C"},
{@"Damage", @"12"},
},
        @"")},

{503, new ItemData(
        503,
        @"Bullet",
        @"""Fires Guns""",
        @"A semi-automatic gun that fires rotating guns, which fire streams of bullets",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"250"},
{@"Clip size", @"6"},
{@"Quality", @"C"},
{@"Damage", @"7 (Gun projectile), 4 (Bullets)"},
},
        @"")},

{541, new ItemData(
        541,
        @"Casey",
        @"""Batting .50""",
        @"A melee weapon that allows you to charge up and swing to damage nearby enemies and reflect enemy bullets
Killed enemies' bodies will fly across the room and deal damage to any enemies they hit
+2 Curse Up
Cannot be fed to a gun muncher
UNLOCK: Unlock this weapon by purchasing it from Doug for 12 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Doug for 12 Hegemony Credits"},
{@"Type", @"Charged"},
{@"Max ammo", @"Infinite"},
{@"Clip size", @"1"},
{@"Quality", @"D"},
{@"Damage", @"100"},
},
        @"")},

{551, new ItemData(
        551,
        @"Crown of Guns",
        @"""All Hail""",
        @"An automatic gun that rapidly fires bullets in all directions, which will home slightly towards enemies
Fires and consumes 3 bullets per shot",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"3000"},
{@"Clip size", @"3000"},
{@"Fire rate", @"who cares, its heckin fast"},
{@"Quality", @"C"},
{@"Damage", @"5.5"},
},
        @"")},

{484, new ItemData(
        484,
        @"Devolver",
        @"""Degenerates""",
        @"Bullets from this gun have a chance to devolve enemies into less powerful enemies
Most enemies will be devolved into Shotgun Kin. Shotgun Kin will be devolved into Bullet Kin. Bullet Kin will be devolved into Arrowkin
UNLOCK: Unlock this weapon by purchasing it from Doug for 10 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Doug for 10 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"100"},
{@"Clip size", @"6"},
{@"Quality", @"C"},
{@"Damage", @"6"},
},
        @"")},

{514, new ItemData(
        514,
        @"Directional Pad",
        @"""Input Output""",
        @"This gun fires bullets in four directions at once.
When all ammo is consumed, the gun is deleted and will spawn a random chest of any quality
Pressing certain button combos will cause special effects. Pressing down, right and fire quickly will cause the gun to fire a ball of fire that deals 45 damage.Pressing left, left and fire will fire a grappling hook",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"120"},
{@"Clip size", @"30"},
{@"Quality", @"B"},
{@"Damage", @"8 (Bullets), 45 (Fireball), Hook (10)"},
},
        @"")},

{508, new ItemData(
        508,
        @"Dueling Laser",
        @"""More Interesting This Way!""",
        @"A gun which fires a high-damage piercing laser.
The recharge of this gun acts similar to an active item, meaning it must charge up by dealing damage to enemies
UNLOCK: Unlock this gun by purchasing it from Doug for 20 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this gun by purchasing it from Doug for 20 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"Infinite"},
{@"Clip size", @"1"},
{@"Quality", @"B"},
{@"Damage", @"100"},
},
        @"")},

{504, new ItemData(
        504,
        @"Hyper Light Blaster",
        @"""Skill Honed Sharp""",
        @"A gun which starts with a very low max ammo count, however successfully hitting an enemy will restore 1 ammo.
UNLOCK: Unlock this weapon by purchasing it from Doug for 22 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Doug for 22 Hegemony Credits"},
{@"Max ammo", @"12"},
{@"Clip size", @"12"},
{@"Quality", @"B"},
{@"Damage", @"20"},
},
        @"")},

{515, new ItemData(
        515,
        @"Mourning Star",
        @"""Satellite Rain""",
        @"A gun which fires a laser sight, which will call down a high-damage orbital strike at the location of an enemy when targeting it for a short time.
The beam persists while the trigger is held, and it will slowly move in the direction of the player's crosshair
UNLOCK: Unlock this weapon by purchasing it from Doug for 22 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Doug for 22 Hegemony Credits"},
{@"Type", @"Beam"},
{@"Max ammo", @"800"},
{@"Clip size", @"800"},
{@"Quality", @"S"},
},
        @"")},

{566, new ItemData(
        566,
        @"Rad Gun",
        @"""Totally Rad""",
        @"Reloading this gun now shows a marker on the reload bar, similar to the Cog of Battle mechanic. Reloading at when the bar lines up will decrease the next reload time and increase damage.
Stacking many successful reloads will cause fired projectiles to grow in size and eventually wear shades.
Damage increases are roughly double for the first 4 reloads, and increase past that infinitely but at a slower rate.
Failing a reload will reset the damage bonus
+2 Coolness",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"250"},
{@"Clip size", @"12"},
{@"Quality", @"B"},
{@"Damage", @"Starts at 4, increasing with each successful active reload"},
},
        @"")},

{576, new ItemData(
        576,
        @"Robot's Left Hand",
        @"""See You Later""",
        @"A gun that rapidly fires blue lasers
UNLOCK: Unlock this gun by killing The Robot's past",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this gun by killing The Robot's past"},
{@"Type", @"Automatic"},
{@"Quality", @"A"},
},
        @"")},

{512, new ItemData(
        512,
        @"Shell",
        @"""Fires Shotguns""",
        @"A semi-automatic gun that fires several shotguns with each shot.
Each fired shotgun will also fire several bullets upon hitting an enemy of obstacle",
        new Dictionary<string, string>(){
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"150"},
{@"Clip size", @"6"},
{@"Quality", @"B"},
{@"Damage", @"2x4 (Bullets), 3x8 (Shotguns)"},
},
        @"")},

{507, new ItemData(
        507,
        @"Starpew",
        @"""Reap And Sow""",
        @"A charged gun that fires drops of water.
Increases in charge with each drop of water fired:
No charge: 1 drop
1 charge: 1 row of 3 drop
2 charges: 1 row of 5 drop
3 charges: 3 rows of 3 drop
Fully charged: 3 rows of 6 drop
UNLOCK: Unlock this weapon by purchasing it from Doug for 20 Hegemony Credits",
        new Dictionary<string, string>(){
{@"No charge", @"1 drop"},
{@"1 charge", @"1 row of 3 drop"},
{@"2 charges", @"1 row of 5 drop"},
{@"3 charges", @"3 rows of 3 drop"},
{@"Fully charged", @"3 rows of 6 drop"},
{@"UNLOCK", @"Unlock this weapon by purchasing it from Doug for 20 Hegemony Credits"},
{@"Type", @"Charged"},
{@"Max ammo", @"100"},
{@"Clip size", @"100"},
{@"Quality", @"A"},
{@"Damage", @"5"},
},
        @"")},

{542, new ItemData(
        542,
        @"Strafe Gun",
        @"""Bleeding Edge Gameplay""",
        @"A gun which fires nails
Releasing the trigger will detonate the nails, however they will also automatically explode after a short amount of time
Can cause enemies to appear to bleed, however this is a cosmetic effect only
UNLOCK: Unlock this weapon by purchasing it from Doug for 26 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Doug for 26 Hegemony Credits"},
{@"Type", @"Automatic"},
{@"Max ammo", @"400"},
{@"Clip size", @"20"},
{@"Quality", @"S"},
{@"Damage", @"1 (on hit), 8 (in explosion radius)"},
},
        @"")},

{537, new ItemData(
        537,
        @"Vorpal Gun",
        @""".50 Critical""",
        @"A semi-automatic gun that fires bullets and has a chance to fire a 'critical' shot that deals 100 damage.
The chance to fire a critical shot is based on your Coolness stat
UNLOCK: Unlock this gun by purchasing it from Doug for 20 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this gun by purchasing it from Doug for 20 Hegemony Credits"},
{@"Type", @"Automatic"},
{@"Max ammo", @"250"},
{@"Clip size", @"6"},
{@"Quality", @"B"},
{@"Damage", @"5 (normal), 100 (critical)"},
},
        @"")},

{545, new ItemData(
        545,
        @"AC-15",
        @"""Armor Class Non-Zero""",
        @"An automatic gun that becomes more powerful when you have armor
The power increase can also be activated by having the Nanomachines item (Synergy)",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"300"},
{@"Clip size", @"40"},
{@"Quality", @"B"},
{@"Damage", @"3.8 (No armor), 15 (With armor)"},
},
        @"")},

{601, new ItemData(
        601,
        @"Big Shotgun",
        @"""A Shotgun That's Big""",
        @"Shoots 3 huge bullets that each explode
Reloading the gun next to any type of Shotgun Kin and Shotgats (the shotgun bat enemies) will suck them up, killing them and giving you +1 ammo.
UNLOCK: Unlock this weapon by purchasing it from Doug for 26 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Doug for 26 Hegemony Credits"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"50"},
{@"Clip size", @"4"},
{@"Quality", @"A"},
{@"Damage", @"n/a"},
},
        @"")},

{539, new ItemData(
        539,
        @"Boxing Glove",
        @"""Pistol Hondo""",
        @"Shoots boxing gloves that have a chance to stun enemies
Killing an enemy with this gun gives you a star. At 3 stars the gun can be charged to consume them and fire a highly powered glove
+1 Curse Up
UNLOCK: Unlock this weapon by beating phase 1 & 2 of the Resourceful Rat boss",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by beating phase 1 & 2 of the Resourceful Rat boss"},
{@"Type", @"Charged"},
{@"Max ammo", @"350"},
{@"Quality", @"C"},
{@"Damage", @"12 (3 star punch deals 200 damage)"},
},
        @"")},

{599, new ItemData(
        599,
        @"Bubble Blaster",
        @"""The Suds""",
        @"Rapidly shoots bubbles which travel slowly across the room
Creates a pool of water when a bubble hits an enemy
Reloading causes bubbles to be pushed forwards",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"500"},
{@"Clip size", @""},
{@"Quality", @"C"},
{@"Damage", @""},
},
        @"")},

{519, new ItemData(
        519,
        @"Combined Rifle",
        @"""Halve Lives""",
        @"An automatic gun with 2 modes: Rapid fire pulse blasts and a piercing bouncy dark energy ball.
Reloading switches between the 2 modes.
UNLOCK: Unlock this weapon by purchasing it from Doug for 26 Hegemony Credits",
        new Dictionary<string, string>(){
{@"An automatic gun with 2 modes", @"Rapid fire pulse blasts and a piercing bouncy dark energy ball."},
{@"UNLOCK", @"Unlock this weapon by purchasing it from Doug for 26 Hegemony Credits"},
{@"Type", @"Automatic"},
{@"Max ammo", @"500"},
{@"Clip size", @"30 (Pulse mode) 1 (Energy mode)"},
{@"Quality", @"B"},
},
        @"")},

{626, new ItemData(
        626,
        @"Elimentaler",
        @"""Full of Holes""",
        @"A gun which 'encheeses' enemies, freezing them in a block of cheese
Enemies killed while frozen spawn a pool of cheese that encheese other enemies that touch it
Can be found in one of the chests that appear after the Resourceful Rat boss fight. After finding it there once it can be found elsewhere too
UNLOCK: Unlock this weapon by finding it in a chest after defeating the Resourceful Rat",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by finding it in a chest after defeating the Resourceful Rat"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"Infinite"},
{@"Quality", @"S"},
},
        @"")},

{563, new ItemData(
        563,
        @"The Exotic",
        @"""Pack of Wolves""",
        @"Fires homing rockets that erupt into short-range swarms of smaller homing rockets
While held gives you a ghost friend, which reveals the contents of unopened chests
UNLOCK: Unlock this weapon by purchasing it from Doug for 26 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Doug for 26 Hegemony Credits"},
{@"Quality", @"A"},
},
        @"")},

{670, new ItemData(
        670,
        @"High Dragunfire",
        @"""Pre-Rendered""",
        @"Rapid fire gun with burning bullets that ignite enemies
Each time you find this gun in the secret room the NPCs will have different dialogue
UNLOCK: Unlock this weapon by finding it in a secret room",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by finding it in a secret room"},
{@"Type", @"Automatic"},
{@"Quality", @"S"},
},
        @"")},

{595, new ItemData(
        595,
        @"Life Orb",
        @"""Value For Effort""",
        @"Fires purple lightning which targets the nearest enemy and deals damage
After killing an enemy, an icon will appear meaning the next time you reload this gun, damage is dealt to all enemies in the room
UNLOCK: Unlock this weapon by using the Blood Shrine 2 times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by using the Blood Shrine 2 times"},
{@"Type", @"Beam"},
{@"Max ammo", @"600"},
{@"Clip size", @"600"},
{@"Quality", @"A"},
{@"Damage", @""},
},
        @"")},

{734, new ItemData(
        734,
        @"Mimic Gun",
        @"",
        @"Randomly replaces another gun
You won't be able to switch to other guns or drop Mimic Gun until you either pick up ammo or fully use its ammo
Bullets that touch enemy bullets turn them into jammed bullets that deal a full heart of damage
UNLOCK: Unlock this weapon by killing an enemy using the Blood Shrine's drain effect",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by killing an enemy using the Blood Shrine's drain effect"},
{@"Max ammo", @"900"},
{@"Clip size", @"8"},
},
        @"")},

{597, new ItemData(
        597,
        @"Mr. Accretion Jr.",
        @"""Music of the Spheres""",
        @"Fires planets from our solar system, each one with a different effect on enemies
Mercury: Sometimes ignits enemies
Venus: No special effect
Earth: Sometimes poisons enemies
Mars: Sometimes ignits enemies
Jupiter: Explodes (doesn't hurt you)
Saturn: No special effect
Uranus: Sometimes freezes enemies
Neptune: Sometimes freezes enemies
Planets that hit a wall or obstacle will then start orbiting the player",
        new Dictionary<string, string>(){
{@"Mercury", @"Sometimes ignits enemies"},
{@"Venus", @"No special effect"},
{@"Earth", @"Sometimes poisons enemies"},
{@"Mars", @"Sometimes ignits enemies"},
{@"Jupiter", @"Explodes (doesn't hurt you)"},
{@"Saturn", @"No special effect"},
{@"Uranus", @"Sometimes freezes enemies"},
{@"Neptune", @"Sometimes freezes enemies"},
{@"Type", @"Semi-automatic"},
{@"Max ammo", @"100"},
{@"Clip size", @"20"},
{@"Quality", @"B"},
{@"Damage", @""},
},
        @"")},

{609, new ItemData(
        609,
        @"Rubenstein's Monster",
        @"""Unit 00""",
        @"Rapidly fires powerful rifle lasers that can ricochet off walls one time
Created by combining RUBE-ADYNE prototype and MK.II",
        new Dictionary<string, string>(){
{@"Type", @"Automatic"},
{@"Max ammo", @"900"},
{@"Clip size", @"100"},
{@"Quality", @""},
{@"Damage", @"7"},
},
        @"")},

{598, new ItemData(
        598,
        @"Stone Dome",
        @"""Big Head Mode""",
        @"An automatic gun that spits out homing bullets rapidly
Has a chance to fear enemies nearby, causing them to run away
UNLOCK: Unlock this weapon by purchasing it from Doug for 26 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by purchasing it from Doug for 26 Hegemony Credits"},
{@"Type", @"Automatic"},
{@"Max ammo", @"750"},
{@"Clip size", @"750"},
{@"Quality", @"B"},
},
        @"")},

{610, new ItemData(
        610,
        @"Wood Beam",
        @"""Speak Softly""",
        @"A 'gun' that extends when fired, allowing you to hit enemies with it
+1 Curse Up
UNLOCK: Unlock this weapon by giving health to the Vampire 3 times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this weapon by giving health to the Vampire 3 times"},
{@"Type", @"It's not even a gun"},
{@"Quality", @"B"},
{@"Damage", @""},
},
        @"")},

{469, new ItemData(
        469,
        @"Master Round I",
        @"""First Chamber""",
        @"+1 Health Up
Gives one piece of armour to The Robot character
Dropped by killing the boss in the first chamber without taking damage",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"n/a"},
},
        @"")},

{471, new ItemData(
        471,
        @"Master Round II",
        @"""Second Chamber""",
        @"+1 Health Up
Gives one piece of armour to The Robot character
Dropped by killing the boss in the second chamber without taking damage",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"n/a"},
},
        @"")},

{468, new ItemData(
        468,
        @"Master Round III",
        @"""Third Chamber""",
        @"+1 Health Up
Gives one piece of armour to The Robot character
Dropped by killing the boss in the third chamber without taking damage",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"n/a"},
},
        @"")},

{470, new ItemData(
        470,
        @"Master Round IV",
        @"""Fourth Chamber""",
        @"+1 Health Up
Gives one piece of armour to The Robot character
Dropped by killing the boss in the fourth chamber without taking damage",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"n/a"},
},
        @"")},

{467, new ItemData(
        467,
        @"Master Round V",
        @"""Fifth Chamber""",
        @"+1 Health Up
Gives one piece of armour to The Robot character
Dropped by killing the boss in the fifth chamber without taking damage",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"n/a"},
},
        @"")},

{348, new ItemData(
        348,
        @"Prime Primer",
        @"""Old Magic""",
        @"One of the pieces needed to craft the 'Bullet that can kill the past'
Sold for 110 casings in the shop",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"n/a"},
},
        @"")},

{351, new ItemData(
        351,
        @"Arcane Gunpowder",
        @"""From The Deep""",
        @"One of the pieces needed to craft the 'Bullet that can kill the past'
Found in the 3rd chamber of the Gungeon (Black Powder Mine) at the back of the large room with floating minecarts
It can be accessed by controlling each minecart and moving it along the invisible track, rolling between each one
While this is an Active item, it cannot be used",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
{@"Quality", @"n/a"},
},
        @"")},

{349, new ItemData(
        349,
        @"Planar Lead",
        @"""Astral Slug""",
        @"One of the pieces needed to craft the 'Bullet that can kill the past'
Found in the 4th chamber of the Gungeon (Hollow) at the back of the large room with an empty chasm in the middle
The room has an invisible path which can only be revealed with a gun that leaves a liquid or debris on the ground,
                        however you can also simply fly across with an item like Wax Wings",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"n/a"},
},
        @"")},

{350, new ItemData(
        350,
        @"Obsidian Shell Casing",
        @"""Indestructible""",
        @"One of the pieces needed to craft the 'Bullet that can kill the past'
Found in the 5th chamber of the Gungeon (Forge) by destroying the skull that is left behind after defeating the High
                        Dragun boss",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"n/a"},
},
        @"")},

{291, new ItemData(
        291,
        @"Meatbun",
        @"""On A Roll""",
        @"Heals one empty red heart container
When used, grants x2 damage until you next take damage",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
{@"Recharge time", @"Single use"},
},
        @"")},

{63, new ItemData(
        63,
        @"Medkit",
        @"""Heals""",
        @"Heals four hearts on use",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
{@"Recharge time", @"Single use"},
},
        @"")},

{104, new ItemData(
        104,
        @"Ration",
        @"""Calories, Mate""",
        @"Heals two empty red heart containers on use
Gets used automatically if you run out of health
This item has to be your selected active item to trigger the auto-heal mechanic
UNLOCK: Unlock this item by purchasing it in The Breach from Trorc for 7 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it in The Breach from Trorc for 7 Hegemony Credits"},
{@"Type", @"Active"},
{@"Recharge time", @"Single use"},
{@"Quality", @"C"},
},
        @"")},

{485, new ItemData(
        485,
        @"Orange",
        @"""You're Not Alexander""",
        @"+1 Health Up
Full heal on use
+2 Coolness up (decreases active item cooldowns, luck up)",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
{@"Recharge time", @"Single use"},
},
        @"")},

{412, new ItemData(
        412,
        @"Friendship Cookie",
        @"""It's Delicious""",
        @"Revives your co-op partner and fully heals them
Can only be found in co-op mode",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
{@"Recharge time", @"Single use"},
{@"Quality", @"n/a"},
},
        @"")},

{108, new ItemData(
        108,
        @"Bomb",
        @"""Use For Boom""",
        @"Throws a bomb that explodes after a short delay",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{109, new ItemData(
        109,
        @"Ice Bomb",
        @"""Cool It!""",
        @"Throws a bomb that freezes enemies when it explodes
Frozen enemies will be unable to move for a short period of time. Dodge rolling into a frozen enemy will shatter it",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{460, new ItemData(
        460,
        @"Chaff Grenade",
        @"""Dazed And Confused""",
        @"Stuns all enemies
Can be used to steal items from the shop
UNLOCK: Unlock this item by purchasing it in The Breach from Trorc for 13 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it in The Breach from Trorc for 13 Hegemony Credits"},
{@"Type", @"Active"},
},
        @"")},

{66, new ItemData(
        66,
        @"Proximity Mine",
        @"""Use To Place""",
        @"Places a mine on the ground that explodes when an enemy comes near it",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{308, new ItemData(
        308,
        @"Cluster Mine",
        @"""Area Hazard""",
        @"Places a cluster of 5 proximity mines that explode when they come into contact with an enemy
UNLOCK: Unlock this item by purchasing it in The Breach from Trorc for 3 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it in The Breach from Trorc for 3 Hegemony Credits"},
{@"Type", @"Active"},
},
        @"")},

{136, new ItemData(
        136,
        @"C4",
        @"""Stick Boom""",
        @"C4 can be placed on the ground and then triggered remotely by using the item again",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{366, new ItemData(
        366,
        @"Molotov",
        @"""Feel The Burn""",
        @"Throws a Molotov that sets a circular area of the ground on fire
The Convict starts with this item",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{252, new ItemData(
        252,
        @"Air Strike",
        @"""Superior!""",
        @"Upon use, the Air Strike creates a chain of missile strikes that form a rectangular pattern infront of you
UNLOCK: Unlock this item by purchasing it in The Breach from Trorc for 6 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it in The Breach from Trorc for 6 Hegemony Credits"},
{@"Type", @"Active"},
},
        @"")},

{242, new ItemData(
        242,
        @"Napalm Strike",
        @"""Smells Great!""",
        @"Upon use, the Napalm Strike sets the ground infront of you on fire in a large a rectangular pattern
UNLOCK: Unlock this item by purchasing it from Professor Goopton's store in The Breach for 18 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Professor Goopton's store in The Breach for 18 Hegemony Credits"},
{@"Type", @"Active"},
},
        @"")},

{443, new ItemData(
        443,
        @"Big Boy",
        @"""Set The World On Fire""",
        @"When used, calls down a missile at the location of the crosshair, causing an explosion that leaves behind a pool of
                        poison
                     
Curse Up while held
UNLOCK: Unlock this item by purchasing it in The Breach from Trorc for 20 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it in The Breach from Trorc for 20 Hegemony Credits"},
{@"Type", @"Active"},
},
        @"")},

{234, new ItemData(
        234,
        @"iBomb Companion App",
        @"""One For That""",
        @"Detonates all explosives and explosive enemies in the current room",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{77, new ItemData(
        77,
        @"Supply Drop",
        @"""I Need Mags!""",
        @"Spawns an ammo crate on use (single use)
Can only be used if you are currently holding a weapon that doesn't have full or infinite ammo
The Marine starts with this item",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
{@"Recharge time", @"Single use"},
},
        @"")},

{116, new ItemData(
        116,
        @"Ammo Synthesizer",
        @"""Ammo Chance On Kills""",
        @"Chance to regain ammo upon killing an enemy",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{450, new ItemData(
        450,
        @"Armor Synthesizer",
        @"""Play Well, Get Armor""",
        @"Gives you a higher chance to get an armour drop upon completing a room",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{164, new ItemData(
        164,
        @"Heart Synthesizer",
        @"""Play Well, Get Hearts""",
        @"Gives you a higher chance to get a heart drop upon completing a room",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{140, new ItemData(
        140,
        @"Master of Unlocking",
        @"""Play Well, Get Keys""",
        @"Gives you a higher chance to get a key drop upon completing a room",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{131, new ItemData(
        131,
        @"Utility Belt",
        @"""All Capacity Up!""",
        @"Max ammo increased by +20% for all weapons
Gives you an additional active item slot",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{473, new ItemData(
        473,
        @"Hidden Compartment",
        @"""Extra Space""",
        @"Max ammo increased by +10% for all weapons
Gives you an additional active item slot
The Pilot starts with this item",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"n/a"},
},
        @"")},

{133, new ItemData(
        133,
        @"Backpack",
        @"""Item Capacity Up!""",
        @"Gives you an additional active item slot",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{102, new ItemData(
        102,
        @"Scope",
        @"""Steady Aim""",
        @"Weapon accuracy increase",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{273, new ItemData(
        273,
        @"Laser Sight",
        @"""King Of The Dot""",
        @"Weapon accuracy increase
Gives your guns a laser sight",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{134, new ItemData(
        134,
        @"Ammo Belt",
        @"""Ammo Capacity Up!""",
        @"Max ammo increased by +20% for all weapons",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{69, new ItemData(
        69,
        @"Bullet Time",
        @"""Dodge This""",
        @"Upon use, this item will slow down time for a few seconds",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{237, new ItemData(
        237,
        @"Aged Bell",
        @"""Lacuna""",
        @"Briefly stops enemies and enemy bullets
Can be used to steal items from the shop",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{155, new ItemData(
        155,
        @"Singularity",
        @"""Sucks""",
        @"Creates a small black hole, damaging any enemies and destroying any projectiles caught in its gravitational pull
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 12 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 12 Hegemony Credits"},
{@"Type", @"Active"},
},
        @"")},

{71, new ItemData(
        71,
        @"Decoy",
        @"""Get Him!""",
        @"Places a decoy that enemies will target instead of the player
The decoy will be destroyed after taking enough damage
Can be used to steal items from the shop",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{438, new ItemData(
        438,
        @"Explosive Decoy",
        @"""KABOOM!""",
        @"Places a decoy that enemies will target instead of the player
The decoy will explode after taking enough damage
Can be used to steal items from the shop (must be used very close to the shopkeeper)",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{403, new ItemData(
        403,
        @"Melted Rock",
        @"""Corpses Explode""",
        @"Causes enemy corpses to explode on use",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{356, new ItemData(
        356,
        @"Trusty Lockpicks",
        @"""Who Needs Keys?""",
        @"Upon use, has a 50% chance to unlock a locked chest, or lock it permanently
The Pilot starts with this item
UNLOCK: Unlock this item by killing The Pilot's past",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing The Pilot's past"},
{@"Type", @"Active"},
},
        @"")},

{462, new ItemData(
        462,
        @"Smoke Bomb",
        @"""Vanish!""",
        @"When used, you temporarily become invisible to enemies
Can be used to steal items from shops",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{216, new ItemData(
        216,
        @"Box",
        @"""Just A Box""",
        @"Entering a new room while under the box will cause enemies to not target the player
Firing a weapon will blow your cover and cause the box to disappear
Can be used to steal items from shops
The Box has no effect if enemies are already targeting you
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 8 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 8 Hegemony Credits"},
{@"Type", @"Active"},
},
        @"")},

{105, new ItemData(
        105,
        @"Fortune's Favor",
        @"""Use For Luck""",
        @"While active, bullets will curve around the player",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{432, new ItemData(
        432,
        @"Jar of Bees",
        @"""The Pain!""",
        @"Spawns a bunch of bees that target and damage the nearest enemy",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{64, new ItemData(
        64,
        @"Potion of Lead Skin",
        @"""I'm Invincible!""",
        @"While active, enemy bullets are reflected back at them",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{168, new ItemData(
        168,
        @"Double Vision",
        @"""One For Each Of You""",
        @"While active, this item doubles your bullets, firing twice as many as you normally would at the same time",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{205, new ItemData(
        205,
        @"Poison Vial",
        @"""For External Use Only""",
        @"While active, this item fires a vial of poison which breaks and creates a circle of poison on the ground",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{174, new ItemData(
        174,
        @"Potion of Gun Friendship",
        @"""Temporary +1 To Gun""",
        @"While active, the potion increases all of your gun's stats by +1",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{201, new ItemData(
        201,
        @"Portable Turret",
        @"""Some Assembly Required""",
        @"Places a stationary turret that shoots at enemies and blocks enemy bullets
The turret will be destroyed after it takes enough damage
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 12 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 12 Hegemony Credits"},
{@"Type", @"Active"},
},
        @"")},

{65, new ItemData(
        65,
        @"Knife Shield",
        @"""Use Again To Launch!""",
        @"When used, this item creates a ring of knives around the player which damage enemies on contact and also block enemy
                        projectiles
                     
Pressing the use button again will launch the knives forward
The knives will vanish after taking enough damage
Curse Up while held",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{250, new ItemData(
        250,
        @"Grappling Hook",
        @"""Rapid Transit""",
        @"Allows players to hook onto and then pull themselves towards walls at a fast speed. Hitting enemies with the hook will
                        deal minor damage and stun them for a short duration. Allows players to steal items from the shop. The hook has an
                        unlimited range
                     
Can be used to grapple onto walls and quickly move across the room
Hitting an enemy will stun for a short period of time
Latching onto an item will pull it towards you (this also means you can steal items from the shop, however you will
                        be caught stealing unless used from a long distance)
                     
The grappling hook has an unlimited range",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{433, new ItemData(
        433,
        @"Stuffed Star",
        @"""Protective Plush""",
        @"While active, provides temporary invulnerability",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{448, new ItemData(
        448,
        @"Boomerang",
        @"""Usually Comes Back""",
        @"Throws a boomerang that travels around the room and stuns enemies",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{447, new ItemData(
        447,
        @"Shield of the Maiden",
        @"""Block And Load""",
        @"When used, a shield is revealed which will block enemy bullets
You are unable to move while the shield is active
UNLOCK: Unlock this item by beating the Keep of a Lead Lord (Chamber #1) boss without getting hit",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by beating the Keep of a Lead Lord (Chamber #1) boss without getting hit"},
{@"Type", @"Active"},
},
        @"")},

{286, new ItemData(
        286,
        @"+1 Bullets",
        @"""+1 To Bullet""",
        @"Damage Up
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 6 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 6 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{113, new ItemData(
        113,
        @"Rocket-Powered Bullets",
        @"""Faster Bullets""",
        @"Damage Up
Bullet Speed Up
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 4 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 4 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{111, new ItemData(
        111,
        @"Heavy Bullets",
        @"""Thunk!""",
        @"Damage Up
Bullet Speed Down",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{298, new ItemData(
        298,
        @"Shock Rounds",
        @"""Electrified!""",
        @"Creates a chain of lightning between fired bullets, which deals damage to any enemies it passes through",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{288, new ItemData(
        288,
        @"Bouncy Bullets",
        @"""Boiyoiyoing!""",
        @"Turns all of your bullets into bouncy bullets, allowing them to bounce off objects and walls",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{304, new ItemData(
        304,
        @"Explosive Rounds",
        @"""Mega Blast""",
        @"Each bullet has a chance to become explosive, causing it to explode upon contact with an object or enemy
The explosions cannot harm the player",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{172, new ItemData(
        172,
        @"Ghost Bullets",
        @"""Shoot Through""",
        @"Bullets become piercing, allowing them to pass through enemies and obstacles",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{373, new ItemData(
        373,
        @"Alpha Bullets",
        @"""First!""",
        @"Doubles the damage dealt by the first bullet in a clip
When combined with Omega Bullets, these items create a synergy that reduces the reload time of all your guns
UNLOCK: Unlock this item by building the 'Bullet That Can Kill The Past' for the first time",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by building the 'Bullet That Can Kill The Past' for the first time"},
{@"Type", @"Passive"},
},
        @"")},

{374, new ItemData(
        374,
        @"Omega Bullets",
        @"""Last!""",
        @"Doubles the damage dealt by the last bullet in a clip
When combined with Alpha Bullets, these items create a synergy that reduces the reload time of all your guns
UNLOCK: Unlock this item by building the 'Bullet That Can Kill The Past' for the first time",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by building the 'Bullet That Can Kill The Past' for the first time"},
{@"Type", @"Passive"},
},
        @"")},

{241, new ItemData(
        241,
        @"Scattershot",
        @"""Quantity Over Quality""",
        @"Guns now fire a spread of bullets which deal less damage
Scattershot triples the amount of bullets you fire",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{204, new ItemData(
        204,
        @"Irradiated Lead",
        @"""Poison Shot""",
        @"Adds a chance to fire bullets that poison enemies
Poisoned enemies take damage over time for a short period",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{295, new ItemData(
        295,
        @"Hot Lead",
        @"""Chance To Ignite""",
        @"Adds a chance to fire bullets that ignite enemies
Burned enemies take damage over time for a short period
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 5 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 5 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{278, new ItemData(
        278,
        @"Frost Bullets",
        @"""Icy Fire""",
        @"Adds a chance to fire bullets that freeze enemies
Frozen enemies will be unable to move for a short period of time. Dodge rolling into a frozen enemy will shatter it",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{277, new ItemData(
        277,
        @"Fat Bullets",
        @"""Fatter = Stronger""",
        @"Bullet Size and Damage Up
-10% Maximum ammo
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 6 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 6 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{323, new ItemData(
        323,
        @"Angry Bullets",
        @"""Hungry For More""",
        @"Hitting an enemy has a chance to refire the projectile at a nearby enemy
Refired bullets can also trigger the same effect
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 8 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 8 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{410, new ItemData(
        410,
        @"Battery Bullets",
        @"""Zap!""",
        @"Causes water that bullets pass over to become electrified, damaging enemies
UNLOCK: Unlock this item by defeating the High Dragun boss as The Robot character",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating the High Dragun boss as The Robot character"},
{@"Type", @"Passive"},
},
        @"")},

{284, new ItemData(
        284,
        @"Homing Bullets",
        @"""Fire And Forget""",
        @"Bullets have a chance to home in on enemies",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{352, new ItemData(
        352,
        @"Shadow Bullets",
        @"""Double Tap""",
        @"Firing a weapon has a 15% chance to also fire an additional projectile",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{375, new ItemData(
        375,
        @"Easy Reload Bullets",
        @"""Rolling Reload""",
        @"Dodge rolling reloads one bullet",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{114, new ItemData(
        114,
        @"Bionic Leg",
        @"""More Machine Than Man""",
        @"Player movement speed up
+1 Armor",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{427, new ItemData(
        427,
        @"Shotgun Coffee",
        @"""Speed Up""",
        @"Player movement speed up",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{426, new ItemData(
        426,
        @"Shotga Cola",
        @"""Speed Up""",
        @"+20% Player movement speed up",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{212, new ItemData(
        212,
        @"Ballistic Boots",
        @"""Speedier Than A Bullet""",
        @"Player movement speed up",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{110, new ItemData(
        110,
        @"Magic Sweet",
        @"""Free Stats""",
        @"+1 Health up
Damage up
Player movement speed up
+1 Coolness up (decreases active item cooldowns, luck up)",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{187, new ItemData(
        187,
        @"Disarming Personality",
        @"""For You?""",
        @"Shop prices are roughly 15% cheaper while held
The Pilot starts with this item
UNLOCK: Unlock this item by killing The Pilot's past",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing The Pilot's past"},
{@"Type", @"Passive"},
},
        @"")},

{435, new ItemData(
        435,
        @"Mustache",
        @"""A Familiar Face""",
        @"Has a chance to heal the player upon purchasing an item",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{213, new ItemData(
        213,
        @"Lichy Trigger Finger",
        @"""Rate of Fire Up""",
        @"+25% rate of fire",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{353, new ItemData(
        353,
        @"Enraging Photo",
        @"""Don't Believe His Lies""",
        @"Upon taking damage, you gain increased damage for a brief period of time and your gun will be instantly reloaded
The Convict starts with this item
UNLOCK: Unlock this item by killing The Convict's past",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing The Convict's past"},
{@"Type", @"Passive"},
},
        @"")},

{115, new ItemData(
        115,
        @"Ballot",
        @"""Vote Of Confidence!""",
        @"+3 Coolness up (decreases active item cooldowns, luck up)",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{414, new ItemData(
        414,
        @"Live Ammo",
        @"""I'm A Bullet Too!""",
        @"Provides immunity to contact damage
Rolling into enemies deals increased damage (15, normally 3 without this item)
The Bullet starts with this item",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"N/A"},
},
        @"")},

{118, new ItemData(
        118,
        @"Eyepatch",
        @"""Hit Harder Less Often""",
        @"Damage up
Accuracy down
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 8 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 8 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{354, new ItemData(
        354,
        @"Military Training",
        @"""Hold Facing Enemy""",
        @"Accuracy up
Better reload speeds
The Marine starts with this item
UNLOCK: Unlock this item by killing The Marine's past",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing The Marine's past"},
{@"Type", @"Passive"},
},
        @"")},

{112, new ItemData(
        112,
        @"Cartographer's Ring",
        @"""Some Floors Are Familiar""",
        @"When entering a new floor, this item gives a small chance for the map to be fully revealed instantly",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{191, new ItemData(
        191,
        @"Ring of Fire Resistance",
        @"""No Burns""",
        @"Prevents damage from fire",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{132, new ItemData(
        132,
        @"Ring of Miserly Protection",
        @"""Aids The Fiscally Responsible""",
        @"+2 Health Up, however purchasing any item from the shop will shatter the ring and remove your gained heart containers",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{495, new ItemData(
        495,
        @"Unity",
        @"""Our Powers Combined""",
        @"Increases damage based on the other guns the player has
2% of the total damage of the player's non-equipped guns is added as flat damage to the player's currently equipped
                        gun
                     
UNLOCK: Unlock this item by fully populating The Breach with all NPCs",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by fully populating The Breach with all NPCs"},
{@"Type", @"Passive"},
},
        @"")},

{488, new ItemData(
        488,
        @"Ring of Chest Vampirism",
        @"""Blood From Wood""",
        @"Heals you upon breaking a chest open
Breaking a chest which has already been opened will not heal you",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{309, new ItemData(
        309,
        @"Cloranthy Ring",
        @"""Dodge Power Up""",
        @"Makes your dodge roll faster by 20% and shortens its recovery time",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{254, new ItemData(
        254,
        @"Ring of Chest Friendship",
        @"""Chest Friends Forever""",
        @"Increases the chance of finding chests",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{294, new ItemData(
        294,
        @"Ring of Mimic Friendship",
        @"""Unlikely Allies""",
        @"Mimics will not attack you",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{456, new ItemData(
        456,
        @"Ring of Triggers",
        @"""Items == Guns""",
        @"Using an active item fires the currently held weapon in all directions",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{458, new ItemData(
        458,
        @"Ring of Ethereal Form",
        @"""Get Ethereal!""",
        @"Upon use, gives you invincibility and flight
Allows you to steal an item from the shop while in the ethereal form",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{159, new ItemData(
        159,
        @"Gundromeda Strain",
        @"""All Enemies Weaker!""",
        @"Decreases health of all enemies encountered
UNLOCK: Unlock this item by purchasing it from Professor Goopton's store in The Breach for 25 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Professor Goopton's store in The Breach for 25 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{258, new ItemData(
        258,
        @"Broccoli",
        @"""Makes You Strong""",
        @"Damage up
Adds a 10% chance to negate damage
Player movement speed up
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 25 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 25 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{240, new ItemData(
        240,
        @"Crutch",
        @"""You Need It""",
        @"Causes bullets to slightly curve towards enemies",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{431, new ItemData(
        431,
        @"Liquid Valkyrie",
        @"""Maximum Pain""",
        @"Decreases enemy bullet speed",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{167, new ItemData(
        167,
        @"Bloody Eye",
        @"""Slower Enemy Bullets""",
        @"Decreases enemy bullet speed
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 7 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 7 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{160, new ItemData(
        160,
        @"Gunknight Helmet",
        @"""Armor Every Floor""",
        @"Grants a piece of armour upon pickup
Grants another piece of armour upon entering a new floor
Collecting all four pieces of the Gunknight set transforms you into Cormorant, which removes the reload time of all
                        guns and gives increased curse
                     
UNLOCK: Unlock this item by completing a hunting quest for Frifle and Grey Mauser to kill 35 Gun Nuts",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by completing a hunting quest for Frifle and Grey Mauser to kill 35 Gun Nuts"},
{@"Type", @"Passive"},
},
        @"")},

{161, new ItemData(
        161,
        @"Gunknight Greaves",
        @"""Armor Every Floor""",
        @"Grants a piece of armour upon pickup
Grants another piece of armour upon entering a new floor
Collecting all four pieces of the Gunknight set transforms you into Cormorant, which removes the reload time of all
                        guns and gives increased curse",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{163, new ItemData(
        163,
        @"Gunknight Armor",
        @"""Armor Every Floor""",
        @"Grants a piece of armour upon pickup
Grants another piece of armour upon entering a new floor
Collecting all four pieces of the Gunknight set transforms you into Cormorant, which removes the reload time of all
                        guns and gives increased curse",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{162, new ItemData(
        162,
        @"Gunknight Gauntlet",
        @"""Armor Every Floor""",
        @"Grants a piece of armour upon pickup
Grants another piece of armour upon entering a new floor
Collecting all four pieces of the Gunknight set transforms you into Cormorant, which removes the reload time of all
                        guns and gives increased curse",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{158, new ItemData(
        158,
        @"Amulet of the Pit Lord",
        @"""No Fall Damage""",
        @"Falling into pits no longer deals damage
UNLOCK: Unlock this item by killing 100 enemies by pushing them into pits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing 100 enemies by pushing them into pits"},
{@"Type", @"Passive"},
},
        @"")},

{219, new ItemData(
        219,
        @"Old Knight's Shield",
        @"""Heavy With Experience""",
        @"Grants two pieces of armor
UNLOCK: Unlock this item by finding Ser Manuel's remains in the tutorial secret room",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by finding Ser Manuel's remains in the tutorial secret room"},
{@"Type", @"Passive"},
{@"Quality", @"N/A"},
},
        @"")},

{222, new ItemData(
        222,
        @"Old Knight's Helm",
        @"""Protects Knowledge""",
        @"Grants two pieces of armor
UNLOCK: Unlock this item by finding Ser Manuel's remains in the tutorial secret room",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by finding Ser Manuel's remains in the tutorial secret room"},
{@"Type", @"Passive"},
{@"Quality", @"N/A"},
},
        @"")},

{267, new ItemData(
        267,
        @"Old Knight's Flask",
        @"""Heals Per Floor""",
        @"Heals the player for half a heart upon use
Starts with 2 charges and gains 2 charges at the start of each floor
UNLOCK: Unlock this item by defeating the High Dragun boss 5 times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating the High Dragun boss 5 times"},
{@"Type", @"Active"},
},
        @"")},

{305, new ItemData(
        305,
        @"Old Crest",
        @"""Passive""",
        @"Grants a piece of armor. Consumed upon taking any damage
Found in a special pedestal room in the Oubliette
Can be placed on the alter in the Gungeon Proper (Chamber #2) to gain access to the Abbey of the True Gun chamber",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"unknown"},
},
        @"")},

{457, new ItemData(
        457,
        @"Armor of Thorns",
        @"""Your Body Is A Weapon""",
        @"Increases damage dealt by dodge rolling into enemies
Grants one piece of armor",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{256, new ItemData(
        256,
        @"Heavy Boots",
        @"""Low Center Of Mass""",
        @"Prevents the player from being affected by enemy knockback, gun recoil, conveyor belts and ice patches",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{193, new ItemData(
        193,
        @"Bug Boots",
        @"""Yikes!""",
        @"Dodge rolling leaves a trail of poison creep
Grants immunity to poison
UNLOCK: Unlock this item by purchasing it from Professor Goopton's store in The Breach for 7 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Professor Goopton's store in The Breach for 7 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{315, new ItemData(
        315,
        @"Gunboots",
        @"""They Go Down Well""",
        @"Dodge rolling fires a spread of five bullets backwards
UNLOCK: Unlock this item by fixing the shortcut to the Gungeon Proper (Chamber #2)",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by fixing the shortcut to the Gungeon Proper (Chamber #2)"},
{@"Type", @"Passive"},
},
        @"")},

{214, new ItemData(
        214,
        @"Coin Crown",
        @"""Play Well, Get Money""",
        @"Increases chance of money drops upon clearing a room
UNLOCK: Unlock this item by carrying 300 casings at once",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by carrying 300 casings at once"},
{@"Type", @"Passive"},
},
        @"")},

{165, new ItemData(
        165,
        @"Oiled Cylinder",
        @"""Reload Faster""",
        @"Decreases reload time",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{170, new ItemData(
        170,
        @"Ice Cube",
        @"""Items Recharge While Active""",
        @"Allows active items to recharge while they are active
+3 Coolness up (decreases active item cooldowns, luck up)",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{190, new ItemData(
        190,
        @"Rolling Eye",
        @"""Back At You""",
        @"Rolling through bullets reflects them at enemies",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{203, new ItemData(
        203,
        @"Cigarettes",
        @"""Hazardous To Health""",
        @"+1 Coolness up per use (decreases active item cooldowns, luck up)
Damages the player for half a heart
Discarded cigarettes will light oil puddles",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{206, new ItemData(
        206,
        @"Charm Horn",
        @"""The Call Of Duty""",
        @"Charms enemies around the player upon use
Can be used to steal items from the shop (must be used very close to the shopkeeper)",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{135, new ItemData(
        135,
        @"Cog of Battle",
        @"""Active Reload""",
        @"When reloading, pressing reload again when the indicator passes a the mark on the reload bar will instantly reload
                        the weapon
                     
Successfully triggering the effect will increase your damage and accuracy on the next clip of bullets",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{119, new ItemData(
        119,
        @"Metronome",
        @"""Better And Better""",
        @"Grants a damage bonus for each enemy killed
The bonus is reset if the player takes damage or changes guns
Picking up a new gun does not reset the bonus and will transfer the bonus to the new gun",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{138, new ItemData(
        138,
        @"Honeycomb",
        @"""Bee Prepared""",
        @"Taking damage spawns bees that seek out and damage enemies",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{137, new ItemData(
        137,
        @"Map",
        @"""Floor Revealed""",
        @"Reveals the entire map for the current floor, including secret rooms",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{281, new ItemData(
        281,
        @"Gungeon Blueprint",
        @"""Procedurally Updates""",
        @"Reveals every room on every floor for the rest of the run
UNLOCK: Unlock this item by defeating The Lich",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating The Lich"},
{@"Type", @"Passive"},
},
        @"")},

{209, new ItemData(
        209,
        @"Sense of Direction",
        @"""Surprisingly Rare.""",
        @"Points in the direction of the floor's exit",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{239, new ItemData(
        239,
        @"Duct Tape",
        @"""Friend Of Gunsmiths""",
        @"Single use. Combines 2 guns by granting one gun the projectiles that the other gun fires
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 10 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 10 Hegemony Credits"},
{@"Type", @"Active"},
},
        @"")},

{253, new ItemData(
        253,
        @"Gungeon Pepper",
        @"""The Heat Is On!""",
        @"Deals damage to nearby enemies",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{259, new ItemData(
        259,
        @"Antibody",
        @"""Heals Up""",
        @"Picking up health has a chance to heal the player for an extra half a heart
Will synergize with healing items such as Green Guon Stone, Blood Brooch and Mustache",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{260, new ItemData(
        260,
        @"Pink Guon Stone",
        @"""Increased Health""",
        @"Orbits the player, blocking enemy shots on contact
Grants one extra heart container",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{262, new ItemData(
        262,
        @"White Guon Stone",
        @"""Kindles Blanks""",
        @"Orbits the player, blocking enemy shots on contact
Grants an extra blank per floor",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{263, new ItemData(
        263,
        @"Orange Guon Stone",
        @"""Hot Rock""",
        @"Orbits the player, blocking enemy shots on contact
Shoots at enemies for 1.5 damage per shot",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{264, new ItemData(
        264,
        @"Clear Guon Stone",
        @"""Pure""",
        @"Orbits the player, blocking enemy shots on contact
Grants immunity to poison damage",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{466, new ItemData(
        466,
        @"Green Guon Stone",
        @"""Chance To Heal""",
        @"Orbits the player, blocking enemy shots on contact
Chance to heal upon taking damage",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{269, new ItemData(
        269,
        @"Red Guon Stone",
        @"""Dodge Up""",
        @"Orbits the player, blocking enemy shots on contact
Increases the speed and distance of dodge rolls",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{270, new ItemData(
        270,
        @"Blue Guon Stone",
        @"""On My Side""",
        @"Orbits the player, blocking enemy shots on contact
Upon taking damage, briefly slows time",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{272, new ItemData(
        272,
        @"Iron Coin",
        @"""Valar Morgunis""",
        @"Upon use, kills all enemies in a random unexplored room of the current floor.
Cannot clear boss rooms
While held, grants a 20% discount at shops and increases coolness by 2.
Has 3 uses total
UNLOCK: Unlock this item by beating the Gungeon Proper (Chamber #2) boss without getting hit",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by beating the Gungeon Proper (Chamber #2) boss without getting hit"},
{@"Type", @"Active"},
},
        @"")},

{279, new ItemData(
        279,
        @"Super Hot Watch",
        @"""Suuuuuuper""",
        @"Slows down time greatly while not moving
UNLOCK: Unlock this item by acquiring 5 Master Rounds in a single run",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by acquiring 5 Master Rounds in a single run"},
{@"Type", @"Passive"},
},
        @"")},

{280, new ItemData(
        280,
        @"Drum Clip",
        @"""One Size Fits All""",
        @"Increases the magazine size of all weapons by +50%",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{285, new ItemData(
        285,
        @"Blood Brooch",
        @"""What Music They Make!""",
        @"Adds a small chance to heal upon damaging an enemy
Increases your Curse while held
UNLOCK: Unlock this item by reaching the Abbey of the True Gun floor",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by reaching the Abbey of the True Gun floor"},
{@"Type", @"Passive"},
},
        @"")},

{287, new ItemData(
        287,
        @"Backup Gun",
        @"""Watch Your Back""",
        @"With each shot fired, a second bullet will be fired in the opposite direction that the player is aiming",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{290, new ItemData(
        290,
        @"Sunglasses",
        @"""Bright Future""",
        @"Slows down time and increases dodge power during explosions
+2 Coolness up (decreases active item cooldowns, luck up)
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 10 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 10 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{293, new ItemData(
        293,
        @"Mimic Tooth Necklace",
        @"""Chomp""",
        @"Every chest and item pedestal is guaranteed to be a Mimic
Since all Mimics will either drop an item or a gun, this item technically unlocks all chests
Also holding the Ring of Mimic Friendship will cause chests to be unlocked but no longer spawn as mimics
UNLOCK: Unlock this item by completing a hunting quest for Frifle and Grey Mauser to kill 5 Mimics",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by completing a hunting quest for Frifle and Grey Mauser to kill 5 Mimics"},
{@"Type", @"Passive"},
},
        @"")},

{306, new ItemData(
        306,
        @"Escape Rope",
        @"""Works Anywhere!""",
        @"Teleport out of the current room into the shop of the current floor",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{106, new ItemData(
        106,
        @"Jetpack",
        @"""To Fly""",
        @"While active, the player has increased movement speed and flight, but cannot dodge roll
Passing over puddles of oil will set them on fire",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
{@"Recharge time", @"Toggled"},
},
        @"")},

{307, new ItemData(
        307,
        @"Wax Wings",
        @"""Too Close To The Gun""",
        @"Grants flight
Unlike the Jetpack, you can still dodgeroll with this item",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{312, new ItemData(
        312,
        @"Blast Helmet",
        @"""Duck And Cover""",
        @"Decreases the radius that explosions will hurt the player in
UNLOCK: Unlock this item by kicking the Ledge Goblin's helmet off the ledge 4 times in The Breach",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by kicking the Ledge Goblin's helmet off the ledge 4 times in The Breach"},
{@"Type", @"Passive"},
},
        @"")},

{313, new ItemData(
        313,
        @"Monster Blood",
        @"""Twist To Open""",
        @"Taking damage spawns a pool of poison creep
Grants immunity to poison damage
+1 HP up
UNLOCK: Unlock this item by purchasing it from Professor Goopton's store in The Breach for 5 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Professor Goopton's store in The Breach for 5 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{314, new ItemData(
        314,
        @"Nanomachines",
        @"""Son""",
        @"Grants two pieces of armour upon pickup
Grants a piece of armour every 4 times damage is taken
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 10 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 10 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{289, new ItemData(
        289,
        @"Seven-Leaf Clover",
        @"""Lucky!""",
        @"Increases the quality of chests
Most chests become red or black chests
UNLOCK: Unlock this item by winning Winchester's shooting game 3 times with 100% accuracy",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by winning Winchester's shooting game 3 times with 100% accuracy"},
{@"Type", @"Passive"},
},
        @"")},

{326, new ItemData(
        326,
        @"Number 2",
        @"""Sidekick No More""",
        @"Boosts stats while your co-op partner is dead
 Only available in co-op, where The Cultist starts with this item",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"unknown"},
},
        @"")},

{321, new ItemData(
        321,
        @"Gold Ammolet",
        @"""Blank Damage Up""",
        @"Increases blank damage to 60
Gives you +1 Blank at the start of each new floor",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{325, new ItemData(
        325,
        @"Chaos Ammolet",
        @"""What Can Will""",
        @"Blanks have a chance to poison, freeze, and ignite enemies
Gives you +1 Blank at the start of each new floor",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{322, new ItemData(
        322,
        @"Lodestone Ammolet",
        @"""Blank Knockback Up""",
        @"Increases the knockback of blanks
Blanks stun enemies for 3 seconds
Gives you +1 Blank at the start of each new floor",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{342, new ItemData(
        342,
        @"Uranium Ammolet",
        @"""Blanks Poison""",
        @"Blanks have a chance to poison enemies
Gives you +1 Blank at the start of each new floor",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{343, new ItemData(
        343,
        @"Copper Ammolet",
        @"""Blanks Ignite""",
        @"Blanks have a chance to ignite enemies
Gives you +1 Blank at the start of each new floor",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{344, new ItemData(
        344,
        @"Frost Ammolet",
        @"""Chance To Freeze""",
        @"Blanks have a chance to freeze enemies
Gives you +1 Blank at the start of each new floor",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{396, new ItemData(
        396,
        @"Table Tech Sight",
        @"""Flip Multiplier""",
        @"Flipping a table briefly slows down time and triple the player's shots",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{397, new ItemData(
        397,
        @"Table Tech Money",
        @"""Flip Prosperity""",
        @"Flipping a table flips all other tables in the room
Adds a chance to spawn money whenever a table is flipped",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{398, new ItemData(
        398,
        @"Table Tech Rocket",
        @"""End Table""",
        @"Flipping a table causes it to launch forward and explode
UNLOCK: Unlock this item by pushing a table into a pit",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by pushing a table into a pit"},
{@"Type", @"Passive"},
},
        @"")},

{399, new ItemData(
        399,
        @"Table Tech Rage",
        @"""Flips Of Fury""",
        @"Flipping a table briefly increases the player's damage",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{400, new ItemData(
        400,
        @"Table Tech Blanks",
        @"""Flip Clarity""",
        @"Flipping a table activates a free blank",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{465, new ItemData(
        465,
        @"Table Tech Stun",
        @"""Flip Showmanship""",
        @"Flipping a table briefly stuns nearby enemies",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{421, new ItemData(
        421,
        @"Heart Holster",
        @"""On Your Sleeve""",
        @"+1 Health Up",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{422, new ItemData(
        422,
        @"Heart Lunchbox",
        @"""Healthy Meal""",
        @"+1 Health Up
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 5 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 5 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{423, new ItemData(
        423,
        @"Heart Locket",
        @"""Memento Mori""",
        @"+1 Health Up
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 4 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 4 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{424, new ItemData(
        424,
        @"Heart Bottle",
        @"""Liquid Life""",
        @"+1 Health Up
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 2 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 2 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{425, new ItemData(
        425,
        @"Heart Purse",
        @"""Form Begets Function""",
        @"+1 Health Up
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 4 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 4 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{440, new ItemData(
        440,
        @"Ruby Bracelet",
        @"""Thrown Guns Explode""",
        @"Thrown guns will explode (Note: Explosion does not destroy the gun)",
        new Dictionary<string, string>(){
{@"Thrown guns will explode (Note", @"Explosion does not destroy the gun)"},
{@"Type", @"Passive"},
},
        @"")},

{407, new ItemData(
        407,
        @"Sixth Chamber",
        @"""Blessing Of Kaliber""",
        @"Increases Coolness proportional to the amount of Curse the player has (+2 coolness per 1 curse)
+2 Curse up
The coolness stat decreases active item cooldowns and increases the chance to find item drops upon clearing a room
UNLOCK: Unlock this item by defeating a Jammed boss",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating a Jammed boss"},
{@"Type", @"Passive"},
},
        @"")},

{409, new ItemData(
        409,
        @"Busted Television",
        @"""Broken And Heavy""",
        @"Upon use, the television is thrown in the direction of the cursor
Dropped upon dodge rolling
Only found in the elevator shaft of the Gungeon Proper (Chamber #2) after the shortcut is unlocked. Deliver this item
                        to the Blacksmith in the Forge (Chamber #5) to unlock The Robot character",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
{@"Quality", @"unknown"},
},
        @"")},

{411, new ItemData(
        411,
        @"Coolant Leak",
        @"""Don't Overheat!""",
        @"Sprays water forward
Useful for putting out fires or causing pools of static shock if you also have shock bullets
Can only be obtained by The Robot character as its starting active item",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
{@"Quality", @"unknown"},
},
        @"")},

{364, new ItemData(
        364,
        @"Heart of Ice",
        @"""That's Cold""",
        @"+1 Health Up
+1 Coolness up (decreases active item cooldowns, luck up)
Taking damage releases bouncing ice bullets
The Coolness stat decreases active item cooldowns and increases the chance to find item drops upon clearing a room",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{255, new ItemData(
        255,
        @"Ancient Hero's Bandana",
        @"""Limitless""",
        @"Quadruples maximum ammo on all guns
UNLOCK: Unlock this item by completing the Forge (Chamber #5) 10 times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by completing the Forge (Chamber #5) 10 times"},
{@"Type", @"Passive"},
},
        @"")},

{436, new ItemData(
        436,
        @"Bloodied Scarf",
        @"""Blink Away""",
        @"Replaces the dodge roll with a blink
Holding down the dodge roll key allows you to teleport to the location of the mouse cursor
UNLOCK: Unlock this item by defeating Old King (the Abbey of the True Gun chamber boss)",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating Old King (the Abbey of the True Gun chamber boss)"},
{@"Type", @"Passive"},
},
        @"")},

{437, new ItemData(
        437,
        @"Muscle Relaxant",
        @"""Loosen Up""",
        @"Reduces weapon spread by 66%, increasing your accuracy",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{500, new ItemData(
        500,
        @"Hip Holster",
        @"""Quickdraw""",
        @"Fires a free bullet upon reloading",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{311, new ItemData(
        311,
        @"Clone",
        @"""The Real Me""",
        @"Upon death, the player is revived in the starting room of the first floor, retaining all items and guns
Allows you to collect duplicate Master Rounds on a single run
UNLOCK: Unlock this item by transporting Ox's replacement arm back to him in The Breach",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by transporting Ox's replacement arm back to him in The Breach"},
{@"Type", @"Passive"},
},
        @"")},

{452, new ItemData(
        452,
        @"Sponge",
        @"""Godliness""",
        @"Removes all liquids near the player
Allows you to understand Professor Goopton's alient language (Jellyfish merchant NPC)
UNLOCK: Unlock this item by purchasing it from Professor Goopton's store in The Breach for 6 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Professor Goopton's store in The Breach for 6 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{453, new ItemData(
        453,
        @"Gas Mask",
        @"""Breathe Deep""",
        @"Grants immunity to poison",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{454, new ItemData(
        454,
        @"Hazmat Suit",
        @"""Safety Protocol""",
        @"Grants immunity to fire, poison, and electricity
UNLOCK: Unlock this item by beating the Black Powder Mine (Chamber #3) boss without getting hit",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by beating the Black Powder Mine (Chamber #3) boss without getting hit"},
{@"Type", @"Passive"},
},
        @"")},

{487, new ItemData(
        487,
        @"Book of Chest Anatomy",
        @"""Controlled Demolition""",
        @"Improves the contents of broken chests
UNLOCK: Unlock this item by attacking a mimic before it attacks you",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by attacking a mimic before it attacks you"},
{@"Type", @"Passive"},
},
        @"")},

{489, new ItemData(
        489,
        @"Gun Soul",
        @"""YOU DEFEATED""",
        @"+1 HP Up
Upon death, you respawn at the start of the current floor with a single heart container and only your starting items/guns.
                        You must reach the location where you died to return to normal and receive all your normal items and guns. The floor
                        layout remains the same but all enemies will respawn
                     
This effect can be triggered multiple times if you manage to return to normal
Dying while in soul form ends the run
UNLOCK: Unlock this item by defeating the High Dragun boss for the first time",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating the High Dragun boss for the first time"},
{@"Type", @"Passive"},
},
        @"")},

{166, new ItemData(
        166,
        @"Shelleton Key",
        @"""Locks Are Dead To You""",
        @"Allows any chest or lock to be opened without using a key
Curse Up while held
UNLOCK: Unlock this item by stealing 10 items from shops",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by stealing 10 items from shops"},
{@"Type", @"Passive"},
},
        @"")},

{490, new ItemData(
        490,
        @"Brick of Cash",
        @"""Secrets Of The Masons""",
        @"Reveals secret rooms by placing a small grey familiar next to them, which will show the location",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{491, new ItemData(
        491,
        @"Wingman",
        @"""Got Your Back""",
        @"Orbits the player, firing rockets at enemies
UNLOCK: Unlock this item by killing The Pilot's past",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing The Pilot's past"},
{@"Type", @"Passive"},
},
        @"")},

{492, new ItemData(
        492,
        @"Wolf",
        @"""Junior""",
        @"A wolf companion that chases and bites enemies, dealing damage to them
UNLOCK: Unlock this item by killing The Hunter's past",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing The Hunter's past"},
{@"Type", @"Passive"},
},
        @"")},

{300, new ItemData(
        300,
        @"Dog",
        @"""Junior II""",
        @"Follows the player around and occasionally digs up a pickup upon completing a room
Identifies Mimics by barking at them
The Hunter starts with this item
UNLOCK: Unlock this item by killing The Hunter's past",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing The Hunter's past"},
{@"Type", @"Passive"},
},
        @"")},

{249, new ItemData(
        249,
        @"Owl",
        @"""Hoots And More""",
        @"A friendly owl companion that will occasionally use short-ranged blanks
UNLOCK: Unlock this item by winning 10 of the Gunsling King's wagers",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by winning 10 of the Gunsling King's wagers"},
{@"Type", @"Passive"},
},
        @"")},

{301, new ItemData(
        301,
        @"Super Space Turtle",
        @"""Hero From Space""",
        @"A friendly turtle familiar that will fire bullets at enemies
UNLOCK: Unlock this item by defeating Blobulord (The Oubilette chamber boss)",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating Blobulord (The Oubilette chamber boss)"},
{@"Type", @"Passive"},
},
        @"")},

{318, new ItemData(
        318,
        @"R2G2",
        @"""Gunmech Robot""",
        @"A friendly robot familiar that will fire bullets at enemies
UNLOCK: Unlock this item by fixing the shortcut to the Black Powder Mine (Chamber #3)",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by fixing the shortcut to the Black Powder Mine (Chamber #3)"},
{@"Type", @"Passive"},
},
        @"")},

{442, new ItemData(
        442,
        @"Badge",
        @"""By The Book""",
        @"Summons a police officer that follows the player, firing bullets at enemies
The officer will die after taking too much damage
Talking to the police officer upon his death will grant a Damage Up and a Curse Up
Can be talked to
UNLOCK: Unlock this item by defeating Blockner, a secret boss found in the Black Powder Mine (Chamber #3)",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating Blockner, a secret boss found in the Black Powder Mine (Chamber #3)"},
{@"Type", @"Passive"},
},
        @"")},

{232, new ItemData(
        232,
        @"Space Friend",
        @"""A Friend From The Space""",
        @"A friendly space ship which will follow the player and fire lasers at enemies
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 25 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 25 Hegemony Credits"},
{@"Type", @"Passive"},
},
        @"")},

{451, new ItemData(
        451,
        @"Pig",
        @"""Shifty""",
        @"Upon death, instantly revives the player with full health
UNLOCK: Unlock this item by completing a hunting quest for Frifle and Grey Mauser to kill 3 Beholsters (the boss)",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by completing a hunting quest for Frifle and Grey Mauser to kill 3 Beholsters (the boss)"},
{@"Type", @"Passive"},
},
        @"")},

{461, new ItemData(
        461,
        @"Blank Companion's Ring",
        @"""He Tries""",
        @"Activates a blank each time an active item is used",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Recharge time", @"10 seconds"},
},
        @"")},

{493, new ItemData(
        493,
        @"Briefcase of Cash",
        @"""Avarice""",
        @"Grants 250 casings and 3 Hegemony Credits
UNLOCK: Unlock this item by killing The Convict's past",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing The Convict's past"},
{@"Type", @"Passive"},
},
        @"")},

{494, new ItemData(
        494,
        @"Galactic Medal of Valor",
        @"""Courage Increased""",
        @"Increases damage dealt to bosses by +30%
-50% reload time
-50% shot spread (accuracy up)
UNLOCK: Unlock this item by killing The Marine's past",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing The Marine's past"},
{@"Type", @"Passive"},
},
        @"")},

{434, new ItemData(
        434,
        @"Bullet Idol",
        @"""Vengeful Spirit""",
        @"Deals damage to enemies upon taking damage",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
},
        @"")},

{271, new ItemData(
        271,
        @"Riddle of Lead",
        @"""This You Can Trust""",
        @"+1 Health Up
+25% Damage
Fully heals the player
+15% Dodge roll speed up
+10% Movement speed up
When at 1 heart or less, this item adds a 50% chance to negate fatal damage
UNLOCK: Unlock this item by defeating The Lich",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating The Lich"},
{@"Type", @"Passive"},
},
        @"")},

{439, new ItemData(
        439,
        @"Bracket Key",
        @"""`debugkill""",
        @"Deals a large amount of damage to all enemies in a room
Increases Curse while held
UNLOCK: Unlock this item by completing the Boss Rush",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by completing the Boss Rush"},
{@"Type", @"Active"},
},
        @"")},

{499, new ItemData(
        499,
        @"Elder Blank",
        @"""Excommunicate Bullets""",
        @"Upon use, activates a blank effect
+2 Curse up while held",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
},
        @"")},

{127, new ItemData(
        127,
        @"Junk",
        @"""Next Time Use A Key""",
        @"Has no effect on its own
If the player has no keys, chests have a 60% chance to drop Junk when destroyed. This chance increases to 72% if the
                        player has at least one key
                     
Can be sold to Creep for 3 casings
When playing as The Robot, each piece of Junk increases damage by 5%",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"unknown"},
},
        @"")},

{148, new ItemData(
        148,
        @"Lies",
        @"""Next Time Tell The Truth""",
        @"No effect
The only way to obtain this item is by destroying Brother Albern's chest (he's a NPC that can sometimes spawn in secret
                        rooms)
                     
Lies also works to upgrade Ser Junkan's level",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"unknown"},
},
        @"")},

{276, new ItemData(
        276,
        @"Spice",
        @"""A tantalizing cube of power""",
        @"First use: gives +1 Health Up, +20% player movement speed, -25% shot spread, +0.5 Curse Up
Second use: +1 Health Up, -10% enemy bullet speed, +20% fire rate, +1 Curse Up
Third use: -1 Health Down, -5% enemy bullet speed, +20% Damage Up, +1 Curse Up
Fourth use and onwards: -1 Health Down, +15% Damage Up, +10% shot spread, +1 Curse Up
Each use increases the chance that Spice will appear in the place of other item and pickup drops
UNLOCK: Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 7 Hegemony Credits",
        new Dictionary<string, string>(){
{@"First use", @"gives +1 Health Up, +20% player movement speed, -25% shot spread, +0.5 Curse Up"},
{@"Second use", @"+1 Health Up, -10% enemy bullet speed, +20% fire rate, +1 Curse Up"},
{@"Third use", @"-1 Health Down, -5% enemy bullet speed, +20% Damage Up, +1 Curse Up"},
{@"Fourth use and onwards", @"-1 Health Down, +15% Damage Up, +10% shot spread, +1 Curse Up"},
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence's store in The Breach for 7 Hegemony Credits"},
{@"Type", @"Active"},
},
        @"")},

{607, new ItemData(
        607,
        @"Clown Mask",
        @"""Anonymity Aid""",
        @"Summons one of the three following clown-masked familiars (chosen randomly):
Wolf (the clown with the red mouth) will attack enemies close up with a taser, continuously stunning them
Houston (the clown with the pink eyelids) will guard the Gungeoneers by occasionally activating mini Blanks that negate
                        enemy bullets
                     
Chains (the clown with black slits over his eyes) wields a shotgun which he will use to attack opponents
If you carry the Loot Bag or Drill, an additional familiar will be summoned for each item
Picking up Clown Mask increases the chance of finding the other Payday 2 promo items - Loot Bag and Drill
UNLOCK: Unlock this item by picking it up from a shop, either by stealing it or making the shopkeeper mad",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by picking it up from a shop, either by stealing it or making the shopkeeper mad"},
{@"Type", @"Passive"},
},
        @"")},

{625, new ItemData(
        625,
        @"Drill",
        @"""Sawgeant""",
        @"If used on a locked chest, this item teleports the player to a large version of the chest room, where they must survive
                        one to two waves of enemies. Surviving the enemies will unlock the chest
                     
If used on a locked door, it will unlock it
Picking up Drill increases the chance of finding the other Payday 2 promo items - Loot Bag and Clown Mask
UNLOCK: Unlock this item by picking it up from a shop, either by stealing it or making the shopkeeper mad",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by picking it up from a shop, either by stealing it or making the shopkeeper mad"},
{@"Type", @"Active"},
},
        @"")},

{605, new ItemData(
        605,
        @"Loot Bag",
        @"""Doesn't Float""",
        @"This item causes enemies to drop more money
Selling to the Sell Creep grants twice as much money
Taking damage causes the player to drop a random amount of money between 15 to 30% of the player's money, up to a maximum
                        of 120 (money dropped this way will disappear after a short while)
                     
Picking up Loot Bag increases the chance of finding the other Payday 2 promo items - Drill and Clown Mask
UNLOCK: Unlock this item by picking it up from a shop, either by stealing it or making the shopkeeper mad",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by picking it up from a shop, either by stealing it or making the shopkeeper mad"},
{@"Type", @"Passive"},
},
        @"")},

{529, new ItemData(
        529,
        @"Battle Standard",
        @"""Set your Own!""",
        @"Increases the damage of companions and charmed enemies by +80%
Increases the duration of the charm effect.
UNLOCK: Unlock this item by having two companions at once",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by having two companions at once"},
{@"Type", @"Passive"},
{@"Quality", @"D"},
},
        @"")},

{524, new ItemData(
        524,
        @"Bloody 9mm",
        @"""Be Realistic""",
        @"Gives your guns a chance to fire a beserk round quick bouncy homing piercing bullet that flies around the room damaging enemies.
Slower weapons have a higher chance to fire a beserk round
UNLOCK: Unlock this item by using the Lament Configurum item 20 times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by using the Lament Configurum item 20 times"},
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{558, new ItemData(
        558,
        @"Bottle",
        @"""Heart Container""",
        @"When used, will store an extra heart or ammo pickup in the Bottle for later use
Using the bottle again will consume the contents",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
{@"Quality", @"D"},
},
        @"")},

{521, new ItemData(
        521,
        @"Chance Bullets",
        @"""Good RNG""",
        @"While firing your gun, you have an additional chance to fire bullets from other carried guns
Has no effect if you only have one gun",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{573, new ItemData(
        573,
        @"Chest Teleporter",
        @"""Zap""",
        @"When used on a chest, this item will teleport it to the next floor
Teleported chests appear either in the starting room or the foyer before the boss. The latter option will also upgrade the chest in quality.
UNLOCK: Unlock this gun by killing The Robot's past",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this gun by killing The Robot's past"},
{@"Type", @"Active"},
{@"Quality", @"A"},
},
        @"")},

{569, new ItemData(
        569,
        @"Chaos Bullets",
        @"""Taste The Rainbow""",
        @"Bullets gain random bullet effects
UNLOCK: Unlock this item by killing High Dragun in challenge mode, or by failing challenge mode 30 total times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing High Dragun in challenge mode, or by failing challenge mode 30 total times"},
{@"Type", @"Passive"},
{@"Quality", @"A"},
},
        @"")},

{527, new ItemData(
        527,
        @"Charming Rounds",
        @"""Made With Love""",
        @"Fired bullets now have a chance to charm enemies on hit
UNLOCK: Unlock this item by purchasing it from Doug for 14 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Doug for 14 Hegemony Credits"},
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{572, new ItemData(
        572,
        @"Chicken Flute",
        @"""Fowl Play""",
        @"Spawns a chicken that follows you, deals contact damage to enemies and blocks bullets
After taking a certain amount of damage, an army of chickens will spawn and attack all enemies in the room
UNLOCK: Unlock this item by killing The Bullet's past",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing The Bullet's past"},
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{571, new ItemData(
        571,
        @"Cursed Bullets",
        @"""Too Spooky""",
        @"+1 Curse up
+10% damage for each point of curse you have
UNLOCK: Unlock this item by defeating the shadow magician 5 times",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating the shadow magician 5 times"},
{@"Type", @"Passive"},
{@"Quality", @"C"},
},
        @"")},

{531, new ItemData(
        531,
        @"Flak Bullets",
        @"""Catch Some!""",
        @"Whenever a bullet hits a wall or enemy, it will split into smaller low damage bullets
The smaller bullets do varying amount of damage per gun
UNLOCK: Unlock this item by purchasing it from Doug for 28 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Doug for 28 Hegemony Credits"},
{@"Type", @"Passive"},
{@"Quality", @"C"},
},
        @"")},

{564, new ItemData(
        564,
        @"Full Metal Jacket",
        @"""Automated Defenses""",
        @"Just before taking damage, one of your blanks will be automatically used and the damage will be prevented
Will work and negate contact and fall damage",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{532, new ItemData(
        532,
        @"Gilded Bullets",
        @"""The Gun Percent""",
        @"Damage up by roughly +0.4% per coin you hold
Exact damage increase is calculated by (coins/500) * (2 - coins/500)
The effect of this item maxes out at +100% damage at 500 coins
UNLOCK: Unlock this item by purchasing all items and guns from Doug",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing all items and guns from Doug"},
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{565, new ItemData(
        565,
        @"Glass Guon Stone",
        @"""Fleeting Defense""",
        @"Orbits the player and blocks enemy shots
Breaks if you take damage
Using a glass shrine will grant 3 Glass Guon Stones
You can have multiple Glass Guon Stones
After unlocking, will frequently appear in shops and drop after room clears
UNLOCK: Unlock this item by using a glass shrine",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by using a glass shrine"},
{@"Type", @"Passive"},
},
        @"")},

{568, new ItemData(
        568,
        @"Helix Bullets",
        @"""Praise Be""",
        @"Causes your bullets to double up and travel in a Helix pattern, similar to the Helix gun
Each bullet does 66% of its original damage
UNLOCK: Unlock this item by purchasing it from Doug for 16 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Doug for 16 Hegemony Credits"},
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{580, new ItemData(
        580,
        @"Ser Junkan",
        @"""Next Time... Who Is He?""",
        @"Ser Junkan follows you around and targets enemies. He starts by pushing enemies around without dealing damage and picking up Junk will level him up
1 Junk -  Attacks enemies slowly with 3 damage
2 Junk - Attacks slightly faster at 5 damage
3 Junk - Attacks faster at 7 damage
4 Junk - Attacks with 9 damage
5 Junk - Can use a spin attack that deals 10 damage to all enemies around him
6 Junk - Sometimes runs to you and uses a blank. Now deals ~13 damage. Also if you die Ser Junkan will sacrifice himself and revive you at full health
7 Junk - Rapid fires bullets at 10 damage each. Loses abilities from previous form.
Before unlocking this item, it has a 20% chance to replace normal Junk items that can drop after destroying a chest
After unlocking, has a 5% chance to replace Junk and can be found as a regular item
UNLOCK: Unlock this item by upgrading Ser Junkan with 3 or more Junk and then killing a boss",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by upgrading Ser Junkan with 3 or more Junk and then killing a boss"},
{@"Type", @"Passive"},
{@"Quality", @"C"},
},
        @"")},

{525, new ItemData(
        525,
        @"Lament Configurum",
        @"""Shellraiser""",
        @"When used, spawns 3-5 enemies and has a chance to spawn a gun or item
Has a 20% chance to self-harm when a gun or item is spawned
Items and guns spawned increase curse by +1 when picked up
Items and guns will be of quality B, A or S
Curse +1 while held
UNLOCK: Unlock this item by rescuing Daisuke",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by rescuing Daisuke"},
{@"Type", @"Active"},
{@"Quality", @"B"},
},
        @"")},

{533, new ItemData(
        533,
        @"Magic Bullets",
        @"""Sufficiently Advanced""",
        @"Your bullets now have a small chance to transmogrify enemies into chickens
UNLOCK: Unlock this item by purchasing it from Doug for 18 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Doug for 18 Hegemony Credits"},
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{536, new ItemData(
        536,
        @"Relodestone",
        @"""Magunetic North""",
        @"When used, for a short while this item will will absorb enemy bullets and convert them into ammo
Reload times are reduced by half while held",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
{@"Quality", @"S"},
},
        @"")},

{530, new ItemData(
        530,
        @"Remote Bullets",
        @"""The Unseen Hand""",
        @"Fired bullets can be guided by your crosshair
+10% Damage up",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"C"},
},
        @"")},

{567, new ItemData(
        567,
        @"Roll Bomb",
        @"""Power Charge""",
        @"Dodge rolling will leave a bomb that explodes and damages enemies
Bombs deal 5 damage on touch and 20 damage in the explosion radius
UNLOCK: Unlock this item by purchasing it from Doug for 12 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Doug for 12 Hegemony Credits"},
{@"Type", @"Passive"},
{@"Quality", @"C"},
},
        @"")},

{538, new ItemData(
        538,
        @"Silver Bullets",
        @"""Blessed Metal""",
        @"+225% damage to Jammed enemies
+25% damage to bosses
UNLOCK: Unlock this item by purchasing it from Doug for 8 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Doug for 8 Hegemony Credits"},
{@"Type", @"Passive"},
{@"Quality", @"C"},
},
        @"")},

{526, new ItemData(
        526,
        @"Springheel Boots",
        @"""Double Jump""",
        @"Allows a second dodge roll while rolling
The second dodge roll can be in any direction, not just the same direction as the first roll
UNLOCK: Unlock this item by killing 15 Keybullet kin",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing 15 Keybullet kin"},
{@"Type", @"Passive"},
{@"Quality", @"D"},
},
        @"")},

{523, new ItemData(
        523,
        @"Stout Bullets",
        @"""Up Close And Personal""",
        @"Close range bullets deal significantly more damage, and at further ranges bullets deal slightly less damage than usual
Damage modifications vary for different guns. Increases are between 33-75%, decreases are between 12.5-33%
-30% shot speed
UNLOCK: Unlock this item by purchasing it from Doug for 12 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Doug for 12 Hegemony Credits"},
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{449, new ItemData(
        449,
        @"Teleporter Prototype",
        @"""Teleport!?""",
        @"When used, will teleport you to a random room on the map
Has a very small chance to teleport you to the next floor
Has a very small chance to teleport you to a room with a large eyeball
UNLOCK: Unlock this item by purchasing it from Doug for 22 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Doug for 22 Hegemony Credits"},
{@"Type", @"Active"},
{@"Quality", @"B"},
},
        @"")},

{570, new ItemData(
        570,
        @"Yellow Chamber",
        @"""The Jammed Thing""",
        @"When entering a room, this item gives a small chance to charm a random enemy for the rest of the room. The charmed enemy dies when the room is cleared
+2 HP up
+15% fire rate up
+2 curse up
UNLOCK: Unlock this item by killing 10 'Confirmed' enemies (the cloaked bullet kin) OR by teleporting to an eyeball room with Teleporter Prototype",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by killing 10 'Confirmed' enemies (the cloaked bullet kin) OR by teleporting to an eyeball room with Teleporter Prototype"},
{@"Type", @"Passive"},
{@"Quality", @"S"},
},
        @"")},

{528, new ItemData(
        528,
        @"Zombie Bullets",
        @"""Unfinished Business""",
        @"Occasionally refunds ammo when bullets miss",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"C"},
},
        @"")},

{664, new ItemData(
        664,
        @"Baby Good Mimic",
        @"""Imitation Love""",
        @"A friendly mimic that deals contact damage and will sometimes bite enemies randomly
When in a room with enemies will remain still in one place. After being hit it will fire randomly for a few seconds and then return to being stationary. This cycle repeats until the room is cleared
Can transform into one of your other familiars, if you have any",
        new Dictionary<string, string>(){
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{630, new ItemData(
        630,
        @"Bumbullets",
        @"""Bumblecore""",
        @"Gives you a chance to fire an attack bee while firing, that has a homing effect
This also works with charged guns, giving a chance to let off a bee while charging
UNLOCK: Unlock this item by purchasing it from Doug for 26 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Doug for 26 Hegemony Credits"},
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{634, new ItemData(
        634,
        @"Crisis Stone",
        @"""Reload. Reload. Reload.""",
        @"Provides invulnerability when reloading an empty clip
UNLOCK: Unlock this item by defeating the High Dragun boss in Turbo Mode",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating the High Dragun boss in Turbo Mode"},
{@"Type", @"Passive"},
{@"Quality", @"A"},
},
        @"")},

{643, new ItemData(
        643,
        @"Daruma",
        @"""Good Fortune""",
        @"When used this item activates a blank, however can only be used after successfully dodging a bullet
UNLOCK: Unlock this item by getting grabbed by a Gripmaster (the hand enemies like the Wallmasters from Zelda)",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by getting grabbed by a Gripmaster (the hand enemies like the Wallmasters from Zelda)"},
{@"Type", @"Active"},
{@"Quality", @"B"},
},
        @"")},

{638, new ItemData(
        638,
        @"Devolver Rounds",
        @"""Two Steps Back""",
        @"Gives bullets a chance to 'devolve' enemies, turning them into Shotgun Kin.
A Shotgun Kin can be devolved again into a Bulletkin, and then again into an Arrowkin
UNLOCK: Unlock this item by purchasing it from Doug for 20 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Doug for 20 Hegemony Credits"},
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{641, new ItemData(
        641,
        @"Gold Junk",
        @"""One Man's Trash""",
        @"+500 casings when picked up
An uncommon drop from destroying chests
If you have Ser Junkan, he will appear wielding a green sword in a gold mech suit and will fire missiles
UNLOCK: Unlock this item by destroying either a red, black or rainbow chest",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by destroying either a red, black or rainbow chest"},
{@"Type", @"Passive"},
{@"Quality", @""},
},
        @"")},

{631, new ItemData(
        631,
        @"Holey Grail",
        @"""Withered Vessel""",
        @"Taking damage triggers a blank and refills 50% of the ammo in each of your guns
Curse Up
UNLOCK: Unlock this item by defeating the Advanced Dragun boss",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating the Advanced Dragun boss"},
{@"Type", @"Passive"},
{@"Quality", @"D"},
},
        @"")},

{655, new ItemData(
        655,
        @"Hungry Bullets",
        @"""Hungry Hungry""",
        @"Your bullets now have a chance to block enemy bullets and projectiles
UNLOCK: Unlock this item by getting caught by a Tarnisher (the barrel like enemies that chase you)",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by getting caught by a Tarnisher (the barrel like enemies that chase you)"},
{@"Type", @"Passive"},
{@"Quality", @"A"},
},
        @"")},

{665, new ItemData(
        665,
        @"Macho Brace",
        @"""Value for Effort""",
        @"After dodge rolling you glow yellow for a brief moment. The first bullet fired while glowing yellow deals extra damage
UNLOCK: Unlock this item by buying from Synergrace 3 times (the lady who sells synergy chests)",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by buying from Synergrace 3 times (the lady who sells synergy chests)"},
{@"Type", @"Passive"},
{@"Quality", @"C"},
},
        @"")},

{662, new ItemData(
        662,
        @"Partially-Eaten Cheese",
        @"""Aged Almost 40 Years""",
        @"When used, temporarily turns you into Pac-Man, killing any enemies you touch
Bosses take some damage instead of dying
You can still use your guns while in Pac-Man mode
UNLOCK: Unlock this item by finding it in a chest after beating the Resourceful Rat",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by finding it in a chest after beating the Resourceful Rat"},
{@"Type", @"Active"},
{@"Quality", @"A"},
},
        @"")},

{644, new ItemData(
        644,
        @"Portable Table Device",
        @"""Know when To Fold 'Em""",
        @"When used will spawn a table, which you can flip to hide behind
Tables break after taking enough damage
Can be used 3 times. After that it will recharge as a normal active item would
UNLOCK: Unlock this item by dodge-rolling over a lot of tables",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by dodge-rolling over a lot of tables"},
{@"Type", @"Active"},
{@"Quality", @"D"},
},
        @"")},

{627, new ItemData(
        627,
        @"Platinum Bullets",
        @"""Over One Million Served""",
        @"Damage Up
Fire rate up with each successful kill
UNLOCK: Unlock this item by purchasing it from Ox and Cadence for 200 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Ox and Cadence for 200 Hegemony Credits"},
{@"Type", @"Passive"},
{@"Quality", @"S"},
},
        @"")},

{667, new ItemData(
        667,
        @"Rat Boots",
        @"""Hover Craft""",
        @"Grants temporary invulnerability and flight when the wearer walks out over a pit
Can be found in one of the chests that appear after the Resourceful Rat boss fight. After finding it there once it can be found elsewhere too
UNLOCK: Unlock this item by finding it in a chest after defeating the Resourceful Rat",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by finding it in a chest after defeating the Resourceful Rat"},
{@"Type", @"Passive"},
{@"Quality", @"C"},
},
        @"")},

{663, new ItemData(
        663,
        @"Resourceful Sack",
        @"""Pack Rat's Rat Pack""",
        @"Allows you to steal enemy bullets by dodge rolling through them
When used, the sack will use all stolen bullets and fires a cheese that does damage based on the number of bullets that were stolen",
        new Dictionary<string, string>(){
{@"Type", @"Active"},
{@"Quality", @"A"},
},
        @"")},

{463, new ItemData(
        463,
        @"Ring of the Resourceful Rat",
        @"""Fufufufufufu""",
        @"If the Resourceful Rat takes an item or gun, he will give another item or gun of the same type and quality
You get one 'trade' per floor. Unused trades will be carried over to future floors, but only from the point of picking up this item
Letting the rat steal ""Bullet That Can Kill The Past"" while holding this item will cause him to drop an S tier item
UNLOCK: Unlock this item by defeating the first 2 phases of the Resourceful Rat boss fight",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by defeating the first 2 phases of the Resourceful Rat boss fight"},
{@"Type", @"Passive"},
{@"Quality", @"B"},
},
        @"")},

{636, new ItemData(
        636,
        @"Snowballets",
        @"""Powder Power""",
        @"Bullets grow in size and damage as they travel
UNLOCK: Unlock this item by purchasing it from Doug for 26 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Doug for 26 Hegemony Credits"},
{@"Type", @"Passive"},
{@"Quality", @"A"},
},
        @"")},

{632, new ItemData(
        632,
        @"Turkey",
        @"""Triple Tap""",
        @"Gives you back 1 ammo after landing three sequential shots
Gives you a turkey friend
UNLOCK: Unlock this item by using the Companion shrine twice",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by using the Companion shrine twice"},
{@"Type", @"Passive"},
{@"Quality", @"C"},
},
        @"")},

{640, new ItemData(
        640,
        @"Vorpal Bullets",
        @"""Through and Through""",
        @"When firing, this item gives a chance to fire a special round that deals massive damage
UNLOCK: Unlock this item by purchasing it from Doug for 26 Hegemony Credits",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by purchasing it from Doug for 26 Hegemony Credits"},
{@"Type", @"Passive"},
{@"Quality", @"A"},
},
        @"")},

{637, new ItemData(
        637,
        @"Weird Egg",
        @"""Miracle of Gun""",
        @"A single use active item that has different effects depending on what you do with it
Simply using it will replenish all your heart containers
Dropping it and shooting it will spawn a random gun or item
Dropping the egg into a fire will spawn a serpent that will follow you around. Taking this serpent to the Dragun boss will cause it to become the 'Advanced Dragun', which changes its third phase to be more difficult
UNLOCK: Unlock this item by entering the Resourceful Rat's Lair for the first time",
        new Dictionary<string, string>(){
{@"UNLOCK", @"Unlock this item by entering the Resourceful Rat's Lair for the first time"},
{@"Type", @"Active"},
{@"Quality", @"D"},
},
        @"")},


};
    }
}