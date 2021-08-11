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
namespace BACKUPRESTORETEST
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DbConnection dbcon = new DbConnection();
        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
   
            DGVMain.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from Lists ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                DGVMain.Rows.Add(dr["id"].ToString(), dr["pname"].ToString());
            }
            cn.Close();
        }

        private void btnBackupBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtbackup.Text = fbd.SelectedPath;
                btnBackupBrowse.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            String database = cn.Database.ToString();
            try
            {
                cn.Open();
                if (txtbackup.Text == string.Empty)
                {
                    MessageBox.Show("please enter the backup file location");
                }
                else
                {
                    string q = "BACKUP DATABASE [" + database + "] TO DISK='" + txtbackup.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                    SqlCommand cmd = new SqlCommand(q,cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Backup taken successfully", "Backup successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestoreBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = ofd.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            cn.Open();
            String database = cn.Database.ToString();
            try
            {
                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd = new SqlCommand(sql1,cn);
                cmd.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtRestore.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, cn);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, cn);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            IMPORT imp = new IMPORT();
            imp.ShowDialog();
        }
    }
}
