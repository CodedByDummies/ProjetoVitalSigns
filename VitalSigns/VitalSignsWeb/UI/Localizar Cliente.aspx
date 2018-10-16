<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Localizar Cliente.aspx.cs" Inherits="VitalSignsWeb.UI.Localizar_Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Localizar Cliente</title>
    <style type="text/css">
        #form1 {
            width: 798px;
            margin-left: 0px;
        }
    </style>
</head>
<body style="width: 818px; margin-left: 45px; margin-right: 326px; margin-bottom: 318px; height: 445px;">
    <form id="form1" runat="server">
        <div style="width: 798px" margin-top: 10px;>
            <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 5px; margin-top: 0px; margin-bottom: 0px;" Height="20px" Width="155px" AutoPostBack="True" ></asp:DropDownList>
            <asp:TextBox ID="TextBox1" runat="server" Width="529px" style="margin-left: 5px; margin-top: 0px; margin-bottom: 0px;" Height="16px" ></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Localizar" style="margin-left: 5px;" Width="80px"/>
            <br />
            <asp:GridView ID="GridView1" runat="server" Height="169px" Width="782px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-top: 20px; margin-left: 5px;">
        </asp:GridView>
        </div>
    </form>
</body>
</html>
