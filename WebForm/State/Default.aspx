<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="State.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        .nameContainer {
        margin:10px 0;
        }
        input {
        margin-right:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This page has been display <%: GetCounter() %> time(s) for user and <%: GetSessionCounter() %> time(s) for this session.
        </div>
        <div class="nameContainer"> 
            <input id="requestedUser" value="Joe" runat="server" />
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
