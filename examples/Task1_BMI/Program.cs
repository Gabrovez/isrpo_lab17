//Ввод данных
Console.WriteLine("Введите вес (кг):");
double weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите рост (м):");
double height = Convert.ToDouble(Console.ReadLine());
// Вычисление имт 
double bmi = weight / (height * height);
// Определение категории
string category;

if (bmi < 18.5){
    category = "Недостаточный вес"; 
}
else if (bmi >= 18.5 && bmi < 25){
    category = "Нормальный вес";
}
else if (bmi >= 25 && bmi < 30){
    category = "Избыточный вес";
}
else{
    category = "Ожирение";
}
// Вывод данных           
Console.WriteLine($"Ваш ИМТ: {bmi:F2}");
Console.WriteLine($"Категория: {category}");