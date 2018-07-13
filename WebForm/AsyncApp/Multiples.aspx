<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Multiples.aspx.cs" Inherits="AsyncApp.Multiples" Async="true" AsyncTimeout="600" %>

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
            <th>Start Time</th>
            <th>URL</th>
            <th>Length</th>
        </tr>
        <asp:Repeater SelectMethod="GetResults" ID="rep" ItemType="AsyncApp.MultiWebSiteResult" runat="server">
            <ItemTemplate>
                <tr>
                    <th><%# Item.StartTime %></th>
                    <th><%# Item.Url %></th>
                    <th><%# Item.Length %></th>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</body>
</html>
