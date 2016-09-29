namespace Visitor
{
    class Wheel : CarElement
    {
        public void accept(CarElementVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
