<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BasicCacl.ascx.cs" Inherits="Controls.Custom.BasicCacl" %>
<%@ Import Namespace="Controls.Custom" %>
This is the BasicCacl control
<hr />
<div>
    <input name="<%= GetId("initialVal") %>" value="<%= Initial %>" />
    <asp:Repeater ID="calcRepeater" runat="server" EnableViewState="false" ItemType="Controls.Custom.Calculation" SelectMethod="GetCalculations">
        <ItemTemplate>
            <%# Item.Operation == OperationType.PLUS? "+":"-" %>
            <input name="<%= GetId("caclValue") %>" value="<%# Item.Value %>" />
            <input type="hidden" name="<%= GetId("calcOp") %>" value="<%# Item.Operation %>" />
        </ItemTemplate>
    </asp:Repeater>
    <button type="submit">=</button>
    <span id="result" runat="server"></span>
</div>
<%--<script src="../Scripts/jquery-3.3.1.js"></script>
<script>
    $(document).ready(function () {
        var id = '<%= GetId("first") %>';
        $('#' + id).focus().select();
    });
</script>
<input id="<%= GetId("first") %>" name="<%= GetId("firstNumber") %>" value="<%= FirstValue %>" />
<%= Operation == OperationType.PLUS ? '+' : '-' %>
<input name="<%= GetId("secondNumber") %>" value="<%= SecondValue %>" />
<button type="submit">=</button>
<span id="result" runat="server"></span>--%>