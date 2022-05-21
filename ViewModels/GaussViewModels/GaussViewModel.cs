using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UIProyectoMN.Commands.GaussCommands;
using UIProyectoMN.Models.GaussModels;

namespace UIProyectoMN.ViewModels.GaussViewModels
{
    public class GaussViewModel : ViewModelBase
    {
        public GaussViewModel()
        {
            _Iteraciones = new();
            CalcularCommand = new CalcularCommand(this);
        }

        public ObservableCollection<Iteracion> _Iteraciones;
        public IEnumerable<Iteracion> Iteracions => _Iteraciones;

        public ICommand CalcularCommand { get; set; }

        public double X11 { get; set; }
        public double X12 { get; set; }
        public double X13 { get; set; }
        public double X21 { get; set; }
        public double X22 { get; set; }
        public double X23 { get; set; }
        public double X31 { get; set; }
        public double X32 { get; set; }
        public double X33 { get; set; }
        public double R1 { get; set; }
        public double R2 { get; set; }
        public double R3 { get; set; }
        public double Error { get; set; }

        private Visibility _ControlVisibility = Visibility.Collapsed;
        public Visibility ControlVisibility
        {
            get
            {
                return _ControlVisibility;
            }
            set
            {
                _ControlVisibility = value;
                OnPropertyChanged(nameof(ControlVisibility));
            }
        }

        public void AgregarAIteraciones(List<Iteracion> lista)
        {
            _Iteraciones.Clear();
            foreach (var item in lista)
            {
                _Iteraciones.Add(item);
            }
        }
    }
}
