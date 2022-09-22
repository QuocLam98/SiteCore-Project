using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Project.Controllers
{
    public class NavigationController : Controller
    {
        // Get : Navigation

        public ActionResult HeaderNav()
        {
            //Get the current DB
            Database currentDb = Sitecore.Context.Database;
            //Get the datasource
            string dataSourcePath = RenderingContext.Current.Rendering.DataSource;
            Item dataSource = currentDb.GetItem("{3D6AA066-6618-4B24-8E0A-16FAB1281B27}");
            //Get the list of Navigation Items from the datasource
            List<Item> navigationItems = dataSource.GetChildren().ToList();
            //Pass the list of Items as a Model to the View
            return View("/Views/Header_Navigation.cshtml", navigationItems);
        }

        public ActionResult FooterNav()
        {
            //Get the current DB
            Database currentDb = Sitecore.Context.Database;
            //Get the datasource
            string dataSourcePath = RenderingContext.Current.Rendering.DataSource;
            Item dataSource = currentDb.GetItem("{C9A25C5E-FA60-40E6-A13C-4A4CFA55D27F}");
            //Get the list of Navigation Items from the datasource
            List<Item> navigationItems = dataSource.GetChildren().ToList();
            //Pass the list of Items as a Model to the View
            return View("/Views/Footer_Navigation.cshtml", navigationItems);
        }
    }
}

