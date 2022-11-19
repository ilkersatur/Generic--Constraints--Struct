using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Inheritance_Constraints
{
    internal class PersonelYonetici<T> where T : ISilahTasinabilir
    {
    }
    internal class PersonelManeger<T> where T : Personel
    {

    }
}