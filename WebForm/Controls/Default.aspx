<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Controls.Default" %>

<%--<%@ Register TagPrefix="CC" TagName="Cacl" Src="~/Custom/BasicCacl.ascx" %>--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        input {
            width: 100px;
        }

        div {
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <%--<div>
            <input name="firstNumber" value="10" />+
            <input name="secondNumber" value="31" />
            <button type="submit">=</button>
            <span id="result" runat="server"></span>
        </div>--%>
      <%--  <div>
            <CC:Cacl ID="Calc" initial="100" runat="server">
                <Calculations>
                    <CC:Calculation operation="PLUS" value="10"></CC:Calculation>
                    <CC:Calculation operation="MINU" value="20"></CC:Calculation>
                </Calculations>
            </CC:Cacl>
            <CC:Cacl ID="Cacl" runat="server" FirstValue="100" SecondValue="5" Operation="MINU"></CC:Cacl>
        </div>--%>
        <div>
            <CC:ServerCalc Initial="100" runat="server">
                <Calculations>
                    <CC:Calculation operation="PLUS" value="10">
                    </CC:Calculation>
                    <CC:Calculation operation="MINU" value="20">
                    </CC:Calculation>
                </Calculations>
            </CC:ServerCalc>
        </div>
    </form>
</body>
</html>
