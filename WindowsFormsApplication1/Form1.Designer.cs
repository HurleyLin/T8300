namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonUPOLOAD = new System.Windows.Forms.Button();
            this.textBoxSn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTips = new System.Windows.Forms.Label();
            this.buttonTEMP = new System.Windows.Forms.Button();
            this.buttonLIGHT = new System.Windows.Forms.Button();
            this.buttonTX_SW = new System.Windows.Forms.Button();
            this.buttonRX_SW = new System.Windows.Forms.Button();
            this.buttonRX_MIC_SPK = new System.Windows.Forms.Button();
            this.buttonRX_SN = new System.Windows.Forms.Button();
            this.buttonTX_SN = new System.Windows.Forms.Button();
            this.buttonSD_CARD = new System.Windows.Forms.Button();
            this.buttonTX_MIC_SPK = new System.Windows.Forms.Button();
            this.buttonRF = new System.Windows.Forms.Button();
            this.buttonVOL_UP = new System.Windows.Forms.Button();
            this.buttonPOWER = new System.Windows.Forms.Button();
            this.buttonRIGHT = new System.Windows.Forms.Button();
            this.buttonLEFT = new System.Windows.Forms.Button();
            this.buttonTALK = new System.Windows.Forms.Button();
            this.buttonDOWN = new System.Windows.Forms.Button();
            this.buttonENTER = new System.Windows.Forms.Button();
            this.buttonUP = new System.Windows.Forms.Button();
            this.buttonMENU = new System.Windows.Forms.Button();
            this.buttonVOL_DOWN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUPOLOAD
            // 
            this.buttonUPOLOAD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUPOLOAD.Location = new System.Drawing.Point(384, 536);
            this.buttonUPOLOAD.Name = "buttonUPOLOAD";
            this.buttonUPOLOAD.Size = new System.Drawing.Size(100, 40);
            this.buttonUPOLOAD.TabIndex = 0;
            this.buttonUPOLOAD.Text = "上传";
            this.buttonUPOLOAD.UseVisualStyleBackColor = true;
            this.buttonUPOLOAD.Click += new System.EventHandler(this.buttonUPOLOAD_Click);
            // 
            // textBoxSn
            // 
            this.textBoxSn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSn.Location = new System.Drawing.Point(374, 42);
            this.textBoxSn.Name = "textBoxSn";
            this.textBoxSn.Size = new System.Drawing.Size(198, 23);
            this.textBoxSn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(316, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "SN：";
            // 
            // labelTips
            // 
            this.labelTips.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTips.Location = new System.Drawing.Point(317, 429);
            this.labelTips.Name = "labelTips";
            this.labelTips.Size = new System.Drawing.Size(267, 81);
            this.labelTips.TabIndex = 15;
            // 
            // buttonTEMP
            // 
            this.buttonTEMP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTEMP.Location = new System.Drawing.Point(47, 105);
            this.buttonTEMP.Name = "buttonTEMP";
            this.buttonTEMP.Size = new System.Drawing.Size(100, 40);
            this.buttonTEMP.TabIndex = 16;
            this.buttonTEMP.Text = "TEMP";
            this.buttonTEMP.UseVisualStyleBackColor = true;
            this.buttonTEMP.Click += new System.EventHandler(this.buttonTEMP_Click);
            // 
            // buttonLIGHT
            // 
            this.buttonLIGHT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLIGHT.Location = new System.Drawing.Point(47, 151);
            this.buttonLIGHT.Name = "buttonLIGHT";
            this.buttonLIGHT.Size = new System.Drawing.Size(100, 40);
            this.buttonLIGHT.TabIndex = 17;
            this.buttonLIGHT.Text = "LIGHT";
            this.buttonLIGHT.UseVisualStyleBackColor = true;
            this.buttonLIGHT.Click += new System.EventHandler(this.buttonLIGHT_Click);
            // 
            // buttonTX_SW
            // 
            this.buttonTX_SW.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTX_SW.Location = new System.Drawing.Point(47, 197);
            this.buttonTX_SW.Name = "buttonTX_SW";
            this.buttonTX_SW.Size = new System.Drawing.Size(100, 40);
            this.buttonTX_SW.TabIndex = 18;
            this.buttonTX_SW.Text = "TX SW";
            this.buttonTX_SW.UseVisualStyleBackColor = true;
            this.buttonTX_SW.Click += new System.EventHandler(this.buttonTX_SW_Click);
            // 
            // buttonRX_SW
            // 
            this.buttonRX_SW.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRX_SW.Location = new System.Drawing.Point(47, 243);
            this.buttonRX_SW.Name = "buttonRX_SW";
            this.buttonRX_SW.Size = new System.Drawing.Size(100, 40);
            this.buttonRX_SW.TabIndex = 19;
            this.buttonRX_SW.Text = "RX SW";
            this.buttonRX_SW.UseVisualStyleBackColor = true;
            this.buttonRX_SW.Click += new System.EventHandler(this.buttonRX_SW_Click);
            // 
            // buttonRX_MIC_SPK
            // 
            this.buttonRX_MIC_SPK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRX_MIC_SPK.Location = new System.Drawing.Point(47, 429);
            this.buttonRX_MIC_SPK.Name = "buttonRX_MIC_SPK";
            this.buttonRX_MIC_SPK.Size = new System.Drawing.Size(200, 40);
            this.buttonRX_MIC_SPK.TabIndex = 20;
            this.buttonRX_MIC_SPK.Text = "RX MIC SPK TESING";
            this.buttonRX_MIC_SPK.UseVisualStyleBackColor = true;
            this.buttonRX_MIC_SPK.Click += new System.EventHandler(this.buttonRX_MIC_SPK_Click);
            // 
            // buttonRX_SN
            // 
            this.buttonRX_SN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRX_SN.Location = new System.Drawing.Point(47, 383);
            this.buttonRX_SN.Name = "buttonRX_SN";
            this.buttonRX_SN.Size = new System.Drawing.Size(100, 40);
            this.buttonRX_SN.TabIndex = 21;
            this.buttonRX_SN.Text = "RX SN";
            this.buttonRX_SN.UseVisualStyleBackColor = true;
            this.buttonRX_SN.Click += new System.EventHandler(this.buttonRX_SN_Click);
            // 
            // buttonTX_SN
            // 
            this.buttonTX_SN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTX_SN.Location = new System.Drawing.Point(47, 335);
            this.buttonTX_SN.Name = "buttonTX_SN";
            this.buttonTX_SN.Size = new System.Drawing.Size(100, 40);
            this.buttonTX_SN.TabIndex = 22;
            this.buttonTX_SN.Text = "TX SN";
            this.buttonTX_SN.UseVisualStyleBackColor = true;
            this.buttonTX_SN.Click += new System.EventHandler(this.buttonTX_SN_Click);
            // 
            // buttonSD_CARD
            // 
            this.buttonSD_CARD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSD_CARD.Location = new System.Drawing.Point(47, 289);
            this.buttonSD_CARD.Name = "buttonSD_CARD";
            this.buttonSD_CARD.Size = new System.Drawing.Size(100, 40);
            this.buttonSD_CARD.TabIndex = 23;
            this.buttonSD_CARD.Text = "SD CARD";
            this.buttonSD_CARD.UseVisualStyleBackColor = true;
            this.buttonSD_CARD.Click += new System.EventHandler(this.buttonSD_CARD_Click);
            // 
            // buttonTX_MIC_SPK
            // 
            this.buttonTX_MIC_SPK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTX_MIC_SPK.Location = new System.Drawing.Point(47, 475);
            this.buttonTX_MIC_SPK.Name = "buttonTX_MIC_SPK";
            this.buttonTX_MIC_SPK.Size = new System.Drawing.Size(200, 40);
            this.buttonTX_MIC_SPK.TabIndex = 24;
            this.buttonTX_MIC_SPK.Text = "TX MIC SPK TESING";
            this.buttonTX_MIC_SPK.UseVisualStyleBackColor = true;
            this.buttonTX_MIC_SPK.Click += new System.EventHandler(this.buttonTX_MIC_SPK_Click);
            // 
            // buttonRF
            // 
            this.buttonRF.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRF.Location = new System.Drawing.Point(47, 59);
            this.buttonRF.Name = "buttonRF";
            this.buttonRF.Size = new System.Drawing.Size(100, 40);
            this.buttonRF.TabIndex = 25;
            this.buttonRF.Text = "RF";
            this.buttonRF.UseVisualStyleBackColor = true;
            this.buttonRF.Click += new System.EventHandler(this.buttonRF_Click);
            // 
            // buttonVOL_UP
            // 
            this.buttonVOL_UP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonVOL_UP.Location = new System.Drawing.Point(502, 98);
            this.buttonVOL_UP.Name = "buttonVOL_UP";
            this.buttonVOL_UP.Size = new System.Drawing.Size(100, 40);
            this.buttonVOL_UP.TabIndex = 26;
            this.buttonVOL_UP.Text = "VOL+";
            this.buttonVOL_UP.UseVisualStyleBackColor = true;
            this.buttonVOL_UP.Click += new System.EventHandler(this.buttonVOL_UP_Click);
            // 
            // buttonPOWER
            // 
            this.buttonPOWER.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPOWER.Location = new System.Drawing.Point(756, 98);
            this.buttonPOWER.Name = "buttonPOWER";
            this.buttonPOWER.Size = new System.Drawing.Size(100, 40);
            this.buttonPOWER.TabIndex = 27;
            this.buttonPOWER.Text = "POWER";
            this.buttonPOWER.UseVisualStyleBackColor = true;
            this.buttonPOWER.Click += new System.EventHandler(this.buttonPOWER_Click);
            // 
            // buttonRIGHT
            // 
            this.buttonRIGHT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRIGHT.Location = new System.Drawing.Point(502, 292);
            this.buttonRIGHT.Name = "buttonRIGHT";
            this.buttonRIGHT.Size = new System.Drawing.Size(100, 40);
            this.buttonRIGHT.TabIndex = 28;
            this.buttonRIGHT.Text = "RIGHT";
            this.buttonRIGHT.UseVisualStyleBackColor = true;
            this.buttonRIGHT.Click += new System.EventHandler(this.buttonRIGHT_Click);
            // 
            // buttonLEFT
            // 
            this.buttonLEFT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLEFT.Location = new System.Drawing.Point(756, 292);
            this.buttonLEFT.Name = "buttonLEFT";
            this.buttonLEFT.Size = new System.Drawing.Size(100, 40);
            this.buttonLEFT.TabIndex = 29;
            this.buttonLEFT.Text = "LEFT";
            this.buttonLEFT.UseVisualStyleBackColor = true;
            this.buttonLEFT.Click += new System.EventHandler(this.buttonLEFT_Click);
            // 
            // buttonTALK
            // 
            this.buttonTALK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTALK.Location = new System.Drawing.Point(632, 413);
            this.buttonTALK.Name = "buttonTALK";
            this.buttonTALK.Size = new System.Drawing.Size(100, 40);
            this.buttonTALK.TabIndex = 30;
            this.buttonTALK.Text = "TALK";
            this.buttonTALK.UseVisualStyleBackColor = true;
            this.buttonTALK.Click += new System.EventHandler(this.buttonTALK_Click);
            // 
            // buttonDOWN
            // 
            this.buttonDOWN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDOWN.Location = new System.Drawing.Point(632, 355);
            this.buttonDOWN.Name = "buttonDOWN";
            this.buttonDOWN.Size = new System.Drawing.Size(100, 40);
            this.buttonDOWN.TabIndex = 31;
            this.buttonDOWN.Text = "DOWN";
            this.buttonDOWN.UseVisualStyleBackColor = true;
            this.buttonDOWN.Click += new System.EventHandler(this.buttonDOWN_Click);
            // 
            // buttonENTER
            // 
            this.buttonENTER.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonENTER.Location = new System.Drawing.Point(632, 292);
            this.buttonENTER.Name = "buttonENTER";
            this.buttonENTER.Size = new System.Drawing.Size(100, 40);
            this.buttonENTER.TabIndex = 32;
            this.buttonENTER.Text = "EBTER";
            this.buttonENTER.UseVisualStyleBackColor = true;
            this.buttonENTER.Click += new System.EventHandler(this.buttonENTER_Click);
            // 
            // buttonUP
            // 
            this.buttonUP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUP.Location = new System.Drawing.Point(632, 232);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(100, 40);
            this.buttonUP.TabIndex = 33;
            this.buttonUP.Text = "UP";
            this.buttonUP.UseVisualStyleBackColor = true;
            this.buttonUP.Click += new System.EventHandler(this.buttonUP_Click);
            // 
            // buttonMENU
            // 
            this.buttonMENU.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonMENU.Location = new System.Drawing.Point(632, 166);
            this.buttonMENU.Name = "buttonMENU";
            this.buttonMENU.Size = new System.Drawing.Size(100, 40);
            this.buttonMENU.TabIndex = 34;
            this.buttonMENU.Text = "MENU";
            this.buttonMENU.UseVisualStyleBackColor = true;
            this.buttonMENU.Click += new System.EventHandler(this.buttonMENU_Click);
            // 
            // buttonVOL_DOWN
            // 
            this.buttonVOL_DOWN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonVOL_DOWN.Location = new System.Drawing.Point(632, 98);
            this.buttonVOL_DOWN.Name = "buttonVOL_DOWN";
            this.buttonVOL_DOWN.Size = new System.Drawing.Size(100, 40);
            this.buttonVOL_DOWN.TabIndex = 35;
            this.buttonVOL_DOWN.Text = "VOL-";
            this.buttonVOL_DOWN.UseVisualStyleBackColor = true;
            this.buttonVOL_DOWN.Click += new System.EventHandler(this.buttonVOL_DOWN_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(554, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 36;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonVOL_DOWN);
            this.Controls.Add(this.buttonMENU);
            this.Controls.Add(this.buttonUP);
            this.Controls.Add(this.buttonENTER);
            this.Controls.Add(this.buttonDOWN);
            this.Controls.Add(this.buttonTALK);
            this.Controls.Add(this.buttonLEFT);
            this.Controls.Add(this.buttonRIGHT);
            this.Controls.Add(this.buttonPOWER);
            this.Controls.Add(this.buttonVOL_UP);
            this.Controls.Add(this.buttonRF);
            this.Controls.Add(this.buttonTX_MIC_SPK);
            this.Controls.Add(this.buttonSD_CARD);
            this.Controls.Add(this.buttonTX_SN);
            this.Controls.Add(this.buttonRX_SN);
            this.Controls.Add(this.buttonRX_MIC_SPK);
            this.Controls.Add(this.buttonRX_SW);
            this.Controls.Add(this.buttonTX_SW);
            this.Controls.Add(this.buttonLIGHT);
            this.Controls.Add(this.buttonTEMP);
            this.Controls.Add(this.labelTips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSn);
            this.Controls.Add(this.buttonUPOLOAD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "T8300";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUPOLOAD;
        private System.Windows.Forms.TextBox textBoxSn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTips;
        private System.Windows.Forms.Button buttonTEMP;
        private System.Windows.Forms.Button buttonLIGHT;
        private System.Windows.Forms.Button buttonTX_SW;
        private System.Windows.Forms.Button buttonRX_SW;
        private System.Windows.Forms.Button buttonRX_MIC_SPK;
        private System.Windows.Forms.Button buttonRX_SN;
        private System.Windows.Forms.Button buttonTX_SN;
        private System.Windows.Forms.Button buttonSD_CARD;
        private System.Windows.Forms.Button buttonTX_MIC_SPK;
        private System.Windows.Forms.Button buttonRF;
        private System.Windows.Forms.Button buttonVOL_UP;
        private System.Windows.Forms.Button buttonPOWER;
        private System.Windows.Forms.Button buttonRIGHT;
        private System.Windows.Forms.Button buttonLEFT;
        private System.Windows.Forms.Button buttonTALK;
        private System.Windows.Forms.Button buttonDOWN;
        private System.Windows.Forms.Button buttonENTER;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.Button buttonMENU;
        private System.Windows.Forms.Button buttonVOL_DOWN;
        private System.Windows.Forms.Button button1;
    }
}

