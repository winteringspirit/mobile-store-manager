﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ChiTietHoaDonDatHang
    {
        public ChiTietHoaDonDatHang() 
        {
        }

        private String maHoaDonDatHang;
        public String MaHoaDonDatHang
        {
            get { return maHoaDonDatHang; }
            set { maHoaDonDatHang = value; }
        }

        private string maMatHang;

        public string MaMatHang
        {
            get { return maMatHang; }
            set { maMatHang = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private float giaNhap;

        public float GiaNhap
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        } 

        private String ghiChu;
        public String GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
    }
}
