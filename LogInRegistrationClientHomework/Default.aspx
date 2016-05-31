<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
    <div>
       <h1>Log in Register</h1>
         <hr />
          <table>
              <tr>
                <td>User Name</td>
                  <td>
                    <asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox>
                  </td>
                </tr>
                <tr>
                <td>Password</td>
                    <td>
                    <asp:TextBox ID="Passwordtextbox" TextMode ="Password" runat="server"></asp:TextBox>
                    </td>
              </tr>

              <tr>
                  <td>
                      <asp:Button ID="LogInBottom" runat="server" Text="LogIn" OnClick="LogInBottom_Click" />
                      

                </td>
                  <td>
                      <asp:Label ID="Errorlabel" runat="server" Text=""></asp:Label>

                  </td>
              </tr>
              </table>
              <asp:LinkButton ID="RegisterLink" runat="server" PostBackUrl="Register.aspx">Register</asp:LinkButton>
          

        </div>
   
    </form>
</body>
</html>
