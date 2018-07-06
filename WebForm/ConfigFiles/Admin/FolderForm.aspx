<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FolderForm.aspx.cs" Inherits="ConfigFiles.Admin.FolderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h3>This is /Admin/FolderForm.aspx </h3>
    <ul>
        <asp:Repeater ID="config" SelectMethod="GetConfig" ItemType="System.String" runat="server">
            <ItemTemplate>
                <li><%# Item %></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
