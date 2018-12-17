using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataGrid = System.Windows.Controls.DataGrid;

namespace ControlsLibrary
{
    /// <summary>
    /// Interaction logic for CustomerCon.xaml
    /// </summary>
    public partial class CustomerCon : System.Windows.Forms.UserControl
    {

        
        public CustomerCon()
        {
            this.setConnection();
            InitializeComponent();
        }
        private void updateDataGrid()
        {
            
        }
        private void setConnection()
        {
            myDataGrid = new System.Windows.Controls.DataGrid();
           
            /* try
             {
                 SqlConnection thisConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;");
                 thisConnection.Open();

                 string Get_Data = "SELECT * FROM cus";

                 SqlCommand cmd = thisConnection.CreateCommand();
                 cmd.CommandText = Get_Data;

                 SqlDataAdapter sda = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable("cus");
                 sda.Fill(dt);

                 myDataGrid.ItemsSource = dt.DefaultView;
             }
             catch
             {
                 MessageBox.Show("db error");
             }*/
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.updateDataGrid();
        }

        

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void update_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void resetAll()
        {
            customer_id_txtbx.Text = "";
            email_txtbx.Text = "";
            name_txtbx.Text = "";
            phone_txtbx.Text = "";
            address_txtbx.Text = "";

            add_btn.IsEnabled = true;
            update_btn.IsEnabled = false;
            delete_btn.IsEnabled = false;
        }

        public static explicit operator System.Windows.Forms.Control(CustomerCon v)
        {
            throw new NotImplementedException();
        }

        private void reset_btn_Click(object sender, RoutedEventArgs e)
        {
            this.resetAll();
        }
        private void AUD(String sql_stmt, int state)
        {
            
        }

        private void myDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                customer_id_txtbx.Text = dr["Customer_ID"].ToString();
                name_txtbx.Text = dr["Name"].ToString();
                phone_txtbx.Text = dr["Phone"].ToString();
                email_txtbx.Text = dr["Email"].ToString();
                address_txtbx.Text = dr["Address"].ToString();

                add_btn.IsEnabled = false;
                update_btn.IsEnabled = true;
                delete_btn.IsEnabled = true;

            }
        }
    }
}
