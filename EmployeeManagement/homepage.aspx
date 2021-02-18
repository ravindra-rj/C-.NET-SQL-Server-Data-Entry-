<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="EmployeeManagement.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div >

<!- Table created for containing input text and button ->
            <table align="center">

<!- text input space ->
                <tr>
                    <td>UserID</td>
                    <td>
                        <asp:TextBox ID="txtUserID" runat="server" Width="258px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" Width="255px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Role</td>
                    <td>
                        <asp:TextBox ID="txtRole" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>

<!- Buttons for communicating with database ->
                    <td>
                        &nbsp;<asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /></td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
