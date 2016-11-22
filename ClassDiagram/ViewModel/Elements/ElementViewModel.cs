using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDiagram.Model;

namespace ClassDiagram.ViewModel.Elements
{
    public abstract class ElementViewModel: BaseViewModel, IElement
    {
        private readonly Element _element;

        protected ElementViewModel(Element element)
        {
            _element = element;
        }

        //protected Element Element { get; }
        //protected ElementViewModel(Element element)
        //{
        //    Element = element;
        //}

        public int Number => _element.Number;
        public double CenterX => Width / 2 + X;

        public double CenterY => Height / 2 + Y;

        public EElement Type
        {
            get { return _element.Type; }
            set {
                _element.Type = value;
            }
        }

        public double Width
        {
            get { return _element.Width; }
            set {
                _element.Width = value;
            }
        }
   
        public double Height
        {
            get { return _element.Height; }
            set
            {
                _element.Height = value;
            }
        }

        public double X
        {
            get { return _element.X; }
            set {
                _element.X = value;
            }
        }

        public double Y
        {
            get { return _element.Y; }
            set {
                _element.Y = value;
            }
        }
    }
}
