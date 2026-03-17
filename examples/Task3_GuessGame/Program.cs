// Создание переменных
System.Random random = new System.Random();
int x = random.Next(0, 101);
int att = 0;
// Ввод n
System.Console.Write("Введите число: ");
int n = int.Parse(System.Console.ReadLine());
// Угадывание числа
while (x != n){
    att = att + 1;
    System.Console.Write("Введите число: ");
    if (n == x){ }
    else if (n < x){
        System.Console.WriteLine("Больше");
    }
     else{
        System.Console.WriteLine("Меньше");
    }
    n = int.Parse(System.Console.ReadLine());
}
// Вывод ответа
System.Console.WriteLine("Вы угадали!");