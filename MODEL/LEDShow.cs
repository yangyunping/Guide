﻿using EQ2008_DataStruct;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODEL
{
    public class LEDShow
    {
        #region 引用
        //添加节目
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern int User_AddProgram(int CardNum, Boolean bWaitToEnd, int iPlayTime);
        //删除所有节目
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_DelAllProgram(int CardNum);
        //发送数据
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_SendToScreen(int CardNum);
        //开屏
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_OpenScreen(int CardNum);
        //关屏
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_CloseScreen(int CardNum);
        //添加单行文本区
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern int User_AddSingleText(int CardNum, ref User_SingleText pSingleText, int iProgramIndex);
        //添加文本区
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern int User_AddText(int CardNum, ref User_Text pText, int iProgramIndex);
        //校正时间
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_AdjustTime(int CardNum);
        //添加时间区
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern int User_AddTime(int CardNum, ref User_DateTime pdateTime, int iProgramIndex);
        //实时建立连接
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_RealtimeConnect(int CardNum);
        //实时发送文本
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_RealtimeSendText(int CardNum, int x, int y, int iWidth, int iHeight, string strText, ref User_FontSet pFontInfo);
        //实时关闭连接
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_RealtimeDisConnect(int CardNum);
        //实时发送清屏
        [DllImport("EQ2008_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern Boolean User_RealtimeScreenClear(int CardNum);
        #endregion

        public string showContent = string.Empty; //显示内容
        public static int g_iGreen = 0xFF00; //绿色
        public static int g_iYellow = 0xFFFF; //黄色
        public static int g_iRed = 0x00FF; //红色
        public static int g_FontSize =Convert.ToInt32(ConfigurationManager.AppSettings["LEDFontSize"]);
        /// <summary>
        /// 打开显示屏
        /// </summary>
        public static bool LedOpen(int cardNum)
        {
            if (User_OpenScreen(cardNum))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 关闭显示屏
        /// </summary>
        public void LedClose(int cardNum)
        {
            if (User_CloseScreen(cardNum))
            {
                MessageBox.Show(cardNum +"关闭显示屏成功！");
            }
            else
            {
                MessageBox.Show(cardNum + "关闭显示屏失败！");
            }
        }
        /// <summary>
        /// 添加节目
        /// </summary>
        /// <param name="cardNum">控制卡地址</param>
        /// 
        /// <param name="duraTion">播放时长 秒</param>
        public static int AddProgram(int cardNum, int duraTion)
        {
            return User_AddProgram(cardNum, false, duraTion);
        }
        /// <summary>
        /// 删除所有节目
        /// </summary>
        /// <param name="cardNum"></param>
        public static bool DeleteProgram(int cardNum)
        {
            return User_DelAllProgram(cardNum);
            //if (User_DelAllProgram(cardNum) == false)
            //{
            //    MessageBox.Show("删除节目失败！");
            //}
        }
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static bool SendData(int cardNum)
        {
            return User_SendToScreen(cardNum);
        }

        /// <summary>
        /// 添加显示内容
        /// </summary>
        /// <param name="cardNum">控制卡地址码</param>
        /// <param name="iWidth">屏幕宽</param>
        /// <param name="iHeight">屏幕高</param>
        /// <param name="content">显示内容</param>
        /// <param name="g_iProgramIndex">节目顺序</param>
        /// <param name="showType">播放方式</param>
        /// <param name="fontName">字体名称</param>
        /// <param name="fontSize">字体大小</param>
        /// <param name="fontColor">字体颜色</param>
        /// <param name="bFontBold">字体是否加粗</param>
        /// <param name="iAlignStyle">是否左右居中</param>
        /// <returns></returns>
        public static bool AddText(int cardNum,int iWidth, int iHeight, string content, int g_iProgramIndex,int showType, string fontName, int fontSize, int fontColor,bool bFontBold, int iAlignStyle)
        {
            User_Text areaTxt = new User_Text();
            areaTxt.BkColor = 0;
            areaTxt.chContent = content;
            areaTxt.PartInfo.iFrameMode = 0;
            areaTxt.PartInfo.iHeight = iHeight;
            areaTxt.PartInfo.iWidth = iWidth;
            areaTxt.PartInfo.iX = 0;
            areaTxt.PartInfo.iY = 0;
            areaTxt.FontInfo.iAlignStyle = iAlignStyle;
            areaTxt.FontInfo.iVAlignerStyle = 1;
            areaTxt.FontInfo.bFontBold = bFontBold;
            areaTxt.FontInfo.bFontItaic = false;
            areaTxt.FontInfo.bFontUnderline = false;
            areaTxt.FontInfo.colorFont = fontColor;
            areaTxt.FontInfo.iFontSize = fontSize;
            areaTxt.PartInfo.FrameColor = fontColor;
            areaTxt.FontInfo.strFontName = fontName; 
            areaTxt.MoveSet.bClear = false;
            areaTxt.MoveSet.iActionSpeed = Convert.ToInt32(ConfigurationManager.AppSettings["PlaySpeed"]);
            areaTxt.MoveSet.iActionType = showType;
            areaTxt.MoveSet.iHoldTime = 0;
            areaTxt.MoveSet.iClearActionType = 0;
            areaTxt.MoveSet.iClearSpeed = 0;
            areaTxt.MoveSet.iFrameTime = 20;
            if (-1 == User_AddText(cardNum, ref areaTxt, g_iProgramIndex))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 添加单行文本
        /// <param name="cardNum">控制卡地址码</param>
        /// <param name="iWidth">屏幕宽</param>
        /// <param name="iHeight">屏幕高</param>
        /// <param name="content">显示内容</param>
        /// <param name="g_iProgramIndex">节目顺序</param>
        /// <param name="showType">播放方式</param>
        /// <param name="fontName">字体名称</param>
        /// <param name="fontSize">字体大小</param>
        /// <param name="fontColor">字体颜色</param>
        /// <param name="bFontBold">字体是否加粗</param>
        /// <param name="iAlignStyle">是否左右居中</param>
        /// <returns></returns>
        public static bool AddSingleText(int cardNum, int iWidth, int iHeight, string content, int g_iProgramIndex, int showType, string fontName, int fontSize, int fontColor, bool bFontBold, int iAlignStyle)
        {
            User_SingleText SingleText = new User_SingleText();

            SingleText.BkColor = 0;
            SingleText.chContent = content;
            SingleText.PartInfo.iFrameMode = 0;
            SingleText.PartInfo.iHeight = iHeight;
            SingleText.PartInfo.iWidth = iWidth;
            SingleText.PartInfo.iX = 0;
            SingleText.PartInfo.iY = 0;
            SingleText.FontInfo.iAlignStyle = iAlignStyle;
            SingleText.FontInfo.iVAlignerStyle = 1;
            SingleText.FontInfo.bFontBold = bFontBold;
            SingleText.FontInfo.bFontItaic = false;
            SingleText.FontInfo.bFontUnderline = false;
            SingleText.FontInfo.colorFont = fontColor;
            SingleText.FontInfo.iFontSize = fontSize;
            SingleText.PartInfo.FrameColor = fontColor;
            SingleText.FontInfo.strFontName = fontName;
            SingleText.MoveSet.bClear = false;
            SingleText.MoveSet.iActionSpeed =Convert.ToInt32(ConfigurationManager.AppSettings["PlaySpeed"]);
            SingleText.MoveSet.iActionType = showType;
            SingleText.MoveSet.iHoldTime = 0;
            SingleText.MoveSet.iClearActionType = 0;
            SingleText.MoveSet.iClearSpeed = 0;
            SingleText.MoveSet.iFrameTime = 20;
            if (-1 == User_AddSingleText(cardNum, ref SingleText, g_iProgramIndex))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 校准时间
        /// </summary>
        public static bool CheckTime(int cardNum)
        {
            return User_AdjustTime(cardNum);
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        /// <param name="cardNum">控制卡地址码</param>
        /// <param name="g_iProgramIndex">节目号</param>
        /// <param name="date">是否显示日期</param>
        /// <param name="week">是否显示星期</param>
        /// <param name="time">是否显示时间</param>
        /// <param name="fontName">字体名称</param>
        /// <param name="fontSize">字体大小</param>
        /// <param name="fontColor">字体颜色</param>
        /// <returns></returns>
        public static bool AddDateTime(int cardNum, int g_iProgramIndex, bool date, bool week, bool time, string fontName, int fontSize, int fontColor, bool bMulOrSingleLine)
        {
            User_DateTime DateTime = new User_DateTime();
            DateTime.bDay = date;
            DateTime.bHour = time;
            DateTime.BkColor = 0;
            DateTime.bMin = time;
            DateTime.bMouth = date;
            DateTime.bMulOrSingleLine = bMulOrSingleLine;//单行 多行
            DateTime.bSec = time;
            DateTime.bWeek = week;
            DateTime.bYear = date;
            DateTime.bYearDisType = false;
            DateTime.chTitle = "";

            DateTime.PartInfo.iFrameMode = 1;
            DateTime.iDisplayType = 1;

            DateTime.PartInfo.FrameColor = fontColor;
            DateTime.PartInfo.iHeight = 32;
            DateTime.PartInfo.iWidth = 128;
            DateTime.PartInfo.iX = 0;
            DateTime.PartInfo.iY = 0;

            DateTime.FontInfo.bFontBold = false;
            DateTime.FontInfo.bFontItaic = false;
            DateTime.FontInfo.bFontUnderline = false;
            DateTime.FontInfo.colorFont = fontColor;
            DateTime.FontInfo.iAlignStyle = 1;
            DateTime.FontInfo.iVAlignerStyle = 1;
            DateTime.FontInfo.iFontSize = fontSize;
            DateTime.FontInfo.strFontName = fontName;

            if (-1 == User_AddTime(cardNum, ref DateTime, g_iProgramIndex))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 实时连接
        /// </summary>
        /// <param name="g_iCardNum"></param>
        public static void RealTimeConnect(int g_iCardNum)
        {
            if (!User_RealtimeConnect(g_iCardNum))
            {
                MessageBox.Show("连接实时通信失败！");
            }
            else
            {
                MessageBox.Show("连接实时通信成功！");
            }
        }
        /// <summary>
        /// 实时关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void RealTimeDisConnect(int g_iCardNum)
        {
            if (!User_RealtimeDisConnect(g_iCardNum))
            {
                MessageBox.Show("关闭实时通信失败！");
            }
            else
            {
                MessageBox.Show("关闭实时通信成功！");
            }
        }
        /// <summary>
        /// 实时发送文本内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RealtimeSendText(int g_iCardNum, string strText)
        {
            int iX = 0;
            int iY = 0;
            int iW = 128;
            int iH = 32;
            User_FontSet FontInfo = new User_FontSet();

            FontInfo.bFontBold = false;
            FontInfo.bFontItaic = false;
            FontInfo.bFontUnderline = false;
            FontInfo.colorFont = 0xFFFF;
            FontInfo.iFontSize = 12;
            FontInfo.strFontName = "宋体";
            FontInfo.iAlignStyle = 0;
            FontInfo.iVAlignerStyle = 0;
            FontInfo.iRowSpace = 0;

            if (!User_RealtimeSendText(g_iCardNum, iX, iY, iW, iH, strText, ref FontInfo))
            {
                MessageBox.Show("发送实时文本失败！");
            }
            else
            {
                MessageBox.Show("发送实时文本成功！");
            }
        }
        /// <summary>
        /// 清空显示屏原有节目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void RealtimeScreenClear(int g_iCardNum)
        {
            if (!User_RealtimeScreenClear(g_iCardNum))
            {
                MessageBox.Show("清空控制卡节目失败！");
            }
            else
            {
                MessageBox.Show("清空控制卡节目成功！");
            }
        }
    }
}
