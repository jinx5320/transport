<%@ Page Language="VB" MasterPageFile="~/HomePage.master" AutoEventWireup="false" CodeFile="contactus.aspx.vb" Inherits="contactus" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">    
 <table width="100%" border="0">
 <tr>
    <td width="40%" class="txtFont"><h1><font color="blue"><u>Contact Us</u></font></h1>
        <font color="#E3366B" size="5px"><b>Mighty Business</b><br /></font>
        <span style="color:#20C82D; font-weight:bold;">Jublii Hills,Road No:12,<br />
        Hyderabad,Andhra Pradesh,<br />
        Phone:040-23440401,<br />
        Mail:info@mightybusiness.com.</span></td>
    <td width="60%"><marquee direction="left" bgcolor="white"><img src="images/img7.jpg" alt="" width="127" height="126" />&nbsp;&nbsp;<img src="images/img8.jpg" alt="" width="150" height="89" />&nbsp;&nbsp;<img src="images/img6.jpg" alt="" width="117" height="109" /></marquee></td>
</tr>
<tr>
    <td colspan="2">
    <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1"/>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile.xml">
    </asp:XmlDataSource></td>
</tr>
</table>   
</asp:Content>

