﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormData.aspx.cs" Inherits="WorkingWithForms.FormData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {
            margin-top: 10px;
        }

            div.float {
                float: left;
                margin: 10px;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class=" float">

            <div>
                Input element:
                <input name="regularInput" value="Green" />
            </div>
            <div>
                Pick a color:
                <select name="color">
                    <option>Red</option>
                    <option>Greent</option>
                    <option>Blue</option>
                </select>
            </div>
            <div>
                Do you agree to the terms?
                <input type="radio" name="city" value="London" checked="checked" />London
                <input type="radio" name="ciity" value="New York" title="New York" />New York
            </div>
            <div>
                <button type="submit" name="button" value="Button 1">Button 1</button>
                <input type="submit" name="button" value="Button 2" />
            </div>
        </div>
        <div class=" float">
            <div>
                Results:
                <ul>
                    <asp:Repeater ItemType="WorkingWithForms.FormKeyValuePair" SelectMethod="GetFormData" runat="server">
                        <ItemTemplate>
                            <li><%# Item.Key %> = <%# Item.Value %></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
        </div>
    </form>
</body>
</html>
