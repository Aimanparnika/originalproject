<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm21.aspx.cs" Inherits="WebApplication7.WebForm21" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="color: #000000"><strong>Kindly select the section under which you add the question of desired category.Make sure questions are relevant.</strong></p>
 <table align="center">
 <tr>
 <td>&nbsp;&nbsp;Class 10&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
 
 <td style="width: 450px">
     
     <asp:RadioButtonList ID="RadioButtonList4" runat="server" AutoPostBack="True" 
         RepeatDirection="Horizontal">
         <asp:ListItem>English</asp:ListItem>
         <asp:ListItem>Social Studies</asp:ListItem>
         <asp:ListItem>Mathematics</asp:ListItem>
         <asp:ListItem>Science</asp:ListItem>
         <asp:ListItem>Computer</asp:ListItem>
     </asp:RadioButtonList>
     
     </td></tr>
 
 <tr>
 <td>&nbsp;Class 12</td>
 
 <td style="width: 450px">
     <asp:RadioButtonList ID="RadioButtonList5" runat="server" AutoPostBack="True" 
         RepeatDirection="Horizontal">
         <asp:ListItem>Physics</asp:ListItem>
         <asp:ListItem>Chemistry</asp:ListItem>
         <asp:ListItem>Mathematics</asp:ListItem>
         <asp:ListItem>Biology</asp:ListItem>
         <asp:ListItem>Physical Education</asp:ListItem>
     </asp:RadioButtonList>
     </td></tr>
     <tr>
     <td>&nbsp;&nbsp; Category</td>
     <td style="width: 450px">
         <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="True" 
             RepeatDirection="Horizontal">
             <asp:ListItem>Easy</asp:ListItem>
             <asp:ListItem>Medium</asp:ListItem>
             <asp:ListItem>Difficult</asp:ListItem>
         </asp:RadioButtonList>
         </td></tr>
    </table>
     <br />
    <span>Enter your question here.....<br />
    </span>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Width="42px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span>
    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="507px"></asp:TextBox>
    </span>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    &nbsp;
<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />

</asp:Content>
