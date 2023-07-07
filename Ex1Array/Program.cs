int[] numbers = { 1, 2, 3, 4, 5 }; // Массив из целых чисел 
string[] names = { "Alice", "Bob", "Charlie" }; // Массив строк
bool[] flags = new bool[3]; // Массив bool

// Способы "Обхода массивов"
// 1. foreach
Console.WriteLine("Перебор int[] numbers = { 1, 2, 3, 4, 5 }");
foreach (int item in numbers) // указываем тип item
    Console.WriteLine(item);
// 2. for
Console.WriteLine("Перебор string[] names =  Alice, Bob, Charlie");
for (int i = 0; i < names.Length; i++)
    Console.WriteLine(names[i]);
// 3. Доступ к отдельным элементам
Console.WriteLine("Печатаем элемент массива с индексом 0  numbers = { 1, 2, 3, 4, 5 }");
Console.WriteLine(numbers[0]); // Первый элемент , индекс  = 0
Console.WriteLine(numbers[numbers.Length - 1]); // последний элемент , индекс = 4. numbers.Length = 5 
// 4. Многомерные массивы
int[,] matrix = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
Console.WriteLine("Доступ к отдельному элементу с индексом 0 0");
Console.WriteLine(matrix[0, 0]); // Доступ к отдельному элементу
Console.WriteLine("Печатаем целую строку массива  { 1, 2 }, { 3, 4 }, { 5, 6 } с индексом 1");
for (int i = 0; i < matrix.GetLength(1); i++) // Печатаем целую строку с индексом 1
    Console.Write(matrix[1, i] + " ");
Console.WriteLine(); // Печатаем чтобы перевести строку
Console.WriteLine("Печатаем целый столбец массива  { 1, 2 }, { 3, 4 }, { 5, 6 } с индексом 1");
for (int i = 0; i < matrix.GetLength(1); i++) // Печатаем целую строку с индексом 1
    Console.Write(matrix[i,1] + " ");