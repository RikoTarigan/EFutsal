using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Efutsal_For_Client
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VOQHr2N0Cxajgc7LoDv4TzjassAIrIKdgWN2cXjt",
            BasePath = "https://efutsal-abd73.firebaseio.com/"
        };
        int height = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
        int width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
        public Form1()
        {
            
            InitializeComponent();
            this.Width = width - 100;
            this.Height = height - 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(config);
            if(client!=null)
            {
                MessageBox.Show("Connnection Established!");
            }
            MessageBox.Show(config.ToString());
            btnCLose.Location = new Point(width-150,12);
        }

        private void btnStega_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
        

        private void btnHome_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(x == 180) //setelah 3 menit cek koneksi
            {
                x = 0;
                //Cek Koneksi Disini!!!!
                labelkoneksi.Text = "Tidak Terhubung!";
                labelkoneksi.ForeColor = Color.Red;
            }
            x += 1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
