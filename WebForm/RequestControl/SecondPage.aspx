﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondPage.aspx.cs" Inherits="RequestControl.SecondPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is SecondPage.aspx
            <p>Handle:<%: Context.Handler %></p>
            <p>Current Handler<%: Context.CurrentHandler %></p>
            <p>PreviewHandler:<%: Context.PreviousHandler %></p>
        </div>
    </form>
</body>
</html>
