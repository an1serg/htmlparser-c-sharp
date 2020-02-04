using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;


namespace SteamReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.friend1.Length > 0)
            {
                HtmlDocument HD = new HtmlDocument();
                var web = new HtmlWeb
                {
                    AutoDetectEncoding = false,
                    OverrideEncoding = Encoding.UTF8,
                };
                HD = web.Load(Properties.Settings.Default.friend1);
                HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("//div[@class='responsive_status_info']//div[@class='profile_in_game_header']");
                if (NoAltElements != null)
                {
                    foreach (HtmlNode HN in NoAltElements)
                    {
                       label2.Text = HN.InnerText;
                    }
                }
            }
            if (Properties.Settings.Default.friend2.Length > 0)
            {
                HtmlDocument HD = new HtmlDocument();
                var web = new HtmlWeb
                {
                    AutoDetectEncoding = false,
                    OverrideEncoding = Encoding.UTF8,
                };
                HD = web.Load(Properties.Settings.Default.friend2);
                HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("//div[@class='responsive_status_info']//div[@class='profile_in_game_header']");
                if (NoAltElements != null)
                {
                    foreach (HtmlNode HN in NoAltElements)
                    {
                        label4.Text = HN.InnerText;
                    }
                }
            }
            if (Properties.Settings.Default.friend3.Length > 0)
            {
                HtmlDocument HD = new HtmlDocument();
                var web = new HtmlWeb
                {
                    AutoDetectEncoding = false,
                    OverrideEncoding = Encoding.UTF8,
                };
                HD = web.Load(Properties.Settings.Default.friend3);
                HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("//div[@class='responsive_status_info']//div[@class='profile_in_game_header']");
                if (NoAltElements != null)
                {
                    foreach (HtmlNode HN in NoAltElements)
                    {
                        label6.Text = HN.InnerText;
                    }
                }
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.friend1.Length > 0)
            {
                HtmlDocument HD = new HtmlDocument();
                var web = new HtmlWeb
                {
                    AutoDetectEncoding = false,
                    OverrideEncoding = Encoding.UTF8,
                };
                HD = web.Load(Properties.Settings.Default.friend1);
                HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("//div[@class='responsive_status_info']//div[@class='profile_in_game_header']");
                if (NoAltElements != null)
                {
                    foreach (HtmlNode HN in NoAltElements)
                    {
                        label2.Text = HN.InnerText;
                    }
                }
            }
            if (Properties.Settings.Default.friend2.Length > 0)
            {
                HtmlDocument HD = new HtmlDocument();
                var web = new HtmlWeb
                {
                    AutoDetectEncoding = false,
                    OverrideEncoding = Encoding.UTF8,
                };
                HD = web.Load(Properties.Settings.Default.friend2);
                HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("//div[@class='responsive_status_info']//div[@class='profile_in_game_header']");
                if (NoAltElements != null)
                {
                    foreach (HtmlNode HN in NoAltElements)
                    {
                        label4.Text = HN.InnerText;
                    }
                }
            }
            if (Properties.Settings.Default.friend3.Length > 0)
            {
                HtmlDocument HD = new HtmlDocument();
                var web = new HtmlWeb
                {
                    AutoDetectEncoding = false,
                    OverrideEncoding = Encoding.UTF8,
                };
                HD = web.Load(Properties.Settings.Default.friend3);
                HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("//div[@class='responsive_status_info']//div[@class='profile_in_game_header']");
                if (NoAltElements != null)
                {
                    foreach (HtmlNode HN in NoAltElements)
                    {
                        label6.Text = HN.InnerText;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Steam/steamapps/common/dota 2 beta/game/bin/win64/dota2.exe");

        }
    }
}
