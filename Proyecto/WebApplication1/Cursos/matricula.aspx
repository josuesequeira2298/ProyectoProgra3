﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="matricula.aspx.cs" Inherits="WebApplication1.Matricula.matricula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Font-Size="13pt" Text="Carrera:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="cmbcarrera" runat="server" OnSelectedIndexChanged="cmbcarrera_SelectedIndexChanged" Width="154px">
</asp:DropDownList>
<br />
    <asp:GridView ID="dgvMatri" runat="server">
    </asp:GridView>
<br />
    <asp:Label ID="Label2" runat="server" Font-Size="13pt" Text="Cursos:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="cmbcurso" runat="server" OnSelectedIndexChanged="cmbcurso_SelectedIndexChanged" Width="158px">
</asp:DropDownList>
&nbsp;<br />
<br />
    <asp:Label ID="Label3" runat="server" Font-Size="13pt" Text="Grupo:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="cmbgrupo" runat="server" OnSelectedIndexChanged="cmbgrupo_SelectedIndexChanged" Width="154px">
</asp:DropDownList>
<br />
<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnmatricular" runat="server" Text="Matricular" OnClick="btnmatricular_Click" Font-Size="13pt" Height="42px" Width="109px" />
</asp:Content>
