<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Colors.aspx.cs" Inherits="WorkingWithControls.Colors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #buttonTarget > input {
            margin: 10px 5px 0 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id ="buttonTarget" runat="server"></div>
        </div>
    </form>
</body>
</html>
