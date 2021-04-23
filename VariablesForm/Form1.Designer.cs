
namespace VariablesForm
{
    partial class form1
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
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.buttonHockey = new System.Windows.Forms.Button();
            this.buttonBill = new System.Windows.Forms.Button();
            this.buttonCarpet = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputLabel1
            // 
            this.outputLabel1.BackColor = System.Drawing.Color.White;
            this.outputLabel1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel1.Location = new System.Drawing.Point(199, 46);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(469, 306);
            this.outputLabel1.TabIndex = 0;
            // 
            // buttonHockey
            // 
            this.buttonHockey.Location = new System.Drawing.Point(39, 46);
            this.buttonHockey.Name = "buttonHockey";
            this.buttonHockey.Size = new System.Drawing.Size(128, 39);
            this.buttonHockey.TabIndex = 1;
            this.buttonHockey.Text = "Hockey";
            this.buttonHockey.UseVisualStyleBackColor = true;
            this.buttonHockey.Click += new System.EventHandler(this.buttonHockey_Click);
            // 
            // buttonBill
            // 
            this.buttonBill.Location = new System.Drawing.Point(39, 313);
            this.buttonBill.Name = "buttonBill";
            this.buttonBill.Size = new System.Drawing.Size(128, 39);
            this.buttonBill.TabIndex = 2;
            this.buttonBill.Text = "Bill";
            this.buttonBill.UseVisualStyleBackColor = true;
            this.buttonBill.Click += new System.EventHandler(this.buttonBill_Click);
            // 
            // buttonCarpet
            // 
            this.buttonCarpet.Location = new System.Drawing.Point(39, 225);
            this.buttonCarpet.Name = "buttonCarpet";
            this.buttonCarpet.Size = new System.Drawing.Size(128, 39);
            this.buttonCarpet.TabIndex = 3;
            this.buttonCarpet.Text = "Carpet";
            this.buttonCarpet.UseVisualStyleBackColor = true;
            this.buttonCarpet.Click += new System.EventHandler(this.buttonCarpet_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(39, 133);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(128, 39);
            this.buttonArea.TabIndex = 4;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(680, 403);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonCarpet);
            this.Controls.Add(this.buttonBill);
            this.Controls.Add(this.buttonHockey);
            this.Controls.Add(this.outputLabel1);
            this.Name = "form1";
            this.Text = "Variable Cost";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Button buttonHockey;
        private System.Windows.Forms.Button buttonBill;
        private System.Windows.Forms.Button buttonCarpet;
        private System.Windows.Forms.Button buttonArea;
    }
}

