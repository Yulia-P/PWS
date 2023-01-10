<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PConcat.aspx.cs" Inherits="ShowBrowser.PConcat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="s" placeholder="string"/>
            <asp:TextBox runat="server" ID="d" placeholder="double"/>
            <asp:Button runat="server" ID="concat" OnClick="concat_Click" Text="Result" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="result" placeholder="Concat" ReadOnly="True"/>
        </div>
    </form>
</body>
</html>
