using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProyectoMN.ViewModels.FuncionesViewModels;

namespace UIProyectoMN.Commands.GraficasCommands
{
    internal class AgregarGraficaCommand : CommandBase
    {
        private FuncionesViewModel _viewModel;
        public AgregarGraficaCommand(FuncionesViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public override void Execute(object? parameter)
        {
            _viewModel.Agregar();
        }
    }
}
