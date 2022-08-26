// // Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// // число и на выходе показывает вторую цифру этого числа.

// //Описываем функцию
// int CutNumber(){
// //Задаем рандомное число, выводим его на экран
//     int num = new Random().Next(100,1000);
//     Console.WriteLine("Number is =  " + num);
// //Математическая магия
//     int dec = num % 100;
//     int ed = num % 10;
//     int result = (dec-ed)/10;
//     return result;
// }
// //Вывод
// int number = CutNumber();
// Console.WriteLine("Cutted number is =  " +number);

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// //Описываем функцию
// void third(int num1){ 
//     int a;
//     if (num1 <= 99) {
//         Console.WriteLine("Третьей цифры нет!");
//     }
//     else {
// //Магия! И без массива же получилось! Кайф.
//     while (num1>1000) {
//     a=num1 % 10;
//     num1= (num1-a)/10;
//     }
//         int dec = num1 % 10;
//         Console.WriteLine("Результат :"+dec);
//     }

// }
// //Ввод числа
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// third(a);


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.


// // Функция!
// void dennedeli(int a){
// if (a > 5 && a < 8) {
// Console.WriteLine("да");
// }
// else if (a<5){
// Console.WriteLine("нет");
// }
// else Console.WriteLine("Число должно быть в диапазано от 1 до 7, это же дни недели :-|");
// }

// //Ввод, вывод, хехе
// Console.Write("Введите число: ");
// int chislo = Convert.ToInt32(Console.ReadLine());
// dennedeli(chislo);


