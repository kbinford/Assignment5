<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Registration</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
                <td>Enter First Name </td>
           <td> <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
                <td>Enter Last Name </td>
            <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
                <td>Enter Email</td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
           
        
        <tr>
                <td>Enter password</td>
            <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
                <td>Confirm Password</td>
            <td>
                <asp:TextBox ID="txtConfirm" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
        <td>
             <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

        </td>
        <td>
            <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>

        </td>
       </tr>

    </table>
    </div>
    </form>
</body>
</html>
