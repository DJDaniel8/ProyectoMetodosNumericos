using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using UIProyectoMN.Commands.MullerCommands;
using UIProyectoMN.Models.MullerModels;
using System.Collections.ObjectModel;

namespace UIProyectoMN.ViewModels.MullerViewModels
{
    public class MullerViewModel : ViewModelBase
    {
        public MullerViewModel()
        {
            _Iteraciones = new();
            CalcularCommand = new MullerCommand(this);
        }

        public ObservableCollection<Iteracion> _Iteraciones;
        public IEnumerable<Iteracion> Iteracions => _Iteraciones;

        public ICommand CalcularCommand { get;}

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

        private string _Funcion;
        public string Funcion
        {
            get
            {
                return _Funcion;
            }
            set
            {
                _Funcion = value;
                OnPropertyChanged(nameof(Funcion));
            }
        }

        private double _X0;
        public double X0
        {
            get
            {
                return _X0;
            }
            set
            {
                _X0 = value;
                OnPropertyChanged(nameof(X0));
            }
        }

        private double _X1;
        public double X1
        {
            get
            {
                return _X1;
            }
            set
            {
                _X1 = value;
                OnPropertyChanged(nameof(X1));
            }
        }

        private double _X2;
        public double X2
        {
            get
            {
                return _X2;
            }
            set
            {
                _X2 = value;
                OnPropertyChanged(nameof(X2));
            }
        }

        private double _Error;
        public double Error
        {
            get
            {
                return _Error;
            }
            set
            {
                _Error = value;
                OnPropertyChanged(nameof(Error));
            }
        }

        public void llenarIteraciones(List<Iteracion> lista)
        {
            _Iteraciones.Clear();
            foreach (Iteracion iteracion in lista)
            {
                _Iteraciones.Add(iteracion);
            }
        }
    }
}
