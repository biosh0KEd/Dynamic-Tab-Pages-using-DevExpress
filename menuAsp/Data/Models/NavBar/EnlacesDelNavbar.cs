using menuAsp.Pages;

namespace menuAsp.Data.Models.NavBar
{
    public static class EnlacesDelNavbar
    {
        public static readonly IEnumerable<Enlace> Enlaces = new[] {            
            new Enlace
            {
                Id = 3,                
                Nombre = "Menu",
                Componente = "Menu/MenuMain",
                Model = "Menu.MenuMainModel",
                Expanded = false
            },
            new Enlace
            {
                Id = 4,                
                Nombre = "Formulario",
                Componente = "Formularios/FormulariosMain",
                Model = "Formularios.FormulariosMainModel",
                Expanded = false
            },
            new Enlace
            {
                Id = 5,
                Nombre = "Funciones",
                Componente = "Funciones/FuncionesMain",
                Model = "Funciones.FuncionesMainModel",
                Expanded = false
            }            
        };

 
    }
}
