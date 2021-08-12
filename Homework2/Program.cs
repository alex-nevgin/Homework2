using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем переменные
            string name; // Имя
            byte age; // Возраст
            byte height; // Рост
            ushort rus_mark; // балл по русскому
            ushort hist_mark; // балл по истории
            ushort math_mark; // балл по математике
            
            // Ввод данных
            Console.WriteLine("Введите Ваше имя: ");
            name = Console.ReadLine();
            
            Console.WriteLine("Введите Ваш возраст: ");
            string age1 = Console.ReadLine(); /* получаем введенное значение и присваиваем его строковой
                                                 переменной  age1 */
            age = Byte.Parse(age1); // преобразуем тип age1 в byte и присваиваем его переменной age
            
            Console.WriteLine("Введите Ваш рост: ");
            string height1 = Console.ReadLine(); /* получаем введенное значение и присваиваем его строковой
                                                 переменной  height1 */
            height = byte.Parse(height1); // преобразуем тип age1 в byte и присваиваем его переменной age
            
            Console.WriteLine("Введите Ваш балл по русскому языку: ");
            string rus_mark1 = Console.ReadLine(); /* получаем введенное значение и присваиваем его строковой
                                                 переменной  height1 */
            rus_mark = ushort.Parse(rus_mark1); // преобразуем тип rus_mark1 в ushort и присваиваем его переменной age
            
            Console.WriteLine("Введите Ваш балл по истории: ");
            string hist_mark1 = Console.ReadLine(); /* получаем введенное значение и присваиваем его строковой
                                                 переменной  height1 */
            hist_mark = ushort.Parse(hist_mark1); // преобразуем тип rus_mark1 в ushort и присваиваем его переменной age
            
            Console.WriteLine("Введите Ваш балл по математике: ");
            string math_mark1 = Console.ReadLine(); /* получаем введенное значение и присваиваем его строковой
                                                 переменной  height1 */
            math_mark = ushort.Parse(math_mark1); // преобразуем тип rus_mark1 в ushort и присваиваем его переменной age

            // Проверяем баллы
            
            
            // Вычисляем средний балл
            double average_mark = (double)(rus_mark + hist_mark + math_mark) / 3;
            Console.WriteLine("Средний балл: " + average_mark );
            
            // Вывод в консоль
            Console.WriteLine(name + age + height + hist_mark + math_mark + rus_mark); // Неформатированный вывод
            Console.WriteLine("\n"); // разделение разных типов вывода (здесь и далее только для красоты и читаемости)
            
            Console.WriteLine(name + " " + age + " " + height + " " + hist_mark + " " + math_mark + " " + rus_mark); // Вывод с простым форматированием
            Console.WriteLine("\n");
            
            Console.WriteLine("Имя: " + name + " Возраст: " + age + " Рост: " + height + " Балл по русскому языку: " + rus_mark + " Балл по истории: " + hist_mark + 
                              " Балл по математике: " + math_mark); // Вывод без шаблона" Балл по русскому языку: "
            Console.WriteLine("\n"); 
            
            // Вывод по шаблону 
            string simple_pattern = "Имя: {0}, Возраст: {1}, Рост: {2}, Балл по русскому языку: {3}, Балл по истории: {4}, Балл по математике: {5}";
            Console.WriteLine(simple_pattern, name, age, height, rus_mark, hist_mark, math_mark);
            Console.WriteLine("\n");
            
            // Вывод по шаблону (интерполяция строк)
            var interpol_pattern = $"Имя: {name}, Возраст: {age}, Рост: {height}, Балл по русскому языку: {rus_mark}, Балл по истории: {hist_mark}, Балл по математике: {math_mark}";
            Console.WriteLine(interpol_pattern, name, age, height, rus_mark, hist_mark, math_mark);
            Console.WriteLine("\n");
            
            // Вывод по шаблону (c escape-последовательностями)
            var escape_seq_pattern = $"Имя: {name} \nВозраст: {age} \nРост: {height} \nБалл по русскому языку: {rus_mark} \nБалл по истории: {hist_mark} \nБалл по математике: {math_mark}";
            Console.WriteLine(escape_seq_pattern, name, age, height, rus_mark, hist_mark, math_mark);














        }
    }
}