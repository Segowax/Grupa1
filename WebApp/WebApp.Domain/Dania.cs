using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Domain;

public class Dania : Lokale
{
    public int Id { get; set; }
    public int Typ { get; set; }
    public string Nazwa { get; set; }
    public int Cena { get; set; }
}
