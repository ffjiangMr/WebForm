<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HtmlTable.aspx.cs" Inherits="ServerSiteHtml.HtmlTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table {
            border: thin solid black;
            border-spacing: 0px;
            border-collapse: separate;
            font-family:Monospaced Number,Chinese Quote,-apple-system,BlinkMacSystemFont,Segoe UI,Roboto,PingFang SC,Hiragino Sans GB,Microsoft YaHei,Helvetica Neue,Helvetica,Arial,sans-serif;
        }

        tr {
            border: 0px solid black;
        }

        td, th {
            border: 1px solid black;
            font-size:10px;
        }

        th {
            font-weight: normal;          
        }

        thead > tr {
            border: solid thin black;
        }

        td:last-child, th:last-child {
            text-align: right;
        }

        span {
            font: normal;
        }

        div {
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table id="colorTable" runat="server">
                <thead>
                    <tr>
                        <th><span>Color</span></th>
                        <th><span>Count</span></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Red</td>
                        <td>2</td>
                    </tr>
                    <tr>
                        <td>Green</td>
                        <td>41</td>
                    </tr>
                    <tr>
                        <td>Blue</td>
                        <td>3</td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr>
                        <th>Total:</th>
                        <th>46</th>
                    </tr>
                </tfoot>
            </table>
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
