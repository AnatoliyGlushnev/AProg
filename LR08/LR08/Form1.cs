using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.IO;

namespace LR08
{
    public partial class form_main : Form
    {
        SearchTextSymbols _searchTextSymbols = new SearchTextSymbols();
        public form_main()
        {
            InitializeComponent();

            ArrayList arr_list = new ArrayList();
            arr_list.AddRange(listBox_Input.Items);
            string[] strs = arr_list.ToArray(typeof(string)) as string[];
            _searchTextSymbols.LoadStrings(ref strs);
        }

        private void ToolStripMenu_Clear_Click(object sender, EventArgs e)
        {
            _searchTextSymbols.Clear_Strings();
            listBox_Input.Items.Clear();
            toolStripStatusLabel.Text = "Выполнена очистка строк!";
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            _searchTextSymbols.Clear_Strings();
            listBox_Input.Items.Clear();
            toolStripStatusLabel.Text = "Выполнена очистка строк!";
        }

        private void button_FindLetter1_Click(object sender, EventArgs e)
        {
            char ch_letter = textbox_Letter.Text[0];
            int count_letter = _searchTextSymbols.Search_Num_Of_Letter(ch_letter);
            string str = "Символ " + "'" + ch_letter.ToString() + "' встречается в тексте "+ count_letter.ToString() + " раз!";
            toolStripStatusLabel.Text = str;
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
{
                string file_name = openFileDialog.FileName;
                listBox_Input.Items.Clear();
                using (StreamReader r = new StreamReader(file_name, Encoding.Default))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox_Input.Items.Add(line);
                    }
                }
                ArrayList arr_list = new ArrayList();
                arr_list.AddRange(listBox_Input.Items);
                string[] strs = arr_list.ToArray(typeof(string)) as string[];
                _searchTextSymbols.LoadStrings(ref strs);
            }
        }

        private void ToolStripMenu_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа создана для поиска буквы в строках", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count_letter = _searchTextSymbols.Search_Num_Of_Letter_Ind();
            string str = "Количество совпадений (инд. задание) в тексте встречается "
            + count_letter.ToString() + " раз!";

            toolStripStatusLabel.Text = str;
        }
    }
}
