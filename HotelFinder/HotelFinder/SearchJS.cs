using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelFinder
{
    static class SearchJS
    {
        public static void SearchCityBounds(WebBrowser webBrowser, string city, string country)
        {
            //return the value of the variable from within the javascript code
            object[] returnGeocoder = { "geocoder;" };
            object[] returnMap = { "map;" };
            object geocoder = webBrowser.Document.InvokeScript("eval", returnGeocoder);
            object map = webBrowser.Document.InvokeScript("eval", returnMap);
            object[] javascriptParam = { city, country, geocoder, map };
            webBrowser.Document.InvokeScript("geocodeAddress", javascriptParam);
        }

        public static string returnPlaceID(WebBrowser webbrowser)
        {
            string result = "";
            try
            {
                result = webbrowser.Document.InvokeScript("retrieveplaceid").ToString();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return result;
        }
    }
}
