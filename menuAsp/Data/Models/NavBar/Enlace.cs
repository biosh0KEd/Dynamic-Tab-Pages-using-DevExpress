namespace menuAsp.Data.Models.NavBar
{
    public class Enlace
    {
        public int Id { get; set; }
        public int Categoria { get; set; }
        public string Nombre { get; set; }
        public string Componente { get; set; }
        public string? Model { get; set; }
        public bool Expanded { get; set; }
    }
}
