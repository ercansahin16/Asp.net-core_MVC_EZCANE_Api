namespace NöbetciEczane_Mvc_API.Models
{
    public class IzmirModel
    {
        public DateTime Tarih { get; set; }
        public string? LokasyonY { get; set; }
        public string? LokasyonX { get; set; }
        public string? BolgeAciklama { get; set; }
        public string? Adi { get; set; }
        public string? Telefon { get; set; }
        public string? Adres { get; set; }
        public int BolgeId { get; set; }
        public string? Bolge { get; set; }
        public int? UzaklikMetre { get; set; }
        public int EczaneId { get; set; }
        public int IlceId { get; set; }
    }
}
