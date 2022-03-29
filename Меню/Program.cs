// See https://aka.ms/new-console-template for more information
using System;

namespace Меню // Note: actual namespace depends on the project name.
{
    enum GameMenu
    {
        Начать = 1,
        Начать_новую = 2,
        Загрузить = 3,
        Настройки = 4,
        Выход = 5
    }
    internal class Program 
    {
   
    
        static void Main(string[] args)
        {
            Console.WriteLine($"Нажмите {(int)GameMenu.Начать} что бы продолжить игру");
            Console.WriteLine($"Нажмите {(int)GameMenu.Загрузить} что бы загрузить сохранение");
            Console.WriteLine($"Нажмите {(int)GameMenu.Настройки} что бы открыть настройки");
            Console.WriteLine($"Нажмите {(int)GameMenu.Выход} что бы выйти");
       
            string input = Console.ReadLine();
            GameMenu menu= (GameMenu)int.Parse(input);
            Console.WriteLine($"Вы выбрали {menu}");
        }
    }
}