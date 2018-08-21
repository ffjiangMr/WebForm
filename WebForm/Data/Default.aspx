<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Data.Default" %>

<%@ Register Assembly="Data" Namespace="Data.Controls" TagPrefix="CS" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {
            margin-bottom: 10px;
        }

        th, td {
            text-align: left;
        }

        td {
            padding-bottom: 5px;
        }

        th, table {
            border-bottom: solid thin black;
        }

            th:last-child, td:last-child {
                text-align: right;
            }

        body {
            font-family: "Arial Narrow",sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Category</th>
                        <th>Price</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater SelectMethod="GetProductData" ItemType="Data.Models.Product" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#: Item.Name %></td>
                                <td><%#: Item.Category %></td>
                                <td><%#: Item.Price.ToString("F2") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
        <div>
            Filter &nbsp<b>:</b>&nbsp 
            <CS:DataSelect ID="dSelect" ItemType="Data.Models.Product" SelectMethod="GetCategories" runat="server">
                <itemtemplate>
                    <option <%# Container.GenerateSelect(Item.Category) %>>
                        <%#: Item.Category %>
                    </option>
                </itemtemplate>
            </CS:DataSelect>
            <%-- <CS:DataSelect ID="dSelect" runat="server" SelectMethod="GetCategories" />--%>
            <%-- <asp:DropDownList ID="ddList" SelectMethod="GetCategories" runat="server" ItemType="System.String">
            </asp:DropDownList>--%>
            <%-- <select name="filterSelect">
                <asp:Repeater SelectMethod="GetCategories" runat="server" ItemType="Data.CategoryView">
                    <ItemTemplate>
                        <option <%#: Item.Selected %>>
                            <%#: Item.Name %>
                        </option>
                    </ItemTemplate>
                </asp:Repeater>
            </select>--%>
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
