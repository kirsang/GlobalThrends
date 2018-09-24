namespace Thrends
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this._MainControlZG = new ZedGraph.ZedGraphControl();
            this._Button1Otrisovka = new System.Windows.Forms.Button();
            this._Button2Otrisovka = new System.Windows.Forms.Button();
            this._ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _MainControlZG
            // 
            this._MainControlZG.Location = new System.Drawing.Point(34, 38);
            this._MainControlZG.Name = "_MainControlZG";
            this._MainControlZG.ScrollGrace = 0D;
            this._MainControlZG.ScrollMaxX = 0D;
            this._MainControlZG.ScrollMaxY = 0D;
            this._MainControlZG.ScrollMaxY2 = 0D;
            this._MainControlZG.ScrollMinX = 0D;
            this._MainControlZG.ScrollMinY = 0D;
            this._MainControlZG.ScrollMinY2 = 0D;
            this._MainControlZG.Size = new System.Drawing.Size(565, 263);
            this._MainControlZG.TabIndex = 0;
            this._MainControlZG.UseExtendedPrintDialog = true;
            // 
            // _Button1Otrisovka
            // 
            this._Button1Otrisovka.Location = new System.Drawing.Point(605, 38);
            this._Button1Otrisovka.Name = "_Button1Otrisovka";
            this._Button1Otrisovka.Size = new System.Drawing.Size(225, 33);
            this._Button1Otrisovka.TabIndex = 1;
            this._Button1Otrisovka.Text = "1 отрисовка";
            this._Button1Otrisovka.UseVisualStyleBackColor = true;
            this._Button1Otrisovka.Click += new System.EventHandler(this._Button1Otrisovka_Click);
            // 
            // _Button2Otrisovka
            // 
            this._Button2Otrisovka.Location = new System.Drawing.Point(605, 77);
            this._Button2Otrisovka.Name = "_Button2Otrisovka";
            this._Button2Otrisovka.Size = new System.Drawing.Size(225, 31);
            this._Button2Otrisovka.TabIndex = 2;
            this._Button2Otrisovka.Text = "Последующая отрисовка";
            this._Button2Otrisovka.UseVisualStyleBackColor = true;
            this._Button2Otrisovka.Click += new System.EventHandler(this._Button2Otrisovka_Click);
            // 
            // _ButtonExit
            // 
            this._ButtonExit.Location = new System.Drawing.Point(605, 114);
            this._ButtonExit.Name = "_ButtonExit";
            this._ButtonExit.Size = new System.Drawing.Size(225, 35);
            this._ButtonExit.TabIndex = 3;
            this._ButtonExit.Text = "Выход";
            this._ButtonExit.UseVisualStyleBackColor = true;
            this._ButtonExit.Click += new System.EventHandler(this._ButtonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 336);
            this.Controls.Add(this._ButtonExit);
            this.Controls.Add(this._Button2Otrisovka);
            this.Controls.Add(this._Button1Otrisovka);
            this.Controls.Add(this._MainControlZG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ZedGraph.ZedGraphControl _MainControlZG;
        private System.Windows.Forms.Button _Button1Otrisovka;
        private System.Windows.Forms.Button _Button2Otrisovka;
        private System.Windows.Forms.Button _ButtonExit;
    }
}

