using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDiagram.Model;
using ClassDiagram.ViewModel.Elements;

namespace ClassDiagram.ViewModel.Connections
{
    public class AssociationViewModel: ConnectionViewModel
    {
        public AssociationViewModel():this(new Connection() { Type=EConnection.Association}){ }
        public AssociationViewModel(Connection connection) : base(connection)
        {
        }
        public AssociationViewModel(ElementViewModel from, ElementViewModel to) : base(new Connection() { Type = EConnection.Association }, from, to)
        {
        }

    }
}
