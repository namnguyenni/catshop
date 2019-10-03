using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CatShop.Models;
using System.Linq;


namespace CatShop.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            MultiCustomModel multicus = new MultiCustomModel();

            multicus.ModelCAT_CarouselStart.AddRange(GetCatCarouselStart());
            multicus.ModelCAT_Trending.AddRange(GetSellCatTrending());
            multicus.ModelCAT_BestSeller.AddRange(GetSellCatBestSeller());
            multicus.ModelCAT_BlogSection.AddRange(GetSellCatBlogSection());
            return View(multicus);
        }

        public List<CatCustomModel> GetCatCarouselStart()
        {
            List<CatCustomModel> listcats = new List<CatCustomModel>();
            CAT_SHOP1Entities data = new CAT_SHOP1Entities();
            var cattable = data.BestCats;
            var cattable1 = data.Meos;
            var item = (from a in cattable
                        join b in cattable1 on a.Id equals b.Id
                        where a.Check_cat == 1
                        select new
                        {
                            id = b.Id,
                            img = b.img
                        }).ToList();

            foreach (var i in item)
            {
                listcats.Add(new CatCustomModel
                {
                    Id = i.id,
                    img = i.img
                });
            }
            return listcats;
        }

        public List<CatCustomModel> GetSellCatTrending()
        {
            List<CatCustomModel> listcats = new List<CatCustomModel>();
            CAT_SHOP1Entities data = new CAT_SHOP1Entities();
            var cattable = data.MaxMonneyCats;
            var cattable1 = data.Meos;
            var item = (from a in cattable
                        join b in cattable1 on a.Id equals b.Id
                        where a.Check_cat == 1
                        select new
                        {
                            id = b.Id,
                            img = b.img
                        }).ToList();

            foreach (var i in item)
            {
                listcats.Add(new CatCustomModel
                {
                    Id = i.id,
                    img = i.img
                });
            }
            return listcats;
        }


        public List<CatCustomModel> GetSellCatBestSeller()
        {
            List<CatCustomModel> listcats = new List<CatCustomModel>();
            CAT_SHOP1Entities data = new CAT_SHOP1Entities();
            var cattable = data.SellerCats;
            var cattable1 = data.Meos;
            var item = (from a in cattable
                        join b in cattable1 on a.Id equals b.Id
                        where a.Check_cat == 1
                        select new
                        {
                            id = b.Id,
                            img = b.img
                        }).ToList();

            foreach (var i in item)
            {
                listcats.Add(new CatCustomModel
                {
                    Id = i.id,
                    img = i.img
                });
            }
            return listcats;
        }

        public List<CatCustomModel> GetSellCatBlogSection()
        {
            List<CatCustomModel> listcats = new List<CatCustomModel>();
            CAT_SHOP1Entities data = new CAT_SHOP1Entities();
            var cattable = data.LastNews;
            var cattable1 = data.Meos;
            var item = (from a in cattable
                        join b in cattable1 on a.Id equals b.Id
                        where a.Check_cat == 1
                        select new
                        {
                            id = b.Id,
                            img = b.img
                        }).ToList();

            foreach (var i in item)
            {
                listcats.Add(new CatCustomModel
                {
                    Id = i.id,
                    img = i.img
                });
            }
            return listcats;
        }


        public ActionResult Shop()
        {
            return View();
        }


    }
}
