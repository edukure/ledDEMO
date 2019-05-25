namespace ledDEMO
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
            this.components = new System.ComponentModel.Container();
            this.ledButton = new System.Windows.Forms.Button();
            this.comPortsCombobox = new System.Windows.Forms.ComboBox();
            this.arduinoConnectButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ledButton
            // 
            this.ledButton.Location = new System.Drawing.Point(110, 22);
            this.ledButton.Margin = new System.Windows.Forms.Padding(2);
            this.ledButton.Name = "ledButton";
            this.ledButton.Size = new System.Drawing.Size(122, 64);
            this.ledButton.TabIndex = 0;
            this.ledButton.Text = "LIGA LED";
            this.ledButton.UseVisualStyleBackColor = true;
            this.ledButton.Click += new System.EventHandler(this.ledButton_Click);
            // 
            // comPortsCombobox
            // 
            this.comPortsCombobox.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortsCombobox.FormattingEnabled = true;
            this.comPortsCombobox.Location = new System.Drawing.Point(100, 110);
            this.comPortsCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.comPortsCombobox.Name = "comPortsCombobox";
            this.comPortsCombobox.Size = new System.Drawing.Size(92, 29);
            this.comPortsCombobox.TabIndex = 1;
            // 
            // arduinoConnectButton
            // 
            this.arduinoConnectButton.Location = new System.Drawing.Point(195, 105);
            this.arduinoConnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.arduinoConnectButton.Name = "arduinoConnectButton";
            this.arduinoConnectButton.Size = new System.Drawing.Size(64, 34);
            this.arduinoConnectButton.TabIndex = 2;
            this.arduinoConnectButton.Text = "Conectar";
            this.arduinoConnectButton.UseVisualStyleBackColor = true;
            this.arduinoConnectButton.Click += new System.EventHandler(this.arduinoConnectButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 158);
            this.Controls.Add(this.arduinoConnectButton);
            this.Controls.Add(this.comPortsCombobox);
            this.Controls.Add(this.ledButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ledButton;
        private System.Windows.Forms.ComboBox comPortsCombobox;
        private System.Windows.Forms.Button arduinoConnectButton;
        private System.Windows.Forms.Timer timer;
    }
}

