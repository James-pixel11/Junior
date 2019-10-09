using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorShop
{
    private OleDbConnection connection = new OleDbConnection();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          try

            {
               
              
connection.Connection.String = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Mukazika\Documents\mydatabase.accdb";
               
             connection.Open();
             checkConnection.Text = "SUCCESSFUL!";
                
             connection.Close();
               }   
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}


              

                
         