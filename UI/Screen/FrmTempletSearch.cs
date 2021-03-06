﻿using BLL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;
using UI.LED;

namespace UI
{
    public partial class FrmTempletSearch : UserControl
    {
        BllTempletShow bllTempletShow = new BllTempletShow();
        public FrmTempletSearch()
        {
            InitializeComponent();
            DgvColumns();
            bntDelete.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.模板删除);
            btnModify.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.模板修改);
        }
        private void DgvColumns()
        {
            dgvTemShow.Columns.AddRange(
            new DataGridViewTextBoxColumn { Name = @"ID", HeaderText = @"编号", DataPropertyName = @"ID", Width = 60 },
            new DataGridViewTextBoxColumn { Name = @"ShowContent", HeaderText = @"播放内容", DataPropertyName = @"ShowContent", Width = 500 }
             );
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtShow = bllTempletShow.GetTempletShows(txtKey.Text.Trim());
            dgvTemShow.AutoGenerateColumns = false;
            dgvTemShow.DataSource = dtShow;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
          
            if (dgvTemShow.CurrentRow != null)
            {
                TempletShow templetShow = new TempletShow();
                templetShow.ID = Convert.ToInt32(dgvTemShow.CurrentRow.Cells["ID"].Value);
                templetShow.ShowContent = dgvTemShow.CurrentRow.Cells["ShowContent"].Value.ToString();
                FrmTempletLED frmTempletLED = new FrmTempletLED(templetShow);
                frmTempletLED.ShowDialog();
                btnSearch_Click(null,null);
            } 
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (dgvTemShow.CurrentRow != null)
            {
                if (bllTempletShow.DeleteTempletShow(Convert.ToInt32(dgvTemShow.CurrentRow.Cells["ID"].Value)))
                {
                    MessageBox.Show("删除成功！");
                    dgvTemShow.Rows.Remove(dgvTemShow.CurrentRow);
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void btnLEDShow_Click(object sender, EventArgs e)
        {
            if (dgvTemShow.CurrentRow != null)
            {
                FrmTempletSendLED frmTempletSendLED = new FrmTempletSendLED(dgvTemShow.CurrentRow.Cells["ShowContent"].Value.ToString());
                frmTempletSendLED.ShowDialog();
            }
        }
    }
}
