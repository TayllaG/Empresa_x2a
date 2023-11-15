using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_x2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                CadastroCompleto cc = new CadastroCompleto();
                cc.Nome = txt_nome.Text;
                cc.Cpf = txt_cpf.Text;
                cc.Telefone1 = txt_telefone1.Text;
                cc.Telefone2 = txt_telefone2.Text;
                cc.Genero = txt_genero.Text;
                cc.estadoCivil = txt_estadocivil.Text;
                cc.Cep = txt_cep.Text;
                cc.Logradouro = txt_logradouro.Text;
                cc.Numero = (int)Convert.ToInt64(txt_numero.Text);
                cc.Bairro = txt_bairro.Text;
                cc.Estado = txt_estado.Text;
                cc.Municipio = txt_municipio.Text;
                cc.Cargo = txt_cargo.Text;
                cc.Departamento = txt_departamento.Text;
                cc.DataAdmissao = txt_dataadmissao.Text;
                cc.Banco = txt_banco.Text;
                cc.Salario = Convert.ToDouble(txt_salario.Text);
                cc.Agencia = txt_agencia.Text;
                cc.Conta = txt_conta.Text;


                MessageBox.Show(Validacoes.ValidaCPF(txt_cpf.Text).ToString());
                var resultadoCpf = Validacoes.ValidaCPF(txt_cpf.Text);
                if(resultadoCpf == false)
                {
                    MessageBox.Show("Cpf inválido!");
                }
                else
                {
                    MessageBox.Show("Cadastro concluido com sucesso!");
                }
                if (Validacoes.ValidarEmail(txt_email.Text))
                {
                    MessageBox.Show("Cadastro concluido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Email inválido!");
                }



            }
            catch
            {
                MessageBox.Show("Verifique se os campos estão preenchidos corretamente!");
            }

        }

        private void txt_cancelar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_cpf.Clear();
            txt_rg.Clear();
            txt_email.Clear();
            txt_telefone1.Clear();
            txt_telefone2.Clear();
            txt_genero.SelectedIndex = -1;
            txt_estadocivil.SelectedIndex= -1;
            txt_cep.Clear();
            txt_logradouro.Clear();
            txt_numero.Clear();
            txt_bairro.Clear();
            txt_estado.SelectedIndex = -1;
            txt_municipio.Clear();
            txt_cargo.SelectedIndex = -1;
            txt_departamento.SelectedIndex = -1;
            txt_dataadmissao.Clear();
            txt_banco.SelectedIndex = -1;
            txt_salario.Clear();
            txt_agencia.Clear(); 
            txt_conta.Clear();


        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_logradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}