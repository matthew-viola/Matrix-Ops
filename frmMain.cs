using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixOps
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtColsA.Text = "3";
            txtRowsA.Text = "3";
            txtColsB.Text = "3";
            txtRowsB.Text = "3";
            txtRowsA.Focus();
            rbtnMultiply.Checked = true;
        }

        private void txtRowsA_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void txtRowsA_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtRowsA.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number");
                txtRowsA.Focus();
            }
        }
        public double[,] createMatrix(int r, int c)
        {
            double[,] matrix = new double[r, c];
            Random autorand = new Random();
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    matrix[i, j] = Math.Round(autorand.NextDouble() * 10, 1);
                }
            }
            return matrix;
        }
        public string matrixDisplay(double[,] matrix)
        {
            StringBuilder display = new StringBuilder();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                display.AppendLine();
                for (int j = 0; j < cols; j++)
                {
                    display.Append(Convert.ToString(matrix[i, j]));
                    display.Append("       ");
                }
            }
            return display.ToString();

        }
        double[,] MatrixA;
        double[,] MatrixB;
        public void btnMakeA_Click(object sender, EventArgs e)
        {
            MatrixA = createMatrix(Convert.ToInt32(txtRowsA.Text), Convert.ToInt32(txtColsA.Text));
            txtMatrixA.Text = matrixDisplay(MatrixA);
        }

        public void btnMakeB_Click(object sender, EventArgs e)
        {
            MatrixB = createMatrix(Convert.ToInt32(txtRowsB.Text), Convert.ToInt32(txtColsB.Text));
            txtMatrixB.Text = matrixDisplay(MatrixB);
        }

        public void btnMakeBIdentity_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(txtRowsB.Text);
            int cols = Convert.ToInt32(txtColsB.Text);
            double[,] imatrix = new double[rows, cols];
            int count = 0;
            if (rows == cols)
            {
                for(int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < cols; j++)
                    {
                        imatrix[i, j] = 0;
                    }
                    imatrix[i, count] = 1.0;
                    count++;
                }
                txtMatrixB.Text = (matrixDisplay(imatrix));
                MatrixB = imatrix;
            }
            else
            {
                MessageBox.Show("Rows and Columns must be equal");
            }
        }
      
        public void btnCalculate_Click(object sender, EventArgs e)
        {
            
            int rowsA = Convert.ToInt32(txtRowsA.Text);
            int colsA = Convert.ToInt32(txtColsA.Text);
            int rowsB = Convert.ToInt32(txtRowsB.Text);
            int colsB = Convert.ToInt32(txtColsB.Text);
            double[,] matrixC = new double[rowsA, colsB];
                if (txtColsA.Text == "0" || txtColsB.Text == "0" || txtRowsA.Text == "0" || txtRowsB.Text == "0")
            {
                MessageBox.Show("Rows or Columns can not be 0");
            }
            else
            {

                if (rbtnMultiply.Checked == true)
                {
                    if(rowsA == colsB && rowsB == colsA)
                    {
                        for(int i = 0; i < rowsA; i++)
                        {
                            for(int j = 0; j < colsB; j++)
                            {
                                for(int q = 0; q < colsA; q++)
                                {
                                    matrixC[i, j] += Math.Round(MatrixA[i, q] * MatrixB[q, j], 1);
                                }
                            }
                        }
                        txtMatrixC.Text = matrixDisplay(matrixC);
                    }
                    else
                    {
                        MessageBox.Show("Rows of A and Columns of B must be equal for multiplication and vice versa");
                    }
                }
                else if(rbtnAdd.Checked == true)
                {
                    if(rowsA == rowsB && colsA == colsB)
                    {
                        for(int i = 0; i < rowsA; i++)
                        {
                            for(int j = 0; j < colsA; j++)
                            {
                                matrixC[i,j] = MatrixA[i,j] + MatrixB[i,j];
                            }
                        }
                        txtMatrixC.Text = matrixDisplay(matrixC);
                    }
                    else
                    {
                        MessageBox.Show("Dimensions of the matracies must be equal for addition");
                    }
                }
                else
                {
                    if (rowsA == rowsB && colsA == colsB)
                    {
                        for (int i = 0; i < rowsA; i++)
                        {
                            for (int j = 0; j < colsA; j++)
                            {
                                matrixC[i, j] = MatrixA[i, j] - MatrixB[i, j];
                            }
                        }
                        txtMatrixC.Text = matrixDisplay(matrixC);
                    }
                    else
                    {
                        MessageBox.Show("Dimensions of the matracies must be equal for subtraction");
                    }
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(txtRowsA.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt32(txtColsA.Text); j++)
                {
                    MatrixA[i, j] = 0;
                }
            }
            for (int i = 0; i < Convert.ToInt32(txtRowsB.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt32(txtColsB.Text); j++)
                {
                    MatrixB[i, j] = 0;
                }
            }
            txtMatrixA.Text = "";
            txtMatrixB.Text = "";
            txtMatrixC.Text = "";
            txtColsA.Text = "3";
            txtColsB.Text = "3";
            txtRowsA.Text = "3";
            txtRowsB.Text = "3";
            rbtnMultiply.Checked = true;
            txtRowsA.Focus();
            
        }
    }
}
