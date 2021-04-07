
namespace childInformation
{
    partial class viewForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.placeOfDelivery = new System.Windows.Forms.ComboBox();
            this.lPlaceOfDelivery = new System.Windows.Forms.Label();
            this.monthOfDeath = new System.Windows.Forms.ComboBox();
            this.lMonthOfDeath = new System.Windows.Forms.Label();
            this.diedWithinFirst4Weeks = new System.Windows.Forms.ComboBox();
            this.lDiedWithinFirst4Weeks = new System.Windows.Forms.Label();
            this.diedWithinFirstWeek = new System.Windows.Forms.ComboBox();
            this.lDiedWithinFirstWeek = new System.Windows.Forms.Label();
            this.bornWithinLast4Weeks = new System.Windows.Forms.ComboBox();
            this.lBornWithinLast4Weeks = new System.Windows.Forms.Label();
            this.btnSyncUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lYearOfBirth = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yearOfBirth = new System.Windows.Forms.ComboBox();
            this.placeOfDeliveryOther = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // placeOfDelivery
            // 
            this.placeOfDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOfDelivery.FormattingEnabled = true;
            this.placeOfDelivery.Location = new System.Drawing.Point(715, 513);
            this.placeOfDelivery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placeOfDelivery.Name = "placeOfDelivery";
            this.placeOfDelivery.Size = new System.Drawing.Size(639, 33);
            this.placeOfDelivery.TabIndex = 48;
            this.placeOfDelivery.SelectedIndexChanged += new System.EventHandler(this.placeOfDelivery_SelectedIndexChanged);
            // 
            // lPlaceOfDelivery
            // 
            this.lPlaceOfDelivery.AutoSize = true;
            this.lPlaceOfDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlaceOfDelivery.Location = new System.Drawing.Point(503, 521);
            this.lPlaceOfDelivery.Name = "lPlaceOfDelivery";
            this.lPlaceOfDelivery.Size = new System.Drawing.Size(168, 25);
            this.lPlaceOfDelivery.TabIndex = 47;
            this.lPlaceOfDelivery.Text = "Place of Delivery?";
            // 
            // monthOfDeath
            // 
            this.monthOfDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthOfDeath.FormattingEnabled = true;
            this.monthOfDeath.Location = new System.Drawing.Point(715, 832);
            this.monthOfDeath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthOfDeath.Name = "monthOfDeath";
            this.monthOfDeath.Size = new System.Drawing.Size(639, 33);
            this.monthOfDeath.TabIndex = 46;
            // 
            // lMonthOfDeath
            // 
            this.lMonthOfDeath.AutoSize = true;
            this.lMonthOfDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMonthOfDeath.Location = new System.Drawing.Point(185, 840);
            this.lMonthOfDeath.Name = "lMonthOfDeath";
            this.lMonthOfDeath.Size = new System.Drawing.Size(486, 25);
            this.lMonthOfDeath.TabIndex = 45;
            this.lMonthOfDeath.Text = "During which month did he/she die? (Circle one option)";
            // 
            // diedWithinFirst4Weeks
            // 
            this.diedWithinFirst4Weeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diedWithinFirst4Weeks.FormattingEnabled = true;
            this.diedWithinFirst4Weeks.Location = new System.Drawing.Point(715, 780);
            this.diedWithinFirst4Weeks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diedWithinFirst4Weeks.Name = "diedWithinFirst4Weeks";
            this.diedWithinFirst4Weeks.Size = new System.Drawing.Size(639, 33);
            this.diedWithinFirst4Weeks.TabIndex = 44;
            // 
            // lDiedWithinFirst4Weeks
            // 
            this.lDiedWithinFirst4Weeks.AutoSize = true;
            this.lDiedWithinFirst4Weeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDiedWithinFirst4Weeks.Location = new System.Drawing.Point(260, 788);
            this.lDiedWithinFirst4Weeks.Name = "lDiedWithinFirst4Weeks";
            this.lDiedWithinFirst4Weeks.Size = new System.Drawing.Size(411, 25);
            this.lDiedWithinFirst4Weeks.TabIndex = 43;
            this.lDiedWithinFirst4Weeks.Text = "Did the baby die within the first 4 weeks of life?";
            // 
            // diedWithinFirstWeek
            // 
            this.diedWithinFirstWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diedWithinFirstWeek.FormattingEnabled = true;
            this.diedWithinFirstWeek.Location = new System.Drawing.Point(715, 727);
            this.diedWithinFirstWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diedWithinFirstWeek.Name = "diedWithinFirstWeek";
            this.diedWithinFirstWeek.Size = new System.Drawing.Size(639, 33);
            this.diedWithinFirstWeek.TabIndex = 42;
            // 
            // lDiedWithinFirstWeek
            // 
            this.lDiedWithinFirstWeek.AutoSize = true;
            this.lDiedWithinFirstWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDiedWithinFirstWeek.Location = new System.Drawing.Point(275, 735);
            this.lDiedWithinFirstWeek.Name = "lDiedWithinFirstWeek";
            this.lDiedWithinFirstWeek.Size = new System.Drawing.Size(396, 25);
            this.lDiedWithinFirstWeek.TabIndex = 41;
            this.lDiedWithinFirstWeek.Text = "Did the baby died within the first week of life?";
            // 
            // bornWithinLast4Weeks
            // 
            this.bornWithinLast4Weeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bornWithinLast4Weeks.FormattingEnabled = true;
            this.bornWithinLast4Weeks.Location = new System.Drawing.Point(715, 673);
            this.bornWithinLast4Weeks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bornWithinLast4Weeks.Name = "bornWithinLast4Weeks";
            this.bornWithinLast4Weeks.Size = new System.Drawing.Size(639, 33);
            this.bornWithinLast4Weeks.TabIndex = 40;
            // 
            // lBornWithinLast4Weeks
            // 
            this.lBornWithinLast4Weeks.AutoSize = true;
            this.lBornWithinLast4Weeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBornWithinLast4Weeks.Location = new System.Drawing.Point(76, 681);
            this.lBornWithinLast4Weeks.Name = "lBornWithinLast4Weeks";
            this.lBornWithinLast4Weeks.Size = new System.Drawing.Size(595, 25);
            this.lBornWithinLast4Weeks.TabIndex = 39;
            this.lBornWithinLast4Weeks.Text = "If baby was born this year, was he/she born within the last 4 weeks?";
            // 
            // btnSyncUpdate
            // 
            this.btnSyncUpdate.BackColor = System.Drawing.Color.HotPink;
            this.btnSyncUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyncUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSyncUpdate.Location = new System.Drawing.Point(1160, 902);
            this.btnSyncUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSyncUpdate.Name = "btnSyncUpdate";
            this.btnSyncUpdate.Size = new System.Drawing.Size(214, 71);
            this.btnSyncUpdate.TabIndex = 38;
            this.btnSyncUpdate.Text = "Sync to Server";
            this.btnSyncUpdate.UseVisualStyleBackColor = false;
            this.btnSyncUpdate.Click += new System.EventHandler(this.btnSyncUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(920, 902);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(214, 71);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(686, 902);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(214, 71);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lYearOfBirth
            // 
            this.lYearOfBirth.AutoSize = true;
            this.lYearOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lYearOfBirth.Location = new System.Drawing.Point(482, 629);
            this.lYearOfBirth.Name = "lYearOfBirth";
            this.lYearOfBirth.Size = new System.Drawing.Size(189, 25);
            this.lYearOfBirth.TabIndex = 32;
            this.lYearOfBirth.Text = "Year of baby\'s birth?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(45, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1929, 443);
            this.dataGridView1.TabIndex = 51;
            // 
            // yearOfBirth
            // 
            this.yearOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOfBirth.FormattingEnabled = true;
            this.yearOfBirth.Location = new System.Drawing.Point(715, 621);
            this.yearOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearOfBirth.Name = "yearOfBirth";
            this.yearOfBirth.Size = new System.Drawing.Size(639, 33);
            this.yearOfBirth.TabIndex = 52;
            // 
            // placeOfDeliveryOther
            // 
            this.placeOfDeliveryOther.Enabled = false;
            this.placeOfDeliveryOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOfDeliveryOther.Location = new System.Drawing.Point(715, 567);
            this.placeOfDeliveryOther.Name = "placeOfDeliveryOther";
            this.placeOfDeliveryOther.Size = new System.Drawing.Size(639, 28);
            this.placeOfDeliveryOther.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Other";
            // 
            // viewForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2025, 1131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placeOfDeliveryOther);
            this.Controls.Add(this.yearOfBirth);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.placeOfDelivery);
            this.Controls.Add(this.lPlaceOfDelivery);
            this.Controls.Add(this.monthOfDeath);
            this.Controls.Add(this.lMonthOfDeath);
            this.Controls.Add(this.diedWithinFirst4Weeks);
            this.Controls.Add(this.lDiedWithinFirst4Weeks);
            this.Controls.Add(this.diedWithinFirstWeek);
            this.Controls.Add(this.lDiedWithinFirstWeek);
            this.Controls.Add(this.bornWithinLast4Weeks);
            this.Controls.Add(this.lBornWithinLast4Weeks);
            this.Controls.Add(this.btnSyncUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lYearOfBirth);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "viewForms";
            this.Text = "All Forms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox placeOfDelivery;
        private System.Windows.Forms.Label lPlaceOfDelivery;
        private System.Windows.Forms.ComboBox monthOfDeath;
        private System.Windows.Forms.Label lMonthOfDeath;
        private System.Windows.Forms.ComboBox diedWithinFirst4Weeks;
        private System.Windows.Forms.Label lDiedWithinFirst4Weeks;
        private System.Windows.Forms.ComboBox diedWithinFirstWeek;
        private System.Windows.Forms.Label lDiedWithinFirstWeek;
        private System.Windows.Forms.ComboBox bornWithinLast4Weeks;
        private System.Windows.Forms.Label lBornWithinLast4Weeks;
        private System.Windows.Forms.Button btnSyncUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lYearOfBirth;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox yearOfBirth;
        private System.Windows.Forms.TextBox placeOfDeliveryOther;
        private System.Windows.Forms.Label label1;
    }
}