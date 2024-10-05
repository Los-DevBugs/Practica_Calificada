<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAsignatura.aspx.cs" Inherits="CapaPresentacion.frmAsignatura"%>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Mantimiento de la tabla Asignatura</h3>
    <p>
        CodAsignatura : <asp:TextBox runat="server" ID="txtCodAsignatura" />
    </p>
    <p>
        Asignatura : <asp:TextBox runat="server" ID="txtNombreAsignatura" />
    </p>
    <p>
        CodRequisito : <asp:TextBox runat="server" ID="txtCodRequisito" />
    </p>
    <p>
        <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" />
        <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click" />
        <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click" />
    </p>
    <p>
        Buscar : <asp:TextBox runat="server" ID="txtBuscar" />
        <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" />
    </p>
    <p>
        <asp:GridView runat="server" ID="gvAsignatura"></asp:GridView>
    </p>
</asp:Content>
