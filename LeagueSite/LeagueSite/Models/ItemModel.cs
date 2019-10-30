using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeagueSite.Models
{
    public class ItemModel
    {
        public string name { get; set; }
        public RuneDetails rune { get; set; }
        public GoldInfo gold { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string colloq { get; set; }
        public string plaintext { get; set; }
        public bool consumed { get; set; }
        public int stacks { get; set; }
        public int depth { get; set; }
        public bool consumeOnFull { get; set; }
        public string[] from { get; set; }
        public string[] into { get; set; }
        public int specialRecipe { get; set; }
        public bool inStore { get; set; }
        public bool hideFromAll { get; set; }
        public string requiredChampion { get; set; }
        public string requiredAlly { get; set; }
        public Dictionary<string,double> stats { get; set; }
        public string[] tags { get; set; }
        public Dictionary<int,bool> maps { get; set; }

    }
    public class RuneDetails
    {
        public bool isrune { get; set; }
        public int tier { get; set; }
        public string type { get; set; }
    }
    public class GoldInfo
    {
        public int Base { get; set; }
        public int total { get; set; }
        public int sell { get; set; }
        public bool purchasable { get; set; }
    }
}