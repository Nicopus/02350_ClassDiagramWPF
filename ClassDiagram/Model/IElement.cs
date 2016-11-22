using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram.Model
{
    public interface IElement
    {
        int Number { get; }
        EElement Type { get; }
        double Width { get; }
        double Height { get; }
        double X { get; }
        double Y { get; }
    }
}
