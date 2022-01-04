<%@ Page Language="VB" MasterPageFile="~/AdminPage.master" AutoEventWireup="false" CodeFile="~/admincompose.aspx.vb" Inherits="indiandeals.admincompose" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table align="center" style="border:solid 1px #000000;">
<tr><td colspan="2" align="center" bgcolor="#E3366B"><span style="color:White;font-weight:bold;">Compose</span></td></tr>
<tr>
    <td>To:</td>
    <td><asp:DropDownList ID="toid" runat="server" Height="16px" Width="157px" /></td>
</tr>
<tr>
    <td>Subject:</td>
    <td><asp:TextBox ID="subject" runat="server" Width="363px" /></td>
</tr>
<tr>
    <td>Message:</td>
    <td><asp:TextBox ID="msg" runat="server" Height="107px" TextMode="MultiLine" Width="383px" /></td>
</tr>
<tr><td colspan="2" align="center"><asp:Button ID="cmdsubmit" runat="server" Text="Submit" /></td></tr>
</table>
</asp:Content>

