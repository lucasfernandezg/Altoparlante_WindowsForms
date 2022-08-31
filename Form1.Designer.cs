
namespace AltoparlanteGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Re = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.Le = new System.Windows.Forms.Label();
            this.Bl = new System.Windows.Forms.Label();
            this.Mm = new System.Windows.Forms.Label();
            this.Cm = new System.Windows.Forms.Label();
            this.Rm = new System.Windows.Forms.Label();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.formsPlot2 = new ScottPlot.FormsPlot();
            this.RmBox = new AltoparlanteGUI.MyTextBox();
            this.CmBox = new AltoparlanteGUI.MyTextBox();
            this.MmBox = new AltoparlanteGUI.MyTextBox();
            this.BlBox = new AltoparlanteGUI.MyTextBox();
            this.LeBox = new AltoparlanteGUI.MyTextBox();
            this.ReBox = new AltoparlanteGUI.MyTextBox();
            this.SuspendLayout();
            // 
            // Re
            // 
            this.Re.AutoSize = true;
            this.Re.Location = new System.Drawing.Point(5, 12);
            this.Re.Name = "Re";
            this.Re.Size = new System.Drawing.Size(21, 13);
            this.Re.TabIndex = 0;
            this.Re.Text = "Re";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(30, 182);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(100, 33);
            this.CalculateBtn.TabIndex = 2;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.OnClick);
            // 
            // Le
            // 
            this.Le.AutoSize = true;
            this.Le.Location = new System.Drawing.Point(5, 38);
            this.Le.Name = "Le";
            this.Le.Size = new System.Drawing.Size(19, 13);
            this.Le.TabIndex = 4;
            this.Le.Text = "Le";
            // 
            // Bl
            // 
            this.Bl.AutoSize = true;
            this.Bl.Location = new System.Drawing.Point(8, 64);
            this.Bl.Name = "Bl";
            this.Bl.Size = new System.Drawing.Size(16, 13);
            this.Bl.TabIndex = 5;
            this.Bl.Text = "Bl";
            // 
            // Mm
            // 
            this.Mm.AutoSize = true;
            this.Mm.Location = new System.Drawing.Point(8, 90);
            this.Mm.Name = "Mm";
            this.Mm.Size = new System.Drawing.Size(24, 13);
            this.Mm.TabIndex = 12;
            this.Mm.Text = "Mm";
            // 
            // Cm
            // 
            this.Cm.AutoSize = true;
            this.Cm.Location = new System.Drawing.Point(8, 116);
            this.Cm.Name = "Cm";
            this.Cm.Size = new System.Drawing.Size(22, 13);
            this.Cm.TabIndex = 13;
            this.Cm.Text = "Cm";
            // 
            // Rm
            // 
            this.Rm.AutoSize = true;
            this.Rm.Location = new System.Drawing.Point(8, 142);
            this.Rm.Name = "Rm";
            this.Rm.Size = new System.Drawing.Size(23, 13);
            this.Rm.TabIndex = 14;
            this.Rm.Text = "Rm";
            // 
            // formsPlot1
            // 
            this.formsPlot1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formsPlot1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.formsPlot1.Location = new System.Drawing.Point(136, 12);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(630, 300);
            this.formsPlot1.TabIndex = 15;
            // 
            // formsPlot2
            // 
            this.formsPlot2.Location = new System.Drawing.Point(136, 291);
            this.formsPlot2.Name = "formsPlot2";
            this.formsPlot2.Size = new System.Drawing.Size(611, 300);
            this.formsPlot2.TabIndex = 16;
            // 
            // RmBox
            // 
            this.RmBox.Location = new System.Drawing.Point(30, 139);
            this.RmBox.Name = "RmBox";
            this.RmBox.Size = new System.Drawing.Size(100, 20);
            this.RmBox.TabIndex = 11;
            this.RmBox.Text = "1,04";
            this.RmBox.validate = true;
            this.RmBox.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // CmBox
            // 
            this.CmBox.Location = new System.Drawing.Point(30, 113);
            this.CmBox.Name = "CmBox";
            this.CmBox.Size = new System.Drawing.Size(100, 20);
            this.CmBox.TabIndex = 10;
            this.CmBox.Text = "0,000140";
            this.CmBox.validate = true;
            this.CmBox.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // MmBox
            // 
            this.MmBox.Location = new System.Drawing.Point(30, 87);
            this.MmBox.Name = "MmBox";
            this.MmBox.Size = new System.Drawing.Size(100, 20);
            this.MmBox.TabIndex = 9;
            this.MmBox.Text = "0,011";
            this.MmBox.validate = true;
            this.MmBox.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // BlBox
            // 
            this.BlBox.Location = new System.Drawing.Point(30, 61);
            this.BlBox.Name = "BlBox";
            this.BlBox.Size = new System.Drawing.Size(100, 20);
            this.BlBox.TabIndex = 7;
            this.BlBox.Text = "11";
            this.BlBox.validate = true;
            this.BlBox.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // LeBox
            // 
            this.LeBox.Location = new System.Drawing.Point(30, 35);
            this.LeBox.Name = "LeBox";
            this.LeBox.Size = new System.Drawing.Size(100, 20);
            this.LeBox.TabIndex = 6;
            this.LeBox.Text = "0,00047";
            this.LeBox.validate = true;
            this.LeBox.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // ReBox
            // 
            this.ReBox.Location = new System.Drawing.Point(30, 9);
            this.ReBox.Name = "ReBox";
            this.ReBox.Size = new System.Drawing.Size(100, 20);
            this.ReBox.TabIndex = 3;
            this.ReBox.Text = "5,4";
            this.ReBox.validate = true;
            this.ReBox.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 603);
            this.Controls.Add(this.formsPlot2);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.Rm);
            this.Controls.Add(this.Cm);
            this.Controls.Add(this.Mm);
            this.Controls.Add(this.RmBox);
            this.Controls.Add(this.CmBox);
            this.Controls.Add(this.MmBox);
            this.Controls.Add(this.BlBox);
            this.Controls.Add(this.LeBox);
            this.Controls.Add(this.Bl);
            this.Controls.Add(this.Le);
            this.Controls.Add(this.ReBox);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.Re);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Re;
        private System.Windows.Forms.Button CalculateBtn;
        private MyTextBox ReBox;
        private System.Windows.Forms.Label Le;
        private System.Windows.Forms.Label Bl;
        private MyTextBox LeBox;
        private MyTextBox BlBox;
        private MyTextBox MmBox;
        private MyTextBox CmBox;
        private MyTextBox RmBox;
        private System.Windows.Forms.Label Mm;
        private System.Windows.Forms.Label Cm;
        private System.Windows.Forms.Label Rm;
        private ScottPlot.FormsPlot formsPlot1;
        private ScottPlot.FormsPlot formsPlot2;
    }
}

