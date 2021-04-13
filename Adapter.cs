namespace DesignPatternsStudy
{
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return _adaptee.GetSpecificRequest();
        }
    }
}