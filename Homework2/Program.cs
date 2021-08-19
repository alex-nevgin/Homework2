using System;
using System.ComponentModel.Design;
using static System.Console;

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
            string errCode1 = "Ошибка 1: рост не должен быть отрицательным";
            string errCode2 = "Ощибка 2: балл по предмету должен быть неотрицательным и не превышать 10"; 

            // Ввод данных (пользователь 1)
            WriteLine("Введите Ваше имя: ");
            string name = ReadLine();

            WriteLine("Введите Ваш возраст: ");
            byte age = byte.Parse(ReadLine()); /* получаем введенное значение, приводим к типу byte и
                                                              присваиваем переменной  age */

            WriteLine("Введите Ваш рост: ");
            double height = double.Parse(ReadLine()); /* получаем введенное значение и присваиваем его строковой
                                                                     переменной  height */
            
            
            WriteLine("Введите Ваш балл по русскому языку: ");
            byte rusMark = byte.Parse(ReadLine()); /* получаем введенное значение, преобразуем и
                                                                       присваиваем его переменной RusMark*/
            

            WriteLine("Введите Ваш балл по истории: ");
            byte histMark = byte.Parse(ReadLine()); /* получаем введенное значение, преобразуем 
                                                                        и присваиваем его переменной  HistMark */
                
            WriteLine("Введите Ваш балл по математике: ");
            byte mathMark = byte.Parse(ReadLine()); /* получаем введенное значение, преобразуем 
                                                                        и присваиваем его переменной  MathMark */
            
            // Вычисляем средний балл
            double averageMark = (double) (rusMark + histMark + mathMark) / 3;
            WriteLine("Средний балл: " + averageMark);

            // Вывод в консоль
            WriteLine(name + age + height + histMark + mathMark + rusMark); // Неформатированный вывод
            WriteLine("\n"); // разделение разных типов вывода (здесь и далее только для красоты и читаемости)

            WriteLine(name + " " + age + " " + height + " " + rusMark + " " + histMark + " " +
                                  mathMark); // Вывод с простым форматированием
            WriteLine("\n");

            WriteLine("Имя: " + name + " Возраст: " + age + " Рост: " + height +
                                  " Балл по русскому языку: " + rusMark + " Балл по истории: " + histMark +
                                  " Балл по математике: " +
                                  mathMark); // Вывод без шаблона" Балл по русскому языку: "
            WriteLine("\n");

            // Вывод по шаблону 
            string simplePattern =
                    "Имя: {0}, Возраст: {1}, Рост: {2}, Балл по русскому языку: {3}, Балл по истории: {4}, Балл по математике: {5}";
            WriteLine(simplePattern, name, age, height, rusMark, histMark, mathMark);
            WriteLine("\n");

            // Вывод по шаблону (интерполяция строк)
            var interpolPattern = $"Имя: {name}, Возраст: {age}, Рост: {height}, Балл по русскому языку: {rusMark}, Балл по истории: {histMark}, Балл по математике: {mathMark}";
            WriteLine(interpolPattern, name, age, height, rusMark, histMark, mathMark);
            WriteLine("\n");

            // Вывод по шаблону (c escape-последовательностями)
            var escapeSeqPattern = $"Имя: {name} \nВозраст: {age} \nРост: {height} \nБалл по русскому языку: {rusMark} \nБалл по истории: {histMark} \nБалл по математике: {mathMark}";
            WriteLine(escapeSeqPattern, name, age, height, rusMark, histMark, mathMark);

        }
    }
}