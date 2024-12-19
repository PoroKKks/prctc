using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SytnikPP.Manager
{
    public partial class RequestManager : Form
    {
        DataBase dataBase;
        List<Request> requests;
        Dictionary<int, string> specialists;
        Dictionary<int, string> statuses;

        private void UpdateLabelCount()
           => labelCount.Text = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Visible).ToString() + " из " + dataGridView1.Rows.Count;

        public RequestManager(DataBase dataBase)
        {
            InitializeComponent();

            this.dataBase = dataBase;
            requests = dataBase.GetAllRequests().ToList();

            specialists = dataBase.GetAllSpecialists();
            foreach (var spec in specialists)
                comboBoxSpecialist.Items.Add(spec.Value);
            if (comboBoxSpecialist.Items.Count > 0)
                comboBoxSpecialist.SelectedIndex = 0;

            statuses = dataBase.GetRequestStatuses();
            foreach (var stat in statuses)
                comboBoxStatus.Items.Add(stat.Value);
            if (comboBoxStatus.Items.Count > 0)
                comboBoxStatus.SelectedIndex = 0;


            dataGridView1.Columns.Add("requestID", "Номер заявки");
            dataGridView1.Columns.Add("startDate", "Дата начала");
            dataGridView1.Columns.Add("problemDescription", "Описание проблемы");
            dataGridView1.Columns.Add("completionDate", "Дата окончания");
            dataGridView1.Columns.Add("requestStatus", "Статус заявки");
            dataGridView1.Columns.Add("techModel", "Модель техники");
            dataGridView1.Columns.Add("master", "Имя специалиста");
            dataGridView1.Columns.Add("client", "Имя клиента");

            foreach (var req in requests)
                dataGridView1.Rows.Add(req.requestID, req.startDate.ToLocalTime().ToString("dd.MM.yyyy"), req.problemDescription, req.completionDate.HasValue ? req.completionDate.Value.ToLocalTime().ToString("dd.MM.yyyy") : "Нет", req.requestStatus.Value, req.techModel.Value, req.masterData.HasValue ? req.masterData.Value.Value : "Нет", req.clientData.Value);

            UpdateLabelCount();
        }


       

        private void RequestManager_Load(object sender, EventArgs e)
        {
            if (requests.Count == 0)
            {
                MessageBox.Show("Заявок нет", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        => Close();

        private void buttonObrab_Click(object sender, EventArgs e)
        {
            dataBase.SetMasterForRequest((int)dataGridView1.SelectedCells[0].Value, specialists.First(spec => spec.Value == comboBoxSpecialist.Text).Key);
            dataGridView1.SelectedCells[5].Value = comboBoxSpecialist.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Visible = textBox1.Text.Split(',').Select(str => str.Trim()).All(str => dataGridView1.Rows[i].Cells.Cast<DataGridViewCell>().Any(str2 => str2.Value.ToString().Contains(str)));
            UpdateLabelCount();
        }

        private void buttonUstanov_Click(object sender, EventArgs e)
        {
            dataBase.ChangeStatus((int)dataGridView1.SelectedCells[0].Value, statuses.First(stat => stat.Value == comboBoxStatus.Text).Key);
            dataGridView1.SelectedCells[4].Value = comboBoxStatus.Text;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataBase.Delete((int)dataGridView1.SelectedCells[0].Value);
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }
    }
}
