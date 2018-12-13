using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoFarm_EF
{
    public partial class Form1 : Form
    {
        public EntityConnection cn;
        public EntityCommand cmd;

        EcoFarm_DBEntities db = new EcoFarm_DBEntities();

        public Form1()
        {
            InitializeComponent();
            ProductsCB.DataSource = db.Invoice_products.Select(x => x.Name).Distinct().ToList();
            SupplierCB.DataSource = db.Invoices.Select(x => x.Supplier).Distinct().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.DataSource = db.Invoices.Where(x => x.Date >= start.Value && x.Date <= end.Value)
                                       .Join(db.Invoice_products,
                                       i => i.Invoice_number,
                                       p => p.Invoice_Number,
                                       (i, p) => new
                                       {
                                           i.Invoice_number,
                                           i.Date,
                                           i.Supplier,
                                           p.Name,
                                           p.Units,
                                           p.Number_of_units,
                                           p.Total_price
                                       }
                                       ).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn = new EntityConnection("Name=EcoFarm_DBEntities");
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT VALUE i FROM EcoFarm_DBEntities.Invoice_products as i WHERE i.Name = @product";
            cmd.Parameters.AddWithValue("product", ProductsCB.SelectedItem);
            DbDataReader dbReader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
            dt.Columns.Add("col", "Product code");
            dt.Columns.Add("col", "Name");
            dt.Columns.Add("col", "Units");
            dt.Columns.Add("col", "Number of units");
            dt.Columns.Add("col", "Unit price");
            dt.Columns.Add("col", "Total price");
            dt.Columns.Add("col", "Invoice number");
            while (dbReader.Read())
            {
                dt.Rows.Add(
                    dbReader["Product_code"].ToString(),
                    dbReader["Name"].ToString(),
                    dbReader["Units"].ToString(), 
                    dbReader["Number_of_units"].ToString(),
                    dbReader["Unit_price"].ToString(),
                    dbReader["Total_price"].ToString(),
                    dbReader["Invoice_Number"].ToString()
                    );
            }
            dbReader.Close();
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ObjectContext context = (new EcoFarm_DBEntities() as IObjectContextAdapter).ObjectContext;
            //context.DefaultContainerName = "EcoFarm_DBEntities";
            ObjectParameter parameter = new ObjectParameter("supplier", SupplierCB.SelectedItem.ToString());
            string query = "SELECT VALUE i FROM Invoices as i WHERE i.Supplier=@supplier";

            ObjectQuery<Invoice> objectQuery = context.CreateQuery<Invoice>(query, parameter);
            var res = objectQuery.ToList();
            dt.DataSource = res;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Code_First form = new Code_First();
            form.Visible = true;
        }
    }
}
