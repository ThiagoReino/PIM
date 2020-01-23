<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ControleVeiculoWeb.Interface.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pagina Login</title>
    <link href="../Content/Css/StyleSheet.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="../Content/Css/bootstrap.css" rel="stylesheet" media="screen" />
</head>

<body>
    <form id="form1" runat="server">
        <section>
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div id="banner">
                            <h1>
                                <img src="../Imagem/Logo.png" alt="RodoSystem - Gerenciamento de Veiculos" />
                            </h1>
                            <h2>RodoSystem - Gerenciamento de Veiculos
                            </h2>
                        </div>
                    </div>
                    <br />
                    <br />
                    <div class="row">
                        <div class="col-xs-1 col-xs-offset-5">
                            <asp:Label ID="LabelUsuario" runat="server" Text="Usuario:"></asp:Label>
                            <asp:TextBox ID="EditUsuario" runat="server" Style="margin-bottom: 1px"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-xs-1 col-xs-offset-5">
                            <asp:Label ID="LabelSenha" runat="server" Text="Senha:"></asp:Label>
                            <asp:TextBox ID="EditSenha" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-xs-1 col-xs-offset-6 linhaCinza">
                            <asp:Button ID="BotaoEntrar" runat="server" Text="Entrar" CssClass="btn" OnClick="BotaoEntrar_Click" />
                        </div>
                    </div>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <div class="row">
                        <div class="col-xs-5 col-xs-offset-4 linhaCinza" id="copyright">
                            <footer>
                                <a href="#" id="logo-RodoSystem">
                                    <img src="../Imagem/Logo.png" alt="RodoSystem - Gerenciamento de Veiculos" />
                                </a>
                                <p>Todos os direitos reservados &copy; 2019</p>
                            </footer>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section>
            <div id="erro">
                <asp:Label ID="LabelErro" runat="server" Text=""></asp:Label>
            </div>
        </section>
    </form>
    <script src="../Scripts/JS/jquery-3.4.1.min.js"></script>
    <script src="../Scripts/JS/bootstrap.min.js"></script>
</body>
</html>
