//Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.


int [] number = new int[8];
Console.Write("{");

for (int i = 0; i < number.Length; i++)
 {
    number [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("}");

int Method (int a)
{
    return number[a];
}


 