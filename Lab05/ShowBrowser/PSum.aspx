<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PSum.aspx.cs" Inherits="ShowBrowser.PSum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<%--            <label for="x_obj">first params</label>--%>
            <p id="x_obj">
                <asp:TextBox runat="server" ID="x_s" placeholder="string"/>
                <asp:TextBox runat="server" ID="x_k" placeholder="int"/>
                <asp:TextBox runat="server" ID="x_f" placeholder="float"/>
            </p>

            <%--<label for="y_obj">second params</label>--%>
            <p id="y_obj">
                <asp:TextBox runat="server" ID="y_s" placeholder="string"/>
                <asp:TextBox runat="server" ID="y_k" placeholder="int"/>
                <asp:TextBox runat="server" ID="y_f" placeholder="float"/>
            </p>

            <asp:Button runat="server" ID="get_sum" OnClick="sum_Click" Text="Result" />
        </div>
        <div>
            <p id="res_obj">
                <asp:TextBox runat="server" ID="result_s" placeholder="Sum" ReadOnly="True"/>
                <asp:TextBox runat="server" ID="result_k" placeholder="Sum" ReadOnly="True"/>
                <asp:TextBox runat="server" ID="result_f" placeholder="Sum" ReadOnly="True"/>
            </p>
        </div>
    </form>
</body>
</html>
