<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCarrera.aspx.cs" Inherits="CapaPresentacion.frmCarrera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Mantimiento de la tabla carrera</h3>
    <p>
        CodCarrera : <asp:TextBox runat="server" ID="txtCodCarrera" />
    </p>
    <p>
        Carrera : <asp:TextBox runat="server" ID="txtCarrera" />
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
        <asp:GridView runat="server" ID="gvCarrera"></asp:GridView>
    </p>
</asp:Content>
