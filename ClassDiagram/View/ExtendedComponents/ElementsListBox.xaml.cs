using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClassDiagram.View.ExtendedComponents
{
    /// <summary>
    /// Interaction logic for ElementsListBox.xaml
    /// </summary>
    public partial class ElementsListBox : ListBox
    {

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ElementItemContainer();
        }
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return (item is ElementItemContainer);
        }
        public ElementsListBox()
        {
            InitializeComponent();
        }

        private Queue<ElementItemContainer> _chain = new Queue<ElementItemContainer>();

    }
}
