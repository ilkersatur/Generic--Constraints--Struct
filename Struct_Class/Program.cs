//class --- referans tipli
//struct ---- değer tipli
// kendi veri yapılarımızı oluşturmamızı sağlar ve ramin hangi gölgesinde tutulacağına karar veriyoruz
// bir veri yapısı 16 byte tan küçük ise struct olarak kullan, büyükse class kullan
using ConsoleApp4;
using Struct_Class;

Nokta nokta = new Nokta();

nokta.X = 23;
nokta.Y = 12;

nokta.Yaz();
//struct lar için varsayılar ctor lar ilk değer ataması yapılır... ilgili tip için değerleri varsayılan alır. 
int sayi = new int();
Console.WriteLine(sayi);
// en temelde 16 byte tan küçükse bunu kullan
// büyük byte struct stack yapısını bozar