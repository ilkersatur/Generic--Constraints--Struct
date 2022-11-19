using System.Collections;

ArrayList liste1 = new ArrayList();
liste1.Add(1);
liste1.Add(5);
liste1.Add(12);

//liste1.Add("on");

int toplam = 0;
foreach (int sayi in liste1)
{
    toplam += sayi;
}
Console.WriteLine(toplam);

List<int> liste2 = new List<int>();
liste2.Add(1);
liste2.Add(3);
liste2.Add(2);
//liste2.Add("as"); generic yapıları kodu çalıştırmadan tip ile ilgili olan hataları dizayn time da yakalama fırsatı verir 
// Bundan dolayı generic yapıların kullanımı tip güvenliğini arttırır.