namespace DesafioProjetoHospedagem.Models
{
    public class Suite(string suiteType, int capacity, int dailyRate)
    {
        public string SuiteType { get; set; } = suiteType;

        public int Capacity { get; set; } = capacity;
        public int DailyRate { get; set; } = dailyRate;
    }
}


