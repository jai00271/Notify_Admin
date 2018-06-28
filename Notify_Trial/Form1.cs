using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using System.IO;
using System.Data.SqlClient;
namespace Notify_Trial
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.if_info_370079;
            popup.ImageSize = new Size(30, 30);
            popup.TitleText = "first notification";
            popup.ContentText = "this is my first notification";
            popup.Popup();*/
           /* notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000, "Important Notice", "Something has come up", ToolTipIcon.Info);
    */        
            /*FileStream fs = new FileStream("c:\\Users\\Pradeepta_Ranjan_Cho\\Desktop\\files\\events.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs); */
            string event1 = textBox1.Text;
            /*sw.WriteLine(event1);
            sw.Flush();
            sw.Close();
            fs.Close();*/
            label2.Text = "your event has been registered";
            textBox1.Text = "";

            SqlConnection sqlConnection1 =
              new SqlConnection(@"Data Source=mssql5.gear.host;Initial Catalog=events3;User ID=events3;Password=Ev067I!~zyZy");
               
            DateTime today = DateTime.Now;

            string query = "INSERT Events2 (EventName,Upload_Time) VALUES ('"+event1+"','"+today+"')";
            sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO EVENTS2 (EventName,Upload_Time) VALUES (@Name,@Time) ",sqlConnection1);
            cmd.Parameters.AddWithValue("@Name", event1);
            cmd.Parameters.AddWithValue("@Time", today);
            cmd.ExecuteNonQuery();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
