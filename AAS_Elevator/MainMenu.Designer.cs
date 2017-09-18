namespace AAS_Elevator
{
    partial class MainMenu
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBookkeeping = new System.Windows.Forms.Button();
            this.buttonLaboratory = new System.Windows.Forms.Button();
            this.buttonWeighing_station = new System.Windows.Forms.Button();
            this.buttonGranary = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBookkeeping
            // 
            this.buttonBookkeeping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBookkeeping.Location = new System.Drawing.Point(40, 35);
            this.buttonBookkeeping.Name = "buttonBookkeeping";
            this.buttonBookkeeping.Size = new System.Drawing.Size(141, 65);
            this.buttonBookkeeping.TabIndex = 0;
            this.buttonBookkeeping.Text = "Бухгалтерия";
            this.buttonBookkeeping.UseVisualStyleBackColor = true;
            this.buttonBookkeeping.Click += new System.EventHandler(this.buttonBookkeeping_Click);
            // 
            // buttonLaboratory
            // 
            this.buttonLaboratory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonLaboratory.Location = new System.Drawing.Point(214, 35);
            this.buttonLaboratory.Name = "buttonLaboratory";
            this.buttonLaboratory.Size = new System.Drawing.Size(141, 65);
            this.buttonLaboratory.TabIndex = 1;
            this.buttonLaboratory.Text = "Лаборатория";
            this.buttonLaboratory.UseVisualStyleBackColor = true;
            this.buttonLaboratory.Click += new System.EventHandler(this.buttonLaboratory_Click);
            // 
            // buttonWeighing_station
            // 
            this.buttonWeighing_station.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonWeighing_station.Location = new System.Drawing.Point(385, 35);
            this.buttonWeighing_station.Name = "buttonWeighing_station";
            this.buttonWeighing_station.Size = new System.Drawing.Size(141, 65);
            this.buttonWeighing_station.TabIndex = 2;
            this.buttonWeighing_station.Text = "Весовая";
            this.buttonWeighing_station.UseVisualStyleBackColor = true;
            this.buttonWeighing_station.Click += new System.EventHandler(this.buttonWeighing_station_Click);
            // 
            // buttonGranary
            // 
            this.buttonGranary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonGranary.Location = new System.Drawing.Point(557, 35);
            this.buttonGranary.Name = "buttonGranary";
            this.buttonGranary.Size = new System.Drawing.Size(141, 65);
            this.buttonGranary.TabIndex = 3;
            this.buttonGranary.Text = "Зернохранилища";
            this.buttonGranary.UseVisualStyleBackColor = true;
            this.buttonGranary.Click += new System.EventHandler(this.buttonGranary_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonExit.Location = new System.Drawing.Point(557, 147);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(141, 65);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonHelp.Location = new System.Drawing.Point(40, 147);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(141, 65);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 247);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGranary);
            this.Controls.Add(this.buttonWeighing_station);
            this.Controls.Add(this.buttonLaboratory);
            this.Controls.Add(this.buttonBookkeeping);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Автоматизированная информационная система учета зерновых на элеваторе";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBookkeeping;
        private System.Windows.Forms.Button buttonLaboratory;
        private System.Windows.Forms.Button buttonWeighing_station;
        private System.Windows.Forms.Button buttonGranary;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHelp;
    }
}

