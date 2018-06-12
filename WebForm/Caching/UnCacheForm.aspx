<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnCacheForm.aspx.cs" Inherits="Caching.UnCacheForm" %>
<%@ Register TagPrefix="CC" TagName="Time" Src="~/CurrentTime.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        div.panle {
        margin:5px;
        padding:5px;
        border:thin solid black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="panle">
            <CC:Time ID="timeControl" runat="server" />
        </div>
        <div class="panle">
            Requested at :<%: DateTime.Now.ToLongTimeString() %>
        </div>
    </form>
</body>
</html>
