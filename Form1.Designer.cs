
namespace Track_Test_Creator
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
            this.cupLabel1 = new System.Windows.Forms.Label();
            this.cupInput = new System.Windows.Forms.NumericUpDown();
            this.build = new System.Windows.Forms.Button();
            this.RightArrow = new System.Windows.Forms.Button();
            this.LeftArrow = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Track4BMG = new System.Windows.Forms.TextBox();
            this.Track4Name = new System.Windows.Forms.TextBox();
            this.Track3BMG = new System.Windows.Forms.TextBox();
            this.Track3Name = new System.Windows.Forms.TextBox();
            this.Track2BMG = new System.Windows.Forms.TextBox();
            this.Track2Name = new System.Windows.Forms.TextBox();
            this.Track1BMG = new System.Windows.Forms.TextBox();
            this.Track1Name = new System.Windows.Forms.TextBox();
            this.cupLabel = new System.Windows.Forms.Label();
            this.Track1Slot = new System.Windows.Forms.NumericUpDown();
            this.Track2Slot = new System.Windows.Forms.NumericUpDown();
            this.Track3Slot = new System.Windows.Forms.NumericUpDown();
            this.Track4Slot = new System.Windows.Forms.NumericUpDown();
            this.Track1Music = new System.Windows.Forms.NumericUpDown();
            this.Track2Music = new System.Windows.Forms.NumericUpDown();
            this.Track3Music = new System.Windows.Forms.NumericUpDown();
            this.Track4Music = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Music4Label = new System.Windows.Forms.Label();
            this.Slot4Label = new System.Windows.Forms.Label();
            this.Music3Label = new System.Windows.Forms.Label();
            this.Slot3Label = new System.Windows.Forms.Label();
            this.Music2Label = new System.Windows.Forms.Label();
            this.Slot2Label = new System.Windows.Forms.Label();
            this.Music1Label = new System.Windows.Forms.Label();
            this.Slot1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cupInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track1Slot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track2Slot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track3Slot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track4Slot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track1Music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track2Music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track3Music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track4Music)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cupLabel1
            // 
            this.cupLabel1.AutoSize = true;
            this.cupLabel1.Location = new System.Drawing.Point(42, 365);
            this.cupLabel1.Name = "cupLabel1";
            this.cupLabel1.Size = new System.Drawing.Size(57, 13);
            this.cupLabel1.TabIndex = 0;
            this.cupLabel1.Text = "Cup Count";
            this.cupLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cupInput
            // 
            this.cupInput.Location = new System.Drawing.Point(43, 381);
            this.cupInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.cupInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cupInput.Name = "cupInput";
            this.cupInput.Size = new System.Drawing.Size(54, 20);
            this.cupInput.TabIndex = 1;
            this.cupInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cupInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cupInput.ValueChanged += new System.EventHandler(this.cupInput_ValueChanged);
            // 
            // build
            // 
            this.build.Location = new System.Drawing.Point(426, 378);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(75, 23);
            this.build.TabIndex = 110;
            this.build.Text = "Build";
            this.build.UseVisualStyleBackColor = true;
            this.build.Click += new System.EventHandler(this.build_Click);
            // 
            // RightArrow
            // 
            this.RightArrow.Location = new System.Drawing.Point(472, 12);
            this.RightArrow.Name = "RightArrow";
            this.RightArrow.Size = new System.Drawing.Size(29, 350);
            this.RightArrow.TabIndex = 111;
            this.RightArrow.Text = ">";
            this.RightArrow.UseVisualStyleBackColor = true;
            this.RightArrow.Click += new System.EventHandler(this.RightArrow_Click);
            // 
            // LeftArrow
            // 
            this.LeftArrow.Location = new System.Drawing.Point(8, 12);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(29, 350);
            this.LeftArrow.TabIndex = 112;
            this.LeftArrow.Text = "<";
            this.LeftArrow.UseVisualStyleBackColor = true;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(345, 378);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 113;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(264, 378);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 114;
            this.import.Text = "Import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(6, 320);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(64, 13);
            this.label50.TabIndex = 57;
            this.label50.Tag = "cup1";
            this.label50.Text = "BMG/Music";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 295);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 56;
            this.label16.Tag = "cup1";
            this.label16.Text = "File/Slot";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 236);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 55;
            this.label15.Tag = "cup1";
            this.label15.Text = "BMG/Music";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 54;
            this.label14.Tag = "cup1";
            this.label14.Text = "File/Slot";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 53;
            this.label13.Tag = "cup1";
            this.label13.Text = "BMG/Music";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 52;
            this.label12.Tag = "cup1";
            this.label12.Text = "File/Slot";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 51;
            this.label11.Tag = "cup1";
            this.label11.Text = "BMG/Music";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 50;
            this.label10.Tag = "cup1";
            this.label10.Text = "File/Slot";
            // 
            // Track4BMG
            // 
            this.Track4BMG.Location = new System.Drawing.Point(76, 318);
            this.Track4BMG.Name = "Track4BMG";
            this.Track4BMG.Size = new System.Drawing.Size(171, 20);
            this.Track4BMG.TabIndex = 9;
            this.Track4BMG.Tag = "cup1";
            // 
            // Track4Name
            // 
            this.Track4Name.Location = new System.Drawing.Point(76, 292);
            this.Track4Name.Name = "Track4Name";
            this.Track4Name.Size = new System.Drawing.Size(171, 20);
            this.Track4Name.TabIndex = 8;
            this.Track4Name.Tag = "cup1";
            // 
            // Track3BMG
            // 
            this.Track3BMG.Location = new System.Drawing.Point(76, 233);
            this.Track3BMG.Name = "Track3BMG";
            this.Track3BMG.Size = new System.Drawing.Size(171, 20);
            this.Track3BMG.TabIndex = 7;
            this.Track3BMG.Tag = "cup1";
            // 
            // Track3Name
            // 
            this.Track3Name.Location = new System.Drawing.Point(76, 207);
            this.Track3Name.Name = "Track3Name";
            this.Track3Name.Size = new System.Drawing.Size(171, 20);
            this.Track3Name.TabIndex = 6;
            this.Track3Name.Tag = "cup1";
            // 
            // Track2BMG
            // 
            this.Track2BMG.Location = new System.Drawing.Point(76, 144);
            this.Track2BMG.Name = "Track2BMG";
            this.Track2BMG.Size = new System.Drawing.Size(171, 20);
            this.Track2BMG.TabIndex = 5;
            this.Track2BMG.Tag = "cup1";
            // 
            // Track2Name
            // 
            this.Track2Name.Location = new System.Drawing.Point(76, 118);
            this.Track2Name.Name = "Track2Name";
            this.Track2Name.Size = new System.Drawing.Size(171, 20);
            this.Track2Name.TabIndex = 4;
            this.Track2Name.Tag = "cup1";
            // 
            // Track1BMG
            // 
            this.Track1BMG.Location = new System.Drawing.Point(76, 55);
            this.Track1BMG.Name = "Track1BMG";
            this.Track1BMG.Size = new System.Drawing.Size(171, 20);
            this.Track1BMG.TabIndex = 3;
            this.Track1BMG.Tag = "cup1";
            // 
            // Track1Name
            // 
            this.Track1Name.Location = new System.Drawing.Point(76, 29);
            this.Track1Name.Name = "Track1Name";
            this.Track1Name.Size = new System.Drawing.Size(171, 20);
            this.Track1Name.TabIndex = 2;
            this.Track1Name.Tag = "cup1";
            // 
            // cupLabel
            // 
            this.cupLabel.AutoSize = true;
            this.cupLabel.Location = new System.Drawing.Point(143, 8);
            this.cupLabel.Name = "cupLabel";
            this.cupLabel.Size = new System.Drawing.Size(35, 13);
            this.cupLabel.TabIndex = 98;
            this.cupLabel.Tag = "cup1";
            this.cupLabel.Text = "Cup 1";
            // 
            // Track1Slot
            // 
            this.Track1Slot.Location = new System.Drawing.Point(253, 29);
            this.Track1Slot.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.Track1Slot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track1Slot.Name = "Track1Slot";
            this.Track1Slot.Size = new System.Drawing.Size(34, 20);
            this.Track1Slot.TabIndex = 99;
            this.Track1Slot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track1Slot.ValueChanged += new System.EventHandler(this.Track1Slot_ValueChanged);
            // 
            // Track2Slot
            // 
            this.Track2Slot.Location = new System.Drawing.Point(252, 118);
            this.Track2Slot.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.Track2Slot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track2Slot.Name = "Track2Slot";
            this.Track2Slot.Size = new System.Drawing.Size(34, 20);
            this.Track2Slot.TabIndex = 100;
            this.Track2Slot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track2Slot.ValueChanged += new System.EventHandler(this.Track2Slot_ValueChanged);
            // 
            // Track3Slot
            // 
            this.Track3Slot.Location = new System.Drawing.Point(253, 207);
            this.Track3Slot.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.Track3Slot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track3Slot.Name = "Track3Slot";
            this.Track3Slot.Size = new System.Drawing.Size(34, 20);
            this.Track3Slot.TabIndex = 101;
            this.Track3Slot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track3Slot.ValueChanged += new System.EventHandler(this.Track3Slot_ValueChanged);
            // 
            // Track4Slot
            // 
            this.Track4Slot.Location = new System.Drawing.Point(253, 292);
            this.Track4Slot.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.Track4Slot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track4Slot.Name = "Track4Slot";
            this.Track4Slot.Size = new System.Drawing.Size(34, 20);
            this.Track4Slot.TabIndex = 102;
            this.Track4Slot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track4Slot.ValueChanged += new System.EventHandler(this.Track4Slot_ValueChanged);
            // 
            // Track1Music
            // 
            this.Track1Music.Location = new System.Drawing.Point(253, 55);
            this.Track1Music.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.Track1Music.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track1Music.Name = "Track1Music";
            this.Track1Music.Size = new System.Drawing.Size(34, 20);
            this.Track1Music.TabIndex = 103;
            this.Track1Music.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track1Music.ValueChanged += new System.EventHandler(this.Track1Music_ValueChanged);
            // 
            // Track2Music
            // 
            this.Track2Music.Location = new System.Drawing.Point(252, 144);
            this.Track2Music.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.Track2Music.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track2Music.Name = "Track2Music";
            this.Track2Music.Size = new System.Drawing.Size(34, 20);
            this.Track2Music.TabIndex = 104;
            this.Track2Music.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track2Music.ValueChanged += new System.EventHandler(this.Track2Music_ValueChanged);
            // 
            // Track3Music
            // 
            this.Track3Music.Location = new System.Drawing.Point(253, 233);
            this.Track3Music.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.Track3Music.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track3Music.Name = "Track3Music";
            this.Track3Music.Size = new System.Drawing.Size(34, 20);
            this.Track3Music.TabIndex = 105;
            this.Track3Music.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track3Music.ValueChanged += new System.EventHandler(this.Track3Music_ValueChanged);
            // 
            // Track4Music
            // 
            this.Track4Music.Location = new System.Drawing.Point(253, 318);
            this.Track4Music.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.Track4Music.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track4Music.Name = "Track4Music";
            this.Track4Music.Size = new System.Drawing.Size(34, 20);
            this.Track4Music.TabIndex = 106;
            this.Track4Music.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track4Music.ValueChanged += new System.EventHandler(this.Track4Music_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Music4Label);
            this.panel1.Controls.Add(this.Slot4Label);
            this.panel1.Controls.Add(this.Music3Label);
            this.panel1.Controls.Add(this.Slot3Label);
            this.panel1.Controls.Add(this.Music2Label);
            this.panel1.Controls.Add(this.Slot2Label);
            this.panel1.Controls.Add(this.Music1Label);
            this.panel1.Controls.Add(this.Slot1Label);
            this.panel1.Controls.Add(this.Track4Music);
            this.panel1.Controls.Add(this.Track3Music);
            this.panel1.Controls.Add(this.Track2Music);
            this.panel1.Controls.Add(this.Track1Music);
            this.panel1.Controls.Add(this.Track4Slot);
            this.panel1.Controls.Add(this.Track3Slot);
            this.panel1.Controls.Add(this.Track2Slot);
            this.panel1.Controls.Add(this.Track1Slot);
            this.panel1.Controls.Add(this.cupLabel);
            this.panel1.Controls.Add(this.Track1Name);
            this.panel1.Controls.Add(this.Track1BMG);
            this.panel1.Controls.Add(this.Track2Name);
            this.panel1.Controls.Add(this.Track2BMG);
            this.panel1.Controls.Add(this.Track3Name);
            this.panel1.Controls.Add(this.Track3BMG);
            this.panel1.Controls.Add(this.Track4Name);
            this.panel1.Controls.Add(this.Track4BMG);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(43, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 350);
            this.panel1.TabIndex = 105;
            this.panel1.Tag = "cup1";
            // 
            // Music4Label
            // 
            this.Music4Label.AutoSize = true;
            this.Music4Label.Location = new System.Drawing.Point(296, 321);
            this.Music4Label.Name = "Music4Label";
            this.Music4Label.Size = new System.Drawing.Size(61, 13);
            this.Music4Label.TabIndex = 114;
            this.Music4Label.Text = "Luigi Circuit";
            // 
            // Slot4Label
            // 
            this.Slot4Label.AutoSize = true;
            this.Slot4Label.Location = new System.Drawing.Point(296, 295);
            this.Slot4Label.Name = "Slot4Label";
            this.Slot4Label.Size = new System.Drawing.Size(61, 13);
            this.Slot4Label.TabIndex = 113;
            this.Slot4Label.Text = "Luigi Circuit";
            // 
            // Music3Label
            // 
            this.Music3Label.AutoSize = true;
            this.Music3Label.Location = new System.Drawing.Point(296, 236);
            this.Music3Label.Name = "Music3Label";
            this.Music3Label.Size = new System.Drawing.Size(61, 13);
            this.Music3Label.TabIndex = 112;
            this.Music3Label.Text = "Luigi Circuit";
            // 
            // Slot3Label
            // 
            this.Slot3Label.AutoSize = true;
            this.Slot3Label.Location = new System.Drawing.Point(296, 210);
            this.Slot3Label.Name = "Slot3Label";
            this.Slot3Label.Size = new System.Drawing.Size(61, 13);
            this.Slot3Label.TabIndex = 111;
            this.Slot3Label.Text = "Luigi Circuit";
            // 
            // Music2Label
            // 
            this.Music2Label.AutoSize = true;
            this.Music2Label.Location = new System.Drawing.Point(296, 146);
            this.Music2Label.Name = "Music2Label";
            this.Music2Label.Size = new System.Drawing.Size(61, 13);
            this.Music2Label.TabIndex = 110;
            this.Music2Label.Text = "Luigi Circuit";
            // 
            // Slot2Label
            // 
            this.Slot2Label.AutoSize = true;
            this.Slot2Label.Location = new System.Drawing.Point(296, 121);
            this.Slot2Label.Name = "Slot2Label";
            this.Slot2Label.Size = new System.Drawing.Size(61, 13);
            this.Slot2Label.TabIndex = 109;
            this.Slot2Label.Text = "Luigi Circuit";
            // 
            // Music1Label
            // 
            this.Music1Label.AutoSize = true;
            this.Music1Label.Location = new System.Drawing.Point(297, 58);
            this.Music1Label.Name = "Music1Label";
            this.Music1Label.Size = new System.Drawing.Size(61, 13);
            this.Music1Label.TabIndex = 108;
            this.Music1Label.Text = "Luigi Circuit";
            // 
            // Slot1Label
            // 
            this.Slot1Label.AutoSize = true;
            this.Slot1Label.Location = new System.Drawing.Point(297, 32);
            this.Slot1Label.Name = "Slot1Label";
            this.Slot1Label.Size = new System.Drawing.Size(61, 13);
            this.Slot1Label.TabIndex = 107;
            this.Slot1Label.Text = "Luigi Circuit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 412);
            this.Controls.Add(this.import);
            this.Controls.Add(this.export);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.RightArrow);
            this.Controls.Add(this.build);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cupInput);
            this.Controls.Add(this.cupLabel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Track Selection";
            ((System.ComponentModel.ISupportInitialize)(this.cupInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track1Slot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track2Slot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track3Slot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track4Slot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track1Music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track2Music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track3Music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track4Music)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cupLabel1;
        private System.Windows.Forms.NumericUpDown cupInput;
        private System.Windows.Forms.Button build;
        private System.Windows.Forms.Button RightArrow;
        private System.Windows.Forms.Button LeftArrow;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Track4BMG;
        private System.Windows.Forms.TextBox Track4Name;
        private System.Windows.Forms.TextBox Track3BMG;
        private System.Windows.Forms.TextBox Track3Name;
        private System.Windows.Forms.TextBox Track2BMG;
        private System.Windows.Forms.TextBox Track2Name;
        private System.Windows.Forms.TextBox Track1BMG;
        private System.Windows.Forms.TextBox Track1Name;
        private System.Windows.Forms.Label cupLabel;
        private System.Windows.Forms.NumericUpDown Track1Slot;
        private System.Windows.Forms.NumericUpDown Track2Slot;
        private System.Windows.Forms.NumericUpDown Track3Slot;
        private System.Windows.Forms.NumericUpDown Track4Slot;
        private System.Windows.Forms.NumericUpDown Track1Music;
        private System.Windows.Forms.NumericUpDown Track2Music;
        private System.Windows.Forms.NumericUpDown Track3Music;
        private System.Windows.Forms.NumericUpDown Track4Music;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Music4Label;
        private System.Windows.Forms.Label Slot4Label;
        private System.Windows.Forms.Label Music3Label;
        private System.Windows.Forms.Label Slot3Label;
        private System.Windows.Forms.Label Music2Label;
        private System.Windows.Forms.Label Slot2Label;
        private System.Windows.Forms.Label Music1Label;
        private System.Windows.Forms.Label Slot1Label;
    }
}

