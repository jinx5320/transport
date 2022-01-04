<%@ Page Language="VB" MasterPageFile="~/HomePage.master" AutoEventWireup="false" CodeFile="~/Buyer Registartion.aspx.vb" Inherits="indiandeals.Buyer_Registartion" title="Untitled Page" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 57%; border:solid 1px #000000;" align="center">
        <tr>
            <td colspan="2">
                <asp:Label ID="lbldisplay" runat="server" /></td>
            
        </tr>        
        <tr>
            <td colspan="2" align="center" bgcolor="#E3366B">
                <asp:Label ID="aks" Text="Buyer Registration" runat="server" 
                    Font-Bold="True" ForeColor="white" Font-Size="X-Large" /></td>
            <td align="center">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 143px">
                <asp:Label ID="Label1" Text="Buyer ID" runat="server" /></td>
            <td>
                <asp:TextBox ID ="bid" runat="server" /></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 143px">
                <asp:Label ID="Label2" Text="Buyer Password" runat="server" /></td>
            <td>
                <asp:TextBox ID="bpwd" runat="server" TextMode="Password" /></td>
            
        </tr>
        <tr>
            <td style="width: 143px">
                <asp:Label ID="Label3" Text="Company Name" runat="server" /></td>
            <td>
                <asp:TextBox ID="cname" runat="server" /></td>
            
        </tr>
        <tr>
            <td style="width: 143px">
                <asp:Label ID="Label4" Text="Address" runat="server" /></td>
            <td>
                <asp:TextBox ID="baddr" runat="server" TextMode="MultiLine" /></td>
            
        </tr>
        <tr>
            <td style="width: 143px">
                <asp:Label ID="Label5" Text="Poineers Company" runat="server" /></td>
            <td>
                <asp:DropDownList ID ="bpioneer" runat="server" /></td>
            
        </tr>
        <tr>
            <td style="width: 143px">
                <asp:Label ID="Label6" Text="E-Mail" runat="server" /></td>
            <td>
                <asp:TextBox ID="email" runat="server" /></td>
           
        </tr>
        <tr>
            <td style="width: 143px">
                <asp:Label ID="Label7" Text="Web Site" runat="server" /></td>
            <td>
                <asp:TextBox ID="website" runat="server" /></td>
           
        </tr>
        <tr>
            <td style="width: 143px">
                <asp:Label ID="Label8" Text="Date Of Establishment" runat="server" /></td>
            <td>
                <asp:TextBox ID="doe" runat="server" />
                                <asp:Label ID="sksks" runat="server" Text="YYYY-MM-DD" /></td>
        </tr>
        <tr>
            <td style="width: 143px">
                <asp:Label ID="Label9" Text="Turn Over" runat="server" /></td>
            <td>
                <asp:TextBox ID="tover" runat="server" /></td>
        </tr>
        <tr>
            <td style="width: 143px">
                <asp:Label ID="Label10" Text="Register Date" runat="server" /></td>
            <td>
                <asp:TextBox ID="rdate" runat="server" />
            <asp:Label ID="Label11" runat="server" Text="YYYY-MM-DD" /></td>
                
        </tr>
        
        <tr>
            <td style="width: 143px">
                <asp:Label ID="Label12" Text="DOLT" runat="server" /></td>
            <td>
                <asp:TextBox ID="dolt" runat="server" />
                <asp:Label ID="Label13" runat="server" Text="YYYY-MM-DD" /></td>
        </tr>
        <tr>
        <td colspan="2" align="center"><asp:Button ID ="cmdadd" Text="Add Buyer" runat="server" /></td></tr>
    </table>
</asp:Content>  

