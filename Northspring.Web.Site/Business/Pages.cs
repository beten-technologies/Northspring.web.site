using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Northspring.Web.Site.Business
{
    class Pages
    {
        private string defaultPageName = "~/Views/Shared/_pagedown.cshtml";
        public Pages()
        {

        }

        public string GetDynamicPageName(string pageNameFromUrl, string controller = "Home", string action = "Pages")
        {
            if (string.IsNullOrEmpty(pageNameFromUrl))
                return defaultPageName;

            string partialViewName = "~/Views/" + controller + "/" + action + "/_" + pageNameFromUrl.ToLower() + ".cshtml";

            return partialViewName;
        }

        public string GetDefaultPageName()
        {
            return defaultPageName;
        }
    }
}
