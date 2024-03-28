namespace LabTP9
{
    partial class MainForm
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
            this.buttonPaint = new System.Windows.Forms.Button();
            this.checkBoxWalls = new System.Windows.Forms.CheckBox();
            this.checkBoxWindows = new System.Windows.Forms.CheckBox();
            this.checkBoxRoof = new System.Windows.Forms.CheckBox();
            this.checkBoxDoor = new System.Windows.Forms.CheckBox();
            this.checkBoxPipe = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonPaint
            // 
            this.buttonPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPaint.Location = new System.Drawing.Point(29, 358);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(95, 39);
            this.buttonPaint.TabIndex = 0;
            this.buttonPaint.Text = "Рисовать";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // checkBoxWalls
            // 
            this.checkBoxWalls.AutoSize = true;
            this.checkBoxWalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWalls.Location = new System.Drawing.Point(29, 30);
            this.checkBoxWalls.Name = "checkBoxWalls";
            this.checkBoxWalls.Size = new System.Drawing.Size(69, 21);
            this.checkBoxWalls.TabIndex = 1;
            this.checkBoxWalls.Text = "Стены";
            this.checkBoxWalls.UseVisualStyleBackColor = true;
            this.checkBoxWalls.CheckedChanged += new System.EventHandler(this.checkBoxWalls_CheckedChanged);
            // 
            // checkBoxWindows
            // 
            this.checkBoxWindows.AutoSize = true;
            this.checkBoxWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWindows.Location = new System.Drawing.Point(31, 90);
            this.checkBoxWindows.Name = "checkBoxWindows";
            this.checkBoxWindows.Size = new System.Drawing.Size(61, 21);
            this.checkBoxWindows.TabIndex = 2;
            this.checkBoxWindows.Text = "Окна";
            this.checkBoxWindows.UseVisualStyleBackColor = true;
            this.checkBoxWindows.CheckedChanged += new System.EventHandler(this.checkBoxWindows_CheckedChanged);
            // 
            // checkBoxRoof
            // 
            this.checkBoxRoof.AutoSize = true;
            this.checkBoxRoof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRoof.Location = new System.Drawing.Point(29, 159);
            this.checkBoxRoof.Name = "checkBoxRoof";
            this.checkBoxRoof.Size = new System.Drawing.Size(73, 21);
            this.checkBoxRoof.TabIndex = 3;
            this.checkBoxRoof.Text = "Крыша";
            this.checkBoxRoof.UseVisualStyleBackColor = true;
            this.checkBoxRoof.CheckedChanged += new System.EventHandler(this.checkBoxRoof_CheckedChanged);
            // 
            // checkBoxDoor
            // 
            this.checkBoxDoor.AutoSize = true;
            this.checkBoxDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDoor.Location = new System.Drawing.Point(29, 225);
            this.checkBoxDoor.Name = "checkBoxDoor";
            this.checkBoxDoor.Size = new System.Drawing.Size(68, 21);
            this.checkBoxDoor.TabIndex = 4;
            this.checkBoxDoor.Text = "Дверь";
            this.checkBoxDoor.UseVisualStyleBackColor = true;
            this.checkBoxDoor.CheckedChanged += new System.EventHandler(this.checkBoxDoor_CheckedChanged);
            // 
            // checkBoxPipe
            // 
            this.checkBoxPipe.AutoSize = true;
            this.checkBoxPipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPipe.Location = new System.Drawing.Point(29, 292);
            this.checkBoxPipe.Name = "checkBoxPipe";
            this.checkBoxPipe.Size = new System.Drawing.Size(67, 21);
            this.checkBoxPipe.TabIndex = 5;
            this.checkBoxPipe.Text = "Труба";
            this.checkBoxPipe.UseVisualStyleBackColor = true;
            this.checkBoxPipe.CheckedChanged += new System.EventHandler(this.checkBoxPipe_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.progressBar1.Location = new System.Drawing.Point(222, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(865, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(222, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 626);
            this.panel1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1099, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkBoxPipe);
            this.Controls.Add(this.checkBoxDoor);
            this.Controls.Add(this.checkBoxRoof);
            this.Controls.Add(this.checkBoxWindows);
            this.Controls.Add(this.checkBoxWalls);
            this.Controls.Add(this.buttonPaint);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPaint;
        private System.Windows.Forms.CheckBox checkBoxWalls;
        private System.Windows.Forms.CheckBox checkBoxWindows;
        private System.Windows.Forms.CheckBox checkBoxRoof;
        private System.Windows.Forms.CheckBox checkBoxDoor;
        private System.Windows.Forms.CheckBox checkBoxPipe;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
    }
}

