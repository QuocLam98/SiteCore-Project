#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Project;
    
    #line 1 "..\..\Views\Navigation.cshtml"
    using Sitecore;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Navigation.cshtml"
    using Sitecore.Data;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Navigation.cshtml"
    using Sitecore.Data.Items;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Navigation.cshtml"
    using Sitecore.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Navigation.cshtml")]
    public partial class _Views_Navigation_cshtml : System.Web.Mvc.WebViewPage<List<Item>>
    {
        public _Views_Navigation_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Navigation.cshtml"
 if (Model == null || Model.Count <= 0)
{
    return;
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\Views\Navigation.cshtml"
  
    Database currentDb = Sitecore.Context.Database; //Extract the current Db
    Item homeItem = currentDb.GetItem("{3069770B-30C3-41A4-A68C-B5052B3C100E}"); //Get the item /sitecore/content/Home

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" id=\"sticky-header\"");

WriteLiteral(" class=\"main-header-area\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"header_bottom_border\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row align-items-center\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-12 d-block d-lg-none\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"logo\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 24 "..\..\Views\Navigation.cshtml"
                   Write(Html.Sitecore().Field("Link", homeItem,
                         new { text = @Html.Sitecore().Field("Image", homeItem) }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-xl-9 col-lg-9\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"main-menu  d-none d-lg-block\"");

WriteLiteral(">\r\n                        <nav>\r\n                            <ul");

WriteLiteral(" id=\"navigation\"");

WriteLiteral(">\r\n");

            
            #line 32 "..\..\Views\Navigation.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Navigation.cshtml"
                                 foreach (Item menuItem in Model)
                                {
                                    if (menuItem.GetChildren().Count > 0)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li>\r\n");

WriteLiteral("                                            ");

            
            #line 37 "..\..\Views\Navigation.cshtml"
                                       Write(Html.Sitecore().Field("Link", menuItem,
                                            new
                                            {
                                                text = @Html.Sitecore().Field(
                                            "Title", menuItem) + "< i class=\"ti-angle-down\"></i>"
                                                 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            <ul");

WriteLiteral(" class=”submenu”");

WriteLiteral(">\r\n");

            
            #line 44 "..\..\Views\Navigation.cshtml"
                                                
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Navigation.cshtml"
                                                 foreach (Item childMenuItem in menuItem.GetChildren())
                                                {

            
            #line default
            #line hidden
WriteLiteral("                                                    <li>\r\n");

WriteLiteral("                                                        ");

            
            #line 47 "..\..\Views\Navigation.cshtml"
                                                   Write(Html.Sitecore().Field("Link", childMenuItem,
                                                        new
                                                             {
                                                                 text = @Html.Sitecore().Field(
                                                        "Link", childMenuItem)
                                                             }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                    </li>\r\n");

            
            #line 54 "..\..\Views\Navigation.cshtml"
                                                }

            
            #line default
            #line hidden
WriteLiteral("                                            </ul>\r\n                              " +
"          </li>\r\n");

            
            #line 57 "..\..\Views\Navigation.cshtml"
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li>\r\n");

WriteLiteral("                                            ");

            
            #line 61 "..\..\Views\Navigation.cshtml"
                                       Write(Html.Sitecore().Field("Link", menuItem,
                                            new
                                            {
                                                text = @Html.Sitecore().Field(
                                            "Title", menuItem)
                                            }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </li>\r\n");

            
            #line 68 "..\..\Views\Navigation.cshtml"
                                    }
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\r\n                        </nav>\r\n              " +
"      </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-xl-3 col-lg-3 d-none d-lg-block\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"Appointment justify-content-end\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"search_btn\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#exampleModalCenter\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"ti-search\"");

WriteLiteral("></i>\r\n                            </a>\r\n                        </div>\r\n        " +
"            </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-12\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"mobile_menu d-block d-lg-none\"");

WriteLiteral("></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>" +
"\r\n</div>");

        }
    }
}
#pragma warning restore 1591
