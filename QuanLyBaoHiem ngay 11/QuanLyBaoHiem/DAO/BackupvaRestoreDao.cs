using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoHiem.DAO
{
    class BackupvaRestoreDao
    {
        public void actionbackup(SaveFileDialog ofd)
        {
            SqlConnection connect;
            string con = @"data source=(local)\SQLEXPRESS;initial catalog=QuanLiBaoHiem;integrated security=True;";
            connect = new SqlConnection(con);
            connect.Open();
            //----------------------------------------------------------------------------------------------------

            //Execute SQL---------------
            SqlCommand command;
            command = new SqlCommand(@"backup database QuanLiBaoHiem to disk ='" + ofd.FileName + "' with init,stats=10", connect);
            command.ExecuteNonQuery();
            //-------------------------------------------------------------------------------------------------------------------------------

            connect.Close();

            MessageBox.Show("Đã sao lưu database thành công", "Back", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void actionrestore(OpenFileDialog ofd)
        {
            //Connect SQL-----------
            SqlConnection connect;
            string con = @"data source=116.106.36.210,1433;initial catalog=QuanLiBaoHiem;User ID=son;Password=123;";
            connect = new SqlConnection(con);
            connect.Open();
            //-----------------------------------------------------------------------------------------

            //Excute SQL----------------
            SqlCommand command;
            command = new SqlCommand("use master ", connect);
            command.ExecuteNonQuery();
            command = new SqlCommand(@"ALTER DATABASE QuanLiBaoHiem SET SINGLE_USER WITH ROLLBACK IMMEDIATE", connect);
            command.ExecuteNonQuery();
            command = new SqlCommand(@"RESTORE DATABASE QuanLiBaoHiem FROM DISK = '" + ofd.FileName + "'", connect);
            command.ExecuteNonQuery();
            //--------------------------------------------------------------------------------------------------------
            connect.Close();

            MessageBox.Show("Has been restored database", "Restoration", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void backup()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BAK File (.bak)|*.bak|All Files (*.*)|*.*";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show(ofd.FileName);
                if (File.Exists(@"" + sfd.FileName + ""))
                {
                    File.Delete(@"" + sfd.FileName + "");

                    actionbackup(sfd);
                }
                else
                {
                    actionbackup(sfd);
                }
            }

        }
        public void restore()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "BAK File (.bak)|*.bak|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (File.Exists(@"" + ofd.FileName + ""))
                    {
                        if (MessageBox.Show("Are you sure you restore?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            actionrestore(ofd);
                        }
                    }
                    else
                        MessageBox.Show(@"Do not make any endorsement above (or is not in the correct path)", "Restoration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
    }
}
