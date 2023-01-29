namespace NZWalk.Api.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population
        {
            get; set;
        } 
        // Navigation Property tells entity framwork that ragion can have multiple walks 
        public IEnumerable<Walk> Walks { get; set; }
    }
}
