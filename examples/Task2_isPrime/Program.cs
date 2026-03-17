// Ввод данных
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
// Проверка простого числа
static bool IsPrime(int n){
    if (n <= 1){
    return false;
    }
    for (int i = 2; i * i <= n; i++){
        if (n % i == 0){
            return false;
        }
    }    
    return true;
}
// вывод данных
bool result = IsPrime(number);
if (result){
    Console.WriteLine($"{number} - простое число");
}
else{
    Console.WriteLine($"{number} - не простое число");
}
    
