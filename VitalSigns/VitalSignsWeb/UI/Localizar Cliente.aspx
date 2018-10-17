<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Localizar Cliente.aspx.cs" Inherits="VitalSignsWeb.UI.Localizar_Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Localizar Cliente</title>
    <style type="text/css">
        #form1 {
            margin-top: 102px;
            width: 798px;
            margin-left: 174px;
        }
    </style>
</head>
<body style="width: 1129px; margin-left: 45px; margin-right: 326px; margin-bottom: 318px; height: 504px;">
    <form id="form1" runat="server">
        <div style="width: 798px; margin-left: 0px;" margin-top: 10px;>
            <asp:DropDownList ID="ddlPesquisa" runat="server" style="margin-left: 5px; margin-top: 0px; margin-bottom: 0px;" Height="20px" Width="155px" AutoPostBack="True" ></asp:DropDownList>
            <asp:TextBox ID="txtLocalizadorCliente" runat="server" Width="529px" style="margin-left: 5px; margin-top: 0px; margin-bottom: 0px;" Height="16px" ></asp:TextBox>
            <asp:Button ID="btnLocalizar" runat="server" Text="Localizar" style="margin-left: 5px;" Width="80px"/>
            <asp:GridView ID="gwViewChamado" runat="server" Height="277px" Width="782px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-top: 20px; margin-left: 5px;"></asp:GridView>
            <asp:Button ID="btnCriarPerfil" runat="server" Text="Criar Perfil" style="margin-left: 5px; margin-top: 20px;" Height="24px" Width="150px"/>
            <asp:Button ID="btnNovoChamado" runat="server" Text="Novo Chamado" style="margin-left: 480px; margin-right: 0px;" Height="24px" Width="150px"/>
        </div>
    </form>
</body>
</html>
    