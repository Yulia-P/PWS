<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PAdd.aspx.cs" Inherits="ShowBrowser.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:TextBox runat="server" ID="x" placeholder="int"/>
            <asp:TextBox runat="server" ID="y" placeholder="int"/>
            <asp:Button runat="server" ID="Add" OnClick="add_Click" Text="Result" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="result" placeholder="Add" ReadOnly="True"/>
        </div>
    </form>
</body>
</html>
