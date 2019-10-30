using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeagueSite.Models
{
    public class ItemListModel
    {
        public string type { get; set; }
        public string version { get; set; }
        public ItemModel basic { get; set; }
        public Dictionary<string, ItemModel> data { get; set; }
        public Dictionary<string, string>[] groups { get; set; }
        public ItemTree[] tree { get; set; }
    }
    public class ItemTree
    {
        public string header { get; set; }
        public string[] tags { get; set; }
    }
}