using Core.Common;
using Core.DAL;
using MoreLinq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class ThongKe_DAL
    {
        Database<NhanVien> nhanvien = new Database<NhanVien>();
        Database<PhanCong> phancong = new Database<PhanCong>();
        Database<Tour> tour = new Database<Tour>();
        Database<ThoiGianDoan> thoigian_doan = new Database<ThoiGianDoan>();
        Database<Tour_Gia> tour_gia = new Database<Tour_Gia>();
        Database<Doan> doan = new Database<Doan>();
        Database<CTDoan> ct_doan = new Database<CTDoan>();
        Database<DangKi> dangki = new Database<DangKi>();

        

        // Thống kê số lần nhân viên đi tour trong khoảng tg
       
        public SoLanDiTourModel ThongKeSoLan_DiTour(DateTime bd, DateTime kt)
        {
            SoLanDiTourModel dsThongKe = new SoLanDiTourModel();
            dsThongKe.ListNhanVien = new List<NhanVien>();
            dsThongKe.ListDoanDaDi = new List<List<Doan>>();
            dsThongKe.SoLanDi = new List<int>();
            var dsNhanVien = nhanvien.GetMulti(x => x.TrangThai == true);
            foreach (var nv in dsNhanVien)
            {
                int soLanDi = 0;
                List<Doan> listDoanDaDi = new List<Doan>();

                dsThongKe.ListNhanVien.Add(nv);
                if (nv.PhanCongs.Count <= 0)
                {
                    dsThongKe.SoLanDi.Add(soLanDi);
                    dsThongKe.ListDoanDaDi.Add(listDoanDaDi);
                }
                else
                {
                    var dsPhanCong = phancong.GetMulti(x => x.MaNV == nv.MaNV);
                    foreach (var pc in dsPhanCong.DistinctBy(x => x.MaDoan))
                    {
                        var thoiGianDoan = thoigian_doan.GetSingleByCondition(x => x.MaDoan == pc.Doan.MaDoan);
                        if (thoiGianDoan.NgayDi.Value.Date >= bd.Date && thoiGianDoan.NgayVe.Value.Date <= kt.Date)
                        {
                            soLanDi++;
                            listDoanDaDi.Add(pc.Doan);
                        }
                    }
                    dsThongKe.SoLanDi.Add(soLanDi);
                    dsThongKe.ListDoanDaDi.Add(listDoanDaDi);
                }
            }
            return dsThongKe;
        }


        public TinhHinhHoatDongModel ThongKeTinhHinhHoatDong(DateTime bd, DateTime kt, int maTour)
        {
            TinhHinhHoatDongModel dsThongKe = new TinhHinhHoatDongModel();
            dsThongKe.DoanhThuTours = new List<double>();
            dsThongKe.DoanThamQuans = new List<string>();
            dsThongKe.LoiNhuans = new List<double>();
            dsThongKe.ThoiGianTours = new List<string>();
            var tourThongKe = tour.GetMulti(x => x.TrangThai == true, new string[] { "ThoiGianTours" }).ToArray()[maTour];


            foreach (var tg in tourThongKe.ThoiGianTours.Where(x => x.NgayDi.Value >= bd && x.NgayDi.Value <= kt))
            {
                int soDoanThamQuan = 0;
                double doanhThu = 0;
                // Tinh tong doanh thu cua 1 tour trong lich khoi hanh tuong ung
                double giaTour = tour_gia.GetMulti(x => x.MaTour == tourThongKe.MaTour && x.TGBD.Date <= bd  && x.TGKT.Date >= kt).OrderByDescending(x => x.MaTour).FirstOrDefault().Gia;
                int slKhachDangKy = dangki.GetMulti(x => x.MaThoiGian == tg.MaThoiGianTour).Count();
                doanhThu = giaTour * slKhachDangKy;

                // Lay so doan tham quan co tinh trang la da hoan thanh chuyen di
                var dsDoanThamQuan = doan.GetMulti(x => x.TinhTrang == 1);
                var dsctdoan = ct_doan.GetMulti(x => x.MaDoan == 1);
                soDoanThamQuan = dsDoanThamQuan.Count();
               
                // Tinh tong tien da chi trong chuyen di
                // Suy ra duoc loi nhuan bang doanhthu - tongtienALL
                double tongTatCa = 0;
                foreach (var ct_doan in dsctdoan)
                {
                    int tienAnUong = ct_doan.TongCPBA;
                    int tienKhachSan = ct_doan.TongCPKS;
                    int tienPhuongTien = ct_doan.TongCPPT;
                    //int tienPhatSinh = ct_doan.TongCPKhac;
                    tongTatCa = tienAnUong + tienKhachSan + tienPhuongTien;
                }

                string thoiGian = tg.NgayDi.Value.ToString("dd/MM/yyyy") + "-" + tg.NgayVe.Value.ToString("dd/MM/yyyy");
                string doanThamQuan = "Có " + soDoanThamQuan + " đoàn";
                dsThongKe.ThoiGianTours.Add(thoiGian);
                dsThongKe.DoanThamQuans.Add(doanThamQuan);
                dsThongKe.DoanhThuTours.Add(doanhThu);
                dsThongKe.LoiNhuans.Add(doanhThu - tongTatCa);
            }
            return dsThongKe;
        }
    }
}
