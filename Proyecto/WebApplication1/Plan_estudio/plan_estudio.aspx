<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Plan_estudio.aspx.cs" Inherits="WebApplication1.Plan_estudio.Plan_estudio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    

    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        Seleccion de Carrera:&nbsp;
        <asp:DropDownList ID="cboCarrera" runat="server" Width="158px" OnSelectedIndexChanged="cboCarrera_SelectedIndexChanged">
        </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCargar" runat="server" OnClick="btnCargar_Click" Text="Cargar" Height="18px" Width="58px" />
    </p>
<br />
<br />
    Aprobados:<br />
    <br />
        <asp:GridView ID="dgvplan" runat="server" Height="263px" Width="721px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
    <br />
    Faltantes<br />
<br />
    <asp:GridView ID="dgvplan2" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="288px" Width="722px">
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

    

</asp:Content>
