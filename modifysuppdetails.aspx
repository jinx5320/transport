<%@ Page Language="VB" MasterPageFile="~/supplier.master" AutoEventWireup="false" CodeFile="~/modifysuppdetails.aspx.vb" Inherits="indiandeals.modifysuppdetails" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="aks" Text="Supplier Modification Form" runat="server" 
                    Font-Bold="True" ForeColor="Blue" Font-Size="X-Large" /></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" style="width: 232px">
                <asp:Label ID="Label1" Text="Supplier ID" runat="server" /></td>
            <td>
                <asp:TextBox ID ="sid" runat="server" /></td>
        </tr>
        <tr>
            <td align="right" style="width: 232px">
                <asp:Label ID="Label2" Text="Supplier Password" runat="server" /></td>
            <td>
                <asp:TextBox ID="spwd" runat="server" /></td>
        </tr>
        <tr>
            <td align="right" style="width: 232px">
                <asp:Label ID="Label3" Text="Company Name" runat="server" /></td>
            <td>
                <asp:TextBox ID="cname" runat="server" /></td>
        </tr>
        <tr>
            <td align="right" style="width: 232px">
                <asp:Label ID="Label4" Text="Address" runat="server" /></td>
            <td>
                <asp:TextBox ID="saddress" runat="server" TextMode="MultiLine" /></td>
        </tr>
        <tr>
            <td align="right" style="width: 232px">
                <asp:Label ID="Label5" Text="Poineers Company" runat="server" /></td>
            <td>
                <asp:DropDownList ID ="spioneer" runat="server" /></td>
        </tr>
        <tr>
            <td align="right" style="width: 232px">
                <asp:Label ID="Label6" Text="E-Mail" runat="server" /></td>
            <td>
                <asp:TextBox ID="email" runat="server" /></td>
        </tr>
        <tr>
            <td align="right" style="width: 232px">
                <asp:Label ID="Label7" Text="Web Site" runat="server" /></td>
            <td>
                <asp:TextBox ID="website" runat="server" /></td>
        </tr>
        <tr>
            <td align="right" style="width: 232px">
                <asp:Label ID="Label8" Text="Date Of Establishment" runat="server" /></td>
            <td>
                <asp:TextBox ID="doe" runat="server" /></td>
            
        </tr>
        <tr>
            <td align="right" style="width: 232px">
                <asp:Label ID="Label9" Text="Turn Over" runat="server" /></td>
            <td>
                <asp:TextBox ID="tover" runat="server" /></td>
        </tr>
        <tr >
            <td style="width: 232px" align="right">
                <asp:Label ID="Label11" Text="Credit Card Number" runat="server" /></td>
            <td>
                <asp:TextBox ID="ccno" runat="server" /></td>
        </tr>
        <tr>
            <td align="right" style="width: 232px">
                <asp:Label ID="Label12" Text="Credit Card Validity Upto" runat="server" /></td>
            <td>
                <asp:TextBox ID="ccvu" runat="server" /></td>
        </tr>
        <tr>
        <td colspan="2" align="center"><asp:Button ID="cmdadd" runat="server" Text="Modify" 
                Width="97px" /></td></tr>
    </table>
</asp:Content>

