using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_DESIGNS
{
    public partial class message : UserControl
    {
        
        public message(bool isColor,string sender,string message_txt)
        {
            InitializeComponent();
            label1.Text = sender;
            textBox2.Text=message_txt;
            if (isColor)
            {
                panel1.BackColor = Color.MediumTurquoise;
                textBox2.BackColor=Color.MediumTurquoise;
            }
            else
            {
                panel1.BackColor = Color.WhiteSmoke;
                textBox2.BackColor = Color.WhiteSmoke;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void message_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
