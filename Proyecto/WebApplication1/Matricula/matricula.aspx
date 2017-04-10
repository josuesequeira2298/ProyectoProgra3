<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="matricula.aspx.cs" Inherits="WebApplication1.Matricula.matricula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Font-Size="13pt" Text="Carrera:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="cmbcarrera" runat="server">
</asp:DropDownList>
<br />
<br />
    <asp:Label ID="Label2" runat="server" Font-Size="13pt" Text="Cursos:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="cmbcurso" runat="server">
</asp:DropDownList>
&nbsp;<br />
<br />
    <asp:Label ID="Label3" runat="server" Font-Size="13pt" Text="Grupo:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="cmbgrupo" runat="server">
</asp:DropDownList>
<br />
<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnmatricular" runat="server" Text="Matricular" OnClick="btnmatricular_Click" Font-Size="13pt" Height="42px" Width="109px" />
</asp:Content>
