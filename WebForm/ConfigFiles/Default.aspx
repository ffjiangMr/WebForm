<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConfigFiles.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <ul>
        <asp:Repeater SelectMethod="GetConfig" ItemType="System.String" runat="server">
            <ItemTemplate>
                <li>
                    <%# Item %>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</body>
</html>
