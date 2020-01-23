<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logon.aspx.cs" Inherits="Controle_Veiculos_Web.Views.Logon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/Css/w3.css" rel="stylesheet" />
</head>
<body>
    <div class="w3-light-gray" style="width: 40%; height: 40%; margin-top: 20%; margin-left: 20%;">
        <div class="w3-row w3-padding-32">
            <div class="w3-half w3-container">
                <img src="../Imagem/Person.png" class="w3-round" alt="Norway"/>
            </div>
            <div class="w3-half w3-container">
                <form id="form1" runat="server">
                    <div class="w3-row">
                        <div class="w3-third w3-container">
                            <div class="">Login:</div>
                        </div>
                        <div class="w3-twothird w3-container">
                            <asp:TextBox ID="EDITLOGIN" runat="server" class="w3-input w3-border"></asp:TextBox>
                        </div>
                    </div>
                    <div class="w3-row">
                        <div class="w3-third w3-container">
                            <div class="">Senha:</div>
                        </div>
                        <div class="w3-twothird w3-container">
                            <asp:TextBox ID="EDITSENHA" runat="server" class="w3-input w3-border" type="password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="w3-row">
                        <div class="w3-half w3-container" style="padding-left: 0;">
                            <asp:Button ID="Button1" runat="server" Text="Entrar" OnClick="Button1_Click" class="w3-button w3-light-gray w3-border" />
                        </div>
                        <div class="w3-half w3-container">
                            <asp:Button ID="Button2" runat="server" Text="Sair" OnClick="Button1_Click" class="w3-button w3-light-gray w3-border" />
                        </div>
                    </div>
                    <div class="w3-center">
                        <asp:Button ID="Button3" runat="server" Text="Cadastre - se" OnClick="Button1_Click" class="w3-button w3-light-gray w3-border" />
                    </div>
            </div>


            </form>
        </div>
    </div>
    </div>
</body>
</html>
