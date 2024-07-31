using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IRepositorioProyectos
    {
        List<Proyect> GetProyects();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyect> GetProyects()
        {
            return new List<Proyect>()
            {
                new Proyect
                {
                    Title = "Modulo del terapeuta",
                    Description = "Modelo de servidor realizado en Flask",
                    Link = "Yeltic.com",
                    ImageUrl = "/images/servidor.png"
                },
                new Proyect
                {
                    Title = "Yeltic LeARn",
                    Description = "Desarrollo del backend de la App sobre Firebase",
                    Link = "Yeltic.com",
                    ImageUrl = "/images/yeltic.png"
                },
                new Proyect
                {
                    Title = "Casilleros de carga Stereo Picnic",
                    Description = "Desarrollo del backend local y sistema de comunicación con Arduino",
                    Link = "Yeltic.com",
                    ImageUrl = "/images/stereopicnic.png"
                },
                new Proyect
                {
                    Title = "Plugin Descarga Nativa",
                    Description = "Creacion de un puglin nativo de android sobre Java para la descarga nativa de archivos en Unity",
                    Link = "Yeltic.com",
                    ImageUrl = "/images/android.png"
                }
            };
        }
    }
}
