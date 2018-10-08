namespace KPMG.Interview.CaseStudy1
{
    public class BFactory : IBFactory
    {
        public IB Create(TimeOfTheDay timeOfTheDay)
        {
            if (timeOfTheDay == TimeOfTheDay.Morning)
            {
                return new B1();
            }
            else
            {
                return new B2();
            }
        }
    }
}
