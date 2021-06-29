using System.Data;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private GenericDataGrid.GenericDataGrid dataGrids;

        public GenericDataGrid.GenericDataGrid DataGrid
        {
            get
            {
                return dataGrids;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataGridHost.Children.Clear();
            AddGenericDataGrid();
        }

        public void AddGenericDataGrid()
        {
            dataGrids = new GenericDataGrid.GenericDataGrid();

            dataGrids.Datatable = createDataTable();

            // AddFieldLayout(dataGrid);
            DataGridHost.Children.Add(dataGrids);

        }

        public static DataTable createDataTable()
        {
            DataTable table = new DataTable();
            //columns  
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("NAME", typeof(string));
            table.Columns.Add("CITY", typeof(string));

            //data  
            table.Rows.Add(111, "Devesh", "Ghaziabad");
            table.Rows.Add(222, "Ravi", "Kanpur");
            table.Rows.Add(102, "ROLI", "MAINPURI");
            table.Rows.Add(212, "DEVESH", "KANPUR");
            table.Rows.Add(102, "NIKHIL", "GZB");
            table.Rows.Add(212, "HIMANSHU", "NOIDA");
            table.Rows.Add(102, "AVINASH", "NOIDA");
            table.Rows.Add(212, "BHUPPI", "GZB");
            
            return table;
        }
    }
}



