using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //Herhangi bir kredi türünün hesaplamasını yapabilir. 
            krediManager.Hesapla();

        }
    }
}
