namespace MagicTrick
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
            this.lstBxMonths = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBttnMultiplyBy10 = new System.Windows.Forms.RadioButton();
            this.rdoBttnMultiplyBy5 = new System.Windows.Forms.RadioButton();
            this.rdoBttnMultiplyBy2 = new System.Windows.Forms.RadioButton();
            this.bttnStart = new System.Windows.Forms.Button();
            this.bttnClosesApp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBScheming = new System.Windows.Forms.CheckBox();
            this.cBPushover = new System.Windows.Forms.CheckBox();
            this.cBNormal = new System.Windows.Forms.CheckBox();
            this.cBPessimistic = new System.Windows.Forms.CheckBox();
            this.cBEcstatic = new System.Windows.Forms.CheckBox();
            this.cBListless = new System.Windows.Forms.CheckBox();
            this.cBBoring = new System.Windows.Forms.CheckBox();
            this.cBConsiderate = new System.Windows.Forms.CheckBox();
            this.cBHumorless = new System.Windows.Forms.CheckBox();
            this.cBMean = new System.Windows.Forms.CheckBox();
            this.cBNice = new System.Windows.Forms.CheckBox();
            this.cBProtective = new System.Windows.Forms.CheckBox();
            this.lblAnswerPrediction = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnYes = new System.Windows.Forms.Button();
            this.bttnNo = new System.Windows.Forms.Button();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblFailure = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBxMonths
            // 
            this.lstBxMonths.FormattingEnabled = true;
            this.lstBxMonths.Items.AddRange(new object[] {
            "1 = January",
            "2 = February",
            "3 = March",
            "4 = April",
            "5 = May",
            "6 = June",
            "7 = July",
            "8 = August",
            "9 = September",
            "10 = October",
            "11 = November",
            "12 = December"});
            this.lstBxMonths.Location = new System.Drawing.Point(12, 30);
            this.lstBxMonths.Name = "lstBxMonths";
            this.lstBxMonths.Size = new System.Drawing.Size(120, 160);
            this.lstBxMonths.TabIndex = 0;
            this.lstBxMonths.DoubleClick += new System.EventHandler(this.lstBxMonths_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the number associated with your birth month. (Make sure to double click)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.rdoBttnMultiplyBy10);
            this.groupBox1.Controls.Add(this.rdoBttnMultiplyBy5);
            this.groupBox1.Controls.Add(this.rdoBttnMultiplyBy2);
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Now choose one.";
            // 
            // rdoBttnMultiplyBy10
            // 
            this.rdoBttnMultiplyBy10.AutoSize = true;
            this.rdoBttnMultiplyBy10.Location = new System.Drawing.Point(7, 68);
            this.rdoBttnMultiplyBy10.Name = "rdoBttnMultiplyBy10";
            this.rdoBttnMultiplyBy10.Size = new System.Drawing.Size(89, 17);
            this.rdoBttnMultiplyBy10.TabIndex = 2;
            this.rdoBttnMultiplyBy10.TabStop = true;
            this.rdoBttnMultiplyBy10.Text = "Multiply by 10";
            this.rdoBttnMultiplyBy10.UseVisualStyleBackColor = true;
            this.rdoBttnMultiplyBy10.CheckedChanged += new System.EventHandler(this.rdoBttnMultiplyBy10_CheckedChanged);
            // 
            // rdoBttnMultiplyBy5
            // 
            this.rdoBttnMultiplyBy5.AutoSize = true;
            this.rdoBttnMultiplyBy5.Location = new System.Drawing.Point(7, 44);
            this.rdoBttnMultiplyBy5.Name = "rdoBttnMultiplyBy5";
            this.rdoBttnMultiplyBy5.Size = new System.Drawing.Size(83, 17);
            this.rdoBttnMultiplyBy5.TabIndex = 1;
            this.rdoBttnMultiplyBy5.TabStop = true;
            this.rdoBttnMultiplyBy5.Text = "Multiply by 5";
            this.rdoBttnMultiplyBy5.UseVisualStyleBackColor = true;
            this.rdoBttnMultiplyBy5.CheckedChanged += new System.EventHandler(this.rdoBttnMultiplyBy5_CheckedChanged);
            // 
            // rdoBttnMultiplyBy2
            // 
            this.rdoBttnMultiplyBy2.AutoSize = true;
            this.rdoBttnMultiplyBy2.Location = new System.Drawing.Point(7, 20);
            this.rdoBttnMultiplyBy2.Name = "rdoBttnMultiplyBy2";
            this.rdoBttnMultiplyBy2.Size = new System.Drawing.Size(83, 17);
            this.rdoBttnMultiplyBy2.TabIndex = 0;
            this.rdoBttnMultiplyBy2.TabStop = true;
            this.rdoBttnMultiplyBy2.Text = "Multiply by 2";
            this.rdoBttnMultiplyBy2.UseVisualStyleBackColor = true;
            this.rdoBttnMultiplyBy2.CheckedChanged += new System.EventHandler(this.rdoBttnMultiplyBy2_CheckedChanged);
            // 
            // bttnStart
            // 
            this.bttnStart.BackColor = System.Drawing.Color.Aqua;
            this.bttnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttnStart.Location = new System.Drawing.Point(405, 28);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(146, 67);
            this.bttnStart.TabIndex = 3;
            this.bttnStart.Text = "Click me to start!!";
            this.bttnStart.UseVisualStyleBackColor = false;
            this.bttnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnClosesApp
            // 
            this.bttnClosesApp.Location = new System.Drawing.Point(476, 274);
            this.bttnClosesApp.Name = "bttnClosesApp";
            this.bttnClosesApp.Size = new System.Drawing.Size(75, 23);
            this.bttnClosesApp.TabIndex = 5;
            this.bttnClosesApp.Text = "Exit ";
            this.bttnClosesApp.UseVisualStyleBackColor = true;
            this.bttnClosesApp.Click += new System.EventHandler(this.bttnClosesApp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.cBScheming);
            this.groupBox2.Controls.Add(this.cBPushover);
            this.groupBox2.Controls.Add(this.cBNormal);
            this.groupBox2.Controls.Add(this.cBPessimistic);
            this.groupBox2.Controls.Add(this.cBEcstatic);
            this.groupBox2.Controls.Add(this.cBListless);
            this.groupBox2.Controls.Add(this.cBBoring);
            this.groupBox2.Controls.Add(this.cBConsiderate);
            this.groupBox2.Controls.Add(this.cBHumorless);
            this.groupBox2.Controls.Add(this.cBMean);
            this.groupBox2.Controls.Add(this.cBNice);
            this.groupBox2.Controls.Add(this.cBProtective);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(138, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 170);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check which number your birth month became. ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cBScheming
            // 
            this.cBScheming.AutoSize = true;
            this.cBScheming.Location = new System.Drawing.Point(113, 142);
            this.cBScheming.Name = "cBScheming";
            this.cBScheming.Size = new System.Drawing.Size(91, 17);
            this.cBScheming.TabIndex = 11;
            this.cBScheming.Text = "12) Scheming";
            this.cBScheming.UseVisualStyleBackColor = true;
            this.cBScheming.CheckedChanged += new System.EventHandler(this.cBScheming_CheckedChanged);
            // 
            // cBPushover
            // 
            this.cBPushover.AutoSize = true;
            this.cBPushover.Location = new System.Drawing.Point(113, 122);
            this.cBPushover.Name = "cBPushover";
            this.cBPushover.Size = new System.Drawing.Size(89, 17);
            this.cBPushover.TabIndex = 10;
            this.cBPushover.Text = "11) Pushover";
            this.cBPushover.UseVisualStyleBackColor = true;
            this.cBPushover.CheckedChanged += new System.EventHandler(this.cBPushover_CheckedChanged);
            // 
            // cBNormal
            // 
            this.cBNormal.AutoSize = true;
            this.cBNormal.Location = new System.Drawing.Point(113, 98);
            this.cBNormal.Name = "cBNormal";
            this.cBNormal.Size = new System.Drawing.Size(77, 17);
            this.cBNormal.TabIndex = 9;
            this.cBNormal.Text = "10) Normal";
            this.cBNormal.UseVisualStyleBackColor = true;
            this.cBNormal.CheckedChanged += new System.EventHandler(this.cBNormal_CheckedChanged);
            // 
            // cBPessimistic
            // 
            this.cBPessimistic.AutoSize = true;
            this.cBPessimistic.Location = new System.Drawing.Point(113, 74);
            this.cBPessimistic.Name = "cBPessimistic";
            this.cBPessimistic.Size = new System.Drawing.Size(89, 17);
            this.cBPessimistic.TabIndex = 8;
            this.cBPessimistic.Text = "9) Pessimistic";
            this.cBPessimistic.UseVisualStyleBackColor = true;
            this.cBPessimistic.CheckedChanged += new System.EventHandler(this.cBPessimistic_CheckedChanged);
            // 
            // cBEcstatic
            // 
            this.cBEcstatic.AutoSize = true;
            this.cBEcstatic.Location = new System.Drawing.Point(113, 50);
            this.cBEcstatic.Name = "cBEcstatic";
            this.cBEcstatic.Size = new System.Drawing.Size(76, 17);
            this.cBEcstatic.TabIndex = 7;
            this.cBEcstatic.Text = "8) Ecstatic";
            this.cBEcstatic.UseVisualStyleBackColor = true;
            this.cBEcstatic.CheckedChanged += new System.EventHandler(this.cBEcstatic_CheckedChanged);
            // 
            // cBListless
            // 
            this.cBListless.AutoSize = true;
            this.cBListless.Location = new System.Drawing.Point(113, 26);
            this.cBListless.Name = "cBListless";
            this.cBListless.Size = new System.Drawing.Size(72, 17);
            this.cBListless.TabIndex = 6;
            this.cBListless.Text = "7) Listless";
            this.cBListless.UseVisualStyleBackColor = true;
            this.cBListless.CheckedChanged += new System.EventHandler(this.cBListless_CheckedChanged);
            // 
            // cBBoring
            // 
            this.cBBoring.AutoSize = true;
            this.cBBoring.Location = new System.Drawing.Point(6, 142);
            this.cBBoring.Name = "cBBoring";
            this.cBBoring.Size = new System.Drawing.Size(68, 17);
            this.cBBoring.TabIndex = 5;
            this.cBBoring.Text = "6) Boring";
            this.cBBoring.UseVisualStyleBackColor = true;
            this.cBBoring.CheckedChanged += new System.EventHandler(this.cBBoring_CheckedChanged);
            // 
            // cBConsiderate
            // 
            this.cBConsiderate.AutoSize = true;
            this.cBConsiderate.Location = new System.Drawing.Point(6, 122);
            this.cBConsiderate.Name = "cBConsiderate";
            this.cBConsiderate.Size = new System.Drawing.Size(94, 17);
            this.cBConsiderate.TabIndex = 4;
            this.cBConsiderate.Text = "5) Considerate";
            this.cBConsiderate.UseVisualStyleBackColor = true;
            this.cBConsiderate.CheckedChanged += new System.EventHandler(this.cBConsiderate_CheckedChanged);
            // 
            // cBHumorless
            // 
            this.cBHumorless.AutoSize = true;
            this.cBHumorless.Location = new System.Drawing.Point(6, 98);
            this.cBHumorless.Name = "cBHumorless";
            this.cBHumorless.Size = new System.Drawing.Size(87, 17);
            this.cBHumorless.TabIndex = 3;
            this.cBHumorless.Text = "4) Humorless";
            this.cBHumorless.UseVisualStyleBackColor = true;
            this.cBHumorless.CheckedChanged += new System.EventHandler(this.cBHumorless_CheckedChanged);
            // 
            // cBMean
            // 
            this.cBMean.AutoSize = true;
            this.cBMean.Location = new System.Drawing.Point(6, 74);
            this.cBMean.Name = "cBMean";
            this.cBMean.Size = new System.Drawing.Size(65, 17);
            this.cBMean.TabIndex = 2;
            this.cBMean.Text = "3) Mean";
            this.cBMean.UseVisualStyleBackColor = true;
            this.cBMean.CheckedChanged += new System.EventHandler(this.cBMean_CheckedChanged);
            // 
            // cBNice
            // 
            this.cBNice.AutoSize = true;
            this.cBNice.Location = new System.Drawing.Point(6, 50);
            this.cBNice.Name = "cBNice";
            this.cBNice.Size = new System.Drawing.Size(60, 17);
            this.cBNice.TabIndex = 1;
            this.cBNice.Text = "2) Nice";
            this.cBNice.UseVisualStyleBackColor = true;
            this.cBNice.CheckedChanged += new System.EventHandler(this.cBNice_CheckedChanged);
            // 
            // cBProtective
            // 
            this.cBProtective.AutoSize = true;
            this.cBProtective.Location = new System.Drawing.Point(6, 26);
            this.cBProtective.Name = "cBProtective";
            this.cBProtective.Size = new System.Drawing.Size(86, 17);
            this.cBProtective.TabIndex = 0;
            this.cBProtective.Text = "1) Protective";
            this.cBProtective.UseVisualStyleBackColor = true;
            this.cBProtective.CheckedChanged += new System.EventHandler(this.cBProtective_CheckedChanged);
            // 
            // lblAnswerPrediction
            // 
            this.lblAnswerPrediction.AutoSize = true;
            this.lblAnswerPrediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPrediction.Location = new System.Drawing.Point(138, 31);
            this.lblAnswerPrediction.Name = "lblAnswerPrediction";
            this.lblAnswerPrediction.Size = new System.Drawing.Size(0, 20);
            this.lblAnswerPrediction.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Was I correct?";
            // 
            // bttnYes
            // 
            this.bttnYes.BackColor = System.Drawing.Color.Lime;
            this.bttnYes.Location = new System.Drawing.Point(409, 172);
            this.bttnYes.Name = "bttnYes";
            this.bttnYes.Size = new System.Drawing.Size(142, 34);
            this.bttnYes.TabIndex = 9;
            this.bttnYes.Text = "Yes";
            this.bttnYes.UseVisualStyleBackColor = false;
            this.bttnYes.Click += new System.EventHandler(this.bttnYes_Click);
            // 
            // bttnNo
            // 
            this.bttnNo.BackColor = System.Drawing.Color.Red;
            this.bttnNo.Location = new System.Drawing.Point(409, 212);
            this.bttnNo.Name = "bttnNo";
            this.bttnNo.Size = new System.Drawing.Size(142, 37);
            this.bttnNo.TabIndex = 10;
            this.bttnNo.Text = "No";
            this.bttnNo.UseVisualStyleBackColor = false;
            this.bttnNo.Click += new System.EventHandler(this.bttnNo_Click);
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.Location = new System.Drawing.Point(138, 63);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 20);
            this.lblSuccess.TabIndex = 11;
            this.lblSuccess.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFailure
            // 
            this.lblFailure.AutoSize = true;
            this.lblFailure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailure.Location = new System.Drawing.Point(138, 95);
            this.lblFailure.Name = "lblFailure";
            this.lblFailure.Size = new System.Drawing.Size(0, 20);
            this.lblFailure.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 311);
            this.Controls.Add(this.lblFailure);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.bttnNo);
            this.Controls.Add(this.bttnYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAnswerPrediction);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bttnClosesApp);
            this.Controls.Add(this.bttnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBxMonths);
            this.Name = "Form1";
            this.Text = "A simple magic trick ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxMonths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBttnMultiplyBy10;
        private System.Windows.Forms.RadioButton rdoBttnMultiplyBy5;
        private System.Windows.Forms.RadioButton rdoBttnMultiplyBy2;
        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.Button bttnClosesApp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cBScheming;
        private System.Windows.Forms.CheckBox cBPushover;
        private System.Windows.Forms.CheckBox cBNormal;
        private System.Windows.Forms.CheckBox cBPessimistic;
        private System.Windows.Forms.CheckBox cBEcstatic;
        private System.Windows.Forms.CheckBox cBListless;
        private System.Windows.Forms.CheckBox cBBoring;
        private System.Windows.Forms.CheckBox cBConsiderate;
        private System.Windows.Forms.CheckBox cBHumorless;
        private System.Windows.Forms.CheckBox cBMean;
        private System.Windows.Forms.CheckBox cBNice;
        private System.Windows.Forms.CheckBox cBProtective;
        private System.Windows.Forms.Label lblAnswerPrediction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnYes;
        private System.Windows.Forms.Button bttnNo;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblFailure;
    }
}

