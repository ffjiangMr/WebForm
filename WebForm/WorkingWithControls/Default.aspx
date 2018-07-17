<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WorkingWithControls.Default" %>

<%@ Register TagPrefix="CC" TagName="UCButton" Src="~/ButtonCountUserControl.ascx" %>
<%@ Register TagPrefix="SC" Assembly="WorkingWithControls"  Namespace="WorkingWithControls" %>
 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Button presses :<span id="counter" runat="server"></span>
        </div>
        <div>
            <button type="submit">Submit</button>
        </div>
        <CC:UCButton ID="userControl" runat="server"></CC:UCButton>
        <SC:ButtonCountServerControl ID="serverControl" runat="server"></SC:ButtonCountServerControl>
    </form>
</body>
</html>
