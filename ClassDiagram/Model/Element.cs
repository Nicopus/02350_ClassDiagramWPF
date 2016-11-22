using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram.Model
{
    public class Element : IElement
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public EElement Type { get; set; }

        public double Width { get; set; }

        public double X { get; set; }

        public double Y { get; set; }
    }
}
