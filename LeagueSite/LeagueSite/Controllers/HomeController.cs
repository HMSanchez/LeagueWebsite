using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using LeagueSite.Models;
using System.Runtime.Serialization;
using System.Net;
using Newtonsoft.Json;

namespace LeagueSite.Controllers
{
    public class HomeController : Controller
    {
        public string APIKey = "RGAPI-ac5da9b8-6a44-4362-b30c-8fff3c85c296";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Items()
        {
            ItemListModel i = null;
            using(var client=new WebClient())
            {
                var json = client.DownloadString("http://ddragon.leagueoflegends.com/cdn/7.22.1/data/en_US/item.json");
                i = JsonConvert.DeserializeObject<ItemListModel>(json);
            }
            return View(i);
        }
        public ActionResult Item(int? id)
        {
            if (id == null)
            {
                return new HttpNotFoundResult();
            }
            //api call to items
            return View();
        }

        public ActionResult Champions()
        {
            ChampionListModel m = new ChampionListModel();
            using(var client=new WebClient())
            {
                var json = client.DownloadString("http://ddragon.leagueoflegends.com/cdn/7.22.1/data/en_US/champion.json");
                m=JsonConvert.DeserializeObject<ChampionListModel>(json);
            }

            return View(m);
        }
        public ActionResult Champion(string id)
        {
            ChampionListModel c = null;
            if (id == null)
            {
                return new HttpNotFoundResult();
            }
            using (var client = new WebClient())
            {
                var json = client.DownloadString($"http://ddragon.leagueoflegends.com/cdn/7.22.1/data/en_US/champion/{id}.json");
                c = JsonConvert.DeserializeObject<ChampionListModel>(json);
            }
            return View(c.data[id]);
        }

        public ActionResult Profile()
        {
            return View();
        }



    }
}