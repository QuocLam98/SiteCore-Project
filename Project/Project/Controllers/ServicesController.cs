using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore;
using Sitecore.Mvc;
using Sitecore.Mvc.Presentation;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace Project.Controllers
{ 
    public class ServicesController : Controller
    {
        // GET: Navigation
        public ActionResult GetServices()
        {
            //Get the current DB
            Database currentDb = Sitecore.Context.Database;
            //Get the datasource
            string dataSourcePath = RenderingContext.Current.Rendering.DataSource;
            Item dataSource = currentDb.GetItem(dataSourcePath);
            //Get the list of Navigation Items from the datasource
            List<Item> serviceItems = dataSource.GetChildren().ToList();
            //Pass the list of Items as a Model to the View
            return View("/Views/ServicesSection.cshtml", serviceItems);
        }
    }
}
