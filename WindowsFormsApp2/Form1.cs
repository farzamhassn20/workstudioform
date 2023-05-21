using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Paint += button1_Paint;


        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
            GraphicsPath buttonPath = new GraphicsPath();
            float borderRadius = Math.Min(button.Width -5, button.Height -5); // Adjust this value to change the button's roundness

            buttonPath.AddEllipse(+4, +3, borderRadius, borderRadius);
            button.Region = new Region(buttonPath);

        }
     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
