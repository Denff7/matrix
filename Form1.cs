namespace matrix
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

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[,] a = new char[10, 10];

            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;

            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows[i].Cells[i].Style.BackColor = Color.Black;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char[,] a = new char[10, 10];

            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            char[,] a = new char[10, 10];

            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            char[,] a = new char[10, 10];

            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i + j == 10 - 1)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char[,] a = new char[10, 10];

            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            char[,] a = new char[10, 10];

            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[,] a = new char[10, 10];

            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i > j)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            char[,] a = new char[10, 10];

            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i + j < 10 - 1)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }

                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            char[,] a = new char[10, 10];

            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i < j)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            char[,] a = new char[10, 10];

            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i + j > 10 - 1)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }

                }
            }
        }
    }
}

