<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmDocente.aspx.cs" Inherits="CapaPresentacion.frmDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Mantimiento de la tabla Docente</h3>
    <p>
        CodDocente : <asp:TextBox runat="server" ID="txtCodDocente" />
    </p>
    <p>
        Docente : <asp:TextBox runat="server" ID="txtDocente" />
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
        <asp:GridView runat="server" ID="gvDocente"></asp:GridView>
    </p>
</asp:Content>
