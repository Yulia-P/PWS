<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddsPage.aspx.cs" Inherits="solution.AddsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="https://code.jquery.com/jquery-3.6.1.js" integrity="sha256-3zlB5s2uwoUzrXK3BT7AX3FyvojsraNFxCc2vC/7pNI=" crossorigin="anonymous"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                    <input type="text" id="x"/>
                    <input type="text" id="y"/>
                    <input type="button" onclick="getSum_Ajax()" value="ajax" />
                </div>
                <div>
                    <input type="text" id="result"/>
                </div>
        </div>
    </form>
    <script>
        function getSum_Ajax() {
            const data = {
                x: parseInt($("#x").val()),
                y: parseInt($("#y").val())
            };
            $.ajax({
                url: "Simplex.asmx/adds",
                type: "GET",
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                data: data,
                success: result => {
                    $("#result").val(result.d);
                },
                error: error => {
                    console.log(error);
                }
            })
        }
    </script>
</body>
</html>

