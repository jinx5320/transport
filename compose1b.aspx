<%@ Page Language="VB" MasterPageFile="~/Buyer.master" AutoEventWireup="false" CodeFile="~/compose1b.aspx.vb" Inherits="indiandeals.compose1b" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table>
<tr>
<td colspan="2" align="center">
    <asp:label ID="sa" Text="Compose" runat="server" 
        Font-Bold="True" Font-Size="X-Large" ForeColor="#0033CC" /></td></tr>
<tr>
<td colspan="2" align="center">&nbsp;</td></tr>
<tr><td><asp:Label ID="sjlsd" Text="TO: " runat="server" /></td>
<td><asp:DropDownList ID="toid" runat="server" Height="16px" Width="157px" /></td>
</tr>
<tr><td colspan="2">&nbsp;</td>
</tr>
<tr>
<td><asp:Label ID="Label1" Text="Subject: " runat="server" /></td>
<td><asp:TextBox ID="subject" runat="server" Width="363px" /></td></tr>
<tr><td colspan="2">&nbsp;</td></tr>
<tr><td><asp:Label ID="Label1s" Text="Message: " runat="server" /></td>
<td><asp:TextBox ID="msg" runat="server" Height="107px" TextMode="MultiLine" 
        Width="383px" /></td></tr>
<tr>
<td colspan="2" align="center"><asp:Button ID="cmdsubmit" runat="server" Text="Submit" /></td></tr>
</table>
</asp:Content>

