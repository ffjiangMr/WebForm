<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RequestControl.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
            <h3>This is Default.aspx
            </h3>
            <div>
                <label for="redirect302">
                    <input type="radio" name="choice" value="redirect302" checked="checked" id="redirect302" />
                    Redirect                  
                </label>
            </div>
            <div>
                <input type="radio" name="choice" value="remaphandler" />Remap Handler
            </div>
            <div>
                <input type="radio" name="choice" value="transferpage" />Transfer Page
            </div>
            <div>
                <input type="radio" name="choice" value="execute" />Execute Page
            </div>
            <p>
                <button type="submit">Submit</button>
            </p>
        </div>
    </form>
</body>
</html>
