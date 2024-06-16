namespace Tdoctor.Entities
{
    public class Especialidad
    {
        public Especialidad()
        {

        }

        public Guid Id { get; set; }
        public int Operacion { get; set; }
        public string NombreEspe { get; set; }
        public int TiempoOpera { get; set; }

        public List<Doctor> Doctors { get; set; }




    }
}