namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            this.Step1();
            this.Step2();
            this.Step3();
        }

        protected virtual void Step1() { }
        abstract protected void Step2();
        protected virtual void Step3() { }
    }

    class ConcreteClass : AbstractClass
    {
        protected override void Step2() { }
    }
}
