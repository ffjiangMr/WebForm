<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductTest.aspx.cs" Inherits="ClientDev.ProductTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {
            margin-bottom: 10px;
        }
    </style>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        function GetObjectString(dataObject) {
            if (typeof dataObject == "string") {
                return dataObject;
            }
            else {
                var message = "";
                for (var prop in dataObject) {
                    message += prop + ": " + dataObject[prop] + "\n";
                }
                return message;
            }
        }
        $(document).ready(function () {
            $(":input").click(function (e) {
                var action = $(e.target).attr("data-action");
                $.ajax({
                    url: action == "all" ? "/api/product" : "/api/product/1",
                    type: "GEt",
                    dataType: "json",
                    success: function (data) {
                        if (Array.isArray(data)) {
                            var message = "";
                            for (var i = 0; i < data.length; i++) {
                                message += "Item " + [i] + "\n" + GetObjectString(data[i]) + "\r\n";
                            }
                            $("#results").text(message);
                        }
                        else {
                            $("#results").text(GetObjectString(data));
                        }
                    }
                });
                e.preventDefault();
            });
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" data-action="all" value="GetAll"/>
            <input type="button"  data-action="one" value="GetOne"/>
        </div>
        <textarea id="results" cols="40" rows="10"></textarea>
    </form>
</body>
</html>
