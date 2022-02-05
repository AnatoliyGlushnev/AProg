using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.IO;

using SearchTextSymbols = LR08.SearchTextSymbols;

namespace LR08
{
    class SearchTextSymbols
    {
        private string[] _strs_input = new string[100]; // набор строк
        private int _index = 0; // индекс строки в наборе строк 
        public void Clear_Strings() // метод очистки строк
        {
            for (int i = 0; i < 100; i++)
            {
                _strs_input[i] = "";
            }
            Start_Enumeration();
        }
        public void Start_Enumeration() // метод начала перебора 
        {
            _index = 0; // сбрасываем индекс начала перебора строк на ноль 
        }
        public string Get_Next_String() // метод получение очередной строки 
        { // перед вызовом внутренний индекс НЕОБХОДИМО обнулить!!!
            string str_ret = null;
            for (int i = _index; i < 100; i++)
            { // перебираем строки, начиная с _index
                str_ret = _strs_input[i];
                if (str_ret != null) // если строка непустая, возвращаем ее 
                { // обновляем индекс последней считанной строки на следующую 
                    _index = i + 1;
                    break; // выходим из цикла
                }
            }
            return str_ret; // возвращаем найденную строку 
        }
        public void LoadStrings(ref string[] strs)
        {
            Clear_Strings();
            // число передаваемых для копирования строк 
            int count = strs.Count();
            if (count > 100) count = 100; // ограничиваем число строк до 100
            for (int i = 0; i < count; i++)
            {// копируем каждую строку в строки внутри данного класса 
                _strs_input[i] = strs[i];
            }
        }
        public int Search_Num_Of_Letter(char letter)
        { // поиск символа в наборе строк 
            int find_count = 0; // число совпадений
            Start_Enumeration(); // зануляем внутренний индекс 
            for (int i = 0; i < 100; i++)
            {
                string str = Get_Next_String(); // получаем очередную строку 
                if (str != null) // если строка непустая
                {
                    int len = str.Length; // длина очередной строки
                    for (int i_len = 0; i_len < len; i_len++)
                    { // сравниваем со второй по счету 
                        if (str[i_len] == letter)
                            //(str[(Num/100 + Num%100) % 20] == strs[(Num + i_len)%30]) && (i_len > (Num / 100 + Num % 100) % 10)
                            // увеличиваем число совпадений на 1,  
                            find_count++; // если коды символов одинаковы 
                    }
                }
                else // иначе прекращаем поиск 
                {
                    break; // выход из цикла
                }
            }
            return find_count;
        }
        public int Search_Num_Of_Letter_Ind()
        { // поиск символа в наборе строк 
            string[] strs = { "а", "б", "в", "г", "д",
                               "е", "ж", "з", "и", "й",
                               "к", "л", "м", "н", "о",
                               "п", "р", "с", "т", "у",
                               "ф", "х", "ц", "ч", "ш",
                               "щ", "ь", "э", "ю", "я"};
            int Num = 50203;
            int find_count = 0; // число совпадений
            Start_Enumeration(); // зануляем внутренний индекс 
            for (int i = 0; i < 100; i++)
            {
                string str = Get_Next_String(); // получаем очередную строку 
                if (str != null) // если строка непустая
                {
                    int len = str.Length; // длина очередной строки
                    for (int i_len = 0; i_len < len; i_len++)
                    { // сравниваем со второй по счету 
                        if ((str[(Num / 100 + Num % 100) % 20].ToString() == strs[(Num + i_len) % 30]) && (i_len > (Num / 100 + Num % 100) % 10))
                        {// увеличиваем число совпадений на 1,  
                            int n_str = (Num / 100 + Num % 100) % 20, n_strs = (Num + i_len) % 30;
                            string ch_str = str[n_str].ToString();
                            string ch_strs = strs[n_strs];
                            find_count++; // если коды символов одинаковы
                        }
                    }
                }
                else // иначе прекращаем поиск 
                {
                    break; // выход из цикла
                }
            }
            return find_count;
        }

    }
}
