namespace Visitor
{
    interface CarElement
    {
        void accept(CarElementVisitor visitor);
    }
}
