namespace HRApplication
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
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNewSalaried = new System.Windows.Forms.Button();
            this.buttonNewHourly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 25;
            this.listBoxEmployees.Location = new System.Drawing.Point(28, 15);
            this.listBoxEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(309, 254);
            this.listBoxEmployees.TabIndex = 0;
            this.listBoxEmployees.DoubleClick += new System.EventHandler(this.listBoxEmployees_DoubleClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(411, 27);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(279, 42);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit Employee Details";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNewSalaried
            // 
            this.buttonNewSalaried.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewSalaried.Location = new System.Drawing.Point(411, 110);
            this.buttonNewSalaried.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewSalaried.Name = "buttonNewSalaried";
            this.buttonNewSalaried.Size = new System.Drawing.Size(279, 42);
            this.buttonNewSalaried.TabIndex = 2;
            this.buttonNewSalaried.Text = "New Salaried Employee";
            this.buttonNewSalaried.UseVisualStyleBackColor = true;
            this.buttonNewSalaried.Click += new System.EventHandler(this.buttonNewSalaried_Click);
            // 
            // buttonNewHourly
            // 
            this.buttonNewHourly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewHourly.Location = new System.Drawing.Point(411, 191);
            this.buttonNewHourly.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewHourly.Name = "buttonNewHourly";
            this.buttonNewHourly.Size = new System.Drawing.Size(279, 42);
            this.buttonNewHourly.TabIndex = 3;
            this.buttonNewHourly.Text = "New Hourly Employee";
            this.buttonNewHourly.UseVisualStyleBackColor = true;
            this.buttonNewHourly.Click += new System.EventHandler(this.buttonNewHourly_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 315);
            this.Controls.Add(this.buttonNewHourly);
            this.Controls.Add(this.buttonNewSalaried);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listBoxEmployees);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNewSalaried;
        private System.Windows.Forms.Button buttonNewHourly;
    }
}

