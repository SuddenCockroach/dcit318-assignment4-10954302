namespace Address_Book
{
    partial class AddressBook
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
            pictureBox1 = new PictureBox();
            IblContactID = new Label();
            txtBoxContactID = new TextBox();
            txtBoxName = new TextBox();
            IblName = new Label();
            txtBoxEMAIL = new TextBox();
            IblEMAIL = new Label();
            txtBoxPhoneNumber = new TextBox();
            IblPhoneNumber = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.istockphoto_1352955578_1024x1024;
            pictureBox1.Location = new Point(373, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // IblContactID
            // 
            IblContactID.AutoSize = true;
            IblContactID.BackColor = Color.Transparent;
            IblContactID.Location = new Point(40, 166);
            IblContactID.Name = "IblContactID";
            IblContactID.Size = new Size(86, 17);
            IblContactID.TabIndex = 1;
            IblContactID.Text = "CONTACT ID";
            // 
            // txtBoxContactID
            // 
            txtBoxContactID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxContactID.Location = new Point(155, 161);
            txtBoxContactID.Name = "txtBoxContactID";
            txtBoxContactID.Size = new Size(173, 27);
            txtBoxContactID.TabIndex = 2;
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxName.Location = new Point(155, 216);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(173, 27);
            txtBoxName.TabIndex = 4;
            // 
            // IblName
            // 
            IblName.AutoSize = true;
            IblName.BackColor = Color.Transparent;
            IblName.Location = new Point(40, 221);
            IblName.Name = "IblName";
            IblName.Size = new Size(46, 17);
            IblName.TabIndex = 3;
            IblName.Text = "NAME";
            // 
            // txtBoxEMAIL
            // 
            txtBoxEMAIL.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxEMAIL.Location = new Point(155, 274);
            txtBoxEMAIL.Name = "txtBoxEMAIL";
            txtBoxEMAIL.Size = new Size(173, 27);
            txtBoxEMAIL.TabIndex = 6;
            // 
            // IblEMAIL
            // 
            IblEMAIL.AutoSize = true;
            IblEMAIL.BackColor = Color.Transparent;
            IblEMAIL.Location = new Point(40, 279);
            IblEMAIL.Name = "IblEMAIL";
            IblEMAIL.Size = new Size(47, 17);
            IblEMAIL.TabIndex = 5;
            IblEMAIL.Text = "EMAIL";
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxPhoneNumber.Location = new Point(155, 333);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(173, 27);
            txtBoxPhoneNumber.TabIndex = 8;
            // 
            // IblPhoneNumber
            // 
            IblPhoneNumber.AutoSize = true;
            IblPhoneNumber.BackColor = Color.Transparent;
            IblPhoneNumber.Location = new Point(40, 338);
            IblPhoneNumber.Name = "IblPhoneNumber";
            IblPhoneNumber.Size = new Size(97, 17);
            IblPhoneNumber.TabIndex = 7;
            IblPhoneNumber.Text = "PhoneNumber";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Location = new Point(172, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DeepSkyBlue;
            btnUpdate.Location = new Point(328, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(496, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.Location = new Point(634, 409);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // AddressBook
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtBoxPhoneNumber);
            Controls.Add(IblPhoneNumber);
            Controls.Add(txtBoxEMAIL);
            Controls.Add(IblEMAIL);
            Controls.Add(txtBoxName);
            Controls.Add(IblName);
            Controls.Add(txtBoxContactID);
            Controls.Add(IblContactID);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "AddressBook";
            Text = "AddressBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label IblContactID;
        private TextBox txtBoxContactID;
        private TextBox txtBoxName;
        private Label IblName;
        private TextBox txtBoxEMAIL;
        private Label IblEMAIL;
        private TextBox txtBoxPhoneNumber;
        private Label IblPhoneNumber;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}
