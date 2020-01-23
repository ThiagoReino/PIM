<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="ControleVeiculoWeb.Paginas.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RodoSystem - Gerenciamento de Veiculos</title>
    <link href="../Content/Css/StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <header>
        <div id="banner">
            <h1>
                <img src="../Imagem/Logo.png" alt="RodoSystem - Gerenciamento de Veiculos" />
            </h1>
            <h2>RodoSystem - Gerenciamento de Veiculos
            </h2>
            <nav>
                <ul class="menu">
                    <li><a href="Menu.aspx">Home</a></li>
                    <li><a href="#">Cadastros</a>
                        <ul class="submenu">
                            <li><a href="Motorista.aspx">Motorista</a></li>
                            <li><a href="#">Veiculo</a></li>
                            <li><a href="#">Fornecedor</a></li>
                            <li><a href="#">Grupo Produtos</a></li>
                            <li><a href="#">Produto</a></li>
                            <li><a href="#">Marca - Modelo Veiculo</a></li>
                            <li><a href="#">Seguradora</a></li>
                        </ul>
                    </li>
                    <li><a href="#">Operacoes</a></li>
                    <li><a href="#">Contato</a></li>
                </ul>
            </nav>
        </div>
    </header>
    <section>
        <div id="centropagina">
        </div>
    </section>
    <footer>
        <div id="copyright">
            <a href="#" id="logo-RodoSystem">
                <img src="../Imagem/Logo.png" alt="RodoSystem - Gerenciamento de Veiculos" />
            </a>
            <p>Todos os direitos reservados &copy; 2019</p>
        </div>
    </footer>
</body>
</html>
