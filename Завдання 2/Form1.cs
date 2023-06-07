using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання_2
{
    public partial class frmDiagrams : Form
    {
        public frmDiagrams()
        {
            InitializeComponent();
        }
        public int mGist, mRound, minAge, minYear;

        private void btCreateMasRound_Click(object sender, EventArgs e)
        {
            if (txtMasRound.Text == "" || txtMinAge.Text == "")
            { MessageBox.Show("Не всі дані введені", "Помилка"); return; }

            minAge = Convert.ToInt32(txtMinAge.Text);
            mRound = Convert.ToInt32(txtMasRound.Text);

            if (minAge < 0 || mRound <= 0)
            {
                MessageBox.Show("Введені значення не вірні", "Помилка");
                return;
            }

            dgvMasRound.ColumnCount = mRound;

            for (int j = 0; j < mRound; j++)
            {
                dgvMasRound.Columns[j].Width = 110;
                dgvMasRound.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvMasRound.Columns[j].HeaderText = $"Вік катег ({minAge.ToString()})";
                minAge++;
            }
        }

        private void btCreateGist_Click(object sender, EventArgs e)
        {
            int[] C = new int[mGist];
            int[] D = new int[mGist];
            minYear -= mGist;

            for (int j = 0; j < mGist; j++)
            {
                C[j] = Convert.ToInt32(dgvMasGist.Rows[0].Cells[j].Value);
                D[j] = minYear;
                minYear++;
                if (C[j] < 0)
                {
                    MessageBox.Show("Серед введених значень є відємні", "Помилка");
                }
            }

            chartDiagrams.Series[0].Points.DataBindXY(D, C);
        }

        private void btCreateRound_Click(object sender, EventArgs e)
        {
            string[] S = new string[mRound];
            double[] D = new double[mRound];
            minAge -= mRound;

            for (int j = 0; j < mRound; j++)
            {
                S[j] = dgvMasRound.Columns[j].HeaderText;
                D[j] = Convert.ToInt32(dgvMasRound.Rows[0].Cells[j].Value);
                Sum += D[j];
                if (D[j] < 0)
                {
                    MessageBox.Show("Серед введених значень є відємні", "Помилка");
                }
            }
            for (int i = 0; i < mRound; i++)
            {
                D[i] = D[i] / Sum * 100; 
            }

            chartDiagrams.Series[1].Points.DataBindXY(S, D);
        }

        private void btCreateMasGist_Click(object sender, EventArgs e)
        {
            if (txtMinYear.Text == "" || txtMasGist.Text == "")
            { MessageBox.Show("Не всі дані введені", "Помилка"); return; }

            minYear = Int32.Parse(txtMinYear.Text);
            mGist = Int32.Parse(txtMasGist.Text);

            if (minYear < 2000)
            { MessageBox.Show("Рік початку курсів - 2000-й", "Помилка"); return; }

            dgvMasGist.ColumnCount = mGist;

            for (int j = 0; j < mGist; j++)
            {
                dgvMasGist.Columns[j].Width = 110;
                dgvMasGist.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvMasGist.Columns[j].HeaderText = minYear.ToString() + " рік";
                minYear++;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public double Sum;
    }
}
