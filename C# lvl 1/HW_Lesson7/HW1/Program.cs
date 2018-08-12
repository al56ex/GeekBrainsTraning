//Корсун Алексей
//Задание №1
// а - Добавить в программу “Удвоитель” подсчет количества отданных команд удвоителю.
// б - Добавить меню и команду “Играть”. При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен постараться получить это число за минимальное количество ходов.
// в - Добавить кнопку “Отменить”, которая отменяет последние ходы.
//Задание №2
//Используя Windows Forms, разработать игру “Угадай число”. Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Для ввода данных от человека используется элемент TextBox.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartGame());
        }
    }
}
