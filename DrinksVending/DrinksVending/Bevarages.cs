using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVending
{
        // Базовый класс для всех напитков (родительский)
        public class Drink
        {
            public int Volume { get; set; } // Объем напитка

            public virtual string GetDescription()
            {
                return $"Объем: {Volume} мл";
            }
        }

        // Класс для сока
        public class Juice : Drink
        {
            public string Fruit { get; set; } // Используемый фрукт
            public bool HasPulp { get; set; } // Наличие мякоти

            public override string GetDescription()
            {
                return $"Сок, {base.GetDescription()}, Фрукт: {Fruit}, {(HasPulp ? "с мякотью" : "без мякоти")}";
            }

        }

        // Класс для газировки
        public class Soda : Drink
        {
            public string Type { get; set; } // Вид газировки
            public int BubblesCount { get; set; } // Количество пузыриков

            public override string GetDescription()
            {
                return $"Газировка, {base.GetDescription()}, Вид: {Type}, Пузыриков: {BubblesCount}";
            }
        }

        // Класс для алкогольных напитков
        public class Alcohol : Drink
        {
            public double Strength { get; set; } // Крепость алкоголя
            public string Type { get; set; } // Тип алкоголя

            public override string GetDescription()
            {
                return $"Алкоголь, {base.GetDescription()}, Крепость: {Strength}%, Тип: {Type}";
            }
        }
    }
