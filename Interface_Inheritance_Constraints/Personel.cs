using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Inheritance_Constraints
{
    internal class Personel
    {

    }
    internal class Mudur : Personel, ISilahTasinabilir
    {

    }

    internal class Güvenlik : Personel, ISilahTasinabilir
    {

    }
    internal class Hizmetli : Personel
    {

    }
    internal interface ISilahTasinabilir
    {
    }
    internal class Taseron
    {

    }
}