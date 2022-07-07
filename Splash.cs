using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            prog.Value = startpoint;
            if (prog.Value == 100)
            {
                prog.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
