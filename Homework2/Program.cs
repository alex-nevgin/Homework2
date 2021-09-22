using System;
using static System.Console;

namespace Homework2
{
    class Program
    {
        /// <summary>
        /// Приложение, принимающее данные трех пользователей (имя, возраст, рост, балл по русскому языку,
        /// истории и математике), рассчитывающее средний балл и выводящее введенные и рассчитанные данные
        /// в консоль по заданному шаблону.
        /// </summary>
        /// <param name="args"> Параметры точки входа (класса Main) </param>
        static void Main(string[] args)
        {
            
            // Подсказки для ввода данных
            string nameHint = "Введите Ваше имя: ";
            string ageHint = "Введите Ваш возраст: ";
            string heightHint = "Введите Ваш рост: ";
            string rusMarkHint = "Введите балл по русскому языку: ";
            string histMarkHint = "Введите балл по истории: ";
            string mathMarkHint = "Введите балл по математике: ";
            
            // Дополнительные переменные, необходимые для вывода
            int consoleWindowLength = Console.WindowWidth;
            int consoleWindowHeight = Console.WindowHeight;
            
            #region Данные пользователя 1
            
            // Ввод данных (пользователь 1)
            WriteLine(nameHint);
            string name1 = ReadLine();
            
            WriteLine(ageHint);
            byte age1 = byte.Parse(ReadLine()); /* получаем введенное значение, приводим к типу byte и
                                                   присваиваем переменной  age */
            
            WriteLine(heightHint);
            double height1 = double.Parse(ReadLine()); /* получаем введенное значение и присваиваем его строковой
                                                          переменной  height */
            
            WriteLine(rusMarkHint);
            byte rusMark1 = byte.Parse(ReadLine()); /* получаем введенное значение, преобразуем и
                                                       присваиваем его переменной RusMark*/
            
            WriteLine(histMarkHint);
            byte histMark1 = byte.Parse(ReadLine()); /* получаем введенное значение, преобразуем 
                                                        и присваиваем его переменной  HistMark */
                
            WriteLine(mathMarkHint);
            byte mathMark1 = byte.Parse(ReadLine()); /* получаем введенное значение, преобразуем 
                                                        и присваиваем его переменной  MathMark */

            // Вычисляем средний балл
            double averageMark1 = (double) (rusMark1 + histMark1 + mathMark1) / 3;
            
            WriteLine("\n");
            
            #endregion

            #region Данные пользователя 2
            
            /*
            Принцип работы данной части кода аналогичен первой части. 
            Описания переменных и работы кода см. в регионе 1.
            Отличие данного участка - метод вывода данных (он описан в комментарии к соответствующем блоке кода.
            */
            
            
            WriteLine(nameHint);
            string name2 = ReadLine();
            
            WriteLine(ageHint);
            byte age2 = byte.Parse(ReadLine()); 

            WriteLine(heightHint);
            double height2 = double.Parse(ReadLine()); 
            
            WriteLine(rusMarkHint);
            byte rusMark2 = byte.Parse(ReadLine()); 
            
            WriteLine(histMarkHint);
            byte histMark2 = byte.Parse(ReadLine()); 
                
            WriteLine(mathMarkHint);
            byte mathMark2 = byte.Parse(ReadLine());
            
            double averageMark2 = (double) (rusMark2 + histMark2 + mathMark2) / 3;
            
            #endregion

            #region Данные пользователя 3

            /*
            Принцип работы данной части кода аналогичен регионам 1 и 2. 
            Описания переменных и работы кода см. в регионе 1.
            Единственное отличие данного региона от двух первых - другой формат вывода данных.
            */

            WriteLine(nameHint);
            string name3 = ReadLine();
            
            WriteLine(ageHint);
            byte age3 = byte.Parse(ReadLine()); 

            WriteLine(heightHint);
            double height3 = double.Parse(ReadLine()); 
            
            WriteLine(rusMarkHint);
            byte rusMark3 = byte.Parse(ReadLine()); 
            
            WriteLine(histMarkHint);
            byte histMark3 = byte.Parse(ReadLine()); 
                
            WriteLine(mathMarkHint);
            byte mathMark3 = byte.Parse(ReadLine());
            
            double averageMark3 = (double) (rusMark3 + histMark3 + mathMark3) / 3;

            #endregion

            #region Вывод данных

            // Вывод данных первого пользователя

            string user1Output = name1 + age1 + height1 + rusMark1 + histMark1 + mathMark1 + averageMark1;
            int user1OutputLength = user1Output.Length;
            int centerX = ((consoleWindowLength / 2) - (user1OutputLength / 2));
            int centerY = (consoleWindowHeight / 2) - 1;
            SetCursorPosition(centerX, centerY);
            WriteLine(user1Output);
            WriteLine("\n");

            // Вывод данных второго пользователя
            string user2Output = name2 + " " + age2 + " " + height2 + " " + rusMark2 + " " + histMark2 + " " +
                                 mathMark2 + " " + averageMark2;
            int user2OutputLength = user2Output.Length;
            int centerX2 = ((consoleWindowLength / 2) - (user2OutputLength / 2));
            int centerY2 = (consoleWindowHeight / 2) - 1;
            SetCursorPosition(centerX2, centerY2);
            WriteLine(user2Output);
            WriteLine("\n");

            // Вывод данных третьего пользователя
            string user3Output = $"Имя: {name3}, Возраст: {age3}, Рост: {height3}, Балл по русскому языку: {rusMark3}, " +
                                  $"Балл по истории: {histMark3}, Балл по математике: {mathMark3}, Средний балл: {averageMark3}";
            int user3OutputLength = user3Output.Length;
            int centerX3 = ((consoleWindowLength / 2) - (user3OutputLength / 2));
            int centerY3 = (consoleWindowHeight / 2) - 1;
            SetCursorPosition(centerX2, centerY2);
            WriteLine(user3Output); 
            WriteLine("\n");

            #endregion
        }
    }
}