<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="FirstStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <!--This is a web or xml comment-->
        <h1>Birthday Calculator</h1>
        <hr />
        <p>Choose your birthday</p>
        <asp:Calendar ID="Calendar1" runat="server">
        </asp:Calendar>
        <p>Enter your name<asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox></p>
        <p>
        <asp:Button ID="SubmitButtom" runat="server" Text="Submit" OnClick="SubmitButtom_Click" />
        <asp:Label ID="ResultLabel" runat="server" CssClass="result"></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
