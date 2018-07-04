<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Change.aspx.cs" Inherits="ManagingUsers.Account.Change" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {
            margin-bottom: 20px;
        }

        label {
            display: inline-block;
            margin-right: 5px;
            width: 150px;
        }

        span.error {
            color: red;
            margin-bottom: 10px;
            display: block;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <h3>Change Password
        </h3>
        <asp:PlaceHolder ID="error" Visible="false" runat="server">
            <span class="error" id="message" runat="server"></span>
        </asp:PlaceHolder>
        <asp:PlaceHolder ID="usernamePh" runat="server" Visible="true">
            <div>
                <label for="user">Username:</label>
                <input id="user" name="user" runat="server" />
            </div>
        </asp:PlaceHolder>
        <asp:PlaceHolder ID="oldpasswordPh" runat="server" Visible="true">
            <div>
                <label for="oldpass">Old Password:</label>
                <input id="oldpass" name="oldpass" type="password" runat="server" />
            </div>
        </asp:PlaceHolder>
        <div>
            <label for="newpass1">New Password:</label>
            <input id="newpass1" name="newpass1" type="password" runat="server" />
        </div>
        <div>
            <label for="newpass2">New Password (again):</label>
            <input id="newpass2" name="newpass2" type="password" runat="server" />
        </div>
        <div>
            <input type="submit" value="Change Password" />
        </div>
    </form>
</body>
</html>
