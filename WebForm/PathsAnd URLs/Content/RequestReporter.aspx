<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestReporter.aspx.cs" Inherits="PathsAnd_URLs.Content.RequestReporter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>Original virtual path:<%: Request.FilePath %></p>
    <p>Original physical path:<%: Request.PhysicalPath %></p>
    <p>Current virtual path:<%: Request.CurrentExecutionFilePath %></p>
    <p>Current physical path:<%: Request.MapPath(Request.CurrentExecutionFilePath) %></p>
</body>
</html>
