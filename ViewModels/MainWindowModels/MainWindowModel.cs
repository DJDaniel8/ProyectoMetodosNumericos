using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProyectoMN.ViewModels.FuncionesViewModels;
using UIProyectoMN.ViewModels.GaussViewModels;
using UIProyectoMN.ViewModels.InterseccionesViewModels;
using UIProyectoMN.ViewModels.MullerViewModels;
using UIProyectoMN.ViewModels.NewtonRaphsonViewModels;
using UIProyectoMN.ViewModels.NosotrosViewModels;

namespace UIProyectoMN.ViewModels.MainWindowModels
{
    public class MainWindowModel : ViewModelBase
    {


        public NosotrosViewModel NosotrosViewModel { get; set; } = new();
        public NewtonRaphsonViewModel NewtonViewModel { get; set; } = new();
        public FuncionesViewModel FuncionesViewModel  { get; set; } = new();
        public MullerViewModel MullerViewModel { get; set; } = new();
        public GaussViewModel GaussViewModel { get; set; } = new();
        public InterseccionesViewModel InterseccionesViewModel { get; set; } = new();

        private bool _IsNosotrosChecked = true;
        public bool IsNosotrosChecked
        {
            get
            {
                return _IsNosotrosChecked;
            }
            set
            {
                _IsNosotrosChecked = value;
                if (value == true) NosotrosViewModel.ControlVisibility = System.Windows.Visibility.Visible;
                else NosotrosViewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
                OnPropertyChanged(nameof(IsNosotrosChecked));
            }
        }

        private bool _IsNewtonChecked;
        public bool IsNewtonChecked
        {
            get
            {
                return _IsNewtonChecked;
            }
            set
            {
                _IsNewtonChecked = value;
                if(value == true) NewtonViewModel.ControlVisibility= System.Windows.Visibility.Visible;
                else NewtonViewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
                OnPropertyChanged(nameof(IsNewtonChecked));
            }
        }

        private bool _IsFuncionesChecked;
        public bool IsFuncionesChecked
        {
            get
            {
                return _IsFuncionesChecked;
            }
            set
            {
                _IsFuncionesChecked = value;
                if (value == true) FuncionesViewModel.ControlVisibility = System.Windows.Visibility.Visible;
                else FuncionesViewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
                OnPropertyChanged(nameof(IsFuncionesChecked));
            }
        }

        private bool _IsMullerChecked;
        public bool IsMullerChecked
        {
            get
            {
                return _IsMullerChecked;
            }
            set
            {
                _IsMullerChecked = value;
                if (value == true) MullerViewModel.ControlVisibility = System.Windows.Visibility.Visible;
                else MullerViewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
                OnPropertyChanged(nameof(IsMullerChecked));
            }
        }

        private bool _IsGaussChecked;
        public bool IsGaussChecked
        {
            get
            {
                return _IsGaussChecked;
            }
            set
            {
                _IsGaussChecked = value;
                if (value == true) GaussViewModel.ControlVisibility = System.Windows.Visibility.Visible;
                else GaussViewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
                OnPropertyChanged(nameof(IsGaussChecked));
            }
        }

        private bool _IsInterseccionesChecked;
        public bool IsInterseccionesChecked
        {
            get
            {
                return _IsInterseccionesChecked;
            }
            set
            {
                _IsInterseccionesChecked = value;
                if (value == true) InterseccionesViewModel.ControlVisibility = System.Windows.Visibility.Visible;
                else InterseccionesViewModel.ControlVisibility = System.Windows.Visibility.Collapsed;
                OnPropertyChanged(nameof(IsInterseccionesChecked));
            }
        }
    }
}
