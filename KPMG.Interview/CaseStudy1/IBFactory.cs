namespace KPMG.Interview.CaseStudy1
{
    public interface IBFactory
    {
        IB Create(TimeOfTheDay timeOfTheDay);
    }
}