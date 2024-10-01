using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class frmCarrera : System.Web.UI.Page
    {
        private void Listar()
        {
            Carrera carrera = new Carrera();
            gvCarrera.DataSource = carrera.Listar();
            gvCarrera.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Para que no consuma recursos hacemos que solo cargue 1 vez
            // Solo cargar la lista la primera vez
            if (!Page.IsPostBack)
                Listar();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Carrera carrera = new Carrera();
            carrera.CodCarrera = txtCodCarrera.Text.Trim();
            carrera.NombreCarrera = txtCarrera.Text.Trim();
            if (carrera.Agregar())
                Listar();
            else
            {
                Response.Write("Error: No se agregó correctamente");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Carrera carrera = new Carrera();
            carrera.CodCarrera = txtCodCarrera.Text.Trim();
            carrera.NombreCarrera = txtCarrera.Text.Trim();
            if (carrera.Eliminar())
                Listar();
            else
            {
                Response.Write("Error: No se eliminó correctamente");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Carrera carrera = new Carrera();
            carrera.CodCarrera = txtCodCarrera.Text.Trim();
            carrera.NombreCarrera = txtCarrera.Text.Trim();
            if (carrera.Actualizar())
                Listar();
            else
            {
                Response.Write("Error: No se actualizó correctamente");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim(); // Obtener el criterio de búsqueda

            DataTable resultado = new Carrera().Buscar(criterio);

            if (resultado.Rows.Count > 0)
            {
                gvCarrera.DataSource = resultado; // Asignar el DataTable al GridView
                gvCarrera.DataBind(); // Realizar el binding
            }
            else
            {
                Response.Write("No se encontraron resultados");
                gvCarrera.DataSource = null; // Limpiar el GridView si no hay resultados
                gvCarrera.DataBind(); // Realizar el binding para limpiar la vista
            }
        }
    }
}
