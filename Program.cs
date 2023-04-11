using System.Windows.Forms;

namespace Formulario

    {
        static class Program{

            public static void Main()
            {
                Form janela = new Form();
                janela.Text = "Sys Login";
                janela.Size = new System.Drawing.Size(500, 700);

                Label lblNome = new Label();
                lblNome.Text = "Seu nome:";
                lblNome.Location =  new System.Drawing.Point (10, 10);
                TextBox txtNome = new TextBox();
                txtNome.Location = new System.Drawing.Point(10, 40);
                txtNome.Width = 200;


                Label lblEmail = new Label();
                lblEmail.Text = "E-mail:";
                lblEmail.Location = new System.Drawing.Point(10, 80);
                TextBox txtEmail = new TextBox();
                txtEmail.Location = new System.Drawing.Point(10, 110);
                txtEmail.Width = 200;



                Label lblSenha = new Label();
                lblSenha.Text = "Senha:";
                lblSenha.Location = new System.Drawing.Point(10, 150);
                TextBox txtSenha = new TextBox();
                txtSenha.PasswordChar = '*';
                txtSenha.Location = new System.Drawing.Point(10, 180);
                txtSenha.Width = 200;



                Button botao = new Button();
                botao.Text = "Login";
                botao.Location = new System.Drawing.Point(10, 230);
                botao.Click += (sender, e) => MessageBox.Show("Bem-vindo");






                janela.Controls.Add(botao);
                janela.Controls.Add(lblNome);               
                janela.Controls.Add(txtNome);
                janela.Controls.Add(lblEmail);
                janela.Controls.Add(txtEmail);
                janela.Controls.Add(lblSenha);
                janela.Controls.Add(txtSenha);




                Application.Run(janela);
            }
        }
}