using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProyectoMN.Models.GraficasModels
{
    public class MarcadorList : List<Tuple<string, string>>
    {
        public MarcadorList()
        {
            Add(new Tuple<string, string>("Circulo", "o"));
            Add(new Tuple<string, string>("Mas", "+"));
            Add(new Tuple<string, string>("Asterisco", "*"));
            Add(new Tuple<string, string>("Punto", "."));
            Add(new Tuple<string, string>("Cruz", "x"));
            Add(new Tuple<string, string>("Cuadrado", "s"));
            Add(new Tuple<string, string>("Rombo", "d"));
            Add(new Tuple<string, string>("Pentagono", "p"));
            Add(new Tuple<string, string>("Hexagono", "h"));
        }

        public Tuple<string, string> Get(int i)
        {
            return this.Get(i);
        }
    }
}
