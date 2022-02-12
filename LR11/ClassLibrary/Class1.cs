using System;

namespace ClassLibrary
{
    public class Calclulator
    {
        /* a * b */
        public static string Mp(short first_num, short second_num)
        {
            string str_ret = String.Format("\n{0,10}", first_num);
            str_ret += "\n*";
            str_ret += String.Format("\n{0,10}", second_num);
            str_ret += "\n----------";

            if (first_num > 50 && second_num > 50) // Ограничения
                str_ret += String.Format("\n{0,10}", 1.0 * first_num * second_num); // Процесс решения
            else
                str_ret = "ошибка";

            return str_ret;
        }

        /* a |= b */
        public static string Mp(ref short first_num, short second_num)
        {
            string str_ret = String.Format("\n{0,10}", first_num);
            str_ret += "\n|=";
            str_ret += String.Format("\n{0,10}", second_num);
            str_ret += "\n----------";

            if (first_num > 90)
                str_ret += String.Format("\n{0,10}", 1.0 * (first_num |= second_num));
            else
                str_ret = "ошибка";

            return str_ret;
        }

        /* a & b */
        public static string And(short first_num, short second_num)
        {
            string str_ret = String.Format("\n{0,10}", first_num);
            str_ret += "\n&";
            str_ret += String.Format("\n{0,10}", second_num);
            str_ret += "\n----------";

            if (first_num > 40)
                str_ret += String.Format("\n{0,10}", 1.0 * (first_num & second_num));
            else
                str_ret = "ошибка";

            return str_ret;
        }

        /* a -= b */
        public static string subtraction(ref short first_num, short second_num)
        {
            string str_ret = String.Format("\n{0,10}", first_num);
            str_ret += "\n-=";
            str_ret += String.Format("\n{0,10}", second_num);
            str_ret += "\n----------";


            if (second_num > 80)
                str_ret += String.Format("\n{0,10}", 1.0 * (first_num -= second_num));
            else
                str_ret = "ошибка";
            return str_ret;
        }
    }
}
