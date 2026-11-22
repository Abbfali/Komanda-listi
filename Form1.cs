using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Acildi hezle iki misal tapshiriq
            dataGridView1.Rows.Add("Hesabat", "Aylıq", "21.11.2026", false);
            dataGridView1.Rows.Add("Görüş", "Komanda", "22.11.2026", false);
        }

        // Button1: yeni tapshiriq elave et
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Tapşırığın adı boşdur!");
                return;
            }

            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString("dd.MM.yyyy"), false);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        // CheckBox sutunu: silme suali
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["CheckBox"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Bu tapşırığı silmək istəyirsiniz?", "Sual", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
