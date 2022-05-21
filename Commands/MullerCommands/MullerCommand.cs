using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProyectoMN.Models.MullerModels;
using UIProyectoMN.ViewModels.MullerViewModels;

namespace UIProyectoMN.Commands.MullerCommands
{
    public class MullerCommand : CommandBase
    {
        private MullerViewModel _viewModel;
        public MullerCommand(MullerViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();
            matlab.Execute("cd C:\\MN\\Proyecto");

            object result = null;

            matlab.Feval("Muller", 1, out result, _viewModel.Funcion, _viewModel.X0, _viewModel.X1, _viewModel.X2, _viewModel.Error);

            object[] res = result as object[];
            double[,] resultado = res[0] as double[,];
            int filas = resultado.Length / 5;
            List<Iteracion> lista = new();
            for (int i = 0; i < filas; i++)
            {
                Iteracion ite = new();
                ite.X0 = resultado[i,0];
                ite.X1 = resultado[i, 1];
                ite.X2 = resultado[i, 2];
                ite.X3 = resultado[i, 3];
                ite.Error = resultado[i, 4];
                lista.Add(ite);
            }
            _viewModel.llenarIteraciones(lista);
        }
    }
}
