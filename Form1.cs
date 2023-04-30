using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class Kind : Form
    {
        ListView type;
        Random accident, incident, chance;
        List<Product> products = new List<Product>()
        {
            new Product("name_1", 1000, 10),
            new Product("name_2", 2000, 20),
            new Product("name_3", 3000, 30),
            new Product("name_4", 4000, 40)
        };
        public Kind()
        {
            InitializeComponent();
            type = new ListView();
            type.SetBounds(400, 40, 300, 100);
            Controls.Add(type);
        }

        private void rev_ord_Click(object sender, EventArgs e)
        {
            int index = 0, value, meaning, significance;//индекс итерации
            accident = new Random();
            value = accident.Next(0, 2);
            incident = new Random();
            meaning = incident.Next(0, 2);
            chance = new Random();
            significance = chance.Next(0, 2);
            if (significance == meaning || significance == value)
            {
                value = 2;
                meaning = 1;
                significance = 0;//значение третьего элемента
            }
            type.Items.Add(new ListViewItem(products[value].prod_name));
            type.Items.Add(new ListViewItem(products[meaning].prod_name));
            type.Items.Add(new ListViewItem(products[significance].prod_name));
            type.Columns.Add("name");
            type.Columns[index].Width = 100;
            type.Columns.Add("price");
            type.Columns[1].Width = 100;
            type.Columns.Add("count");
            type.Columns[2].Width = 100;
            foreach (ListViewItem item in type.Items)
            {
                item.SubItems.Add($"{products[index].price}");
                item.SubItems.Add($"{products[index].count}");
                item.ImageIndex = index;
                index++;
            }
        }

        private void dir_ord_Click(object sender, EventArgs e)
        {
            int index = 0, value, meaning, significance;//индекс итерации
            accident = new Random();
            value = accident.Next(0, 2);
            incident = new Random();
            meaning = incident.Next(0, 2);
            chance = new Random();
            significance = chance.Next(0, 2);
            if (significance == meaning || significance == value)
            {
                value = 0;//значение первого элемента
                meaning = 1;
                significance = 2;
            }
            type.Items.Add(new ListViewItem(products[value].prod_name));
            type.Items.Add(new ListViewItem(products[meaning].prod_name));
            type.Items.Add(new ListViewItem(products[significance].prod_name));
            type.Columns.Add("name");
            type.Columns[0].Width = 100;
            type.Columns.Add("price");
            type.Columns[1].Width = 100;
            type.Columns.Add("count");
            type.Columns[2].Width = 100;
            try
            {
                foreach (ListViewItem item in type.Items)
                {
                    item.SubItems.Add($"{products[index].price}");
                    item.SubItems.Add($"{products[index].count}");
                    item.ImageIndex = index;
                    index++;
                }
            }
            catch (Exception exclusion)
            {
                MessageBox.Show(exclusion.Message);
            }
        }
    }
}