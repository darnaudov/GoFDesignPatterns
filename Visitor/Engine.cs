namespace Visitor
{
    class Engine : CarElement
    {
        public void accept(CarElementVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
