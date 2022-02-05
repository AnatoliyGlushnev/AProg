using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR07
{
    public partial class Form_Main : Form
    {
        private int _x = 0;
        private int _y = 0;
        private Graphics _gr;
        private int _index;
        private Color _colorPen = Color.Black;
        private Color _colorBrush = Color.Black;
        public Form_Main()
        {
            InitializeComponent();
            _gr = pictureBox.CreateGraphics();
            listBox_Primitives.SelectedIndex = 0;
        }

        private void listBox_Primitives_SelectedIndexChanged(object sender, EventArgs e)
        {
            _index = listBox_Primitives.SelectedIndex;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            this._x = p.X;
            this._y = p.Y;
            pictureBox.Invalidate();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Pen pn = new Pen(_colorPen, 2);
            _gr = e.Graphics;
            SolidBrush sb = new SolidBrush(_colorBrush);

            Font f = new Font("Conrier New", 9, FontStyle.Bold);
            string str = "x= " + _x.ToString() + " y= " + _y.ToString();
            string str1 = "Анатолий Глушнев 50203";
            
            switch(_index)
            {
                case 0:
                    break;
                case 1:
                    _gr.DrawString(str1, f, sb, _x, _y);
                    _gr.DrawArc(pn, _x - 55, _y - 10, 22, 22, 0, 22);
                    _gr.DrawArc(pn, _x - 85, _y - 10, 22, 22, 0, 22);
                    _gr.DrawArc(pn, _x - 100, _y - 50, 100, 100, 0, 120);
                    break;
                case 2:
                    _gr.DrawRectangle(pn, _x - 50, _y - 50, 100, 100);
                    _gr.FillRectangle(sb, _x - 50, _y - 50, 100, 100);
                    break;
                case 3:
                    _gr.DrawArc(pn, _x - 50, _y - 50, 100, 100, 0, 120);
                    break;
                case 4:
                    _gr.DrawLine(pn, _x, _y, 200, 200);
                    break;
            }
        }

        private void button_ColorPen_Click(object sender, EventArgs e)
        {
            if(colorDialog_Pen.ShowDialog() == DialogResult.OK)
            {
                _colorPen = colorDialog_Pen.Color;
                pictureBox.Invalidate();
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_ColorBrush_Click(object sender, EventArgs e)
        {
            if (colorDialog_Pen.ShowDialog() == DialogResult.OK)
            {
                _colorBrush = colorDialog_Pen.Color;
                pictureBox.Invalidate();
            }
        }
    }
}
