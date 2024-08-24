using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Formular
    {
        /// <summary>
        /// Позволяет сократить код, от дублирования логических операций. Возвращает result.
        /// </summary>
        /// <param name="text">Выводимый в консоль текст</param>
        /// <param name="oneValue">Максимальное значение</param>
        /// <param name="twoValue">Минимальное значение</param>
        /// <param name="result">Результат ввода ( Console.ReadLine() )</param>
        public float FormulaOne(string text, float oneValue, float twoValue, ref float result)
        {
            do
            {
                Console.Write($"{text}");

                if (!float.TryParse(Console.ReadLine(), out float value))
                {
                    Console.WriteLine("Укажите цифры!");
                    result = -1f;
                }
                else
                {
                    result = value;
                }

            }
            while (result > oneValue || result < twoValue);

            return result;
        }
    }
}
