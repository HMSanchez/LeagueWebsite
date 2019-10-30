using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeagueSite.Models
{
    public class ChampionListModel
    {
        public Dictionary<String, ChampionModel> data { get; set; } = new Dictionary<string, ChampionModel>();
        public string type { get; set; }
        public string format { get; set; }
        public string version { get; set; }
    }
}