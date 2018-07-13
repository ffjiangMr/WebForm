<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AsyncApp.Default" Async="true" AsyncTimeout="60" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table {
            border: thin solid black;
            border-collapse: collapse;
        }

        th, td {
            text-align: left;
            padding: 5px;
            border: thin solid black;
        }
    </style>
</head>
<body>
    <table>
        <tr>
            <th>URL</th>
            <th>Length</th>
            <th>Blocked Duration</th>
            <th>Total Duration</th>
        </tr>
        <tr>
            <td><%: GetResult().Url %></td>
            <td><%: GetResult().Length %></td>
            <td><%: GetResult().Blocked %></td>
            <td><%: GetResult().Total %></td>
        </tr>
    </table>
</body>
</html>
