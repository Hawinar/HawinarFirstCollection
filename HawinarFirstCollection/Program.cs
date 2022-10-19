using System;
using System.Linq;

namespace HawinarFirstCollection
{
    /// <summary>
    /// https://github.com/Hawinar
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Zadanie1_22();
                //Zadanie1_47();
                //Zadanie2_22();
                //Zadanie3_22();
                //Zadanie4_22();
                //Zadanie4_47();
                //Zadanie4_72();
                //Zadanie4_97();
                //Zadanie4_122();
                //Zadanie5_22();
                //Zadanie5_47();
                //Zadanie5_72();
                //Zadanie6_22();
                //Zadanie6_47();
                //Zadanie6_72();
                //Zadanie6_97();
                //Zadanie7_22();
                //Zadanie7_47();
                //Zadanie7_72();
                //Zadanie7_97();
                //Zadanie7_122();
                //Zadanie8_22();
                //Zadanie8_47();
                //Zadanie9_22();
                //Zadanie9_47();
                //Zadanie9_72();
                //Zadanie9_97();
                //Zadanie9_122();
                //Zadanie9_147();
                //Zadanie9_172();
                //Zadanie10_22();
                //Zadanie10_47();
                //Zadanie11_22();
                //Zadanie11_47();
                //Zadanie11_72();
                //Zadanie11_97();
                //Zadanie11_122();
                //Zadanie11_147();
                //Zadanie11_172();
                //Zadanie11_197();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка");
            }
        }
        static void Zadanie1_22()
        {
            Console.WriteLine("Задание 1.22\ny=7x^2-3x+6\nВведите целочисленное число для x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(7 * Math.Pow(x, 2) - 3 * x + 6);

            Console.WriteLine("x=12a^2+7a-16\nВведите целочисленное число для a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(12 * Math.Pow(a, 2) + 7 * a - 16);
        }
        static void Zadanie1_47()
        {
            //{ x, y };
            int[] cords1 = new int[2] { 0, 7 };
            int[] cords2 = new int[2] { 24, 0 };


            int[] horizontalCrossing = new int[2] { cords1[0], cords2[1] };
            int catetCords1AndHorCross = Math.Abs(cords1[1] - horizontalCrossing[1]);
            int catetCords2AndHorCross = Math.Abs(cords2[0] - horizontalCrossing[0]);

            //Теорема Пифагора c=√(a²+b²)
            Console.WriteLine("\nЗадание 1.47\n" + Math.Sqrt(Math.Pow(catetCords1AndHorCross, 2) + Math.Pow(catetCords2AndHorCross, 2)));
        }
        static void Zadanie2_22()
        {
            Random rnd = new Random();
            int number = rnd.Next(99, 999999999);
            Console.WriteLine($"\nЗадание 2.22\nДано натуральное число n (n > 99)\nСлучайное число по нужным критериям уже задано: {number}");

            Console.WriteLine($"В числе {number} {number / 100} сотен и {number / 10} десятков");
        }
        static void Zadanie3_22()
        {
            Console.WriteLine("\nЗадание 3.22\nВведите значение логической величины X (true/false)");
            bool x = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение логической величины Y (true/false)");
            bool y = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение логической величины Z (true/false)");
            bool z = bool.Parse(Console.ReadLine());

            bool resultA = Not(And(Nor(x, y), z));
            bool resultB = Or(y, Or(Nand(x, y), z));
            bool resultC = Not(Or(And(Not(x), y), z));
            Console.WriteLine($"не (X или не Y и Z)\nРезультат:{resultA}"
                 + $"\n\nY или (X и не Y или Z);\nРезультат:{resultB}"
                 + $"\n\nне (не X и Y или Z;\nРезультат:{resultC}");
        }
        static bool And(bool operandOne, bool operandTwo) => operandOne && operandTwo;
        static bool Or(bool operandOne, bool operandTwo) => operandOne || operandTwo;
        static bool Not(bool operandOne) => !operandOne;
        static bool Nand(bool operandOne, bool operandTwo) => !(operandOne && operandTwo);
        static bool Nor(bool operandOne, bool operandTwo) => !(operandOne || operandTwo);
        static void Zadanie4_22()
        {
            Console.WriteLine($"\nЗадание 4.22\nВведите натуральное число:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число {number}\nЧётное: {number % 2 == 0}" +
                $"\nЗаканчивается на 7: {number.ToString()[number.ToString().Length - 1] == '7'}");
        }
        static void Zadanie4_47()
        {
            Console.WriteLine("\nЗадание 4.47\nВведите сторону A");
            float A = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону B");
            float B = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону C");
            float C = float.Parse(Console.ReadLine());
            if (A == B || B == C || A == C)
                Console.WriteLine("Треугольник равнобедренний");
            else
                Console.WriteLine("Треугольник неравнобедренний");
        }
        static void Zadanie4_72()
        {
            Console.WriteLine("\nЗадание 4.72\nВведите первое число");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            float number2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            float number3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите четвёртое число");
            float number4 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Максимальное число: {Math.Max(Math.Max(number1, number2), Math.Max(number3, number4))}");
            Console.WriteLine($"Минимальное число: {Math.Min(Math.Min(number1, number2), Math.Min(number3, number4))}");
        }
        static void Zadanie4_97()
        {
            Console.WriteLine("\nЗадание 4.97\nВведите первое число");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int number3 = int.Parse(Console.ReadLine());

            var numbers = new int[] { number1, number2, number3 };
            Array.Sort(numbers);
            Array.Reverse(numbers);
            Console.WriteLine($"Максимальное число: {numbers[0]}");
            Console.WriteLine($"Минимальное число: {numbers[2]}");
            Console.WriteLine($"Среднее число: {numbers[1]}");
        }
        static void Zadanie4_122()
        {
            Console.WriteLine("\nЗадание 4.122\nВведите первую сторону треугольника");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону треугольника");
            float number2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью сторону треугольника");
            float number3 = float.Parse(Console.ReadLine());
            //У треугольника сумма любых двух сторон должна быть больше третьей.
            if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2)
                Console.WriteLine($"Треугольник со сторонами {number1}, {number2}, {number3} существует");
            else
                Console.WriteLine($"Треугольник со сторонами {number1}, {number2}, {number3} не существует");
        }
        static void Zadanie5_22()
        {
            Console.WriteLine("\nЗадание 5.22\nВведите стоимость конфет за 1 килограмм");
            double cost = double.Parse(Console.ReadLine());
            for (double i = 0.1; i < 2.01; i += 0.1)
                Console.WriteLine($"За {Math.Round(i * 1000)} грамм {Math.Round(cost * i)} у.е.");
        }
        static void Zadanie5_47()
        {
            int result = 1;
            int[] numbers = new int[6];
            Console.WriteLine("\nЗадание 5.47");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1}-е число");
                numbers[i] = int.Parse(Console.ReadLine());
                result *= numbers[i];
            }
            Console.WriteLine($"{result}");
        }
        static void Zadanie5_72()
        {
            double run = 10;
            double distance = 10;
            Console.WriteLine("\nЗадание 5.72");
            for (int i = 2; i < 11; i++)
            {
                run *= 1.1;
                distance += run;
                Console.WriteLine($"За {i}-й день преодолено ещё {run} км");
                if (i == 7)
                    Console.WriteLine($"Всего за {i} дней было преодолено {distance} км");
            }
        }
        static void Zadanie6_22()
        {
            Console.WriteLine("\nЗадание 6.22\nВведите натуральное число:");
            string number = Console.ReadLine();
            int ThreesCount, LastCount, EvenNumbersCount, Sum, Mult, ZerosAndFivesCount;
            ThreesCount = LastCount = EvenNumbersCount = Sum = Mult = ZerosAndFivesCount = 0;

            Mult = 1;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '3')
                    ThreesCount++;

                if (number[i] == number[number.Length - 1])
                    LastCount++;

                bool CheckNumber = number[i] % 2 == 0;
                switch (CheckNumber)
                {
                    case true:
                        EvenNumbersCount++;
                        break;
                    case false:
                        break;
                }
                if (int.Parse(number[i].ToString()) > 5)
                    Sum += int.Parse(number[i].ToString());
                if (int.Parse(number[i].ToString()) > 7)
                    Mult *= int.Parse(number[i].ToString());
                if (number[i] == '0' || number[i] == '5')
                    ZerosAndFivesCount++;
            }
            Console.WriteLine($"количество цифр 3: {ThreesCount}\n" +
                $"сколько раз встречается последняя цифра: {LastCount}\n" +
                $"количество четных цифр: {EvenNumbersCount}\n" +
                $"сумму цифр, больших пяти: {Sum}\n" +
                $"произведение цифр, больших семи: {Mult}\n" +
                $"сколько раз встречаются цифры 0 и 5 (всего): {ZerosAndFivesCount}");
        }
        static void Zadanie6_47()
        {
            Console.WriteLine("\nЗадание 6.47");
            Random rnd = new Random();
            int a = rnd.Next(1, 11), b = rnd.Next(1, 11), k = rnd.Next(1, 11), m = rnd.Next(1, 11);
            Console.WriteLine($"а) Верно ли, что сумма его цифр меньше {a}?" +
                $"\r\nб) Верно ли, что произведение его цифр больше {b}?" +
                $"\r\nв) Верно ли, что это число {k}-значное?" +
                $"\r\nг) Верно ли, что его первая цифра превышает {m}");
            Console.WriteLine("Введите натуральное число:");
            string number = Console.ReadLine();
            bool[] results = new bool[4];
            int sum = 0;
            int mult = 1;
            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
                mult *= int.Parse(number[i].ToString());
            }
            results[0] = sum < a;
            results[1] = mult > b;
            results[2] = number.Length == k;
            results[3] = int.Parse(number[0].ToString()) > m;
            for (int j = 0; j < results.Length; j++)
                Console.WriteLine(results[j]);
        }
        static void Zadanie6_72()
        {
            bool isRight = true;
            //В таком случае массив будет считаться правильным:
            //var points = new int[] { 3, 5, 6, 6, 7, 24, 33 };
            var points = new int[] { 3, 5, 6, 6, 7, 54, 33 };
            var places = new int[] { 7, 6, 5, 4, 3, 2, 1 };

            var sortedPoints = new int[points.Length];
            var sortedPlaces = new int[places.Length];

            for (int i = 0; i < points.Length; i++)
            {
                sortedPoints[i] = points[i];
                sortedPlaces[i] = places[i];
            }
            Array.Sort(sortedPoints);
            Array.Sort(sortedPlaces);

            if (points == sortedPoints && places == sortedPlaces) { }

            else
                isRight = false;
            Console.WriteLine("\nЗадание 6.72\n" + isRight);
        }
        static void Zadanie6_97()
        {
            Console.WriteLine("\nЗадание 6.97");
            int[] points = new int[20] { 53, 51, 48, 47, 43, 42, 41, 40, 37, 35, 30, 29, 28, 27, 23, 20, 19, 18, 17, 15 };
            for (int i = 0; i < points.Length - 1; i++)
            {
                Console.Write(points[i] + ", ");
            }
            Console.Write(points[19] + "\nВведите кол-во очков для определения места команды:");
            int target = int.Parse(Console.ReadLine());
            for (int j = 0; j < points.Length;)
            {
                //Пока НЕ содержит выбранное кол-во очков, сравниваем с последующими резульатами команд
                while (!points[j].ToString().Contains($"{target.ToString()}"))
                {
                    j++;
                }
                Console.WriteLine($"{j + 1}-место с {target} очками");
                break;
            }
        }
        static void Zadanie7_22()
        {
            int maxNewspaper = 16;
            int minMagazine = maxNewspaper + 1;
            Console.WriteLine($"\nЗадание 7.22\nМинимальный объём журналов: {minMagazine} страниц" +
                $"\nМаксимальное количество страниц журналов: бесконечность");
        }
        static void Zadanie7_47()
        {
            float[] weightMass = new float[9] { 135, 77, 64, 65, 150, 99, 89, 61, 163 };
            float FatPeoplesWeight, FatPeoplesCount, AnotherPeuplesWeight, AnotherPeoplesCount;
            FatPeoplesWeight = FatPeoplesCount = AnotherPeuplesWeight = AnotherPeoplesCount = 0;
            for (int i = 0; i < weightMass.Length; i++)
            {
                if (weightMass[i] > 100)
                {
                    FatPeoplesWeight += weightMass[i];
                    FatPeoplesCount++;
                }
                else
                {
                    AnotherPeuplesWeight += weightMass[i];
                    AnotherPeoplesCount++;
                }
            }
            Console.WriteLine($"\nЗадание 7.47\nСредний вес 'полных' людей: {FatPeoplesWeight / FatPeoplesCount} кг" +
                $"\nСредний евс остальных людей: {AnotherPeuplesWeight / AnotherPeoplesCount} кг");
        }
        static void Zadanie7_72()
        {
            float[] voltageMass = new float[20] {1.5f, 4.2f, 53.1f, 54.3f, 0.5f, 4.4f, 3.2f, 5.1f, 5.5f, 32.1f,
                                                 55.4f, 41.5f, 43.2f, 42.1f, 5.6f, 23.4f, 27.9f, 10.5f, 54.1f, 50f};
            float[] resistanseMass = new float[20] {5f,3f,6f,11f,3f,13f,55f,132f,150f,100f,
                                                     44f,32f,213f,43f,5545f,435f,3443f,2334f,4343f,10f};

            float minAmperage = voltageMass[0] * resistanseMass[0];
            int numberResistanse = 0;
            for (int i = 0; i <= voltageMass.Length - 1; i++)
            {
                if (minAmperage > voltageMass[i] * resistanseMass[i])
                {
                    minAmperage = voltageMass[i] * resistanseMass[i];
                    numberResistanse = i + 1;
                }
            }
            Console.WriteLine($"\nЗадание 7.72\nМинимальный ток в {minAmperage}А проходит по порядковому номеру сопротивления {numberResistanse}");
        }
        static void Zadanie7_97()
        {
            const int n = 7;
            int[] mass = new int[n] { 3, 6, 10, 25, 9, 19, 15 };
            int sum20 = 0;
            int sum10 = 0;
            for (int j = 0; j < mass.Length; j++)
            {
                if (mass[j] < 20)
                    sum20 += mass[j];

                if (mass[j] < 10)
                    sum10 += mass[j];
            }
            Console.WriteLine($"\nЗадание 7.97\nНе превышает 50:{sum20 < 50}" +
                $"\nКратно трём: {sum10 % 3 == 0}");
        }
        static void Zadanie7_122()
        {
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            int[] ages = new int[6] { 7, 5, 6, 4, 8, 4 };
            for (int i = 0; i < ages.Length; i++)
            {
                if (maxValue < ages[i])
                    maxValue = ages[i];
                if (minValue > ages[i])
                    minValue = ages[i];
            }
            for (int j = 0; j < ages.Length; j++)
            {
                if (ages[j] == maxValue)
                {
                    Console.WriteLine($"\nЗадание 7.122\nПервее было максимальное значение {maxValue}");
                    break;
                }
                else if (ages[j] == minValue)
                {
                    Console.WriteLine($"\nЗадание 7.122\nПервее было миниальное значение {minValue}");
                    break;
                }
            }
        }
        static void Zadanie8_22()
        {
            Console.WriteLine("\nЗадание 8.22\n");
            Random rnd = new Random();
            int[,] students = new int[6, 5];
            int rows = students.GetUpperBound(0) + 1;    // количество строк
            int columns = students.Length / rows;        // количество столбцов
            int minStudents = int.MaxValue;
            int course, group, i, j, count;
            course = group = i = j = count = 0;
            int tmp = int.MaxValue;
            int[] minMass = new int[rows];
            int[] minOnCourses = new int[rows];
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    students[i, j] = rnd.Next(0, 30);
                    if (minStudents > students[i, j])
                    {
                        minStudents = students[i, j];
                        course = i;
                        group = j;
                    }
                    if (tmp > students[i, j])
                        tmp = students[i, j];
                    Console.WriteLine($"i:{i} j:{j}" + "\n" + students[i, j]);
                    count += students[i, j];
                }
                minMass[i] = tmp;
                tmp = int.MaxValue;
                minOnCourses[i] = count;
                count = 0;
                Console.WriteLine($"Минимум на {i + 1} курсе: {minMass[i]}");
            }
            count = int.MaxValue;
            for (i = 0; i < minOnCourses.Length - 1; i++)
            {
                if (count > minOnCourses[i])
                {
                    count = minOnCourses[i];
                }
            }
            Console.WriteLine($"Меньше всего обучается на {i++} курсе: {count}");
            Console.WriteLine($"В самой малочисленной группе {course} курса, группы {group}: {minStudents}");
        }
        static void Zadanie8_47()
        {
            Console.WriteLine("\nЗадание 8.47\nВведите желаемый вес:");
            int[] mass = new int[10] { 100, 200, 300, 500, 1000, 1200, 1400, 1500, 2000, 3000 };
            int targetWeight = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (mass[i] == targetWeight)
                {
                    count++;
                }
                for (int j = 0; j < mass.Length; j++)
                {

                    if (mass[i] + mass[j] == targetWeight)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"\n{count}");
        }
        static void Zadanie9_22()
        {
            Console.WriteLine("\nЗадание 9.22\nВведите слово со чётным количеством букв.");
            string text = Console.ReadLine();
            Console.WriteLine(text.Remove(text.Length / 2));
        }
        static void Zadanie9_47()
        {
            Console.WriteLine("\nЗадание 9.47\nВведите количество символов:");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите один символ:");
            string symbol = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol[0]);
            }
        }
        static void Zadanie9_72()
        {
            string text = "\nЗадание 9.72\nВерно ли, что число слов в предложении больше трех?";
            bool isLessThan3 = false;
            string[] textSplited = text.Split(" ");
            if (textSplited.Length > 3)
                isLessThan3 = true;
            Console.WriteLine(isLessThan3);
        }
        static void Zadanie9_97()
        {
            string text = "\nЗадание 9.97\nДано предложение. Заменить в нем все вхождения буквосочетания бит на рог.";
            Console.WriteLine(text.Replace("бит", "рог"));
        }
        static void Zadanie9_122()
        {
            string word = "чели_";
            Console.WriteLine("\nЗадание 9.122\nЗадайте символ:");
            string symbol = Console.ReadLine();
            if (word.Contains("и") == true)
                Console.WriteLine(word.Replace('_', symbol[0]));
        }
        static void Zadanie9_147()
        {
            Random rnd = new Random();
            int[] massNumbers = new int[20];
            int count = 0;
            for (int i = 0; i < massNumbers.Length - 1; i++)
            {
                massNumbers[i] = rnd.Next(1, 100000);
                Console.WriteLine(massNumbers[i]);
                count += massNumbers[i];
            }
            Console.WriteLine($"\nЗадание 9.147\nАлгебраическая сумма: {count}");
        }
        static void Zadanie9_172()
        {
            string text = "\nЗадание 9.172\nНапечатать его самое длинное слово";
            string[] words = text.Split(" ");
            string maxWord = "";
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (maxWord.Length < words[i].Length - 1)
                    maxWord = words[i];
            }
            Console.WriteLine($"Самое длинное слово: {maxWord}");
        }
        static void Zadanie10_22()
        {
            int[] numbers = new int[6] { 5, 4, 6324, 43434, 0, 4 };
            int max = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
                max = Math.Max(max, numbers[i]);
            Console.WriteLine($"\nЗадание 10.22\nМаксимальное число: {max}");
        }
        static void Zadanie10_47()
        {
            Console.WriteLine("\nЗадание 10.47\nВведите k:");
            int k = int.Parse(Console.ReadLine());
            int Fibonachi(int k)
            {
                if (k == 0 || k == 1) return k;

                return Fibonachi(k - 1) + Fibonachi(k - 2);
            }
            Console.WriteLine($"{k}-е число Фибоначчи: {Fibonachi(k)}");
        }
        static void Zadanie11_22()
        {
            Random rnd = new Random();
            int total = 0;
            int[] mass = new int[12];
            for (int i = 0; i < mass.Length - 1; i++)
                mass[i] = rnd.Next(1, 999999);
            for (int j = 0; j < mass.Length - 1; j++)
                total += mass[j];
            Console.WriteLine($"\nЗадание 11.22\nОбщая стоимость: {total}");
        }
        static void Zadanie11_47()
        {
            Random rnd = new Random();
            double[] mass = new double[10];
            for (int i = 0; i < mass.Length - 1; i++)
                mass[i] = rnd.Next(1, 50);
            for (int j = 0; j < mass.Length - 1; j++)
                if (mass[j] > 10)
                    mass[j] = Math.Sqrt(mass[j]);
            for (int k = 0; k < mass.Length - 1; k++)
                if (k % 2 == 0)
                    mass[k] = Math.Abs(mass[k]);
        }
        static void Zadanie11_72()
        {
            Random rnd = new Random();
            int positiveCount = 0;
            int negativeCount = 0;
            int[] mass = new int[5] { -5, -6, 2, 5, -4 };
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                    positiveCount++;
                else
                {
                    negativeCount++;
                }
            }
            Console.WriteLine($"\nЗадание 11.72\nПоложительных чисел: {positiveCount}\nОтрицательных чисел: {negativeCount}");
        }
        static void Zadanie11_97()
        {
            double[] mass = { 1.2, 3.4, 2 };
            double avg = mass.Average();
            double value = double.MaxValue,
                result = 0;
            for (int i = 0; i < mass.Length; i++)
                if (Math.Abs(avg - mass[i]) < value)
                {
                    value = Math.Abs(avg - mass[i]);
                    result = mass[i];
                }
            Console.WriteLine("\nЗадание 11.97\n" + result);
        }
        static void Zadanie11_122()
        {
            Random rnd = new Random();
            int minRange = 10;
            int maxRange = 20;

            int minCount = 0;
            int[] mass = new int[60];
            for (int i = 0; i < mass.Length - 1; i++)
            {
                mass[i] = rnd.Next(minRange, maxRange); //Определение стоимости путём выбора случайной величины
                if (mass[i] == minRange)
                    minCount++;
            }
            Console.WriteLine($"\nЗадание 11.122\nКоличество самых дешевых книг: {minCount}");
        }
        static void Zadanie11_147()
        {
            Console.WriteLine("\nЗадание 11.147\n");
            Random rnd = new Random();
            int[] mass = new int[15];
            int[] massSorted = new int[15];
            int tmp1, tmp2, minNum, maxNum, minID, maxID;
            tmp1 = tmp2 = minID = maxID = 0;
            //При сравнении любое число будет меньше и больше соответсвенно,
            //благодаря этому, условия будут работать всегда
            minNum = int.MaxValue;
            maxNum = int.MinValue;
            //Задаём значение исходному массиву, а массив,
            //над которым будут выполняться различные сортировки приравниваем к исходному
            for (int m = 0; m < mass.Length; m++)
            {
                mass[m] = rnd.Next(1, 100);
                massSorted[m] = mass[m];
                Console.Write(mass[m] + ", ");
            }

            Console.WriteLine("\n");
            int k = 3;
            int s = 9;
            for (int i = k; i < s; i++)
            {
                tmp1 = mass[i];
                tmp2 = mass[s];
                massSorted[i] = tmp2;
                massSorted[s] = tmp1;
                s--;
            }
            for (int l = 0; l < massSorted.Length; l++)
                Console.Write(massSorted[l] + ", ");
            Console.WriteLine("\n");
            //Вовзращаем массив в исходное состояние
            for (int m = 0; m < mass.Length; m++)
                massSorted[m] = mass[m];

            Console.WriteLine("\nВведите k (k < s)");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите s (k < s)");
            s = int.Parse(Console.ReadLine());
            for (int i = k; i < s; i++)
            {
                tmp1 = mass[i];
                tmp2 = mass[s];
                massSorted[i] = tmp2;
                massSorted[s] = tmp1;
                s--;
            }
            for (int l = 0; l < massSorted.Length; l++)
                Console.Write(massSorted[l] + ", ");
            Console.WriteLine("\n");
            //Вовзращаем массив в исходное состояние
            for (int m = 0; m < mass.Length; m++)
            {
                massSorted[m] = mass[m];
                if (minNum > massSorted[m])
                {
                    minNum = massSorted[m];
                    minID = m;
                }
                if (maxNum < massSorted[m])
                {
                    maxNum = massSorted[m];
                    maxID = m;
                }
            }
            Console.WriteLine($"mimNum:{minNum}\nminID:{minID}\nmaxNum:{maxNum}\nmaxID:{maxID}");
            for (int i = minID; i < maxID; i++)
            {
                tmp1 = mass[i];
                tmp2 = mass[s];
                massSorted[i] = tmp2;
                massSorted[s] = tmp1;
                maxID--;
            }
            for (int l = 0; l < massSorted.Length; l++)
                Console.Write(massSorted[l] + ", ");
        }
        static void Zadanie11_172()
        {
            Console.WriteLine("\nЗадание 11.172\nПеречень результатов (чем число больше, тем лучше):");
            Random rnd = new Random();
            int[] mass = new int[25];
            for (int i = 0; i < mass.Length - 1; i++)
                mass[i] = rnd.Next(1, 50);
            Array.Sort(mass);
            Array.Reverse(mass);
            for (int i = 0; i < mass.Length - 1; i++)
                Console.Write(mass[i] + ", ");
        }
        static void Zadanie11_197()
        {
            Random rnd = new Random();
            int[] mass = new int[28];
            bool haveUnderachievers = false;
            for (int i = 0; i < mass.Length - 1; i++)
            {
                mass[i] = rnd.Next(2, 5);
                if (mass[i] == 2)
                {
                    haveUnderachievers = true;
                    break;
                }
            }
            Console.WriteLine($"\nЗадание 11.197\nВ классе есть двоечники: {haveUnderachievers}");
        }
    }
}
