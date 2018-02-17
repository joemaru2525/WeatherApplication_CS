using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WeatherApp_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            get_weather("https://weather.yahoo.co.jp/weather/jp/13/4410.html");  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //項目をコンボボックスに追加していく
            List<YahooUrl> yahoo = new List<YahooUrl>();

            yahoo.Add(new YahooUrl("●北海道", ""));
            yahoo.Add(new YahooUrl("稚内", "https://weather.yahoo.co.jp/weather/jp/1a/1100.html"));
            yahoo.Add(new YahooUrl("旭川", "https://weather.yahoo.co.jp/weather/jp/1a/1200.html"));
            yahoo.Add(new YahooUrl("留萌", "https://weather.yahoo.co.jp/weather/jp/1a/1300.html"));
            yahoo.Add(new YahooUrl("札幌", "https://weather.yahoo.co.jp/weather/jp/1b/1400.html"));
            yahoo.Add(new YahooUrl("岩見沢", "https://weather.yahoo.co.jp/weather/jp/1b/1500.html"));
            yahoo.Add(new YahooUrl("倶知安", "https://weather.yahoo.co.jp/weather/jp/1b/1600.html"));
            yahoo.Add(new YahooUrl("網走", "https://weather.yahoo.co.jp/weather/jp/1c/1710.html"));
            yahoo.Add(new YahooUrl("北見", "https://weather.yahoo.co.jp/weather/jp/1c/1720.html"));
            yahoo.Add(new YahooUrl("紋別", "https://weather.yahoo.co.jp/weather/jp/1c/1730.html"));
            yahoo.Add(new YahooUrl("根室", "https://weather.yahoo.co.jp/weather/jp/1c/1800.html"));
            yahoo.Add(new YahooUrl("釧路", "https://weather.yahoo.co.jp/weather/jp/1c/1900.html"));
            yahoo.Add(new YahooUrl("帯広", "https://weather.yahoo.co.jp/weather/jp/1c/2000.html"));
            yahoo.Add(new YahooUrl("室蘭", "https://weather.yahoo.co.jp/weather/jp/1d/2100.html"));
            yahoo.Add(new YahooUrl("浦河", "https://weather.yahoo.co.jp/weather/jp/1d/2200.html"));
            yahoo.Add(new YahooUrl("函館", "https://weather.yahoo.co.jp/weather/jp/1d/2300.html"));
            yahoo.Add(new YahooUrl("江差", "https://weather.yahoo.co.jp/weather/jp/1d/2400.html"));
            yahoo.Add(new YahooUrl("●東北", ""));
            yahoo.Add(new YahooUrl("青森", "https://weather.yahoo.co.jp/weather/jp/2/3110.html"));
            yahoo.Add(new YahooUrl("むつ", "https://weather.yahoo.co.jp/weather/jp/2/3120.html"));
            yahoo.Add(new YahooUrl("八戸", "https://weather.yahoo.co.jp/weather/jp/2/3130.html"));
            yahoo.Add(new YahooUrl("盛岡", "https://weather.yahoo.co.jp/weather/jp/3/3310.html"));
            yahoo.Add(new YahooUrl("宮古", "https://weather.yahoo.co.jp/weather/jp/3/3320.html"));
            yahoo.Add(new YahooUrl("大船渡", "https://weather.yahoo.co.jp/weather/jp/3/3330.html"));
            yahoo.Add(new YahooUrl("仙台", "https://weather.yahoo.co.jp/weather/jp/4/3410.html"));
            yahoo.Add(new YahooUrl("白石", "https://weather.yahoo.co.jp/weather/jp/4/3420.html"));
            yahoo.Add(new YahooUrl("秋田", "https://weather.yahoo.co.jp/weather/jp/5/3210.html"));
            yahoo.Add(new YahooUrl("横手", "https://weather.yahoo.co.jp/weather/jp/5/3220.html"));
            yahoo.Add(new YahooUrl("山形", "https://weather.yahoo.co.jp/weather/jp/6/3510.html"));
            yahoo.Add(new YahooUrl("米沢", "https://weather.yahoo.co.jp/weather/jp/6/3520.html"));
            yahoo.Add(new YahooUrl("酒田", "https://weather.yahoo.co.jp/weather/jp/6/3530.html"));
            yahoo.Add(new YahooUrl("新庄", "https://weather.yahoo.co.jp/weather/jp/6/3540.html"));
            yahoo.Add(new YahooUrl("福島", "https://weather.yahoo.co.jp/weather/jp/7/3610.html"));
            yahoo.Add(new YahooUrl("小名浜", "https://weather.yahoo.co.jp/weather/jp/7/3620.html"));
            yahoo.Add(new YahooUrl("若松", "https://weather.yahoo.co.jp/weather/jp/7/3630.html"));
            yahoo.Add(new YahooUrl("●関東、甲信越", ""));
            yahoo.Add(new YahooUrl("東京", "https://weather.yahoo.co.jp/weather/jp/13/4410.html"));
            yahoo.Add(new YahooUrl("大島", "https://weather.yahoo.co.jp/weather/jp/13/4420.html"));
            yahoo.Add(new YahooUrl("八丈島", "https://weather.yahoo.co.jp/weather/jp/13/4430.html"));
            yahoo.Add(new YahooUrl("父島", "https://weather.yahoo.co.jp/weather/jp/13/4440.html"));
            yahoo.Add(new YahooUrl("横浜", "https://weather.yahoo.co.jp/weather/jp/14/4610.html"));
            yahoo.Add(new YahooUrl("小田原", "https://weather.yahoo.co.jp/weather/jp/14/4620.html"));
            yahoo.Add(new YahooUrl("さいたま", "https://weather.yahoo.co.jp/weather/jp/11/4310.html"));
            yahoo.Add(new YahooUrl("熊谷", "https://weather.yahoo.co.jp/weather/jp/11/4320.html"));
            yahoo.Add(new YahooUrl("秩父", "https://weather.yahoo.co.jp/weather/jp/11/4330.html"));
            yahoo.Add(new YahooUrl("千葉", "https://weather.yahoo.co.jp/weather/jp/12/4510.html"));
            yahoo.Add(new YahooUrl("銚子", "https://weather.yahoo.co.jp/weather/jp/12/4520.html"));
            yahoo.Add(new YahooUrl("館山", "https://weather.yahoo.co.jp/weather/jp/12/4530.html"));
            yahoo.Add(new YahooUrl("水戸", "https://weather.yahoo.co.jp/weather/jp/8/4010.html"));
            yahoo.Add(new YahooUrl("土浦", "https://weather.yahoo.co.jp/weather/jp/8/4020.html"));
            yahoo.Add(new YahooUrl("宇都宮", "https://weather.yahoo.co.jp/weather/jp/9/4110.html"));
            yahoo.Add(new YahooUrl("大田原", "https://weather.yahoo.co.jp/weather/jp/9/4120.html"));
            yahoo.Add(new YahooUrl("前橋", "https://weather.yahoo.co.jp/weather/jp/10/4210.html"));
            yahoo.Add(new YahooUrl("みなかみ", "https://weather.yahoo.co.jp/weather/jp/10/4220.html"));
            yahoo.Add(new YahooUrl("甲府", "https://weather.yahoo.co.jp/weather/jp/19/4910.html"));
            yahoo.Add(new YahooUrl("河口湖", "https://weather.yahoo.co.jp/weather/jp/19/4920.html"));
            yahoo.Add(new YahooUrl("新潟", "https://weather.yahoo.co.jp/weather/jp/15/5410.html"));
            yahoo.Add(new YahooUrl("長岡", "https://weather.yahoo.co.jp/weather/jp/15/5420.html"));
            yahoo.Add(new YahooUrl("高田", "https://weather.yahoo.co.jp/weather/jp/15/5430.html"));
            yahoo.Add(new YahooUrl("相川", "https://weather.yahoo.co.jp/weather/jp/15/5440.html"));
            yahoo.Add(new YahooUrl("長野", "https://weather.yahoo.co.jp/weather/jp/20/4810.html"));
            yahoo.Add(new YahooUrl("松本", "https://weather.yahoo.co.jp/weather/jp/20/4820.html"));
            yahoo.Add(new YahooUrl("飯田", "https://weather.yahoo.co.jp/weather/jp/20/4830.html"));
            yahoo.Add(new YahooUrl("●東海、北陸、近畿", ""));
            yahoo.Add(new YahooUrl("名古屋", "https://weather.yahoo.co.jp/weather/jp/23/5110.html"));
            yahoo.Add(new YahooUrl("豊橋", "https://weather.yahoo.co.jp/weather/jp/23/5120.html"));
            yahoo.Add(new YahooUrl("岐阜", "https://weather.yahoo.co.jp/weather/jp/21/5210.html"));
            yahoo.Add(new YahooUrl("高山", "https://weather.yahoo.co.jp/weather/jp/21/5220.html"));
            yahoo.Add(new YahooUrl("静岡", "https://weather.yahoo.co.jp/weather/jp/22/5010.html"));
            yahoo.Add(new YahooUrl("網代", "https://weather.yahoo.co.jp/weather/jp/22/5020.html"));
            yahoo.Add(new YahooUrl("三島", "https://weather.yahoo.co.jp/weather/jp/22/5030.html"));
            yahoo.Add(new YahooUrl("浜松", "https://weather.yahoo.co.jp/weather/jp/22/5040.html"));
            yahoo.Add(new YahooUrl("津", "https://weather.yahoo.co.jp/weather/jp/24/5310.html"));
            yahoo.Add(new YahooUrl("尾鷲", "https://weather.yahoo.co.jp/weather/jp/24/5320.html"));
            yahoo.Add(new YahooUrl("富山", "https://weather.yahoo.co.jp/weather/jp/16/5510.html"));
            yahoo.Add(new YahooUrl("伏木", "https://weather.yahoo.co.jp/weather/jp/16/5520.html"));
            yahoo.Add(new YahooUrl("金沢", "https://weather.yahoo.co.jp/weather/jp/17/5610.html"));
            yahoo.Add(new YahooUrl("輪島", "https://weather.yahoo.co.jp/weather/jp/17/5620.html"));
            yahoo.Add(new YahooUrl("福井", "https://weather.yahoo.co.jp/weather/jp/18/5710.html"));
            yahoo.Add(new YahooUrl("敦賀", "https://weather.yahoo.co.jp/weather/jp/18/5720.html"));
            yahoo.Add(new YahooUrl("大阪", "https://weather.yahoo.co.jp/weather/jp/27/6200.html"));
            yahoo.Add(new YahooUrl("神戸", "https://weather.yahoo.co.jp/weather/jp/28/6310.html"));
            yahoo.Add(new YahooUrl("豊岡", "https://weather.yahoo.co.jp/weather/jp/28/6320.html"));
            yahoo.Add(new YahooUrl("京都", "https://weather.yahoo.co.jp/weather/jp/26/6110.html"));
            yahoo.Add(new YahooUrl("舞鶴", "https://weather.yahoo.co.jp/weather/jp/26/6120.html"));
            yahoo.Add(new YahooUrl("大津", "https://weather.yahoo.co.jp/weather/jp/25/6010.html"));
            yahoo.Add(new YahooUrl("彦根", "https://weather.yahoo.co.jp/weather/jp/25/6020.html"));
            yahoo.Add(new YahooUrl("奈良", "https://weather.yahoo.co.jp/weather/jp/29/6410.html"));
            yahoo.Add(new YahooUrl("風屋", "https://weather.yahoo.co.jp/weather/jp/29/6420.html"));
            yahoo.Add(new YahooUrl("●中国、四国", ""));
            yahoo.Add(new YahooUrl("和歌山", "https://weather.yahoo.co.jp/weather/jp/30/6510.html"));
            yahoo.Add(new YahooUrl("潮岬", "https://weather.yahoo.co.jp/weather/jp/30/6520.html"));
            yahoo.Add(new YahooUrl("松江", "https://weather.yahoo.co.jp/weather/jp/32/6810.html"));
            yahoo.Add(new YahooUrl("浜田", "https://weather.yahoo.co.jp/weather/jp/32/6820.html"));
            yahoo.Add(new YahooUrl("西郷", "https://weather.yahoo.co.jp/weather/jp/32/6830.html"));
            yahoo.Add(new YahooUrl("鳥取", "https://weather.yahoo.co.jp/weather/jp/31/6910.html"));
            yahoo.Add(new YahooUrl("米子", "https://weather.yahoo.co.jp/weather/jp/31/6920.html"));
            yahoo.Add(new YahooUrl("岡山", "https://weather.yahoo.co.jp/weather/jp/33/6610.html"));
            yahoo.Add(new YahooUrl("津山", "https://weather.yahoo.co.jp/weather/jp/33/6620.html"));
            yahoo.Add(new YahooUrl("広島", "https://weather.yahoo.co.jp/weather/jp/34/6710.html"));
            yahoo.Add(new YahooUrl("庄原", "https://weather.yahoo.co.jp/weather/jp/34/6720.html"));
            yahoo.Add(new YahooUrl("下関", "https://weather.yahoo.co.jp/weather/jp/35/8110.html"));
            yahoo.Add(new YahooUrl("山口", "https://weather.yahoo.co.jp/weather/jp/35/8120.html"));
            yahoo.Add(new YahooUrl("柳井", "https://weather.yahoo.co.jp/weather/jp/35/8130.html"));
            yahoo.Add(new YahooUrl("萩", "https://weather.yahoo.co.jp/weather/jp/35/8140.html"));
            yahoo.Add(new YahooUrl("徳島", "https://weather.yahoo.co.jp/weather/jp/36/7110.html"));
            yahoo.Add(new YahooUrl("日和佐", "https://weather.yahoo.co.jp/weather/jp/36/7120.html"));
            yahoo.Add(new YahooUrl("高松", "https://weather.yahoo.co.jp/weather/jp/37/7200.html"));
            yahoo.Add(new YahooUrl("松山", "https://weather.yahoo.co.jp/weather/jp/38/7310.html"));
            yahoo.Add(new YahooUrl("新居浜", "https://weather.yahoo.co.jp/weather/jp/38/7320.html"));
            yahoo.Add(new YahooUrl("宇和島", "https://weather.yahoo.co.jp/weather/jp/38/7330.html"));
            yahoo.Add(new YahooUrl("高知", "https://weather.yahoo.co.jp/weather/jp/39/7410.html"));
            yahoo.Add(new YahooUrl("室戸岬", "https://weather.yahoo.co.jp/weather/jp/39/7420.html"));
            yahoo.Add(new YahooUrl("清水", "https://weather.yahoo.co.jp/weather/jp/39/7430.html"));
            yahoo.Add(new YahooUrl("●九州", ""));
            yahoo.Add(new YahooUrl("福岡", "https://weather.yahoo.co.jp/weather/jp/40/8210.html"));
            yahoo.Add(new YahooUrl("八幡", "https://weather.yahoo.co.jp/weather/jp/40/8220.html"));
            yahoo.Add(new YahooUrl("飯塚", "https://weather.yahoo.co.jp/weather/jp/40/8230.html"));
            yahoo.Add(new YahooUrl("久留米", "https://weather.yahoo.co.jp/weather/jp/40/8240.html"));
            yahoo.Add(new YahooUrl("佐賀", "https://weather.yahoo.co.jp/weather/jp/41/8510.html"));
            yahoo.Add(new YahooUrl("伊万里", "https://weather.yahoo.co.jp/weather/jp/41/8520.html"));
            yahoo.Add(new YahooUrl("長崎", "https://weather.yahoo.co.jp/weather/jp/42/8410.html"));
            yahoo.Add(new YahooUrl("佐世保", "https://weather.yahoo.co.jp/weather/jp/42/8420.html"));
            yahoo.Add(new YahooUrl("厳原", "https://weather.yahoo.co.jp/weather/jp/42/8430.html"));
            yahoo.Add(new YahooUrl("福江", "https://weather.yahoo.co.jp/weather/jp/42/8440.html"));
            yahoo.Add(new YahooUrl("熊本", "https://weather.yahoo.co.jp/weather/jp/43/8610.html"));
            yahoo.Add(new YahooUrl("阿蘇乙姫", "https://weather.yahoo.co.jp/weather/jp/43/8620.html"));
            yahoo.Add(new YahooUrl("牛深", "https://weather.yahoo.co.jp/weather/jp/43/8630.html"));
            yahoo.Add(new YahooUrl("人吉", "https://weather.yahoo.co.jp/weather/jp/43/8640.html"));
            yahoo.Add(new YahooUrl("大分", "https://weather.yahoo.co.jp/weather/jp/44/8310.html"));
            yahoo.Add(new YahooUrl("中津", "https://weather.yahoo.co.jp/weather/jp/44/8320.html"));
            yahoo.Add(new YahooUrl("日田", "https://weather.yahoo.co.jp/weather/jp/44/8330.html"));
            yahoo.Add(new YahooUrl("佐伯", "https://weather.yahoo.co.jp/weather/jp/44/8340.html"));
            yahoo.Add(new YahooUrl("宮崎", "https://weather.yahoo.co.jp/weather/jp/45/8710.html"));
            yahoo.Add(new YahooUrl("延岡", "https://weather.yahoo.co.jp/weather/jp/45/8720.html"));
            yahoo.Add(new YahooUrl("都城", "https://weather.yahoo.co.jp/weather/jp/45/8730.html"));
            yahoo.Add(new YahooUrl("高千穂", "https://weather.yahoo.co.jp/weather/jp/45/8740.html"));
            yahoo.Add(new YahooUrl("名瀬", "https://weather.yahoo.co.jp/weather/jp/46/1000.html"));
            yahoo.Add(new YahooUrl("鹿児島", "https://weather.yahoo.co.jp/weather/jp/46/8810.html"));
            yahoo.Add(new YahooUrl("鹿屋", "https://weather.yahoo.co.jp/weather/jp/46/8820.html"));
            yahoo.Add(new YahooUrl("種子島", "https://weather.yahoo.co.jp/weather/jp/46/8830.html"));
            yahoo.Add(new YahooUrl("●沖縄", ""));
            yahoo.Add(new YahooUrl("那覇", "https://weather.yahoo.co.jp/weather/jp/47/9110.html"));
            yahoo.Add(new YahooUrl("名護", "https://weather.yahoo.co.jp/weather/jp/47/9120.html"));
            yahoo.Add(new YahooUrl("久米島", "https://weather.yahoo.co.jp/weather/jp/47/9130.html"));
            yahoo.Add(new YahooUrl("南大東", "https://weather.yahoo.co.jp/weather/jp/47/9200.html"));
            yahoo.Add(new YahooUrl("宮古島", "https://weather.yahoo.co.jp/weather/jp/47/9300.html"));
            yahoo.Add(new YahooUrl("石垣島", "https://weather.yahoo.co.jp/weather/jp/47/9410.html"));
            yahoo.Add(new YahooUrl("与那国島", "https://weather.yahoo.co.jp/weather/jp/47/9420.html"));

            comboBox1.DataSource = yahoo;
            comboBox1.ValueMember = "Url";
            comboBox1.DisplayMember = "Location";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string urlWeather = comboBox1.SelectedValue.ToString();
            System.Diagnostics.Debug.WriteLine("Debugg1: " + urlWeather);
            //選択されていればSelectedValueに入っている
            if (urlWeather.Contains("https://"))
            {
                System.Diagnostics.Debug.WriteLine(urlWeather);
                get_weather(urlWeather);
            }
        }

        void get_weather(string urlWeather) //メソッド宣言部
        {
            //天気情報のスクレイピング
            //(1)Webサイトに接続してHTMLを取得
            string url = urlWeather;
            System.Net.WebClient web = new System.Net.WebClient();
            web.Encoding = System.Text.Encoding.UTF8;
            string html = web.DownloadString(url);

            //(2)HtmlDocumentクラスにHTMLをセット
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            //(3)XPathを使ってラ情報を抽出
            HtmlNodeCollection nodes =
            doc.DocumentNode.SelectNodes(@"//ul[@id=""todayRanking""]//a");

            //タイトル
            HtmlNodeCollection node0 =
            doc.DocumentNode.SelectNodes("//title");
            labelTitle.Text = node0[0].InnerText;

            //Anounce Date & Time（発表日時）
            HtmlNodeCollection node1 =
            doc.DocumentNode.SelectNodes("//div[@class='yjw_title_h2 yjw_clr']//p[@class='yjSt yjw_note_h2']");
            labelAnnounce.Text = node1[0].InnerText;    //node1(0).InnerText

            //WeatherDate（対象日）
            HtmlNodeCollection node2 =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//p[@class='date']");
            labelDate.Text = node2[0].InnerText;

            //Weather（天候）
            HtmlNodeCollection node3 =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//p[@class='pict']");
            labelWeather.Text = node3[0].InnerText;

            //High Temp（最高気温）
            HtmlNodeCollection node4 =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//ul[@class='temp']//li[@class='high']");
            labelTempHigh.Text = "最高気温 [前日差]： " + node4[0].InnerText;

            //Low Temp（最低気温）
            HtmlNodeCollection node5 =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//ul[@class='temp']//li[@class='low']");
            labelTempLow.Text = "最低気温 [前日差]： " + node5[0].InnerText;

            //Precip1[0-6]（降水確率）
            HtmlNodeCollection node6 =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//tr[@class='precip']//td");
            labelPrecipi01.Text = node6[0].InnerText;

            //Precip1[6-12]（降水確率）
            labelPrecipi02.Text = node6[1].InnerText;

            //Precip1[12-18]（降水確率）
            labelPrecipi03.Text = node6[2].InnerText;

            //Precip1[18-24]（降水確率）
            labelPrecipi04.Text = node6[3].InnerText;

            //WeatherPicture（天気画像）
            HtmlNodeCollection node7 =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//p[@class='pict']//img");
            pictureBox1.ImageLocation = node7[0].GetAttributeValue("src", "");
        }

        public class YahooUrl
        {
            public string Location { get; set; }
            public string Url { get; set; }

            public YahooUrl(string location, string url)
            {
                this.Location = location;
                this.Url = url;
            }
        }

        //linkLabel1のLinkClickedイベントハンドラ
        private void linkLabel1_LinkClicked(object sender,
           System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            //リンク先に移動したことにする
            linkLabel1.LinkVisited = true;
            //ブラウザで開く
            System.Diagnostics.Process.Start("https://weather.yahoo.co.jp/weather/");
        }
    }
}