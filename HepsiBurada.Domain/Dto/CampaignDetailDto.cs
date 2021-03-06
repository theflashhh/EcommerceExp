namespace HepsiBurada.Domain.Dtos
{
    public class CampaignDetailDto : BaseClass
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public int TargetSales { get; set; }
        public int TotalSales { get; set; }
        public int Turnover { get; set; }
        public double AverageItemPrice { get; set; }
    }
}