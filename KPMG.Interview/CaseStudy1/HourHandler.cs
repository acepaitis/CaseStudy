namespace KPMG.Interview.CaseStudy1
{
    public class HourHandler : IHourHandler
    {
        private readonly int hour;
        public HourHandler(int hour)
        {
            this.hour = hour;
        }
        public int GetHour()
        {
            return hour;
        }
    }
}
