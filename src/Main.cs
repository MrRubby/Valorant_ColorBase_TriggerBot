using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;


namespace KeyAuth
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        private void Main_Load(object sender, EventArgs e)
        {
            Login.KeyAuthApp.check();
           
            key.Text = "Username: " + Login.KeyAuthApp.user_data.username;
            expiry.Text = "Expiry: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry));
            subscription.Text = "Subscription: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
           
           
            createDate.Text = "Creation date: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.createdate));
            lastLogin.Text = "Last login: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.lastlogin));
            subscriptionDaysLabel.Text = "Expiry in Days: " + Login.KeyAuthApp.expirydaysleft();

        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void hile_Click(object sender, EventArgs e)
        {
   
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }





        private void chatmsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
      


        }





        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cheatglobal.com/konu/valomacro-triggerbot-source-codes-leaked-by-010101x.33398/page-2#post-594880");
        }

        private void key_Click(object sender, EventArgs e)
        {
            
        }

     

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            
          
         
        }

        private void hile_Click_1(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            
            Process.Start("C:/Loader/Drivers/RawAccell/TyAccel/Fix2/Fixed/Loader.exe");
        }

        private void siticoneRoundedButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click_1(object sender, EventArgs e)
        {
            hile.Text = "Loading {Vanguard Bypass}";
            this.Refresh();
            System.Threading.Thread.Sleep(1500);
            siticoneRoundedButton1.Text = "Bypass Successful!";
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            timer1.Enabled = false;
        }
    }
}                                                    

        

        

      
       

     
    

