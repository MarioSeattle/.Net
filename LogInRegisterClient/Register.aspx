<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 435px">
    <table>
        <tr>
        <td>last Name</td>
        <td><asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox> </td>
        <td></td>
        </tr>
        <tr>
        <td>First Name</td>
        <td><asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox> </td>
            <td></td>
            </tr>
        <tr>
        <td>Email</td>    
        <td><asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox> </td>
         <td>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="Invalid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            </tr>
        <tr>
        <td>Password</td>
        <td><asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox> </td>
        <td> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="password required"  ControlToValidate="PasswordTextBox"></asp:RequiredFieldValidator>
            </td>
         </tr>
        <tr>
            <td>Confirm Password</td>
            <td>
                <asp:TextBox ID="ConfirmTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="They don't match" ControlToCompare="PasswordTextBox" ControlToValidate="ConfirmTextBox"></asp:CompareValidator>
            </td>

            </tr>
        <tr>
            <td>
                <asp:Button ID="SubmitBottom" runat="server" Text="Button" OnClick="SubmitBottom_Click" />

            </td>
            <td> <asp:Label ID="ErrorLabel" runat="server" Text="Label"></asp:Label></td>
            <td>&nbsp;</td>
    </tr>
    </table>
    </div>
    </form>
</body>
</html>
