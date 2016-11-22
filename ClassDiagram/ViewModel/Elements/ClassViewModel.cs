using ClassDiagram.Model;

namespace ClassDiagram.ViewModel.Elements
{
    public class ClassViewModel: ElementViewModel 
    {
        public ClassViewModel():this(new Element() { Type=EElement.Class}){ }
        public ClassViewModel(Element element) : base(element)
        {
        }
    }
}
