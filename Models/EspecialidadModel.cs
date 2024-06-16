using Microsoft.AspNetCore.Mvc.Rendering;

namespace Tdoctor.Models
{
    public class EspecialidadModel
    {
        public EspecialidadModel()
        {

        }

        public Guid Id { get; set; }
public int Operacion { get; set; }
 public string NombreEspe { get; set; }
public int TiempoOpera { get; set; }


    }

}