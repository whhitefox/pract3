namespace Pract3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            int[] octava = changeOctava(1);
            ConsoleKeyInfo knopka;
            do
            {
                Console.WriteLine("Переключение октав: F1, F2, F3");
                Console.WriteLine("Ноты: С, D, E, F, G, A, B");
                Console.WriteLine("Черные ноты с зажатой клавишей Shift");
                knopka = Console.ReadKey();
                Console.Clear();
                switch (knopka.Key)
                {
                    case ConsoleKey.F1:
                        octava = changeOctava(1);
                        Console.WriteLine("Выбрана октава 1");
                        break;
                    case ConsoleKey.F2:
                        octava = changeOctava(2);
                        Console.WriteLine("Выбрана октава 2");
                        break;
                    case ConsoleKey.F3:
                        octava = changeOctava(3);
                        Console.WriteLine("Выбрана октава 3");
                        break;
                    case ConsoleKey.C:
                        if (!knopka.Modifiers.HasFlag(ConsoleModifiers.Shift))
                        {
                            playNota(0, octava);
                        }
                        else
                        {
                            playNota(1, octava);
                        }
                        break;
                    case ConsoleKey.D:
                        if (!knopka.Modifiers.HasFlag(ConsoleModifiers.Shift))
                        {
                            playNota(2, octava);
                        }
                        else
                        {
                            playNota(3, octava);
                        }
                        break;
                    case ConsoleKey.E:
                        playNota(4, octava);
                        break;
                    case ConsoleKey.F:
                        if (!knopka.Modifiers.HasFlag(ConsoleModifiers.Shift))
                        {
                            playNota(5, octava);
                        }
                        else
                        {
                            playNota(6, octava);
                        }
                        break;
                    case ConsoleKey.G:
                        if (!knopka.Modifiers.HasFlag(ConsoleModifiers.Shift))
                        {
                            playNota(7, octava);
                        }
                        else
                        {
                            playNota(8, octava);
                        }
                        break;
                    case ConsoleKey.A:
                        playNota(9, octava);
                        break;
                    case ConsoleKey.B:
                        if (!knopka.Modifiers.HasFlag(ConsoleModifiers.Shift))
                        {
                            playNota(10, octava);
                        }
                        else
                        {
                            playNota(11, octava);
                        }
                        break;
                }
            } while (knopka.Key != ConsoleKey.Escape);
        }
        static void playNota(int number, int[] octava)
        {
            Console.Beep(octava[number] * 10, 100);
        }
        static int[] changeOctava(int octava)
        {
            int[] firstOctava = new int[] { 33, 35, 37, 39, 41, 44, 46, 49, 52, 55, 58, 62 };
            int[] secondOctava = new int[] { 65, 69, 73, 78, 82, 87, 92, 98, 104, 110, 116, 123 };
            int[] thirdOctava = new int[] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 };


            switch (octava)
            {
                case 1:
                    return firstOctava;
                case 2:
                    return secondOctava;
                case 3:
                    return thirdOctava;
                default:
                    return firstOctava;
            }
        }
    }
}