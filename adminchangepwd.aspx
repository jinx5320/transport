<%@ Page Language="VB" MasterPageFile="~/AdminPage.master" AutoEventWireup="false" CodeFile="~/adminchangepwd.aspx.vb" Inherits="indiandeals.adminchangepwd" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 40%; border:solid 1px #000000;" align="center">
<tr><td colspan="2" align="center" bgcolor="#E3366B"><b>Change Password</b></td></tr>
<tr>
    <td>Old Password:&nbsp;</td>
    <td><asp:TextBox ID="Text1" runat="server" TextMode="Password" /><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="old Password Should Not be Empty" ControlToValidate="Text1">*</asp:RequiredFieldValidator></td>
</tr>
<tr>
    <td>New Password:&nbsp;</td>
    <td><asp:TextBox ID="Text2" runat="server" TextMode="Password" /><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="New Password Should Not Be Empty" ControlToValidate="Text2">*</asp:RequiredFieldValidator></td>
</tr>
<tr>
    <td align="right"><asp:Button ID="cmdsubmit" Text="Submit" runat="server" /></td>
    <td><asp:Button ID="cmdcancel" Text="Cancel" runat="server" /></td>
</tr>
<tr><td colspan="2"><asp:ValidationSummary ID="ValidationSummary1" runat="server" /></td></tr>
</table>
</asp:Content>

