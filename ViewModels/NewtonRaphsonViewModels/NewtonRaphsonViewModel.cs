using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UIProyectoMN.Commands.NewtonRaphsonCommands;

namespace UIProyectoMN.ViewModels.NewtonRaphsonViewModels
{
    public class NewtonRaphsonViewModel : ViewModelBase
    {
        public NewtonRaphsonViewModel()
        {
            Calcular = new CalcularCommand(this);
        }

        public ICommand Calcular { get; set; }

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

        private int _Iteraciones;
        public int Iteraciones
        {
            get
            {
                return _Iteraciones;
            }
            set
            {
                _Iteraciones = value;
                OnPropertyChanged(nameof(Iteraciones));
            }
        }

        private double _XInicial;
        public double XInicial
        {
            get
            {
                return _XInicial;
            }
            set
            {
                _XInicial = value;
                OnPropertyChanged(nameof(XInicial));
            }
        }

        private string _Respuesta;
        public string Respuesta
        {
            get
            {
                return _Respuesta;
            }
            set
            {
                _Respuesta = value;
                OnPropertyChanged(nameof(Respuesta));
            }
        }
    }
}
