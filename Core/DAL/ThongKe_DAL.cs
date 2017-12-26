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

<<<<<<< HEAD
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
=======
           
            // Kiểm tra ngày đi phải lớn hơn ngày chọn bắt đầu và ngày về của đoàn phải nhỏ hơn ngày kết thúc.
            //var list = db.Doans.Select(x => new {x => }).ToList();
>>>>>>> 40ac28184ded5cd16c479530fa6d5f537ac86221


        public TinhHinhHoatDongModel ThongKeTinhHinhHoatDong(DateTime bd, DateTime kt, int maTour)
        {
            TinhHinhHoatDongModel dsThongKe = new TinhHinhHoatDongModel();
            dsThongKe.DoanhThuTours = new List<int>();
            dsThongKe.DoanThamQuans = new List<string>();
            dsThongKe.LoiNhuans = new List<int>();
            dsThongKe.ThoiGianTours = new List<string>();
            var tourThongKe = tour.GetSingleByCondition(x => x.TrangThai == true && x.MaTour == maTour, new string[] { "ThoiGianTours" });

            var tgTours = tourThongKe.ThoiGianTours.Where(x => x.NgayDi >= bd && x.NgayDi <= kt);
            foreach (var tg in tgTours)
            {
                int soDoanThamQuan = 0;
                int doanhThu = 0;
                // Tinh tong doanh thu cua 1 tour trong lich khoi hanh tuong ung
                int giaTour = tour_gia.GetMulti(x => x.MaTour == tourThongKe.MaTour && x.TGBD <= bd  && x.TGKT >= kt).OrderByDescending(x => x.MaTour).FirstOrDefault().Gia;
                int slKhachDangKy = dangki.GetMulti(x => x.MaThoiGian == tg.MaThoiGianTour).Count();
                doanhThu = giaTour * slKhachDangKy;

                // Lay so doan tham quan co tinh trang la da hoan thanh chuyen di
                var dsDoanThamQuan = doan.GetMulti(x => x.TinhTrang == 1);
              
                //var dsctdoan = ct_doan.GetMulti(x => x.MaDoan ==  );
                //soDoanThamQuan = dsDoanThamQuan.Count();
               
                // Tinh tong tien da chi trong chuyen di
                // Suy ra duoc loi nhuan bang doanhthu - tongtienALL
                int tongTatCa = 0;
                foreach (var doan in dsDoanThamQuan)
                {
                    doan.CTDoans.ToList().ForEach(ct => {
                        int tienAnUong = ct.TongCPBA;
                        int tienKhachSan = ct.TongCPKS;
                        int tienPhuongTien = ct.TongCPPT;
                        int tienPhatSinh = Convert.ToInt32(ct.TongCPKhac);
                        tongTatCa = tienAnUong + tienKhachSan + tienPhuongTien + tienPhatSinh;

                    });
                   

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
