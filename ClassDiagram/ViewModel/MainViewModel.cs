using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ClassDiagram.ViewModel.Elements;
using ClassDiagram.ViewModel.Connections;

namespace ClassDiagram.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<ElementViewModel> Elements { get; }
        public ObservableCollection<ConnectionViewModel> Connections { get; }

        public MainViewModel() : base()
        {
            Elements = new ObservableCollection<ElementViewModel>() {
                new ClassViewModel() { X = 30, Y = 40, Width = 80, Height = 80 },
                new ClassViewModel() { X = 200, Y = 40, Width = 80, Height = 80 }
            
            };
            Connections = new ObservableCollection<ConnectionViewModel>()
            {
                new AssociationViewModel(Elements[0], Elements[1]) {}
            };
        }
    }
}
