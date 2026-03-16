//Функция сложения
static double Add(double a, double b){
    return a + b;
}
//Функция вычитания
static double Subtract(double a, double b){
    return a - b;
}
//Функция умножения
static double Multiply(double a, double b){
    return a * b;
}
//Функция деления
static double Divide(double a, double b){
    return a / b;
}

//Ввод данных
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

//Вывод ответа
Console.WriteLine($"Сложение: {Add(num1, num2)}");
Console.WriteLine($"Вычитание: {Subtract(num1, num2)}");
Console.WriteLine($"Умножение: {Multiply(num1, num2)}");
Console.WriteLine($"Деление: {Divide(num1, num2)}");
