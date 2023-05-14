namespace ApiIntegration.DataModels
{
    public class Сompetition
    {
        public int Id { get; set; }
        public Area Area { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Plan { get; set; }
        public CurrentSeason CurrentSeason { get; set; }
    }
}
