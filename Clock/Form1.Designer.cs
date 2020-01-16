namespace Clock
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.pinButton = new System.Windows.Forms.Button();
            this.biggerButton = new System.Windows.Forms.Button();
            this.smallerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.OnTick);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(370, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.OnClickClose);
            this.closeButton.MouseEnter += new System.EventHandler(this.OnMouseEnterClose);
            this.closeButton.MouseLeave += new System.EventHandler(this.OnMouseLeaveClose);
            // 
            // pinButton
            // 
            this.pinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pinButton.FlatAppearance.BorderSize = 0;
            this.pinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pinButton.ForeColor = System.Drawing.Color.Blue;
            this.pinButton.Location = new System.Drawing.Point(335, 0);
            this.pinButton.Name = "pinButton";
            this.pinButton.Size = new System.Drawing.Size(30, 30);
            this.pinButton.TabIndex = 1;
            this.pinButton.UseVisualStyleBackColor = false;
            this.pinButton.Visible = false;
            this.pinButton.Click += new System.EventHandler(this.OnClickPin);
            this.pinButton.MouseEnter += new System.EventHandler(this.OnMouseEnterPin);
            this.pinButton.MouseLeave += new System.EventHandler(this.OnMouseLeavePin);
            // 
            // biggerButton
            // 
            this.biggerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.biggerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.biggerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.biggerButton.FlatAppearance.BorderSize = 0;
            this.biggerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.biggerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.biggerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.biggerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.biggerButton.ForeColor = System.Drawing.Color.Green;
            this.biggerButton.Location = new System.Drawing.Point(370, 35);
            this.biggerButton.Name = "biggerButton";
            this.biggerButton.Size = new System.Drawing.Size(30, 30);
            this.biggerButton.TabIndex = 3;
            this.biggerButton.UseVisualStyleBackColor = false;
            this.biggerButton.Visible = false;
            this.biggerButton.Click += new System.EventHandler(this.OnClickBigger);
            this.biggerButton.MouseEnter += new System.EventHandler(this.OnMouseEnterBigger);
            this.biggerButton.MouseLeave += new System.EventHandler(this.OnMouseLeaveBigger);
            // 
            // smallerButton
            // 
            this.smallerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.smallerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.smallerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.smallerButton.FlatAppearance.BorderSize = 0;
            this.smallerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.smallerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.smallerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smallerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.smallerButton.ForeColor = System.Drawing.Color.Green;
            this.smallerButton.Location = new System.Drawing.Point(335, 35);
            this.smallerButton.Name = "smallerButton";
            this.smallerButton.Size = new System.Drawing.Size(30, 30);
            this.smallerButton.TabIndex = 4;
            this.smallerButton.UseVisualStyleBackColor = false;
            this.smallerButton.Visible = false;
            this.smallerButton.Click += new System.EventHandler(this.OnClickSmaller);
            this.smallerButton.MouseEnter += new System.EventHandler(this.OnMouseEnterSmaller);
            this.smallerButton.MouseLeave += new System.EventHandler(this.OnMouseLeaveSmaller);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.smallerButton);
            this.Controls.Add(this.biggerButton);
            this.Controls.Add(this.pinButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Clock";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.OnLoad);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownMove);
            this.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button pinButton;
        private System.Windows.Forms.Button biggerButton;
        private System.Windows.Forms.Button smallerButton;
    }
}

