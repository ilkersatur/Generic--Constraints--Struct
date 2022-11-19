//? ?? ------- generic bir yapılır
//Nullable Types
//içine hiç değer atanmamış değerlerdir
//Normal şartlar altında null değer alamaz

//int sayi = null;
string str = null;
object obj = null;
//int sayi = null;

Nullable<int> nullable = null;
Console.WriteLine(nullable.GetValueOrDefault());
nullable = 123;
Console.WriteLine(nullable.GetValueOrDefault());

//null değeri referans tipliler alınır
//? elvis operatörü
int? number = null; //int nullable type çevirdik
int? number1 = 12;
Console.WriteLine(number1 ?? -5); // ?? ----- nullable.GetValueOrDefault()