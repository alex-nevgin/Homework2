using System;
using System.ComponentModel.Design;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Создаем переменные
            string name; // Имя
            byte age; // Возраст
            byte height; // Рост
            ushort rus_mark; // балл по русскому
            ushort hist_mark; // балл по истории
            ushort math_mark; // балл по математике
            */
            
            // Коды ошибок для вывода
            string ErrCode1 = "Ошибка 1: рост не должен быть отрицательным";
            string ErrCode2 = "Ощибка 2: балл по предмету должен быть неотрицательным и не превышать 10";

            // Ввод данных
            Console.WriteLine("Введите Ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите Ваш возраст: ");
            byte age = Convert.ToByte(Console.ReadLine()); /* получаем введенное значение, приводим к типу byte и
                                                              присваиваем переменной  age */

            Console.WriteLine("Введите Ваш рост: ");
            double height = Convert.ToDouble(Console.ReadLine()); /* получаем введенное значение и присваиваем его строковой
                                                                     переменной  height */

            // проверка роста
            


            Console.WriteLine("Введите Ваш балл по русскому языку: ");
                byte rus_mark = Convert.ToByte(Console.ReadLine()); /* получаем введенное значение, преобразуем и
                                                                       присваиваем его переменной rus_mark*/
                switch (rus_mark)
                {
                    case <= 0:
                        Console.WriteLine(ErrCode2);
                        break;
                    case > 10:
                        Console.WriteLine(ErrCode2);
                        break;
                }

                Console.WriteLine("Введите Ваш балл по истории: ");
                byte hist_mark = Convert.ToByte(Console.ReadLine()); /* получаем введенное значение, преобразуем 
                                                                        и присваиваем его переменной  hist_mark */
                
                Console.WriteLine("Введите Ваш балл по математике: ");
                byte math_mark = Convert.ToByte(Console.ReadLine()); /* получаем введенное значение, преобразуем 
                                                                        и присваиваем его переменной  math_mark */

                // Проверка оценок
                
                
                // Вычисляем средний балл
                double average_mark = (double) (rus_mark + hist_mark + math_mark) / 3;
                Console.WriteLine("Средний балл: " + average_mark);

                // Вывод в консоль
                Console.WriteLine(name + age + height + hist_mark + math_mark +
                                  rus_mark); // Неформатированный вывод
                Console.WriteLine(
                    "\n"); // разделение разных типов вывода (здесь и далее только для красоты и читаемости)

                Console.WriteLine(name + " " + age + " " + height + " " + hist_mark + " " + math_mark + " " +
                                  rus_mark); // Вывод с простым форматированием
                Console.WriteLine("\n");

                Console.WriteLine("Имя: " + name + " Возраст: " + age + " Рост: " + height +
                                  " Балл по русскому языку: " + rus_mark + " Балл по истории: " + hist_mark +
                                  " Балл по математике: " +
                                  math_mark); // Вывод без шаблона" Балл по русскому языку: "
                Console.WriteLine("\n");

                // Вывод по шаблону 
                string simple_pattern =
                    "Имя: {0}, Возраст: {1}, Рост: {2}, Балл по русскому языку: {3}, Балл по истории: {4}, Балл по математике: {5}";
                Console.WriteLine(simple_pattern, name, age, height, rus_mark, hist_mark, math_mark);
                Console.WriteLine("\n");

                // Вывод по шаблону (интерполяция строк)
                var interpol_pattern =
                    $"Имя: {name}, Возраст: {age}, Рост: {height}, Балл по русскому языку: {rus_mark}, Балл по истории: {hist_mark}, Балл по математике: {math_mark}";
                Console.WriteLine(interpol_pattern, name, age, height, rus_mark, hist_mark, math_mark);
                Console.WriteLine("\n");

                // Вывод по шаблону (c escape-последовательностями)
                var escape_seq_pattern =
                    $"Имя: {name} \nВозраст: {age} \nРост: {height} \nБалл по русскому языку: {rus_mark} \nБалл по истории: {hist_mark} \nБалл по математике: {math_mark}";
                Console.WriteLine(escape_seq_pattern, name, age, height, rus_mark, hist_mark, math_mark);

        }
    }
}