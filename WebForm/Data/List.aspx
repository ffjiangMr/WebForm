<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Data.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="Styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="list" SelectMethod="GetProducts" runat="server" AppendDataBoundItems="true" SelectionMode="Multiple">
                <asp:ListItem Selected="True" Text="All">

                </asp:ListItem>
            </asp:ListBox>
        </div>
        <div>
            Selection&nbsp:&nbsp<span id="selection" runat="server"></span>
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
