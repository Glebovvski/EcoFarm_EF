using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            SqlParameter parameter = new SqlParameter("@product", ProductsCB.SelectedItem);

            //dt.DataSource = db.Database.SqlQuery<Invoice>("select * from Invoice where Supplier = @product", parameter).ToList();
            dt.DataSource = db.Database.SqlQuery<Invoice_product>("select * from [Invoice products] where [Name] = @product", parameter).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conn = db.Database.Connection.ConnectionString;
            ObjectContext context = (new EcoFarm_DBEntities() as IObjectContextAdapter).ObjectContext;
            context.DefaultContainerName = "EcoFarm_DBEntities";
            ObjectParameter parameter = new ObjectParameter("supplier", SupplierCB.SelectedItem);
            string query = "SELECT VALUE i FROM Invoice as i WHERE i.Supplier=@supplier";
            //new ObjectContext(db.Database.Connection.ConnectionString);
            
            ObjectQuery<Invoice> objectQuery = new ObjectQuery<Invoice>(query, context);
            objectQuery.Parameters.Add(parameter);
            var res= objectQuery.First();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Code_First form = new Code_First();
            form.Visible = true;
        }
    }
}
