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
    public partial class frmDocente : System.Web.UI.Page
    {
        private void Listar()
        {
            Docente docente = new Docente();
            gvDocente.DataSource = docente.Listar();
            gvDocente.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            docente.CodDocente = txtCodDocente.Text.Trim();
            docente.APaterno = txtAPaterno.Text.Trim();
            docente.AMaterno = txtAMaterno.Text.Trim();
            docente.NombresDocen = txtNombresDocen.Text.Trim();
            docente.Usuario = txtUsuario.Text.Trim();
            if (docente.Agregar())
                Listar();
            else
            {
                Response.Write("Error: No se agregó correctamente");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            docente.CodDocente = txtCodDocente.Text.Trim();
            docente.APaterno = txtAPaterno.Text.Trim();
            docente.AMaterno = txtAMaterno.Text.Trim();
            docente.NombresDocen = txtNombresDocen.Text.Trim();
            docente.Usuario = txtUsuario.Text.Trim();
            if (docente.Eliminar())
                Listar();
            else
            {
                Response.Write("Error: No se eliminó correctamente");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            docente.CodDocente = txtCodDocente.Text.Trim();
            docente.APaterno = txtAPaterno.Text.Trim();
            docente.AMaterno = txtAMaterno.Text.Trim();
            docente.NombresDocen = txtNombresDocen.Text.Trim();
            docente.Usuario = txtUsuario.Text.Trim();
            if (docente.Actualizar())
                Listar();
            else
            {
                Response.Write("Error: No se actualizó correctamente");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim(); // Obtener el criterio de búsqueda

            DataTable resultado = new Docente().Buscar(criterio);

            if (resultado.Rows.Count > 0)
            {
                gvDocente.DataSource = resultado; // Asignar el DataTable al GridView
                gvDocente.DataBind(); // Realizar el binding
            }
            else
            {
                Response.Write("No se encontraron resultados");
                gvDocente.DataSource = null; // Limpiar el GridView si no hay resultados
                gvDocente.DataBind(); // Realizar el binding para limpiar la vista
            }
        }
    }
}