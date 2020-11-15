using Prototype.Classes;

namespace Prototype.Interfaces
{
    interface ICloneableRectangle
    {
        Size Size { get; set; }
        ICloneableRectangle Clone();
    }
}
