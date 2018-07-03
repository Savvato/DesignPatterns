namespace DesignPatterns.Structural.Proxy
{
    class Client
    {
        public void Work()
        {
            IService service = new Proxy();
            service.ServiceMethod();
        }
    }

    interface IService
    {
        void ServiceMethod();
    }

    class Service : IService
    {
        public void ServiceMethod()
        {
            // Some logic
        }
    }

    class Proxy : IService
    {
        private Service service;

        public Proxy()
        {
            this.service = new Service();
        }

        private void BeforeServiceMethod() { }
        private void AfterServiceMethod() { }

        public void ServiceMethod()
        {
            this.BeforeServiceMethod();
            this.service.ServiceMethod();
            this.AfterServiceMethod();
        }
    }

}
