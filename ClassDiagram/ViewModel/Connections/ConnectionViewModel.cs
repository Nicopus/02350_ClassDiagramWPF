using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDiagram.Model;
using ClassDiagram.ViewModel.Elements;

namespace ClassDiagram.ViewModel.Connections
{
    public abstract class ConnectionViewModel : BaseViewModel, IConnection
    {
        private readonly Connection _connection;
        private ElementViewModel _to;
        private ElementViewModel _from;

        public int ToNumber => _to.Number;
        public int FromNumber => _from.Number;
        protected ConnectionViewModel(Connection connection)
        {
            _connection = connection;
        }

        public ConnectionViewModel(Connection connection, ElementViewModel from, ElementViewModel to) : this(connection)
        {
            this.From = from;
            this.To = to;
        }

        public string FromMultiplicity
        {
            get { return _connection.FromMultiplicity; }
            set {
                _connection.FromMultiplicity = value;
            }
        }
  
        public string Label
        {
            get { return _connection.Label; }
            set {
                _connection.Label = value;
            }
        }

        public string ToMultiplicity
        {
            get { return _connection.ToMultiplicity; }
            set {
                _connection.ToMultiplicity = value;
            }
        }

        public EConnection Type
        {
            get { return _connection.Type; }
            set {
                _connection.Type = value;
            }
        }

        public ElementViewModel To
        {
            get { return _to; }
            set
            {
                _to = value;
                _connection.ToNumber = value.Number;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ToNumber));
            }
        }

        public ElementViewModel From
        {
            get { return _from; }
            set
            {
                _from = value;
                _connection.FromNumber = value.Number;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FromNumber));
            }
        }
    }
}
