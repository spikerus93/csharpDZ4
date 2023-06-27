// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А:  ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:  ");
int B = Convert.ToInt32(Console.ReadLine());

int A_B=1;
  for(int i=0; i<B; i++) 
  {
   A_B*=A;
  }
  Console.WriteLine("{0} ^ {1} = {2}", A, B, A_B);