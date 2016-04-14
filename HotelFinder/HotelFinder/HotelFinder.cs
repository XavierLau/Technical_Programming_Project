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
    /// <summary>
    /// The application allows a user to search for hotels around a given country and city using the google maps api, places library,
    /// and geodata library.
    /// 
    /// Authors: Xavier Lau, Daniel Lei Zhang
    /// </summary>
    [ComVisible(true)]
    public partial class HotelFinder : Form
    {
        //creates a list of hotels
        private List<Hotel> hotelList = new List<Hotel>();
        //creates a list of panels
        private List<Panel> panelList = new List<Panel>();

        public HotelFinder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the map, populates the combobox, enables this form to be accessed by javascript within the webbrowser.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //loads maps
            webBrowserMap.DocumentText = Properties.Resources.home;
            //populates combobox with country names
            PopulateCountryComboBox();
            //allows the form to be accessed with javascript
            webBrowserMap.ObjectForScripting = this;
        }

        /// <summary>
        /// Populates the combobox with every country.
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

        /// <summary>
        /// Initiates the process of finding all hotels in a given area and returning the results to the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchJS.SearchCityBounds(webBrowserMap, textBoxSearch.Text, comboBoxCountry.SelectedItem.ToString());
        }

        /// <summary>
        /// Creates a panel, gives it a flowlayout, three labels to it, and adds the panel to the 
        /// flowlayoutpanel that holds all hotel results.
        /// </summary>
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
            flowLayoutPanel.Click += new EventHandler(onPanelClick);
            textBoxName.Text = name;
            textBoxAddress.Text = address;
            textBoxRating.Text = "Rating: " + rating;

            panel.Controls.Add(flowLayoutPanel);
            flowLayoutPanel.Controls.Add(textBoxName);
            flowLayoutPanel.Controls.Add(textBoxAddress);
            flowLayoutPanel.Controls.Add(textBoxRating);
            flowLayoutPanelResults.Controls.Add(panel);
            panelList.Add(panel);
        }

        /// <summary>
        /// Clears all previous panels.
        /// </summary>
        public void clearPanels()
        {
            foreach (Panel panel in panelList)
            {
                flowLayoutPanelResults.Controls.Remove(panel);
            }
            panelList.Clear();
        }

        /// <summary>
        /// Adds a single hotel to the hotel list.
        /// </summary>
        /// <param name="name">the name of the hotel</param>
        /// <param name="address">the address of the hotel</param>
        /// <param name="rating">the hotels review rating</param>
        public void addHotel(string name, string address, string rating, string phoneNumber, string photo)
        {
            Hotel hotel = new Hotel();
            hotel.Name = name;
            hotel.Address = address;
            hotel.Rating = rating;
            hotel.PhoneNumber = phoneNumber;
            hotel.Photos = photo;
            hotelList.Add(hotel);
        }

        /// <summary>
        /// Clears the list of hotels.
        /// </summary>
        public void clearHotelList()
        {
            hotelList.Clear();
        }

        /// <summary>
        /// Panel click function that brings up another view with more detailed information about a certain hotel.
        /// </summary>
        /// <param name="sender"></param
        private void onPanelClick(object sender, EventArgs e)
        {
            foreach (Hotel x in hotelList)
            {
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Address);
                Console.WriteLine(x.Rating);
                Console.WriteLine(x.PhoneNumber);
                Console.WriteLine(x.Photos);
            }
        }
    }
}
