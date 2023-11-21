using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        List<ItemData> itemData = new List<ItemData>();

        public Form1() {
            InitializeComponent();
        }

        Dictionary<string, string> favoriteDict = new Dictionary<string, string>();

        class favoriteTitle {
            public string Titles { get; set; }
            public string URL { get; set; }

            public favoriteTitle(string URL,string Titles) {
                this.Titles = Titles;
                this.URL = URL;
            }
            public override string ToString() {
                return Titles;
            }
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (tbUrl.Text == "")
                return;

            lbRssTitle.Items.Clear();

            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                itemData = xdoc.Root.Descendants("item")
                                        .Select(x => new ItemData {
                                            Title = (string)x.Element("title"),
                                            Link = (string)x.Element("link")
                                        }).ToList();

                foreach (var node in itemData) {
                    lbRssTitle.Items.Add(node.Title);
                }
            }
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            var url = lbRssTitle.SelectedIndex;
            wbBrowser.Navigate(itemData[url].Link);
        }

        private void bk_Click(object sender, EventArgs e) {
            wbBrowser.GoBack();
        }

        private void gf_Click(object sender, EventArgs e) {
            wbBrowser.GoForward();
        }

        private void uTitle_Click(object sender, EventArgs e) {
            try {
                lbRssTitle.SelectedIndex -= 1;
                wbBrowser.Navigate(itemData[lbRssTitle.SelectedIndex].Link);
            }
            catch {}     
        }

        private void dTitle_Click(object sender, EventArgs e) {
            try {
                lbRssTitle.SelectedIndex += 1;
                wbBrowser.Navigate(itemData[lbRssTitle.SelectedIndex].Link);
            }
            catch {}    
        }

        private void btDelete_Click(object sender, EventArgs e) {
            tbUrl.ResetText();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/business.xml";
        }

        private void rb2_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/entertainment.xml";
        }

        private void rb3_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/sports.xml";
        }

        private void rb4_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
        }

        private void btfavorite_Click(object sender, EventArgs e) {
            favoriteTitle favorite = new favoriteTitle(tburlName.Text, tbfavoriteName.Text);
            if (favoriteDict.ContainsKey(tburlName.Text) || favoriteDict.ContainsValue(tbfavoriteName.Text)) {
                errorlb.Text = "重複しています";
            }
            else {
                errorlb.Text = "";
                favoriteDict.Add(tburlName.Text, tbfavoriteName.Text);
                cbfavorite.Items.Add(favorite);

                tburlName.Clear();
                tbfavoriteName.Clear();
            }
        }

        private void cbfavorite_SelectedIndexChanged(object sender, EventArgs e) {
            favoriteTitle favorite = (favoriteTitle)cbfavorite.SelectedItem;
            tbUrl.Text = favorite.URL.ToString();
        }
    }
}
