namespace CoffeeMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PowerButton = new Button();
            BlackCoffee = new Button();
            CappuccinoCoffee = new Button();
            EspressoCoffe = new Button();
            FullCupCoffee = new Button();
            HalfCupCoffe = new Button();
            Display = new RichTextBox();
            RunCoffee = new Button();
            SugarLevel = new ProgressBar();
            AddSugar = new Button();
            SubSugar = new Button();
            label1 = new Label();
            CoffeBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CoffeBox).BeginInit();
            SuspendLayout();
            // 
            // PowerButton
            // 
            PowerButton.BackgroundImage = (Image)resources.GetObject("PowerButton.BackgroundImage");
            PowerButton.Location = new Point(683, 245);
            PowerButton.Name = "PowerButton";
            PowerButton.Size = new Size(45, 45);
            PowerButton.TabIndex = 0;
            PowerButton.UseVisualStyleBackColor = true;
            PowerButton.Click += PowerButton_Click;
            // 
            // BlackCoffee
            // 
            BlackCoffee.BackgroundImage = (Image)resources.GetObject("BlackCoffee.BackgroundImage");
            BlackCoffee.Location = new Point(437, 245);
            BlackCoffee.Name = "BlackCoffee";
            BlackCoffee.Size = new Size(45, 45);
            BlackCoffee.TabIndex = 1;
            BlackCoffee.UseVisualStyleBackColor = true;
            BlackCoffee.Click += BlackCoffee_Click;
            // 
            // CappuccinoCoffee
            // 
            CappuccinoCoffee.BackgroundImage = (Image)resources.GetObject("CappuccinoCoffee.BackgroundImage");
            CappuccinoCoffee.Location = new Point(437, 290);
            CappuccinoCoffee.Name = "CappuccinoCoffee";
            CappuccinoCoffee.Size = new Size(45, 45);
            CappuccinoCoffee.TabIndex = 2;
            CappuccinoCoffee.UseVisualStyleBackColor = true;
            CappuccinoCoffee.Click += CappuccinoCoffee_Click;
            // 
            // EspressoCoffe
            // 
            EspressoCoffe.BackgroundImage = (Image)resources.GetObject("EspressoCoffe.BackgroundImage");
            EspressoCoffe.Location = new Point(437, 335);
            EspressoCoffe.Name = "EspressoCoffe";
            EspressoCoffe.Size = new Size(45, 45);
            EspressoCoffe.TabIndex = 3;
            EspressoCoffe.UseVisualStyleBackColor = true;
            EspressoCoffe.Click += EspressoCoffe_Click;
            // 
            // FullCupCoffee
            // 
            FullCupCoffee.BackgroundImage = (Image)resources.GetObject("FullCupCoffee.BackgroundImage");
            FullCupCoffee.Location = new Point(683, 290);
            FullCupCoffee.Name = "FullCupCoffee";
            FullCupCoffee.Size = new Size(45, 45);
            FullCupCoffee.TabIndex = 4;
            FullCupCoffee.UseVisualStyleBackColor = true;
            FullCupCoffee.Click += FullCupCoffee_Click;
            // 
            // HalfCupCoffe
            // 
            HalfCupCoffe.BackgroundImage = (Image)resources.GetObject("HalfCupCoffe.BackgroundImage");
            HalfCupCoffe.Location = new Point(683, 335);
            HalfCupCoffe.Name = "HalfCupCoffe";
            HalfCupCoffe.Size = new Size(45, 45);
            HalfCupCoffe.TabIndex = 5;
            HalfCupCoffe.UseVisualStyleBackColor = true;
            HalfCupCoffe.Click += HalfCupCoffe_Click;
            // 
            // Display
            // 
            Display.Location = new Point(499, 245);
            Display.Name = "Display";
            Display.Size = new Size(169, 135);
            Display.TabIndex = 6;
            Display.Text = "";
            Display.TextChanged += Display_TextChanged;
            // 
            // RunCoffee
            // 
            RunCoffee.BackgroundImage = (Image)resources.GetObject("RunCoffee.BackgroundImage");
            RunCoffee.Location = new Point(823, 272);
            RunCoffee.Name = "RunCoffee";
            RunCoffee.Size = new Size(80, 80);
            RunCoffee.TabIndex = 7;
            RunCoffee.UseVisualStyleBackColor = true;
            RunCoffee.Click += RunCoffee_Click;
            // 
            // SugarLevel
            // 
            SugarLevel.Location = new Point(499, 417);
            SugarLevel.Name = "SugarLevel";
            SugarLevel.Size = new Size(169, 29);
            SugarLevel.TabIndex = 8;
            // 
            // AddSugar
            // 
            AddSugar.Font = new Font("Segoe UI", 20F);
            AddSugar.ImageAlign = ContentAlignment.MiddleLeft;
            AddSugar.Location = new Point(683, 401);
            AddSugar.Name = "AddSugar";
            AddSugar.Size = new Size(45, 45);
            AddSugar.TabIndex = 9;
            AddSugar.Text = "+";
            AddSugar.TextAlign = ContentAlignment.MiddleRight;
            AddSugar.UseVisualStyleBackColor = true;
            AddSugar.Click += AddSugar_Click;
            // 
            // SubSugar
            // 
            SubSugar.Font = new Font("Segoe UI", 20F);
            SubSugar.Location = new Point(437, 401);
            SubSugar.Name = "SubSugar";
            SubSugar.Size = new Size(45, 45);
            SubSugar.TabIndex = 10;
            SubSugar.Text = "-";
            SubSugar.UseVisualStyleBackColor = true;
            SubSugar.Click += SubSugar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(528, 393);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 11;
            label1.Text = "Poziom Cukru";
            // 
            // CoffeBox
            // 
            CoffeBox.BackColor = Color.Transparent;
            CoffeBox.Location = new Point(437, 748);
            CoffeBox.Name = "CoffeBox";
            CoffeBox.Size = new Size(291, 250);
            CoffeBox.TabIndex = 12;
            CoffeBox.TabStop = false;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1089, 1061);
            Controls.Add(CoffeBox);
            Controls.Add(label1);
            Controls.Add(SubSugar);
            Controls.Add(AddSugar);
            Controls.Add(SugarLevel);
            Controls.Add(RunCoffee);
            Controls.Add(Display);
            Controls.Add(HalfCupCoffe);
            Controls.Add(FullCupCoffee);
            Controls.Add(EspressoCoffe);
            Controls.Add(CappuccinoCoffee);
            Controls.Add(BlackCoffee);
            Controls.Add(PowerButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)CoffeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PowerButton;
        private Button BlackCoffee;
        private Button CappuccinoCoffee;
        private Button EspressoCoffe;
        private Button FullCupCoffee;
        private Button HalfCupCoffe;
        private RichTextBox Display;
        private Button RunCoffee;
        private ProgressBar SugarLevel;
        private Button AddSugar;
        private Button SubSugar;
        private Label label1;
        private PictureBox CoffeBox;
    }
}
