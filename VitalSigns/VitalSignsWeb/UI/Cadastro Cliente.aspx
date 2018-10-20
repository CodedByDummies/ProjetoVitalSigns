<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro Cliente.aspx.cs" Inherits="VitalSignsWeb.UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="width: 826px; margin-left: 326px; margin-top: 102px; margin-bottom: 318px; height: 465px;">
    <form id="form1" runat="server">
        <div style="height: 359px; width: 627px;" >
            <asp:Panel ID="Panel1" runat="server" Height="353px">
            <asp:Label ID="lblNome" runat="server" Text="Nome" style="margin-left: 4px"></asp:Label>
            <br />
            <asp:TextBox ID="txtNomeCadastro" runat="server" Width="609px" style="margin-left: 4px; margin-right: 4px"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="lblCpfCnpjCadastro" runat="server" Text="CPF/CNPJ" style="margin-left: 4px"></asp:Label>
            <asp:Label ID="lblEmail" runat="server" Text="E-mail" style="margin-left: 165px"></asp:Label>
            <br />
            <asp:TextBox ID="txtCpfCnpjCadastro" runat="server" Width="229px" style="margin-left: 4px"></asp:TextBox>
            <asp:TextBox ID="txtEmailCadastro" runat="server" Width="373px"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="lblDddTel" runat="server" Text="DDD" style="margin-left: 4px"></asp:Label>
            <asp:Label ID="lblTelefone" runat="server" Text="Telefone" style="margin-left: 20px"></asp:Label>
            <asp:Label ID="lblDddCel" runat="server" Text="DDD" style="margin-left: 195px"></asp:Label>
            <asp:Label ID="lblCelular" runat="server" Text="Celular" style="margin-left: 20px"></asp:Label>
            <br />
            <asp:TextBox ID="txtDddTelCadastro" runat="server" Width="51px" style="margin-left:4px"></asp:TextBox>
            <asp:TextBox ID="txtTelCadastro" runat="server" Width="240px"></asp:TextBox>
            <asp:TextBox ID="txtDddCelCadastro" runat="server" Width="51px" style="margin-left:4px"></asp:TextBox>
            <asp:TextBox ID="txtCelCadastro" runat="server" Width="240px"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblLougradouro" runat="server" Text="Lougradouro" style="margin-left: 4px"></asp:Label>
            <asp:Label ID="lblNumero" runat="server" Text="Número" style="margin-left: 174px"></asp:Label>
            <asp:Label ID="lblComplemento" runat="server" Text="Complemento" style="margin-left: 9px"></asp:Label>
            <Br />
            <asp:TextBox ID="txtLougraCadastro" runat="server" Width="248px" style="margin-left:4px"></asp:TextBox>
            <asp:TextBox ID="txtNumCadastro" runat="server" Width="51px" style="margin-left:4px"></asp:TextBox>
            <asp:TextBox ID="txtCompleCadastro" runat="server" Width="287px" style="margin-left:4px"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="lblCep" runat="server" Text="CEP" style="margin-left: 4px"></asp:Label>
            <asp:Label ID="lblBairro" runat="server" Text="Bairro" style="margin-left: 136px"></asp:Label>
            <br />
            <asp:TextBox ID="txtCepCadastro" runat="server" Width="162px" style="margin-left:4px"></asp:TextBox>
            <asp:TextBox ID="txtBairroCadastro" runat="server" Width="440px" style="margin-left:px"></asp:TextBox>
            <br />
            
            <br />
            <asp:Label ID="lblCidade" runat="server" Text="Cidade" style="margin-left: 4px"></asp:Label>
            <asp:Label ID="lblEstado" runat="server" Text="Estado" style="margin-left: 252px"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlCidadeCasdtro" runat="server" Width="297px" style="margin-left:4px"></asp:DropDownList>
            <asp:DropDownList ID="ddlEstadoCadastro" runat="server" Width="313px" style="margin-left:1px"></asp:DropDownList>
            </asp:Panel>


        </div>
    </form>
</body>
</html>
