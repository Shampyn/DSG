namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbAmplitude = new System.Windows.Forms.TextBox();
            this.tbFrequency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Label();
            this.tbDutyCycle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbWaveTypes = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbModulTypes = new System.Windows.Forms.ComboBox();
            this.tbModulAmpl = new System.Windows.Forms.TextBox();
            this.tbModulFreq = new System.Windows.Forms.TextBox();
            this.tbModulDC = new System.Windows.Forms.TextBox();
            this.tbNone = new System.Windows.Forms.RadioButton();
            this.gb = new System.Windows.Forms.GroupBox();
            this.rbAmplitude = new System.Windows.Forms.RadioButton();
            this.rbFrequency = new System.Windows.Forms.RadioButton();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAmplitude
            // 
            this.tbAmplitude.Location = new System.Drawing.Point(104, 31);
            this.tbAmplitude.Name = "tbAmplitude";
            this.tbAmplitude.Size = new System.Drawing.Size(100, 22);
            this.tbAmplitude.TabIndex = 1;
            // 
            // tbFrequency
            // 
            this.tbFrequency.Location = new System.Drawing.Point(104, 74);
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(100, 22);
            this.tbFrequency.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amplitude";
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(15, 78);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(75, 17);
            this.f.TabIndex = 5;
            this.f.Text = "Frequency";
            // 
            // tbDutyCycle
            // 
            this.tbDutyCycle.Location = new System.Drawing.Point(104, 124);
            this.tbDutyCycle.Name = "tbDutyCycle";
            this.tbDutyCycle.Size = new System.Drawing.Size(100, 22);
            this.tbDutyCycle.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "DutyCycle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(104, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbWaveTypes
            // 
            this.cbWaveTypes.FormattingEnabled = true;
            this.cbWaveTypes.Items.AddRange(new object[] {
            "Sinusoid",
            "Triangle",
            "Pulse",
            "Noise",
            "Sawtooth"});
            this.cbWaveTypes.Location = new System.Drawing.Point(15, 165);
            this.cbWaveTypes.Name = "cbWaveTypes";
            this.cbWaveTypes.Size = new System.Drawing.Size(189, 24);
            this.cbWaveTypes.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(7, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(197, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amplitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Frequency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "DutyCycle";
            // 
            // cbModulTypes
            // 
            this.cbModulTypes.FormattingEnabled = true;
            this.cbModulTypes.Items.AddRange(new object[] {
            "Sinusoid",
            "Triangle",
            "Pulse",
            "Noise",
            "Sawtooth"});
            this.cbModulTypes.Location = new System.Drawing.Point(521, 165);
            this.cbModulTypes.Name = "cbModulTypes";
            this.cbModulTypes.Size = new System.Drawing.Size(203, 24);
            this.cbModulTypes.TabIndex = 14;
            // 
            // tbModulAmpl
            // 
            this.tbModulAmpl.Location = new System.Drawing.Point(624, 36);
            this.tbModulAmpl.Name = "tbModulAmpl";
            this.tbModulAmpl.Size = new System.Drawing.Size(100, 22);
            this.tbModulAmpl.TabIndex = 15;
            // 
            // tbModulFreq
            // 
            this.tbModulFreq.Location = new System.Drawing.Point(624, 76);
            this.tbModulFreq.Name = "tbModulFreq";
            this.tbModulFreq.Size = new System.Drawing.Size(100, 22);
            this.tbModulFreq.TabIndex = 16;
            // 
            // tbModulDC
            // 
            this.tbModulDC.Location = new System.Drawing.Point(624, 124);
            this.tbModulDC.Name = "tbModulDC";
            this.tbModulDC.Size = new System.Drawing.Size(100, 22);
            this.tbModulDC.TabIndex = 17;
            // 
            // tbNone
            // 
            this.tbNone.AutoSize = true;
            this.tbNone.Location = new System.Drawing.Point(6, 21);
            this.tbNone.Name = "tbNone";
            this.tbNone.Size = new System.Drawing.Size(63, 21);
            this.tbNone.TabIndex = 18;
            this.tbNone.TabStop = true;
            this.tbNone.Text = "None";
            this.tbNone.UseVisualStyleBackColor = true;
            this.tbNone.CheckedChanged += new System.EventHandler(this.tbNone_CheckedChanged);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.rbFrequency);
            this.gb.Controls.Add(this.rbAmplitude);
            this.gb.Controls.Add(this.tbNone);
            this.gb.Location = new System.Drawing.Point(521, 207);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(200, 100);
            this.gb.TabIndex = 19;
            this.gb.TabStop = false;
            this.gb.Text = "ModType";
            // 
            // rbAmplitude
            // 
            this.rbAmplitude.AutoSize = true;
            this.rbAmplitude.Location = new System.Drawing.Point(6, 46);
            this.rbAmplitude.Name = "rbAmplitude";
            this.rbAmplitude.Size = new System.Drawing.Size(91, 21);
            this.rbAmplitude.TabIndex = 19;
            this.rbAmplitude.TabStop = true;
            this.rbAmplitude.Text = "Amplitude";
            this.rbAmplitude.UseVisualStyleBackColor = true;
            this.rbAmplitude.CheckedChanged += new System.EventHandler(this.rbAmplitude_CheckedChanged);
            // 
            // rbFrequency
            // 
            this.rbFrequency.AutoSize = true;
            this.rbFrequency.Location = new System.Drawing.Point(6, 73);
            this.rbFrequency.Name = "rbFrequency";
            this.rbFrequency.Size = new System.Drawing.Size(96, 21);
            this.rbFrequency.TabIndex = 20;
            this.rbFrequency.TabStop = true;
            this.rbFrequency.Text = "Frequency";
            this.rbFrequency.UseVisualStyleBackColor = true;
            this.rbFrequency.CheckedChanged += new System.EventHandler(this.rbFrequency_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.tbModulDC);
            this.Controls.Add(this.tbModulFreq);
            this.Controls.Add(this.tbModulAmpl);
            this.Controls.Add(this.cbModulTypes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbWaveTypes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDutyCycle);
            this.Controls.Add(this.f);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFrequency);
            this.Controls.Add(this.tbAmplitude);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAmplitude;
        private System.Windows.Forms.TextBox tbFrequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.TextBox tbDutyCycle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbWaveTypes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbModulTypes;
        private System.Windows.Forms.TextBox tbModulAmpl;
        private System.Windows.Forms.TextBox tbModulFreq;
        private System.Windows.Forms.TextBox tbModulDC;
        private System.Windows.Forms.RadioButton tbNone;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton rbFrequency;
        private System.Windows.Forms.RadioButton rbAmplitude;
    }
}

