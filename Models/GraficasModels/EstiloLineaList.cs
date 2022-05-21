using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProyectoMN.Models.GraficasModels
{
    public class EstiloLineaList : List<Tuple<string, string>>
    {
        public EstiloLineaList()
        {
            this.Add(new Tuple<string, string>("Linea Continua", "-"));
            this.Add(new Tuple<string, string>("Linea Discontinua", "--"));
            this.Add(new Tuple<string, string>("Linea Puntuada", ":"));
            this.Add(new Tuple<string, string>("Discontinua Puntuada", "-."));
        }

        public Tuple<string, string> Get(int i)
        {
            return this.Get(i);
        }
    }
}
