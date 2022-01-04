<%@ Page Language="VB" MasterPageFile="~/supplier.master" AutoEventWireup="false" CodeFile="~/deleteproduct.aspx.vb" Inherits="indiandeals.deleteproduct" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height: 204px;">
        <tr>
            <td colspan="4" align="center">
                <asp:Label ID="sls" Text="Product Deletion" runat="server" Font-Bold="True" 
                    ForeColor="#0033CC" Font-Size="X-Large" /></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" Text="Product ID" runat="server" /></td>
            <td style="width: 149px">
                <asp:DropDownList ID="pid" runat="server" AutoPostBack="True" /></td>
        <td>
                <asp:Label ID="Label2" Text="Tax" runat="server" /></td>
            <td>
                <asp:TextBox ID="Tax" runat="server" /></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" Text="Name" runat="server" /></td>
            <td style="width: 149px">
                <asp:TextBox ID="name" runat="server" /></td>
        <td>
                <asp:Label ID="Label4" Text="Dom" runat="server" /></td>
            <td>
                <asp:TextBox ID="dom" runat="server" /></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" Text="Price" runat="server" /></td>
            <td style="width: 149px">
                <asp:TextBox ID="price" runat="server" /></td>
        <td>
                <asp:Label ID="Label6" Text="Batch No" runat="server" /></td>
            <td>
                <asp:TextBox ID="batchno" runat="server" /></td>
        </tr>
        <tr >
            <td>
                <asp:Label ID="Label7" Text="Category" runat="server" /></td>
            <td style="width: 149px">
                <asp:DropDownList ID="catg" runat="server" /></td>
                </tr>
                <tr>
        <td colspan="4" align="center" valign="middle">
                <asp:Button ID="cmdadd" Text="Delete Product" runat="server" /></td>
            </tr>
    </table>
</asp:Content>

