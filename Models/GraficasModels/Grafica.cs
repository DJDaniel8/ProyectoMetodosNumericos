using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProyectoMN.Models.GraficasModels
{
    public class Grafica
    {
        public Grafica()
        {
            Funcion = string.Empty;
            Linea = new("","");
            Marcador = new("", "");
            Color = new("", "");

        }

        public EstiloLineaList estilolinea { get; set; } = new();
        public MarcadorList marcadorlist { get; set; } = new();
        public ColorList colorList { get; set; } = new();

        public string Funcion { get; set; }
        public Tuple<string,string> Linea { get; 
            set; }
        public Tuple<string,string> Marcador { get; set; }
        public Tuple<string, string> Color { get; set; }

    }
}
