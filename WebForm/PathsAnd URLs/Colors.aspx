<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Colors.aspx.cs" Inherits="PathsAnd_URLs.Colors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    The colors are:
    <ol>
        <asp:Repeater ItemType="System.String" SelectMethod="GetColors" runat="server">
            <ItemTemplate>
                <li><%# Item %></li>
            </ItemTemplate>
        </asp:Repeater>
    </ol>
</body>
</html>
