using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace childInformation
{
    public partial class viewForms : Form
    {
        int ID = 0;
        public viewForms()
        {
            InitializeComponent();

            SQLiteConnection conn;
            conn = CreateConnection();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM q20toq25";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlite_cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(OnRowHeaderMouseClick);

            conn.Close();
        }


        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=mySQLiteDB.db; Version = 3; New = True; Compress = True;");
            // Open the connection:
            sqlite_conn.Open();
            return sqlite_conn;
        }

        void OnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("Clicked RowHeader!");

            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            // ComboBox 1
            Dictionary<string, string> c1Entries = new Dictionary<string, string>{
                     { "1", "Home"}
                    ,{ "2", "Dispensary"}
                    ,{ "3", "Health House (LHW)"}
                    ,{ "4", "Private Clinic/Hospital"}
                    ,{ "5", "Basic health unit"}
                    ,{ "6", "Rural health center"}
                    ,{ "7", "THQ"}
                    ,{ "8", "DHQ"}
                    ,{ "9", "MCH Center"}
                    ,{ "10", "CMW working station"}
                    ,{ "11", "Parent’s home"}
                    ,{ "12", "In-law’s home"}
                    ,{ "13", "TBA’s"}
                    ,{ "14", "On the way to health care facility"}
                    ,{ "15", "Other"}
                    ,{ "16", "Do not know"}
                };
            placeOfDelivery.DataSource = new BindingSource(c1Entries, null);
            placeOfDelivery.DisplayMember = "Value";
            placeOfDelivery.ValueMember = "Key";

            // ComboBox 6
            Dictionary<string, string> c61Entries = new Dictionary<string, string>{
                     { "1", "2016"}
                    ,{ "2", "2017"}
                    ,{ "3", "2018"}
                    ,{ "4", "2019"}
                    ,{ "5", "2020"}
                    ,{ "6", "2021"}
                };
            yearOfBirth.DataSource = new BindingSource(c61Entries, null);
            yearOfBirth.DisplayMember = "Value";
            yearOfBirth.ValueMember = "Key";

            // ComboBox 2
            Dictionary<string, string> c21Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "2", "No"}
                };
            bornWithinLast4Weeks.DataSource = new BindingSource(c21Entries, null);
            bornWithinLast4Weeks.DisplayMember = "Value";
            bornWithinLast4Weeks.ValueMember = "Key";

            // ComboBox 3
            Dictionary<string, string> c31Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "2", "No"}
                };
            diedWithinFirstWeek.DataSource = new BindingSource(c31Entries, null);
            diedWithinFirstWeek.DisplayMember = "Value";
            diedWithinFirstWeek.ValueMember = "Key";

            // ComboBox 4
            Dictionary<string, string> c41Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "2", "No"}
                };
            diedWithinFirst4Weeks.DataSource = new BindingSource(c41Entries, null);
            diedWithinFirst4Weeks.DisplayMember = "Value";
            diedWithinFirst4Weeks.ValueMember = "Key";

            // ComboBox 5
            Dictionary<string, string> c51Entries = new Dictionary<string, string>{
                     { "1", "January"}
                    ,{ "2", "February"}
                    ,{ "3", "March"}
                    ,{ "4", "April"}
                    ,{ "5", "May"}
                    ,{ "6", "June"}
                    ,{ "7", "July"}
                    ,{ "8", "August"}
                    ,{ "9", "September"}
                    ,{ "10", "October"}
                    ,{ "11", "November"}
                    ,{ "12", "December"}
                    ,{ "13", "Do not know"}
                };
            monthOfDeath.DataSource = new BindingSource(c51Entries, null);
            monthOfDeath.DisplayMember = "Value";
            monthOfDeath.ValueMember = "Key";

            //string pcb11 = placeOfDelivery.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)placeOfDelivery.SelectedItem).Key;
            //string pcb11 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            placeOfDelivery.SelectedIndex       = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) != -1 ? int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) - 1 : -1;
            
            if(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() != "") {
                placeOfDeliveryOther.Enabled = true;
            } else {
                placeOfDeliveryOther.Enabled = false;
            }

            placeOfDeliveryOther.Text           = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "" ? "-1" : dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            yearOfBirth.SelectedIndex           = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) != -1 ? int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) - 1 : -1;
            bornWithinLast4Weeks.SelectedIndex  = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()) != -1 ? int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()) - 1 : -1;
            diedWithinFirstWeek.SelectedIndex   = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()) != -1 ? int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()) - 1 : -1;
            diedWithinFirst4Weeks.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()) != -1 ? int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()) - 1 : -1;
            monthOfDeath.SelectedIndex          = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString()) != -1 ? int.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString()) - 1 : -1;
        }

        //Update Record  
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            string var1, var1Other, var2, var3, var4, var5, var6, var7, var8;
            string message, title;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();

            var1 = placeOfDelivery.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)placeOfDelivery.SelectedItem).Key;
            var1Other = placeOfDeliveryOther.Text == "" ? "" : placeOfDeliveryOther.Text;
            var2 = yearOfBirth.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)yearOfBirth.SelectedItem).Key;
            var3 = bornWithinLast4Weeks.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)bornWithinLast4Weeks.SelectedItem).Key;
            var4 = diedWithinFirstWeek.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)diedWithinFirstWeek.SelectedItem).Key;
            var5 = diedWithinFirst4Weeks.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)diedWithinFirst4Weeks.SelectedItem).Key;
            var6 = monthOfDeath.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)monthOfDeath.SelectedItem).Key;
            var7 = "51f980b1d00224dc";
            var8 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            sqlite_cmd.CommandText = "UPDATE q20toq25 set placeOfDelivery = '" + var1 + "', placeOfDeliveryOther = '" + var1Other + "', yearOfBirth = '" + var2 + "', bornWithinLast4Weeks = '" + var3 + "', diedWithinFirstWeek = '" + 
                var4 + "', diedWithinFirst4Weeks = '" + var5 + "', monthOfDeath = '" + var6 + "', deviceid = '" + var7 + "', updatedAt = '" + var8 
                + "', afterUpdateSyncStatus = '" + 1 + "' where _id = " + ID;

            if (sqlite_cmd.ExecuteNonQuery() > 0)
            {
                message = "Updation was successful";
                title = "Success";

                sqlite_cmd.CommandText = "SELECT * FROM q20toq25";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlite_cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                message = "No record selected or some error occured, please check";
                title = "Failure";
            }

            MessageBox.Show(message, title);
        }

        private void placeOfDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (placeOfDelivery.SelectedIndex == 14)
            {
                placeOfDeliveryOther.Enabled = true;
                placeOfDeliveryOther.Focus();
            }
            else
            {
                placeOfDeliveryOther.Text = "";
                placeOfDeliveryOther.Enabled = false;
            }
        }

        private void btnSyncUpdate_Click(object sender, EventArgs e)
        {
            string message, title;
            SQLiteConnection conn;
            conn = CreateConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT _id, placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, monthOfDeath, updateAt FROM q20toq25 where afterUpdateSyncStatus = 1";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlite_cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                string table_column_value = DataTableToJSON(dt);
                var table_data = "[{\"table\":\"q20t0q25\"}, " + table_column_value + "]";

                string URL = "http://F38158/fr/api/sync2.php";
                var data = postData(table_data, URL);

                if (data != null)
                {
                    message = "Sync was successful";
                    title = "Success";

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sqlite_cmd.CommandText = "UPDATE q20toq25 set afterUpdateSyncStatus = 0 where _id = " + dt.Rows[i][0].ToString();
                        sqlite_cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    message = "Sync wasn't successful";
                    title = "Success";
                }
            }
            else
            {
                message = "Either no new records or some error occured, please check";
                title = "Error";
            }

            MessageBox.Show(message, title);
        }


        // Convert datatable to JSON string
        public string DataTableToJSON(DataTable table)
        {

            var JSONString = new StringBuilder();

            if (table.Rows.Count > 0)
            {
                JSONString.Append("[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }
            return JSONString.ToString();
        }

        // Post data to server
        public string postData(string postData, string URL)
        {
            string responseFromServer = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            request.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            System.IO.Stream dataStream = null;
            dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        // Get data returned from server
        public string getData(string URL)
        {
            string jsonString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            request.ContentType = "application/x-www-form-urlencoded";

            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jsonString = sr.ReadToEnd();
            sr.Close();
            return jsonString;
        }
    }
}
