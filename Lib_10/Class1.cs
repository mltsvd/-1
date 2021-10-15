using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_10
{
    public class Class1
         
    {
        /// <summary>
        /// Функция для расчета суммы элементов массива
        /// </summary>
        /// <param name="k"></param>
        /// <param name="kol"></param>
        /// <param name="s2"></param>
        /// <param name="s1"></param>

        public static void Sum(int k,out int kol,out string s2, out string s1)
        {
            int x;// сгенерированное число
            int sum = 0;// сумма
            kol = 0;// количество сгенерированных чисел
            Random rnd = new Random();
            s1 = " ";// строка для вывода суммы
            s2 = "";// строка для вывода сгенерированных чисел
           
                while(sum<k)
                {
                    x = rnd.Next(5, 10);// генерирование чисел, распределенных в диапазоне от 5 до 10
                s2 = x.ToString() + ";" + s2 ;//заполение строки числами
                    kol++;// счетчик количества чисел
                    sum = sum + x;// вычисление суммы
                    s1 = sum.ToString();// заполнение строки суммой

                }
          
        }
    }
}
