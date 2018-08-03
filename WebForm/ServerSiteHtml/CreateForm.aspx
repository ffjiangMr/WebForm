<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateForm.aspx.cs" Inherits="ServerSiteHtml.CreateForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        div {
            margin: 10px;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="nameDiv" runat="server">Name:
        </div>
        <div id="passDiv" runat="server">Password:</div>
        <div id="hiddenAndButtonDiv" runat="server"></div>
    </form>
</body>
</html>
