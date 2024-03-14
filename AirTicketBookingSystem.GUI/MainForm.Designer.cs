namespace AirTicketBookingSystem.GUI
{
    partial class MainForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvOutboundFlight = new System.Windows.Forms.DataGridView();
            this.IDOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightNumberOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CabinTypeOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CabinPriceOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfStopOutbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblCabinType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpOutbound = new System.Windows.Forms.DateTimePicker();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblOutbound = new System.Windows.Forms.Label();
            this.rdbOneWay = new System.Windows.Forms.RadioButton();
            this.rdbReturn = new System.Windows.Forms.RadioButton();
            this.cbCabinType = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.lblOutboundDetail = new System.Windows.Forms.Label();
            this.lblReturnDetail = new System.Windows.Forms.Label();
            this.checkboxOutboundThreeDay = new System.Windows.Forms.CheckBox();
            this.checkboxReturnThreeDay = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.groupBoxConfirmBooking = new System.Windows.Forms.GroupBox();
            this.lblPassenger = new System.Windows.Forms.Label();
            this.txtPassenger = new System.Windows.Forms.TextBox();
            this.dgvReturnFilght = new System.Windows.Forms.DataGridView();
            this.IDReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightNumberReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CabinTypeReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CabinPriceReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfStopReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutboundFlight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxConfirmBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnFilght)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(999, 65);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 53);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SeachBtn_Click);
            // 
            // dgvOutboundFlight
            // 
            this.dgvOutboundFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutboundFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDOutbound,
            this.FromOutbound,
            this.ToOutbound,
            this.DateOutbound,
            this.TimeOutbound,
            this.FlightNumberOutbound,
            this.CabinTypeOutbound,
            this.CabinPriceOutbound,
            this.NumberOfStopOutbound});
            this.dgvOutboundFlight.Location = new System.Drawing.Point(38, 184);
            this.dgvOutboundFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOutboundFlight.Name = "dgvOutboundFlight";
            this.dgvOutboundFlight.Size = new System.Drawing.Size(1174, 167);
            this.dgvOutboundFlight.TabIndex = 1;
            this.dgvOutboundFlight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOutboundFlight_CellClick);
            // 
            // IDOutbound
            // 
            this.IDOutbound.DataPropertyName = "ID";
            this.IDOutbound.Frozen = true;
            this.IDOutbound.HeaderText = "ID";
            this.IDOutbound.Name = "IDOutbound";
            // 
            // FromOutbound
            // 
            this.FromOutbound.DataPropertyName = "From";
            this.FromOutbound.Frozen = true;
            this.FromOutbound.HeaderText = "From";
            this.FromOutbound.Name = "FromOutbound";
            // 
            // ToOutbound
            // 
            this.ToOutbound.DataPropertyName = "To";
            this.ToOutbound.Frozen = true;
            this.ToOutbound.HeaderText = "To";
            this.ToOutbound.Name = "ToOutbound";
            // 
            // DateOutbound
            // 
            this.DateOutbound.DataPropertyName = "Date";
            this.DateOutbound.Frozen = true;
            this.DateOutbound.HeaderText = "Date";
            this.DateOutbound.Name = "DateOutbound";
            // 
            // TimeOutbound
            // 
            this.TimeOutbound.DataPropertyName = "Time";
            this.TimeOutbound.Frozen = true;
            this.TimeOutbound.HeaderText = "Time";
            this.TimeOutbound.Name = "TimeOutbound";
            // 
            // FlightNumberOutbound
            // 
            this.FlightNumberOutbound.DataPropertyName = "FlightNumber";
            this.FlightNumberOutbound.Frozen = true;
            this.FlightNumberOutbound.HeaderText = "Flight Number";
            this.FlightNumberOutbound.Name = "FlightNumberOutbound";
            this.FlightNumberOutbound.Width = 150;
            // 
            // CabinTypeOutbound
            // 
            this.CabinTypeOutbound.DataPropertyName = "CabinType";
            this.CabinTypeOutbound.Frozen = true;
            this.CabinTypeOutbound.HeaderText = "Cabin Type";
            this.CabinTypeOutbound.Name = "CabinTypeOutbound";
            this.CabinTypeOutbound.Width = 200;
            // 
            // CabinPriceOutbound
            // 
            this.CabinPriceOutbound.DataPropertyName = "CabinPrice";
            this.CabinPriceOutbound.Frozen = true;
            this.CabinPriceOutbound.HeaderText = "CabinPrice";
            this.CabinPriceOutbound.Name = "CabinPriceOutbound";
            // 
            // NumberOfStopOutbound
            // 
            this.NumberOfStopOutbound.DataPropertyName = "NumberOfStop";
            this.NumberOfStopOutbound.Frozen = true;
            this.NumberOfStopOutbound.HeaderText = "Number Of Stop";
            this.NumberOfStopOutbound.Name = "NumberOfStopOutbound";
            this.NumberOfStopOutbound.Width = 150;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(60, 30);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(44, 17);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(350, 30);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 17);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To";
            // 
            // lblCabinType
            // 
            this.lblCabinType.AutoSize = true;
            this.lblCabinType.Location = new System.Drawing.Point(664, 30);
            this.lblCabinType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCabinType.Name = "lblCabinType";
            this.lblCabinType.Size = new System.Drawing.Size(98, 17);
            this.lblCabinType.TabIndex = 7;
            this.lblCabinType.Text = "Cabin Types";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpReturn);
            this.groupBox1.Controls.Add(this.dtpOutbound);
            this.groupBox1.Controls.Add(this.lblReturn);
            this.groupBox1.Controls.Add(this.lblOutbound);
            this.groupBox1.Controls.Add(this.rdbOneWay);
            this.groupBox1.Controls.Add(this.rdbReturn);
            this.groupBox1.Controls.Add(this.cbCabinType);
            this.groupBox1.Controls.Add(this.cbTo);
            this.groupBox1.Controls.Add(this.cbFrom);
            this.groupBox1.Controls.Add(this.lblCabinType);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1170, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Passengers";
            // 
            // dtpReturn
            // 
            this.dtpReturn.CustomFormat = "dd/MM/yyyy";
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturn.Location = new System.Drawing.Point(761, 100);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(200, 23);
            this.dtpReturn.TabIndex = 16;
            this.dtpReturn.Value = new System.DateTime(2018, 10, 20, 0, 0, 0, 0);
            // 
            // dtpOutbound
            // 
            this.dtpOutbound.CustomFormat = "dd/MM/yyyy";
            this.dtpOutbound.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOutbound.Location = new System.Drawing.Point(428, 100);
            this.dtpOutbound.Name = "dtpOutbound";
            this.dtpOutbound.Size = new System.Drawing.Size(200, 23);
            this.dtpOutbound.TabIndex = 15;
            this.dtpOutbound.Value = new System.DateTime(2018, 10, 10, 0, 0, 0, 0);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(667, 100);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(57, 17);
            this.lblReturn.TabIndex = 14;
            this.lblReturn.Text = "Return";
            // 
            // lblOutbound
            // 
            this.lblOutbound.AutoSize = true;
            this.lblOutbound.Location = new System.Drawing.Point(341, 100);
            this.lblOutbound.Name = "lblOutbound";
            this.lblOutbound.Size = new System.Drawing.Size(79, 17);
            this.lblOutbound.TabIndex = 13;
            this.lblOutbound.Text = "Outbound";
            // 
            // rdbOneWay
            // 
            this.rdbOneWay.AutoSize = true;
            this.rdbOneWay.Location = new System.Drawing.Point(173, 100);
            this.rdbOneWay.Name = "rdbOneWay";
            this.rdbOneWay.Size = new System.Drawing.Size(92, 21);
            this.rdbOneWay.TabIndex = 12;
            this.rdbOneWay.TabStop = true;
            this.rdbOneWay.Text = "One Way";
            this.rdbOneWay.UseVisualStyleBackColor = true;
            this.rdbOneWay.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // rdbReturn
            // 
            this.rdbReturn.AutoSize = true;
            this.rdbReturn.Location = new System.Drawing.Point(63, 100);
            this.rdbReturn.Name = "rdbReturn";
            this.rdbReturn.Size = new System.Drawing.Size(75, 21);
            this.rdbReturn.TabIndex = 11;
            this.rdbReturn.TabStop = true;
            this.rdbReturn.Text = "Return";
            this.rdbReturn.UseVisualStyleBackColor = true;
            // 
            // cbCabinType
            // 
            this.cbCabinType.FormattingEnabled = true;
            this.cbCabinType.Location = new System.Drawing.Point(794, 30);
            this.cbCabinType.Name = "cbCabinType";
            this.cbCabinType.Size = new System.Drawing.Size(121, 24);
            this.cbCabinType.TabIndex = 10;
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(405, 30);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(121, 24);
            this.cbTo.TabIndex = 9;
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(120, 30);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(121, 24);
            this.cbFrom.TabIndex = 8;
            // 
            // lblOutboundDetail
            // 
            this.lblOutboundDetail.AutoSize = true;
            this.lblOutboundDetail.Location = new System.Drawing.Point(38, 165);
            this.lblOutboundDetail.Name = "lblOutboundDetail";
            this.lblOutboundDetail.Size = new System.Drawing.Size(139, 13);
            this.lblOutboundDetail.TabIndex = 10;
            this.lblOutboundDetail.Text = "Outbound flight details:";
            // 
            // lblReturnDetail
            // 
            this.lblReturnDetail.AutoSize = true;
            this.lblReturnDetail.Location = new System.Drawing.Point(35, 382);
            this.lblReturnDetail.Name = "lblReturnDetail";
            this.lblReturnDetail.Size = new System.Drawing.Size(122, 13);
            this.lblReturnDetail.TabIndex = 11;
            this.lblReturnDetail.Text = "Return flight details:";
            // 
            // checkboxOutboundThreeDay
            // 
            this.checkboxOutboundThreeDay.AutoSize = true;
            this.checkboxOutboundThreeDay.Location = new System.Drawing.Point(983, 166);
            this.checkboxOutboundThreeDay.Name = "checkboxOutboundThreeDay";
            this.checkboxOutboundThreeDay.Size = new System.Drawing.Size(225, 17);
            this.checkboxOutboundThreeDay.TabIndex = 12;
            this.checkboxOutboundThreeDay.Text = "Display three days before and after";
            this.checkboxOutboundThreeDay.UseVisualStyleBackColor = true;
            this.checkboxOutboundThreeDay.CheckedChanged += new System.EventHandler(this.CheckboxOutboundThreeDay_CheckedChanged);
            // 
            // checkboxReturnThreeDay
            // 
            this.checkboxReturnThreeDay.AutoSize = true;
            this.checkboxReturnThreeDay.Location = new System.Drawing.Point(987, 380);
            this.checkboxReturnThreeDay.Name = "checkboxReturnThreeDay";
            this.checkboxReturnThreeDay.Size = new System.Drawing.Size(225, 17);
            this.checkboxReturnThreeDay.TabIndex = 13;
            this.checkboxReturnThreeDay.Text = "Display three days before and after";
            this.checkboxReturnThreeDay.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1087, 596);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 53);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.Location = new System.Drawing.Point(303, 23);
            this.btnBookFlight.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(125, 53);
            this.btnBookFlight.TabIndex = 18;
            this.btnBookFlight.Text = "Book Flight";
            this.btnBookFlight.UseVisualStyleBackColor = true;
            this.btnBookFlight.Click += new System.EventHandler(this.BookFlightBtn_Click);
            // 
            // groupBoxConfirmBooking
            // 
            this.groupBoxConfirmBooking.Controls.Add(this.lblPassenger);
            this.groupBoxConfirmBooking.Controls.Add(this.txtPassenger);
            this.groupBoxConfirmBooking.Controls.Add(this.btnBookFlight);
            this.groupBoxConfirmBooking.Location = new System.Drawing.Point(322, 573);
            this.groupBoxConfirmBooking.Name = "groupBoxConfirmBooking";
            this.groupBoxConfirmBooking.Size = new System.Drawing.Size(478, 100);
            this.groupBoxConfirmBooking.TabIndex = 19;
            this.groupBoxConfirmBooking.TabStop = false;
            this.groupBoxConfirmBooking.Text = "Confirm booking for";
            // 
            // lblPassenger
            // 
            this.lblPassenger.AutoSize = true;
            this.lblPassenger.Location = new System.Drawing.Point(177, 38);
            this.lblPassenger.Name = "lblPassenger";
            this.lblPassenger.Size = new System.Drawing.Size(72, 13);
            this.lblPassenger.TabIndex = 20;
            this.lblPassenger.Text = "Passengers";
            // 
            // txtPassenger
            // 
            this.txtPassenger.Location = new System.Drawing.Point(60, 38);
            this.txtPassenger.Name = "txtPassenger";
            this.txtPassenger.Size = new System.Drawing.Size(100, 20);
            this.txtPassenger.TabIndex = 19;
            this.txtPassenger.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassenger_Validating);
            // 
            // dgvReturnFilght
            // 
            this.dgvReturnFilght.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnFilght.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDReturn,
            this.FromReturn,
            this.ToReturn,
            this.DateReturn,
            this.TimeReturn,
            this.FlightNumberReturn,
            this.CabinTypeReturn,
            this.CabinPriceReturn,
            this.NumberOfStopReturn});
            this.dgvReturnFilght.Location = new System.Drawing.Point(37, 397);
            this.dgvReturnFilght.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvReturnFilght.MultiSelect = false;
            this.dgvReturnFilght.Name = "dgvReturnFilght";
            this.dgvReturnFilght.Size = new System.Drawing.Size(1174, 167);
            this.dgvReturnFilght.TabIndex = 20;
            this.dgvReturnFilght.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReturnFilght_CellClick);
            // 
            // IDReturn
            // 
            this.IDReturn.DataPropertyName = "ID";
            this.IDReturn.Frozen = true;
            this.IDReturn.HeaderText = "ID";
            this.IDReturn.Name = "IDReturn";
            // 
            // FromReturn
            // 
            this.FromReturn.DataPropertyName = "From";
            this.FromReturn.Frozen = true;
            this.FromReturn.HeaderText = "From";
            this.FromReturn.Name = "FromReturn";
            // 
            // ToReturn
            // 
            this.ToReturn.DataPropertyName = "To";
            this.ToReturn.Frozen = true;
            this.ToReturn.HeaderText = "To";
            this.ToReturn.Name = "ToReturn";
            // 
            // DateReturn
            // 
            this.DateReturn.DataPropertyName = "Date";
            this.DateReturn.Frozen = true;
            this.DateReturn.HeaderText = "Date";
            this.DateReturn.Name = "DateReturn";
            // 
            // TimeReturn
            // 
            this.TimeReturn.DataPropertyName = "Time";
            this.TimeReturn.Frozen = true;
            this.TimeReturn.HeaderText = "Time";
            this.TimeReturn.Name = "TimeReturn";
            // 
            // FlightNumberReturn
            // 
            this.FlightNumberReturn.DataPropertyName = "FlightNumber";
            this.FlightNumberReturn.Frozen = true;
            this.FlightNumberReturn.HeaderText = "Flight Number";
            this.FlightNumberReturn.Name = "FlightNumberReturn";
            this.FlightNumberReturn.Width = 150;
            // 
            // CabinTypeReturn
            // 
            this.CabinTypeReturn.DataPropertyName = "CabinType";
            this.CabinTypeReturn.Frozen = true;
            this.CabinTypeReturn.HeaderText = "Cabin Type";
            this.CabinTypeReturn.Name = "CabinTypeReturn";
            this.CabinTypeReturn.Width = 200;
            // 
            // CabinPriceReturn
            // 
            this.CabinPriceReturn.DataPropertyName = "CabinPrice";
            this.CabinPriceReturn.Frozen = true;
            this.CabinPriceReturn.HeaderText = "CabinPrice";
            this.CabinPriceReturn.Name = "CabinPriceReturn";
            // 
            // NumberOfStopReturn
            // 
            this.NumberOfStopReturn.DataPropertyName = "NumberOfStop";
            this.NumberOfStopReturn.Frozen = true;
            this.NumberOfStopReturn.HeaderText = "Number Of Stop";
            this.NumberOfStopReturn.Name = "NumberOfStopReturn";
            this.NumberOfStopReturn.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 685);
            this.Controls.Add(this.dgvReturnFilght);
            this.Controls.Add(this.groupBoxConfirmBooking);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.checkboxReturnThreeDay);
            this.Controls.Add(this.checkboxOutboundThreeDay);
            this.Controls.Add(this.lblReturnDetail);
            this.Controls.Add(this.lblOutboundDetail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOutboundFlight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Search for flights";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutboundFlight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxConfirmBooking.ResumeLayout(false);
            this.groupBoxConfirmBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnFilght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvOutboundFlight;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblCabinType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCabinType;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DateTimePicker dtpOutbound;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblOutbound;
        private System.Windows.Forms.RadioButton rdbOneWay;
        private System.Windows.Forms.RadioButton rdbReturn;
        private System.Windows.Forms.Label lblOutboundDetail;
        private System.Windows.Forms.Label lblReturnDetail;
        private System.Windows.Forms.CheckBox checkboxOutboundThreeDay;
        private System.Windows.Forms.CheckBox checkboxReturnThreeDay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.GroupBox groupBoxConfirmBooking;
        private System.Windows.Forms.Label lblPassenger;
        private System.Windows.Forms.TextBox txtPassenger;
        private System.Windows.Forms.DataGridView dgvReturnFilght;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNumberOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn CabinTypeOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn CabinPriceOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfStopOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNumberReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CabinTypeReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CabinPriceReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfStopReturn;
    }
}