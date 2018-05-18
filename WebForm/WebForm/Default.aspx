<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%-- I Live in:
            <%: GetCity() %>--%>
            Here are some cities:
            <hr />
            <asp:Literal Text="<%$ AppSettings:cityMessage %>" runat="server"></asp:Literal>
            <hr />
            <span id="mySpan" name="mySpan" runat="server"></span>
            <hr />
            <span>Today is : <%: GetDayOfWeek() %></span>
            <ul>
                <asp:Repeater ItemType="System.String" SelectMethod="GetCity" runat="server">
                    <ItemTemplate>
                        <li>
                            <%# Item %>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
    </form>
</body>
</html>
