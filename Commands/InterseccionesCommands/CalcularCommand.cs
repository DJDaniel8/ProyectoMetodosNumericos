using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProyectoMN.ViewModels.InterseccionesViewModels;

namespace UIProyectoMN.Commands.InterseccionesCommands
{
    public class CalcularCommand : CommandBase
    {
        private InterseccionesViewModel _viewModel;
        public CalcularCommand(InterseccionesViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public override void Execute(object? parameter)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();
            matlab.Execute("cd C:\\MN\\Proyecto");

            object result = null;

            
            matlab.Feval("Intersecciones", 1, out result, _viewModel.Funcion1, _viewModel.Funcion2);

            object[] res = result as object[];
            double[,] Puntos = res[0] as double[,];
            List<string> lista = new();
            int columans = Puntos.Length / 2;
            for (int i = 0; i < columans; i++)
            {
                string pun = "";
                bool agregar = true;
                pun = "Punto Allado en ( "+ Puntos[0, i].ToString("f4").Replace(',', '.') + " , ";
                pun = pun + Puntos[1, i].ToString("f4").Replace(',', '.') + " ) \n";
                foreach (var item in lista)
                {
                    if (pun == item) agregar = false;
                }
                if(agregar)lista.Add(pun);
                
            }
            _viewModel.Respuesta = "";
            foreach (var item in lista)
            {
                _viewModel.Respuesta += item;
            }
        }
    }
}
