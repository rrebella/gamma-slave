using System.Drawing;
using System.Windows.Forms;

namespace rebellagamma
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelGamma;
        private TrackBar trackBarGamma;
        private Label labelGammaValue;
        private Label labelBrightness;
        private TrackBar trackBarBrightness;
        private Label labelBrightnessValue;
        private Label labelContrast;
        private TrackBar trackBarContrast;
        private Label labelContrastValue;
        private ComboBox comboBoxMonitors;
        private Button buttonReset;
        private Panel panelGraph;
        private PictureBox pictureBox1;

        // New profile controls
        private Button buttonSaveProfile;
        private Button buttonLoadProfile;
        private TextBox textBoxProfileName;
        private ComboBox comboBoxProfiles;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelGamma = new Label();
            trackBarGamma = new TrackBar();
            labelGammaValue = new Label();
            labelBrightness = new Label();
            trackBarBrightness = new TrackBar();
            labelBrightnessValue = new Label();
            labelContrast = new Label();
            trackBarContrast = new TrackBar();
            labelContrastValue = new Label();
            comboBoxMonitors = new ComboBox();
            buttonReset = new Button();
            panelGraph = new Panel();
            label1 = new Label();
            buttonSaveProfile = new Button();
            buttonLoadProfile = new Button();
            textBoxProfileName = new TextBox();
            comboBoxProfiles = new ComboBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarGamma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarContrast).BeginInit();
            panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelGamma
            // 
            labelGamma.AutoSize = true;
            labelGamma.ForeColor = Color.White;
            labelGamma.Location = new Point(7, 9);
            labelGamma.Name = "labelGamma";
            labelGamma.Size = new Size(49, 15);
            labelGamma.TabIndex = 0;
            labelGamma.Text = "Gamma";
            // 
            // trackBarGamma
            // 
            trackBarGamma.AutoSize = false;
            trackBarGamma.BackColor = Color.Black;
            trackBarGamma.LargeChange = 10;
            trackBarGamma.Location = new Point(107, 7);
            trackBarGamma.Maximum = 888;
            trackBarGamma.Minimum = 8;
            trackBarGamma.Name = "trackBarGamma";
            trackBarGamma.Size = new Size(160, 45);
            trackBarGamma.TabIndex = 2;
            trackBarGamma.TickFrequency = 100;
            trackBarGamma.TickStyle = TickStyle.None;
            trackBarGamma.Value = 100;
            trackBarGamma.Scroll += trackBarGamma_Scroll;
            trackBarGamma.MouseDown += trackBar_MouseDown_RemoveFocus;
            // 
            // labelGammaValue
            // 
            labelGammaValue.AutoSize = true;
            labelGammaValue.ForeColor = Color.White;
            labelGammaValue.Location = new Point(77, 9);
            labelGammaValue.Name = "labelGammaValue";
            labelGammaValue.Size = new Size(28, 15);
            labelGammaValue.TabIndex = 1;
            labelGammaValue.Text = "1.00";
            labelGammaValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBrightness
            // 
            labelBrightness.AutoSize = true;
            labelBrightness.ForeColor = Color.White;
            labelBrightness.Location = new Point(7, 39);
            labelBrightness.Name = "labelBrightness";
            labelBrightness.Size = new Size(62, 15);
            labelBrightness.TabIndex = 3;
            labelBrightness.Text = "Brightness";
            // 
            // trackBarBrightness
            // 
            trackBarBrightness.BackColor = Color.Black;
            trackBarBrightness.Location = new Point(107, 37);
            trackBarBrightness.Maximum = 888;
            trackBarBrightness.Minimum = -888;
            trackBarBrightness.Name = "trackBarBrightness";
            trackBarBrightness.Size = new Size(160, 45);
            trackBarBrightness.TabIndex = 5;
            trackBarBrightness.TickStyle = TickStyle.None;
            trackBarBrightness.Scroll += trackBarBrightness_Scroll;
            trackBarBrightness.MouseDown += trackBar_MouseDown_RemoveFocus;
            // 
            // labelBrightnessValue
            // 
            labelBrightnessValue.AutoSize = true;
            labelBrightnessValue.ForeColor = Color.White;
            labelBrightnessValue.Location = new Point(77, 39);
            labelBrightnessValue.Name = "labelBrightnessValue";
            labelBrightnessValue.Size = new Size(13, 15);
            labelBrightnessValue.TabIndex = 4;
            labelBrightnessValue.Text = "0";
            labelBrightnessValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelContrast
            // 
            labelContrast.AutoSize = true;
            labelContrast.ForeColor = Color.White;
            labelContrast.Location = new Point(7, 69);
            labelContrast.Name = "labelContrast";
            labelContrast.Size = new Size(52, 15);
            labelContrast.TabIndex = 6;
            labelContrast.Text = "Contrast";
            // 
            // trackBarContrast
            // 
            trackBarContrast.BackColor = Color.Black;
            trackBarContrast.Location = new Point(107, 67);
            trackBarContrast.Maximum = 888;
            trackBarContrast.Minimum = 8;
            trackBarContrast.Name = "trackBarContrast";
            trackBarContrast.Size = new Size(160, 45);
            trackBarContrast.TabIndex = 8;
            trackBarContrast.TickFrequency = 10;
            trackBarContrast.TickStyle = TickStyle.None;
            trackBarContrast.Value = 100;
            trackBarContrast.Scroll += trackBarContrast_Scroll;
            trackBarContrast.MouseDown += trackBar_MouseDown_RemoveFocus;
            // 
            // labelContrastValue
            // 
            labelContrastValue.AutoSize = true;
            labelContrastValue.ForeColor = Color.White;
            labelContrastValue.Location = new Point(77, 69);
            labelContrastValue.Name = "labelContrastValue";
            labelContrastValue.Size = new Size(25, 15);
            labelContrastValue.TabIndex = 7;
            labelContrastValue.Text = "100";
            labelContrastValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxMonitors
            // 
            comboBoxMonitors.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonitors.Location = new Point(275, 114);
            comboBoxMonitors.Name = "comboBoxMonitors";
            comboBoxMonitors.Size = new Size(100, 23);
            comboBoxMonitors.TabIndex = 9;
            comboBoxMonitors.SelectedIndexChanged += comboBoxMonitors_SelectedIndexChanged;
            // 
            // buttonReset
            // 
            buttonReset.ForeColor = SystemColors.ControlLightLight;
            buttonReset.Location = new Point(275, 142);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(100, 43);
            buttonReset.TabIndex = 10;
            buttonReset.Text = "⛧ Reset ⛧";
            buttonReset.Click += buttonReset_Click;
            // 
            // panelGraph
            // 
            panelGraph.BackColor = Color.Black;
            panelGraph.Controls.Add(label1);
            panelGraph.Location = new Point(275, 7);
            panelGraph.Name = "panelGraph";
            panelGraph.Size = new Size(100, 100);
            panelGraph.TabIndex = 11;
            panelGraph.Paint += panelGraph_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 6F);
            label1.ForeColor = Color.FromArgb(8, 8, 8);
            label1.Location = new Point(70, 87);
            label1.Name = "label1";
            label1.Size = new Size(29, 11);
            label1.TabIndex = 30;
            label1.Text = "rebella";
            // 
            // buttonSaveProfile
            // 
            buttonSaveProfile.Font = new Font("Segoe UI", 9F);
            buttonSaveProfile.ForeColor = SystemColors.ControlLightLight;
            buttonSaveProfile.Location = new Point(7, 98);
            buttonSaveProfile.Name = "buttonSaveProfile";
            buttonSaveProfile.Size = new Size(75, 27);
            buttonSaveProfile.TabIndex = 25;
            buttonSaveProfile.Text = "Save";
            buttonSaveProfile.Click += buttonSaveProfile_Click;
            // 
            // buttonLoadProfile
            // 
            buttonLoadProfile.Font = new Font("Segoe UI", 9F);
            buttonLoadProfile.ForeColor = SystemColors.ControlLightLight;
            buttonLoadProfile.Location = new Point(7, 128);
            buttonLoadProfile.Name = "buttonLoadProfile";
            buttonLoadProfile.Size = new Size(75, 27);
            buttonLoadProfile.TabIndex = 26;
            buttonLoadProfile.Text = "Load";
            buttonLoadProfile.Click += buttonLoadProfile_Click;
            // 
            // textBoxProfileName
            // 
            textBoxProfileName.Location = new Point(88, 100);
            textBoxProfileName.Name = "textBoxProfileName";
            textBoxProfileName.Size = new Size(100, 23);
            textBoxProfileName.TabIndex = 27;
            // 
            // comboBoxProfiles
            // 
            comboBoxProfiles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProfiles.FormattingEnabled = true;
            comboBoxProfiles.Location = new Point(88, 131);
            comboBoxProfiles.Name = "comboBoxProfiles";
            comboBoxProfiles.Size = new Size(100, 23);
            comboBoxProfiles.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = gamma2.Properties.Resources.reb;
            pictureBox1.Location = new Point(199, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 161);
            label2.Name = "label2";
            label2.Size = new Size(245, 11);
            label2.TabIndex = 30;
            label2.Text = "gamma slave gamma slave gamma slave gamma slave gamma slave ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 6F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 173);
            label3.Name = "label3";
            label3.Size = new Size(245, 11);
            label3.TabIndex = 31;
            label3.Text = "gamma slave gamma slave gamma slave gamma slave gamma slave ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(252, 161);
            label4.Name = "label4";
            label4.Size = new Size(24, 25);
            label4.TabIndex = 32;
            label4.Text = "♰";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(383, 191);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxProfileName);
            Controls.Add(trackBarContrast);
            Controls.Add(trackBarBrightness);
            Controls.Add(panelGraph);
            Controls.Add(buttonReset);
            Controls.Add(comboBoxMonitors);
            Controls.Add(comboBoxProfiles);
            Controls.Add(buttonLoadProfile);
            Controls.Add(buttonSaveProfile);
            Controls.Add(labelGamma);
            Controls.Add(labelGammaValue);
            Controls.Add(trackBarGamma);
            Controls.Add(labelBrightness);
            Controls.Add(labelBrightnessValue);
            Controls.Add(labelContrast);
            Controls.Add(labelContrastValue);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "gamma slave";
            ((System.ComponentModel.ISupportInitialize)trackBarGamma).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarContrast).EndInit();
            panelGraph.ResumeLayout(false);
            panelGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
