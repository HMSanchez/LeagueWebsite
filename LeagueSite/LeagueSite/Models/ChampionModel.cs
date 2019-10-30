using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeagueSite.Models
{
    public class ChampionModel
    {
        public string version { get; set; } //list
        public string id { get; set; } //both
        public string key { get; set; } //both
        public string name { get; set; } //both
        public string title { get; set; } //both
        public ImageData image { get; set; } //both
        public ChampionSkin[] skins { get; set; } //full
        public string lore { get; set; } //full
        public string blurb { get; set; } //both
        public string[] allytips { get; set; } //full
        public string[] enemytips { get; set; } //full
        public string[] tags { get; set; } //both
        public string partype { get; set; } //both
        public Dictionary<string,double> info { get; set; } //both
        public Dictionary<string, double> stats { get; set; }//could change to class //both
        public ChampionSpell[] spells { get; set; } //full
        public ChampionPassive passive { get; set; } //full
        public ChampionRecommendedBuilds[] recommended { get; set; } //full
    }
    public class ChampionRecommendedBuilds
    {
        public string champion { get; set; }
        public string title { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public string type { get; set; }
        public string customTag { get; set; }
        public int sortrank { get; set; }
        public bool extensionPage { get; set; }
        public object customPanel { get; set; }//Probably want to figure out what this is
        public BuildsBlocks[] blocks { get; set; }
    }
    public class BuildsBlocks
    {
        public string type { get; set; }
        public bool recMath { get; set; }
        public bool recSteps { get; set; }
        public int minSummonerLevel { get; set; }
        public int maxSummonerLevel { get; set; }
        public string showIfSummonerSpell { get; set; }
        public string hideIfSummonerSpell { get; set; }
        public BuildItem[] items { get; set; }
    }
    public class BuildItem
    {
        public string id { get; set; }
        public int count { get; set; }
        public bool hideCount { get; set; }
    }
    public class ChampionSkin
    {
        public string id { get; set; }
        public int num { get; set; }
        public string name { get; set; }
        public bool chromas { get; set; }
    }
    //public class ChampionInfo
    //{
    //    public int attack { get; set; }
    //    public int defense { get; set; }
    //    public int magic { get; set; }
    //    public int difficulty { get; set; }
    //}
    public class ChampionPassive
    {
        public string name { get; set; }
        public string description { get; set; }
        public ImageData image { get; set; }
    }
    public class ChampionSpell
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string tooltip { get; set; }
        public Dictionary<string, string[]> leveltip { get; set; }
        public int maxrank { get; set; }
        public double[] cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public double[] cost { get; set; }
        public string costBurn { get; set; }
        public double[][] effect { get; set; }
        public string[] effectBurn { get; set; }
        public SpellVars[] vars { get; set; }
        public string costType { get; set; }
        public string maxammo { get; set; }
        public int[] range { get; set; }
        public string rangeBurn { get; set; }
        public ImageData image { get; set; }
        public string resource { get; set; }

        public class SpellVars
        {
            public string link { get; set; }
            public double coeff { get; set; }
            public string key { get; set; }
        }
    }
}