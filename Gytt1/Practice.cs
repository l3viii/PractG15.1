using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gytt1
{// МЕЙЙЙЙЙЙЙЙн
    /// <summary>
    /// Найти произведение n целых случайных чисел X., распределенных в
    /// диапазоне от 0 до n.
    /// </summary>
    /// <param name="n">Количество чисел и граница генарции</param>
    /// <returns>Произведение целых случайных чисел и сгенерированные числа </returns>
    public class Practice
    {
        static Random random = new Random();
        public static (double allNumbers, string calculations) ProductEvenWithOut(int count)
        {
            
            int product = 1;
            string numbers = string.Empty;
         
            for (int i = 0; i < count; i++)
            {
                int number = random.Next(0, count);

                numbers += number.ToString() + " ";
                
                product *= number;
            }

            var finding = (product, numbers);
            return finding;
        }
    }
}

