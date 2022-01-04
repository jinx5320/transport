<%@ Page Language="VB" MasterPageFile="~/AdminPage.master" AutoEventWireup="false" CodeFile="~/cancelsupp.aspx.vb" Inherits="indiandeals.cancelsupp" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 38%; border:solid 1px #000000;" align="center">
<tr><td colspan="3" align="center" bgcolor="#E3366B"><span style="color:White;font-weight:bold;">Suppliers Cancellation</span></td></tr>
<tr><td colspan="3" align="center" style="height: 21px"></td></tr>
<tr>
    <td>Select Supplier:&nbsp;</td>
    <td><asp:DropDownList ID="DropDownList1" runat="server" /></td>
    <td><asp:Button ID="cmddelete" Text="Delete" runat="server" Width="85px" /></td></tr>
</table>
</asp:Content>

