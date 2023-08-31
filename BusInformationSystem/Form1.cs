using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net;
using System.Xml;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusInformationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string LoadBusInformation()
        {
         


            try
            {
                WebClient client = new WebClient();
                string url = "https://apis.data.go.kr/6410000/buslocationservice/getBusLocationList?serviceKey=LeZsnLGwpMbvOPtg6%2Bw5fiPliCoxGu8Q3RS0H3PAcixlky%2BCT7uaXD27BN99mY1GbJaA7NTv734d6N%2FFeNzvOw%3D%3D&routeId=234001243";
                using (StreamReader reader = new StreamReader(client.OpenRead(url)))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return null;
        }
        private void printBusInform(string xmlData)
        {
            listView1.Items.Clear();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlData);

            XmlNodeList list = xmlDoc.GetElementsByTagName("xmlData");

            int idx = 0;
            foreach (XmlNode node in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = idx.ToString();
                item.SubItems.Add(node["plateNo"].InnerText);
                item.SubItems.Add(node["막차여부"].InnerText);
                item.SubItems.Add(node["빈자리 수"].InnerText);

                listView1.Items.Add(item);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string result = LoadBusInformation();
            printBusInform(result);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBusInformation();
        }
    }
}
