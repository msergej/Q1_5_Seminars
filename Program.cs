         // Выполнение практических задааний на семинарах

         
         // Семинары, урок 2 (19.09.22)
// Seminar_2_Task_09();
// Seminar_2_Task_11();
// Seminar_2_Task_12();
// Seminar_2_Task_14();
Seminar_2_Task_16();
 
static void Seminar_2_Task_16() {
          // Задача 16. Напишите программу, которая принимает на вход два числа и проверяет, 
          // яявляется ли одно число квадратом другого.
    Console.WriteLine("Введите первое число:");
    int N1= Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int N2= Convert.ToInt16(Console.ReadLine());
    
    if ((N1 == Math.Pow(N2, 2)) || (N2 == Math.Pow(N1, 2))) Console.WriteLine($"Одно из чисел {N1} и {N2} является квадратом другого числа.");
        else Console.WriteLine($"Ни одно из чисел {N1} и {N2} не является квадратом другого числа.");
}
static void Seminar_2_Task_14() {
          // Задача 14. Напишите программу, которая принимает на вход число и проверяет, 
          // кратно ли оно одновременно 7 и 23.
    Console.WriteLine("Введите число:");
    int Num= Convert.ToInt16(Console.ReadLine());
    
    if (Num % 161 != 0) Console.WriteLine($"Число {Num} не кратно одновременно 7 и 23.");
        else Console.WriteLine($"Число {Num} кратно одновременно 7 и 23.");
}
static void Seminar_2_Task_12() {
          // Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить,
          // является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит
          // остаток от деления.
    Console.WriteLine("Введите первое число:");
    int N1= Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int N2= Convert.ToInt16(Console.ReadLine());
    
    if (N2 % N1 != 0) Console.WriteLine($"Второе число {N2} не кратно первому числу {N1}. Остаток от деления: {N2%N1}");
        else Console.WriteLine($"Второе число {N2} кратно первому числу {N1}. Остаток от деления: {N2%N1}");
}
static void Seminar_2_Task_11() {
          // Задача 11. Напишите программу, которая выводит случайное трёхзначное число
          // и удаляет вторую цифру этого числа.       
          // Генерация случайного числа
    Random RundNum = new Random();
    int Num = RundNum.Next(100, 1000);
    Console.WriteLine (Num);
          // выделение разрядов десятков и единиц (если INT, то "/" - это челочисленное деление)
    int hunderts = Num / 100;
    int ones =(Num % 100) % 10;
    Console.WriteLine($"Итоговое число без средней цифры>: {hunderts*10 + ones}");
}
static void Seminar_2_Task_09() {
          // Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
          // и показывает наибольшую цифру этого числа.       
          // Генерация случайного числа
    Random RundNum = new Random();
    int Num = RundNum.Next(10, 100);
    Console.WriteLine (Num);
          // выделение разрядов десятков и единиц (если INT, то "/" - это челочисленное деление)
    int tens = Num / 10;
    int ones = Num % 10;
    if (tens > ones) Console.WriteLine($"Большее число: {tens}");
        else Console.WriteLine($"Большее число: {ones}");
}





