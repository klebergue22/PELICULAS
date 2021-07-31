using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace peliculasAPI.Utilidades
{
    public interface IAlmacenadorArchivos
    {
        Task BorrarAchivo(string ruta, string contenedor);

        Task<string> EditarArchivo(string contenedor, IFormFile archivo, string ruta);

        Task<string> GuardarArchivo(string contenedor, IFormFile archivo);
    }
}