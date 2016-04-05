using System;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Drawing;

namespace HotelFinder
{
    public partial class HotelFinder : Form
    {
        List<Hotel> hotelListing = new List<Hotel>();
        public HotelFinder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loads maps
            webBrowserMap.DocumentText = Properties.Resources.home;
            //populates combobox with country names
            PopulateCountryComboBox();
            hotel = new Hotel();
            webBrowserMap.ObjectForScripting = hotel;
        }

        /// <summary>
        /// 
        /// Source: http://thinkingrounds.blogspot.ca/2014/07/c-combobox-with-all-countries.html
        /// </summary>
        private void PopulateCountryComboBox()
        {
            RegionInfo country = new RegionInfo(new CultureInfo("en-US", false).LCID);
            List<string> countryNames = new List<string>();
            foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                country = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                countryNames.Add(country.DisplayName.ToString());
            }

            IEnumerable nameAdded = countryNames.OrderBy(names => names).Distinct();

            foreach (string item in nameAdded)
            {
                comboBoxCountry.Items.Add(item);
            }

            comboBoxCountry.SelectedIndex = 0;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchJS.SearchCityBounds(webBrowserMap, textBoxSearch.Text, comboBoxCountry.SelectedItem.ToString());
            Console.WriteLine(SearchJS.returnPlaceID(webBrowserMap));
            
            dynamicPanels(12);
        }

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private List<string> hotelName = new List<string>();
        private List<Panel> panels = new List<Panel>();

        public void dynamicPanels(int hotelNumber)
        {
            //Remove previous panels
            foreach(Panel panel in panels)
            {
                this.Controls.Remove(panel);
            }

            //clear panels list
            panels.Clear();

            for (int i = 0; i < hotelNumber; i++)
            {
                Panel pnl = new Panel();
                pnl.Location = new Point(12, 0 + i * 50);
                pnl.Size = new Size(150, 50);
                pnl.BackColor = Color.White;
                pnl.BorderStyle = BorderStyle.FixedSingle;

                panels.Add(pnl);
                panels[i].Click += new EventHandler(clickPanel);
                panel2.Controls.Add(panels[i]);
            }
        }

        private void clickPanel(object sender, EventArgs e)
        {
            Console.WriteLine("hello");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(hotel.Name);
        }
    }
}
