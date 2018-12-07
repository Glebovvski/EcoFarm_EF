using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoFarm_EF
{
    public partial class Code_First : Form
    {
        public Code_First()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(EmployeeContext db = new EmployeeContext())
            {
                dataGridView1.DataSource = db.Employees.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeContext db = new EmployeeContext();
            bool res = int.TryParse(AgeTb.Text, out int age);
            if (!res)
                MessageBox.Show("Input must be digit");
            else dataGridView1.DataSource = db.Employees.Where(x => x.Age <= age).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (EmployeeContext db = new EmployeeContext()) {
                dataGridView1.DataSource = db.Employees.Where(x => x.Name.Contains(NameTb.Text)).ToList();
                    };
        }
    }
}
