using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SQLiteTestAddTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please Input " + lblCustID.Content);
            }
            else if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please Input " + lblName.Content);
            }
            else if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please Input " + lblLastName.Content);
            }
            else
            {
                int Unique = 1;
                foreach (string list in DataAccess.GetData())
                {
                    if (list == txtID.Text)
                    {
                        Unique = 2;
                        MessageBox.Show("Customer ID : " + list + " already exist");
                        break;
                    }
                }
                if (Unique == 1)
                {
                    DataAccess.AddData(txtID.Text, txtName.Text, txtLastName.Text, txtEmail.Text);
                    MessageBox.Show("Customer ID " + txtID.Text + " done");
                }
                ClearTxtBox();
            }
        }
        private void ClearTxtBox()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
        }

        private void showMsgBtn_Click(object sender, RoutedEventArgs e)
        {
            string data = "";
            int counter = 0;
            foreach (string list in DataAccess.GetData())
            {
                counter += 1;
                data += list + Environment.NewLine;
            }

            if (counter == 0)
            {
                MessageBox.Show("Data found", "Customer-DATA");
            }
            else
            {
                MessageBox.Show(data, "Customer-DATA");
            }
        }
    }
}
