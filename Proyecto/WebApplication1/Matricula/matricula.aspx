<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="matricula.aspx.cs" Inherits="WebApplication1.Matricula.matricula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    Carrera:&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server">
</asp:DropDownList>
<br />
<br />
Curso:&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList2" runat="server">
</asp:DropDownList>
<br />
<br />
Grupo:&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList3" runat="server">
</asp:DropDownList>
<br />
<br />
    <asp:Button ID="btnagregar" runat="server" Text="Matricular" OnClick="btnagregar_Click" />
</asp:Content>
