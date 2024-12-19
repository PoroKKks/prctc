using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SytnikPP
{
    public partial class RequestOperator : Form
    {
        DataBase dataBase;
        List<Request> requests;
        Dictionary<int, string> specialists;

        private void UpdateLabelCount()
           => labelCount.Text = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible).ToString() + " из " + dataGridView.Rows.Count;

        public RequestOperator(DataBase dataBase)
        {
            InitializeComponent();

            this.dataBase = dataBase;
            requests = dataBase.GetAllRequests().ToList();

            specialists = dataBase.GetAllSpecialists();
            foreach (var spec in specialists)
                comboBox1.Items.Add(spec.Value);
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;


            dataGridView.Columns.Add("requestID", "Номер заявки");
            dataGridView.Columns.Add("startDate", "Дата начала");
            dataGridView.Columns.Add("problemDescription", "Описание проблемы");
            dataGridView.Columns.Add("completionDate", "Дата окончания");
            dataGridView.Columns.Add("requestStatus", "Статус заявки");
            dataGridView.Columns.Add("techModel", "Модель техники");
            dataGridView.Columns.Add("master", "Имя специалиста");
            dataGridView.Columns.Add("client", "Имя клиента");

            foreach (var req in requests)
                dataGridView.Rows.Add(req.requestID, req.startDate.ToLocalTime().ToString("dd.MM.yyyy"), req.problemDescription, req.completionDate.HasValue ? req.completionDate.Value.ToLocalTime().ToString("dd.MM.yyyy") : "Нет", req.requestStatus.Value, req.techModel.Value, req.masterData.HasValue ? req.masterData.Value.Value : "Нет", req.clientData.Value);

            UpdateLabelCount();
            labelAVG.Text = $"Среднее время выполнения заявок: {Exec.GetAvgTime(requests)} дней";
        }


        public RequestOperator()
        {
            InitializeComponent();
        }

        private void RequestOperator_Load(object sender, EventArgs e)
        {
            if (requests.Count == 0)
            {
                MessageBox.Show("Заявок нет", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        => Close();

        private void buttonMaster_Click(object sender, EventArgs e)
        {
            dataBase.SetMasterForRequest((int)dataGridView.SelectedCells[0].Value, specialists.First(spec => spec.Value == comboBox1.Text).Key);
            dataGridView.SelectedCells[6].Value = comboBox1.Text;
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            dataBase.SetDateForRequest((int)dataGridView.SelectedCells[0].Value, dateTimePicker.Value);
            dataGridView.SelectedCells[3].Value = dateTimePicker.Value.Date.ToString("dd.MM.yyyy");
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
                dataGridView.Rows[i].Visible = textBoxFilter.Text.Split(',').Select(str => str.Trim()).All(str => dataGridView.Rows[i].Cells.Cast<DataGridViewCell>().Any(str2 => str2.Value.ToString().Contains(str)));
            UpdateLabelCount();
        }
    }
}
