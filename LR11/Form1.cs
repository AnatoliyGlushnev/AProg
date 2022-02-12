using System;
using System.Windows.Forms;
using System.IO;
using calc = ClassLibrary.Calclulator;

namespace WinFormsApp_FormatOutputBox_50203
{
    public partial class Form1 : Form
    {
    /* Добавление выражений для выбора. */
        private string action0 = "[Выберите выражение!]";
        private string action1 = "a * b";
        private string action2 = "a |= b";
        private string action3 = "a & b";
        private string action4 = "a -= b";

        private string text = "";

        private string error = "ошибка";
        private string incorrect_data = "\nНекорректные данные\n";
        /* Сами картинки. */
        private string incorrect_image = System.IO.Path.GetFullPath(@".\images\incorrect.png");
        private string mp_image = System.IO.Path.GetFullPath(@".\images\mp.png");
        private string mp_ref_image = System.IO.Path.GetFullPath(@".\images\mp_ref.png");
        private string and_image = System.IO.Path.GetFullPath(@".\images\and.png");
        private string and_ref_image = System.IO.Path.GetFullPath(@".\images\and_ref.png");
        private string uslovie_image = System.IO.Path.GetFullPath(@".\images\uslovie.png");

        public Form1()
        {
            /* Сообщение о успешном запуске программы. */
            InitializeComponent();
            richTextBox1.Text = "Программа успешно запустилась!";
            /* Перебирает выражение, затем добавляет выражение в listBox1 */
            string[] actions = {action0, action1, action2, action3, action4 };
            listBox1.Items.AddRange(actions);
            listBox1.SetSelected(0, true);

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        /* Запрет внесения букв. Можно вносить только: -9 до 9*/
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == "")
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-')) return;
            }
            else
            {
                if ((e.KeyChar >= '1') && (e.KeyChar <= '9') && (textBox1.Text == "-")) return;
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && (textBox1.Text != "0") && (textBox1.Text != "-")) return;
            }
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;

        }
        /* Запрет внесения букв. Можно вносить только: -9 до 9*/
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Text == "")
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-')) return;
            }
            else
            {
                if ((e.KeyChar >= '1') && (e.KeyChar <= '9') && (textBox2.Text == "-")) return;
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && (textBox2.Text != "0") && (textBox2.Text != "-")) return;
            }
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;

        }
        /* Расчетная часть*/
        private void button1_Click(object sender, EventArgs e)
        {
            short num_first = short.Parse(textBox1.Text); // A
            short num_second = short.Parse(textBox2.Text); // B
            string selectedAction = listBox1.SelectedItem.ToString(); // выбор выражение через listBox1. Переменная selectAction
            /* Первое выражение action1 */
            if (selectedAction == action1) 
            {
                string result = calc.Mp(num_first, num_second);
                text = $"\nПриложение: Инициализировано событие {action1}";
                if (result == error)
                {
                    /* Если выражение с ошибкой. Выдаст MessageBox с ошибкой */
                    MessageBox.Show(
                    incorrect_data,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                    text += incorrect_data;
                    pictureBox1.Image = System.Drawing.Image.FromFile(incorrect_image);
                }
                else
                {
                    text += $"\n{result}\n";
                    pictureBox1.Image = System.Drawing.Image.FromFile(mp_image);
                }
            }
            /* Второе выражение action2 */
            else if (selectedAction == action2)
            {
                short old_num_first = num_first;
                string result = calc.Mp(ref num_first, num_second);
                text = $"\nПриложение: Инициализировано событие {action2}";

                if (result == error)
                {
                    /* Если выражение с ошибкой. Выдаст MessageBox с ошибкой */
                    MessageBox.Show(
                    incorrect_data,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                    text += incorrect_data;
                    pictureBox1.Image = System.Drawing.Image.FromFile(incorrect_image);
                }
                else
                {
                    text += $"\n{result}\n";
                    pictureBox1.Image = System.Drawing.Image.FromFile(mp_ref_image);
                }

            }
            /* ТРЕТЬЕ выражение action4 (Порядок перепутан)*/ 
            else if (selectedAction == action4)
            {
                string result = calc.subtraction(ref num_first, num_second);
                text = $"\nПриложение: Инициализировано событие {action4}";

                if (result == error)
                {
                    /* Если выражение с ошибкой. Выдаст MessageBox с ошибкой */
                    MessageBox.Show(
                    incorrect_data,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                    text += incorrect_data;
                    pictureBox1.Image = System.Drawing.Image.FromFile(incorrect_image);
                }
                else
                {
                    text += $"\n{result}\n";
                    pictureBox1.Image = System.Drawing.Image.FromFile(and_image);
                }

            }
            /* Четвертое выражение action3 */
            else if (selectedAction == action3)
            {
                short old_num_first = num_first;
                string result = calc.And(num_first, num_second);
                text = $"\nПриложение: Инициализировано событие {action3}";
                /* Если выражение с ошибкой. Выдаст MessageBox с ошибкой */
                if (result == error)
                {
                    MessageBox.Show(
                    incorrect_data,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    pictureBox1.Image = System.Drawing.Image.FromFile(incorrect_image);

                    text += incorrect_data;
                }
                else
                {
                    text += $"\n{result}\n";
                    pictureBox1.Image = System.Drawing.Image.FromFile(and_ref_image);
                }
            }
            /* [none](Выбор выраждения) */
            else if (selectedAction == action0)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(uslovie_image);
            }
            richTextBox1.Text += text;
        }

        /* Очистка выражений, картинки, текстов */
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            pictureBox1.Image = null;
        }
    }
}
