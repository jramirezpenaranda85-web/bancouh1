<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoTecnicos.aspx.cs" Inherits="bancouh1.Presentacion.CatalogoTecnicos_aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <h2>Catalogo de Tecnicos</h2>
    <p>Bienvenido al catalogo de tecnicos.</p>

    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>

    <br />

    <label>Tecnico ID:</label>
    <asp:TextBox ID="txtTecnicoID" runat="server"></asp:TextBox>
    <br />

    <label>Nombre:</label>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <br />

    <label>Especialidad:</label>
    <asp:TextBox ID="txtEspecialidad" runat="server"></asp:TextBox>
    <br /><br />

    
<asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
<asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />

</div>
    </form>
</body>
</html>
