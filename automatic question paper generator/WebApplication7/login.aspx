<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="WebApplication7.WebForm17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<body>
<h1 align="center" class="style11" >LOGIN</h1>
<table>
<tr>
<td><b>Username&nbsp; :</b></td><td>&nbsp;<asp:TextBox ID="TextBox1" runat="server" 
        Width="220px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
    &nbsp;</td>
</tr>
<tr>
<td><b>Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    </b></td>'
<td>
    <asp:TextBox ID="TextBox2" runat="server"  Width="220px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>

    <tr><td></td>
    <td>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="LOGIN" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    <td>&nbsp;</td></tr></td>
</tr>
</table>

<p style="color: #FF0000"><strong><a href="adminlogin.aspx">If you are a admin,click here!!!!</a></strong></p>

</body>
</asp:Content>
