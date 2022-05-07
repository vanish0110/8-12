namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 15;
            dataGridView1.RowCount = 15;
            int[,] a = new int[15, 15];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    a[i, j] = rand.Next(-100, 10);

            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();

            int[] array = new int[a.Length];
            for (i = 0; i < a.GetLength(0); i++)
            {

                for (j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > 0)
                        array[j] ++;
                }
            }
            int min = array[0];
            int mur = 0;
            for (int v = 0; v < a.Length; v++)
            {
                if (min > array[v])
                {
                    min = array[v];
                    mur = v;
                }
            }
            textBox1.Text = Convert.ToString(mur);
        }
    }
}
        