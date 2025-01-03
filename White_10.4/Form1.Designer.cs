namespace White_10._4
{
    partial class EmployeeDataCollection
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
            this.components = new System.ComponentModel.Container();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IDBOX = new System.Windows.Forms.TextBox();
            this.PosBox = new System.Windows.Forms.TextBox();
            this.DepartBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UserList = new System.Windows.Forms.ListBox();
            this.RunBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(365, 349);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(208, 26);
            this.NameBox.TabIndex = 0;
            this.NameBox.Text = "Enter Name";
            // 
            // IDBOX
            // 
            this.IDBOX.Location = new System.Drawing.Point(615, 349);
            this.IDBOX.Name = "IDBOX";
            this.IDBOX.Size = new System.Drawing.Size(208, 26);
            this.IDBOX.TabIndex = 1;
            this.IDBOX.Text = "Enter ID #";
            // 
            // PosBox
            // 
            this.PosBox.Location = new System.Drawing.Point(365, 436);
            this.PosBox.Name = "PosBox";
            this.PosBox.Size = new System.Drawing.Size(208, 26);
            this.PosBox.TabIndex = 2;
            this.PosBox.Text = "Enter Position Hired";
            // 
            // DepartBox
            // 
            this.DepartBox.Location = new System.Drawing.Point(615, 436);
            this.DepartBox.Name = "DepartBox";
            this.DepartBox.Size = new System.Drawing.Size(208, 26);
            this.DepartBox.TabIndex = 3;
            this.DepartBox.Text = "Enter Department Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.ItemHeight = 20;
            this.UserList.Location = new System.Drawing.Point(887, 215);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(388, 504);
            this.UserList.TabIndex = 5;
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(405, 631);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(99, 47);
            this.RunBtn.TabIndex = 6;
            this.RunBtn.Text = "Add User";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee Data Collection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Employee ID Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Employee Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Employee Department";
            // 
            // EmployeeDataCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 775);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.DepartBox);
            this.Controls.Add(this.PosBox);
            this.Controls.Add(this.IDBOX);
            this.Controls.Add(this.NameBox);
            this.Name = "EmployeeDataCollection";
            this.Text = "Employee Data Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IDBOX;
        private System.Windows.Forms.TextBox PosBox;
        private System.Windows.Forms.TextBox DepartBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

