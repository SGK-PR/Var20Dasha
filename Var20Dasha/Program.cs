using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DashaVar20
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Введите код специальности:");
            s = Convert.ToString(Console.ReadLine());

            string[] vs = s.Split('-');


            if (s.Length <= 9 && s.Length >= 7)
            {
                bool Validaciya = ProverkaBukv(vs[0]) && ProverkaCifr(vs[1]) && ProverkaCifr(vs[2]);
                if (Validaciya)
                {
                    Console.WriteLine("Код верный");
                    NomerCursa(s);
                    polnoeNazvanieSpecialnosti(s);

                }
                else
                {
                    Console.WriteLine("Код неверный");
                }
            }
            else
            {
                Console.WriteLine("Код неверный");
            }

            Console.ReadLine();
        }

        public static Boolean ProverkaBukv(string name)
        {
            Char[] chars = name.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (!(chars[i] >= 'А' && chars[i] <= 'Я')) return false;
            }
            return true;
        }

        public static Boolean ProverkaCifr(string name)
        {
            Char[] numbers = name.ToCharArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!(numbers[i] >= '0' && numbers[i] <= '9')) return false;
            }
            return true;
        }
        public static void NomerCursa(string name)
        {
            string[] vs = name.Split('-');
            string tekushiiYear = DateTime.Now.Year.ToString();
            int PlusYear = 0;
            if (DateTime.Now.Month >= 9)
            {
                PlusYear = 1;
            }
            string year = tekushiiYear.Substring(tekushiiYear.Length - 2);

            Console.WriteLine(((Int16.Parse(year) - Int16.Parse(vs[1])) + PlusYear) + " курс");
        }
        public static void polnoeNazvanieSpecialnosti(string name)
        {
            var sokrToPolnoe = new Dictionary<string, string>()
            {
            { "ИС", "Информационные системы и программирование" },
            { "МЛ", "Машинист локомотива" },
            { "ГД", "Графический дизайнер" },
            { "СЭЗ", "Строительство и эксплуатация зданий и сооружений" },
            { "УК", "Управление, эксплуатация и обслуживание многоквартирного дома" },
            { "КС", "Компьютерные системы и комплексы" },
            { "ПКС", "Программирование в компьютерных системах" },
            { "СА", "Сетевое и системное администрирование" },
            { "ОТЗ", "Организация и технология защиты информации" },
            { "ПД", "Печатное дело" },
            { "ДО", "Дошкольное образование" },
            };
            string[] vs = name.Split('-');
            Console.WriteLine(sokrToPolnoe[vs[0]]);
        }


    }

}
