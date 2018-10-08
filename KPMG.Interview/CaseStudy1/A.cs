namespace KPMG.Interview.CaseStudy1
{
    class A
    {
        private readonly IBFactory bFactory;
        private readonly IHourHandler hourHandler;

        public A(IBFactory bFactory, IHourHandler hourHandler)
        {
            this.bFactory = bFactory;
            this.hourHandler = hourHandler;
        }

        public void DoWork()
        {
            IB b;

            if (hourHandler.GetHour() < 12)
            {
                b = bFactory.Create(TimeOfTheDay.Morning);
            }
            else
            {
                b = bFactory.Create(TimeOfTheDay.Evening);
            }

            b.Run();
        }
    }
}
