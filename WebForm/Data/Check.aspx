<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Check.aspx.cs" Inherits="Data.Check" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        div {
            margin-bottom: 10px;
        }
    </style>
    <link href="Styles.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        var IDs = {
            controlSelector: "#<%= cbl.ClientID%> input",
            allInputID: "<%= cbl.ClientID %>_0",
            allInputSelector: "#<%= cbl.ClientID%>_0",
        };
        $(function () {
            $(IDs.controlSelector).change(function (e) {
                var selection = (e.target.id == IDs.allInputID) ?
                    $(IDs.controlSelector).not(IDs.allInputSelector).attr("checked", false) :
                    $(IDs.allInputSelector).attr("checked", false);
                //selection.attr("checked", false);
            });
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="cbl" AppendDataBoundItems="true" RepeatColumns="3" SelectMethod="GetProducts" runat="server">
                <asp:ListItem Text="All" Selected="True">
                </asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div>
            Selection&nbsp<b>:</b>&nbsp<span id="selection" runat="server"></span>
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
