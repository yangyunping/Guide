﻿using BLL;
using MODEL;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using UI.LED;

namespace UI
{
    public partial class FrmMain : Form
    {
        BllAreaInfo BllAreaInfo = new BllAreaInfo();
        BllLedShowInfo ledShowInfo = new BllLedShowInfo();
        public readonly string _configPath = Application.StartupPath + @"\\" + @"Config.ini";//配置文件存放路径
        private string skinType = string.Empty;
        public FrmMain()
        {
            InitializeComponent();
            PowersInite();
            ShowTimer.Start();//开始预设显示
            string skinPath = Application.StartupPath + @"\Skins";
            lstContent.DataSource = new DirectoryInfo(skinPath).GetFiles();
            lstContent.DisplayMember = "Name";
            lblEmpInfo.Text = "登录信息： " + CurrentInfo.currentEmp.EmployeeName;
        }
        /// <summary>
        /// 添加新界面
        /// </summary>
        /// <param name="titleName"></param>
        /// <param name="control"></param>
        private void CreateNewPage(string titleName, Control control)
        {
            foreach (TabPage tbpage in tbMainShow.TabPages)
            {
                if (tbpage.Name == titleName)
                {
                    tbMainShow.SelectedTab = tbpage;
                    return;
                }
            }
            TabPage newPage = new TabPage() { Name = titleName, Text = titleName };
            tbMainShow.TabPages.Add(newPage);
            newPage.Controls.Add(control);
            control.Parent = newPage;
            tbMainShow.SelectTab(newPage);
        }
        /// <summary>
        /// 双击删除界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbContent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl1 = (TabControl)sender;
            Point pt = new Point(e.X, e.Y);

            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                Rectangle recTab = tabControl1.GetTabRect(i);
                if (recTab.Contains(pt))
                {
                    TabPage seltab = tbMainShow.SelectedTab;
                    int seltabindex = tbMainShow.SelectedIndex;

                    tabControl1.Controls.Remove(seltab);
                    if (seltabindex != 0)
                        tabControl1.SelectTab(seltabindex - 1);
                    return;
                }
            }
        }

        private void FrmMain_FormClosing1(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 权限控制
        /// </summary>
        private void PowersInite()
        {
            AreaShowSearch.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.区域设置);
            tsmSreenToArea.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.区域LED匹配);
            tsmScreenSetting.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.LED参数配置);
            tsmByOrderSet.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.排序设置);
            tsmTepletSet.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.模板设置);
            tsmDefinedShow.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.自定义LED显示);
            tsbConfig.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.配置信息);
        }
        /// <summary>
        /// 区域设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AreaShowSearch_Click(object sender, EventArgs e)
        {
            FrmSearchTemplet frmAreaSearch = new FrmSearchTemplet("区域") { Dock = DockStyle.Fill, AutoSize = false, AutoScaleMode = AutoScaleMode.None };
            CreateNewPage(AreaShowSearch.Text, frmAreaSearch);
        }
        /// <summary>
        /// 编组设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 配置查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperateLED FrmiAplay = new FrmOperateLED();
            FrmiAplay.ShowDialog();
        }
        /// <summary>
        /// 启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBegin_Click(object sender, EventArgs e)
        {
            FrmShow frmShow = new FrmShow();
            frmShow.ShowDialog();
        }
        /// <summary>
        /// 关闭界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            Application.Exit();
        }

        private void tsbEmployee_Click(object sender, EventArgs e)
        {
            FrmEmpSearch frmEmpSearch = new FrmEmpSearch() { Dock = DockStyle.Fill, AutoSize = false, AutoScaleMode = AutoScaleMode.None };
            CreateNewPage(tsbEmployee.Text, frmEmpSearch);
        }
        /// <summary>
        /// 配置信息（权限等）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbConfig_Click(object sender, EventArgs e)
        {
            FrmConfig frmConfig = new FrmConfig() { Dock = DockStyle.Fill, AutoSize = false, AutoScaleMode = AutoScaleMode.None };
            CreateNewPage(tsbConfig.Text, frmConfig);
        }
        /// <summary>
        /// 显示器设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSreenToArea_Click(object sender, EventArgs e)
        {
            FrmSearchTemplet frmShowSearch = new FrmSearchTemplet("屏幕") { Dock = DockStyle.Fill, AutoSize = false, AutoScaleMode = AutoScaleMode.None };
            CreateNewPage(tsmSreenToArea.Text, frmShowSearch);
        }
        /// <summary>
        /// 皮肤更换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 皮肤更换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstContent.Enabled = true;
            pnlThemes.Visible = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                FormClosing += (senders, ex) =>
                {
                    GC.Collect();
                    Application.Exit();
                };
                StringBuilder selectOrder = new StringBuilder(255);
                PublicClass.GetPrivateProfileString("SkinPath", "SkinPathValue", " ", selectOrder, 255,
                    _configPath);
                if (string.IsNullOrEmpty(selectOrder.ToString()))
                {
                    skinEngine1.Active = false;
                    return;
                }
                skinEngine1.SkinFile = selectOrder.ToString();
            }
            catch { }
        }
        /// <summary>
        /// 皮肤应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lstContent.SelectedItem != null)
                {
                    skinType = (this.lstContent.SelectedItem as FileInfo).FullName;
                    skinEngine1.SkinFile = skinType;
                    skinEngine1.SkinAllForm = true;
                    skinEngine1.DisableTag = 9999;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }
        /// <summary>
        /// 保存皮肤到本地文件缓存中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(skinType))
            {
                PublicClass.WritePrivateProfileString("SkinPath", "SkinPathValue", skinType, _configPath);
            }
            pnlThemes.Visible = false;
        }
        /// <summary>
        /// 加载本地的所有皮肤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrigal_Click(object sender, EventArgs e)
        {
            PublicClass.WritePrivateProfileString("SkinPath", "SkinPathValue", "", _configPath);
            skinEngine1.Active = false;
            pnlThemes.Visible = false;
        }
        /// <summary>
        /// 关闭皮肤操作框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            lstContent.Enabled = false;
            pnlThemes.Visible = false;
        }
        /// <summary>
        ///密码修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPassword frmPassword = new FrmPassword();
            frmPassword.ShowDialog();
        }
        /// <summary>
        /// 自定义显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmDefinedShow_Click(object sender, EventArgs e)
        {
            FrmDefinedShow frmDefinedShow = new FrmDefinedShow();
            frmDefinedShow.ShowDialog();
        }
        /// <summary>
        /// 模板查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmTempletSearch_Click(object sender, EventArgs e)
        {
            FrmTempletSearch frmTempletSearch = new FrmTempletSearch() { Dock = DockStyle.Fill, AutoSize = false, AutoScaleMode = AutoScaleMode.None };
            CreateNewPage(tsmTempletSearch.Text, frmTempletSearch);
        }
        /// <summary>
        /// 模板设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 模板设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTempletLED frmTempletLED = new FrmTempletLED();
            frmTempletLED.ShowDialog();
        }
        /// <summary>
        ///LED预显示重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmResetOrderShow_Click(object sender, EventArgs e)
        {
            DataTable dtALLShow = ledShowInfo.GetLEDShowInfos($@" and  Tag = 2 ");
            for (int i = 0; i < dtALLShow.Rows.Count; i++)
            {
                ledShowInfo.UpdateLEDShowInfoState(Convert.ToInt32(dtALLShow.Rows[i]["ID"]), 0);
            }
        }
        /// <summary>
        /// 模板显示操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 模板显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTempletSendLED frmTempletSendLED = new FrmTempletSendLED();
            frmTempletSendLED.ShowDialog();
        }
        /// <summary>
        /// 预显示查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmShowLog_Click(object sender, EventArgs e)
        {
            FrmShowLogSearch frmShowLog = new FrmShowLogSearch() { Dock = DockStyle.Fill, AutoSize = false, AutoScaleMode = AutoScaleMode.None };
            CreateNewPage(tsmShowLog.Text, frmShowLog);
        }
        /// <summary>
        /// 参数配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lED参数配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLEDSetting frmLEDSetting = new FrmLEDSetting();
            frmLEDSetting.ShowDialog();
        }
        /// <summary>
        /// 排序设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 排序设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmByOrderShow frmByOrderShow = new FrmByOrderShow();
            frmByOrderShow.ShowDialog();
        }
        /// <summary>
        /// timer 实时显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                //预设显示
                DataTable dtShow = ledShowInfo.GetLEDShowInfos($@" and  Tag = 0  and  BeginTime <= CONVERT (CHAR(10), GETDATE(), 108) and EndTime >= CONVERT (CHAR(10), GETDATE(), 108) order by BeginTime");
                for (int i = 0; i < dtShow.Rows.Count; i++)
                {
                    try
                    {
                        int addressNum = Convert.ToInt32(dtShow.Rows[i]["AddressNum"]);
                        if (Convert.ToInt32(dtShow.Rows[i]["DeleteUpProgram"]) == 1)
                        {
                            LEDShow.DeleteProgram(addressNum);//删除指定控制卡所有节目
                        }
                        int programInx = LEDShow.AddProgram(addressNum, Convert.ToInt32(dtShow.Rows[i]["Duration"]));//添加节目
                        int fontsize = Convert.ToInt32(dtShow.Rows[i]["SonFontSize"]) == 0 ? Convert.ToInt32(dtShow.Rows[i]["FontSize"]) : Convert.ToInt32(dtShow.Rows[i]["SonFontSize"]);

                        //开始显示日志记录和发送失败记录
                        LEDShowInfo showInfo = new LEDShowInfo();
                        showInfo.ScreenId = dtShow.Rows[i]["ScreenId"].ToString();
                        showInfo.AddressNum = Convert.ToInt32(dtShow.Rows[i]["AddressNum"]);
                        showInfo.BeginTime = dtShow.Rows[i]["BeginTime"].ToString();
                        showInfo.EndTime = dtShow.Rows[i]["EndTime"].ToString();
                        showInfo.Content = dtShow.Rows[i]["Content"].ToString();
                        showInfo.FontColor = dtShow.Rows[i]["FontColor"].ToString();
                        showInfo.FontName = dtShow.Rows[i]["FontName"].ToString();
                        showInfo.FontSize = Convert.ToInt32(dtShow.Rows[i]["FontSize"]);
                        showInfo.ShowStyle = Convert.ToInt32(dtShow.Rows[i]["ShowStyle"]);
                        showInfo.FontBold = Convert.ToBoolean(dtShow.Rows[i]["FontBold"]);
                        showInfo.Position = Convert.ToInt32(dtShow.Rows[i]["Position"]);
                        showInfo.Duration = Convert.ToInt32(dtShow.Rows[i]["Duration"]);
                        if (LEDShow.LedOpen(Convert.ToInt32(addressNum)))
                        {
                            //添加显示内容
                            LEDShow.AddText(addressNum, Convert.ToInt32(dtShow.Rows[i]["ScreenWidth"]), Convert.ToInt32(dtShow.Rows[i]["ScreenHeight"]),
                                dtShow.Rows[i]["Content"].ToString(), programInx, Convert.ToInt32(dtShow.Rows[i]["ShowStyle"]), dtShow.Rows[i]["FontName"].ToString(),
                                fontsize, 0x00FF, Convert.ToBoolean(dtShow.Rows[i]["FontBold"]),
                                Convert.ToInt32(dtShow.Rows[i]["Position"]));//最后0  左对齐 1居中 2右对齐
                            if (LEDShow.SendData(addressNum))//发送数据
                            {
                                showInfo.SendState = "开始显示成功";
                                ledShowInfo.UpdateLEDShowInfoState(Convert.ToInt32(dtShow.Rows[i]["ID"]), 2);//更新状态显示成功-已显示
                                ledShowInfo.InserScreenLog(showInfo);//发送成功日志记录
                            }
                            else
                            {
                                showInfo.SendState = "开始显示失败";
                                CurrentInfo.DataSendErro += dtShow.Rows[i]["ScreenId"].ToString() + ",";
                                ledShowInfo.UpdateLEDShowInfoState(Convert.ToInt32(dtShow.Rows[i]["ID"]), 1);//更新状态显示失败
                                ledShowInfo.InserScreenLog(showInfo);//发送失败日志记录
                            }
                        }
                        else
                        {
                            showInfo.SendState = "打开屏幕失败";
                            ledShowInfo.UpdateLEDShowInfoState(Convert.ToInt32(dtShow.Rows[i]["ID"]), 1);//更新状态显示失败
                            ledShowInfo.InserScreenLog(showInfo);//发送失败日志记录
                            continue;
                        }    
                    }
                    catch {
                        CurrentInfo.DataSendErro += dtShow.Rows[i]["ScreenId"].ToString()+",";
                        continue;
                    }
                }
                //到结束时间，停止显示
                DataTable dtOutShow = ledShowInfo.GetLEDShowInfos($@" and  Tag = 2  and  EndTime < CONVERT (CHAR(10), GETDATE(), 108)");
                for (int i = 0; i < dtOutShow.Rows.Count; i++)
                {
                    try
                    {
                        int addressNum = Convert.ToInt32(dtOutShow.Rows[i]["AddressNum"]);
                        LEDShowInfo showEndInfo = new LEDShowInfo();
                        showEndInfo.ScreenId = dtOutShow.Rows[i]["ScreenId"].ToString();
                        showEndInfo.AddressNum = Convert.ToInt32(dtOutShow.Rows[i]["AddressNum"]);
                        showEndInfo.BeginTime = dtOutShow.Rows[i]["BeginTime"].ToString();
                        showEndInfo.EndTime = dtOutShow.Rows[i]["EndTime"].ToString();
                        showEndInfo.Content = dtOutShow.Rows[i]["Content"].ToString();
                        showEndInfo.FontColor = dtOutShow.Rows[i]["FontColor"].ToString();
                        showEndInfo.FontName = dtOutShow.Rows[i]["FontName"].ToString();
                        showEndInfo.FontSize = Convert.ToInt32(dtOutShow.Rows[i]["FontSize"]);
                        showEndInfo.ShowStyle = Convert.ToInt32(dtOutShow.Rows[i]["ShowStyle"]);
                        showEndInfo.FontBold = Convert.ToBoolean(dtOutShow.Rows[i]["FontBold"]);
                        showEndInfo.Position = Convert.ToInt32(dtOutShow.Rows[i]["Position"]);
                        showEndInfo.Duration = Convert.ToInt32(dtOutShow.Rows[i]["Duration"]);
                        LEDShow.DeleteProgram(addressNum);
                        if (LEDShow.DeleteProgram(addressNum) && LEDShow.User_CloseScreen(addressNum))//删除现有显示 关屏
                        {
                            ledShowInfo.UpdateLEDShowInfoState(Convert.ToInt32(dtOutShow.Rows[i]["ID"]), 0);//更新状态
                            showEndInfo.SendState = "结束显示成功";
                            ledShowInfo.InserScreenLog(showEndInfo);//记录日志
                        }
                        else
                        {
                            showEndInfo.SendState = "结束显示失败";
                            ledShowInfo.InserScreenLog(showEndInfo);//记录日志
                        }
                    }
                    catch 
                    {
                        CurrentInfo.DataSendErro += dtOutShow.Rows[i]["ScreenId"].ToString() + ",";
                        continue;
                    }
                }
                lblError.Text ="显示失败："+ CurrentInfo.DataSendErro;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// LED参数查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmLEDSetingSearch_Click(object sender, EventArgs e)
        {
            FrmScreenSettingSearch frmScreenSettingSearch = new FrmScreenSettingSearch() { Dock = DockStyle.Fill, AutoSize = false, AutoScaleMode = AutoScaleMode.None };
            CreateNewPage(tsmLEDSetingSearch.Text, frmScreenSettingSearch);
        }
        /// <summary>
        /// 预设显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmPreShow_Click(object sender, EventArgs e)
        {
            FrmScreenShowLogSearch frmAreaSearch = new FrmScreenShowLogSearch() { Dock = DockStyle.Fill, AutoSize = false, AutoScaleMode = AutoScaleMode.None };
            CreateNewPage(tsmPreShow.Text, frmAreaSearch);
        }

        private void tsmOperateLED_Click(object sender, EventArgs e)
        {
            FrmOperateLED frmOperateLED = new FrmOperateLED();
            frmOperateLED.ShowDialog();
        }
    }
}
