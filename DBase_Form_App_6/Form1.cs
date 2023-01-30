using System.Collections.Generic;
using System.Data;

namespace DBase_Form_App_6
{
    public partial class frmDBase : Form
    {
        public frmDBase()
        {
            InitializeComponent();
        }

        private void btnDBaseConnect_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string SQL = rtbSQL.Text;


            DatabaseConnect.dataConnect(ds, SQL);

            dgvDataSet.DataSource = ds.Tables[0];
            dgvDataSet.Refresh();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            string SQL  = rtbSQL.Text;

            DatabaseConnect.FireSQL(SQL);
        }

        private void frmDBase_Load(object sender, EventArgs e)
        {
            rtbSQLExamples.Text = SQLLabel();
        }
        public static string SQLLabel()
        {
            string LabelText;

            LabelText = "tblCities, tblPerson, tblUKCities\r\n";

            LabelText += "\r\nSELECT * FROM tblPerson;\r\n";

            LabelText += "\r\nINSERT INTO tblPerson ( FName, SName, CitiesID )\r\n" +
                "VALUES (\"Berlinda\", \"Bridges\", 1056459162);\r\n";

            LabelText += "\r\nALTER TABLE tblPerson\r\nALTER COLUMN SName VARCHAR(30) NOT NULL;\r\n";

            LabelText += "\r\nALTER TABLE tblPerson ADD COLUMN CityOfBirth VARCHAR(25);\r\n";

            LabelText += "\r\nALTER TABLE tblPerson DROP CityOfBirth;\r\n";

            LabelText += "\r\nCREATE TABLE tblContinents(\r\nContID \t\tVARCHAR(4) NOT NULL," +
                         "\r\nContName \tVARCHAR(30) NOT NULL,\r\nCountries\tINTEGER,\r\n" +
                         "PRIMARY KEY \t(ContID ));\r\n";

            LabelText += "\r\nUPDATE tblPerson\r\nSET FName = 'Barnabas', SName = 'Bourges'\r\nWHERE PersonID = 0007;\r\n";

            LabelText += "\r\nDELETE FROM tblPerson WHERE FName='Barney';";

            return LabelText;
        }

        private void dgvDataSet_DoubleClick(object sender, EventArgs e)
        {
            int selRow = dgvDataSet.CurrentRow.Index;
            int result  =(int)(dgvDataSet.Rows[selRow].Cells[0].Value);
        }
    }
}