namespace GeneticAlgorithims
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.simSpeed = new System.Windows.Forms.TrackBar();
            this.traceLength = new System.Windows.Forms.TrackBar();
            this.mutationRate = new System.Windows.Forms.TrackBar();
            this.foodRate = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.asdsd = new System.Windows.Forms.Label();
            this.canDie = new System.Windows.Forms.CheckBox();
            this.canRepo = new System.Windows.Forms.CheckBox();
            this.clearFood = new System.Windows.Forms.Button();
            this.clearOrgan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.simSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traceLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodRate)).BeginInit();
            this.SuspendLayout();
            // 
            // simSpeed
            // 
            this.simSpeed.Location = new System.Drawing.Point(168, 201);
            this.simSpeed.Maximum = 100;
            this.simSpeed.Name = "simSpeed";
            this.simSpeed.Size = new System.Drawing.Size(104, 45);
            this.simSpeed.TabIndex = 0;
            this.simSpeed.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // traceLength
            // 
            this.traceLength.Location = new System.Drawing.Point(168, 150);
            this.traceLength.Name = "traceLength";
            this.traceLength.Size = new System.Drawing.Size(104, 45);
            this.traceLength.TabIndex = 1;
            this.traceLength.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // mutationRate
            // 
            this.mutationRate.Location = new System.Drawing.Point(168, 99);
            this.mutationRate.Name = "mutationRate";
            this.mutationRate.Size = new System.Drawing.Size(104, 45);
            this.mutationRate.TabIndex = 2;
            // 
            // foodRate
            // 
            this.foodRate.Location = new System.Drawing.Point(168, 48);
            this.foodRate.Name = "foodRate";
            this.foodRate.Size = new System.Drawing.Size(104, 45);
            this.foodRate.TabIndex = 3;
            this.foodRate.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Food Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.label2.Location = new System.Drawing.Point(11, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mutation Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(11, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.lbl4.Location = new System.Drawing.Point(13, 201);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(109, 25);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Sim Speed";
            // 
            // asdsd
            // 
            this.asdsd.AutoSize = true;
            this.asdsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.asdsd.Location = new System.Drawing.Point(11, 150);
            this.asdsd.Name = "asdsd";
            this.asdsd.Size = new System.Drawing.Size(128, 25);
            this.asdsd.TabIndex = 8;
            this.asdsd.Text = "Trace Length";
            // 
            // canDie
            // 
            this.canDie.AutoSize = true;
            this.canDie.Checked = true;
            this.canDie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.canDie.Location = new System.Drawing.Point(308, 48);
            this.canDie.Name = "canDie";
            this.canDie.Size = new System.Drawing.Size(62, 17);
            this.canDie.TabIndex = 9;
            this.canDie.Text = "Can die";
            this.canDie.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.canDie.UseVisualStyleBackColor = true;
            // 
            // canRepo
            // 
            this.canRepo.AutoSize = true;
            this.canRepo.Checked = true;
            this.canRepo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.canRepo.Location = new System.Drawing.Point(308, 75);
            this.canRepo.Name = "canRepo";
            this.canRepo.Size = new System.Drawing.Size(96, 17);
            this.canRepo.TabIndex = 10;
            this.canRepo.Text = "Can reproduce";
            this.canRepo.UseVisualStyleBackColor = true;
            // 
            // clearFood
            // 
            this.clearFood.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearFood.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.clearFood.Location = new System.Drawing.Point(308, 101);
            this.clearFood.Name = "clearFood";
            this.clearFood.Size = new System.Drawing.Size(115, 43);
            this.clearFood.TabIndex = 11;
            this.clearFood.Text = "Clear Food";
            this.clearFood.UseVisualStyleBackColor = false;
            this.clearFood.Click += new System.EventHandler(this.clearFood_Click);
            // 
            // clearOrgan
            // 
            this.clearOrgan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearOrgan.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.clearOrgan.Location = new System.Drawing.Point(308, 150);
            this.clearOrgan.Name = "clearOrgan";
            this.clearOrgan.Size = new System.Drawing.Size(115, 45);
            this.clearOrgan.TabIndex = 12;
            this.clearOrgan.Text = "Clear Organisms";
            this.clearOrgan.UseVisualStyleBackColor = false;
            this.clearOrgan.Click += new System.EventHandler(this.clearOrgan_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.clearOrgan);
            this.Controls.Add(this.clearFood);
            this.Controls.Add(this.canRepo);
            this.Controls.Add(this.canDie);
            this.Controls.Add(this.asdsd);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foodRate);
            this.Controls.Add(this.mutationRate);
            this.Controls.Add(this.traceLength);
            this.Controls.Add(this.simSpeed);
            this.Location = new System.Drawing.Point(512, 0);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.simSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traceLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TrackBar simSpeed;
        public System.Windows.Forms.TrackBar traceLength;
        public System.Windows.Forms.TrackBar mutationRate;
        public System.Windows.Forms.TrackBar foodRate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl4;
        public System.Windows.Forms.Label asdsd;
        public System.Windows.Forms.CheckBox canDie;
        public System.Windows.Forms.CheckBox canRepo;
        public System.Windows.Forms.Button clearFood;
        public System.Windows.Forms.Button clearOrgan;
    }
}