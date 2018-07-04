<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ManagingUsers.Account.Register" %>

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
            margin-bottom: 5px;
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
        <h3>Create Account</h3>
        <asp:PlaceHolder ID="error" Visible="false" runat="server">
            <span id="message" class="error" runat="server"></span>
        </asp:PlaceHolder>
        <div>
            <label for="user">UserName:</label>
            <input id="user" name="user" />
        </div>
        <div>
            <label for="email">Email:</label>
            <input id="email" name="email" />
        </div>
        <div>
            <label for="pass">Password:</label>
            <input id="pass" name="pass" type="password" />
        </div>
        <div>
            <label for="question">Recovery Question:</label>
            <select id="question" name="question">
                <option>What month were you born?</option>
                <option>What is your favorite color?</option>
                <option>What was your first pet's name?</option>
            </select>
        </div>
        <div>
            <label for="answer">Answer:</label>
            <input id="answer" name="answer" />
        </div>
        <div>
            <button type="submit">Create Account</button>
        </div>
    </form>
</body>
</html>
