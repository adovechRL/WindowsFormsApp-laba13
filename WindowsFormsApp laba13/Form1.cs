using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_laba13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            {

                InitializeComponent();

                // Відключаємо автоматичне створення стовпців
                dataGridView1.AutoGenerateColumns = false;

                // Додаємо стовпці вручну
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Name";
                column.Name = "Модель";
                dataGridView1.Columns.Add(column);

                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Manufacturer";
                column.Name = "Виробник";
                dataGridView1.Columns.Add(column);

                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Type";
                column.Name = "Тип літака";
                dataGridView1.Columns.Add(column);

                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "PassengerCapacity";
                column.Name = "Пасажиро стійкість";
                dataGridView1.Columns.Add(column);

                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "FuelConsumption";
                column.Name = "Споживання пального";
                dataGridView1.Columns.Add(column);

                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "MaxSpeed";
                column.Name = "Макс швидкість";
                dataGridView1.Columns.Add(column);

                column = new DataGridViewCheckBoxColumn();
                column.DataPropertyName = "HasAutopilot";
                column.Name = "Є автопілот";
                dataGridView1.Columns.Add(column);

                column = new DataGridViewCheckBoxColumn();
                column.DataPropertyName = "NoAutopilot";
                column.Name = "Нема автопілота";
                dataGridView1.Columns.Add(column);
               
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK) // Відображаємо Form2 як модальне вікно і чекаємо, доки воно не буде закрите
            {
                // Якщо користувач натиснув OK на формі Form2, то передаємо дані до DataGridView
                dataGridView1.Rows.Add(form2.Model, form2.Manufacturer, form2.Type, form2.PassengerCapacity, form2.FuelConsumption, form2.MaxSpeed, form2.HasAutopilot, form2.NoAutopilot);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // Видаляємо виділену лінію у dataGridView1
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // Перевірка, чи є виділені комірки
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Вмикаємо кнопку 3
                toolStripButton3.Checked = false;
            }
        }
        private void toolStripButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Перевіряємо, чи кнопка 3 вмикнута
            if (toolStripButton3.Checked)
            {
                // Увімкнути режим редагування для виділених комірок
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    cell.ReadOnly = false;
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Очищаємо dataGridView1
            dataGridView1.Rows.Clear();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
