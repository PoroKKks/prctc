namespace SytnikPP
{

    enum RowState
    {
        Existed,
        New,
        Modifield,
        ModifieldNew,
        Deleted
    }
    public partial class Form1 : Form
    {
        DataBase dataBase;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("userID", "Вид техники");
            dataGridView1.Columns.Add("problemDescription", "Модель");
            dataGridView1.Columns.Add("userID", "Проблема");
            dataGridView1.Columns.Add("userID", "ФИО");
            dataGridView1.Columns.Add("userID", "Телефон");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
