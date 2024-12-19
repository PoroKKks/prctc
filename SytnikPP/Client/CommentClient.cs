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
    public partial class CommentClient : Form
    {
        DataBase dataBase;
        int userID;
        List<Request> requests;
        Dictionary<int, Comment> comments;

        public CommentClient(DataBase dataBase, string login)
        {
            InitializeComponent();

            this.dataBase = dataBase;
            userID = dataBase.GetUserIdByLogin(login);
            requests = dataBase.GetAllRequests().Where(req => req.clientData.Key == userID).ToList();
            comments = dataBase.GetAllComments();

            dataGridView1.Columns.Add("Comment", "Комментарий");

            foreach (Request request in requests)
                comboBoxRequest.Items.Add(request.requestID);
            if (comboBoxRequest.Items.Count > 0)
                comboBoxRequest.SelectedIndex = 0;
        }


        public CommentClient()
        {
            InitializeComponent();
        }

        private void CommentClient_Load(object sender, EventArgs e)
        {
            if (requests.Count == 0)
            {
                MessageBox.Show("Нет заявок", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            comboBoxRequest_SelectionChangeCommitted(sender, e);
        }

        private void comboBoxRequest_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (var comment in comments.Where(com => com.Value.RequestID == int.Parse(comboBoxRequest.Text)).ToDictionary())
                dataGridView1.Rows.Add(comment.Value.Message);

            labelCount.Text = dataGridView1.Rows.Count.ToString() + " из " + dataGridView1.Rows.Count.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
         => Close();
    }
}
