using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BACKUPRESTORETEST
{
    public partial class IMPORT : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DbConnection dbcon = new DbConnection();
        Form1 frm = new Form1();
        public IMPORT()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void IMPORT_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
                if (csv_file_path.EndsWith(".csv"))
                {
                    using (Microsoft.VisualBasic.FileIO.TextFieldParser csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csv_file_path))
                    {
                        csvReader.SetDelimiters(new string[] { "," });
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        //read column
                        string[] colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }
                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }
                            csvData.Rows.Add(fieldData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exce " + ex);
            }
            return csvData;
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                int ImportedRecord = 0, inValidItem = 0;
                string SourceURl = "";

                if (dialog.FileName != "")
                {
                    if (dialog.FileName.EndsWith(".csv"))
                    {
                        DataTable dtNew = new DataTable();
                        dtNew = GetDataTabletFromCSVFile(dialog.FileName);
                        if (Convert.ToString(dtNew.Columns[0]).ToLower() != "pname")
                        {
                            MessageBox.Show("Invalid Items File");
                            btnImport.Enabled = false;
                            return;
                        }
                        txtBrowse.Text = dialog.SafeFileName;
                        SourceURl = dialog.FileName;
                        if (dtNew.Rows != null && dtNew.Rows.ToString() != String.Empty)
                        {
                            dataGridView1.DataSource = dtNew;
                        }
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if ( Convert.ToString(row.Cells["pname"].Value) == "" || row.Cells["pname"].Value == null)
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                                inValidItem += 1;
                            }
                            else
                            {
                                ImportedRecord += 1;
                            }
                        }
                        if (dataGridView1.Rows.Count == 0)
                        {
                            btnImport.Enabled = false;
                            MessageBox.Show("There is no data in this file", "__", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected File is Invalid, Please Select valid csv file.", "____", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void btnImport_Click(object sender, EventArgs e)
        {
            if(txtBrowse.Text == "")
            {
                MessageBox.Show("Please Select File First");
                return;
            }
            cn.Open();
            try
            {
                DataTable dtItem = (DataTable)(dataGridView1.DataSource);
                string pname;
                int count = 0;
                foreach (DataRow dr in dtItem.Rows)
                {
                    pname = Convert.ToString(dr["pname"]);
                    if (pname != "")
                    {
                        string q = "if not exists (select * from Lists l where l.pname = '" + pname + "') Insert into Lists(pname) Values('" + pname + "') ";
                        SqlCommand cmd = new SqlCommand(q, cn);
                        cmd.ExecuteNonQuery();
                        count++;
                    }
                }
                foreach (DataGridViewRow dr in frm.DGVMain.Rows)
                {
                    pname = Convert.ToString(dr.Cells[1]);
                    if (pname.ToString() == dr.Cells[1].Value.ToString())
                    {
                        MessageBox.Show("Duplicate Item FOUND");
                    }
                }
                cn.Close();
                MessageBox.Show("Item Imported Successfully Duplicate Name Skipped", "_____", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
