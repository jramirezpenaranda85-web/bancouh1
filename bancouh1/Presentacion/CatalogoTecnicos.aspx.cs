
using System;
using System.Web.UI;
using bancouh1.Capa_Logica;

namespace bancouh1.Presentacion
{
    public partial class CatalogoTecnicos_aspx : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MostrarTecnicos();
            }
        }

        private void MostrarTecnicos()
        {
            GridView1.DataSource = Tecnicos_CL.MostrarTecnicos();
            GridView1.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtTecnicoID.Text);
            string nombre = txtNombre.Text;
            string especialidad = txtEspecialidad.Text;

            Tecnicos_CL.AgregarTecnico(id, nombre, especialidad);
            MostrarTecnicos();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtTecnicoID.Text);
            string nombre = txtNombre.Text;
            string especialidad = txtEspecialidad.Text;

            Tecnicos_CL.ActualizarTecnico(id, nombre, especialidad);
            MostrarTecnicos();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtTecnicoID.Text);

            Tecnicos_CL.EliminarTecnico(id);
            MostrarTecnicos();
        }
    }
}
