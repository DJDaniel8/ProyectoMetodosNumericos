using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UIProyectoMN.Commands.InterseccionesCommands;

namespace UIProyectoMN.ViewModels.InterseccionesViewModels
{
    public class InterseccionesViewModel : ViewModelBase
    {
        public InterseccionesViewModel()
        {
            CalcularCommand = new CalcularCommand(this);                            
        }

        public ICommand CalcularCommand { get;}

        private Visibility _ControlVisiblity = Visibility.Collapsed;
        public Visibility ControlVisibility
        {
            get
            {
                return _ControlVisiblity;
            }
            set
            {
                _ControlVisiblity = value;
                OnPropertyChanged(nameof(ControlVisibility));
            }
        }

        private string _Funcion1;
        public string Funcion1
        {
            get
            {
                return _Funcion1;
            }
            set
            {
                _Funcion1 = value;
                OnPropertyChanged(nameof(Funcion1));
            }
        }

        private string _Funcion2;
        public string Funcion2
        {
            get
            {
                return _Funcion2;
            }
            set
            {
                _Funcion2 = value;
                OnPropertyChanged(nameof(Funcion2));
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
