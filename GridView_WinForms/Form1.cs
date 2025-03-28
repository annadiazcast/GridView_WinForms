namespace GridView_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acciones acc = new Acciones();
            dataGridView1.DataSource = acc.MostrarAutos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Acciones acc = new Acciones();
            dataGridView1.DataSource = acc.EliminarAutos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
