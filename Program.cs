         // Выполнение практических задааний на семинарах

         // Семинары, урок 5 (29.09.22)
Seminar_5_Task_37();
// Seminar_5_Task_35();
// Seminar_5_Task_33();
// Seminar_5_Task_32();
// Seminar_5_Task_26();

static void Seminar_5_Task_37() {
          // Задача 37. Найдите произведение пар чисел в одномерном массиве.
          // Парой считаем первый и последний элемент, второй и предпоследний и т.д.
          // Результат запишите в новом массиве.
    Random RundNum = new Random();
    int size = RundNum.Next(6,16);
    int[] Nums = new int[size]; 
          // Заполнение массива и его печать выполняются соответствующими подпрограммами
    Seminar_5_Task_37_FillArray(Nums);
    Seminar_5_Task_37_PrintArray(Nums);
    Seminar_5_Task_37_Multiplication(Nums);
    Console.WriteLine("- - - - - - - Задача 37 успешно выполнена! - - - - - - -\n");
}
static void Seminar_5_Task_37_Multiplication(int[] Mas) {
          // Задача 35. Подпрограмма перемножения чисел 
    int MaxIndex = Mas.Length - 1;
    for (int i=0; i<(Mas.Length/2); i++) Console.Write ($"{Mas[i]} * {Mas[MaxIndex-i]} = {Mas[i]*Mas[MaxIndex-i]}\n");
    if ((Mas.Length % 2) == 1) Console.Write ($"Средний элемент массива: {Mas[Mas.Length / 2]}\n");
}
static void Seminar_5_Task_37_FillArray(int[] Mas) {
          // Задача 33. Подпрограмма заполнения массива
    Random RundNum = new Random();
    for (int i=0; i<Mas.Length; i++) Mas[i] = RundNum.Next(-100,100);
}
static void Seminar_5_Task_37_PrintArray(int[] Mas) {
          // Задача 33. Подпрограмма печати массива
    for (int i=0; i<Mas.Length; i++) Console.Write(Mas[i] + "\t");
    Console.Write("\n");
}
static void Seminar_5_Task_35() {
          // Задача 34. Задайте одномерный массив, состоящий из случайных чисел.
          // Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
          // [5, 18, 123, 6, 2] -> 1; [1, 2, 3, 6, 2] -> 0; [10, 11, 12, 13, 14] -> 5
    Random RundNum = new Random();
    int size = RundNum.Next(10,16);
    int[] Nums = new int[size]; 
          // Заполнение массива и его печать выполняются соответствующими подпрограммами
    Seminar_5_Task_35_FillArray(Nums);
    Seminar_5_Task_35_PrintArray(Nums);
    Seminar_5_Task_35_FindValues(Nums);
    Console.WriteLine("- - - - - - - Задача 35 успешно выполнена! - - - - - - -\n");
}
static void Seminar_5_Task_35_FindValues(int[] Mas) {
          // Задача 35. Подпрограмма поиска элементов, лежащих в диапазоне [10, 99] , 
    int k = 0;
    for (int i=0; i<Mas.Length; i++)
        if ((Mas[i] >= 10) & (Mas[i] <= 99)) k++;
/*    while (found & (i<Mas.Length)) {
        if (Mas[i] == Num) found = true;
        i++; 
    } */
    Console.Write($"В массиве имеется {k} чисел, лежащих в диапазоне [10, 99].\n");
}
static void Seminar_5_Task_35_FillArray(int[] Mas) {
          // Задача 33. Подпрограмма заполнения массива
    Random RundNum = new Random();
    for (int i=0; i<Mas.Length; i++) Mas[i] = RundNum.Next(-100,100);
}
static void Seminar_5_Task_35_PrintArray(int[] Mas) {
          // Задача 33. Подпрограмма печати массива
    for (int i=0; i<Mas.Length; i++) Console.Write(Mas[i] + "\t");
    Console.Write("\n");
}
static void Seminar_5_Task_33() {
          // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
    Console.WriteLine("Введите число для поиска:");
    int N = Convert.ToInt16(Console.ReadLine());
    Random RundNum = new Random();
    int size = RundNum.Next(10,16);
    int[] Nums = new int[size]; 
          // Заполнение массива и его печать выполняются соответствующими подпрограммами
    Seminar_5_Task_33_FillArray(Nums);
    Seminar_5_Task_33_PrintArray(Nums);
    Seminar_5_Task_33_FindValue(Nums, N);
    Console.WriteLine("- - - - - - - Задача 33 успешно выполнена! - - - - - - -\n");
}
static void Seminar_5_Task_33_FindValue(int[] Mas, int Num) {
          // Задача 33. Подпрограмма поиска числа
    bool found = false;
//    int i = 0;
    for (int i=0; (!(found) & i<Mas.Length); i++) if (Mas[i] == Num) found = true;
/*    while (found & (i<Mas.Length)) {
        if (Mas[i] == Num) found = true;
        i++; 
    } */
    if (found) Console.Write($"Число {Num} присутствует в массиве.\n");
      else Console.Write($"Число {Num} не присутствует в массиве.\n");
}
static void Seminar_5_Task_33_FillArray(int[] Mas) {
          // Задача 33. Подпрограмма заполнения массива
    Random RundNum = new Random();
    for (int i=0; i<Mas.Length; i++) Mas[i] = RundNum.Next(0,21);
}
static void Seminar_5_Task_33_PrintArray(int[] Mas) {
          // Задача 33. Подпрограмма печати массива
    for (int i=0; i<Mas.Length; i++) Console.Write(Mas[i] + "\t");
    Console.Write("\n");
}
static void Seminar_5_Task_32()      {
          // Задача 32. Напишите программу замены элементов массива:
          // положительные элементы замените на соответствующие отрицательные, и наоборот.
    Random RundNum = new Random();
    int size = RundNum.Next(10,16);
    int[] Nums = new int[size]; 
          // Заполнение массива и его печать выполняются соответствующими подпрограммами
    Seminar_5_Task_32_FillArray(Nums);
    Seminar_5_Task_32_PrintArray(Nums);
    Seminar_5_Task_32_ChangeValues(Nums);
    Seminar_5_Task_32_PrintArray(Nums);
    Console.WriteLine("- - - - - - - Задача 32 успешно выполнена! - - - - - - -\n");
}
static void Seminar_5_Task_32_ChangeValues(int[] Mas) {
          // Задача 32. Подпрограмма замены элементов
    for (int i=0; i<Mas.Length; i++) Mas[i] = - Mas[i];
}
static void Seminar_5_Task_32_FillArray(int[] Mas) {
          // Задача 32. Подпрограмма заполнения массива
    Random RundNum = new Random();
    for (int i=0; i<Mas.Length; i++) Mas[i] = RundNum.Next(-10,11);
}
static void Seminar_5_Task_32_PrintArray(int[] Mas) {
          // Задача 32. Подпрограмма печати массива
    for (int i=0; i<Mas.Length; i++) Console.Write(Mas[i] + "\t");
    Console.Write("\n");
}

         // Семинары, урок 4 (26.09.22)
// Seminar_3_Task_17();
// Seminar_3_Task_18();
// Seminar_4_Task_30();
// Seminar_4_Task_26();

static void Seminar_4_Task_30()      {
          // Задача 30. Напишите программу, которая выводит массив из 8 элементов,
          // заполненный нулями и единицами в случайном порядке, например: [1,0,1,1,0,1,0,0].
    Random RundNum = new Random();
    int size = RundNum.Next(4,10);
    int[] Nums = new int[size]; 
          // Заполнение массива и его печать выполняются соответствующими подпрограммами
//    for (int i=1; i<size; i++) Nums[i] = RundNum.Next(0,2);
//    for (int i=1; i<size; i++) Console.Write(Nums[i] + "\t");
    Seminar_4_Task_30_FillArray(Nums);
    Seminar_4_Task_30_PrintArray(Nums);
    Console.WriteLine("- - - - - - - Задача 30 успешно выполнена! - - - - - - -\n");
}
static void Seminar_4_Task_30_FillArray(int[] Mas) {
          // Задача 30. Подпрограмма заполнения массива
    Random RundNum = new Random();
    for (int i=1; i<Mas.Length; i++) Mas[i] = RundNum.Next(0,2);
}
static void Seminar_4_Task_30_PrintArray(int[] Mas) {
          // Задача 30. Подпрограмма печати массива
    for (int i=1; i<Mas.Length; i++) Console.Write(Mas[i] + "\t");
    Console.Write("\n");
}
static void Seminar_4_Task_26()      {
          // Задача 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
    Console.Write("Введите число:");
    int Num = Convert.ToInt32(Console.ReadLine());
          // Для подсчета количества цифр используем десятичный логарифм округленный вверх
    Console.WriteLine($"Количество цифр в числе {Num}: {Math.Ceiling(Math.Log10(Num))}");
    Console.WriteLine("- - - - - - - Задача 26 успешно выполнена! - - - - - - -\n");
}
/*
         // Семинары, урок 3 (22.09.22)
// Seminar_3_Task_17();
// Seminar_3_Task_18();
// Seminar_3_Task_21();
// Seminar_3_Task_22();

static void Seminar_3_Task_22() {
          // Задача 22. Напишите программу, которая принимает на вход число (N) и выдаёт 
          // таблицу квадратов чисел от 1 до N.
    Random RundNum = new Random();
    int Num = RundNum.Next(1, 100);
    string ResultStr = "";
    int i = 1;

    Console.WriteLine($"Квадраты чисел от 1 до {Num}:");
    while (i <= Num) {
        if (ResultStr.Length > 0) ResultStr = ResultStr.Insert(ResultStr.Length, ", ");
        ResultStr = ResultStr.Insert(ResultStr.Length, Convert.ToString(Math.Pow(i,2)));
        i = i + 1;
    }
    Console.WriteLine(ResultStr);
}
static void Seminar_3_Task_21() {
          // Задача 21. Напишите программу, которая принимает на вход координаты двух точек
          // и находит расстояние между ними в 2D пространстве.
//    Console.WriteLine("Введите первое число:");
//    int N1= Convert.ToInt16(Console.ReadLine());
//    Console.WriteLine("Введите второе число:");
//    int N2= Convert.ToInt16(Console.ReadLine());
    Random RundNum = new Random();
    int Ax = RundNum.Next(-10, 11);
    int Ay = RundNum.Next(-10, 11);
    int Bx = RundNum.Next(-10, 11);
    int By = RundNum.Next(-10, 11);

    Console.WriteLine($"Точки: A({Ax}, {Ay}), B({Bx}, {By})");
    Console.WriteLine($"Расстояние между точками А и В: {Math.Sqrt(Math.Pow((Bx-Ax),2) + Math.Pow((By-Ay),2))}");
}
static void Seminar_3_Task_18() {
          // Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон 
          // возможных координат точек в этой четверти (x и y).
    Random RundNum = new Random();
    int q = RundNum.Next(1, 5);
    Console.WriteLine($"Задана четветь {q}");
    
    if (q == 1) Console.WriteLine("Точки будут иметь координаты: (0 < X < ∞) и (0 < Y < ∞).");
        else if (q == 2) Console.WriteLine("Точки будут иметь координаты: (-∞ < X < 0) и (0 < Y < ∞).");
                 else if (q == 3) Console.WriteLine("Точки будут иметь координаты: (-∞ < X < 0) и (-∞ < Y < 0).");
                          else if (q == 4) Console.WriteLine("Точки будут иметь координаты: (0 < X < ∞) и (-∞ < Y < 0).");
                                   else Console.WriteLine("Указана несуществующая четверть.");
}
static void Seminar_3_Task_17() {
          // Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0,
          // и выдаёт номер четверти плоскости,  в которой находится эта точка.
//    Console.WriteLine("Введите первое число:");
//    int N1= Convert.ToInt16(Console.ReadLine());
//    Console.WriteLine("Введите второе число:");
//    int N2= Convert.ToInt16(Console.ReadLine());
    Random RundNum = new Random();
    int x = RundNum.Next(-10, 11);
    int y = RundNum.Next(-10, 11);
//    Console.WriteLine($"Точка ({x}, {y})");
    
    if ((x > 0) && (y > 0)) Console.WriteLine($"Точка ({x}, {y}) лежит в первой четверти.");
        else if ((x < 0) && (y > 0)) Console.WriteLine($"Точка ({x}, {y}) лежит во второй четверти.");
                 else if ((x < 0) && (y < 0)) Console.WriteLine($"Точка ({x}, {y}) лежит в третьей четверти.");
                          else if ((x > 0) && (y < 0)) Console.WriteLine($"Точка ({x}, {y}) лежит в четвертой четверти.");
                                   else Console.WriteLine($"Точка ({x}, {y}) лежит на одной из осей.");
} */
/*
         // Семинары, урок 2 (19.09.22)
// Seminar_2_Task_09();
// Seminar_2_Task_11();
// Seminar_2_Task_12();
// Seminar_2_Task_14();
// Seminar_2_Task_16();
 static void Seminar_2_Task_16() {
          // Задача 16. Напишите программу, которая принимает на вход два числа и проверяет, 
          // является ли одно число квадратом другого.
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
} */