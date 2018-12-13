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
        EmployeeContext db = new EmployeeContext();

        public Code_First()
        {
            InitializeComponent();
            comboBox1.DataSource = db.Positions.Select(x => x.PositionName).Distinct().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                var positions = db.Positions.ToList();
                var emps = db.Employees.ToList();
                dataGridView1.DataSource = emps.Join(
                    positions,
                    emp => emp.PositionId,
                    p => p.Id, (emp, p) => new
                    {
                        emp.Id,
                        emp.Name,
                        emp.Age,
                        p.PositionName,
                        p.Description
                    }).ToList();
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

        private void button4_Click(object sender, EventArgs e)
        {
            var positions = db.Positions.ToList();
            var emps = db.Employees.ToList();
            var result = from emp in db.Employees
                                       join pos in db.Positions
                                       on emp.PositionId equals pos.Id
                                       where pos.PositionName == comboBox1.SelectedItem.ToString()
                                       select new { emp.Name, emp.Age, pos.PositionName, pos.Description };

            dataGridView1.DataSource = result.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Positions position = new Positions("Test position", "description");
            //Employees employee = new Employees("Test Name", 24, 5);
            //db.Positions.Add(position);
            //db.Employees.Add(employee);

            Positions pos = new Positions(pos_tb.Text, desc.Text);
            db.Positions.Add(pos);
            db.SaveChanges();
        }
    }
}
