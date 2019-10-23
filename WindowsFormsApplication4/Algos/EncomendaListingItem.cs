namespace AMDManager
{
    public class EncomendaListingItem
    {
        public string Cod { get; set; }
        public string ClienteMorada { get; set; }
        public string HorarioDescarga { get; set; }
        public string Contacto { get; set; }
        public int PalSec { get; set; }
        public int PalFresc { get; set; }
        public int PalCong { get; set; }
        public int? RolliSec { get; set; }
        public int? RolliFresc { get; set; }
        public int? RolliCong { get; set; }
        public int? Peso { get; set; }
    }
}
