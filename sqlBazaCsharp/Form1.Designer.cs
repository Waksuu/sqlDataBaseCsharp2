namespace sqlBazaCsharp
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
            this.connectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.database = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.queryText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.queryBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tableName = new System.Windows.Forms.TextBox();
            this.insertSubmit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(951, 33);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(637, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(700, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(795, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(858, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // server
            // 
            this.server.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.server.Location = new System.Drawing.Point(629, 33);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(69, 22);
            this.server.TabIndex = 5;
            this.server.Text = "localhost";
            this.server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // database
            // 
            this.database.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.database.Location = new System.Drawing.Point(704, 33);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(69, 22);
            this.database.TabIndex = 6;
            this.database.Text = "test";
            this.database.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user.Location = new System.Drawing.Point(781, 33);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(69, 22);
            this.user.TabIndex = 7;
            this.user.Text = "root";
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password.Location = new System.Drawing.Point(861, 33);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(69, 22);
            this.password.TabIndex = 8;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 553);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // queryText
            // 
            this.queryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryText.Location = new System.Drawing.Point(629, 98);
            this.queryText.Name = "queryText";
            this.queryText.Size = new System.Drawing.Size(307, 22);
            this.queryText.TabIndex = 10;
            this.queryText.Text = "select * from miejsca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(624, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Query:";
            // 
            // queryBtn
            // 
            this.queryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryBtn.Location = new System.Drawing.Point(951, 98);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(75, 23);
            this.queryBtn.TabIndex = 12;
            this.queryBtn.Text = "Click me!";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Enabled = false;
            this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.insertBtn.Location = new System.Drawing.Point(654, 354);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 52);
            this.insertBtn.TabIndex = 13;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(650, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Table Name";
            // 
            // tableName
            // 
            this.tableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableName.Location = new System.Drawing.Point(654, 432);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(100, 22);
            this.tableName.TabIndex = 15;
            this.tableName.Text = "miejsca";
            // 
            // insertSubmit
            // 
            this.insertSubmit.Enabled = false;
            this.insertSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.insertSubmit.Location = new System.Drawing.Point(654, 460);
            this.insertSubmit.Name = "insertSubmit";
            this.insertSubmit.Size = new System.Drawing.Size(75, 23);
            this.insertSubmit.TabIndex = 16;
            this.insertSubmit.Text = "Submit";
            this.insertSubmit.UseVisualStyleBackColor = true;
            this.insertSubmit.Click += new System.EventHandler(this.insertSubmit_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(842, 193);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(181, 276);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Databases";
            this.columnHeader1.Width = 176;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteBtn.Location = new System.Drawing.Point(652, 193);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 52);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(624, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(380, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Delete only by pimary key and update cell one by one";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateBtn.Location = new System.Drawing.Point(733, 193);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(76, 52);
            this.updateBtn.TabIndex = 20;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(946, 195);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 21;
            this.backBtn.Text = "<- Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 574);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.insertSubmit);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.queryText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.database);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Inser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox queryText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tableName;
        private System.Windows.Forms.Button insertSubmit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button backBtn;
    }
}

