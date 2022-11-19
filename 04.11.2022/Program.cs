//Generic
using _04._11._2022;
int[] sayilar = { 12, 44, 53, 76 };
string[] isimler = { "Ali", "Veli", "İlker" };
double[] fiyatlar = { 63.24, 39.5, 34.5 };

void YazSayi(int[] dizi)
{
    foreach (int sayi in dizi)
    {
        Console.Write(sayi + " ");
    }
}
void YazIsim(string[] dizi)
{
    foreach (string isim in dizi)
    {
        Console.Write(isim + " ");
    }
}
void YazFiyat(double[] dizi)
{
    foreach (double fiyat in dizi)
    {
        Console.Write(fiyat + " ");
    }
}

YazSayi(sayilar);
YazFiyat(fiyatlar);
YazIsim(isimler);

Console.WriteLine();

void Yaz2<T>(T[] dizi)  // tek metodla 3 metodun yaptığı işi yaptık , tipte değişken gibi değişir
{
    foreach (T t in dizi)
    {
        Console.WriteLine(t);
    }
    Console.WriteLine();
}

Yaz2<int>(sayilar);
// böylede yazılabilir Yaz2<int>(sayilar);
Yaz2<string>(isimler);
Yaz2<double>(fiyatlar);
//design time kod yazım anı, run time uygulama çalıştığı an

Depo<string> depo = new Depo<string>();
Depo<Televizyon> depo2 = new Depo<Televizyon>();
Depo<Buzdolabı> depo3 = new Depo<Buzdolabı>();

depo.Ekle(/*buraya string bekliyor*/"s");
depo2.Ekle(/*Televizyon bekliyor*/new Televizyon());
depo3.Ekle(/*Buzdolabı bekliyor*/ new Buzdolabı());