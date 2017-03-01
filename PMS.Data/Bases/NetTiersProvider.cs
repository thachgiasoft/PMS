#region Using directives

using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Configuration.Provider;

using PMS.Entities;

#endregion

namespace PMS.Data.Bases
{	
	///<summary>
	/// The base class to implements to create a .NetTiers provider.
	///</summary>
	public abstract class NetTiersProvider : NetTiersProviderBase
	{
		
		///<summary>
		/// Current DotChiTraProviderBase instance.
		///</summary>
		public virtual DotChiTraProviderBase DotChiTraProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PhanCongDoAnTotNghiepProviderBase instance.
		///</summary>
		public virtual PhanCongDoAnTotNghiepProviderBase PhanCongDoAnTotNghiepProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MonThucTapTotNghiepProviderBase instance.
		///</summary>
		public virtual MonThucTapTotNghiepProviderBase MonThucTapTotNghiepProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NoiDungDanhGiaProviderBase instance.
		///</summary>
		public virtual NoiDungDanhGiaProviderBase NoiDungDanhGiaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoCoiThiVhuexProviderBase instance.
		///</summary>
		public virtual ThuLaoCoiThiVhuexProviderBase ThuLaoCoiThiVhuexProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PhanNhomMonHocProviderBase instance.
		///</summary>
		public virtual PhanNhomMonHocProviderBase PhanNhomMonHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DanhMucNghienCuuKhoaHocProviderBase instance.
		///</summary>
		public virtual DanhMucNghienCuuKhoaHocProviderBase DanhMucNghienCuuKhoaHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MonHocTinhHeSoKhoiNganhProviderBase instance.
		///</summary>
		public virtual MonHocTinhHeSoKhoiNganhProviderBase MonHocTinhHeSoKhoiNganhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DonGiaMotTietProviderBase instance.
		///</summary>
		public virtual DonGiaMotTietProviderBase DonGiaMotTietProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NamHocProviderBase instance.
		///</summary>
		public virtual NamHocProviderBase NamHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DanhMucGioGiangProviderBase instance.
		///</summary>
		public virtual DanhMucGioGiangProviderBase DanhMucGioGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhPhanNhomMonHocProviderBase instance.
		///</summary>
		public virtual SdhPhanNhomMonHocProviderBase SdhPhanNhomMonHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CauHinhGiangVienPhanHoiProviderBase instance.
		///</summary>
		public virtual CauHinhGiangVienPhanHoiProviderBase CauHinhGiangVienPhanHoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MonXepLichChuNhatKhongTinhHeSoProviderBase instance.
		///</summary>
		public virtual MonXepLichChuNhatKhongTinhHeSoProviderBase MonXepLichChuNhatKhongTinhHeSoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DanhMucViPhamProviderBase instance.
		///</summary>
		public virtual DanhMucViPhamProviderBase DanhMucViPhamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongGiangDayCaoDangProviderBase instance.
		///</summary>
		public virtual KhoiLuongGiangDayCaoDangProviderBase KhoiLuongGiangDayCaoDangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TcbKetQuaQuyDoiProviderBase instance.
		///</summary>
		public virtual TcbKetQuaQuyDoiProviderBase TcbKetQuaQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DanhMucHoatDongQuanLyProviderBase instance.
		///</summary>
		public virtual DanhMucHoatDongQuanLyProviderBase DanhMucHoatDongQuanLyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current QuocTichProviderBase instance.
		///</summary>
		public virtual QuocTichProviderBase QuocTichProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TongTienLuongTrongNamCuaGiangVienProviderBase instance.
		///</summary>
		public virtual TongTienLuongTrongNamCuaGiangVienProviderBase TongTienLuongTrongNamCuaGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NhomChucNangProviderBase instance.
		///</summary>
		public virtual NhomChucNangProviderBase NhomChucNangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrinhDoQuanLyNhaNuocProviderBase instance.
		///</summary>
		public virtual TrinhDoQuanLyNhaNuocProviderBase TrinhDoQuanLyNhaNuocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current UteKhoiLuongGiangDayProviderBase instance.
		///</summary>
		public virtual UteKhoiLuongGiangDayProviderBase UteKhoiLuongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoChucDanhTietNghiaVuProviderBase instance.
		///</summary>
		public virtual HeSoChucDanhTietNghiaVuProviderBase HeSoChucDanhTietNghiaVuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VaiTroProviderBase instance.
		///</summary>
		public virtual VaiTroProviderBase VaiTroProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PhanBienLuanAnProviderBase instance.
		///</summary>
		public virtual PhanBienLuanAnProviderBase PhanBienLuanAnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current QuyUocDatTenLopHocPhanProviderBase instance.
		///</summary>
		public virtual QuyUocDatTenLopHocPhanProviderBase QuyUocDatTenLopHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PscExBarCodesProviderBase instance.
		///</summary>
		public virtual PscExBarCodesProviderBase PscExBarCodesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NamHocHienThiThuLaoLenWebProviderBase instance.
		///</summary>
		public virtual NamHocHienThiThuLaoLenWebProviderBase NamHocHienThiThuLaoLenWebProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PscDotThanhToanCoiThiChamThiProviderBase instance.
		///</summary>
		public virtual PscDotThanhToanCoiThiChamThiProviderBase PscDotThanhToanCoiThiChamThiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LopHocPhanGhepThoiKhoaBieuProviderBase instance.
		///</summary>
		public virtual LopHocPhanGhepThoiKhoaBieuProviderBase LopHocPhanGhepThoiKhoaBieuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LopChatLuongCaoProviderBase instance.
		///</summary>
		public virtual LopChatLuongCaoProviderBase LopChatLuongCaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NhomKhoiLuongProviderBase instance.
		///</summary>
		public virtual NhomKhoiLuongProviderBase NhomKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PhanLoaiGiangVienProviderBase instance.
		///</summary>
		public virtual PhanLoaiGiangVienProviderBase PhanLoaiGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongQuyDoiCaoDangProviderBase instance.
		///</summary>
		public virtual KhoiLuongQuyDoiCaoDangProviderBase KhoiLuongQuyDoiCaoDangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KetQuaThanhToanThuLaoProviderBase instance.
		///</summary>
		public virtual KetQuaThanhToanThuLaoProviderBase KetQuaThanhToanThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current QuyDoiGioChuanProviderBase instance.
		///</summary>
		public virtual QuyDoiGioChuanProviderBase QuyDoiGioChuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LopHocPhanChuyenNganhProviderBase instance.
		///</summary>
		public virtual LopHocPhanChuyenNganhProviderBase LopHocPhanChuyenNganhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KyTinhLuongProviderBase instance.
		///</summary>
		public virtual KyTinhLuongProviderBase KyTinhLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LyDoTamNghiProviderBase instance.
		///</summary>
		public virtual LyDoTamNghiProviderBase LyDoTamNghiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MonPhanCongNhieuGiangVienProviderBase instance.
		///</summary>
		public virtual MonPhanCongNhieuGiangVienProviderBase MonPhanCongNhieuGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ChotKhoiLuongGiangDayProviderBase instance.
		///</summary>
		public virtual ChotKhoiLuongGiangDayProviderBase ChotKhoiLuongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThueThuNhapCaNhanProviderBase instance.
		///</summary>
		public virtual ThueThuNhapCaNhanProviderBase ThueThuNhapCaNhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LoaiNghienCuuKhoaHocProviderBase instance.
		///</summary>
		public virtual LoaiNghienCuuKhoaHocProviderBase LoaiNghienCuuKhoaHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LoaiLopProviderBase instance.
		///</summary>
		public virtual LoaiLopProviderBase LoaiLopProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongQuyDoiProviderBase instance.
		///</summary>
		public virtual KhoiLuongQuyDoiProviderBase KhoiLuongQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LoaiGiangVienProviderBase instance.
		///</summary>
		public virtual LoaiGiangVienProviderBase LoaiGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienThanhToanQuaNganHangProviderBase instance.
		///</summary>
		public virtual GiangVienThanhToanQuaNganHangProviderBase GiangVienThanhToanQuaNganHangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongGiangDayDoAnTotNghiepProviderBase instance.
		///</summary>
		public virtual KhoiLuongGiangDayDoAnTotNghiepProviderBase KhoiLuongGiangDayDoAnTotNghiepProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqPhanNhomMonHocProviderBase instance.
		///</summary>
		public virtual KcqPhanNhomMonHocProviderBase KcqPhanNhomMonHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current QuyDinhTienCanTrenProviderBase instance.
		///</summary>
		public virtual QuyDinhTienCanTrenProviderBase QuyDinhTienCanTrenProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongTamUngProviderBase instance.
		///</summary>
		public virtual KhoiLuongTamUngProviderBase KhoiLuongTamUngProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NoiDungCongViecQuanLyProviderBase instance.
		///</summary>
		public virtual NoiDungCongViecQuanLyProviderBase NoiDungCongViecQuanLyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KyThiProviderBase instance.
		///</summary>
		public virtual KyThiProviderBase KyThiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LoaiKhoiLuongProviderBase instance.
		///</summary>
		public virtual LoaiKhoiLuongProviderBase LoaiKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TinhTrangTheoNamHocProviderBase instance.
		///</summary>
		public virtual TinhTrangTheoNamHocProviderBase TinhTrangTheoNamHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqPhanCongDoAnTotNghiepProviderBase instance.
		///</summary>
		public virtual KcqPhanCongDoAnTotNghiepProviderBase KcqPhanCongDoAnTotNghiepProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongGiangDayTungTuanProviderBase instance.
		///</summary>
		public virtual KhoiLuongGiangDayTungTuanProviderBase KhoiLuongGiangDayTungTuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MonTinhTheoQuyCheMoiProviderBase instance.
		///</summary>
		public virtual MonTinhTheoQuyCheMoiProviderBase MonTinhTheoQuyCheMoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LopHocPhanKhongTinhGioGiangProviderBase instance.
		///</summary>
		public virtual LopHocPhanKhongTinhGioGiangProviderBase LopHocPhanKhongTinhGioGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongHuongDanThucTapProviderBase instance.
		///</summary>
		public virtual KhoiLuongHuongDanThucTapProviderBase KhoiLuongHuongDanThucTapProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ChiTienThuLaoGiangDayProviderBase instance.
		///</summary>
		public virtual ChiTienThuLaoGiangDayProviderBase ChiTienThuLaoGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PhanQuyenControlTrenFormProviderBase instance.
		///</summary>
		public virtual PhanQuyenControlTrenFormProviderBase PhanQuyenControlTrenFormProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NhomHoatDongNgoaiGiangDayProviderBase instance.
		///</summary>
		public virtual NhomHoatDongNgoaiGiangDayProviderBase NhomHoatDongNgoaiGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MonHocKhongTinhKhoiLuongProviderBase instance.
		///</summary>
		public virtual MonHocKhongTinhKhoiLuongProviderBase MonHocKhongTinhKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoChamBaiProviderBase instance.
		///</summary>
		public virtual ThuLaoChamBaiProviderBase ThuLaoChamBaiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongDoAnTotNghiepChiTietProviderBase instance.
		///</summary>
		public virtual KhoiLuongDoAnTotNghiepChiTietProviderBase KhoiLuongDoAnTotNghiepChiTietProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ReportManagermentsProviderBase instance.
		///</summary>
		public virtual ReportManagermentsProviderBase ReportManagermentsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NgonNguGiangDayProviderBase instance.
		///</summary>
		public virtual NgonNguGiangDayProviderBase NgonNguGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThangHeProviderBase instance.
		///</summary>
		public virtual ThangHeProviderBase ThangHeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhLoaiKhoiLuongProviderBase instance.
		///</summary>
		public virtual SdhLoaiKhoiLuongProviderBase SdhLoaiKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SoTietCoiThiTieuChuanCuaGiangVienProviderBase instance.
		///</summary>
		public virtual SoTietCoiThiTieuChuanCuaGiangVienProviderBase SoTietCoiThiTieuChuanCuaGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhDonGiaProviderBase instance.
		///</summary>
		public virtual SdhDonGiaProviderBase SdhDonGiaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DonViTinhProviderBase instance.
		///</summary>
		public virtual DonViTinhProviderBase DonViTinhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThongTinGiangDayGiangVienProviderBase instance.
		///</summary>
		public virtual ThongTinGiangDayGiangVienProviderBase ThongTinGiangDayGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LopHocPhanBacDaoTaoProviderBase instance.
		///</summary>
		public virtual LopHocPhanBacDaoTaoProviderBase LopHocPhanBacDaoTaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PscUserConfigApplicationProviderBase instance.
		///</summary>
		public virtual PscUserConfigApplicationProviderBase PscUserConfigApplicationProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoTroCapTheoKhoaProviderBase instance.
		///</summary>
		public virtual HeSoTroCapTheoKhoaProviderBase HeSoTroCapTheoKhoaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongCacCongViecKhacProviderBase instance.
		///</summary>
		public virtual KhoiLuongCacCongViecKhacProviderBase KhoiLuongCacCongViecKhacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoImportProviderBase instance.
		///</summary>
		public virtual ThuLaoImportProviderBase ThuLaoImportProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongKhacProviderBase instance.
		///</summary>
		public virtual KhoiLuongKhacProviderBase KhoiLuongKhacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhNhomMonHocProviderBase instance.
		///</summary>
		public virtual SdhNhomMonHocProviderBase SdhNhomMonHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TietNghiaVuProviderBase instance.
		///</summary>
		public virtual TietNghiaVuProviderBase TietNghiaVuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhKetQuaThanhToanThuLaoProviderBase instance.
		///</summary>
		public virtual SdhKetQuaThanhToanThuLaoProviderBase SdhKetQuaThanhToanThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SiSoLopHocPhanProviderBase instance.
		///</summary>
		public virtual SiSoLopHocPhanProviderBase SiSoLopHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienTinhLuongThinhGiangProviderBase instance.
		///</summary>
		public virtual GiangVienTinhLuongThinhGiangProviderBase GiangVienTinhLuongThinhGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ReportTemplateProviderBase instance.
		///</summary>
		public virtual ReportTemplateProviderBase ReportTemplateProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThanhTraCoiThiProviderBase instance.
		///</summary>
		public virtual ThanhTraCoiThiProviderBase ThanhTraCoiThiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HopDongThinhGiangProviderBase instance.
		///</summary>
		public virtual HopDongThinhGiangProviderBase HopDongThinhGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoRaDeThiVhuexProviderBase instance.
		///</summary>
		public virtual ThuLaoRaDeThiVhuexProviderBase ThuLaoRaDeThiVhuexProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoGiangDayThucHanhProviderBase instance.
		///</summary>
		public virtual ThuLaoGiangDayThucHanhProviderBase ThuLaoGiangDayThucHanhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqHopDongThinhGiangProviderBase instance.
		///</summary>
		public virtual KcqHopDongThinhGiangProviderBase KcqHopDongThinhGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoQuyDoiGioTroiProviderBase instance.
		///</summary>
		public virtual HeSoQuyDoiGioTroiProviderBase HeSoQuyDoiGioTroiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current UteThanhToanThuLaoProviderBase instance.
		///</summary>
		public virtual UteThanhToanThuLaoProviderBase UteThanhToanThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienChoDuyetHoSoProviderBase instance.
		///</summary>
		public virtual GiangVienChoDuyetHoSoProviderBase GiangVienChoDuyetHoSoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqMonThucTapTotNghiepProviderBase instance.
		///</summary>
		public virtual KcqMonThucTapTotNghiepProviderBase KcqMonThucTapTotNghiepProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoThuLaoProviderBase instance.
		///</summary>
		public virtual HeSoThuLaoProviderBase HeSoThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoLuongProviderBase instance.
		///</summary>
		public virtual HeSoLuongProviderBase HeSoLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoanQuyDoiProviderBase instance.
		///</summary>
		public virtual KhoanQuyDoiProviderBase KhoanQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoRaDeVhuProviderBase instance.
		///</summary>
		public virtual ThuLaoRaDeVhuProviderBase ThuLaoRaDeVhuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KetQuaCacKhoanChiKhacProviderBase instance.
		///</summary>
		public virtual KetQuaCacKhoanChiKhacProviderBase KetQuaCacKhoanChiKhacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoHuongDanCuoiKhoaProviderBase instance.
		///</summary>
		public virtual ThuLaoHuongDanCuoiKhoaProviderBase ThuLaoHuongDanCuoiKhoaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoanChiKhacProviderBase instance.
		///</summary>
		public virtual KhoanChiKhacProviderBase KhoanChiKhacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThucGiangMonThucTeTuHocProviderBase instance.
		///</summary>
		public virtual ThucGiangMonThucTeTuHocProviderBase ThucGiangMonThucTeTuHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoGiangDayDaiHocLopClcProviderBase instance.
		///</summary>
		public virtual ThuLaoGiangDayDaiHocLopClcProviderBase ThuLaoGiangDayDaiHocLopClcProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KetQuaTinhProviderBase instance.
		///</summary>
		public virtual KetQuaTinhProviderBase KetQuaTinhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThoiGianGiangDayProviderBase instance.
		///</summary>
		public virtual ThoiGianGiangDayProviderBase ThoiGianGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienChuyenMonProviderBase instance.
		///</summary>
		public virtual GiangVienChuyenMonProviderBase GiangVienChuyenMonProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoVanHocTapProviderBase instance.
		///</summary>
		public virtual CoVanHocTapProviderBase CoVanHocTapProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThoiGianLamViecCuaNhanVienProviderBase instance.
		///</summary>
		public virtual ThoiGianLamViecCuaNhanVienProviderBase ThoiGianLamViecCuaNhanVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ChiTietKhoiLuongProviderBase instance.
		///</summary>
		public virtual ChiTietKhoiLuongProviderBase ChiTietKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current QuyDoiKhoiLuongTamUngProviderBase instance.
		///</summary>
		public virtual QuyDoiKhoiLuongTamUngProviderBase QuyDoiKhoiLuongTamUngProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current XetDuyetDeCuongLuanVanCaoHocProviderBase instance.
		///</summary>
		public virtual XetDuyetDeCuongLuanVanCaoHocProviderBase XetDuyetDeCuongLuanVanCaoHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TienCongTacPhiProviderBase instance.
		///</summary>
		public virtual TienCongTacPhiProviderBase TienCongTacPhiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoCoiThiVhuProviderBase instance.
		///</summary>
		public virtual ThuLaoCoiThiVhuProviderBase ThuLaoCoiThiVhuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoCoiThiChamBaiImportProviderBase instance.
		///</summary>
		public virtual ThuLaoCoiThiChamBaiImportProviderBase ThuLaoCoiThiChamBaiImportProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThanhTraGiangDayProviderBase instance.
		///</summary>
		public virtual ThanhTraGiangDayProviderBase ThanhTraGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqKhoiLuongKhacProviderBase instance.
		///</summary>
		public virtual KcqKhoiLuongKhacProviderBase KcqKhoiLuongKhacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienGiamTruDinhMucProviderBase instance.
		///</summary>
		public virtual GiangVienGiamTruDinhMucProviderBase GiangVienGiamTruDinhMucProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current BangPhuTroiNamHocProviderBase instance.
		///</summary>
		public virtual BangPhuTroiNamHocProviderBase BangPhuTroiNamHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongGiangDayProviderBase instance.
		///</summary>
		public virtual KhoiLuongGiangDayProviderBase KhoiLuongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TietNoKyTruocProviderBase instance.
		///</summary>
		public virtual TietNoKyTruocProviderBase TietNoKyTruocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienChucVuProviderBase instance.
		///</summary>
		public virtual GiangVienChucVuProviderBase GiangVienChucVuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoCoiThiProviderBase instance.
		///</summary>
		public virtual ThuLaoCoiThiProviderBase ThuLaoCoiThiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienNghienCuuKhProviderBase instance.
		///</summary>
		public virtual GiangVienNghienCuuKhProviderBase GiangVienNghienCuuKhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LopHocPhanGiangBangTiengNuocNgoaiProviderBase instance.
		///</summary>
		public virtual LopHocPhanGiangBangTiengNuocNgoaiProviderBase LopHocPhanGiangBangTiengNuocNgoaiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienCamKetKhongTruThueProviderBase instance.
		///</summary>
		public virtual GiangVienCamKetKhongTruThueProviderBase GiangVienCamKetKhongTruThueProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienHoSoProviderBase instance.
		///</summary>
		public virtual GiangVienHoSoProviderBase GiangVienHoSoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThanhToanThinhGiangProviderBase instance.
		///</summary>
		public virtual ThanhToanThinhGiangProviderBase ThanhToanThinhGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MonKhongTinhProviderBase instance.
		///</summary>
		public virtual MonKhongTinhProviderBase MonKhongTinhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhMonHocKhongTinhKhoiLuongProviderBase instance.
		///</summary>
		public virtual SdhMonHocKhongTinhKhoiLuongProviderBase SdhMonHocKhongTinhKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LopHocPhanClcAufCjlProviderBase instance.
		///</summary>
		public virtual LopHocPhanClcAufCjlProviderBase LopHocPhanClcAufCjlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PhuCapHanhChinhProviderBase instance.
		///</summary>
		public virtual PhuCapHanhChinhProviderBase PhuCapHanhChinhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThoiGianNghiTamThoiCuaGiangVienProviderBase instance.
		///</summary>
		public virtual ThoiGianNghiTamThoiCuaGiangVienProviderBase ThoiGianNghiTamThoiCuaGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhMonPhanCongNhieuGiangVienProviderBase instance.
		///</summary>
		public virtual SdhMonPhanCongNhieuGiangVienProviderBase SdhMonPhanCongNhieuGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienMocTangLuongProviderBase instance.
		///</summary>
		public virtual GiangVienMocTangLuongProviderBase GiangVienMocTangLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhPhanLoaiHocPhanProviderBase instance.
		///</summary>
		public virtual SdhPhanLoaiHocPhanProviderBase SdhPhanLoaiHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoThoaThuanProviderBase instance.
		///</summary>
		public virtual ThuLaoThoaThuanProviderBase ThuLaoThoaThuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KetQuaDanhGiaVuotGioProviderBase instance.
		///</summary>
		public virtual KetQuaDanhGiaVuotGioProviderBase KetQuaDanhGiaVuotGioProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhHeSoDiaDiemProviderBase instance.
		///</summary>
		public virtual SdhHeSoDiaDiemProviderBase SdhHeSoDiaDiemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current QuyDoiHoatDongNgoaiGiangDayProviderBase instance.
		///</summary>
		public virtual QuyDoiHoatDongNgoaiGiangDayProviderBase QuyDoiHoatDongNgoaiGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhChotKhoiLuongGiangDayProviderBase instance.
		///</summary>
		public virtual SdhChotKhoiLuongGiangDayProviderBase SdhChotKhoiLuongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienHoatDongQuanLyProviderBase instance.
		///</summary>
		public virtual GiangVienHoatDongQuanLyProviderBase GiangVienHoatDongQuanLyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThamDinhLuanVanThacSyProviderBase instance.
		///</summary>
		public virtual ThamDinhLuanVanThacSyProviderBase ThamDinhLuanVanThacSyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhUteKhoiLuongQuyDoiProviderBase instance.
		///</summary>
		public virtual SdhUteKhoiLuongQuyDoiProviderBase SdhUteKhoiLuongQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MonGiangMoiProviderBase instance.
		///</summary>
		public virtual MonGiangMoiProviderBase MonGiangMoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HocHamProviderBase instance.
		///</summary>
		public virtual HocHamProviderBase HocHamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqMonPhanCongNhieuGiangVienProviderBase instance.
		///</summary>
		public virtual KcqMonPhanCongNhieuGiangVienProviderBase KcqMonPhanCongNhieuGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqPhanBienLuanAnProviderBase instance.
		///</summary>
		public virtual KcqPhanBienLuanAnProviderBase KcqPhanBienLuanAnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqHeSoHocKyProviderBase instance.
		///</summary>
		public virtual KcqHeSoHocKyProviderBase KcqHeSoHocKyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoCoSoProviderBase instance.
		///</summary>
		public virtual HeSoCoSoProviderBase HeSoCoSoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienGiangDayGdtcQpProviderBase instance.
		///</summary>
		public virtual GiangVienGiangDayGdtcQpProviderBase GiangVienGiangDayGdtcQpProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DinhMucGioChuanProviderBase instance.
		///</summary>
		public virtual DinhMucGioChuanProviderBase DinhMucGioChuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DinhMucNghienCuuKhoaHocProviderBase instance.
		///</summary>
		public virtual DinhMucNghienCuuKhoaHocProviderBase DinhMucNghienCuuKhoaHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangDayChatLuongCaoProviderBase instance.
		///</summary>
		public virtual GiangDayChatLuongCaoProviderBase GiangDayChatLuongCaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DanhMucQuyMoProviderBase instance.
		///</summary>
		public virtual DanhMucQuyMoProviderBase DanhMucQuyMoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ChietTinhBoiDuongGiangDayProviderBase instance.
		///</summary>
		public virtual ChietTinhBoiDuongGiangDayProviderBase ChietTinhBoiDuongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DonGiaChamBaiProviderBase instance.
		///</summary>
		public virtual DonGiaChamBaiProviderBase DonGiaChamBaiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhUteKhoiLuongGiangDayProviderBase instance.
		///</summary>
		public virtual SdhUteKhoiLuongGiangDayProviderBase SdhUteKhoiLuongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqUteKhoiLuongGiangDayProviderBase instance.
		///</summary>
		public virtual KcqUteKhoiLuongGiangDayProviderBase KcqUteKhoiLuongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiamTruGioChuanProviderBase instance.
		///</summary>
		public virtual GiamTruGioChuanProviderBase GiamTruGioChuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhHeSoLopDongProviderBase instance.
		///</summary>
		public virtual SdhHeSoLopDongProviderBase SdhHeSoLopDongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoNgayProviderBase instance.
		///</summary>
		public virtual HeSoNgayProviderBase HeSoNgayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NhomMonHocProviderBase instance.
		///</summary>
		public virtual NhomMonHocProviderBase NhomMonHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DonGiaCoiThiProviderBase instance.
		///</summary>
		public virtual DonGiaCoiThiProviderBase DonGiaCoiThiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CongThucProviderBase instance.
		///</summary>
		public virtual CongThucProviderBase CongThucProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqCauHinhChotGioProviderBase instance.
		///</summary>
		public virtual KcqCauHinhChotGioProviderBase KcqCauHinhChotGioProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoThucTapProviderBase instance.
		///</summary>
		public virtual HeSoThucTapProviderBase HeSoThucTapProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienTamUngProviderBase instance.
		///</summary>
		public virtual GiangVienTamUngProviderBase GiangVienTamUngProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiamTruDinhMucProviderBase instance.
		///</summary>
		public virtual GiamTruDinhMucProviderBase GiamTruDinhMucProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DuTruGioGiangKhiCoLopHocPhanProviderBase instance.
		///</summary>
		public virtual DuTruGioGiangKhiCoLopHocPhanProviderBase DuTruGioGiangKhiCoLopHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienDinhMucKhauTruProviderBase instance.
		///</summary>
		public virtual GiangVienDinhMucKhauTruProviderBase GiangVienDinhMucKhauTruProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienBiChanTienProviderBase instance.
		///</summary>
		public virtual GiangVienBiChanTienProviderBase GiangVienBiChanTienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DinhMucHuongDanKhoaLuanThucTapProviderBase instance.
		///</summary>
		public virtual DinhMucHuongDanKhoaLuanThucTapProviderBase DinhMucHuongDanKhoaLuanThucTapProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangDaySauDaiHocProviderBase instance.
		///</summary>
		public virtual GiangDaySauDaiHocProviderBase GiangDaySauDaiHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienChuyenDoiGioGiangProviderBase instance.
		///</summary>
		public virtual GiangVienChuyenDoiGioGiangProviderBase GiangVienChuyenDoiGioGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoThamNienProviderBase instance.
		///</summary>
		public virtual HeSoThamNienProviderBase HeSoThamNienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienThayDoiChucVuProviderBase instance.
		///</summary>
		public virtual GiangVienThayDoiChucVuProviderBase GiangVienThayDoiChucVuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienTamUngChiTietProviderBase instance.
		///</summary>
		public virtual GiangVienTamUngChiTietProviderBase GiangVienTamUngChiTietProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqPhuCapHanhChinhProviderBase instance.
		///</summary>
		public virtual KcqPhuCapHanhChinhProviderBase KcqPhuCapHanhChinhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HoatDongNgoaiGiangDayProviderBase instance.
		///</summary>
		public virtual HoatDongNgoaiGiangDayProviderBase HoatDongNgoaiGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrinhDoSuPhamProviderBase instance.
		///</summary>
		public virtual TrinhDoSuPhamProviderBase TrinhDoSuPhamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoKhoiNganhProviderBase instance.
		///</summary>
		public virtual HeSoKhoiNganhProviderBase HeSoKhoiNganhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienKhongTinhGioGiangProviderBase instance.
		///</summary>
		public virtual GiangVienKhongTinhGioGiangProviderBase GiangVienKhongTinhGioGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DonGiaTcbProviderBase instance.
		///</summary>
		public virtual DonGiaTcbProviderBase DonGiaTcbProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NgachCongChucProviderBase instance.
		///</summary>
		public virtual NgachCongChucProviderBase NgachCongChucProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ChucNangProviderBase instance.
		///</summary>
		public virtual ChucNangProviderBase ChucNangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongGiangDayChiTietProviderBase instance.
		///</summary>
		public virtual KhoiLuongGiangDayChiTietProviderBase KhoiLuongGiangDayChiTietProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TinhTrangProviderBase instance.
		///</summary>
		public virtual TinhTrangProviderBase TinhTrangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienHoatDongNgoaiGiangDayProviderBase instance.
		///</summary>
		public virtual GiangVienHoatDongNgoaiGiangDayProviderBase GiangVienHoatDongNgoaiGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current BangPhuTroiGioDayGiangVienProviderBase instance.
		///</summary>
		public virtual BangPhuTroiGioDayGiangVienProviderBase BangPhuTroiGioDayGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MucDoHoanThanhNckhProviderBase instance.
		///</summary>
		public virtual MucDoHoanThanhNckhProviderBase MucDoHoanThanhNckhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NghienCuuKhoaHocProviderBase instance.
		///</summary>
		public virtual NghienCuuKhoaHocProviderBase NghienCuuKhoaHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqKhoiLuongGiangDayChiTietProviderBase instance.
		///</summary>
		public virtual KcqKhoiLuongGiangDayChiTietProviderBase KcqKhoiLuongGiangDayChiTietProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DanhSachHopDongThinhGiangProviderBase instance.
		///</summary>
		public virtual DanhSachHopDongThinhGiangProviderBase DanhSachHopDongThinhGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current BacLuongProviderBase instance.
		///</summary>
		public virtual BacLuongProviderBase BacLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienThayDoiLoaiGiangVienProviderBase instance.
		///</summary>
		public virtual GiangVienThayDoiLoaiGiangVienProviderBase GiangVienThayDoiLoaiGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CauHinhProviderBase instance.
		///</summary>
		public virtual CauHinhProviderBase CauHinhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HocViProviderBase instance.
		///</summary>
		public virtual HocViProviderBase HocViProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DonGiaNgoaiQuyCheProviderBase instance.
		///</summary>
		public virtual DonGiaNgoaiQuyCheProviderBase DonGiaNgoaiQuyCheProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MonHocCoNganHangDeThiProviderBase instance.
		///</summary>
		public virtual MonHocCoNganHangDeThiProviderBase MonHocCoNganHangDeThiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ChotCoVanHocTapProviderBase instance.
		///</summary>
		public virtual ChotCoVanHocTapProviderBase ChotCoVanHocTapProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NghienCuuKhoaHocTongHopProviderBase instance.
		///</summary>
		public virtual NghienCuuKhoaHocTongHopProviderBase NghienCuuKhoaHocTongHopProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DonGiaChatLuongCaoProviderBase instance.
		///</summary>
		public virtual DonGiaChatLuongCaoProviderBase DonGiaChatLuongCaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SdhUteThanhToanThuLaoProviderBase instance.
		///</summary>
		public virtual SdhUteThanhToanThuLaoProviderBase SdhUteThanhToanThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienPhanHoiProviderBase instance.
		///</summary>
		public virtual GiangVienPhanHoiProviderBase GiangVienPhanHoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CauHinhChungProviderBase instance.
		///</summary>
		public virtual CauHinhChungProviderBase CauHinhChungProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GhiChuThanhToanBoSungProviderBase instance.
		///</summary>
		public virtual GhiChuThanhToanBoSungProviderBase GhiChuThanhToanBoSungProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DanhGiaCoVanHocTapProviderBase instance.
		///</summary>
		public virtual DanhGiaCoVanHocTapProviderBase DanhGiaCoVanHocTapProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ChucVuProviderBase instance.
		///</summary>
		public virtual ChucVuProviderBase ChucVuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqUteThanhToanThuLaoProviderBase instance.
		///</summary>
		public virtual KcqUteThanhToanThuLaoProviderBase KcqUteThanhToanThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoChucDanhChuyenMonProviderBase instance.
		///</summary>
		public virtual HeSoChucDanhChuyenMonProviderBase HeSoChucDanhChuyenMonProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrinhDoTinHocProviderBase instance.
		///</summary>
		public virtual TrinhDoTinHocProviderBase TrinhDoTinHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NhomQuyenProviderBase instance.
		///</summary>
		public virtual NhomQuyenProviderBase NhomQuyenProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TaiKhoanProviderBase instance.
		///</summary>
		public virtual TaiKhoanProviderBase TaiKhoanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CauHinhChotGioProviderBase instance.
		///</summary>
		public virtual CauHinhChotGioProviderBase CauHinhChotGioProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienTinhGioChuanProviderBase instance.
		///</summary>
		public virtual GiangVienTinhGioChuanProviderBase GiangVienTinhGioChuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienLopHocPhanProviderBase instance.
		///</summary>
		public virtual GiangVienLopHocPhanProviderBase GiangVienLopHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeThongProviderBase instance.
		///</summary>
		public virtual HeThongProviderBase HeThongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqKhoiLuongDoAnTotNghiepChiTietProviderBase instance.
		///</summary>
		public virtual KcqKhoiLuongDoAnTotNghiepChiTietProviderBase KcqKhoiLuongDoAnTotNghiepChiTietProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrinhDoNgoaiNguProviderBase instance.
		///</summary>
		public virtual TrinhDoNgoaiNguProviderBase TrinhDoNgoaiNguProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoNhomMonProviderBase instance.
		///</summary>
		public virtual HeSoNhomMonProviderBase HeSoNhomMonProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoCoVanHocTapProviderBase instance.
		///</summary>
		public virtual HeSoCoVanHocTapProviderBase HeSoCoVanHocTapProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoQuyDoiGioChuanProviderBase instance.
		///</summary>
		public virtual HeSoQuyDoiGioChuanProviderBase HeSoQuyDoiGioChuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HistoryProviderBase instance.
		///</summary>
		public virtual HistoryProviderBase HistoryProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoBacDaoTaoProviderBase instance.
		///</summary>
		public virtual HeSoBacDaoTaoProviderBase HeSoBacDaoTaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqMonXepLichChuNhatKhongTinhHeSoProviderBase instance.
		///</summary>
		public virtual KcqMonXepLichChuNhatKhongTinhHeSoProviderBase KcqMonXepLichChuNhatKhongTinhHeSoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HoatDongChuyenMonKhacProviderBase instance.
		///</summary>
		public virtual HoatDongChuyenMonKhacProviderBase HoatDongChuyenMonKhacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqDonGiaProviderBase instance.
		///</summary>
		public virtual KcqDonGiaProviderBase KcqDonGiaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqNhomMonHocProviderBase instance.
		///</summary>
		public virtual KcqNhomMonHocProviderBase KcqNhomMonHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqUteKhoiLuongQuyDoiProviderBase instance.
		///</summary>
		public virtual KcqUteKhoiLuongQuyDoiProviderBase KcqUteKhoiLuongQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DinhMucGioChuanToiThieuTheoChucVuProviderBase instance.
		///</summary>
		public virtual DinhMucGioChuanToiThieuTheoChucVuProviderBase DinhMucGioChuanToiThieuTheoChucVuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LoaiNhanVienProviderBase instance.
		///</summary>
		public virtual LoaiNhanVienProviderBase LoaiNhanVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqKhoiLuongGiangDayDoAnTotNghiepProviderBase instance.
		///</summary>
		public virtual KcqKhoiLuongGiangDayDoAnTotNghiepProviderBase KcqKhoiLuongGiangDayDoAnTotNghiepProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThueThanhToanBoSungProviderBase instance.
		///</summary>
		public virtual ThueThanhToanBoSungProviderBase ThueThanhToanBoSungProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KetQuaTinhTheoTuanProviderBase instance.
		///</summary>
		public virtual KetQuaTinhTheoTuanProviderBase KetQuaTinhTheoTuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqUteKhoiLuongKhacProviderBase instance.
		///</summary>
		public virtual KcqUteKhoiLuongKhacProviderBase KcqUteKhoiLuongKhacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KhoiLuongGiangDayDoAnProviderBase instance.
		///</summary>
		public virtual KhoiLuongGiangDayDoAnProviderBase KhoiLuongGiangDayDoAnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqLoaiKhoiLuongProviderBase instance.
		///</summary>
		public virtual KcqLoaiKhoiLuongProviderBase KcqLoaiKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienProviderBase instance.
		///</summary>
		public virtual GiangVienProviderBase GiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThanhTraChamGiangTheoKhoaHocProviderBase instance.
		///</summary>
		public virtual ThanhTraChamGiangTheoKhoaHocProviderBase ThanhTraChamGiangTheoKhoaHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SoTietNckhChuyenSangNamSauProviderBase instance.
		///</summary>
		public virtual SoTietNckhChuyenSangNamSauProviderBase SoTietNckhChuyenSangNamSauProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqQuyDoiGioChuanProviderBase instance.
		///</summary>
		public virtual KcqQuyDoiGioChuanProviderBase KcqQuyDoiGioChuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienThayDoiHocViProviderBase instance.
		///</summary>
		public virtual GiangVienThayDoiHocViProviderBase GiangVienThayDoiHocViProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqChotKhoiLuongGiangDayProviderBase instance.
		///</summary>
		public virtual KcqChotKhoiLuongGiangDayProviderBase KcqChotKhoiLuongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HoatDongNgoaiGiangDayClcProviderBase instance.
		///</summary>
		public virtual HoatDongNgoaiGiangDayClcProviderBase HoatDongNgoaiGiangDayClcProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PhanLoaiHocPhanProviderBase instance.
		///</summary>
		public virtual PhanLoaiHocPhanProviderBase PhanLoaiHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DuTruGioGiangTruocThoiKhoaBieuProviderBase instance.
		///</summary>
		public virtual DuTruGioGiangTruocThoiKhoaBieuProviderBase DuTruGioGiangTruocThoiKhoaBieuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqHeSoQuyDoiTinChiProviderBase instance.
		///</summary>
		public virtual KcqHeSoQuyDoiTinChiProviderBase KcqHeSoQuyDoiTinChiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GiangVienThayDoiHocHamProviderBase instance.
		///</summary>
		public virtual GiangVienThayDoiHocHamProviderBase GiangVienThayDoiHocHamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrinhDoChinhTriProviderBase instance.
		///</summary>
		public virtual TrinhDoChinhTriProviderBase TrinhDoChinhTriProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current QuyMoKhoaProviderBase instance.
		///</summary>
		public virtual QuyMoKhoaProviderBase QuyMoKhoaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DonGiaProviderBase instance.
		///</summary>
		public virtual DonGiaProviderBase DonGiaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoKhoiLuongCongThemProviderBase instance.
		///</summary>
		public virtual HeSoKhoiLuongCongThemProviderBase HeSoKhoiLuongCongThemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqKetQuaThanhToanThuLaoProviderBase instance.
		///</summary>
		public virtual KcqKetQuaThanhToanThuLaoProviderBase KcqKetQuaThanhToanThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuMoiGiangHopDongThinhGiangProviderBase instance.
		///</summary>
		public virtual ThuMoiGiangHopDongThinhGiangProviderBase ThuMoiGiangHopDongThinhGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoLopDongProviderBase instance.
		///</summary>
		public virtual HeSoLopDongProviderBase HeSoLopDongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoNgoaiGioProviderBase instance.
		///</summary>
		public virtual HeSoNgoaiGioProviderBase HeSoNgoaiGioProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current UteKhoiLuongKhacProviderBase instance.
		///</summary>
		public virtual UteKhoiLuongKhacProviderBase UteKhoiLuongKhacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqHeSoDiaDiemProviderBase instance.
		///</summary>
		public virtual KcqHeSoDiaDiemProviderBase KcqHeSoDiaDiemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HinhThucDaoTaoProviderBase instance.
		///</summary>
		public virtual HinhThucDaoTaoProviderBase HinhThucDaoTaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoThanhToanGioChuanVuotMucProviderBase instance.
		///</summary>
		public virtual HeSoThanhToanGioChuanVuotMucProviderBase HeSoThanhToanGioChuanVuotMucProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoCongViecProviderBase instance.
		///</summary>
		public virtual HeSoCongViecProviderBase HeSoCongViecProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqKhoiLuongThucTapCuoiKhoaProviderBase instance.
		///</summary>
		public virtual KcqKhoiLuongThucTapCuoiKhoaProviderBase KcqKhoiLuongThucTapCuoiKhoaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HoSoProviderBase instance.
		///</summary>
		public virtual HoSoProviderBase HoSoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HuongDanKhoaLuanThucTapProviderBase instance.
		///</summary>
		public virtual HuongDanKhoaLuanThucTapProviderBase HuongDanKhoaLuanThucTapProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DuTruGioGiangTruocLopHocPhanProviderBase instance.
		///</summary>
		public virtual DuTruGioGiangTruocLopHocPhanProviderBase DuTruGioGiangTruocLopHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqHeSoCoSoProviderBase instance.
		///</summary>
		public virtual KcqHeSoCoSoProviderBase KcqHeSoCoSoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqPhanLoaiHocPhanProviderBase instance.
		///</summary>
		public virtual KcqPhanLoaiHocPhanProviderBase KcqPhanLoaiHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoChucDanhKhoiLuongKhacProviderBase instance.
		///</summary>
		public virtual HeSoChucDanhKhoiLuongKhacProviderBase HeSoChucDanhKhoiLuongKhacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqKhoanQuyDoiProviderBase instance.
		///</summary>
		public virtual KcqKhoanQuyDoiProviderBase KcqKhoanQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqMonHocKhongTinhKhoiLuongProviderBase instance.
		///</summary>
		public virtual KcqMonHocKhongTinhKhoiLuongProviderBase KcqMonHocKhongTinhKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoQuyDoiTinChiProviderBase instance.
		///</summary>
		public virtual HeSoQuyDoiTinChiProviderBase HeSoQuyDoiTinChiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoNgonNguProviderBase instance.
		///</summary>
		public virtual HeSoNgonNguProviderBase HeSoNgonNguProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoHocKyProviderBase instance.
		///</summary>
		public virtual HeSoHocKyProviderBase HeSoHocKyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoTinChiProviderBase instance.
		///</summary>
		public virtual HeSoTinChiProviderBase HeSoTinChiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqKhoiLuongGiangDayDoAnProviderBase instance.
		///</summary>
		public virtual KcqKhoiLuongGiangDayDoAnProviderBase KcqKhoiLuongGiangDayDoAnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current UteKhoiLuongQuyDoiProviderBase instance.
		///</summary>
		public virtual UteKhoiLuongQuyDoiProviderBase UteKhoiLuongQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqNhomKhoiLuongProviderBase instance.
		///</summary>
		public virtual KcqNhomKhoiLuongProviderBase KcqNhomKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoChamThiVhuexProviderBase instance.
		///</summary>
		public virtual ThuLaoChamThiVhuexProviderBase ThuLaoChamThiVhuexProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqMonTieuLuanProviderBase instance.
		///</summary>
		public virtual KcqMonTieuLuanProviderBase KcqMonTieuLuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqDonGiaNgoaiQuyCheProviderBase instance.
		///</summary>
		public virtual KcqDonGiaNgoaiQuyCheProviderBase KcqDonGiaNgoaiQuyCheProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThuLaoChamBaiVhuProviderBase instance.
		///</summary>
		public virtual ThuLaoChamBaiVhuProviderBase ThuLaoChamBaiVhuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KcqMonTinhTheoQuyCheMoiProviderBase instance.
		///</summary>
		public virtual KcqMonTinhTheoQuyCheMoiProviderBase KcqMonTinhTheoQuyCheMoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoThoiGianGiangDayProviderBase instance.
		///</summary>
		public virtual HeSoThoiGianGiangDayProviderBase HeSoThoiGianGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HeSoNhomThucHanhProviderBase instance.
		///</summary>
		public virtual HeSoNhomThucHanhProviderBase HeSoNhomThucHanhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MonTieuLuanProviderBase instance.
		///</summary>
		public virtual MonTieuLuanProviderBase MonTieuLuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ThanhTraTheoThoiKhoaBieuProviderBase instance.
		///</summary>
		public virtual ThanhTraTheoThoiKhoaBieuProviderBase ThanhTraTheoThoiKhoaBieuProvider{get {throw new NotImplementedException();}}
		
		
		///<summary>
		/// Current VChiTietKhoiLuongProviderBase instance.
		///</summary>
		public virtual VChiTietKhoiLuongProviderBase VChiTietKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VChiTietKhoiLuongThucDayProviderBase instance.
		///</summary>
		public virtual VChiTietKhoiLuongThucDayProviderBase VChiTietKhoiLuongThucDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VChiTietQuyDoiProviderBase instance.
		///</summary>
		public virtual VChiTietQuyDoiProviderBase VChiTietQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VGiangVienChucVuProviderBase instance.
		///</summary>
		public virtual VGiangVienChucVuProviderBase VGiangVienChucVuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VKhoiLuongThucDayProviderBase instance.
		///</summary>
		public virtual VKhoiLuongThucDayProviderBase VKhoiLuongThucDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VLopHocPhanKhongPhanCongProviderBase instance.
		///</summary>
		public virtual VLopHocPhanKhongPhanCongProviderBase VLopHocPhanKhongPhanCongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VMonHocTinChiProviderBase instance.
		///</summary>
		public virtual VMonHocTinChiProviderBase VMonHocTinChiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VThanhToanThuLaoProviderBase instance.
		///</summary>
		public virtual VThanhToanThuLaoProviderBase VThanhToanThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VTongHopKhoiLuongProviderBase instance.
		///</summary>
		public virtual VTongHopKhoiLuongProviderBase VTongHopKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VTongHopQuyDoiProviderBase instance.
		///</summary>
		public virtual VTongHopQuyDoiProviderBase VTongHopQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VTongHopThuLaoProviderBase instance.
		///</summary>
		public virtual VTongHopThuLaoProviderBase VTongHopThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewBacDaoTaoProviderBase instance.
		///</summary>
		public virtual ViewBacDaoTaoProviderBase ViewBacDaoTaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewBacDaoTaoLoaiHinhProviderBase instance.
		///</summary>
		public virtual ViewBacDaoTaoLoaiHinhProviderBase ViewBacDaoTaoLoaiHinhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewBangPhuTroiGioDayGiangVienProviderBase instance.
		///</summary>
		public virtual ViewBangPhuTroiGioDayGiangVienProviderBase ViewBangPhuTroiGioDayGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewBuoiProviderBase instance.
		///</summary>
		public virtual ViewBuoiProviderBase ViewBuoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewCauHinhProviderBase instance.
		///</summary>
		public virtual ViewCauHinhProviderBase ViewCauHinhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewChiTienCoVanProviderBase instance.
		///</summary>
		public virtual ViewChiTienCoVanProviderBase ViewChiTienCoVanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewChiTietGiangDayProviderBase instance.
		///</summary>
		public virtual ViewChiTietGiangDayProviderBase ViewChiTietGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewChiTietHocPhanProviderBase instance.
		///</summary>
		public virtual ViewChiTietHocPhanProviderBase ViewChiTietHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewChiTietKhoiLuongProviderBase instance.
		///</summary>
		public virtual ViewChiTietKhoiLuongProviderBase ViewChiTietKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewChiTietKhoiLuongGiangDayProviderBase instance.
		///</summary>
		public virtual ViewChiTietKhoiLuongGiangDayProviderBase ViewChiTietKhoiLuongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewChiTietKhoiLuongThucDayProviderBase instance.
		///</summary>
		public virtual ViewChiTietKhoiLuongThucDayProviderBase ViewChiTietKhoiLuongThucDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewChiTietPhanCongGiangDayProviderBase instance.
		///</summary>
		public virtual ViewChiTietPhanCongGiangDayProviderBase ViewChiTietPhanCongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewChiTietQuyDoiProviderBase instance.
		///</summary>
		public virtual ViewChiTietQuyDoiProviderBase ViewChiTietQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewCoSoProviderBase instance.
		///</summary>
		public virtual ViewCoSoProviderBase ViewCoSoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewCoVanHocTapProviderBase instance.
		///</summary>
		public virtual ViewCoVanHocTapProviderBase ViewCoVanHocTapProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewDanhSachHopDongThinhGiangProviderBase instance.
		///</summary>
		public virtual ViewDanhSachHopDongThinhGiangProviderBase ViewDanhSachHopDongThinhGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewDanhSachLopPhanCongGiangDayProviderBase instance.
		///</summary>
		public virtual ViewDanhSachLopPhanCongGiangDayProviderBase ViewDanhSachLopPhanCongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewDanTocProviderBase instance.
		///</summary>
		public virtual ViewDanTocProviderBase ViewDanTocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewDoiTuongDonGiaProviderBase instance.
		///</summary>
		public virtual ViewDoiTuongDonGiaProviderBase ViewDoiTuongDonGiaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewDonGiaNgoaiQuyCheProviderBase instance.
		///</summary>
		public virtual ViewDonGiaNgoaiQuyCheProviderBase ViewDonGiaNgoaiQuyCheProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewDonViProviderBase instance.
		///</summary>
		public virtual ViewDonViProviderBase ViewDonViProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewGiamTruGioChuanProviderBase instance.
		///</summary>
		public virtual ViewGiamTruGioChuanProviderBase ViewGiamTruGioChuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewGiangVienProviderBase instance.
		///</summary>
		public virtual ViewGiangVienProviderBase ViewGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewGiangVienKhoaProviderBase instance.
		///</summary>
		public virtual ViewGiangVienKhoaProviderBase ViewGiangVienKhoaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewGiangVienLopHocPhanProviderBase instance.
		///</summary>
		public virtual ViewGiangVienLopHocPhanProviderBase ViewGiangVienLopHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewGiangVienNckhProviderBase instance.
		///</summary>
		public virtual ViewGiangVienNckhProviderBase ViewGiangVienNckhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewGiangVienNghienCuuKhoaHocProviderBase instance.
		///</summary>
		public virtual ViewGiangVienNghienCuuKhoaHocProviderBase ViewGiangVienNghienCuuKhoaHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewHeDaoTaoProviderBase instance.
		///</summary>
		public virtual ViewHeDaoTaoProviderBase ViewHeDaoTaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewHeSoLopDongHbuProviderBase instance.
		///</summary>
		public virtual ViewHeSoLopDongHbuProviderBase ViewHeSoLopDongHbuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewHeSoLuongHocHamHocViProviderBase instance.
		///</summary>
		public virtual ViewHeSoLuongHocHamHocViProviderBase ViewHeSoLuongHocHamHocViProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewHesoThuLaoProviderBase instance.
		///</summary>
		public virtual ViewHesoThuLaoProviderBase ViewHesoThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewHeSoTinChiProviderBase instance.
		///</summary>
		public virtual ViewHeSoTinChiProviderBase ViewHeSoTinChiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewHinhThucThiProviderBase instance.
		///</summary>
		public virtual ViewHinhThucThiProviderBase ViewHinhThucThiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewHinhThucViPhamProviderBase instance.
		///</summary>
		public virtual ViewHinhThucViPhamProviderBase ViewHinhThucViPhamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewHocKyProviderBase instance.
		///</summary>
		public virtual ViewHocKyProviderBase ViewHocKyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewHocPhanMonHocProviderBase instance.
		///</summary>
		public virtual ViewHocPhanMonHocProviderBase ViewHocPhanMonHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewHopDongThinhGiangProviderBase instance.
		///</summary>
		public virtual ViewHopDongThinhGiangProviderBase ViewHopDongThinhGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKcqDonGiaNgoaiQuyCheProviderBase instance.
		///</summary>
		public virtual ViewKcqDonGiaNgoaiQuyCheProviderBase ViewKcqDonGiaNgoaiQuyCheProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKcqHopDongThinhGiangProviderBase instance.
		///</summary>
		public virtual ViewKcqHopDongThinhGiangProviderBase ViewKcqHopDongThinhGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKcqKetQuaThanhToanThuLaoProviderBase instance.
		///</summary>
		public virtual ViewKcqKetQuaThanhToanThuLaoProviderBase ViewKcqKetQuaThanhToanThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKcqLietKeKhoiLuongGiangDayChiTiet2ProviderBase instance.
		///</summary>
		public virtual ViewKcqLietKeKhoiLuongGiangDayChiTiet2ProviderBase ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKcqMonThucTapTotNghiepProviderBase instance.
		///</summary>
		public virtual ViewKcqMonThucTapTotNghiepProviderBase ViewKcqMonThucTapTotNghiepProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKcqMonTinhTheoQuyCheMoiProviderBase instance.
		///</summary>
		public virtual ViewKcqMonTinhTheoQuyCheMoiProviderBase ViewKcqMonTinhTheoQuyCheMoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKcqMonXepLichChuNhatKhongTinhHeSoProviderBase instance.
		///</summary>
		public virtual ViewKcqMonXepLichChuNhatKhongTinhHeSoProviderBase ViewKcqMonXepLichChuNhatKhongTinhHeSoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKcqPhanNhomMonHocProviderBase instance.
		///</summary>
		public virtual ViewKcqPhanNhomMonHocProviderBase ViewKcqPhanNhomMonHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKcqPhanNhomMonHocActProviderBase instance.
		///</summary>
		public virtual ViewKcqPhanNhomMonHocActProviderBase ViewKcqPhanNhomMonHocActProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKcqPhuCapHanhChinhProviderBase instance.
		///</summary>
		public virtual ViewKcqPhuCapHanhChinhProviderBase ViewKcqPhuCapHanhChinhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKcqUteKhoiLuongGiangDayProviderBase instance.
		///</summary>
		public virtual ViewKcqUteKhoiLuongGiangDayProviderBase ViewKcqUteKhoiLuongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKcqUteKhoiLuongQuyDoi2ProviderBase instance.
		///</summary>
		public virtual ViewKcqUteKhoiLuongQuyDoi2ProviderBase ViewKcqUteKhoiLuongQuyDoi2Provider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKetQuaCacKhoanChiKhacProviderBase instance.
		///</summary>
		public virtual ViewKetQuaCacKhoanChiKhacProviderBase ViewKetQuaCacKhoanChiKhacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKetQuaThanhToanThuLaoProviderBase instance.
		///</summary>
		public virtual ViewKetQuaThanhToanThuLaoProviderBase ViewKetQuaThanhToanThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKetQuaTinhProviderBase instance.
		///</summary>
		public virtual ViewKetQuaTinhProviderBase ViewKetQuaTinhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKhoaProviderBase instance.
		///</summary>
		public virtual ViewKhoaProviderBase ViewKhoaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKhoaBoMonProviderBase instance.
		///</summary>
		public virtual ViewKhoaBoMonProviderBase ViewKhoaBoMonProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKhoaHocProviderBase instance.
		///</summary>
		public virtual ViewKhoaHocProviderBase ViewKhoaHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKhoaHocBacHeProviderBase instance.
		///</summary>
		public virtual ViewKhoaHocBacHeProviderBase ViewKhoaHocBacHeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKhoiLuongGiangDayProviderBase instance.
		///</summary>
		public virtual ViewKhoiLuongGiangDayProviderBase ViewKhoiLuongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKhoiLuongGiangDayCanBoProviderBase instance.
		///</summary>
		public virtual ViewKhoiLuongGiangDayCanBoProviderBase ViewKhoiLuongGiangDayCanBoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKhoiLuongThucDayProviderBase instance.
		///</summary>
		public virtual ViewKhoiLuongThucDayProviderBase ViewKhoiLuongThucDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKhoiLuongCacCongViecKhacProviderBase instance.
		///</summary>
		public virtual ViewKhoiLuongCacCongViecKhacProviderBase ViewKhoiLuongCacCongViecKhacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewKyThiProviderBase instance.
		///</summary>
		public virtual ViewKyThiProviderBase ViewKyThiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLietKeKhoiLuongGiangDayChiTietProviderBase instance.
		///</summary>
		public virtual ViewLietKeKhoiLuongGiangDayChiTietProviderBase ViewLietKeKhoiLuongGiangDayChiTietProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLietKeKhoiLuongGiangDayChiTietUsshProviderBase instance.
		///</summary>
		public virtual ViewLietKeKhoiLuongGiangDayChiTietUsshProviderBase ViewLietKeKhoiLuongGiangDayChiTietUsshProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProviderBase instance.
		///</summary>
		public virtual ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProviderBase ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLietKeKhoiLuongGiangDayChiTiet2ProviderBase instance.
		///</summary>
		public virtual ViewLietKeKhoiLuongGiangDayChiTiet2ProviderBase ViewLietKeKhoiLuongGiangDayChiTiet2Provider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLoaiHinhDaoTaoProviderBase instance.
		///</summary>
		public virtual ViewLoaiHinhDaoTaoProviderBase ViewLoaiHinhDaoTaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLoaiHocPhanProviderBase instance.
		///</summary>
		public virtual ViewLoaiHocPhanProviderBase ViewLoaiHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLopProviderBase instance.
		///</summary>
		public virtual ViewLopProviderBase ViewLopProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLopChatLuongCaoProviderBase instance.
		///</summary>
		public virtual ViewLopChatLuongCaoProviderBase ViewLopChatLuongCaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLopHocPhanProviderBase instance.
		///</summary>
		public virtual ViewLopHocPhanProviderBase ViewLopHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLopHocPhanClcAufCjlProviderBase instance.
		///</summary>
		public virtual ViewLopHocPhanClcAufCjlProviderBase ViewLopHocPhanClcAufCjlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLopHocPhanChuyenNganhProviderBase instance.
		///</summary>
		public virtual ViewLopHocPhanChuyenNganhProviderBase ViewLopHocPhanChuyenNganhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLopHocPhanGiangBangTiengNuocNgoaiProviderBase instance.
		///</summary>
		public virtual ViewLopHocPhanGiangBangTiengNuocNgoaiProviderBase ViewLopHocPhanGiangBangTiengNuocNgoaiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewLopHocPhanGiangBangTiengNuocNgoaiBuhProviderBase instance.
		///</summary>
		public virtual ViewLopHocPhanGiangBangTiengNuocNgoaiBuhProviderBase ViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewMonGiangMoiProviderBase instance.
		///</summary>
		public virtual ViewMonGiangMoiProviderBase ViewMonGiangMoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewMonHocProviderBase instance.
		///</summary>
		public virtual ViewMonHocProviderBase ViewMonHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewMonHocKhoaProviderBase instance.
		///</summary>
		public virtual ViewMonHocKhoaProviderBase ViewMonHocKhoaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewMonThucTapTotNghiepProviderBase instance.
		///</summary>
		public virtual ViewMonThucTapTotNghiepProviderBase ViewMonThucTapTotNghiepProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewMonTinhTheoQuyCheMoiProviderBase instance.
		///</summary>
		public virtual ViewMonTinhTheoQuyCheMoiProviderBase ViewMonTinhTheoQuyCheMoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewMonXepLichChuNhatKhongTinhHeSoProviderBase instance.
		///</summary>
		public virtual ViewMonXepLichChuNhatKhongTinhHeSoProviderBase ViewMonXepLichChuNhatKhongTinhHeSoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewNamHocProviderBase instance.
		///</summary>
		public virtual ViewNamHocProviderBase ViewNamHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewNgachLuongHrmProviderBase instance.
		///</summary>
		public virtual ViewNgachLuongHrmProviderBase ViewNgachLuongHrmProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewNgayTrongTuanProviderBase instance.
		///</summary>
		public virtual ViewNgayTrongTuanProviderBase ViewNgayTrongTuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewNhomMonHocProviderBase instance.
		///</summary>
		public virtual ViewNhomMonHocProviderBase ViewNhomMonHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewPhanCongChuyenMonProviderBase instance.
		///</summary>
		public virtual ViewPhanCongChuyenMonProviderBase ViewPhanCongChuyenMonProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewPhanCongCoVanProviderBase instance.
		///</summary>
		public virtual ViewPhanCongCoVanProviderBase ViewPhanCongCoVanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewPhanCongGiangDayProviderBase instance.
		///</summary>
		public virtual ViewPhanCongGiangDayProviderBase ViewPhanCongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewPhanLoaiGiangVienProviderBase instance.
		///</summary>
		public virtual ViewPhanLoaiGiangVienProviderBase ViewPhanLoaiGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewPhanNhomMonHocProviderBase instance.
		///</summary>
		public virtual ViewPhanNhomMonHocProviderBase ViewPhanNhomMonHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewPhanNhomMonHocActProviderBase instance.
		///</summary>
		public virtual ViewPhanNhomMonHocActProviderBase ViewPhanNhomMonHocActProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewPhuCapHanhChinhProviderBase instance.
		///</summary>
		public virtual ViewPhuCapHanhChinhProviderBase ViewPhuCapHanhChinhProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewQuyDoiHoatDongNgoaiGiangDayProviderBase instance.
		///</summary>
		public virtual ViewQuyDoiHoatDongNgoaiGiangDayProviderBase ViewQuyDoiHoatDongNgoaiGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewQuyetDinhDoiHocHamHocViProviderBase instance.
		///</summary>
		public virtual ViewQuyetDinhDoiHocHamHocViProviderBase ViewQuyetDinhDoiHocHamHocViProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewSdhLietKeKhoiLuongGiangDayChiTietProviderBase instance.
		///</summary>
		public virtual ViewSdhLietKeKhoiLuongGiangDayChiTietProviderBase ViewSdhLietKeKhoiLuongGiangDayChiTietProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewSdhUteKhoiLuongQuyDoiProviderBase instance.
		///</summary>
		public virtual ViewSdhUteKhoiLuongQuyDoiProviderBase ViewSdhUteKhoiLuongQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewSinhVienHocPhanProviderBase instance.
		///</summary>
		public virtual ViewSinhVienHocPhanProviderBase ViewSinhVienHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewSinhVienLopProviderBase instance.
		///</summary>
		public virtual ViewSinhVienLopProviderBase ViewSinhVienLopProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewSinhVienLopHocPhanProviderBase instance.
		///</summary>
		public virtual ViewSinhVienLopHocPhanProviderBase ViewSinhVienLopHocPhanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewSinhVienLopHocPhanSgProviderBase instance.
		///</summary>
		public virtual ViewSinhVienLopHocPhanSgProviderBase ViewSinhVienLopHocPhanSgProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewSoTietCoiThiTieuChuanCuaGiangVienProviderBase instance.
		///</summary>
		public virtual ViewSoTietCoiThiTieuChuanCuaGiangVienProviderBase ViewSoTietCoiThiTieuChuanCuaGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThamDinhLuanVanThacSyProviderBase instance.
		///</summary>
		public virtual ViewThamDinhLuanVanThacSyProviderBase ViewThamDinhLuanVanThacSyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThanhToanGioDayProviderBase instance.
		///</summary>
		public virtual ViewThanhToanGioDayProviderBase ViewThanhToanGioDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThanhToanThuLaoProviderBase instance.
		///</summary>
		public virtual ViewThanhToanThuLaoProviderBase ViewThanhToanThuLaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThanhToanTienGiangProviderBase instance.
		///</summary>
		public virtual ViewThanhToanTienGiangProviderBase ViewThanhToanTienGiangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThanhTraChamGiangTheoKhoaHocProviderBase instance.
		///</summary>
		public virtual ViewThanhTraChamGiangTheoKhoaHocProviderBase ViewThanhTraChamGiangTheoKhoaHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThanhTraCoiThiProviderBase instance.
		///</summary>
		public virtual ViewThanhTraCoiThiProviderBase ViewThanhTraCoiThiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThanhTraGiangDayProviderBase instance.
		///</summary>
		public virtual ViewThanhTraGiangDayProviderBase ViewThanhTraGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThanhTraTheoThoiKhoaBieuProviderBase instance.
		///</summary>
		public virtual ViewThanhTraTheoThoiKhoaBieuProviderBase ViewThanhTraTheoThoiKhoaBieuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewTheoDoiGiangDayProviderBase instance.
		///</summary>
		public virtual ViewTheoDoiGiangDayProviderBase ViewTheoDoiGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThoiGianLamViecCuaNhanVienProviderBase instance.
		///</summary>
		public virtual ViewThoiGianLamViecCuaNhanVienProviderBase ViewThoiGianLamViecCuaNhanVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThoiGianNghiTamThoiCuaGiangVienProviderBase instance.
		///</summary>
		public virtual ViewThoiGianNghiTamThoiCuaGiangVienProviderBase ViewThoiGianNghiTamThoiCuaGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThoiKhoaBieuProviderBase instance.
		///</summary>
		public virtual ViewThoiKhoaBieuProviderBase ViewThoiKhoaBieuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThongKeChucVuProviderBase instance.
		///</summary>
		public virtual ViewThongKeChucVuProviderBase ViewThongKeChucVuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThongKeHoSoProviderBase instance.
		///</summary>
		public virtual ViewThongKeHoSoProviderBase ViewThongKeHoSoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThongKeHoSoChiTietProviderBase instance.
		///</summary>
		public virtual ViewThongKeHoSoChiTietProviderBase ViewThongKeHoSoChiTietProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThongTinChiTietGiangVienProviderBase instance.
		///</summary>
		public virtual ViewThongTinChiTietGiangVienProviderBase ViewThongTinChiTietGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThongTinChiTietGiangVienChoDuyetHoSoProviderBase instance.
		///</summary>
		public virtual ViewThongTinChiTietGiangVienChoDuyetHoSoProviderBase ViewThongTinChiTietGiangVienChoDuyetHoSoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThongTinGiangVienProviderBase instance.
		///</summary>
		public virtual ViewThongTinGiangVienProviderBase ViewThongTinGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewThongTinLopHocPhanHeSoCongViecProviderBase instance.
		///</summary>
		public virtual ViewThongTinLopHocPhanHeSoCongViecProviderBase ViewThongTinLopHocPhanHeSoCongViecProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewTietGiangDayProviderBase instance.
		///</summary>
		public virtual ViewTietGiangDayProviderBase ViewTietGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewTietNghiaVuProviderBase instance.
		///</summary>
		public virtual ViewTietNghiaVuProviderBase ViewTietNghiaVuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewTietNghiaVuTheoNamHocHocKyProviderBase instance.
		///</summary>
		public virtual ViewTietNghiaVuTheoNamHocHocKyProviderBase ViewTietNghiaVuTheoNamHocHocKyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewTietNoKyTruocProviderBase instance.
		///</summary>
		public virtual ViewTietNoKyTruocProviderBase ViewTietNoKyTruocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewTinhKhoiLuongProviderBase instance.
		///</summary>
		public virtual ViewTinhKhoiLuongProviderBase ViewTinhKhoiLuongProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewTinhKhoiLuongTungTuanProviderBase instance.
		///</summary>
		public virtual ViewTinhKhoiLuongTungTuanProviderBase ViewTinhKhoiLuongTungTuanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewTongHopChiTienCoVanProviderBase instance.
		///</summary>
		public virtual ViewTongHopChiTienCoVanProviderBase ViewTongHopChiTienCoVanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProviderBase instance.
		///</summary>
		public virtual ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProviderBase ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewTongHopQuyDoiProviderBase instance.
		///</summary>
		public virtual ViewTongHopQuyDoiProviderBase ViewTongHopQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewTongHopGioDayGiangVienProviderBase instance.
		///</summary>
		public virtual ViewTongHopGioDayGiangVienProviderBase ViewTongHopGioDayGiangVienProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewTonGiaoProviderBase instance.
		///</summary>
		public virtual ViewTonGiaoProviderBase ViewTonGiaoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewUteKhoiLuongGiangDayProviderBase instance.
		///</summary>
		public virtual ViewUteKhoiLuongGiangDayProviderBase ViewUteKhoiLuongGiangDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewUteKhoiLuongQuyDoiProviderBase instance.
		///</summary>
		public virtual ViewUteKhoiLuongQuyDoiProviderBase ViewUteKhoiLuongQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewUteKhoiLuongQuyDoi2ProviderBase instance.
		///</summary>
		public virtual ViewUteKhoiLuongQuyDoi2ProviderBase ViewUteKhoiLuongQuyDoi2Provider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewXetDuyetDeCuongLuanVanCaoHocProviderBase instance.
		///</summary>
		public virtual ViewXetDuyetDeCuongLuanVanCaoHocProviderBase ViewXetDuyetDeCuongLuanVanCaoHocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewXuLyQuyDoiProviderBase instance.
		///</summary>
		public virtual ViewXuLyQuyDoiProviderBase ViewXuLyQuyDoiProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ViewXuLyQuyDoiTungTuanProviderBase instance.
		///</summary>
		public virtual ViewXuLyQuyDoiTungTuanProviderBase ViewXuLyQuyDoiTungTuanProvider{get {throw new NotImplementedException();}}
		
	}
}
