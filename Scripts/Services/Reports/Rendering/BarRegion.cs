namespace Server.Engines.Reports
{
    public class BarRegion
    {
        public int m_RangeFrom, m_RangeTo;
        public string m_Name;
        public BarRegion(int rangeFrom, int rangeTo, string name)
        {
            this.m_RangeFrom = rangeFrom;
            this.m_RangeTo = rangeTo;
            this.m_Name = name;
        }
    }
}
