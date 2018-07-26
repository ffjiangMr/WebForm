<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Counter.ascx.cs" Inherits="ControlState.Custom.Counter" %>
<%--<input type="hidden" name="<%= GetId("left") %>" value="<%= LeftValue %>" />
<input type="hidden" name="<%= GetId("right") %>" value="<%= RightValue %>" />--%>
<div>Left Counter: <%= LeftValue %></div>
<div>Right Counter: <%= RightValue %></div>
<div>
    <button name="<%= GetId("button") %>" value="<%= GetId("left") %>">Left</button>
    <button name="<%= GetId("button") %>" value="<%= GetId("right") %>">Right</button>
</div>
