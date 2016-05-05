<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="AuthorDropDownList" runat="server"></asp:DropDownList>
        <asp:GridView ID="BusinessGridView" runat="server"></asp:GridView>
        <asp:Button ID="BusinessButton" runat="server" Text="Button" OnClick="BusinessButton_Click" />
    <div>
    
    </div>
    </form>
</body>
</html>
