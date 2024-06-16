using Tdoctor.Entities;

public class Doctor
    {
        public Doctor()
        {
        
        }

        public string Nombre { get; set; } 
        public int Edad { get; set; } 
        public string Sexo { get; set; } 
        public Guid Id { get; set; }  

        public Guid? EspecialidaddId { get; set; }
        public Especialidad Especialidad { get; set; }

        
       
    }
