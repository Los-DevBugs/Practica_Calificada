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
    public partial class frmAlumno : System.Web.UI.Page
    {
        private void Listar()
        {
            Alumno alumno = new Alumno();
            gvAlumno.DataSource = alumno.Listar();
            gvAlumno.DataBind();
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
            Alumno alumno = new Alumno();
            alumno.CodAlumno = txtCodAlumno.Text.Trim();
            alumno.APaterno = txtAPaterno.Text.Trim();
            alumno.AMaterno = txtAMaterno.Text.Trim();
            alumno.Nombres = txtNombres.Text.Trim();
            alumno.Usuario = txtUsuario.Text.Trim();
            alumno.CodCarrera = txtCodCarrera.Text.Trim();
            if (alumno.Agregar())
                Listar();
            else
            {
                Response.Write("Error: No se agregó correctamente");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.CodAlumno = txtCodAlumno.Text.Trim();
            alumno.APaterno = txtAPaterno.Text.Trim();
            alumno.AMaterno = txtAMaterno.Text.Trim();
            alumno.Nombres = txtNombres.Text.Trim();
            alumno.Usuario = txtUsuario.Text.Trim();
            alumno.CodCarrera = txtCodCarrera.Text.Trim();
            if (alumno.Eliminar())
                Listar();
            else
            {
                Response.Write("Error: No se eliminó correctamente");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.CodAlumno = txtCodAlumno.Text.Trim();
            alumno.APaterno = txtAPaterno.Text.Trim();
            alumno.AMaterno = txtAMaterno.Text.Trim();
            alumno.Nombres = txtNombres.Text.Trim();
            alumno.Usuario = txtUsuario.Text.Trim();
            alumno.CodCarrera = txtCodCarrera.Text.Trim();
            if (alumno.Actualizar())
                Listar();
            else
            {
                Response.Write("Error: No se actualizó correctamente");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim(); // Obtener el criterio de búsqueda

            DataTable resultado = new Alumno().Buscar(criterio);

            if (resultado.Rows.Count > 0)
            {
                gvAlumno.DataSource = resultado; // Asignar el DataTable al GridView
                gvAlumno.DataBind(); // Realizar el binding
            }
            else
            {
                Response.Write("No se encontraron resultados");
                gvAlumno.DataSource = null; // Limpiar el GridView si no hay resultados
                gvAlumno.DataBind(); // Realizar el binding para limpiar la vista
            }
        }
    }
}
