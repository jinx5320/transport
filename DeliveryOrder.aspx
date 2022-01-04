<%@ Page Language="VB" MasterPageFile="~/supplier.master" AutoEventWireup="false" CodeFile="~/DeliveryOrder.aspx.vb" Inherits="indiandeals.DeliveryOrder" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID ="Label1" runat="server"  Text="Delivery Order" 
                    Font-Bold="True" Font-Size="X-Large" ForeColor="#0033CC"/></td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                &nbsp;</td>
        </tr>   
        <tr>
            <td align="right">
                <asp:Label ID ="hknk" runat="server"  Text="Purchase Order ID"/></td>
            <td>
                <asp:DropDownList ID="poid" runat="server" AutoPostBack="True" /></td>
        </tr>   
        <tr>
            <td align="right">
                <asp:Label ID ="Label2" runat="server"  Text="Product ID"/></td>
            <td>
                <asp:TextBox ID="pid" runat="server" /></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID ="Label3" runat="server"  Text="Quantity"/></td>
            <td>
               <asp:TextBox ID="qty" runat="server" /></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID ="Label4" runat="server"  Text="Delivery Date"/></td>
            <td>
                <asp:TextBox ID="ddate" runat="server" /></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID ="Label5" runat="server"  Text="Bid"/></td>
            <td>
                <asp:TextBox ID="bid" runat="server" /></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID ="Label6" runat="server"  Text="Confirm Date"/></td>
            <td>
                <asp:TextBox ID="condate" runat="server" /></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID ="Label7" runat="server"  Text="Revised Quantity"/></td>
            <td>
                <asp:TextBox ID="rqty" runat="server" /></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID ="Label8" runat="server"  Text="Total"/></td>
            <td>
                <asp:TextBox ID="total" runat="server" /></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID ="cmdorder" runat="server"  Text="Deliver"/></td>
           
        </tr>
    </table>
</asp:Content>

