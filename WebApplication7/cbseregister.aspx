<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeFile="cbseregister.aspx.cs" Inherits="WebApplication7.WebForm19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
<h1 style="color: #009933">Registration form</h1>
<h4>Teachers kindly confirm that your entries are true so that we can welcome your questions further.</h4>
<table ><br />
<tr>
<td style="font-weight: bold"><b>Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    </b> </td>
<td><asp:TextBox ID="TextBox1" runat="server" Width="193px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="*Compulsory" ControlToValidate="TextBox1" ForeColor="#FF3300"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td style="font-weight: bold"><b>School Id:</b></td>
<td><asp:TextBox ID="TextBox2" runat="server" Width="193px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ErrorMessage="*Compulsory" ControlToValidate="TextBox2" ForeColor="#FF3300"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td style="font-weight: bold"><b>Subject:</b></td>
<td><asp:TextBox ID="TextBox3" runat="server"  Width="193px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ErrorMessage="*Compulsory" ControlToValidate="TextBox3" ForeColor="#FF3300"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td style="font-weight: bold"><b>E-mail id:</b></td>
<td><asp:TextBox ID="TextBox4" runat="server" Width="193px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ErrorMessage="*Compulsory" ControlToValidate="TextBox4" ForeColor="#FF3300"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td style="font-weight: bold"><b>User name:</b></td>
<td><asp:TextBox ID="TextBox6" runat="server"  Width="193px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
        ErrorMessage="*Compulsory" ControlToValidate="TextBox6" 
        ForeColor="#FF3300"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td style="font-weight: bold"><b>password:</b></td>
<td><asp:TextBox ID="TextBox7" runat="server" Width="193px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
        ErrorMessage="*Compulsory" ControlToValidate="TextBox7" 
        ForeColor="#FF3300"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td style="font-weight: bold"><b>c-password:</b></td>
<td><asp:TextBox ID="TextBox8" runat="server" Width="193px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
        ErrorMessage="*Compulsory" ControlToValidate="TextBox8" 
        ForeColor="#FF3300"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td style="font-weight: bold"><b>contact number:</b></td>
<td><asp:TextBox ID="TextBox5" runat="server" Width="193px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
        ErrorMessage="*Compulsory" ControlToValidate="TextBox5" ForeColor="#FF3300"></asp:RequiredFieldValidator></td>
</tr>

</table>
<br />
<table>
<tr><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    &nbsp;</td>
    
<td><asp:Button ID="Button1" runat="server" Text="Register" style="height: 26px" 
        onclick="Button1_Click" /></td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
            ID="Lbl1" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    &nbsp;</td></tr></table>
</asp:Content>
