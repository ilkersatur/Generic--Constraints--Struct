using Interface_Inheritance_Constraints;
//3- İnterface
// Hizetli sınıfı ISilahtasiyabilir arayüzünü uygulamadığından çalışmaz
//PersonelYonetici<Hizmetli> py1 = new PersonelYonetici<Hizmetli>();
PersonelYonetici<Mudur> py2 = new PersonelYonetici<Mudur>();
PersonelYonetici<Güvenlik> py3 = new PersonelYonetici<Güvenlik>();

//4- inheritance

PersonelManeger<Personel> pm1 = new PersonelManeger<Personel>();
PersonelManeger<Mudur> pm2 = new PersonelManeger<Mudur>();
PersonelManeger<Hizmetli> pm3 = new PersonelManeger<Hizmetli>();

//Taşeron sınıfı personel sınıfından türetilmediğinden izin vermez
//PersonelManeger<Taseron> pm4= new PersonelManeger<Taseron>();