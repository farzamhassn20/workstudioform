using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        bool login = true;
        Font smallf = new Font("Arial", 8);
        public Form2()
        {
            InitializeComponent();



        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;
    

            if(circularProgressBar1.Value == 100 )
            {
                timer1.Enabled = false;
                if (login == true)
                {
                    Form2 f2 = new Form2();
                    f2.Hide();
                    Form1 f = new Form1();
                    f.ShowDialog(); 
                }

                else
                {
                    
                }

            }
        }
    }
}
