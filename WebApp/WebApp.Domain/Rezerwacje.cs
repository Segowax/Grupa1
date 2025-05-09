using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain
{
    public class Rezerwacje
    {
        public int Id { get; set; }
        public int Nr_stolika { get; set; }
        public int Data_rez { get; set; }
        public int Liczba_osob { get; set; }
        public string Telefon { get; set; }

    }
}
