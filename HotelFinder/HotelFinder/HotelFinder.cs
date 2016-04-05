using System;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Drawing;
using System.Runtime.InteropServices;

namespace HotelFinder
{
    [ComVisible(true)]
    public partial class HotelFinder : Form
    {
        private List<Hotel> hotelList = new List<Hotel>();
        private List<Panel> panelList = new List<Panel>();

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
            webBrowserMap.ObjectForScripting = this;
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
        }

        public void addPanel(string name, string address, string rating)
        {
            Label textBoxName = new Label();
            Label textBoxAddress = new Label();
            Label textBoxRating = new Label();
            Panel panel = new Panel();
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

            textBoxName.AutoSize = true;
            textBoxAddress.AutoSize = true;
            textBoxRating.AutoSize = true;

            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Click += new EventHandler(onPanelClick);
            textBoxName.Text = name;
            textBoxAddress.Text = address;
            textBoxRating.Text = "Rating: "+ rating;
            panel.Controls.Add(flowLayoutPanel);
            flowLayoutPanel.Controls.Add(textBoxName);
            flowLayoutPanel.Controls.Add(textBoxAddress);
            flowLayoutPanel.Controls.Add(textBoxRating);
            flowLayoutPanelResults.Controls.Add(panel);
            panelList.Add(panel);
        }

        public void clearPanels()
        {
            foreach (Panel panel in panelList)
            {
                flowLayoutPanelResults.Controls.Remove(panel);
            }
            panelList.Clear();
        }

        public void addHotel(string name, string address, string rating)
        {
            Hotel hotel = new Hotel();
            hotel.Name = name;
            hotel.Address = address;
            hotel.Rating = rating;
            hotelList.Add(hotel);
        }

        public void clearHotelList()
        {
            hotelList.Clear();
        }

        private void onPanelClick(object sender, EventArgs e)
        {
            foreach (Hotel x in hotelList)
            {
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Address);
                Console.WriteLine(x.Rating);
            }
        }
    }
}
