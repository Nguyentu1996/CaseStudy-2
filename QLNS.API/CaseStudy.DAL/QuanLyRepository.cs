using CaseStudy.DAL.Interface;
using CaseStudy.Domain.Request.QuanLy;
using CaseStudy.Domain.Response.QuanLy;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CaseStudy.DAL
{
    public class QuanLyRepository : BaseRepository, IQuanLyRepository
    {
        #region Diem Danh
        public IList<DiemDanh> LayDiemDanhBoPhanId(LayDiemDanhBoPhanId model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@QuanLyId", model.QuanLyId);
                parameters.Add("@Ngay", model.Ngay);
                IList<DiemDanh> list = SqlMapper.Query<DiemDanh>((SqlConnection)con, "sp_LayDiemDanhBoPhanId", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DiemDanh LayDiemDanhNhanVienId(LayDiemDanhNhanVienId model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@NhanVienId", model.NhanVienId);
                parameters.Add("@QuanLyId", model.QuanLyId);
                parameters.Add("@Ngay", model.Ngay);
                return SqlMapper.Query<DiemDanh>((SqlConnection)con, "sp_LayDiemDanhNhanVienId", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool TaoDiemDanh(TaoDiemDanh model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@NhanVienId", model.NhanVienId);
                parameters.Add("@QuanLyId", model.QuanLyId);
                parameters.Add("@TrangThai", model.TrangThai);
                parameters.Add("@Ngay", model.Ngay);
                SqlMapper.Execute((SqlConnection)con, "sp_TaoDiemDanh", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Thong Ke
        public IList<DiemDanh> LayDiemDanhNhanVienIdThang(LayDiemDanhNhanVienIdThang model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@NhanVienId", model.NhanVienId);
                parameters.Add("@QuanLyId", model.QuanLyId);
                parameters.Add("@Thang", model.Thang);
                parameters.Add("@Nam", model.Nam);
                IList<DiemDanh> list = SqlMapper.Query<DiemDanh>((SqlConnection)con, "sp_LayDiemDanhNhanVienIdThang", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<ThongKe> LayThongKeBoPhanId(LayThongKeBoPhanId model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@QuanLyId", model.QuanLyId);
                IList<ThongKe> list = SqlMapper.Query<ThongKe>((SqlConnection)con, "sp_LayThongKeBoPhanId", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<ThongKe> LayThongKeNhanVienId(LayThongKeNhanVienId model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@NhanVienId", model.NhanVienId);
                parameters.Add("@QuanLyId", model.QuanLyId);
                IList<ThongKe> list = SqlMapper.Query<ThongKe>((SqlConnection)con, "sp_LayThongKeNhanVienId", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Don Xin Phep
        public IList<DonXinPhep> LayDonXinPhepBoPhanId(LayDonXinPhepBoPhanId model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@QuanLyId", model.QuanLyId);
                IList<DonXinPhep> list = SqlMapper.Query<DonXinPhep>((SqlConnection)con, "sp_LayDonXinPhepBoPhanId", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DonXinPhep LayDonXinPhepNhanVienId(LayDonXinPhepNhanVienId model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@QuanLyId", model.QuanLyId);
                parameters.Add("@Id", model.Id);
                return SqlMapper.Query<DonXinPhep>((SqlConnection)con, "sp_LayDonXinPhepNhanVienId", param: parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Thong Tin
        public IList<ThongTin> LayThongTinBoPhanId(LayThongTinBoPhanId model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@QuanLyId", model.QuanLyId);
                IList<ThongTin> list = SqlMapper.Query<ThongTin>((SqlConnection)con, "sp_LayThongTinBoPhanId", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
