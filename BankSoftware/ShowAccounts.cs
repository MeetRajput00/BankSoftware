using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSoftware
{
    public partial class ShowAccounts : Form
    {
        Account obj;

        public ShowAccounts()
        {
            InitializeComponent();
        }
        public DataTable ToDataTable<T>(List<T> items)

        {

            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in Props)

            {

                //Setting column names as Property names

                dataTable.Columns.Add(prop.Name);

            }

            foreach (T item in items)

            {

                var values = new object[Props.Length];

                for (int i = 0; i < Props.Length; i++)

                {

                    //inserting property values to datatable rows

                    values[i] = Props[i].GetValue(item, null);

                }

                dataTable.Rows.Add(values);

            }

            //put a breakpoint here and check datatable

            return dataTable;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            var songsDataGridView = new DataGridView();
            this.Controls.Add(songsDataGridView);

            songsDataGridView.AutoGenerateColumns = true;

            songsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            songsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            songsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(songsDataGridView.Font, FontStyle.Bold);

            songsDataGridView.Name = "songsDataGridView";
            songsDataGridView.Location = new Point(8, 8);
            songsDataGridView.Size = new Size(500, 250);
            songsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            songsDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            songsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            songsDataGridView.GridColor = Color.Black;
            songsDataGridView.RowHeadersVisible = true;
            var dt = ToDataTable(AccountDB.BackAccounts);
            songsDataGridView.DataSource = dt;
            //songsDataGridView.Refresh();
            songsDataGridView.Rows.Add(dt.Rows[0]);

            //dataGridView1.AutoGenerateColumns = true;
            //var source = new BindingSource(bindingList, null);
            //dataGridView1.DataSource = null;
            //var dt = ToDataTable(AccountDB.BackAccounts);
            //dataGridView1.Columns.Clear();
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();
            //accountGrid.Refresh();


        }
    }
}
