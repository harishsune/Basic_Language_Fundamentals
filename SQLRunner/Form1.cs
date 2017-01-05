using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Controls;

namespace SQLRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            string query =
                "select FirstName from Person.Person;\r\n\r\nselect MiddleName from Person.Person;\r\n\r\nselect LastName from Person.Person;                                             ;";
            string[] Commands = query.Split(';');
            SqlConnection oConnection=new SqlConnection("Data Source=.;Integrated Security=SSPI;Initial Catalog=AdventureWorks2014");
            int iCount = 1;
            string Command=String.Empty;
            foreach (string sCommand in Commands)
            {
                Command = sCommand.Trim();
                if (!string.IsNullOrEmpty(Command))
                {
                    SqlDataAdapter oAdapter = new SqlDataAdapter(Command, oConnection);
                    DataTable oDataSet = new DataTable();
                    oAdapter.Fill(oDataSet);
                    MetroTabPage oMetroTabPage = new MetroTabPage();
                    oMetroTabPage.Name = "Query" + iCount;
                   
                    oMetroTabPage.Text = "     Query " + iCount+ "     ";

                    DataGridView oDataGridView = new DataGridView
                    {
                        DataSource = oDataSet,
                        Name = "Grid" + iCount
                    };

                     oDataGridView.Size=new Size(907, 244);

                    oMetroTabPage.Controls.Add(oDataGridView);
                    metroTabControl1.TabPages.Add(oMetroTabPage);
                    iCount++;
                }
               
            }
           
        }
    }
}
