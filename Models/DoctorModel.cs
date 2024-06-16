using Tdoctor.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Tdoctor
{
    public class DoctorModel
    {
        public DoctorModel()
        {
              //ListEspecialidad = new List<SelectListItem>();
        }
        
public string Nombre {get; set;} 
public int Edad {get; set;} 
public string Sexo {get; set;} 
public Guid Id {get; set;} 


public Guid? EspecialidadId { get; set; }

public EspecialidadModel? Especialidad { get; set; }

public string? NombreEspe { get; set; }

public List<SelectListItem> ListEspecialidad{ get; set; }


    }
}