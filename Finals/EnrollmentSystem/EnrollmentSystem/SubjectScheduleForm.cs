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
    public partial class SubjectScheduleForm : Form
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"\\\\Server2\\second semester 2023-2024\\LAB802\\79286_CC_APPSDEV22_1030_1230_PM_MW\\79286-23213218\\Desktop\\Finals\\LorejasF.accdb\"";

        public SubjectScheduleForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            string Ole = "Select * From SubjectFile";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "SubjectFile");

            DataRow thisRow = thisDataSet.Tables["SubjectFile"].NewRow();
            thisRow["SSFEDPCODE"] = Convert.ToInt16(SubjectcodeTbox.Text);
            thisRow["SSFSUBJCODE"] = SubjectcodeTbox.Text;
            thisRow["SSFSTARTTIME"] = StarttimedateTimePicker.Text;
            thisRow["SSFENDTIME"] = EndtimedateTimePicker.Text.Substring(0, 1);
            thisRow["SSFDAYS"] = DaysTbox.Text.Substring(0, 1);
            thisRow["SSFROOM"] = RoomTbox.Text;
            thisRow["SSFMAXSIZE"] = RoomTbox.Text;
            thisRow["SSFCLASSSIZE"] = RoomTbox.Text;
            thisRow["SFSUBJREGOFRING"]= AmpmCbox.Text;
           

            thisDataSet.Tables["SubjectFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SubjectScheduleFile");

            MessageBox.Show("Recorded");
        }
    }
}
