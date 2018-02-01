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

namespace WeatherApp_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //(1)Webサイトに接続してHTMLを取得
            const string url = "https://weather.yahoo.co.jp/weather/jp/14/4610.html";
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
    }
}