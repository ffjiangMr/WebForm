<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Count.aspx.cs" Inherits="PathsAnd_URLs.Count" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    The numbers are:
    <ul>
        <asp:Repeater ItemType="System.Int32" SelectMethod="GetNumbers" runat="server">
            <ItemTemplate>
                <li>
                    <%# Item %>
                </li>
            </ItemTemplate>

        </asp:Repeater>
    </ul>
</body>
</html>
