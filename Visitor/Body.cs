namespace Visitor
{
    class Body : CarElement
    {
        public void accept(CarElementVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
