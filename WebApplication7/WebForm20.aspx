<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm30.aspx.cs" Inherits="WebApplication7.WebForm30" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<body>
<form id="Form1" runat="server">
<p style="color: #000000"><strong>Kindly enter any one class of whose question paper you want to generate randomly.Corresponding to a particular class select a subject.</strong></p>
 <table align="center">
 <tr>
 <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Class 12&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
 
 <td>
     <asp:RadioButtonList ID="RadioButtonList2" runat="server">
         <asp:ListItem>Physics</asp:ListItem>
         <asp:ListItem>Chemistry</asp:ListItem>
         <asp:ListItem>Maths</asp:ListItem>
         <asp:ListItem>Biology</asp:ListItem>
         <asp:ListItem>English</asp:ListItem>
         <asp:ListItem>Physical Education</asp:ListItem>
     </asp:RadioButtonList>
     </td></tr>
 
 <tr>
 <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Class 10</td>
 
 <td><asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
         onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
         <asp:ListItem>Science</asp:ListItem>
         <asp:ListItem>Mathematics</asp:ListItem>
         <asp:ListItem>Social Studies</asp:ListItem>
         <asp:ListItem>English</asp:ListItem>
         <asp:ListItem>Computer</asp:ListItem>
     </asp:RadioButtonList>
     </td></tr></table>
     <tr><td></td>
     <td>&nbsp;&nbsp;&nbsp; 
         <asp:TextBox ID="TxtRequiredRecords" runat="server"></asp:TextBox>
        </td><td>
        <asp:Button ID="BtnDisplayRecords" runat="server"  Text="Display Records" OnClick="BtnDisplayRecords_OnClick" />
        </td></tr>
        <tr><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td><asp:GridView ID="GvResults" runat="server">
        </asp:GridView></td><td></td>
        </tr>
<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
     <br />
     </form>
     </body>