namespace LR61
{
    /// <summary>
    /// Осовной код.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Запись условия.
        /// </summary>
        /// <param name="bag"> имя.</param>
        /// <returns> True or False.</returns>
        public static bool WightAndQuantity(Baggage bag)
        {
            return bag.Count > 2;
        }

        /// <summary>
        /// Определяет есть ли хоть один подходящий человек.
        /// </summary>
        /// <param name="baggages"> имя.</param>
        /// <returns> True or False.</returns>
        public static bool IsPassenger(List<Baggage> baggages)
        {
            // return baggages.Where((b) => WightAndQuantity(b)).Any();
            bool n = false;
            foreach (Baggage baggage in baggages)
            {
                if (WightAndQuantity(baggage))
                {
                    n = true;
                    break;
                }
            }

            return n;
        }


        /// <summary>
        /// Выборка.
        /// </summary>
        /// <param name="baggages"> имя.</param>
        /// <returns> sublist. </returns>
        public static List<Baggage> Viborka(List<Baggage> baggages)
        {
            var subList = baggages.Where((t) => WightAndQuantity(t)).ToList();

            if (subList.Count == 0)
            {
                Console.WriteLine("Отсутсвуют пассажиры, имеющие " +
                                  "более двух вещей.");
            }
            else
            {
                Console.WriteLine("\nПассажиры, имеющие " +
                                  "более двух вещей:\n");
                subList.ForEach((t) => Console.WriteLine(t.Print()));
            }

            return subList;
        }

        /// <summary>
        /// Главная функция.
        /// </summary>
        public static void Main()
        {
            List<Baggage> baggages = new List<Baggage>(10);

            baggages.Add(
                new Baggage
                {
                    Name = "Воронов И.И.",
                    Weight = 22,
                    Count = 3
                });
            baggages.Add(
                new Baggage
                {
                    Name = "Сорокин П.П.",
                    Weight = 32,
                    Count = 2
                });
            baggages.Add(
                new Baggage
                {
                    Name = "Пиндюров И.Р.",
                    Weight = 32,
                    Count = 2
                });
            baggages.Add(
                new Baggage
                {
                    Name = "Немтинов С.С.",
                    Weight = 31,
                    Count = 5
                });
            baggages.Add(
                new Baggage
                {
                    Name = "Хлусевич Р.Р.",
                    Weight = 13,
                    Count = 1
                });
            baggages.Add(
                new Baggage
                {
                    Name = "Зобнин И.И.",
                    Weight = 10,
                    Count = 1
                });
            baggages.Add(
                new Baggage
                {
                    Name = "Промес И.Р.",
                    Weight = 50,
                    Count = 5
                });
            baggages.Add(
                new Baggage
                {
                    Name = "Джикия П.О.",
                    Weight = 19,
                    Count = 1
                });
            baggages.Add(
                new Baggage
                {
                    Name = "Соболев В.В.",
                    Weight = 33,
                    Count = 2
                });
            baggages.Add(
                new Baggage
                {
                    Name = "Маслов С.С.",
                    Weight = 37,
                    Count = 3
                });

            Console.WriteLine();
            foreach (Baggage i in baggages)
            {
                Console.WriteLine(i.Print());
            }

            // Создание выборки и вывод в консоль
            List<Baggage> vibor = Viborka(baggages);

            int count = vibor.Count;

            Console.WriteLine($"Их количество: {count}");

        }
    }
}
