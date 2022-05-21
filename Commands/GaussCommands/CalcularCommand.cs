using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProyectoMN.Models.GaussModels;
using UIProyectoMN.ViewModels.GaussViewModels;

namespace UIProyectoMN.Commands.GaussCommands
{
    public class CalcularCommand : CommandBase
    {
        private GaussViewModel _viewModel;
        public CalcularCommand(GaussViewModel viewModel)
        {
            _viewModel = viewModel;
        }


    
        public override void Execute(object? parameter)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();
            matlab.Execute("cd C:\\MN\\Proyecto");

            object result = null;

            double[,] a = new double[,] { { _viewModel.X11 , _viewModel.X12 , _viewModel.X13 },
                                            { _viewModel.X21, _viewModel.X22, _viewModel.X23 },
                                            { _viewModel.X31 , _viewModel.X32 , _viewModel.X33} };
            double[] b = new double[] { _viewModel.R1, _viewModel.R2, _viewModel.R3 };
            
            matlab.Feval("Gauss", 1, out result, b,a, _viewModel.Error);

            object[] res = result as object[];
            double[,] respuesta = res[0] as double[,];
            int filas = respuesta.Length / 6;
            List<Iteracion> lista = new();
            for (int i = 0; i < filas; i++)
            {
                Iteracion ite = new();
                ite.X1 = respuesta[i, 0];
                ite.X2 = respuesta[i, 1];
                ite.X3 = respuesta[i, 2];
                ite.E1 = respuesta[i, 3];
                ite.E2 = respuesta[i, 4];
                ite.E3 = respuesta[i, 5];
                lista.Add(ite);
            }

            _viewModel.AgregarAIteraciones(lista);
        }
    }
}
