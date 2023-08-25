namespace FormBugadoQueDesbuga
{
    public partial class Form1 : Form
    {
        List<string> produtos = new List<string> { "Chinelo", "Carro", "Vassoura", "Chocolate"};
        public Form1()
        {
            InitializeComponent();
        }

        void geraForm(string ItemProduto)
        {
            Panel panel = new Panel();
            panel.Name = "panel";
            panel.BackColor = Color.Blue;
            panel.Size = new Size(100, 100);



            Label label = new Label();
            // label.Name = "";
            label.Text = ItemProduto;
            label.AutoSize = true;
            label.Location = new Point(0, 0);

            void comprar(object sender, EventArgs e) // aqui é o void do botao que eu criei
            {

                label.Text = "COMPRADO";
                panel.BackColor = Color.Green;
            }


            Button button = new Button();
            button.Text = "COMPRAR";
            button.Location = new Point(0, label.Height);
            button.Click += comprar; //aqui está ligado com o void do botao que eu criei
            //mesmo sendo uma função, o comprar da certo porque se eu colocar o () eu vou ter que colocar o sender e o EventArgs
            //E quando eu não coloco, ele basicamente coloca altomaticamente.

            panel.Controls.Add(label);
            panel.Controls.Add(button);

            panel.Location = new Point(0, panel1.Height);

            if (panel1.Height < 500)
                panel1.Height += panel.Height + 10;

            panel1.Controls.Add(panel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string produtos in produtos)
            {
                geraForm(produtos);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}