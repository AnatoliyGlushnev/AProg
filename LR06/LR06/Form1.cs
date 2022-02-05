using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR06
{
    public partial class Form1 : Form
    {
        int _Red;
        int _Green;
        int _Blue;
        public Form1()
        {
            InitializeComponent();
        }

        private void setRGB()
        {
            panel_Colored.BackColor = Color.FromArgb(_Red, _Green, _Blue);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _Red = hScrollBar_Red.Value;
            textBox_Red.Text = hScrollBar_Red.Value.ToString();
            textBox_Red.BackColor = Color.FromArgb(Int16.Parse(textBox_Red.Text), 0, 0); setRGB();
        }

        private void hScrollBar_Green_Scroll(object sender, ScrollEventArgs e)
        {
            _Green = hScrollBar_Green.Value;
            textBox_Green.Text = hScrollBar_Green.Value.ToString();
            textBox_Green.BackColor = Color.FromArgb(0, Int16.Parse(textBox_Green.Text), 0); setRGB();
        }

        private void hScrollBar_Blue_Scroll(object sender, ScrollEventArgs e)
        {
            _Blue = hScrollBar_Blue.Value;
            textBox_Blue.Text = hScrollBar_Blue.Value.ToString();
            textBox_Blue.BackColor = Color.FromArgb(0, 0, Int16.Parse(textBox_Blue.Text));
            setRGB();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _Blue = 27; textBox_Blue.Text = "27"; textBox_Blue.BackColor = Color.FromArgb(0, 0, 27); hScrollBar_Blue.Value = 27;
            _Green = 196; textBox_Green.Text = "196"; textBox_Green.BackColor = Color.FromArgb(0, 195, 0); hScrollBar_Green.Value = 196;
            _Red = 0; textBox_Red.Text = "0"; textBox_Red.BackColor = Color.FromArgb(0, 0, 0); hScrollBar_Red.Value = 0;
            setRGB();

            string str = String.Format("Число 50203 в формате RGB: \n Красный: {0,3}\n Зеленый: {1,3}\n Синий: {2,3}", _Red, _Green, _Blue);
            MessageBox.Show(str);
        }

        private void Button_Color_Click(object sender, EventArgs e)
        {

        }
    }
}
