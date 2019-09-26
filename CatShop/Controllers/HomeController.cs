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

            var cattable = data.Meos;

            List<CatCustomModel> listcats = new List<CatCustomModel>();
            foreach (var item in cattable)
            {
                listcats.Add(new CatCustomModel
                {
                    
                    Id = item.Id,
                    img = item.img
                    
                });

                
                if (listcats.Count == 8)
                {
                    break;
                }
            }
            MultiCustomModel multicus = new MultiCustomModel();
            multicus.ModelCAT.AddRange(listcats);


            return View(multicus);
        }




        public ActionResult Shop()
        {
            return View();
        }


    }
}
