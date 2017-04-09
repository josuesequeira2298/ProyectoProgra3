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
   Carnet:        
            <asp:TextBox ID="carnet" runat="server"></asp:TextBox>
        </p>
          Contraseña:  <asp:TextBox ID="contraseña" runat="server"></asp:TextBox>
   
        <br />
        <br />
 <asp:Button ID="iniciar" runat="server" Text="Iniciar sesión" OnClick="iniciar_Click"  />
         
        <asp:Button ID="registrarse" runat="server" Text="Registrarse"/>
    </form>
    <asp:Label ID="alerta" runat="server" Text="1"></asp:Label>
</body>
</html>