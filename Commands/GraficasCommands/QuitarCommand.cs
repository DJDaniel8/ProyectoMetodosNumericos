using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProyectoMN.ViewModels.FuncionesViewModels;

namespace UIProyectoMN.Commands.GraficasCommands
{
    public class QuitarCommand : CommandBase
    {
        private FuncionesViewModel _viewModel;
        public QuitarCommand(FuncionesViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(FuncionesViewModel.SelectedGrafica))
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return (_viewModel.SelectedGrafica != null) &&
                    base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            _viewModel.Quitar(_viewModel.SelectedGrafica);
        }
    }
}
