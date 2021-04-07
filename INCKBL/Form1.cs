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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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
            cb11.DataSource = new BindingSource(c1Entries, null);
            cb11.DisplayMember = "Value";
            cb11.ValueMember = "Key";
            cb11.SelectedIndex = -1;

            Dictionary<string, string> c2Entries = new Dictionary<string, string>{
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
            cb12.DataSource = new BindingSource(c2Entries, null);
            cb12.DisplayMember = "Value";
            cb12.ValueMember = "Key";
            cb12.SelectedIndex = -1;

            Dictionary<string, string> c3Entries = new Dictionary<string, string>{
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
            cb13.DataSource = new BindingSource(c3Entries, null);
            cb13.DisplayMember = "Value";
            cb13.ValueMember = "Key";
            cb13.SelectedIndex = -1;

            Dictionary<string, string> c4Entries = new Dictionary<string, string>{
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
            cb14.DataSource = new BindingSource(c4Entries, null);
            cb14.DisplayMember = "Value";
            cb14.ValueMember = "Key";
            cb14.SelectedIndex = -1;

            Dictionary<string, string> c5Entries = new Dictionary<string, string>{
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
            cb15.DataSource = new BindingSource(c5Entries, null);
            cb15.DisplayMember = "Value";
            cb15.ValueMember = "Key";
            cb15.SelectedIndex = -1;

            Dictionary<string, string> c6Entries = new Dictionary<string, string>{
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
            cb16.DataSource = new BindingSource(c6Entries, null);
            cb16.DisplayMember = "Value";
            cb16.ValueMember = "Key";
            cb16.SelectedIndex = -1;

            Dictionary<string, string> c7Entries = new Dictionary<string, string>{
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
            cb17.DataSource = new BindingSource(c7Entries, null);
            cb17.DisplayMember = "Value";
            cb17.ValueMember = "Key";
            cb17.SelectedIndex = -1;

            Dictionary<string, string> c8Entries = new Dictionary<string, string>{
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
            cb18.DataSource = new BindingSource(c8Entries, null);
            cb18.DisplayMember = "Value";
            cb18.ValueMember = "Key";
            cb18.SelectedIndex = -1;

            Dictionary<string, string> c9Entries = new Dictionary<string, string>{
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
            cb19.DataSource = new BindingSource(c9Entries, null);
            cb19.DisplayMember = "Value";
            cb19.ValueMember = "Key";
            cb19.SelectedIndex = -1;

            Dictionary<string, string> c10Entries = new Dictionary<string, string>{
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
            cb110.DataSource = new BindingSource(c10Entries, null);
            cb110.DisplayMember = "Value";
            cb110.ValueMember = "Key";
            cb110.SelectedIndex = -1;

            Dictionary<string, string> c11Entries = new Dictionary<string, string>{
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
            cb111.DataSource = new BindingSource(c11Entries, null);
            cb111.DisplayMember = "Value";
            cb111.ValueMember = "Key";
            cb111.SelectedIndex = -1;

            // ComboBox 2
            Dictionary<string, string> c21Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb21.DataSource = new BindingSource(c21Entries, null);
            cb21.DisplayMember = "Value";
            cb21.ValueMember = "Key";
            cb21.SelectedIndex = -1;

            Dictionary<string, string> c22Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb22.DataSource = new BindingSource(c22Entries, null);
            cb22.DisplayMember = "Value";
            cb22.ValueMember = "Key";
            cb22.SelectedIndex = -1;

            Dictionary<string, string> c23Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb23.DataSource = new BindingSource(c23Entries, null);
            cb23.DisplayMember = "Value";
            cb23.ValueMember = "Key";
            cb23.SelectedIndex = -1;

            Dictionary<string, string> c24Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb24.DataSource = new BindingSource(c24Entries, null);
            cb24.DisplayMember = "Value";
            cb24.ValueMember = "Key";
            cb24.SelectedIndex = -1;

            Dictionary<string, string> c25Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb25.DataSource = new BindingSource(c25Entries, null);
            cb25.DisplayMember = "Value";
            cb25.ValueMember = "Key";
            cb25.SelectedIndex = -1;

            Dictionary<string, string> c26Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb26.DataSource = new BindingSource(c26Entries, null);
            cb26.DisplayMember = "Value";
            cb26.ValueMember = "Key";
            cb26.SelectedIndex = -1;

            Dictionary<string, string> c27Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb27.DataSource = new BindingSource(c27Entries, null);
            cb27.DisplayMember = "Value";
            cb27.ValueMember = "Key";
            cb27.SelectedIndex = -1;

            Dictionary<string, string> c28Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb28.DataSource = new BindingSource(c28Entries, null);
            cb28.DisplayMember = "Value";
            cb28.ValueMember = "Key";
            cb28.SelectedIndex = -1;

            Dictionary<string, string> c29Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb29.DataSource = new BindingSource(c29Entries, null);
            cb29.DisplayMember = "Value";
            cb29.ValueMember = "Key";
            cb29.SelectedIndex = -1;

            Dictionary<string, string> c210Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb210.DataSource = new BindingSource(c210Entries, null);
            cb210.DisplayMember = "Value";
            cb210.ValueMember = "Key";
            cb210.SelectedIndex = -1;

            Dictionary<string, string> c211Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb211.DataSource = new BindingSource(c211Entries, null);
            cb211.DisplayMember = "Value";
            cb211.ValueMember = "Key";
            cb211.SelectedIndex = -1;

            // ComboBox 3
            Dictionary<string, string> c31Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb31.DataSource = new BindingSource(c31Entries, null);
            cb31.DisplayMember = "Value";
            cb31.ValueMember = "Key";
            cb31.SelectedIndex = -1;

            Dictionary<string, string> c32Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb32.DataSource = new BindingSource(c32Entries, null);
            cb32.DisplayMember = "Value";
            cb32.ValueMember = "Key";
            cb32.SelectedIndex = -1;

            Dictionary<string, string> c33Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb33.DataSource = new BindingSource(c33Entries, null);
            cb33.DisplayMember = "Value";
            cb33.ValueMember = "Key";
            cb33.SelectedIndex = -1;

            Dictionary<string, string> c34Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb34.DataSource = new BindingSource(c34Entries, null);
            cb34.DisplayMember = "Value";
            cb34.ValueMember = "Key";
            cb34.SelectedIndex = -1;

            Dictionary<string, string> c35Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb35.DataSource = new BindingSource(c35Entries, null);
            cb35.DisplayMember = "Value";
            cb35.ValueMember = "Key";
            cb35.SelectedIndex = -1;

            Dictionary<string, string> c36Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb36.DataSource = new BindingSource(c36Entries, null);
            cb36.DisplayMember = "Value";
            cb36.ValueMember = "Key";
            cb36.SelectedIndex = -1;

            Dictionary<string, string> c37Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb37.DataSource = new BindingSource(c37Entries, null);
            cb37.DisplayMember = "Value";
            cb37.ValueMember = "Key";
            cb37.SelectedIndex = -1;

            Dictionary<string, string> c38Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb38.DataSource = new BindingSource(c38Entries, null);
            cb38.DisplayMember = "Value";
            cb38.ValueMember = "Key";
            cb38.SelectedIndex = -1;

            Dictionary<string, string> c39Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb39.DataSource = new BindingSource(c39Entries, null);
            cb39.DisplayMember = "Value";
            cb39.ValueMember = "Key";
            cb39.SelectedIndex = -1;

            Dictionary<string, string> c310Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb310.DataSource = new BindingSource(c310Entries, null);
            cb310.DisplayMember = "Value";
            cb310.ValueMember = "Key";
            cb310.SelectedIndex = -1;

            Dictionary<string, string> c311Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb311.DataSource = new BindingSource(c311Entries, null);
            cb311.DisplayMember = "Value";
            cb311.ValueMember = "Key";
            cb311.SelectedIndex = -1;

            // ComboBox 4
            Dictionary<string, string> c41Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb41.DataSource = new BindingSource(c41Entries, null);
            cb41.DisplayMember = "Value";
            cb41.ValueMember = "Key";
            cb41.SelectedIndex = -1;

            Dictionary<string, string> c42Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb42.DataSource = new BindingSource(c42Entries, null);
            cb42.DisplayMember = "Value";
            cb42.ValueMember = "Key";
            cb42.SelectedIndex = -1;

            Dictionary<string, string> c43Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb43.DataSource = new BindingSource(c43Entries, null);
            cb43.DisplayMember = "Value";
            cb43.ValueMember = "Key";
            cb43.SelectedIndex = -1;

            Dictionary<string, string> c44Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb44.DataSource = new BindingSource(c44Entries, null);
            cb44.DisplayMember = "Value";
            cb44.ValueMember = "Key";
            cb44.SelectedIndex = -1;

            Dictionary<string, string> c45Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb45.DataSource = new BindingSource(c45Entries, null);
            cb45.DisplayMember = "Value";
            cb45.ValueMember = "Key";
            cb45.SelectedIndex = -1;

            Dictionary<string, string> c46Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb46.DataSource = new BindingSource(c46Entries, null);
            cb46.DisplayMember = "Value";
            cb46.ValueMember = "Key";
            cb46.SelectedIndex = -1;

            Dictionary<string, string> c47Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb47.DataSource = new BindingSource(c47Entries, null);
            cb47.DisplayMember = "Value";
            cb47.ValueMember = "Key";
            cb47.SelectedIndex = -1;

            Dictionary<string, string> c48Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb48.DataSource = new BindingSource(c48Entries, null);
            cb48.DisplayMember = "Value";
            cb48.ValueMember = "Key";
            cb48.SelectedIndex = -1;

            Dictionary<string, string> c49Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb49.DataSource = new BindingSource(c49Entries, null);
            cb49.DisplayMember = "Value";
            cb49.ValueMember = "Key";
            cb49.SelectedIndex = -1;

            Dictionary<string, string> c410Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb410.DataSource = new BindingSource(c410Entries, null);
            cb410.DisplayMember = "Value";
            cb410.ValueMember = "Key";
            cb410.SelectedIndex = -1;

            Dictionary<string, string> c411Entries = new Dictionary<string, string>{
                     { "1", "Yes"}
                    ,{ "0", "No"}
                };
            cb411.DataSource = new BindingSource(c411Entries, null);
            cb411.DisplayMember = "Value";
            cb411.ValueMember = "Key";
            cb411.SelectedIndex = -1;

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
            cb51.DataSource = new BindingSource(c51Entries, null);
            cb51.DisplayMember = "Value";
            cb51.ValueMember = "Key";
            cb51.SelectedIndex = -1;

            Dictionary<string, string> c52Entries = new Dictionary<string, string>{
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
            cb52.DataSource = new BindingSource(c52Entries, null);
            cb52.DisplayMember = "Value";
            cb52.ValueMember = "Key";
            cb52.SelectedIndex = -1;

            Dictionary<string, string> c53Entries = new Dictionary<string, string>{
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
            cb53.DataSource = new BindingSource(c53Entries, null);
            cb53.DisplayMember = "Value";
            cb53.ValueMember = "Key";
            cb53.SelectedIndex = -1;

            Dictionary<string, string> c54Entries = new Dictionary<string, string>{
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
            cb54.DataSource = new BindingSource(c54Entries, null);
            cb54.DisplayMember = "Value";
            cb54.ValueMember = "Key";
            cb54.SelectedIndex = -1;

            Dictionary<string, string> c55Entries = new Dictionary<string, string>{
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
            cb55.DataSource = new BindingSource(c55Entries, null);
            cb55.DisplayMember = "Value";
            cb55.ValueMember = "Key";
            cb55.SelectedIndex = -1;

            Dictionary<string, string> c56Entries = new Dictionary<string, string>{
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
            cb56.DataSource = new BindingSource(c56Entries, null);
            cb56.DisplayMember = "Value";
            cb56.ValueMember = "Key";
            cb56.SelectedIndex = -1;

            Dictionary<string, string> c57Entries = new Dictionary<string, string>{
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
            cb57.DataSource = new BindingSource(c57Entries, null);
            cb57.DisplayMember = "Value";
            cb57.ValueMember = "Key";
            cb57.SelectedIndex = -1;

            Dictionary<string, string> c58Entries = new Dictionary<string, string>{
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
            cb58.DataSource = new BindingSource(c58Entries, null);
            cb58.DisplayMember = "Value";
            cb58.ValueMember = "Key";
            cb58.SelectedIndex = -1;

            Dictionary<string, string> c59Entries = new Dictionary<string, string>{
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
            cb59.DataSource = new BindingSource(c59Entries, null);
            cb59.DisplayMember = "Value";
            cb59.ValueMember = "Key";
            cb59.SelectedIndex = -1;

            Dictionary<string, string> c510Entries = new Dictionary<string, string>{
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
            cb510.DataSource = new BindingSource(c510Entries, null);
            cb510.DisplayMember = "Value";
            cb510.ValueMember = "Key";
            cb510.SelectedIndex = -1;

            Dictionary<string, string> c511Entries = new Dictionary<string, string>{
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
            cb511.DataSource = new BindingSource(c511Entries, null);
            cb511.DisplayMember = "Value";
            cb511.ValueMember = "Key";
            cb511.SelectedIndex = -1;



            // ComboBox 6
            Dictionary<string, string> c61Entries = new Dictionary<string, string>{
                     { "1", "2016"}
                    ,{ "2", "2017"}
                    ,{ "3", "2018"}
                    ,{ "4", "2019"}
                    ,{ "5", "2020"}
                    ,{ "6", "2021"}
                };
            cb61.DataSource = new BindingSource(c61Entries, null);
            cb61.DisplayMember = "Value";
            cb61.ValueMember = "Key";
            cb61.SelectedIndex = -1;

            Dictionary<string, string> c62Entries = new Dictionary<string, string>{
                     { "1", "2016"}
                    ,{ "2", "2017"}
                    ,{ "3", "2018"}
                    ,{ "4", "2019"}
                    ,{ "5", "2020"}
                    ,{ "6", "2021"}
                };
            cb62.DataSource = new BindingSource(c62Entries, null);
            cb62.DisplayMember = "Value";
            cb62.ValueMember = "Key";
            cb62.SelectedIndex = -1;

            Dictionary<string, string> c63Entries = new Dictionary<string, string>{
                     { "1", "2016"}
                    ,{ "2", "2017"}
                    ,{ "3", "2018"}
                    ,{ "4", "2019"}
                    ,{ "5", "2020"}
                    ,{ "6", "2021"}
                };
            cb63.DataSource = new BindingSource(c63Entries, null);
            cb63.DisplayMember = "Value";
            cb63.ValueMember = "Key";
            cb63.SelectedIndex = -1;

            Dictionary<string, string> c64Entries = new Dictionary<string, string>{
                     { "1", "2016"}
                    ,{ "2", "2017"}
                    ,{ "3", "2018"}
                    ,{ "4", "2019"}
                    ,{ "5", "2020"}
                    ,{ "6", "2021"}
                };
            cb64.DataSource = new BindingSource(c64Entries, null);
            cb64.DisplayMember = "Value";
            cb64.ValueMember = "Key";
            cb64.SelectedIndex = -1;

            Dictionary<string, string> c65Entries = new Dictionary<string, string>{
                     { "1", "2016"}
                    ,{ "2", "2017"}
                    ,{ "3", "2018"}
                    ,{ "4", "2019"}
                    ,{ "5", "2020"}
                    ,{ "6", "2021"}
                };
            cb65.DataSource = new BindingSource(c65Entries, null);
            cb65.DisplayMember = "Value";
            cb65.ValueMember = "Key";
            cb65.SelectedIndex = -1;

            Dictionary<string, string> c66Entries = new Dictionary<string, string>{
                     { "1", "2016"}
                    ,{ "2", "2017"}
                    ,{ "3", "2018"}
                    ,{ "4", "2019"}
                    ,{ "5", "2020"}
                    ,{ "6", "2021"}
                };
            cb66.DataSource = new BindingSource(c66Entries, null);
            cb66.DisplayMember = "Value";
            cb66.ValueMember = "Key";
            cb66.SelectedIndex = -1;

            Dictionary<string, string> c67Entries = new Dictionary<string, string>{
                     { "1", "2016"}
                    ,{ "2", "2017"}
                    ,{ "3", "2018"}
                    ,{ "4", "2019"}
                    ,{ "5", "2020"}
                    ,{ "6", "2021"}
                };
            cb67.DataSource = new BindingSource(c67Entries, null);
            cb67.DisplayMember = "Value";
            cb67.ValueMember = "Key";
            cb67.SelectedIndex = -1;

            Dictionary<string, string> c68Entries = new Dictionary<string, string>{
                     { "1", "2016"}
                    ,{ "2", "2017"}
                    ,{ "3", "2018"}
                    ,{ "4", "2019"}
                    ,{ "5", "2020"}
                    ,{ "6", "2021"}
                };
            cb68.DataSource = new BindingSource(c68Entries, null);
            cb68.DisplayMember = "Value";
            cb68.ValueMember = "Key";
            cb68.SelectedIndex = -1;

            Dictionary<string, string> c69Entries = new Dictionary<string, string>{
                     { "1", "2016"}
                    ,{ "2", "2017"}
                    ,{ "3", "2018"}
                    ,{ "4", "2019"}
                    ,{ "5", "2020"}
                    ,{ "6", "2021"}
                };
            cb69.DataSource = new BindingSource(c69Entries, null);
            cb69.DisplayMember = "Value";
            cb69.ValueMember = "Key";
            cb69.SelectedIndex = -1;

            Dictionary<string, string> c610Entries = new Dictionary<string, string>{
                     { "1", "2016"}
                    ,{ "2", "2017"}
                    ,{ "3", "2018"}
                    ,{ "4", "2019"}
                    ,{ "5", "2020"}
                    ,{ "6", "2021"}
                };
            cb610.DataSource = new BindingSource(c610Entries, null);
            cb610.DisplayMember = "Value";
            cb610.ValueMember = "Key";
            cb610.SelectedIndex = -1;

            Dictionary<string, string> c611Entries = new Dictionary<string, string>{
                     { "1", "2016"}
                    ,{ "2", "2017"}
                    ,{ "3", "2018"}
                    ,{ "4", "2019"}
                    ,{ "5", "2020"}
                    ,{ "6", "2021"}
                };
            cb611.DataSource = new BindingSource(c611Entries, null);
            cb611.DisplayMember = "Value";
            cb611.ValueMember = "Key";
            cb611.SelectedIndex = -1;
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


        public void reset()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Clear();
                }
            }

            /*foreach (Control y in this.Controls)
            {
                if (y is CheckBox)
                {
                    ((CheckBox)y).Checked = false;
                }
            }*/

            foreach (Control z in this.Controls)
            {
                if (z is ComboBox)
                {
                    ((ComboBox)z).SelectedIndex = -1;
                }
            }
        }

        private void insertDataToSQLite(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            int counter = 0;
            string var1, var1Other, var2, var3, var4, var5, var6, var7, var8;
            int var9;
            string message, title;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();

            string pcb11 = cb11.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb11.SelectedItem).Key;
            string pcb61 = cb61.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb61.SelectedItem).Key;
            string pcb21 = cb21.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb21.SelectedItem).Key;
            string pcb31 = cb31.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb31.SelectedItem).Key;
            string pcb41 = cb41.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb41.SelectedItem).Key;
            string pcb51 = cb51.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb51.SelectedItem).Key;
            var1 = pcb11;
            var1Other = cb11_77.Text == "" ? "-1" : cb11_77.Text;
            var2 = pcb61;
            var3 = pcb21;
            var4 = pcb31;
            var5 = pcb41;
            var6 = pcb51;
            var7 = "51f980b1d00224dc";
            var8 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var9 = 0;
            sqlite_cmd.CommandText = "INSERT INTO q20toq25(placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, " +
                "monthOfDeath, deviceid, sysdate, createdAt, updatedAt, afterUpdateSyncStatus) " +
                "VALUES ('" + var1 + "','" + var1Other + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "','" + var6 + "','" + var7 + "','" + var8 + "','" + var8 + "','" + var8 + "','" + var9 + "')";
            sqlite_cmd.ExecuteNonQuery();
            counter = counter + 1;

            string pcb12 = cb12.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb12.SelectedItem).Key;
            string pcb62 = cb62.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb62.SelectedItem).Key;
            string pcb22 = cb22.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb22.SelectedItem).Key;
            string pcb32 = cb32.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb32.SelectedItem).Key;
            string pcb42 = cb42.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb42.SelectedItem).Key;
            string pcb52 = cb52.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb52.SelectedItem).Key;
            var1 = pcb12;
            var1Other = cb12_77.Text == "" ? "-1" : cb12_77.Text;
            var2 = pcb62;
            var3 = pcb22;
            var4 = pcb32;
            var5 = pcb42;
            var6 = pcb52;
            var7 = "51f980b1d00224dc";
            var8 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var9 = 0;
            sqlite_cmd.CommandText = "INSERT INTO q20toq25(placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, " +
                "monthOfDeath, deviceid, sysdate, createdAt, updatedAt, afterUpdateSyncStatus) " +
                "VALUES ('" + var1 + "','" + var1Other + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "','" + var6 + "','" + var7 + "','" + var8 + "','" + var8 + "','" + var8 + "','" + var9 + "')";
            sqlite_cmd.ExecuteNonQuery();
            counter = counter + 1;

            string pcb13 = cb13.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb13.SelectedItem).Key;
            string pcb63 = cb63.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb63.SelectedItem).Key;
            string pcb23 = cb23.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb23.SelectedItem).Key;
            string pcb33 = cb33.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb33.SelectedItem).Key;
            string pcb43 = cb43.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb43.SelectedItem).Key;
            string pcb53 = cb53.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb53.SelectedItem).Key;
            var1 = pcb13;
            var1Other = cb13_77.Text == "" ? "-1" : cb13_77.Text;
            var2 = pcb63;
            var3 = pcb23;
            var4 = pcb33;
            var5 = pcb43;
            var6 = pcb53;
            var7 = "51f980b1d00224dc";
            var8 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var9 = 0;
            sqlite_cmd.CommandText = "INSERT INTO q20toq25(placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, " +
                "monthOfDeath, deviceid, sysdate, createdAt, updatedAt, afterUpdateSyncStatus) " +
                "VALUES ('" + var1 + "','" + var1Other + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "','" + var6 + "','" + var7 + "','" + var8 + "','" + var8 + "','" + var8 + "','" + var9 + "')";
            sqlite_cmd.ExecuteNonQuery();
            counter = counter + 1;

            string pcb14 = cb14.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb14.SelectedItem).Key;
            string pcb64 = cb64.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb64.SelectedItem).Key;
            string pcb24 = cb24.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb24.SelectedItem).Key;
            string pcb34 = cb34.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb34.SelectedItem).Key;
            string pcb44 = cb44.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb44.SelectedItem).Key;
            string pcb54 = cb54.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb54.SelectedItem).Key;
            var1 = pcb14;
            var1Other = cb14_77.Text == "" ? "-1" : cb14_77.Text;
            var2 = pcb64;
            var3 = pcb24;
            var4 = pcb34;
            var5 = pcb44;
            var6 = pcb54;
            var7 = "51f980b1d00224dc";
            var8 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var9 = 0;
            sqlite_cmd.CommandText = "INSERT INTO q20toq25(placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, " +
                "monthOfDeath, deviceid, sysdate, createdAt, updatedAt, afterUpdateSyncStatus) " +
                "VALUES ('" + var1 + "','" + var1Other + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "','" + var6 + "','" + var7 + "','" + var8 + "','" + var8 + "','" + var8 + "','" + var9 + "')";
            sqlite_cmd.ExecuteNonQuery();
            counter = counter + 1;

            string pcb15 = cb15.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb15.SelectedItem).Key;
            string pcb65 = cb65.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb65.SelectedItem).Key;
            string pcb25 = cb25.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb25.SelectedItem).Key;
            string pcb35 = cb35.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb35.SelectedItem).Key;
            string pcb45 = cb45.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb45.SelectedItem).Key;
            string pcb55 = cb55.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb55.SelectedItem).Key;
            var1 = pcb15;
            var1Other = cb15_77.Text == "" ? "-1" : cb15_77.Text;
            var2 = pcb65;
            var3 = pcb25;
            var4 = pcb35;
            var5 = pcb45;
            var6 = pcb55;
            var7 = "51f980b1d00224dc";
            var8 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var9 = 0;
            sqlite_cmd.CommandText = "INSERT INTO q20toq25(placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, " +
                "monthOfDeath, deviceid, sysdate, createdAt, updatedAt, afterUpdateSyncStatus) " +
                "VALUES ('" + var1 + "','" + var1Other + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "','" + var6 + "','" + var7 + "','" + var8 + "','" + var8 + "','" + var8 + "','" + var9 + "')";
            sqlite_cmd.ExecuteNonQuery();
            counter = counter + 1;

            string pcb16 = cb16.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb16.SelectedItem).Key;
            string pcb66 = cb66.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb66.SelectedItem).Key;
            string pcb26 = cb26.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb26.SelectedItem).Key;
            string pcb36 = cb36.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb36.SelectedItem).Key;
            string pcb46 = cb46.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb46.SelectedItem).Key;
            string pcb56 = cb56.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb56.SelectedItem).Key;
            var1 = pcb16;
            var1Other = cb16_77.Text == "" ? "-1" : cb16_77.Text;
            var2 = pcb66;
            var3 = pcb26;
            var4 = pcb36;
            var5 = pcb46;
            var6 = pcb56;
            var7 = "51f980b1d00224dc";
            var8 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var9 = 0;
            sqlite_cmd.CommandText = "INSERT INTO q20toq25(placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, " +
                "monthOfDeath, deviceid, sysdate, createdAt, updatedAt, afterUpdateSyncStatus) " +
                "VALUES ('" + var1 + "','" + var1Other + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "','" + var6 + "','" + var7 + "','" + var8 + "','" + var8 + "','" + var8 + "','" + var9 + "')";
            sqlite_cmd.ExecuteNonQuery();
            counter = counter + 1;

            string pcb17 = cb17.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb17.SelectedItem).Key;
            string pcb67 = cb67.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb67.SelectedItem).Key;
            string pcb27 = cb27.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb27.SelectedItem).Key;
            string pcb37 = cb37.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb37.SelectedItem).Key;
            string pcb47 = cb47.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb47.SelectedItem).Key;
            string pcb57 = cb57.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb57.SelectedItem).Key;
            var1 = pcb17;
            var1Other = cb17_77.Text == "" ? "-1" : cb17_77.Text;
            var2 = pcb67;
            var3 = pcb27;
            var4 = pcb37;
            var5 = pcb47;
            var6 = pcb57;
            var7 = "51f980b1d00224dc";
            var8 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var9 = 0;
            sqlite_cmd.CommandText = "INSERT INTO q20toq25(placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, " +
                "monthOfDeath, deviceid, sysdate, createdAt, updatedAt, afterUpdateSyncStatus) " +
                "VALUES ('" + var1 + "','" + var1Other + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "','" + var6 + "','" + var7 + "','" + var8 + "','" + var8 + "','" + var8 + "','" + var9 + "')";
            sqlite_cmd.ExecuteNonQuery();
            counter = counter + 1;

            string pcb18 = cb18.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb18.SelectedItem).Key;
            string pcb68 = cb68.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb68.SelectedItem).Key;
            string pcb28 = cb28.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb28.SelectedItem).Key;
            string pcb38 = cb38.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb38.SelectedItem).Key;
            string pcb48 = cb48.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb48.SelectedItem).Key;
            string pcb58 = cb58.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb58.SelectedItem).Key;
            var1 = pcb18;
            var1Other = cb18_77.Text == "" ? "-1" : cb18_77.Text;
            var2 = pcb68;
            var3 = pcb28;
            var4 = pcb38;
            var5 = pcb48;
            var6 = pcb58;
            var7 = "51f980b1d00224dc";
            var8 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var9 = 0;
            sqlite_cmd.CommandText = "INSERT INTO q20toq25(placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, " +
                "monthOfDeath, deviceid, sysdate, createdAt, updatedAt, afterUpdateSyncStatus) " +
                "VALUES ('" + var1 + "','" + var1Other + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "','" + var6 + "','" + var7 + "','" + var8 + "','" + var8 + "','" + var8 + "','" + var9 + "')";
            sqlite_cmd.ExecuteNonQuery();
            counter = counter + 1;

            string pcb19 = cb19.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb19.SelectedItem).Key;
            string pcb69 = cb69.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb69.SelectedItem).Key;
            string pcb29 = cb29.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb29.SelectedItem).Key;
            string pcb39 = cb39.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb39.SelectedItem).Key;
            string pcb49 = cb49.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb49.SelectedItem).Key;
            string pcb59 = cb59.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb59.SelectedItem).Key;
            var1 = pcb19;
            var1Other = cb19_77.Text == "" ? "-1" : cb19_77.Text;
            var2 = pcb69;
            var3 = pcb29;
            var4 = pcb39;
            var5 = pcb49;
            var6 = pcb59;
            var7 = "51f980b1d00224dc";
            var8 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var9 = 0;
            sqlite_cmd.CommandText = "INSERT INTO q20toq25(placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, " +
                "monthOfDeath, deviceid, sysdate, createdAt, updatedAt, afterUpdateSyncStatus) " +
                "VALUES ('" + var1 + "','" + var1Other + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "','" + var6 + "','" + var7 + "','" + var8 + "','" + var8 + "','" + var8 + "','" + var9 + "')";
            sqlite_cmd.ExecuteNonQuery();
            counter = counter + 1;

            string pcb110 = cb110.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb110.SelectedItem).Key;
            string pcb610 = cb610.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb610.SelectedItem).Key;
            string pcb210 = cb210.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb210.SelectedItem).Key;
            string pcb310 = cb310.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb310.SelectedItem).Key;
            string pcb410 = cb410.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb410.SelectedItem).Key;
            string pcb510 = cb510.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb510.SelectedItem).Key;
            var1 = pcb110;
            var1Other = cb110_77.Text == "" ? "-1" : cb110_77.Text;
            var2 = pcb610;
            var3 = pcb210;
            var4 = pcb310;
            var5 = pcb410;
            var6 = pcb510;
            var7 = "51f980b1d00224dc";
            var8 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var9 = 0;
            sqlite_cmd.CommandText = "INSERT INTO q20toq25(placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, " +
                "monthOfDeath, deviceid, sysdate, createdAt, updatedAt, afterUpdateSyncStatus) " +
                "VALUES ('" + var1 + "','" + var1Other + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "','" + var6 + "','" + var7 + "','" + var8 + "','" + var8 + "','" + var8 + "','" + var9 + "')";
            sqlite_cmd.ExecuteNonQuery();
            counter = counter + 1;

            string pcb111 = cb111.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb111.SelectedItem).Key;
            string pcb611 = cb611.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb611.SelectedItem).Key;
            string pcb211 = cb211.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb211.SelectedItem).Key;
            string pcb311 = cb311.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb311.SelectedItem).Key;
            string pcb411 = cb411.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb411.SelectedItem).Key;
            string pcb511 = cb511.SelectedIndex == -1 ? "-1" : ((KeyValuePair<string, string>)cb511.SelectedItem).Key;
            var1 = pcb111;
            var1Other = cb111_77.Text == "" ? "-1" : cb111_77.Text;
            var2 = pcb611;
            var3 = pcb211;
            var4 = pcb311;
            var5 = pcb411;
            var6 = pcb511;
            var7 = "51f980b1d00224dc";
            var8 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var9 = 0;
            sqlite_cmd.CommandText = "INSERT INTO q20toq25(placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, " +
                "monthOfDeath, deviceid, sysdate, createdAt, updatedAt, afterUpdateSyncStatus) " +
                "VALUES ('" + var1 + "','" + var1Other + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "','" + var6 + "','" + var7 + "','" + var8 + "','" + var8 + "','" + var8 + "','" + var9 + "')";
            sqlite_cmd.ExecuteNonQuery();
            counter = counter + 1;

            sqlite_conn.Close();


            if (counter == 11)
            {
                message = "Insertion was successful";
                title = "Success";
                reset();
            }
            else
            {
                message = "Some error occured";
                title = "Failure";
            }

            MessageBox.Show(message, title);
            /*sqlite_cmd.CommandText = "INSERT INTO q20toq25(placeOfDelivery, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, " +
                "monthOfDeath, deviceid, sysdate) " +
                "VALUES ('" + var1 + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "','" + var6 + "','" + var7 + "','" + var8 + "')";

            if (sqlite_cmd.ExecuteNonQuery() > 0)
            {
                string message = "Insertion was successful";
                string title = "Success";
                MessageBox.Show(message, title);
                reset();
            }
            else
            {
                string message = "Some error occured";
                string title = "Failure";
                MessageBox.Show(message, title);
            }*/
        }


        private void syncData(object sender, EventArgs e)
        {
            string message, title;
            SQLiteConnection conn;
            conn = CreateConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT _id, placeOfDelivery, placeOfDeliveryOther, yearOfBirth, bornWithinLast4Weeks, diedWithinFirstWeek, diedWithinFirst4Weeks, monthOfDeath, deviceid, sysdate, createdAt, updatedAt FROM q20toq25 where synced is null or synced = ''";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlite_cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                string table_column_value = DataTableToJSON(dt);
                var table_data = "[{\"table\":\"q20t0q25\"}, " + table_column_value + "]";

                string URL = "http://F38158/fr/api/sync.php";
                var data = postData(table_data, URL);

                if (data != null)
                {
                    message = "Sync was successful";
                    title = "Success";
                    char synced;
                    string synced_date;
                    synced = '1';
                    synced_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sqlite_cmd.CommandText = "UPDATE q20toq25 set synced = '" + synced + "', synced_date = '" + synced_date + "' where _id = " + dt.Rows[i][0].ToString();
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
                message = "No new records are there";
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
            ((HttpWebRequest)request).UserAgent ="Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
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

        private void viewForms_Click(object sender, EventArgs e)
        {
            viewForms form2 = new viewForms();
            form2.Show();
        }

        private void cb11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb11.SelectedIndex == 14) {
                cb11_77.Enabled = true;
                cb11_77.Focus();
            } else {
                cb11_77.Text = "";
                cb11_77.Enabled = false;
            }
            
        }

        private void cb12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb12.SelectedIndex == 14)
            {
                cb12_77.Enabled = true;
                cb12_77.Focus();
            }
            else
            {
                cb12_77.Text = "";
                cb12_77.Enabled = false;
            }

        }

        private void cb13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb13.SelectedIndex == 14)
            {
                cb13_77.Enabled = true;
                cb13_77.Focus();
            }
            else
            {
                cb13_77.Text = "";
                cb13_77.Enabled = false;
            }

        }

        private void cb14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb14.SelectedIndex == 14)
            {
                cb14_77.Enabled = true;
                cb14_77.Focus();
            }
            else
            {
                cb14_77.Text = "";
                cb14_77.Enabled = false;
            }

        }

        private void cb15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb15.SelectedIndex == 14)
            {
                cb15_77.Enabled = true;
                cb15_77.Focus();
            }
            else
            {
                cb15_77.Text = "";
                cb15_77.Enabled = false;
            }

        }

        private void cb16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb16.SelectedIndex == 14)
            {
                cb16_77.Enabled = true;
                cb16_77.Focus();
            }
            else
            {
                cb16_77.Text = "";
                cb16_77.Enabled = false;
            }

        }

        private void cb17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb17.SelectedIndex == 14)
            {
                cb17_77.Enabled = true;
                cb17_77.Focus();
            }
            else
            {
                cb17_77.Text = "";
                cb17_77.Enabled = false;
            }

        }

        private void cb18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb18.SelectedIndex == 14)
            {
                cb18_77.Enabled = true;
                cb18_77.Focus();
            }
            else
            {
                cb18_77.Text = "";
                cb18_77.Enabled = false;
            }

        }

        private void cb19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb19.SelectedIndex == 14)
            {
                cb19_77.Enabled = true;
                cb19_77.Focus();
            }
            else
            {
                cb19_77.Text = "";
                cb19_77.Enabled = false;
            }

        }

        private void cb110_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb110.SelectedIndex == 14)
            {
                cb110_77.Enabled = true;
                cb110_77.Focus();
            }
            else
            {
                cb110_77.Text = "";
                cb110_77.Enabled = false;
            }

        }

        private void cb111_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb111.SelectedIndex == 14)
            {
                cb111_77.Enabled = true;
                cb111_77.Focus();
            }
            else
            {
                cb111_77.Text = "";
                cb111_77.Enabled = false;
            }

        }

    }

}
