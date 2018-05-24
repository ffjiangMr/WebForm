<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListModules.aspx.cs" Inherits="WebForm.ListModules" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th, td {
            border-bottom: thin,solid,black;
            text-align: left;
            padding: 3px;
        }

            td span {
                display: inline-block;
                text-overflow: ellipsis;
                overflow: hidden;
                white-space: nowrap;
                width: 300px;
            }

        table {
            border-collapse: collapse;
        }
    </style>
</head>
<body>
    <div>
        <table>
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Type
                </th>
            </tr>
            <asp:Repeater ID="Repeater1" SelectMethod="GetModules" ItemType="WebForm.ModuleDescription" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><span><%# Item.Name %></span></td>
                        <td><span><%# Item.TypeName %></span></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</body>
</html>
