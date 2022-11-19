using Constraints_Devam;

//Yonetici<int> yonetici = new Yonetici<int>(); class olduğu için kabul etmedi --- int=> struct

//Yonetici<string> yonetici = new Yonetici<string>(); string class fakat new yüzünden kabul etmedi

Yonetici<Personel> yonetici1 = new Yonetici<Personel>();
//new() = Default ctor var mı?
//Yonetici<Musteri>yonetici2=new Yonetici<Musteri>();
Yonetici<Kitap> yonetici3 = new Yonetici<Kitap>();