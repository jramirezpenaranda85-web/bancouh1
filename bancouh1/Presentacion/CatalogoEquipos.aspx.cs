
using System;
using System.Web.UI;
using bancouh1.Capa_Logica;

namespace bancouh1.Presentacion
{
    public partial class CatalogoEquipos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MostrarEquipos();
            }
        }

        private void MostrarEquipos()
        {
            GridView1.DataSource = Equipos_CL.MostrarEquipos();
            GridView1.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtEquipoID.Text);
            string tipo = txtTipoEquipo.Text;
            string modelo = txtModelo.Text;
            int usuario = int.Parse(txtUsuarioID.Text);

            Equipos_CL.AgregarEquipo(id, tipo, modelo, usuario);
            MostrarEquipos();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtEquipoID.Text);
            string tipo = txtTipoEquipo.Text;
            string modelo = txtModelo.Text;
            int usuario = int.Parse(txtUsuarioID.Text);

            Equipos_CL.ActualizarEquipo(id, tipo, modelo, usuario);
            MostrarEquipos();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtEquipoID.Text);

            Equipos_CL.EliminarEquipo(id);
            MostrarEquipos();
        }
    }
}
