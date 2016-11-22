using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram.Model
{
    public interface IConnection
    {
        int FromNumber { get; }
        int ToNumber { get; }
        string Label { get; }
        string FromMultiplicity { get; }
        string ToMultiplicity { get; }
        EConnection Type { get; }
    }
}
