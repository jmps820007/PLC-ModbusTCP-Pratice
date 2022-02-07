
namespace PLC_ModbusTCP_Pratice
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_IP = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.DI1 = new System.Windows.Forms.PictureBox();
            this.DI3 = new System.Windows.Forms.PictureBox();
            this.DI2 = new System.Windows.Forms.PictureBox();
            this.DI4 = new System.Windows.Forms.PictureBox();
            this.DI5 = new System.Windows.Forms.PictureBox();
            this.DI0 = new System.Windows.Forms.PictureBox();
            this.DO0 = new System.Windows.Forms.PictureBox();
            this.DO1 = new System.Windows.Forms.PictureBox();
            this.DO2 = new System.Windows.Forms.PictureBox();
            this.DO3 = new System.Windows.Forms.PictureBox();
            this.DO4 = new System.Windows.Forms.PictureBox();
            this.DO5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP位置 :";
            // 
            // tbx_IP
            // 
            this.tbx_IP.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_IP.Location = new System.Drawing.Point(107, 8);
            this.tbx_IP.Name = "tbx_IP";
            this.tbx_IP.Size = new System.Drawing.Size(122, 33);
            this.tbx_IP.TabIndex = 1;
            this.tbx_IP.Text = "192.168.0.44";
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Start.Location = new System.Drawing.Point(259, 13);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(84, 28);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Stop.Location = new System.Drawing.Point(366, 13);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(84, 28);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // DI1
            // 
            this.DI1.BackColor = System.Drawing.Color.Green;
            this.DI1.Location = new System.Drawing.Point(123, 80);
            this.DI1.Name = "DI1";
            this.DI1.Size = new System.Drawing.Size(47, 45);
            this.DI1.TabIndex = 5;
            this.DI1.TabStop = false;
            // 
            // DI3
            // 
            this.DI3.BackColor = System.Drawing.Color.Green;
            this.DI3.Location = new System.Drawing.Point(245, 80);
            this.DI3.Name = "DI3";
            this.DI3.Size = new System.Drawing.Size(47, 45);
            this.DI3.TabIndex = 6;
            this.DI3.TabStop = false;
            // 
            // DI2
            // 
            this.DI2.BackColor = System.Drawing.Color.Green;
            this.DI2.Location = new System.Drawing.Point(182, 80);
            this.DI2.Name = "DI2";
            this.DI2.Size = new System.Drawing.Size(47, 45);
            this.DI2.TabIndex = 7;
            this.DI2.TabStop = false;
            // 
            // DI4
            // 
            this.DI4.BackColor = System.Drawing.Color.Green;
            this.DI4.Location = new System.Drawing.Point(308, 80);
            this.DI4.Name = "DI4";
            this.DI4.Size = new System.Drawing.Size(47, 45);
            this.DI4.TabIndex = 8;
            this.DI4.TabStop = false;
            // 
            // DI5
            // 
            this.DI5.BackColor = System.Drawing.Color.Green;
            this.DI5.Location = new System.Drawing.Point(375, 80);
            this.DI5.Name = "DI5";
            this.DI5.Size = new System.Drawing.Size(47, 45);
            this.DI5.TabIndex = 9;
            this.DI5.TabStop = false;
            // 
            // DI0
            // 
            this.DI0.BackColor = System.Drawing.Color.Green;
            this.DI0.Location = new System.Drawing.Point(59, 80);
            this.DI0.Name = "DI0";
            this.DI0.Size = new System.Drawing.Size(47, 45);
            this.DI0.TabIndex = 4;
            this.DI0.TabStop = false;
            // 
            // DO0
            // 
            this.DO0.BackColor = System.Drawing.Color.Maroon;
            this.DO0.Location = new System.Drawing.Point(59, 166);
            this.DO0.Name = "DO0";
            this.DO0.Size = new System.Drawing.Size(47, 45);
            this.DO0.TabIndex = 10;
            this.DO0.TabStop = false;
            this.DO0.Tag = "0";
            this.DO0.Click += new System.EventHandler(this.DO_Click);
            // 
            // DO1
            // 
            this.DO1.BackColor = System.Drawing.Color.Maroon;
            this.DO1.Location = new System.Drawing.Point(123, 166);
            this.DO1.Name = "DO1";
            this.DO1.Size = new System.Drawing.Size(47, 45);
            this.DO1.TabIndex = 11;
            this.DO1.TabStop = false;
            this.DO1.Tag = "1";
            this.DO1.Click += new System.EventHandler(this.DO_Click);
            // 
            // DO2
            // 
            this.DO2.BackColor = System.Drawing.Color.Maroon;
            this.DO2.Location = new System.Drawing.Point(182, 166);
            this.DO2.Name = "DO2";
            this.DO2.Size = new System.Drawing.Size(47, 45);
            this.DO2.TabIndex = 12;
            this.DO2.TabStop = false;
            this.DO2.Tag = "2";
            this.DO2.Click += new System.EventHandler(this.DO_Click);
            // 
            // DO3
            // 
            this.DO3.BackColor = System.Drawing.Color.Maroon;
            this.DO3.Location = new System.Drawing.Point(245, 166);
            this.DO3.Name = "DO3";
            this.DO3.Size = new System.Drawing.Size(47, 45);
            this.DO3.TabIndex = 13;
            this.DO3.TabStop = false;
            this.DO3.Tag = "3";
            this.DO3.Click += new System.EventHandler(this.DO_Click);
            // 
            // DO4
            // 
            this.DO4.BackColor = System.Drawing.Color.Maroon;
            this.DO4.Location = new System.Drawing.Point(308, 166);
            this.DO4.Name = "DO4";
            this.DO4.Size = new System.Drawing.Size(47, 45);
            this.DO4.TabIndex = 14;
            this.DO4.TabStop = false;
            this.DO4.Tag = "4";
            this.DO4.Click += new System.EventHandler(this.DO_Click);
            // 
            // DO5
            // 
            this.DO5.BackColor = System.Drawing.Color.Maroon;
            this.DO5.Location = new System.Drawing.Point(375, 166);
            this.DO5.Name = "DO5";
            this.DO5.Size = new System.Drawing.Size(47, 45);
            this.DO5.TabIndex = 15;
            this.DO5.TabStop = false;
            this.DO5.Tag = "5";
            this.DO5.Click += new System.EventHandler(this.DO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(15, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Y";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(552, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DO5);
            this.Controls.Add(this.DO4);
            this.Controls.Add(this.DO3);
            this.Controls.Add(this.DO2);
            this.Controls.Add(this.DO1);
            this.Controls.Add(this.DO0);
            this.Controls.Add(this.DI5);
            this.Controls.Add(this.DI4);
            this.Controls.Add(this.DI2);
            this.Controls.Add(this.DI3);
            this.Controls.Add(this.DI1);
            this.Controls.Add(this.DI0);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.tbx_IP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DI0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DO5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_IP;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.PictureBox DI1;
        private System.Windows.Forms.PictureBox DI3;
        private System.Windows.Forms.PictureBox DI2;
        private System.Windows.Forms.PictureBox DI4;
        private System.Windows.Forms.PictureBox DI5;
        private System.Windows.Forms.PictureBox DI0;
        private System.Windows.Forms.PictureBox DO0;
        private System.Windows.Forms.PictureBox DO1;
        private System.Windows.Forms.PictureBox DO2;
        private System.Windows.Forms.PictureBox DO3;
        private System.Windows.Forms.PictureBox DO4;
        private System.Windows.Forms.PictureBox DO5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

