
namespace bancouh1.CapaDatos
{
    public class Cls_Tecnico
    {
        private int tecnicoID;
        private string nombre;
        private string especialidad;

        public int TecnicoID
        {
            get { return tecnicoID; }
            set { tecnicoID = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        public Cls_Tecnico()
        {
        }

        public Cls_Tecnico(int tecnicoID, string nombre, string especialidad)
        {
            this.tecnicoID = tecnicoID;
            this.nombre = nombre;
            this.especialidad = especialidad;
        }
    }
}
