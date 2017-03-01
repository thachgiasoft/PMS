<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KetQuaThanhToanThuLao.aspx.cs" Inherits="KetQuaThanhToanThuLao" Title="KetQuaThanhToanThuLao List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Ket Qua Thanh Toan Thu Lao List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KetQuaThanhToanThuLaoDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KetQuaThanhToanThuLao.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MalopHocPhan" HeaderText="Malop Hoc Phan" SortExpression="[MalopHocPhan]"  />
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]"  />
				<asp:BoundField DataField="LoaiLop" HeaderText="Loai Lop" SortExpression="[LoaiLop]"  />
				<asp:BoundField DataField="MaKhoaHoc" HeaderText="Ma Khoa Hoc" SortExpression="[MaKhoaHoc]"  />
				<asp:BoundField DataField="HeSoLuong" HeaderText="He So Luong" SortExpression="[HeSoLuong]"  />
				<asp:BoundField DataField="HeSoNgoaiGio" HeaderText="He So Ngoai Gio" SortExpression="[HeSoNgoaiGio]"  />
				<asp:BoundField DataField="HeSoTroCap" HeaderText="He So Tro Cap" SortExpression="[HeSoTroCap]"  />
				<asp:BoundField DataField="SoGioChuanTinhThem" HeaderText="So Gio Chuan Tinh Them" SortExpression="[SoGioChuanTinhThem]"  />
				<asp:BoundField DataField="SoGioThucGiangTrenLop" HeaderText="So Gio Thuc Giang Tren Lop" SortExpression="[SoGioThucGiangTrenLop]"  />
				<asp:BoundField DataField="HeSoCoSo" HeaderText="He So Co So" SortExpression="[HeSoCoSo]"  />
				<asp:BoundField DataField="HeSoChucDanhChuyenMon" HeaderText="He So Chuc Danh Chuyen Mon" SortExpression="[HeSoChucDanhChuyenMon]"  />
				<asp:BoundField DataField="MaNhomMonHoc" HeaderText="Ma Nhom Mon Hoc" SortExpression="[MaNhomMonHoc]"  />
				<asp:BoundField DataField="HeSoThinhGiangMonChuyenNganh" HeaderText="He So Thinh Giang Mon Chuyen Nganh" SortExpression="[HeSoThinhGiangMonChuyenNganh]"  />
				<asp:BoundField DataField="HeSoClcCntn" HeaderText="He So Clc Cntn" SortExpression="[HeSoClcCntn]"  />
				<asp:BoundField DataField="HeSoMonMoi" HeaderText="He So Mon Moi" SortExpression="[HeSoMonMoi]"  />
				<asp:BoundField DataField="MaCoSo" HeaderText="Ma Co So" SortExpression="[MaCoSo]"  />
				<asp:BoundField DataField="NgonNguGiangDay" HeaderText="Ngon Ngu Giang Day" SortExpression="[NgonNguGiangDay]"  />
				<asp:BoundField DataField="HeSoCongViec" HeaderText="He So Cong Viec" SortExpression="[HeSoCongViec]"  />
				<asp:BoundField DataField="MucThanhToan" HeaderText="Muc Thanh Toan" SortExpression="[MucThanhToan]"  />
				<asp:BoundField DataField="MaCauHinhChotGio" HeaderText="Ma Cau Hinh Chot Gio" SortExpression="[MaCauHinhChotGio]"  />
				<asp:BoundField DataField="HeSoKhoiNganh" HeaderText="He So Khoi Nganh" SortExpression="[HeSoKhoiNganh]"  />
				<asp:BoundField DataField="DotChiTra" HeaderText="Dot Chi Tra" SortExpression="[DotChiTra]"  />
				<asp:BoundField DataField="HeSoBacDaoTao" HeaderText="He So Bac Dao Tao" SortExpression="[HeSoBacDaoTao]"  />
				<asp:BoundField DataField="HeSoNgonNgu" HeaderText="He So Ngon Ngu" SortExpression="[HeSoNgonNgu]"  />
				<asp:BoundField DataField="HeSoNienCheTinChi" HeaderText="He So Nien Che Tin Chi" SortExpression="[HeSoNienCheTinChi]"  />
				<asp:BoundField DataField="NgayChiTra" HeaderText="Ngay Chi Tra" SortExpression="[NgayChiTra]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<data:BoundRadioButtonField DataField="XacNhanChiTra" HeaderText="Xac Nhan Chi Tra" SortExpression="[XacNhanChiTra]"  />
				<asp:BoundField DataField="HeSoQuyDoiThucHanhSangLyThuyet" HeaderText="He So Quy Doi Thuc Hanh Sang Ly Thuyet" SortExpression="[HeSoQuyDoiThucHanhSangLyThuyet]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="PhanLoai" HeaderText="Phan Loai" SortExpression="[PhanLoai]"  />
				<asp:BoundField DataField="Loai" HeaderText="Loai" SortExpression="[Loai]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]"  />
				<asp:BoundField DataField="Nhom" HeaderText="Nhom" SortExpression="[Nhom]"  />
				<asp:BoundField DataField="LoaiHocPhan" HeaderText="Loai Hoc Phan" SortExpression="[LoaiHocPhan]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="MaDonVi" HeaderText="Ma Don Vi" SortExpression="[MaDonVi]"  />
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
				<data:BoundRadioButtonField DataField="LopClc" HeaderText="Lop Clc" SortExpression="[LopClc]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="LanChot" HeaderText="Lan Chot" SortExpression="[LanChot]"  />
				<asp:BoundField DataField="ThanhTien" HeaderText="Thanh Tien" SortExpression="[ThanhTien]"  />
				<asp:BoundField DataField="MaHinhThucDaoTao" HeaderText="Ma Hinh Thuc Dao Tao" SortExpression="[MaHinhThucDaoTao]"  />
				<asp:BoundField DataField="TenCoSo" HeaderText="Ten Co So" SortExpression="[TenCoSo]"  />
				<asp:BoundField DataField="DonGiaNgoaiChuan" HeaderText="Don Gia Ngoai Chuan" SortExpression="[DonGiaNgoaiChuan]"  />
				<asp:BoundField DataField="DonGiaTrongChuan" HeaderText="Don Gia Trong Chuan" SortExpression="[DonGiaTrongChuan]"  />
				<asp:BoundField DataField="TietChuNhat" HeaderText="Tiet Chu Nhat" SortExpression="[TietChuNhat]"  />
				<asp:BoundField DataField="TietThucDay" HeaderText="Tiet Thuc Day" SortExpression="[TietThucDay]"  />
				<asp:BoundField DataField="SiSo" HeaderText="Si So" SortExpression="[SiSo]"  />
				<asp:BoundField DataField="HeSoHocKy" HeaderText="He So Hoc Ky" SortExpression="[HeSoHocKy]"  />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]"  />
				<asp:BoundField DataField="HeSoLopDong" HeaderText="He So Lop Dong" SortExpression="[HeSoLopDong]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KetQuaThanhToanThuLao Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKetQuaThanhToanThuLao" OnClientClick="javascript:location.href='KetQuaThanhToanThuLaoEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KetQuaThanhToanThuLaoDataSource ID="KetQuaThanhToanThuLaoDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
		>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:KetQuaThanhToanThuLaoDataSource>
	    		
</asp:Content>



