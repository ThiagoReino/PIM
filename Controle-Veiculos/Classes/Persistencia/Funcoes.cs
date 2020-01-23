using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Controle_Veiculos.Classes.Persistencia;
using Controle_Veiculos.Classes.Controle;

namespace Controle_Veiculos.Classes.Persistencia
{
    class Funcoes
    {
        public String ApenasNumeros(string Numero)
        {
            Regex re = new Regex("[0-9]");
            StringBuilder s = new StringBuilder();

            foreach (Match m in re.Matches(Numero))
            {
                s.Append(m.Value);
            }
            return s.ToString();
        }

        //METODO DE VALIDAÇÃO CNPJ
        public bool ValidaCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        //METODO DE VALIDACAO DO CPF
        public bool validarCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public Boolean validaFiltrosPesquisa(string campopesquisa, string stringpesquisa)
        {
            Boolean resultado = true;

            if (String.IsNullOrEmpty(campopesquisa) && !string.IsNullOrEmpty(stringpesquisa))
            {
                MessageBox.Show("Informe o conteúdo para pesquisa ou deixar em branco para todos.", "CONTEÚDO DO CAMPO PESQUISA");
                resultado = false;
            }
            else if (!String.IsNullOrEmpty(stringpesquisa) && string.IsNullOrEmpty(campopesquisa))
            {
                MessageBox.Show("Selecione o tipo de campo a pesquisar.", "SELECIONE TIPO PESQUISA");
                resultado = false;
            }
            return resultado;
        }

        //METODO DE VALIDAÇÃO DE DATA textbox
        public Boolean validaData(string wdata)
        {
            Funcoes funcoes = new Funcoes();

            Boolean resultado = true;
            if (funcoes.ApenasNumeros(wdata) != "" && funcoes.ApenasNumeros(wdata) != null)
            {
                DateTime wdt;
                try
                {
                    wdt = DateTime.Parse(wdata,new System.Globalization.CultureInfo("pt-BR"));
                }
                catch (Exception)
                {
                    resultado = false;
                    MessageBox.Show("Erro com a data informada");
                }
            }
            return resultado;
        
        }

        //METODO DE VALIDACAO DO ENDERECO DE E-MAIL
        public bool validarEmail(string email)
        {
            bool validEmail = false;
            if (!String.IsNullOrEmpty(email))
            {
                int indexArr = email.IndexOf('@');
                if (indexArr > 0)
                {
                    int indexDot = email.IndexOf('.', indexArr);
                    if (indexDot - 1 > indexArr)
                    {
                        if (indexDot + 1 < email.Length)
                        {
                            string indexDot2 = email.Substring(indexDot + 1, 1);
                            if (indexDot2 != ".")
                            {
                                validEmail = true;
                            }
                        }
                    }
                }
            }
            return validEmail;
        }


    }
}
