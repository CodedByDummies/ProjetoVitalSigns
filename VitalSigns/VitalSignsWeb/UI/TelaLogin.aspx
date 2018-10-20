<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelaLogin.aspx.cs" Inherits="VitalSignsWeb.UI.TelaLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <style type="text/css">
        #form1 {
            height: 175px;
            margin-left: 174px;
            margin-right: 203px;
            margin-top: 54px;
            font-family: Arial, Helvetica, sans-serif; 
        }
    </style>
</head>
<body style="width: 826px; margin-left: 326px; margin-top: 102px; margin-bottom: 318px">
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="102px" ImageAlign="TextTop" style="margin-left: 124px; margin-top: 0px; margin-bottom: 0px;" Width="150px" ImageUrl="~/Resouces/1.gif" />
        <div>
            <asp:Label ID="lblLogin" runat="server" Text="Login:"></asp:Label>
            <asp:TextBox ID="txtLogin" runat="server" Height="16px" Width="275px" style="margin-left: 24px; margin-top: 18px; margin-bottom: 0px;" OnTextChanged="txtLogin_TextChanged"></asp:TextBox>
            <p /><asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server" style="margin-left: 16px; margin-top: 0px; margin-bottom: 0px; margin-right: 1px;" Width="274px"></asp:TextBox>
        
            </div>
        
        <asp:Button ID="txtEntrar" runat="server" style="margin-left: 70px; margin-top: 0px; margin-bottom: 0px" Text="Entrar" OnClick="btnEntrar" />
        <asp:HyperLink ID="HyperLink1" runat="server">Esqueceu a senha?</asp:HyperLink>
        
    </form>
</body>
</html>
