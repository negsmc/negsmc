namespace negsmcprojeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
             private void btnFazerLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            // Exemplo simples de login fixo
            if (usuario == "negs" && senha == "2009")
            {
                // Abre a tela de produtos
                Form2 telaProdutos = new Form2();
                telaProdutos.Show();

                // Fecha a tela de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tela de cadastro ainda não implementada.");
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro segundaJanela = new Cadastro();
            segundaJanela.Show();  // Abre a segunda janela de forma não modal
            // segundaJanela.ShowDialog(); // Abre a segunda janela de forma modal (bloqueia a principal até fechar)
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}