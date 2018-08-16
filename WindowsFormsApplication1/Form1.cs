using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BenQGuru.eMES.DLLService;
using System.Runtime.InteropServices;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32")]//返回取得字符串缓冲区的长度
        private static extern long GetPrivateProfileString(string section, string key,
            string def, StringBuilder retVal, int size, string filePath);

        string WorkOrder;
        string ResCode;
        string ISCHECK;
        string User;
        string PassWork;
        bool CheckResult = true; 

        public Form1()
        {
            InitializeComponent();

            //关联closing事件
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);

            string filePath;            
            string ErrMessage = "";

            filePath = System.AppDomain.CurrentDomain.BaseDirectory + "T8300.ini";
            
            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString("T8300", "User", null,temp,1024, filePath);
            User = temp.ToString();

            GetPrivateProfileString("T8300", "PassWork", null, temp, 1024, filePath);
            PassWork = temp.ToString();

            GetPrivateProfileString("T8300", "ResCode", null, temp, 1024, filePath);
            ResCode = temp.ToString();

            //GetPrivateProfileString("T8300", "WorkOrder", null, temp, 1024, filePath);
            //WorkOrder = temp.ToString();

            GetPrivateProfileString("T8300", "ISCHECK", null, temp, 1024, filePath);
            ISCHECK = temp.ToString();


            BenQGuru.eMES.DLLService.MESHelper login = new BenQGuru.eMES.DLLService.MESHelper();
            if (!login.CheckUserAndResourcePassed(User, ResCode, PassWork, "", out ErrMessage))
            {
                labelTips.Text = "登录失败\n" + ErrMessage;
                labelTips.ForeColor = Color.Red;
            }
            else
            {
                labelTips.Text = "登录成功";
                labelTips.ForeColor = Color.Red;
            }

        }


        //将按钮变为灰色
        public void button_Gray()
        {
            buttonRF.Text = "RF";
            buttonTEMP.Text = "TEMP";
            buttonLIGHT.Text = "LIGHT";
            buttonTX_SW.Text = "TX_SW";
            buttonRX_SW.Text = "RX_SW";
            buttonSD_CARD.Text = "SD_CARD";
            buttonTX_SN.Text = "TX_SN";
            buttonRX_SN.Text = "RX_SN";
            buttonRX_MIC_SPK.Text = "RX_MIC_SPK";
            buttonTX_MIC_SPK.Text = "TX_MIC_SPK";

            buttonVOL_DOWN.Text = "VOL-";
            buttonMENU.Text = "MENU";
            buttonUP.Text = "UP";
            buttonENTER.Text = "ENTER";
            buttonDOWN.Text = "DOWN";
            buttonTALK.Text = "TALK";
            buttonVOL_UP.Text = "VOL+";
            buttonPOWER.Text = "POWER";
            buttonRIGHT.Text = "RIGHT";
            buttonLEFT.Text = "LEFT";


            buttonRF.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonTEMP.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonLIGHT.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonTX_SW.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonRX_SW.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonSD_CARD.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonTX_SN.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonRX_SN.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonRX_MIC_SPK.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonTX_MIC_SPK.BackColor = Color.FromArgb(200, 192, 192, 192);

            buttonVOL_DOWN.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonMENU.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonUP.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonENTER.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonDOWN.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonTALK.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonVOL_UP.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonPOWER.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonRIGHT.BackColor = Color.FromArgb(200, 192, 192, 192);
            buttonLEFT.BackColor = Color.FromArgb(200, 192, 192, 192);
        }

        //检查按钮是否有确认
        public void button_Check()
        {
            if (buttonRF.Text == "RF")
            {
                CheckResult = false;
            }
            if (buttonTEMP.Text == "TEMP")
            {
                CheckResult = false;
            }
            if (buttonLIGHT.Text == "LIGHT")
            {
                CheckResult = false;
            }
            if (buttonTX_SW.Text == "TX SW")
            {
                CheckResult = false;
            }
            if (buttonRX_SW.Text == "RX SW")
            {
                CheckResult = false;
            }
            if (buttonSD_CARD.Text == "SD CARD")
            {
                CheckResult = false;
            }
            if (buttonTX_SN.Text == "TX SN")
            {
                CheckResult = false;
            }
            if (buttonRX_SN.Text == "RX SN")
            {
                CheckResult = false;
            }
            if (buttonRX_MIC_SPK.Text == "RX MIC SPK TESING")
            {
                CheckResult = false;
            }
            if (buttonTX_MIC_SPK.Text == "TX MIC SPK TESING")
            {
                CheckResult = false;
            }
            if (buttonVOL_DOWN.Text == "VOL-")
            {
                CheckResult = false;
            }
            if (buttonMENU.Text == "MENU")
            {
                CheckResult = false;
            }
            if (buttonUP.Text == "UP")
            {
                CheckResult = false;
            }
            if (buttonENTER.Text == "ENTER")
            {
                CheckResult = false;
            }
            if (buttonDOWN.Text == "DOWN")
            {
                CheckResult = false;
            }
            if (buttonTALK.Text == "TALK")
            {
                CheckResult = false;
            }
            if (buttonVOL_UP.Text == "VOL+")
            {
                CheckResult = false;
            }
            if (buttonPOWER.Text == "POWER")
            {
                CheckResult = false;
            }
            if (buttonRIGHT.Text == "RIGHT")
            {
                CheckResult = false;
            }
            if (buttonLEFT.Text == "LEFT")
            {
                CheckResult = false;
            }
        }

        //将按钮全部设置成绿色
        public void button_Green()
        {
            buttonRF.Text = "RF-OK";
            buttonTEMP.Text = "TEMP-OK";
            buttonLIGHT.Text = "LIGHT-OK";
            buttonTX_SW.Text = "TX SW-OK";
            buttonRX_SW.Text = "RX SW-OK";
            buttonSD_CARD.Text = "SD CARD-OK";
            buttonTX_SN.Text = "TX SN-OK";
            buttonRX_SN.Text = "RX SN-OK";
            buttonRX_MIC_SPK.Text = "RX MIC SPK-OK";
            buttonTX_MIC_SPK.Text = "TX MIC SPK-OK";

            buttonVOL_DOWN.Text = "VOL--OK";
            buttonMENU.Text = "MENU-OK";
            buttonUP.Text = "UP-OK";
            buttonENTER.Text = "ENTER-OK";
            buttonDOWN.Text = "DOWN-OK";
            buttonTALK.Text = "TALK-OK";
            buttonVOL_UP.Text = "VOL+-OK";
            buttonPOWER.Text = "POWER-OK";
            buttonRIGHT.Text = "RIGHT-OK";
            buttonLEFT.Text = "LEFT-OK";


            buttonRF.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonTEMP.BackColor = Color.FromArgb(200, 0, 255, 0);;
            buttonLIGHT.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonTX_SW.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonRX_SW.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonSD_CARD.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonTX_SN.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonRX_SN.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonRX_MIC_SPK.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonTX_MIC_SPK.BackColor = Color.FromArgb(200, 0, 255, 0);

            buttonVOL_DOWN.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonMENU.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonUP.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonENTER.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonDOWN.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonTALK.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonVOL_UP.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonPOWER.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonRIGHT.BackColor = Color.FromArgb(200, 0, 255, 0);
            buttonLEFT.BackColor = Color.FromArgb(200, 0, 255, 0);
        }

        //将按钮全部设置成红色

        public void button_Red()
        {
            buttonRF.Text = "RF-NG";
            buttonTEMP.Text = "TEMP-NG";
            buttonLIGHT.Text = "LIGHT-NG";
            buttonTX_SW.Text = "TX SW-NG";
            buttonRX_SW.Text = "RX SW-NG";
            buttonSD_CARD.Text = "SD CARD-NG";
            buttonTX_SN.Text = "TX SN-NG";
            buttonRX_SN.Text = "RX SN-NG";
            buttonRX_MIC_SPK.Text = "RX MIC SPK-NG";
            buttonTX_MIC_SPK.Text = "TX MIC SPK-NG";

            buttonVOL_DOWN.Text = "VOL--NG";
            buttonMENU.Text = "MENU-NG";
            buttonUP.Text = "UP-NG";
            buttonENTER.Text = "ENTER-NG";
            buttonDOWN.Text = "DOWN-NG";
            buttonTALK.Text = "TALK-NG";
            buttonVOL_UP.Text = "VOL+-NG";
            buttonPOWER.Text = "POWER-NG";
            buttonRIGHT.Text = "RIGHT-NG";
            buttonLEFT.Text = "LEFT-NG";


            buttonRF.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonTEMP.BackColor = Color.FromArgb(200, 255, 0, 0); ;
            buttonLIGHT.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonTX_SW.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonRX_SW.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonSD_CARD.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonTX_SN.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonRX_SN.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonRX_MIC_SPK.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonTX_MIC_SPK.BackColor = Color.FromArgb(200, 255, 0, 0);

            buttonVOL_DOWN.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonMENU.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonUP.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonENTER.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonDOWN.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonTALK.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonVOL_UP.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonPOWER.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonRIGHT.BackColor = Color.FromArgb(200, 255, 0, 0);
            buttonLEFT.BackColor = Color.FromArgb(200, 255, 0, 0);
        }

        //收集错误码
        public void Collecting_Errors(out string ErrMessage)
        {
            ErrMessage = "";
            if (buttonRF.Text == "RF-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_RF";
                }
                else
                {
                    ErrMessage += ",T8300_RF";
                }                     
            }

            if (buttonTEMP.Text == "TEMP-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_TEMP";
                }
                else
                {
                    ErrMessage += ",T8300_TEMP";
                }
            }
            if (buttonLIGHT.Text == "LIGHT-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_LIGHT";
                }
                else
                {
                    ErrMessage += ",T8300_LIGHT";
                }
            }
            if (buttonTX_SW.Text == "TX SW-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300 TX_SW";
                }
                else
                {
                    ErrMessage += ",T8300_TX_SW";
                }
            }
            if (buttonRX_SW.Text == "RX SW-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_RX_SW";
                }
                else
                {
                    ErrMessage += ",T8300_RX_SW";
                }
            }
            if (buttonSD_CARD.Text == "SD CARD-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_SD_CARD";
                }
                else
                {
                    ErrMessage += ",T8300_SD_CARD";
                }
            }
            if (buttonTX_SN.Text == "TX SN-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_TX_SN";
                }
                else
                {
                    ErrMessage += ",T8300_TX_SN";
                }
            }
            if (buttonRX_SN.Text == "RX SN-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_RX_SN";
                }
                else
                {
                    ErrMessage += ",T8300_RX_SN";
                }
            }
            if (buttonRX_MIC_SPK.Text == "RX MIC SPK-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_RX_MIC_SPK";
                }
                else
                {
                    ErrMessage += ",T8300_RX_MIC_SPK";
                }
            }
            if (buttonTX_MIC_SPK.Text == "TX MIC SPK-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_TX_MIC_SPK";
                }
                else
                {
                    ErrMessage += ",T8300_TX_MIC_SPK";
                }
            }
            if (buttonVOL_DOWN.Text == "VOL--NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_VOL-";
                }
                else
                {
                    ErrMessage += ",T8300_VOL-";
                }
            }
            if (buttonMENU.Text == "MENU-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_MENU";
                }
                else
                {
                    ErrMessage += ",T8300_MENU";
                }
            }
            if (buttonUP.Text == "UP-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_UP";
                }
                else
                {
                    ErrMessage += ",T8300_UP";
                }
            }
            if (buttonENTER.Text == "ENTER-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_ENTER";
                }
                else
                {
                    ErrMessage += ",T8300_ENTER";
                }
            }
            if (buttonDOWN.Text == "DOWN-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_DOWN";
                }
                else
                {
                    ErrMessage += ",T8300_DOWN";
                }
            }
            if (buttonTALK.Text == "TALK-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_TALK";
                }
                else
                {
                    ErrMessage += ",T8300_TALK";
                }
            }
            if (buttonVOL_UP.Text == "VOL+-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_VOL+";
                }
                else
                {
                    ErrMessage += ",T8300_VOL+";
                }
            }
            if (buttonPOWER.Text == "POWER-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_POWER";
                }
                else
                {
                    ErrMessage += ",T8300_POWER";
                }
            }
            if (buttonRIGHT.Text == "RIGHT-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_RIGHT";
                }
                else
                {
                    ErrMessage += ",T8300_RIGHT";
                }
            }
            if (buttonLEFT.Text == "LEFT-NG")
            {
                if (ErrMessage == "")
                {
                    ErrMessage = "T8300_LEFT";
                }
                else
                {
                    ErrMessage += ",T8300_LEFT";
                }
            }
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            string ErrMessage = "";
            BenQGuru.eMES.DLLService.MESHelper temp = new BenQGuru.eMES.DLLService.MESHelper();
            bool b = temp.ATELogOut(ResCode, out ErrMessage);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUPOLOAD_Click(object sender, EventArgs e)
        {

            string ErrMessage;
            string SN;
            int time;
            string Result;
            string ErrCode = "";

            CheckResult = true;

            BenQGuru.eMES.DLLService.MESHelper temp = new BenQGuru.eMES.DLLService.MESHelper();

            SN = textBoxSn.Text;
            if (SN == "")
            {
                labelTips.Text = "请扫描SN!";
                return;
            }
            //检查是否有确认按钮
            button_Check();
            if (!CheckResult)
            {
                labelTips.Text = "请确认按钮是否正常\n";
                return;
            }

            //收集错误码
            Collecting_Errors(out ErrCode);
            //textBox1.Text = ErrMessage;
            if (ErrCode == "")
            {
                Result = "OK";
            }
            else
            {
                Result = "NG";
            }


            if (ISCHECK == "TRUE")
            {
                bool b = temp.CheckRoutePassed(SN, ResCode, out ErrMessage, out time);
                if (!b)
                {
                    labelTips.Text = "该序列号不属于当前工序\n" + ErrMessage;
                    textBoxSn.Text = "";
                    textBoxSn.Focus();
                    return;
                }
                else
                {
                    if (!temp.SetMobileData(SN, ResCode, User, Result, ErrCode, out ErrMessage))
                    {
                        labelTips.Text = "上传失败，请重试!\n" + ErrMessage;
                    }
                    else
                    {

                        button_Gray();
                        textBoxSn.Text = "";
                    }
                }
            }
            else
            {
                if (!temp.SetMobileData(SN, ResCode, User, Result, ErrCode, out ErrMessage))
                {
                    labelTips.Text = "上传失败，请重试!\n" + ErrMessage;
                }
                else
                {

                    button_Gray();
                    textBoxSn.Text = "";
                }
            }
            
            textBoxSn.Focus();
            return;
        }

        private void buttonRF_Click(object sender, EventArgs e)
        {

            if (buttonRF.Text == "RF-OK")
            {
                buttonRF.Text = "RF-NG";
                buttonRF.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonRF.Text == "RF-NG")
            {
                buttonRF.Text = "RF-OK";
                buttonRF.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonRF.Text = "RF-OK";
                buttonRF.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonTEMP_Click(object sender, EventArgs e)
        {
            if (buttonTEMP.Text == "TEMP-OK")
            {
                buttonTEMP.Text = "TEMP-NG";
                buttonTEMP.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonTEMP.Text == "TEMP-NG")
            {
                buttonTEMP.Text = "TEMP-OK";
                buttonTEMP.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonTEMP.Text = "TEMP-OK";
                buttonTEMP.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonLIGHT_Click(object sender, EventArgs e)
        {
            if (buttonLIGHT.Text == "LIGHT-OK")
            {
                buttonLIGHT.Text = "LIGHT-NG";
                buttonLIGHT.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonLIGHT.Text == "LIGHT-NG")
            {
                buttonLIGHT.Text = "LIGHT-OK";
                buttonLIGHT.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonLIGHT.Text = "LIGHT-OK";
                buttonLIGHT.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonTX_SW_Click(object sender, EventArgs e)
        {
            if (buttonTX_SW.Text == "TX SW-OK")
            {
                buttonTX_SW.Text = "TX SW-NG";
                buttonTX_SW.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonTX_SW.Text == "TX SW-NG")
            {
                buttonTX_SW.Text = "TX SW-OK";
                buttonTX_SW.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonTX_SW.Text = "TX SW-OK";
                buttonTX_SW.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonRX_SW_Click(object sender, EventArgs e)
        {
            if (buttonRX_SW.Text == "RX SW-OK")
            {
                buttonRX_SW.Text = "RX SW-NG";
                buttonRX_SW.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonRX_SW.Text == "RX SW-NG")
            {
                buttonRX_SW.Text = "RX SW-OK";
                buttonRX_SW.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonRX_SW.Text = "RX SW-OK";
                buttonRX_SW.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonSD_CARD_Click(object sender, EventArgs e)
        {
            if (buttonSD_CARD.Text == "SD CARD-OK")
            {
                buttonSD_CARD.Text = "SD CARD-NG";
                buttonSD_CARD.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonSD_CARD.Text == "SD CARD-NG")
            {
                buttonSD_CARD.Text = "SD CARD-OK";
                buttonSD_CARD.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonSD_CARD.Text = "SD CARD-OK";
                buttonSD_CARD.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonTX_SN_Click(object sender, EventArgs e)
        {
            if (buttonTX_SN.Text == "TX SN-OK")
            {
                buttonTX_SN.Text = "TX SN-NG";
                buttonTX_SN.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonTX_SN.Text == "TX SN-NG")
            {
                buttonTX_SN.Text = "TX SN-OK";
                buttonTX_SN.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonTX_SN.Text = "TX SN-OK";
                buttonTX_SN.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonRX_SN_Click(object sender, EventArgs e)
        {
            if (buttonRX_SN.Text == "RX SN-OK")
            {
                buttonRX_SN.Text = "RX SN-NG";
                buttonRX_SN.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonRX_SN.Text == "RX SN-NG")
            {
                buttonRX_SN.Text = "RX SN-OK";
                buttonRX_SN.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonRX_SN.Text = "RX SN-OK";
                buttonRX_SN.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonRX_MIC_SPK_Click(object sender, EventArgs e)
        {
            if (buttonRX_MIC_SPK.Text == "RX MIC SPK-OK")
            {
                buttonRX_MIC_SPK.Text = "RX MIC SPK-NG";
                buttonRX_MIC_SPK.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonRX_MIC_SPK.Text == "RX MIC SPK-NG")
            {
                buttonRX_MIC_SPK.Text = "RX MIC SPK-OK";
                buttonRX_MIC_SPK.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonRX_MIC_SPK.Text = "RX MIC SPK-OK";
                buttonRX_MIC_SPK.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonTX_MIC_SPK_Click(object sender, EventArgs e)
        {
            if (buttonTX_MIC_SPK.Text == "TX MIC SPK-OK")
            {
                buttonTX_MIC_SPK.Text = "TX MIC SPK-NG";
                buttonTX_MIC_SPK.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonTX_MIC_SPK.Text == "TX MIC SPK-NG")
            {
                buttonTX_MIC_SPK.Text = "TX MIC SPK-OK";
                buttonTX_MIC_SPK.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonTX_MIC_SPK.Text = "TX MIC SPK-OK";
                buttonTX_MIC_SPK.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonVOL_DOWN_Click(object sender, EventArgs e)
        {
            if (buttonVOL_DOWN.Text == "VOL--OK")
            {
                buttonVOL_DOWN.Text = "VOL--NG";
                buttonVOL_DOWN.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonVOL_DOWN.Text == "VOL--NG")
            {
                buttonVOL_DOWN.Text = "VOL--OK";
                buttonVOL_DOWN.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonVOL_DOWN.Text = "VOL--OK";
                buttonVOL_DOWN.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonMENU_Click(object sender, EventArgs e)
        {
            if (buttonMENU.Text == "MENU-OK")
            {
                buttonMENU.Text = "MENU-NG";
                buttonMENU.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonMENU.Text == "MENU-NG")
            {
                buttonMENU.Text = "MENU-OK";
                buttonMENU.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonMENU.Text = "MENU-OK";
                buttonMENU.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonUP_Click(object sender, EventArgs e)
        {
            if (buttonUP.Text == "UP-OK")
            {
                buttonUP.Text = "UP-NG";
                buttonUP.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonUP.Text == "UP-NG")
            {
                buttonUP.Text = "UP-OK";
                buttonUP.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonUP.Text = "UP-OK";
                buttonUP.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonENTER_Click(object sender, EventArgs e)
        {
            if (buttonENTER.Text == "ENTER-OK")
            {
                buttonENTER.Text = "ENTER-NG";
                buttonENTER.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonENTER.Text == "ENTER-NG")
            {
                buttonENTER.Text = "ENTER-OK";
                buttonENTER.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonENTER.Text = "ENTER-OK";
                buttonENTER.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonDOWN_Click(object sender, EventArgs e)
        {
            if (buttonDOWN.Text == "DOWN-OK")
            {
                buttonDOWN.Text = "DOWN-NG";
                buttonDOWN.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonDOWN.Text == "DOWN-NG")
            {
                buttonDOWN.Text = "DOWN-OK";
                buttonDOWN.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonDOWN.Text = "DOWN-OK";
                buttonDOWN.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonTALK_Click(object sender, EventArgs e)
        {
            if (buttonTALK.Text == "TALK-OK")
            {
                buttonTALK.Text = "TALK-NG";
                buttonTALK.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonTALK.Text == "TALK-NG")
            {
                buttonTALK.Text = "TALK-OK";
                buttonTALK.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonTALK.Text = "TALK-OK";
                buttonTALK.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonVOL_UP_Click(object sender, EventArgs e)
        {
            if (buttonVOL_UP.Text == "VOL+-OK")
            {
                buttonVOL_UP.Text = "VOL+-NG";
                buttonVOL_UP.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonVOL_UP.Text == "VOL+-NG")
            {
                buttonVOL_UP.Text = "VOL+-OK";
                buttonVOL_UP.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonVOL_UP.Text = "VOL+-OK";
                buttonVOL_UP.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonPOWER_Click(object sender, EventArgs e)
        {
            if (buttonPOWER.Text == "POWER-OK")
            {
                buttonPOWER.Text = "POWER-NG";
                buttonPOWER.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonPOWER.Text == "POWER-NG")
            {
                buttonPOWER.Text = "POWER-OK";
                buttonPOWER.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonPOWER.Text = "POWER-OK";
                buttonPOWER.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonRIGHT_Click(object sender, EventArgs e)
        {
            if (buttonRIGHT.Text == "RIGHT-OK")
            {
                buttonRIGHT.Text = "RIGHT-NG";
                buttonRIGHT.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonRIGHT.Text == "RIGHT-NG")
            {
                buttonRIGHT.Text = "RIGHT-OK";
                buttonRIGHT.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonRIGHT.Text = "RIGHT-OK";
                buttonRIGHT.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void buttonLEFT_Click(object sender, EventArgs e)
        {
            if (buttonLEFT.Text == "LEFT-OK")
            {
                buttonLEFT.Text = "LEFT-NG";
                buttonLEFT.BackColor = Color.FromArgb(200, 255, 0, 0);
            }
            else if (buttonLEFT.Text == "LEFT-NG")
            {
                buttonLEFT.Text = "LEFT-OK";
                buttonLEFT.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
            else
            {
                buttonLEFT.Text = "LEFT-OK";
                buttonLEFT.BackColor = Color.FromArgb(200, 0, 255, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Green();
        }

    }
}
