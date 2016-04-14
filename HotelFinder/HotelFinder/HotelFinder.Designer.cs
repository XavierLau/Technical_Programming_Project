﻿namespace HotelFinder
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
            this.flowLayoutPanelResults = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMap.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMap.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(30, 28);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.ScrollBarsEnabled = false;
            this.webBrowserMap.Size = new System.Drawing.Size(1002, 713);
            this.webBrowserMap.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(18, 30);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(390, 28);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(296, 142);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
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
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(4);
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
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(427, 190);
            this.panelSearch.TabIndex = 7;
            // 
            // singleHotelPanel
            // 
            this.singleHotelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.singleHotelPanel.AutoScroll = true;
            this.singleHotelPanel.Location = new System.Drawing.Point(0, 184);
            this.singleHotelPanel.Margin = new System.Windows.Forms.Padding(4);
            this.singleHotelPanel.Name = "singleHotelPanel";
            this.singleHotelPanel.Size = new System.Drawing.Size(427, 529);
            this.singleHotelPanel.TabIndex = 8;
            this.singleHotelPanel.Visible = false;
            // 
            // flowLayoutPanelResults
            // 
            this.flowLayoutPanelResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelResults.AutoScroll = true;
            this.flowLayoutPanelResults.Location = new System.Drawing.Point(0, 184);
            this.flowLayoutPanelResults.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            this.flowLayoutPanelResults.Size = new System.Drawing.Size(427, 529);
            this.flowLayoutPanelResults.TabIndex = 8;
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HotelFinder";
            this.Text = "Hotel Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
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
    }
}

