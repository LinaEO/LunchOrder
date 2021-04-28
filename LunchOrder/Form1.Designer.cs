
namespace LunchOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.radPizza = new System.Windows.Forms.RadioButton();
            this.radHamburger = new System.Windows.Forms.RadioButton();
            this.gbAddOn = new System.Windows.Forms.GroupBox();
            this.chkItem3 = new System.Windows.Forms.CheckBox();
            this.chkItem2 = new System.Windows.Forms.CheckBox();
            this.chkItem1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picLunch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbAddOn.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSalad);
            this.groupBox1.Controls.Add(this.radPizza);
            this.groupBox1.Controls.Add(this.radHamburger);
            this.groupBox1.Location = new System.Drawing.Point(39, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Course";
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Location = new System.Drawing.Point(18, 100);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(121, 24);
            this.radSalad.TabIndex = 2;
            this.radSalad.TabStop = true;
            this.radSalad.Text = "Salad - $4.95";
            this.radSalad.UseVisualStyleBackColor = true;
            this.radSalad.CheckedChanged += new System.EventHandler(this.radSalad_CheckedChanged);
            // 
            // radPizza
            // 
            this.radPizza.AutoSize = true;
            this.radPizza.Location = new System.Drawing.Point(18, 70);
            this.radPizza.Name = "radPizza";
            this.radPizza.Size = new System.Drawing.Size(118, 24);
            this.radPizza.TabIndex = 1;
            this.radPizza.TabStop = true;
            this.radPizza.Text = "Pizza - $5.95";
            this.radPizza.UseVisualStyleBackColor = true;
            this.radPizza.CheckedChanged += new System.EventHandler(this.radPizza_CheckedChanged);
            // 
            // radHamburger
            // 
            this.radHamburger.AutoSize = true;
            this.radHamburger.Location = new System.Drawing.Point(18, 40);
            this.radHamburger.Name = "radHamburger";
            this.radHamburger.Size = new System.Drawing.Size(160, 24);
            this.radHamburger.TabIndex = 0;
            this.radHamburger.TabStop = true;
            this.radHamburger.Text = "Hamburger - $6.95";
            this.radHamburger.UseVisualStyleBackColor = true;
            this.radHamburger.CheckedChanged += new System.EventHandler(this.radHamburger_CheckedChanged);
            // 
            // gbAddOn
            // 
            this.gbAddOn.Controls.Add(this.chkItem3);
            this.gbAddOn.Controls.Add(this.chkItem2);
            this.gbAddOn.Controls.Add(this.chkItem1);
            this.gbAddOn.Location = new System.Drawing.Point(356, 88);
            this.gbAddOn.Name = "gbAddOn";
            this.gbAddOn.Size = new System.Drawing.Size(266, 142);
            this.gbAddOn.TabIndex = 1;
            this.gbAddOn.TabStop = false;
            this.gbAddOn.Text = "Add-on items";
            // 
            // chkItem3
            // 
            this.chkItem3.AutoSize = true;
            this.chkItem3.Location = new System.Drawing.Point(19, 100);
            this.chkItem3.Name = "chkItem3";
            this.chkItem3.Size = new System.Drawing.Size(88, 24);
            this.chkItem3.TabIndex = 2;
            this.chkItem3.Text = "Option 3";
            this.chkItem3.UseVisualStyleBackColor = true;
            // 
            // chkItem2
            // 
            this.chkItem2.AutoSize = true;
            this.chkItem2.Location = new System.Drawing.Point(19, 71);
            this.chkItem2.Name = "chkItem2";
            this.chkItem2.Size = new System.Drawing.Size(88, 24);
            this.chkItem2.TabIndex = 1;
            this.chkItem2.Text = "Option 2";
            this.chkItem2.UseVisualStyleBackColor = true;
            // 
            // chkItem1
            // 
            this.chkItem1.AutoSize = true;
            this.chkItem1.Location = new System.Drawing.Point(19, 40);
            this.chkItem1.Name = "chkItem1";
            this.chkItem1.Size = new System.Drawing.Size(88, 24);
            this.chkItem1.TabIndex = 0;
            this.chkItem1.Text = "Option 1";
            this.chkItem1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblTax);
            this.groupBox3.Controls.Add(this.lblSubtotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(39, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 163);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(148, 113);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 29);
            this.lblTotal.TabIndex = 5;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Location = new System.Drawing.Point(148, 74);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(110, 29);
            this.lblTax.TabIndex = 4;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(148, 33);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(110, 29);
            this.lblSubtotal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax (5%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(39, 434);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(125, 29);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "&Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(266, 434);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 29);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(497, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picLunch
            // 
            this.picLunch.Location = new System.Drawing.Point(356, 253);
            this.picLunch.Name = "picLunch";
            this.picLunch.Size = new System.Drawing.Size(266, 163);
            this.picLunch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLunch.TabIndex = 5;
            this.picLunch.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 78);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(676, 498);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picLunch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbAddOn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAddOn.ResumeLayout(false);
            this.gbAddOn.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSalad;
        private System.Windows.Forms.RadioButton radPizza;
        private System.Windows.Forms.RadioButton radHamburger;
        private System.Windows.Forms.GroupBox gbAddOn;
        private System.Windows.Forms.CheckBox chkItem3;
        private System.Windows.Forms.CheckBox chkItem2;
        private System.Windows.Forms.CheckBox chkItem1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLunch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

