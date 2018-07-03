namespace DesignPatterns.CreationalPatterns.Singleton
{
    class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (Singleton.instance == null)
                Singleton.instance = new Singleton();

            return Singleton.instance;
        }
    }
}
