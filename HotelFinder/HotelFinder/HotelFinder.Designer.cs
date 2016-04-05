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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserMap.Location = new System.Drawing.Point(186, -1);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.ScrollBarsEnabled = false;
            this.webBrowserMap.Size = new System.Drawing.Size(481, 516);
            this.webBrowserMap.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(167, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(105, 92);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(12, 65);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCountry.TabIndex = 4;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(13, 6);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "City";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(12, 49);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 6;
            this.labelCountry.Text = "Country";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.labelCountry);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.labelCity);
            this.panel1.Controls.Add(this.comboBoxCountry);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 123);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 395);
            this.panel2.TabIndex = 8;
            // 
            // HotelFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowserMap);
            this.Name = "HotelFinder";
            this.Text = "Hotel Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserMap;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

