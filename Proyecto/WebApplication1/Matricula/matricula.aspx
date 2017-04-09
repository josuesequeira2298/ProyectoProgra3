<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="matricula.aspx.cs" Inherits="WebApplication1.Matricula.matricula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    Carrera:&nbsp;
<asp:DropDownList ID="cmbcarrera" runat="server">
</asp:DropDownList>
<br />
<br />
Curso:&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="cmbcurso" runat="server">
</asp:DropDownList>
<br />
<br />
Grupo:&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="cmbgrupo" runat="server">
</asp:DropDownList>
<br />
<br />
    <asp:Button ID="btnmatricular" runat="server" Text="Matricular" OnClick="btnmatricular_Click" />
</asp:Content>
