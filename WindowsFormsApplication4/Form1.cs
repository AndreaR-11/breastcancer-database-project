//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;

//namespace WindowsFormsApplication4
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            // TODO: This line of code loads data into the 'breast_CancerDataSet._PATIENT_' table. You can move, or remove it, as needed.
//            this.pATIENT_TableAdapter.Fill(this.breast_CancerDataSet._PATIENT_);
//            this.pATIENT_TableAdapter.Fill(this.breast_CancerDataSet._PATIENT_);
            
//            // Manually set the Insert, Update, and Delete commands
            
//        }


//        private void button1_Click(object sender, EventArgs e)
//        {
//            pATIENTBindingSource.AddNew();

//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            pATIENTBindingSource.EndEdit();
//            pATIENT_TableAdapter.Update(breast_CancerDataSet._PATIENT_);

//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
           
//                pATIENTBindingSource.RemoveCurrent();

//    // Update the DataSet
//    pATIENT_TableAdapter.Update(breast_CancerDataSet._PATIENT_);


//          MessageBox.Show("Data Deleted");
//          //pATIENT_TableAdapter.Update(breast_CancerDataSet._PATIENT_);

//        }

//        private void button4_Click(object sender, EventArgs e)
//        {
//            this.Close();

//        }

//        private void button5_Click(object sender, EventArgs e)
//        {
//            pATIENTBindingSource.MoveFirst();

//        }

//        private void button6_Click(object sender, EventArgs e)
//        {
//            pATIENTBindingSource.MoveLast();

//        }

//        private void button7_Click(object sender, EventArgs e)
//        {
//            pATIENTBindingSource.MovePrevious();

//        }

//        private void button8_Click(object sender, EventArgs e)
//        {
//            pATIENTBindingSource.MoveNext();

//        }
       

//    }

//}
//using System;
//using System.Windows.Forms;

//namespace WindowsFormsApplication4
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            // TODO: This line of code loads data into the 'breast_CancerDataSet._PATIENT_' table. You can move, or remove it, as needed.
//            this.pATIENT_TableAdapter.Fill(this.breast_CancerDataSet._PATIENT_);

//            // Manually set the Delete command
//            this.pATIENT_TableAdapter.Adapter.DeleteCommand = new System.Data.SqlClient.SqlCommand();
//            this.pATIENT_TableAdapter.Adapter.DeleteCommand.Connection = new System.Data.SqlClient.SqlConnection("Data Source=LAPTOP-BR3HMMC8\\SQLEXPRESS;Initial Catalog=Breast_Cancer;Integrated Security=True;");
//            this.pATIENT_TableAdapter.Adapter.DeleteCommand.CommandText = "DELETE FROM PATIENT$ WHERE Patient_id = @PatientID"; // Adjust the table and primary key as necessary

//            // Add parameters to the Delete command
//            this.pATIENT_TableAdapter.Adapter.DeleteCommand.Parameters.Add("@PatientID", System.Data.SqlDbType.Int, 0, "PatientID");

//            // Set the DeleteCommand's parameters source
//            this.pATIENT_TableAdapter.Adapter.DeleteCommand.Parameters["@PatientID"].SourceVersion = System.Data.DataRowVersion.Original;
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            pATIENTBindingSource.AddNew();
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            pATIENTBindingSource.EndEdit();
//            pATIENT_TableAdapter.Update(breast_CancerDataSet._PATIENT_);
//        }


//        private void button3_Click(object sender, EventArgs e)
//        {
//           private void button3_Click(object sender, EventArgs e)
//{
//    try
//    {
//        if (MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
//        {
//            // Remove current patient from binding source
//            pATIENTBindingSource.RemoveCurrent();

//            // Update the database
//            pATIENT_TableAdapter.Update(breast_CancerDataSet.PATIENT);

//            MessageBox.Show("Data Deleted");
//        }
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}


//      private void button4_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void button5_Click(object sender, EventArgs e)
//        {
//            pATIENTBindingSource.MoveFirst();
//        }

//        private void button6_Click(object sender, EventArgs e)
//        {
//            pATIENTBindingSource.MoveLast();
//        }

//        private void button7_Click(object sender, EventArgs e)
//        {
//            pATIENTBindingSource.MovePrevious();
//        }

//        private void button8_Click(object sender, EventArgs e)
//        {
//            pATIENTBindingSource.MoveNext();
//        }
//    }
//}


using System;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load data into the dataset
            this.pATIENT_TableAdapter.Fill(this.breast_CancerDataSet._PATIENT_);

            // Manually set the Delete command for the TableAdapter
            this.pATIENT_TableAdapter.Adapter.DeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.pATIENT_TableAdapter.Adapter.DeleteCommand.Connection = new System.Data.SqlClient.SqlConnection("Data Source=LAPTOP-BR3HMMC8\\SQLEXPRESS;Initial Catalog=Breast_Cancer;Integrated Security=True;");
            this.pATIENT_TableAdapter.Adapter.DeleteCommand.CommandText = "DELETE FROM $PATIENT WHERE Patient_id = @PatientID"; // Adjust table name and primary key column as necessary

            // Add parameters to the Delete command
            this.pATIENT_TableAdapter.Adapter.DeleteCommand.Parameters.Add("@PatientID", System.Data.SqlDbType.Int, 0, "Patient_id");

            // Set the DeleteCommand's parameters source
            this.pATIENT_TableAdapter.Adapter.DeleteCommand.Parameters["@PatientID"].SourceVersion = System.Data.DataRowVersion.Original;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add new patient record
            pATIENTBindingSource.AddNew();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
            
        //    {
        //        // Save changes to the dataset
        //        pATIENTBindingSource.EndEdit();
        //        pATIENT_TableAdapter.Update(breast_CancerDataSet._PATIENT_);
        //        MessageBox.Show("Data Updated");
        //    }
           private void button2_Click(object sender, EventArgs e)
                {
                    // Save changes to the dataset
                    pATIENTBindingSource.EndEdit();
                    pATIENT_TableAdapter.Update(breast_CancerDataSet._PATIENT_);
                    MessageBox.Show("Data Updated");
                }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Remove current patient from binding source
                    pATIENTBindingSource.RemoveCurrent();

                    // Update the database
                    pATIENT_TableAdapter.Update(breast_CancerDataSet._PATIENT_);

                    MessageBox.Show("Data Deleted");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Move to the first record in the dataset
            pATIENTBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Move to the last record in the dataset
            pATIENTBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Move to the previous record in the dataset
            pATIENTBindingSource.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Move to the next record in the dataset
            pATIENTBindingSource.MoveNext();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Form3 form3 = new Form3();

            //// Show Form3
            //form3.Show();

            //// Optionally hide or close the current form
            //this.Hide();
        }
    }
}
