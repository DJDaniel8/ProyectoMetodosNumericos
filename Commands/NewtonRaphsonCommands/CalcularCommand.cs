using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProyectoMN.ViewModels.NewtonRaphsonViewModels;

namespace UIProyectoMN.Commands.NewtonRaphsonCommands
{
    public class CalcularCommand : CommandBase
    {
        private NewtonRaphsonViewModel _ViewModel;
        public CalcularCommand(NewtonRaphsonViewModel viewModel)
        {
            _ViewModel = viewModel;
        }
        public override void Execute(object? parameter)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();
            matlab.Execute("cd C:\\MN\\Proyecto");

            object result = null;

            matlab.Feval("Newton", 1, out result, _ViewModel.Funcion, _ViewModel.Iteraciones, _ViewModel.XInicial);

            object[] res = result as object[];
            double[,] valores = res[0] as double[,];
            int i = 0;
            _ViewModel.Respuesta = string.Empty;
            foreach (var item in valores)
            {
                _ViewModel.Respuesta = _ViewModel.Respuesta + $"Iteracion #{i} = {item} \n";
                i++;
            }
        }
    }
}
