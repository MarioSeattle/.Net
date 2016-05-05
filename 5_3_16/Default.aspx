<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mario's C# Exercise 3_5_16</title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:DropDownList ID="DropDownVenues" runat="server"></asp:DropDownList>

        <asp:DropDownList ID="DropDownArtist" runat="server"></asp:DropDownList>


        <asp:DropDownList ID="DropDownShows" runat="server"></asp:DropDownList>



        <asp:Button ID="ButtonVenue" runat="server" Text="Get Shows by Venue" OnClick="ButtonVenue_Click" />

        <asp:GridView ID="GridViewVenue_Shows" runat="server"></asp:GridView>

    
        <asp:Button ID="Button1" runat="server" Text="Get by Shows Artist" OnClick="Button1_Click" />

        <asp:GridView ID="GridViewArtist_Shows" runat="server"></asp:GridView>

    <div>
    
    </div>
    </form>
</body>
</html>
