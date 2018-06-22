<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Out.aspx.cs" Inherits="Routing.Out" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                This is the out.aspx WebForm
            </p>
        </div>
        <a href="<%: GenerateURL() %>">Link to Other Web Form</a>
    </form>
</body>
</html>
