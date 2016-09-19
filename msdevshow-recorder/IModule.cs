using System;
using System.Linq;
using System.Windows.Controls;

namespace msdevshow_recorder
{
    public interface IModule
    {
        string Name { get; }
        UserControl UserInterface { get; }
        void Deactivate();
    }
}
