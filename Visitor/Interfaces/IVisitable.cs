namespace Visitor.Interfaces
{
    interface IVisitable
    {
        void AcceptVisitor(IVisitor visitor);
    }
}
