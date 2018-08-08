<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Binding.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        label {
            display: inline-block;
            width: 120px;
            text-align: right;
            margin: 5px;
        }

        div.panel {
            float: left;
            margin-left: 10px;
        }

            div.panel label {
                text-align: right;
            }

        div.error {
            color: red;
            width: 100%;
        }
    </style>
</head>
<body>


    <form id="form1" runat="server" style="float: left;">
          <div id="panel error">
            <asp:ValidationSummary CssClass="error" runat="server" HeaderText="There are problems with the data you entered:" />
        </div>
       <%-- <asp:PlaceHolder ID="errorPanel" Visible="false" runat="server">
            <div class="error panel">
                There are problems with the data you enter:
            <ul>
                <asp:Repeater SelectMethod="GetModelValidationErrors" ViewStateMode="Disabled" ItemType="System.String" runat="server">
                    <ItemTemplate>
                        <li>
                            <%# Item %>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
            </div>
        </asp:PlaceHolder>--%>
        <div class="panel">
            <div>
                <label for="name">Your name:</label>
                <input id="name" name="name" runat="server" />
            </div>
            <div>
                <label for="age">Your age:</label>
                <input id="age" name="age" runat="server" />
            </div>
            <div>
                <label for="cell">Your cell no:</label>
                <input id="cell" name="cell" runat="server" />
            </div>
            <div>
                <label for="zip">Your zip code:</label>
                <input id="zip" name="zip" runat="server" />
            </div>
            <button type="submit">Submit</button>
        </div>
        <div class="panel">
            <div>
                <label for="sname">Your name:</label>
                <span id="sname" name="sname" runat="server" />
            </div>
            <div>
                <label for="sage">Your age:</label>
                <span id="sage" name="sage" runat="server" />
            </div>
            <div>
                <label for="scell">Your cell no:</label>
                <span id="scell" name="scell" runat="server"></span>
            </div>
            <div>
                <label for="szip">Your zip code:</label>
                <span id="szip" name="szip" runat="server"></span>
            </div>
        </div>
    </form>

</body>
</html>
