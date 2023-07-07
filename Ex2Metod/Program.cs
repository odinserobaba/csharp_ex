// 1. Пустой метод
Console.WriteLine("1. Пустой метод");
void Hello() // Метод , ничего не возвращает (void) 
{
    Console.WriteLine("Hello!");
}
Hello();
// 2. Возвращение целочисленного значения
Console.WriteLine("2. Возвращение целочисленного значения");
int Add(int a, int b) // Метод возвращает Int целочисленное значение суммы двух элементов
{
    return a + b;
}
Console.WriteLine(Add(1,3));
// 3. Значения по умолчанию
Console.WriteLine("3. Значения по умолчанию");
int Multiply(int a, int b = 1) // Метод возвращает Int целочисленное значение произведения двух элементов
{
    return a * b;
}
Console.WriteLine(Multiply(2,4));
// 4. Модификатор ref меняет значение x которые отражены в методе
Console.WriteLine("4. Модификатор ref меняет значение x которые отражены в методе");
int x = 1;
void Func(ref int y)
{
    y=y+10;
}
Func(ref x);
Console.WriteLine(x);
Func(ref x);
Console.WriteLine(x);