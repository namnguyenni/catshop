using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CatShop.Models;


namespace CatShop.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            CAT_SHOP1Entities data = new CAT_SHOP1Entities();
            MultiCustomModel multicus = new MultiCustomModel();
            var cattable = data.Meos;

            List<CatCustomModel> listcats = new List<CatCustomModel>();
            foreach (var item in cattable)
            {
                listcats.Add(new CatCustomModel
                {
                    
                    Id = item.Id,
                    img = item.img
                    
                });

                
                
            }
            
            multicus.ModelCAT_Trending.AddRange(listcats);

            


            return View(multicus);
        }




        public ActionResult Shop()
        {
            return View();
        }


    }
}
