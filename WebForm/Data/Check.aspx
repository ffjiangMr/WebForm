<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Check.aspx.cs" Inherits="Data.Check" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        div {
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="cbl" AppendDataBoundItems="true" SelectMethod="GetProducts" runat="server" RepeatDirection="Vertical" RepeatLayout="OrderedList">
                <asp:ListItem Text="All" Selected="True">
                </asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div>
            Selection&nbsp<b>:</b>&nbsp<span id="selection" runat="server"></span>
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
