﻿using Controller;
using Controller.Data;
using Controller.UserControls_Controller;
using Library.Entity;
using QLKS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UserControls
{
    public partial class UserControl_TKKH : UserControl
    {
        public UserControl_TKKH()
        {
            InitializeComponent();
        }
        private void UserControl_TKKH_Load(object sender, EventArgs e)
        {
            if(ViewData.Instance.GetKhachHangEdit() != null)
            {
                txt_MaKH.Text = ViewData.Instance.GetKhachHangEdit().MaKH;
                txt_TenKH.Text = ViewData.Instance.GetKhachHangEdit().TenKH;
                txt_SDT.Text = ViewData.Instance.GetKhachHangEdit().SDT;
                txt_Email.Text = ViewData.Instance.GetKhachHangEdit().Email;
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = txt_MaKH.Text;
            khachHang.TenKH= txt_TenKH.Text;
            khachHang.SDT = txt_SDT.Text;
            khachHang.Email = txt_Email.Text;
            if (ViewData.Instance.GetUpdate() == true)
            {
                if(UC_TKKH_Controller.Instance.UpdateKhachHang(khachHang, ViewData.Instance.GetKhachHangEdit()))
                {
                    DataGridViewRow gridViewRow = UserControl_DSKH.instance.dataGridView.SelectedCells[0].OwningRow;
                    if (gridViewRow == null) { }
                    else
                    {
                        UserControl_DSKH.instance.dataGridView.Rows.Remove(gridViewRow);
                        UserControl_DSKH.instance.dataGridView = Controls_Controller.Instance.AddDGV_KhachHang(UserControl_DSKH.instance.dataGridView, khachHang);
                    }
                }
            }
            else if(ViewData.Instance.GetAdd() == true)
            {
                if(UC_TKKH_Controller.Instance.UpdateKhachHang(khachHang, null))
                {
                    UserControl_DSKH.instance.dataGridView = Controls_Controller.Instance.AddDGV_KhachHang(UserControl_DSKH.instance.dataGridView, khachHang);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_SDT.Text = "";
            txt_Email.Text = "";
        }
    }
}