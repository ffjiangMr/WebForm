﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Price.aspx.cs" Inherits="WebForm.Price" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>Today's data is <%: DateTime.Now.ToShortDateString() %></p>
    <p>A new shirt costs <%: 20.ToString("c") %></p>
</body>
</html>
