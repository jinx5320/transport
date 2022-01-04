<%@ Page Language="VB" MasterPageFile="~/HomePage.master" AutoEventWireup="false" CodeFile="~/Buyerlogin.aspx.vb" Inherits="indiandeals.Buyerlogin" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br /><table style="width:31%; border:solid 1px #000000;" align="center">
<tr><td colspan="2" align="center" bgcolor="E3366B"><span style="color:White;font-weight:bold;">Buyer Login</span></td></tr>
<tr>
    <td>Login ID:&nbsp;</td>
    <td><asp:DropDownList ID="DropDownList1" runat="server" /></td>
</tr>
<tr>
    <td>Password:&nbsp;</td>
    <td><asp:TextBox ID="TextBox1" runat="server" TextMode="Password" /><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Password Should not be Empty" ValidationGroup="b1">*</asp:RequiredFieldValidator></td>
</tr>
<tr><td align ="center" colspan="2"><asp:Button ID="cmdlogin" runat="server" Text="Login" Width="84px" ValidationGroup="b1"/></td></tr>
 <tr><td align ="center" colspan="2"><asp:Label ID="lbldisplay" runat="server" /></td></tr>
</table><br />
</asp:Content>

