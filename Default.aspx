<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Login</h1>
        <table>
            <tr>
                <td>User Name</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
            </tr>
                       <tr>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="Log In" OnClick="btnLogin_Click" />
                </td>
                <td>
                    <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label> </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
