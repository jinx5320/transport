<%@ Page Language="VB" MasterPageFile="~/Buyer.master" AutoEventWireup="false" CodeFile="~/buyerCompose2.aspx.vb" Inherits="indiandeals.buyerCompose2" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
<tr><td colspan="2" align="center"><asp:Label ID ="Label1" runat="server"  Text="Buyer Purchase Order" Font-Bold="True" Font-Size="X-Large" ForeColor="#0033CC"/></td></tr>
<tr><td colspan="2" align="center">&nbsp;</td></tr>
<tr>
    <td align="right"><asp:Label ID ="hknk" runat="server"  Text="Purchase Order ID"/></td>
    <td><asp:TextBox ID="porder" runat="server"/></td>
</tr>   
<tr>
    <td align="right"><asp:Label ID ="Label2" runat="server"  Text="Product ID"/></td>
    <td><asp:DropDownList ID="pid" runat="server" /></td>
</tr>
<tr>
    <td align="right"><asp:Label ID ="Label3" runat="server"  Text="Name"/></td>
    <td><asp:TextBox ID="name" runat="server" /></td>
</tr>
<tr>       
    <td align="right"><asp:Label ID ="Label8" runat="server"  Text="Price"/></td>
    <td><asp:TextBox ID="price" runat="server" /></td>
</tr>
<tr>
    <td align="right"><asp:Label ID ="Label4" runat="server"  Text="Delivery Date"/></td>
    <td><asp:TextBox ID="ddate" runat="server" /></td>
</tr>
<tr>
    <td align="right"><asp:Label ID ="Label5" runat="server"  Text="Quantity"/></td>
    <td><asp:TextBox ID="qty" runat="server" /></td>
</tr>
<tr><td colspan="2" align="center"><asp:Button ID ="cmdorder" runat="server"  Text="Order" Width="85px"/></td></tr>
</table>
</asp:Content>

