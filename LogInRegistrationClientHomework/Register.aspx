<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <table>
        <tr>
        <td>Venue Name</td>
        <td><asp:TextBox ID="VenueNameTextBox" runat="server"></asp:TextBox> </td>
        <td></td>
        </tr>
        <tr>
        <td>Venue Address</td>
        <td><asp:TextBox ID="VenueAddressTextBox" runat="server"></asp:TextBox> </td>
            <td></td>
            </tr>
             <tr>
        <td>Venue City</td>
        <td><asp:TextBox ID="VenueCityTextBox" runat="server"></asp:TextBox> </td>
            <td></td>
            </tr>
             <tr>
        <td>Venue State</td>
        <td><asp:TextBox ID="VenueStateTextBox" runat="server"></asp:TextBox> </td>
            <td></td>
            </tr>

        <tr>
        <td>Venue ZipCode</td>
        <td><asp:TextBox ID="ZipCodeTextBox" runat="server"></asp:TextBox> </td>
            <td></td>
            </tr>

             <tr>
        <td>Venue Phone</td>
        <td><asp:TextBox ID="VenuePhoneTextBox" runat="server"></asp:TextBox> </td>
            <td></td>
            </tr>

                <tr>
        <td>Venue Email</td>
        <td><asp:TextBox ID="VenueEmailTextBox" runat="server"></asp:TextBox> </td>
            <td></td>
            </tr>

                <tr>
        <td>Venue WebPage</td>
        <td><asp:TextBox ID="VenueWebPageTextBox" runat="server"></asp:TextBox> </td>
            <td></td>
            </tr>

                <tr>
        <td>Venue AgeRestriction</td>
        <td><asp:TextBox ID="AgeRestrictionTextBox" runat="server"></asp:TextBox> </td>
            <td></td>
            </tr>

                 
        <tr>
        <td>UserName</td>    
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
                <asp:Button ID="SubmitBottom" runat="server" Text="Button" OnClick="SubmitBottom_Click"  />

            </td>
            <td> <asp:Label ID="ErrorLabel" runat="server" Text="Label"></asp:Label></td>
            <td>&nbsp;</td>
    </tr>
    </table>

    </div>
    </form>
</body>
</html>
