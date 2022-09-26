namespace DotNetDockerPostgres.Data
{
    public class Unit
    {
        public int Id { get; set; }
        public string MetricUnit { get; set; }
        public string MetricValue { get; set; }
    }

    public class UnitCreateDto
    {
        public string MetricUnit { get; set; }
        public string MetricValue { get; set; }
    }
}
