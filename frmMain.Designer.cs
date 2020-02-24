namespace matrixOps
{
    partial class frmMain
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
            this.txtMatrixA = new System.Windows.Forms.TextBox();
            this.lblMatrixA = new System.Windows.Forms.Label();
            this.lblMatrixB = new System.Windows.Forms.Label();
            this.txtMatrixB = new System.Windows.Forms.TextBox();
            this.lblMatrixC = new System.Windows.Forms.Label();
            this.txtMatrixC = new System.Windows.Forms.TextBox();
            this.btnMakeA = new System.Windows.Forms.Button();
            this.btnMakeB = new System.Windows.Forms.Button();
            this.txtRowsA = new System.Windows.Forms.TextBox();
            this.txtColsB = new System.Windows.Forms.TextBox();
            this.txtColsA = new System.Windows.Forms.TextBox();
            this.txtRowsB = new System.Windows.Forms.TextBox();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblCols = new System.Windows.Forms.Label();
            this.btnMakeBIdentity = new System.Windows.Forms.Button();
            this.grpOp = new System.Windows.Forms.GroupBox();
            this.rbtnSubtract = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnMultiply = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatrixA
            // 
            this.txtMatrixA.Location = new System.Drawing.Point(54, 59);
            this.txtMatrixA.Multiline = true;
            this.txtMatrixA.Name = "txtMatrixA";
            this.txtMatrixA.ReadOnly = true;
            this.txtMatrixA.Size = new System.Drawing.Size(150, 150);
            this.txtMatrixA.TabIndex = 11;
            // 
            // lblMatrixA
            // 
            this.lblMatrixA.AutoSize = true;
            this.lblMatrixA.Location = new System.Drawing.Point(101, 43);
            this.lblMatrixA.Name = "lblMatrixA";
            this.lblMatrixA.Size = new System.Drawing.Size(45, 13);
            this.lblMatrixA.TabIndex = 1;
            this.lblMatrixA.Text = "Matrix A";
            // 
            // lblMatrixB
            // 
            this.lblMatrixB.AutoSize = true;
            this.lblMatrixB.Location = new System.Drawing.Point(270, 43);
            this.lblMatrixB.Name = "lblMatrixB";
            this.lblMatrixB.Size = new System.Drawing.Size(45, 13);
            this.lblMatrixB.TabIndex = 3;
            this.lblMatrixB.Text = "Matrix B";
            // 
            // txtMatrixB
            // 
            this.txtMatrixB.Location = new System.Drawing.Point(223, 59);
            this.txtMatrixB.Multiline = true;
            this.txtMatrixB.Name = "txtMatrixB";
            this.txtMatrixB.ReadOnly = true;
            this.txtMatrixB.Size = new System.Drawing.Size(150, 150);
            this.txtMatrixB.TabIndex = 12;
            // 
            // lblMatrixC
            // 
            this.lblMatrixC.AutoSize = true;
            this.lblMatrixC.Location = new System.Drawing.Point(436, 43);
            this.lblMatrixC.Name = "lblMatrixC";
            this.lblMatrixC.Size = new System.Drawing.Size(45, 13);
            this.lblMatrixC.TabIndex = 5;
            this.lblMatrixC.Text = "Matrix C";
            // 
            // txtMatrixC
            // 
            this.txtMatrixC.Location = new System.Drawing.Point(389, 59);
            this.txtMatrixC.Multiline = true;
            this.txtMatrixC.Name = "txtMatrixC";
            this.txtMatrixC.ReadOnly = true;
            this.txtMatrixC.Size = new System.Drawing.Size(150, 150);
            this.txtMatrixC.TabIndex = 13;
            // 
            // btnMakeA
            // 
            this.btnMakeA.Location = new System.Drawing.Point(54, 239);
            this.btnMakeA.Name = "btnMakeA";
            this.btnMakeA.Size = new System.Drawing.Size(92, 24);
            this.btnMakeA.TabIndex = 6;
            this.btnMakeA.Text = "Make Matrix A";
            this.btnMakeA.UseVisualStyleBackColor = true;
            this.btnMakeA.Click += new System.EventHandler(this.btnMakeA_Click);
            // 
            // btnMakeB
            // 
            this.btnMakeB.Location = new System.Drawing.Point(54, 269);
            this.btnMakeB.Name = "btnMakeB";
            this.btnMakeB.Size = new System.Drawing.Size(92, 23);
            this.btnMakeB.TabIndex = 7;
            this.btnMakeB.Text = "Make Matrix B";
            this.btnMakeB.UseVisualStyleBackColor = true;
            this.btnMakeB.Click += new System.EventHandler(this.btnMakeB_Click);
            // 
            // txtRowsA
            // 
            this.txtRowsA.Location = new System.Drawing.Point(179, 242);
            this.txtRowsA.Name = "txtRowsA";
            this.txtRowsA.Size = new System.Drawing.Size(100, 20);
            this.txtRowsA.TabIndex = 0;
            this.txtRowsA.TextChanged += new System.EventHandler(this.txtRowsA_TextChanged);
            this.txtRowsA.Leave += new System.EventHandler(this.txtRowsA_Leave);
            // 
            // txtColsB
            // 
            this.txtColsB.Location = new System.Drawing.Point(298, 272);
            this.txtColsB.Name = "txtColsB";
            this.txtColsB.Size = new System.Drawing.Size(100, 20);
            this.txtColsB.TabIndex = 3;
            // 
            // txtColsA
            // 
            this.txtColsA.Location = new System.Drawing.Point(298, 242);
            this.txtColsA.Name = "txtColsA";
            this.txtColsA.Size = new System.Drawing.Size(100, 20);
            this.txtColsA.TabIndex = 1;
            // 
            // txtRowsB
            // 
            this.txtRowsB.Location = new System.Drawing.Point(179, 272);
            this.txtRowsB.Name = "txtRowsB";
            this.txtRowsB.Size = new System.Drawing.Size(100, 20);
            this.txtRowsB.TabIndex = 2;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(207, 219);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(34, 13);
            this.lblRow.TabIndex = 12;
            this.lblRow.Text = "Rows";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(325, 219);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(47, 13);
            this.lblCols.TabIndex = 13;
            this.lblCols.Text = "Columns";
            // 
            // btnMakeBIdentity
            // 
            this.btnMakeBIdentity.Location = new System.Drawing.Point(419, 269);
            this.btnMakeBIdentity.Name = "btnMakeBIdentity";
            this.btnMakeBIdentity.Size = new System.Drawing.Size(98, 23);
            this.btnMakeBIdentity.TabIndex = 14;
            this.btnMakeBIdentity.Text = "Make B Identity";
            this.btnMakeBIdentity.UseVisualStyleBackColor = true;
            this.btnMakeBIdentity.Click += new System.EventHandler(this.btnMakeBIdentity_Click);
            // 
            // grpOp
            // 
            this.grpOp.Controls.Add(this.rbtnSubtract);
            this.grpOp.Controls.Add(this.rbtnAdd);
            this.grpOp.Controls.Add(this.rbtnMultiply);
            this.grpOp.Location = new System.Drawing.Point(72, 313);
            this.grpOp.Name = "grpOp";
            this.grpOp.Size = new System.Drawing.Size(219, 64);
            this.grpOp.TabIndex = 15;
            this.grpOp.TabStop = false;
            this.grpOp.Text = "Select Operation";
            // 
            // rbtnSubtract
            // 
            this.rbtnSubtract.AutoSize = true;
            this.rbtnSubtract.Location = new System.Drawing.Point(138, 32);
            this.rbtnSubtract.Name = "rbtnSubtract";
            this.rbtnSubtract.Size = new System.Drawing.Size(65, 17);
            this.rbtnSubtract.TabIndex = 10;
            this.rbtnSubtract.TabStop = true;
            this.rbtnSubtract.Text = "Subtract";
            this.rbtnSubtract.UseVisualStyleBackColor = true;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(88, 32);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(44, 17);
            this.rbtnAdd.TabIndex = 9;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Add";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiply
            // 
            this.rbtnMultiply.AutoSize = true;
            this.rbtnMultiply.Location = new System.Drawing.Point(21, 32);
            this.rbtnMultiply.Name = "rbtnMultiply";
            this.rbtnMultiply.Size = new System.Drawing.Size(60, 17);
            this.rbtnMultiply.TabIndex = 8;
            this.rbtnMultiply.TabStop = true;
            this.rbtnMultiply.Text = "Multiply";
            this.rbtnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(54, 395);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(389, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear Matrices";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(485, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(598, 435);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpOp);
            this.Controls.Add(this.btnMakeBIdentity);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.txtRowsB);
            this.Controls.Add(this.txtColsA);
            this.Controls.Add(this.txtColsB);
            this.Controls.Add(this.txtRowsA);
            this.Controls.Add(this.btnMakeB);
            this.Controls.Add(this.btnMakeA);
            this.Controls.Add(this.lblMatrixC);
            this.Controls.Add(this.txtMatrixC);
            this.Controls.Add(this.lblMatrixB);
            this.Controls.Add(this.txtMatrixB);
            this.Controls.Add(this.lblMatrixA);
            this.Controls.Add(this.txtMatrixA);
            this.Name = "frmMain";
            this.Text = "Matrix Ops";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpOp.ResumeLayout(false);
            this.grpOp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatrixA;
        private System.Windows.Forms.Label lblMatrixA;
        private System.Windows.Forms.Label lblMatrixB;
        private System.Windows.Forms.TextBox txtMatrixB;
        private System.Windows.Forms.Label lblMatrixC;
        private System.Windows.Forms.TextBox txtMatrixC;
        private System.Windows.Forms.Button btnMakeA;
        private System.Windows.Forms.Button btnMakeB;
        private System.Windows.Forms.TextBox txtRowsA;
        private System.Windows.Forms.TextBox txtColsB;
        private System.Windows.Forms.TextBox txtColsA;
        private System.Windows.Forms.TextBox txtRowsB;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.Button btnMakeBIdentity;
        private System.Windows.Forms.GroupBox grpOp;
        private System.Windows.Forms.RadioButton rbtnSubtract;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnMultiply;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

