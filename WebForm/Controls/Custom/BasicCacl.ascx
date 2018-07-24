<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BasicCacl.ascx.cs" Inherits="Controls.Custom.BasicCacl" %>
This is the BasicCacl control
<input name="<%= GetId("firstNumber") %>" value="10" />
<input name="<%= GetId("secondNumber") %>" value="31" />
<button type="submit">=</button>
<span id="result" runat="server"></span>