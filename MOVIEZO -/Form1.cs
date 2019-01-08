using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using HtmlAgilityPack;
using System.IO;

namespace MOVIEZO__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string searchCont , movieCont;
      
        async static void GetReq_search(string Search_url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(Search_url))
                {
                    using (HttpContent contetnt = response.Content)
                    {
                        searchCont = await contetnt.ReadAsStringAsync();




                    }
                }
            }

        }

      

    private void button1_Click(object sender, EventArgs e)
        {
            //string searchLink = "http://www.hdpopcorns.com/?s=";
            //string[] movie = textBox1.Text.Split(' ');
            //searchLink += movie[0];
            //for (int i = 1; i < movie.Length; i++)
            //{
            //    searchLink += '+';
            //    searchLink += movie[i];
            //}
            //// Console.WriteLine(searchCont);

            //WebClient w = new WebClient();
            //searchCont = w.DownloadString(searchLink);

            // LinkItem movielink = link_Finder.find(searchCont)[1];

            //<form action="/select-movie-quality.php" method="post">
            //<input name="FileName720p" type="hidden" value="Th3-Oth3r-W0m2n-2014-720p-hdp0pc0rns.mp4">
            //<input name="FileSize720p" type="hidden" value="809.44 MB">
            //<input name="FSID720p" type="hidden" value="85.93.89.154">
            //<input name="FileName1080p" type="hidden" value="Th3-Oth3r-W0m2n-2014-1080p-hdp0pc0rns.mp4">
            //<input name="FileSize1080p" type="hidden" value="1.64 GB">
            //<input name="FSID1080p" type="hidden" value="85.93.89.154"><p></p>
            //< div align = "center" >
            //< input alt = "Download-Movie-Click-Here" height = "40" src = "/wp-content/uploads/2016/03/Untitled.png" type = "image" width = "290" >
            //</ div >
            //             </ form >
            //using (WebClient client=new WebClient())
            //{
            //    client.Headers.Set("Content-Type","application/x-www-form-urlencoded");
            //  //  client.Headers["Content-Type"] = "application / x - www - form - urlencoded";

            //        System.Collections.Specialized.NameValueCollection collection =
            //            new System.Collections.Specialized.NameValueCollection();

            //        collection.Add("FileName720p", "Th3-Oth3r-W0m2n-2014-720p-hdp0pc0rns.mp4");
            //        collection.Add("FileSize720p", "809.44 MB");
            //        collection.Add("FSID720p","85.93.89.154");
            //        collection.Add("FileName1080p", "Th3-Oth3r-W0m2n-2014-1080p-hdp0pc0rns.mp4");
            //        collection.Add("FileSize1080p", "1.64 GB");
            //        collection.Add("FSID1080p", "85.93.89.154");
            //        collection.Add("x","222");
            //        collection.Add("y", "19");

                string data = "FileName720p=In-H3r-Sh03s-2005-720p-hdp0pc0rns.mp4&FileSize720p=875.24+MB&FSID720p=85.93.89.159&FileName1080p=In-H3r-Sh03s-2005-1080p-hdp0pc0rns.mp4&FileSize1080p=1.95+GB&FSID1080p=85.93.89.159&x=94&y=48";

            //        client.Proxy = null;

            //        string result = client.UploadString("http://www.hdpopcorns.com/select-movie-quality.php", data);
            //    //string converted = Encoding.UTF8.GetString(result, 0, result.Length);
            //    Console.WriteLine(result);


            //}


            var nvc = new List<KeyValuePair<string, string>>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.hdpopcorns.com/select-movie-quality.php");
            request.ContentType = "application/x-www-form-urlencoded"; // or whatever - application/json, etc, etc
            request.Method = "post";
            StreamWriter requestWriter = new StreamWriter(request.GetRequestStream());

            try
            {
                requestWriter.Write(data);
            }
            catch
            {
                throw;
            }
            finally
            {
                requestWriter.Close();
                requestWriter = null;
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            //nvc.Add(new KeyValuePair<string, string>("FileName720p", "Th3-Oth3r-W0m2n-2014-720p-hdp0pc0rns.mp4"));
            //nvc.Add(new KeyValuePair<string, string>("FileSize720p", "809.44 MB"));
            //nvc.Add(new KeyValuePair<string, string>("FSID720p", "85.93.89.154"));
            //nvc.Add(new KeyValuePair<string, string>("FileName1080p", "Th3-Oth3r-W0m2n-2014-1080p-hdp0pc0rns.mp4"));
            //nvc.Add(new KeyValuePair<string, string>("FileSize1080p", "1.64 GB"));
            //nvc.Add(new KeyValuePair<string, string>("FSID1080p", "85.93.89.154"));
            //nvc.Add(new KeyValuePair<string, string>("x", "94"));
            //nvc.Add(new KeyValuePair<string, string>("y", "48"));
            //var client = new HttpClient();
            //var req = new HttpRequestMessage(HttpMethod.Post, "http://www.hdpopcorns.com/select-movie-quality.php") { Content = new FormUrlEncodedContent(nvc) };
            //var reqreq = req.Content.ReadAsStringAsync();
            //reqreq.Wait();

            //Console.WriteLine(reqreq.Result);
            //var res = client.SendAsync(req);
            //res.Wait();
            //var t2 = res.Result.Content.ReadAsStringAsync();
            //t2.Wait();
            //Console.WriteLine(t2.Result);
            // movieCont = w.DownloadString(movielink.Href);
            // System.Diagnostics.Process.Start(textBox1.Text);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //string popLink = "http://hdpopcorns.co/";
            //foreach (string k in movie)
            //{
            //    popLink += k;
            //    popLink += '-';
            //}            //popLink+= "720p-1080p/";
            //listBox1.Items.Clear();
            ////  MessageBox.Show(popLink);
            //listBox1.Items.Add(popLink);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //WebClient wb = new WebClient();
            //string egyb = wb.DownloadString("https://egy.best/movie/in-her-shoes-2005/");

            //foreach (LinkItem i in link_Finder.find(egyb))
            //{
            //    Console.WriteLine(i.Href);
            //}
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
