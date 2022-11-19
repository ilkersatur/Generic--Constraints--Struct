/* Generic Constraints (Jenerik Kısıtlar) 
 
1-Class
2-Struct
3-İnterface
4-İnheritance
5-new()

✪✪✪ Bir yapıya birden fazla kısıt uygulanabilir, fakat new() kısıtı mutlaka en son kısıt olmalı
 
 
 */
using Generic_Constraints;

Islem<int> islem = new Islem<int>();
//Islem<string> islem2 = new Islem<string>(); //eğer class önüne where T : struct yazarsak sadece değer tipli ifade kabul eder, string referans tiplidir

Depo<string> depo1 = new Depo<string>();
Depo<object> depo2 = new Depo<object>();
//Depo<int> depo3 = new Depo<int>(); class harici kullanımlara izin vermez