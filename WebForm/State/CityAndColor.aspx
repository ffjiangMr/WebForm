<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityAndColor.aspx.cs" Inherits="State.CityAndColor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div.section {
            margin: 10px 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="section">
            Select a color
            <asp:DropDownList ID="colorSelect" ItemType="System.String" SelectMethod="GetColors" runat="server">
            </asp:DropDownList>
        </div>
        <div class="section">
            Select a city
            <asp:DropDownList ID="citySelect" ItemType="System.String" SelectMethod="GetCities" runat="server">
            </asp:DropDownList>
        </div>
        <div class="section">
            <button type="submit">Sbumit</button>
        </div>
    </form>
</body>
</html>
