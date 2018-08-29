<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Drop.aspx.cs" Inherits="Data.Drop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="Styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="drop" runat="server" SelectMethod="GetProducts" AppendDataBoundItems="true">
                <asp:ListItem Selected="True" Text="All"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            Select&nbsp:&nbsp<span id="selection" runat="server"></span>
        </div>
        <div>
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
