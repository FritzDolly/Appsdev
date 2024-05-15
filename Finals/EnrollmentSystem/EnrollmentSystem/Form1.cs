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

namespace EnrollmentSystem
{
    public partial class Form1 : Form
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"\\\\Server2\\second semester 2023-2024\\LAB802\\79286_CC_APPSDEV22_1030_1230_PM_MW\\79286-23213218\\Desktop\\Finals\\LorejasF.accdb\"";
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
           
            OleDbConnection thisConnection= new OleDbConnection(connectionString);
            string Ole = "Select * From SubjectFile";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "SubjectFile");

            DataRow thisRow = thisDataSet.Tables["SubjectFile"].NewRow();
            thisRow["SFSUBJCODE"] = Convert.ToInt16(SubjectcodeTbox.Text);
            thisRow["SFSUBJDESC"] = DescriptionTbox.Text;
            thisRow["SFSUBJUNITS"] = UnitsTbox.Text;
            thisRow["SFSUBJREGOFRNG"] = OfferingCbox.Text.Substring(0, 1);
            thisRow["SFSUBJCATEGORY"] = CategoryCbox.Text.Substring(0, 1);
            thisRow["SFSUBJSTATUS"] = "AC";
            thisRow["SFSUBJCOURSECODE"] = CourseCbox.Text;
            thisRow["SFSUBJCURRCODE"] = CurriculumYearTbox.Text;

            thisDataSet.Tables["SubjectFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SubjectFile");

            MessageBox.Show("Recorded");

        }

        private void ScodeTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand=thisConnection.CreateCommand();

                string sql = "SELECT * FROM SUBJECTFILE";
                thisCommand.CommandText = sql;

                OleDbDataReader thisDataReader=thisCommand.ExecuteReader();

                bool found = false;
                string subjectCode = "";
                string description = "";
                string units = "";

                while (thisDataReader.Read()) 
                {
                    //Messagebox.show(thisDataReader["SFSUBJCODE"].ToString());
                    if (thisDataReader["SFSUBJCODE"].ToString().Trim().ToUpper() == ScodeTbox.Text.Trim().ToUpper()) 
                    {
                        found=true;
                        subjectCode = thisDataReader["SFSUBJCODE"].ToString();
                        description = thisDataReader["SFSUBJDESC"].ToString();
                        units = thisDataReader["SFSUBJUNITS"].ToString() ;
                        break;
                        //
                    }
                }
                if (found == false)
                    MessageBox.Show("Sunject Code Not Found");
                else 
                {
                    SubjectDataGridView.Rows[0].Cells[0].Value = subjectCode;
                    SubjectDataGridView.Rows[0].Cells[0].Value = description;
                    SubjectDataGridView.Rows[0].Cells[0].Value = units;

                }
            }
        }
    }
}
