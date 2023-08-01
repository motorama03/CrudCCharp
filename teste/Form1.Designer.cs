namespace teste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSerch = new Button();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            allTable = new Button();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(160, 61);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(260, 61);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(360, 61);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSerch
            // 
            btnSerch.Location = new Point(460, 61);
            btnSerch.Name = "btnSerch";
            btnSerch.Size = new Size(94, 29);
            btnSerch.TabIndex = 3;
            btnSerch.Text = "Serch";
            btnSerch.UseVisualStyleBackColor = true;
            btnSerch.Click += btnSerch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 147);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 204);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "NAME:";
            // 
            // txtId
            // 
            txtId.Location = new Point(129, 144);
            txtId.Name = "txtId";
            txtId.Size = new Size(425, 27);
            txtId.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 204);
            txtName.Name = "txtName";
            txtName.Size = new Size(425, 27);
            txtName.TabIndex = 7;
            // 
            // allTable
            // 
            allTable.Location = new Point(60, 61);
            allTable.Name = "allTable";
            allTable.Size = new Size(94, 29);
            allTable.TabIndex = 8;
            allTable.Text = "AllTable";
            allTable.UseVisualStyleBackColor = true;
            allTable.Click += allTable_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 303);
            Controls.Add(allTable);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSerch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSerch;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtName;
        private Button allTable;
    }
}