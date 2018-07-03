<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ManagingUsers.Account.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div.details {
            margin-bottom: 20px;
        }

        div {
            margin-top: 5px;
        }

        label {
            width: 90px;
            display: inline-block;
        }

        button {
            margin: 10px 10px 0 0;
        }
        span.error {
        color:red;
        border:solid double red;
        visibility:collapse;
        }
    </style>
</head>
<body>
    <div class="details">
        The requst is authenticated :<%: GetRequestStatus() %>
    </div>
    <div class="details">The current user is :<%: GetUser() %></div>
    <form id="form1" runat="server">
        <span class="error" id="message" runat="server">
            Incorect username or password try again.
        </span>
        <div>
            <label for="user">User:</label>
            <input id="user" name="user" />
        </div>
        <div>
            <label for="password">Password:</label>
            <input id="password" name="password" type="password" />
            <div>
                <button name="action" value="login" type="submit">Log In</button>
                <button name="action" value="logout" type="submit">Log Out</button>
            </div>
        </div>
    </form>
</body>
</html>
