using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProyectoMN.Models.GraficasModels
{
    public  class ColorList : List<Tuple<string, string>>
    {
        public ColorList()
        {
            this.Add(new Tuple<string, string>("Rojo", "r"));
            this.Add(new Tuple<string, string>("Verde", "g"));
            this.Add(new Tuple<string, string>("Azul", "b"));
            this.Add(new Tuple<string, string>("Celeste", "c"));
            this.Add(new Tuple<string, string>("Rosa", "m"));
            this.Add(new Tuple<string, string>("Amarillo", "y"));
            this.Add(new Tuple<string, string>("Negro", "k"));
            this.Add(new Tuple<string, string>("Blanco", "w"));
        }

        public Tuple<string, string> Get(int i)
        {
            return this.Get(i);
        }
    }
}
