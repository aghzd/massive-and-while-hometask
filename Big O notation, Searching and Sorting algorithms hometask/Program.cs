//1.Verilmiş Arrayın elementlərinin cəmini ekrana çap edin
//int[] num1 = {1,2,23,31,13,15,26};
//int sum = default;
//for (int i = 0; i < num1.Length; i++)
//{
//    sum += num1[i];
//}
//Console.WriteLine($"num1 massivindeki elementlerin cemi = {sum}");

//2.Verilmiş int Arrayın ən böyük dəyərə sahib elementini tapın
//int[] num1 = { 12, 41, 25, 53 };
//int max = num1[0];
//for (int   i= 0;   i< num1.Length;  i++)
//{
//    if (num1[i] > max)
//    {
//        max = num1[i];
//    }
//}
//Console.WriteLine($"num1 massivindeki elementlerden en boyuyu {max} dir");


//3.Verilmiş Arrayın ilk və son elementlərinin cəmini tapın
//int[] num1 = [1, 3, 5, 7, 9, 12];
//int sum  = 0;
//int max = num1[0];
//int min = num1[1];
//for (int i = 0; i < num1.Length; i++)
//{
//    if (num1[i] > max)
//        max = num1[i];
//    else if (num1[i] < min)
//        min = num1[i];
//}
//sum = min + max;
//Console.WriteLine(sum);


//4.Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın
//int n = 13;
//while (n % 2 == 0)
//{
//    n /= 2;
//}
//if (n ==1 )
//    Console.WriteLine("2 nin quvvetidir");
//else
//    Console.WriteLine("2 nin quvveti deyil");





//5.Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5
//int n = 1234734846;
//int count = 0;
//while (n > 0)
//{
//    n /= 10;
//    count++;
//}
//Console.WriteLine($"eded {count} mertebelidir ");


//6.Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiryi indexi tapan alqoritm(meselen 50 axtaririq egər siyahıda 50 ədədi yoxdursa -1 print olsun, varsa var olduğu index)
//int[] numbers = { 1, 23, 54, 50, 23, 43, 66 };
//int count = -1;

//for (int i = 0; i < numbers.Length; i++)
//{
//     if (numbers[i] == 50)
//        count = i;
//}
//if (count != -1)
//    Console.WriteLine($" 50 reqeminin sirasi {count} dur");
//else
//    Console.WriteLine("sirada 50 ededi yoxdur");