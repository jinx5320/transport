<%@ Page Language="VB" MasterPageFile="~/AdminPage.master" AutoEventWireup="false" CodeFile="~/Buyerlist.aspx.vb" Inherits="indiandeals.Buyerlist" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table><tr>
<td align="center"><asp:Label ID="ljsls" runat="server" Text="Buyers List" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" /></td></tr>
<tr><td>&nbsp</td></tr>
<tr>
    <td><asp:DataGrid id="DataGrid1" runat="server">
    <ItemStyle Font-Size="12px"></ItemStyle>
	<HeaderStyle Font-Size="12px" ForeColor="white" BackColor="#E3366B" Font-Bold="true"></HeaderStyle>
	</asp:DataGrid></td>
</tr>
</table>
</asp:Content>

