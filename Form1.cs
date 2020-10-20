using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;

        BindingSource showProductList;

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.SelectedItem.ToString();
            _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
            _Description = richTxtDescription.Text;
            _Quantity = Quantity(txtQuantity.Text);
            _SellPrice = SellingPrice(txtSellPrice.Text);
            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = showProductList;
        }

        private double SellingPrice(string text)
        {
            throw new NotImplementedException();
        }

        private string Product_Name(string text)
        {
            throw new NotImplementedException();
        }

        private int Quantity(string text)
        {
            throw new NotImplementedException();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            showProductList = new BindingSource();

            InitializeComponent();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProducts = new string[]{
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Meat",
                "Personal Care",
                "Other",
            };

            for (int i = 0; i < 6; i++)
            {
                cbCategory.Items.Add(ListOfProducts[i].ToString());
            }
        }
    }
}
