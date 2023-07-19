/* 
//прямая рекурсия (сначлала действие потом запрос рекурсии)
void Print(int value)
    {
        Console.WriteLine(value);
        if(value <5) Print(value+1);
    }

    Print(1);
*/

//обратная рекурсия (сначала вызываем рекурсия потом действие)

/*void Print(int value)
    {
        if(value <5) Print(value+1);
        Console.WriteLine(value);
    }

    Print(1);
*/

 /*Задача 67: Напишите программу, 
 которая будет принимать на 
 вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

 int SumDigit(int number)
    {
        if(number == 0) return 0 ;//условие выхода из рекурсии
        return number%10 + SumDigit(number/10) ;
    }
    Console.WriteLine(SumDigit(453));