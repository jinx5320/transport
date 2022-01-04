<%@ Page Language="VB" MasterPageFile="~/HomePage.master" AutoEventWireup="false" CodeFile="~/adminlogin.aspx.vb" Inherits="indiandeals._Default" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <br /><table style="width: 30%;border:solid 1px #E3366B;" align="center">
<tr><td colspan="2" align="center" bgcolor="#E3366B"><b>Admin Login</b></td></tr>
<tr>
    <td>User Name:&nbsp;</td>
    <td><asp:TextBox ID="txtusr" runat="server" Width="120"/></td>
</tr>
<tr>
    <td>Password:&nbsp;</td>
    <td><asp:TextBox ID="TextBox1" runat="server" Width="120" TextMode="Password" /></td>
</tr>
<tr>
    <td align="center" colspan="2"><asp:Button ID="cmdlogin" runat="server" Text="Login"/>&nbsp;
    <asp:Button ID="cmdreset" runat="server" Text="Back"/></td>
</tr>
<tr><td colspan="2"><asp:Label ID="lbldisplay" runat="server" /></td></tr>           
</table>
<script type="text/javascript" language="javascript">
    function validate() {    
    if (document.getElementById("ctl00_ContentPlaceHolder1_txtusr").value == '') {
        alert("User Name is required");        
        return false;
    }
    else if (document.getElementById("ctl00_ContentPlaceHolder1_TextBox1").value == '') 
    {
        alert("Password is required");        
        return false;
    }    
    else
        return true;
}
</script>
</asp:Content>

