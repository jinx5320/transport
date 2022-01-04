<%@ Page Language="VB" MasterPageFile="~/AdminPage.master" AutoEventWireup="false" CodeFile="~/launchcategory.aspx.vb" Inherits="indiandeals.launchcategory" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br /><table align="center" width="50%" style="border:solid 1px #000000;">
<tr><td align ="center" colspan="3" bgcolor="#E3366B"><span style="color:White;font-weight:bold;">Launch Category</span></td></tr>
<tr>
    <td>Categories:</td>
    <td><asp:TextBox ID="catgid" runat="server" Width="180" /><asp:RequiredFieldValidator ID="RFV1" runat="server" ControlToValidate="catgid" ErrorMessage="Enter Category Name">*</asp:RequiredFieldValidator></td>
    <td><asp:Button ID="cmdadd" Text="Add New" runat="server" Font-Size="Small" /></td>
</tr>
<tr><td height="5"></td></tr>
<tr>
    <td colspan="3" align="center" width="180"><asp:ListBox ID="lstitems" runat="server" Font-Bold="True" Font-Size="12px" DataSourceID="SqlDataSource1" DataTextField="NAME" DataValueField="NAME" AutoPostBack="True" Height="110px" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:categories_ConnectionString %>" ProviderName="<%$ ConnectionStrings:categories_ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [CATG]"></asp:SqlDataSource></td>
</tr>
</table><br />
</asp:Content>

