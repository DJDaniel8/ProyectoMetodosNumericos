using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UIProyectoMN.Commands.GraficasCommands;
using UIProyectoMN.Models.GraficasModels;

namespace UIProyectoMN.ViewModels.FuncionesViewModels
{
    public class FuncionesViewModel : ViewModelBase
    {

        public FuncionesViewModel()
        {
            _EstiloLinea = new( new Tuple<string,string>[] { new Tuple<string, string>("Linea Continua","-")} );
            _Graficas = new();
            AgregarCommand = new AgregarGraficaCommand(this);
            QuitarCommand = new QuitarCommand(this);
            GraficarCommand = new GraficarCommand(this);

            _Graficas.CollectionChanged += _Graficas_CollectionChanged;
        }

        private void _Graficas_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Graficas));
        }

        public ICommand AgregarCommand { get;}
        public ICommand QuitarCommand { get; }
        public ICommand GraficarCommand { get; }

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

        public ObservableCollection<Grafica> _Graficas;
        public IEnumerable<Grafica> Graficas => _Graficas;

        public ObservableCollection<Tuple<string, string>> _EstiloLinea;
        public IEnumerable<Tuple<string, string>> EstiloLinea => _EstiloLinea;

        private Grafica _SelectedGrafica;
        public Grafica SelectedGrafica
        {
            get
            {
                return _SelectedGrafica;
            }
            set
            {
                _SelectedGrafica = value;
                OnPropertyChanged(nameof(SelectedGrafica));
            }
        }

        public void Agregar()
        {
            _Graficas.Add(new());
        }

        public void Quitar(Grafica g)
        {
            _Graficas.Remove(g);
        }
    }
}
