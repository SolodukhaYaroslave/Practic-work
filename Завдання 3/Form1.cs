using System;
using System.Windows.Forms;

namespace Завдання_3
{
    public partial class frmSector : Form
    {
        public frmSector()
        {
            InitializeComponent();
        }

        int m;
        double Sum;

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (txtColvoEl.Text == "")
            {
                MessageBox.Show("Кількість категорій витрат на введено", "Помилка");
                return;
            }

            m = Convert.ToInt32(txtColvoEl.Text);
            if (m > 10)
            {
                MessageBox.Show("Кількість категорій привищує ліміт(10)", "Помилка");
                return;
            }

            dgvMass.ColumnCount = m;

            for (int i = 0; i < m; i++)
            {
                dgvMass.Columns[i].Width = 110;
                dgvMass.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvMass.Columns[i].HeaderText = "Витрата категорії " + (i + 1).ToString();
            }
        }

        private void btCreateDiag_Click(object sender, EventArgs e)
        {
            Sum = 0;
            double[] A = new double[m];
            string[] B = new string[m];

            for (int i = 0; i < m; i++)
            {
                A[i] = Convert.ToDouble(dgvMass.Rows[0].Cells[i].Value);
                B[i] = dgvMass.Columns[i].HeaderText;
                Sum += A[i];

                if (A[i] < 0)
                {
                    MessageBox.Show("Серед введених значень є відємні", "Помилка");
                    return;
                }
            }

            if (Sum != 100)
            {
                MessageBox.Show("Сума не дорівнює 100%, перевірте дані", "Помилка");
                return;
            }

            chartSector.Series[0].Points.DataBindXY(B, A);
            chartSector.ChartAreas[0].Area3DStyle.Enable3D = true;
        }
    }
}
