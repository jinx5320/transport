<%@ Page Language="VB" MasterPageFile="~/Buyer.master" AutoEventWireup="false" CodeFile="~/dispmsgb.aspx.vb" Inherits="indiandeals.dispmsgb" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="Label4" Text="Message" runat="server" Font-Bold="True" 
                    Font-Size="X-Large" ForeColor="#0033CC" /></td>
            
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="lsk" Text="From:" runat="server" /></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" /></td>
        </tr>
        <tr>
            <td align="right">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label1" Text="Subject:" runat="server" /></td>
            <td>
                <asp:TextBox ID="subject" runat="server" Width="302px" /></td>
        </tr>
        <tr>
            <td align="right">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label2" Text="Message:" runat="server" /></td>
            <td>
                <asp:TextBox ID="msg" runat="server" Height="114px" TextMode="MultiLine" 
                    Width="246px" /></td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label3" Text="Send At:" runat="server" /></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" /></td>
        </tr>
        <tr>
        <td colspan="2" align="center"><asp:Button ID="cmdclose" runat="server" 
                Text="Close" Width="71px" /></td></tr>
    </table>
</asp:Content>

