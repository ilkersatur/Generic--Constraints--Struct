//Generic Kolleksiyonlar
//List<> , Queue<>, Stack<>, Dictionaty<>, SortedList<>

//List<int> liste1 = new List<int>();
//liste1.Add(1);

//List<string> liste2 = new List<string>();
//liste2.Add("");

/*
 Generic kolleksiyonları neden kullanmalıyız
 Önemi
1- Performans
2- Tip güvenliği
 */

//Performans Karşılaştırılması

using System.Collections;
using System.Net.WebSockets;

ArrayList liste1 = new ArrayList();
List<int> liste2 = new List<int>();
DateTime başla, bitir;
TimeSpan fark;
long sayac = 99999999;
başla = DateTime.Now;
for (int i = 0; i < sayac; i++)
{
    liste1.Add(i);
    int sayi = (int)liste1[(i)];
}
bitir = DateTime.Now;
fark = bitir - başla;
Console.WriteLine($"ArrayList çalışma camanı {fark}");

başla = DateTime.Now;
for (int i = 0; i < sayac; i++)
{
    liste1.Add(i);

}
bitir = DateTime.Now;
fark = bitir - başla;
Console.WriteLine($"List çalışma camanı {fark}");

//list<> 4 veya 10 kat daha hızlıdır
// arraylist süreki değer dönüşümü yani unboxing ve boxing yaptığı için zaman kaybeder.
// generick list te tipi bildiği için boxing unboxing yapmaz
//??????? cast opertörü ??????
