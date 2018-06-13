<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SharedControl.aspx.cs" Inherits="Caching.SharedControl" %>

<%@ Register TagPrefix="CC" TagName="Time" Src="~/CurrentTime.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <CC:Time ID="timeControl" runat="server" />
        </div>
    </form>
</body>
</html>
