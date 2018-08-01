<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimlpeState.aspx.cs" Inherits="ControlState.SimlpeState" EnableViewState="true" ViewStateEncryptionMode="Auto" ViewStateMode="Enabled" EnableViewStateMac="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <CC:SimpleTime runat="server"></CC:SimpleTime>
            <div>View State works:<%= ViewStateWorks %></div>
            <div>Control state works:<%= ControlStateWorks %></div>
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
