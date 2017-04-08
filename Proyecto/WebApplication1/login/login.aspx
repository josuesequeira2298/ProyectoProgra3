<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
&nbsp;&nbsp; Carnet:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="carnet" runat="server"></asp:TextBox>
        </p>
        &nbsp; Contraseña:&nbsp; <asp:TextBox ID="contraseña" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;<asp:Button ID="iniciar" runat="server" OnClick="iniciar_click" Text="Iniciar sesión" />
        &nbsp;

        <asp:Button ID="registrarse" runat="server" Text="Registrarse" OnClick="registrarse_click" />
    </form>
</body>
</html>
