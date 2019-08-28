namespace CalculadoraCSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Cero = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Porce = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.Divi = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Font = new System.Drawing.Font("Consolas", 20F);
            this.Pantalla.Location = new System.Drawing.Point(12, 39);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(383, 39);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TextChanged += new System.EventHandler(this.Pantalla_TextChanged);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Consolas", 10F);
            this.One.Location = new System.Drawing.Point(12, 257);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(69, 52);
            this.One.TabIndex = 1;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Consolas", 10F);
            this.Two.Location = new System.Drawing.Point(87, 257);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(69, 52);
            this.Two.TabIndex = 2;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Consolas", 10F);
            this.Three.Location = new System.Drawing.Point(162, 257);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(69, 52);
            this.Three.TabIndex = 3;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Cero
            // 
            this.Cero.Font = new System.Drawing.Font("Consolas", 10F);
            this.Cero.Location = new System.Drawing.Point(12, 329);
            this.Cero.Name = "Cero";
            this.Cero.Size = new System.Drawing.Size(69, 52);
            this.Cero.TabIndex = 4;
            this.Cero.Text = "0";
            this.Cero.UseVisualStyleBackColor = true;
            this.Cero.Click += new System.EventHandler(this.Cero_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Consolas", 10F);
            this.Four.Location = new System.Drawing.Point(12, 185);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(69, 52);
            this.Four.TabIndex = 5;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Consolas", 10F);
            this.Five.Location = new System.Drawing.Point(87, 185);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(69, 52);
            this.Five.TabIndex = 6;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Consolas", 10F);
            this.Six.Location = new System.Drawing.Point(162, 185);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(69, 52);
            this.Six.TabIndex = 7;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Consolas", 10F);
            this.Seven.Location = new System.Drawing.Point(12, 110);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(69, 52);
            this.Seven.TabIndex = 8;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Consolas", 10F);
            this.Eight.Location = new System.Drawing.Point(87, 110);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(69, 52);
            this.Eight.TabIndex = 9;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Consolas", 10F);
            this.Nine.Location = new System.Drawing.Point(162, 110);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(69, 52);
            this.Nine.TabIndex = 10;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Point
            // 
            this.Point.Font = new System.Drawing.Font("Consolas", 10F);
            this.Point.Location = new System.Drawing.Point(87, 329);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(69, 52);
            this.Point.TabIndex = 11;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Porce
            // 
            this.Porce.Font = new System.Drawing.Font("Consolas", 10F);
            this.Porce.Location = new System.Drawing.Point(162, 329);
            this.Porce.Name = "Porce";
            this.Porce.Size = new System.Drawing.Size(69, 52);
            this.Porce.TabIndex = 12;
            this.Porce.Text = "%";
            this.Porce.UseVisualStyleBackColor = true;
            this.Porce.Click += new System.EventHandler(this.Porce_Click);
            // 
            // Multi
            // 
            this.Multi.Font = new System.Drawing.Font("Consolas", 10F);
            this.Multi.Location = new System.Drawing.Point(237, 257);
            this.Multi.Name = "Multi";
            this.Multi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Multi.Size = new System.Drawing.Size(69, 52);
            this.Multi.TabIndex = 13;
            this.Multi.Text = "X";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Consolas", 10F);
            this.Plus.Location = new System.Drawing.Point(237, 185);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(69, 52);
            this.Plus.TabIndex = 14;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Consolas", 10F);
            this.Minus.Location = new System.Drawing.Point(237, 110);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(69, 52);
            this.Minus.TabIndex = 15;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Consolas", 10F);
            this.C.Location = new System.Drawing.Point(326, 110);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(69, 52);
            this.C.TabIndex = 16;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // CE
            // 
            this.CE.Font = new System.Drawing.Font("Consolas", 10F);
            this.CE.Location = new System.Drawing.Point(326, 185);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(69, 52);
            this.CE.TabIndex = 17;
            this.CE.Text = "<-";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // Divi
            // 
            this.Divi.Font = new System.Drawing.Font("Consolas", 10F);
            this.Divi.Location = new System.Drawing.Point(326, 257);
            this.Divi.Name = "Divi";
            this.Divi.Size = new System.Drawing.Size(69, 52);
            this.Divi.TabIndex = 18;
            this.Divi.Text = "/";
            this.Divi.UseVisualStyleBackColor = true;
            this.Divi.Click += new System.EventHandler(this.Divi_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Consolas", 10F);
            this.Result.Location = new System.Drawing.Point(237, 329);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(158, 52);
            this.Result.TabIndex = 19;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 387);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Divi);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.Porce);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Cero);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Pantalla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Cero;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Porce;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button Divi;
        private System.Windows.Forms.Button Result;
    }
}

