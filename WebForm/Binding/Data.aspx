<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="Binding.Data" %>

<!DOCTYPE html>
<%@ Register TagPrefix="CS" Assembly="Binding" Namespace="Binding.Controls" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="max" value="5" runat="server" />
            <CS:OperationSelector id="opSelector" runat="server"></CS:OperationSelector>
            <button type="submit">Generate</button>
        </div>
        <div>
            <asp:Repeater SelectMethod="GetData" ItemType="System.String" runat="server" ViewStateMode="Disabled">
                <ItemTemplate>
                    <P><%# Item %></P>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
