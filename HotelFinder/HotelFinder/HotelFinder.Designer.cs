namespace HotelFinder
{
    partial class HotelFinder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowserMap = new System.Windows.Forms.WebBrowser();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.singleHotelPanel = new System.Windows.Forms.Panel();
            this.labelHotelRating = new System.Windows.Forms.Label();
            this.labelHotelPhoneNumber = new System.Windows.Forms.Label();
            this.labelHotelAddress = new System.Windows.Forms.Label();
            this.labelHotelName = new System.Windows.Forms.Label();
            this.pictureBoxHotelImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelResults = new System.Windows.Forms.FlowLayoutPanel();
            this.backbtn = new System.Windows.Forms.Button();
            this.panelSearch.SuspendLayout();
            this.singleHotelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelImage)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMap.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(30, 28);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.ScrollBarsEnabled = false;
            this.webBrowserMap.Size = new System.Drawing.Size(1002, 713);
            this.webBrowserMap.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(18, 30);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(390, 28);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(296, 143);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 32);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(18, 108);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(390, 26);
            this.comboBoxCountry.TabIndex = 4;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(20, 8);
            this.labelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(44, 18);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "City";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(20, 86);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(71, 18);
            this.labelCountry.TabIndex = 6;
            this.labelCountry.Text = "Country";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.labelCountry);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.labelCity);
            this.panelSearch.Controls.Add(this.comboBoxCountry);
            this.panelSearch.Location = new System.Drawing.Point(0, -1);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(428, 190);
            this.panelSearch.TabIndex = 7;
            // 
            // singleHotelPanel
            // 
            this.singleHotelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.singleHotelPanel.AutoScroll = true;
            this.singleHotelPanel.Controls.Add(this.backbtn);
            this.singleHotelPanel.Controls.Add(this.labelHotelRating);
            this.singleHotelPanel.Controls.Add(this.labelHotelPhoneNumber);
            this.singleHotelPanel.Controls.Add(this.labelHotelAddress);
            this.singleHotelPanel.Controls.Add(this.labelHotelName);
            this.singleHotelPanel.Controls.Add(this.pictureBoxHotelImage);
            this.singleHotelPanel.Location = new System.Drawing.Point(0, 184);
            this.singleHotelPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.singleHotelPanel.Name = "singleHotelPanel";
            this.singleHotelPanel.Size = new System.Drawing.Size(428, 516);
            this.singleHotelPanel.TabIndex = 8;
            this.singleHotelPanel.Visible = false;
            // 
            // labelHotelRating
            // 
            this.labelHotelRating.AutoSize = true;
            this.labelHotelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotelRating.Location = new System.Drawing.Point(18, 417);
            this.labelHotelRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHotelRating.Name = "labelHotelRating";
            this.labelHotelRating.Size = new System.Drawing.Size(112, 25);
            this.labelHotelRating.TabIndex = 4;
            this.labelHotelRating.Text = "HotelRating";
            // 
            // labelHotelPhoneNumber
            // 
            this.labelHotelPhoneNumber.AutoSize = true;
            this.labelHotelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotelPhoneNumber.Location = new System.Drawing.Point(18, 361);
            this.labelHotelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHotelPhoneNumber.Name = "labelHotelPhoneNumber";
            this.labelHotelPhoneNumber.Size = new System.Drawing.Size(183, 25);
            this.labelHotelPhoneNumber.TabIndex = 3;
            this.labelHotelPhoneNumber.Text = "HotelPhoneNumber";
            // 
            // labelHotelAddress
            // 
            this.labelHotelAddress.AutoSize = true;
            this.labelHotelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotelAddress.Location = new System.Drawing.Point(18, 306);
            this.labelHotelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHotelAddress.Name = "labelHotelAddress";
            this.labelHotelAddress.Size = new System.Drawing.Size(111, 20);
            this.labelHotelAddress.TabIndex = 2;
            this.labelHotelAddress.Text = "HotelAddress";
            // 
            // labelHotelName
            // 
            this.labelHotelName.AutoSize = true;
            this.labelHotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotelName.Location = new System.Drawing.Point(12, 231);
            this.labelHotelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHotelName.Name = "labelHotelName";
            this.labelHotelName.Size = new System.Drawing.Size(102, 20);
            this.labelHotelName.TabIndex = 1;
            this.labelHotelName.Text = "HotelName";
            // 
            // pictureBoxHotelImage
            // 
            this.pictureBoxHotelImage.Location = new System.Drawing.Point(20, 14);
            this.pictureBoxHotelImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxHotelImage.Name = "pictureBoxHotelImage";
            this.pictureBoxHotelImage.Size = new System.Drawing.Size(388, 172);
            this.pictureBoxHotelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHotelImage.TabIndex = 0;
            this.pictureBoxHotelImage.TabStop = false;
            // 
            // flowLayoutPanelResults
            // 
            this.flowLayoutPanelResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelResults.AutoScroll = true;
            this.flowLayoutPanelResults.Location = new System.Drawing.Point(0, 184);
            this.flowLayoutPanelResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            this.flowLayoutPanelResults.Size = new System.Drawing.Size(428, 529);
            this.flowLayoutPanelResults.TabIndex = 8;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(305, 458);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(103, 37);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // HotelFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 713);
            this.Controls.Add(this.singleHotelPanel);
            this.Controls.Add(this.flowLayoutPanelResults);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.webBrowserMap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HotelFinder";
            this.Text = "Hotel Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.singleHotelPanel.ResumeLayout(false);
            this.singleHotelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserMap;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResults;
        private System.Windows.Forms.Panel singleHotelPanel;
        private System.Windows.Forms.PictureBox pictureBoxHotelImage;
        private System.Windows.Forms.Label labelHotelRating;
        private System.Windows.Forms.Label labelHotelPhoneNumber;
        private System.Windows.Forms.Label labelHotelAddress;
        private System.Windows.Forms.Label labelHotelName;
        private System.Windows.Forms.Button backbtn;
    }
}

