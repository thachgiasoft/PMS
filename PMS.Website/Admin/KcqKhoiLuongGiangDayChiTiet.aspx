<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqKhoiLuongGiangDayChiTiet.aspx.cs" Inherits="KcqKhoiLuongGiangDayChiTiet" Title="KcqKhoiLuongGiangDayChiTiet List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Khoi Luong Giang Day Chi Tiet List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KcqKhoiLuongGiangDayChiTietDataSource"
				DataKeyNames="MaKhoiLuong"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KcqKhoiLuongGiangDayChiTiet.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="Compensate" HeaderText="Compensate" SortExpression="[Compensate]"  />
				<asp:BoundField DataField="NgayDay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Day" SortExpression="[NgayDay]"  />
				<asp:BoundField DataField="TinhTrang" HeaderText="Tinh Trang" SortExpression="[TinhTrang]"  />
				<asp:BoundField DataField="MaNhomMonHoc" HeaderText="Ma Nhom Mon Hoc" SortExpression="[MaNhomMonHoc]"  />
				<asp:BoundField DataField="MaKhoa" HeaderText="Ma Khoa" SortExpression="[MaKhoa]"  />
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]"  />
				<asp:BoundField DataField="TietBatDau" HeaderText="Tiet Bat Dau" SortExpression="[TietBatDau]"  />
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]"  />
				<asp:BoundField DataField="MaBuoiHoc" HeaderText="Ma Buoi Hoc" SortExpression="[MaBuoiHoc]"  />
				<asp:BoundField DataField="HeSoHocKy" HeaderText="He So Hoc Ky" SortExpression="[HeSoHocKy]"  />
				<asp:BoundField DataField="LoaiHocKy" HeaderText="Loai Hoc Ky" SortExpression="[LoaiHocKy]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="MaPhongHoc" HeaderText="Ma Phong Hoc" SortExpression="[MaPhongHoc]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="MaHinhThucDaoTao" HeaderText="Ma Hinh Thuc Dao Tao" SortExpression="[MaHinhThucDaoTao]"  />
				<data:BoundRadioButtonField DataField="DaoTaoTinChi" HeaderText="Dao Tao Tin Chi" SortExpression="[DaoTaoTinChi]"  />
				<asp:BoundField DataField="DotImport" HeaderText="Dot Import" SortExpression="[DotImport]"  />
				<data:BoundRadioButtonField DataField="LopHocPhanChuyenNganh" HeaderText="Lop Hoc Phan Chuyen Nganh" SortExpression="[LopHocPhanChuyenNganh]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="NamThu" HeaderText="Nam Thu" SortExpression="[NamThu]"  />
				<asp:BoundField DataField="MaKhoaHoc" HeaderText="Ma Khoa Hoc" SortExpression="[MaKhoaHoc]"  />
				<asp:BoundField DataField="MaChucVu" HeaderText="Ma Chuc Vu" SortExpression="[MaChucVu]"  />
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
				<asp:BoundField DataField="DonViTinh" HeaderText="Don Vi Tinh" SortExpression="[DonViTinh]"  />
				<asp:BoundField DataField="Nhom" HeaderText="Nhom" SortExpression="[Nhom]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="ThucHanh" HeaderText="Thuc Hanh" SortExpression="[ThucHanh]"  />
				<asp:BoundField DataField="LyThuyet" HeaderText="Ly Thuyet" SortExpression="[LyThuyet]"  />
				<asp:BoundField DataField="SoTinChi" HeaderText="So Tin Chi" SortExpression="[SoTinChi]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="MaLichHoc" HeaderText="Ma Lich Hoc" SortExpression="[MaLichHoc]"  />
				<asp:BoundField DataField="MaDot" HeaderText="Ma Dot" SortExpression="[MaDot]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="BaiTap" HeaderText="Bai Tap" SortExpression="[BaiTap]"  />
				<asp:BoundField DataField="PhanLoai" HeaderText="Phan Loai" SortExpression="[PhanLoai]"  />
				<asp:BoundField DataField="LoaiHocPhan" HeaderText="Loai Hoc Phan" SortExpression="[LoaiHocPhan]"  />
				<asp:BoundField DataField="MaLoaiHocPhan" HeaderText="Ma Loai Hoc Phan" SortExpression="[MaLoaiHocPhan]"  />
				<asp:BoundField DataField="Tuan" HeaderText="Tuan" SortExpression="[Tuan]"  />
				<asp:BoundField DataField="Nam" HeaderText="Nam" SortExpression="[Nam]"  />
				<asp:BoundField DataField="HeSoThanhPhan" HeaderText="He So Thanh Phan" SortExpression="[HeSoThanhPhan]"  />
				<asp:BoundField DataField="LuanAn" HeaderText="Luan An" SortExpression="[LuanAn]"  />
				<asp:BoundField DataField="DoAn" HeaderText="Do An" SortExpression="[DoAn]"  />
				<asp:BoundField DataField="BaiTapLon" HeaderText="Bai Tap Lon" SortExpression="[BaiTapLon]"  />
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]"  />
				<asp:BoundField DataField="ThucTap" HeaderText="Thuc Tap" SortExpression="[ThucTap]"  />
				<asp:BoundField DataField="TieuLuan" HeaderText="Tieu Luan" SortExpression="[TieuLuan]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KcqKhoiLuongGiangDayChiTiet Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKcqKhoiLuongGiangDayChiTiet" OnClientClick="javascript:location.href='KcqKhoiLuongGiangDayChiTietEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KcqKhoiLuongGiangDayChiTietDataSource ID="KcqKhoiLuongGiangDayChiTietDataSource" runat="server"
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
		</data:KcqKhoiLuongGiangDayChiTietDataSource>
	    		
</asp:Content>



