namespace NutrinfoWeb.Models
{
    public class Berria
    {
        public int Id { get; set; }
        public string Titularra { get; set; }    
        public string Deskripzioa { get; set; }
        public bool Nabarmena { get; set; }
        public string? Autorea { get; set; }
        public DateTime Data { get; set; }
    }
}
