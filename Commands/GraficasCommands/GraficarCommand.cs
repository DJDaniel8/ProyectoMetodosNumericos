using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProyectoMN.ViewModels.FuncionesViewModels;

namespace UIProyectoMN.Commands.GraficasCommands
{
    public class GraficarCommand : CommandBase
    {
        private FuncionesViewModel _viewModel;
        public GraficarCommand(FuncionesViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(FuncionesViewModel.Graficas))
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return (_viewModel.Graficas.Count() > 0) &&
                    base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();
            matlab.Execute("cd C:\\MN\\Proyecto");

            object result = null;
            int filas = _viewModel.Graficas.Count();
            string[,] matriz = new string[filas,4];

            for (int j = 0; j < filas; j++)
            {
                matriz[j, 0] = _viewModel.Graficas.ToArray()[j].Funcion;
                matriz[j, 1] = _viewModel.Graficas.ToArray()[j].Linea.Item2;
                matriz[j, 2] = _viewModel.Graficas.ToArray()[j].Marcador.Item2;
                matriz[j, 3] = _viewModel.Graficas.ToArray()[j].Color.Item2;
            }
            matlab.Feval("Graficas", 1, out result, matriz);

            object[] res = result as object[];
            
        }
    }
}
