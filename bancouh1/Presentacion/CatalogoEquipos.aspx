<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoEquipos.aspx.cs" Inherits="bancouh1.Presentacion.CatalogoEquipos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
<div>
    <h2>Catalogo de Equipos</h2>
    <p>Bienvenido al catalogo de equipos.</p>

    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>

    <br />

    <label>Equipo ID:</label>
    <asp:TextBox ID="txtEquipoID" runat="server"></asp:TextBox>
    <br />

    <label>Tipo de Equipo:</label>
    <asp:TextBox ID="txtTipoEquipo" runat="server"></asp:TextBox>
    <br />

    <label>Modelo:</label>
    <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
    <br />

    <label>Usuario ID:</label>
    <asp:TextBox ID="txtUsuarioID" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Button ID="btnAgregar" runat="server"
        Text="Agregar" OnClick="btnAgregar_Click" />

    <asp:Button ID="btnActualizar" runat="server"
        Text="Actualizar" OnClick="btnActualizar_Click" />

    <asp:Button ID="btnEliminar" runat="server"
        Text="Eliminar" OnClick="btnEliminar_Click" />
</div>

    </form>
</body>
</html>
