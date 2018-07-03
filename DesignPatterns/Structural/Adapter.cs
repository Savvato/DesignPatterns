namespace DesignPatterns.Structural.Adapter
{
    class Client
    {
        public void Work()
        {
            ClientInterface service = new Adapter(new ExternalService());
            service.SomeMethod(22);
        }
    }

    interface ClientInterface
    {
        void SomeMethod(int i);
    }

    class Adapter : ClientInterface
    {
        private ExternalService externalService;

        public Adapter(ExternalService externalService)
        {
            this.externalService = externalService;
        }

        public void SomeMethod(int i)
        {
            this.externalService.ServiceMethod(i);
        }
    }

    class ExternalService
    {
        public void ServiceMethod(double i) { }
    }
}
