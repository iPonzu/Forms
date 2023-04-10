using System.Windows.Forms;

namespace Formulario

    {
        static class Program{

            public static void Main()
            {
                Form janela = new Form();
                janela.Text = "Pega no butão!";
                janela.Size = new System.Drawing.Size(500, 700);



                Label lblEmail = new Label();
                lblEmail.Text = "E-mail:";
                lblEmail.Location = new System.Drawing.Point(10, 10);
                TextBox txtEmail = new TextBox();
                txtEmail.Location = new System.Drawing.Point(10, 40);
                txtEmail.Width = 200;



                Label lblSenha = new Label();
                lblSenha.Text = "Senha:";
                lblSenha.Location = new System.Drawing.Point(10, 80);
                TextBox txtSenha = new TextBox();
                txtSenha.PasswordChar = '*';
                txtSenha.Location = new System.Drawing.Point(10, 110);
                txtSenha.Width = 200;



                Button botao = new Button();
                botao.Text = "VENHA";
                botao.Location = new System.Drawing.Point(10, 140);
                botao.Click += (sender, e) => MessageBox.Show("Se lascou!");




                janela.Controls.Add(botao);
                janela.Controls.Add(lblEmail);
                janela.Controls.Add(txtEmail);
                janela.Controls.Add(lblSenha);
                janela.Controls.Add(txtSenha);




                Application.Run(janela);
            }
        }
}