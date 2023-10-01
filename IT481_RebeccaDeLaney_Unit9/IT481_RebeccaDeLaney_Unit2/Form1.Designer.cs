namespace IT481_RebeccaDeLaney_Unit2
{
    partial class Form1
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
            this.connectButton = new System.Windows.Forms.Button();
            this.companyCountButton = new System.Windows.Forms.Button();
            this.companyNamesButton = new System.Windows.Forms.Button();
            this.OrderCountButton = new System.Windows.Forms.Button();
            this.orderIDsButton = new System.Windows.Forms.Button();
            this.employeeCountButton = new System.Windows.Forms.Button();
            this.employeeNamesButton = new System.Windows.Forms.Button();
            this.directionsLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.databaseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(450, 210);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(300, 32);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connnect to Database";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // companyCountButton
            // 
            this.companyCountButton.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyCountButton.Location = new System.Drawing.Point(50, 300);
            this.companyCountButton.Name = "companyCountButton";
            this.companyCountButton.Size = new System.Drawing.Size(300, 32);
            this.companyCountButton.TabIndex = 6;
            this.companyCountButton.Text = "Customer Count";
            this.companyCountButton.UseVisualStyleBackColor = true;
            this.companyCountButton.Click += new System.EventHandler(this.CompanyCountButton_Click);
            // 
            // companyNamesButton
            // 
            this.companyNamesButton.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNamesButton.Location = new System.Drawing.Point(50, 350);
            this.companyNamesButton.Name = "companyNamesButton";
            this.companyNamesButton.Size = new System.Drawing.Size(300, 32);
            this.companyNamesButton.TabIndex = 7;
            this.companyNamesButton.Text = "Company Names";
            this.companyNamesButton.UseVisualStyleBackColor = true;
            this.companyNamesButton.Click += new System.EventHandler(this.CompanyNamesButton_Click);
            // 
            // OrderCountButton
            // 
            this.OrderCountButton.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCountButton.Location = new System.Drawing.Point(450, 300);
            this.OrderCountButton.Name = "OrderCountButton";
            this.OrderCountButton.Size = new System.Drawing.Size(300, 32);
            this.OrderCountButton.TabIndex = 8;
            this.OrderCountButton.Text = "Order Count";
            this.OrderCountButton.UseVisualStyleBackColor = true;
            this.OrderCountButton.Click += new System.EventHandler(this.OrderCountButton_Click);
            // 
            // orderIDsButton
            // 
            this.orderIDsButton.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDsButton.Location = new System.Drawing.Point(450, 350);
            this.orderIDsButton.Name = "orderIDsButton";
            this.orderIDsButton.Size = new System.Drawing.Size(300, 32);
            this.orderIDsButton.TabIndex = 9;
            this.orderIDsButton.Text = "Order IDs";
            this.orderIDsButton.UseVisualStyleBackColor = true;
            this.orderIDsButton.Click += new System.EventHandler(this.OrderIDsButton_Click);
            // 
            // employeeCountButton
            // 
            this.employeeCountButton.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCountButton.Location = new System.Drawing.Point(850, 300);
            this.employeeCountButton.Name = "employeeCountButton";
            this.employeeCountButton.Size = new System.Drawing.Size(300, 32);
            this.employeeCountButton.TabIndex = 10;
            this.employeeCountButton.Text = "Employee Count";
            this.employeeCountButton.UseVisualStyleBackColor = true;
            this.employeeCountButton.Click += new System.EventHandler(this.EmployeeCountButton_Click);
            // 
            // employeeNamesButton
            // 
            this.employeeNamesButton.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNamesButton.Location = new System.Drawing.Point(850, 350);
            this.employeeNamesButton.Name = "employeeNamesButton";
            this.employeeNamesButton.Size = new System.Drawing.Size(300, 32);
            this.employeeNamesButton.TabIndex = 11;
            this.employeeNamesButton.Text = "Employee Names";
            this.employeeNamesButton.UseVisualStyleBackColor = true;
            this.employeeNamesButton.Click += new System.EventHandler(this.EmployeeNamesButton_Click);
            // 
            // directionsLabel
            // 
            this.directionsLabel.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionsLabel.Location = new System.Drawing.Point(100, 25);
            this.directionsLabel.Name = "directionsLabel";
            this.directionsLabel.Size = new System.Drawing.Size(1000, 50);
            this.directionsLabel.TabIndex = 14;
            this.directionsLabel.Text = "Please fill out the form completely before hitting \"Connect\".";
            this.directionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(100, 100);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(120, 32);
            this.userLabel.TabIndex = 15;
            this.userLabel.Text = "User";
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(250, 100);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(250, 32);
            this.userTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(250, 150);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(250, 32);
            this.passwordTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(100, 150);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(120, 32);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Password";
            // 
            // serverLabel
            // 
            this.serverLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLabel.Location = new System.Drawing.Point(600, 100);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(120, 32);
            this.serverLabel.TabIndex = 19;
            this.serverLabel.Text = "Server";
            // 
            // databaseLabel
            // 
            this.databaseLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseLabel.Location = new System.Drawing.Point(600, 150);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(120, 32);
            this.databaseLabel.TabIndex = 20;
            this.databaseLabel.Text = "Database";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTextBox.Location = new System.Drawing.Point(800, 100);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(250, 32);
            this.serverTextBox.TabIndex = 3;
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseTextBox.Location = new System.Drawing.Point(800, 150);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.Size = new System.Drawing.Size(250, 32);
            this.databaseTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 456);
            this.Controls.Add(this.databaseTextBox);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.directionsLabel);
            this.Controls.Add(this.employeeNamesButton);
            this.Controls.Add(this.employeeCountButton);
            this.Controls.Add(this.orderIDsButton);
            this.Controls.Add(this.OrderCountButton);
            this.Controls.Add(this.companyNamesButton);
            this.Controls.Add(this.companyCountButton);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Northwinds DB Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button companyCountButton;
        private System.Windows.Forms.Button companyNamesButton;
        private System.Windows.Forms.Button OrderCountButton;
        private System.Windows.Forms.Button orderIDsButton;
        private System.Windows.Forms.Button employeeCountButton;
        private System.Windows.Forms.Button employeeNamesButton;
        private System.Windows.Forms.Label directionsLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.TextBox databaseTextBox;
    }
}

