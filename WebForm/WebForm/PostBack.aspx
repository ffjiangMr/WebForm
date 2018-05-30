<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBack.aspx.cs" Inherits="WebForm.PostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:PlaceHolder ID="firstPH" runat="server">
            <div>
                <input id="firstNumber" runat="server" />
                <input id="secondNumber" runat="server" />
            </div>
            <button type="submit">Calculate</button>
        </asp:PlaceHolder>
        <asp:PlaceHolder ID="secondPH" runat="server">
            <p>The total is <span id="result" runat="server"></span></p>
        </asp:PlaceHolder>
    </form>
</body>
</html>
