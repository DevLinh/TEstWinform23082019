using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    
    class SinhVien
    {
        Database db;

        public SinhVien()
        {
            db = new Database();
        }

        public DataTable GetAllSV()
        {
            string sql = "Select MaSV, HotenSV, NgaySinh, iif(GioiTinh=1, N'Nam', N'Nữ') as GioiTinh, HocBong, TenLop from SinhVien s, Lop l where s.MaLop = l.MaLop";
            DataTable dt = db.Excute(sql);
            return dt;
        }

        public DataTable GetAllLop()
        {
            string sql = "Select * from Lop";
            DataTable dt = db.Excute(sql);
            return dt;
        }

        public void DeleteSV( string index_sv)
        {
            string sql = string.Format("delete from SinhVien Where MaSV = '{0}'", index_sv);
            db.ExcuteNonQuery(sql);
        }

        public void AddSV(string ma, string hoten, string ngaysinh, bool gt, float hocbong, string malop)
        {
            string sql = string.Format("insert into SinhVien values ('{0}', N'{1}', '{2}', '{3}', {4}, '{5}')", ma, hoten, ngaysinh, gt, hocbong, malop);
            db.ExcuteNonQuery(sql);
        }

        public void UpdateSV(string ma, string hoten, string ngaysinh, bool gt, float hocbong, string malop)
        {
            string sql = string.Format("update SinhVien set HotenSV = N'{0}', NgaySinh = '{1}', GioiTinh = '{2}', HocBong = {3}, MaLop = '{4}' where MaSV = '{5}'", hoten, ngaysinh, gt, hocbong, malop, ma);
            db.ExcuteNonQuery(sql);
        }

    }
}
