using WindowsFormsApp1shop12.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1shop12
{
    public partial class dashboard : Form
    {
        k101shop1Entities db = new k101shop1Entities();
        private Worker actWorker;
        product selectedproduct;

        public dashboard(Worker worker)
        {
            actWorker = worker;
            InitializeComponent();
        }

        public void FillCategoryCombo()
        {
            txtcat.Items.AddRange(db.Categories.Select(c => c.Name).ToArray());
        }

        public void FillOrderDataGrid()
        {
            txtgrid.DataSource = db.Orders.Where(ord => ord.WorkerID == actWorker.ID).Select(x => new
            {
                Category_Name = x.product.Category.Name,
                Product_Name = x.product.Name,
                x.product.Price,
                x.Count,
                x.PurchaseDate

            }).ToList();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            txtwel.Text = "welcome" + actWorker.Fullname + "!";
            FillCategoryCombo();
            FillOrderDataGrid();
        }
        public void ISBuy(string txt)
        {
            if(txt== "buy")
            {
                btnbuy.Enabled = true;
                lblprice.Visible = true;
                txtcat.Text = "";
            }
            else
            {
                btnbuy.Enabled = false;
                lblprice.Visible = false;
                txtcount.Value = 1;

            }
        }
        private void txtcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cat = txtcat.Text;
            int catId= db.Categories.First(x => x.Name == cat).ID;
            ISBuy("b");
            txtpra.Items.Clear();
            txtpra.Items.AddRange(db.products.Where(x => x.CategoryId == catId).Select(x => x.Name).ToArray());
        }

        private void txtpra_SelectedIndexChanged(object sender, EventArgs e)
        {
            string protext = txtpra.Text;
            if(protext!="")
            {
              selectedproduct=  db.products.First(x => x.Name==protext);
                lblprice.Text = selectedproduct.Price+"azn";
                lblprice.Visible = true;
                txtcount.Maximum = selectedproduct.Quantity;
                ISBuy("buy");
            }
        }

        private void txtcount_ValueChanged(object sender, EventArgs e)
        {
            lblprice.Text = (selectedproduct.Price * txtcount.Value) + "azn";
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            ord.WorkerID = actWorker.ID;
            ord.ProductID = selectedproduct.ID;
            ord.PurchaseDate = DateTime.Now;
            ord.Count = (int)txtcount.Value;
            db.Orders.Add(ord);
            selectedproduct.Quantity -= (int)txtcount.Value;
            db.SaveChanges();
            FillOrderDataGrid();
           MessageBox.Show($"products : {selectedproduct.Name} buy suuces","succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ISBuy("b");
                txtpra.Items.Clear();

        }
    }
}
