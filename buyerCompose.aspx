<%@ Page Language="VB" MasterPageFile="~/Buyer.master" AutoEventWireup="false" CodeFile="~/buyerCompose.aspx.vb" Inherits="indiandeals.buyerCompose" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table> 
<tr>
            <td align ="center"><asp:Label ID="Label1" Text="Select Type Of  Product" runat="server" />
                </td>
            <td>
                <asp:DropDownList ID ="pioneer" runat="server" /></td>
        </tr>
        <tr>
            <td colspan ="2" align="center"><asp:Button ID="cmdNext" Text="Next" runat="server" 
                    Width="65px" />
                </td>
            
        </tr>
    </table>
</asp:Content>

