/* 
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
N = 5 -> "1, 2, 3, 4, 5" 
N = 6 -> "1, 2, 3, 4, 5, 6" 
*/ 
 
string ReturnRealDigits(int startNum, int number)
    { 
        if(startNum == number) return startNum.ToString(); 
        return startNum + " " + ReturnRealDigits(startNum+1,number); // " " для преобразования всего рядом в string 
    } 

Console.WriteLine(ReturnRealDigits(1,5));