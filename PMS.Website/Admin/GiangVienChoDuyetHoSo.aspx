<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienChoDuyetHoSo.aspx.cs" Inherits="GiangVienChoDuyetHoSo" Title="GiangVienChoDuyetHoSo List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Cho Duyet Ho So List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienChoDuyetHoSoDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVienChoDuyetHoSo.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="ChuyenNganh" HeaderText="Chuyen Nganh" SortExpression="[ChuyenNganh]"  />
				<asp:BoundField DataField="NamLamViec" HeaderText="Nam Lam Viec" SortExpression="[NamLamViec]"  />
				<asp:BoundField DataField="NgayHuongLuong" HeaderText="Ngay Huong Luong" SortExpression="[NgayHuongLuong]"  />
				<asp:BoundField DataField="MaHeSoThuLao" HeaderText="Ma He So Thu Lao" SortExpression="[MaHeSoThuLao]"  />
				<asp:BoundField DataField="Hrmid" HeaderText="Hrmid" SortExpression="[HRMID]"  />
				<asp:BoundField DataField="SoHieuCongChuc" HeaderText="So Hieu Cong Chuc" SortExpression="[SoHieuCongChuc]"  />
				<asp:BoundField DataField="Ngach" HeaderText="Ngach" SortExpression="[Ngach]"  />
				<asp:BoundField DataField="MaSoThue" HeaderText="Ma So Thue" SortExpression="[MaSoThue]"  />
				<asp:BoundField DataField="TenNganHang" HeaderText="Ten Ngan Hang" SortExpression="[TenNganHang]"  />
				<asp:BoundField DataField="SoTaiKhoan" HeaderText="So Tai Khoan" SortExpression="[SoTaiKhoan]"  />
				<asp:BoundField DataField="ChiNhanh" HeaderText="Chi Nhanh" SortExpression="[ChiNhanh]"  />
				<asp:BoundField DataField="BacLuong" HeaderText="Bac Luong" SortExpression="[BacLuong]"  />
				<asp:BoundField DataField="ThoiGianBatDau" HeaderText="Thoi Gian Bat Dau" SortExpression="[ThoiGianBatDau]"  />
				<asp:BoundField DataField="SoSoBaoHiem" HeaderText="So So Bao Hiem" SortExpression="[SoSoBaoHiem]"  />
				<asp:BoundField DataField="NoiCapBang" HeaderText="Noi Cap Bang" SortExpression="[NoiCapBang]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="MaTrinhDoQuanLyNhaNuoc" HeaderText="Ma Trinh Do Quan Ly Nha Nuoc" SortExpression="[MaTrinhDoQuanLyNhaNuoc]"  />
				<asp:BoundField DataField="KhoiKienThucGiangDay" HeaderText="Khoi Kien Thuc Giang Day" SortExpression="[KhoiKienThucGiangDay]"  />
				<data:BoundRadioButtonField DataField="DaDuyet" HeaderText="Da Duyet" SortExpression="[DaDuyet]"  />
				<asp:BoundField DataField="DonViGiangDay" HeaderText="Don Vi Giang Day" SortExpression="[DonViGiangDay]"  />
				<asp:BoundField DataField="NganhDaoTao" HeaderText="Nganh Dao Tao" SortExpression="[NganhDaoTao]"  />
				<asp:BoundField DataField="MaNgachCongChuc" HeaderText="Ma Ngach Cong Chuc" SortExpression="[MaNgachCongChuc]"  />
				<asp:BoundField DataField="MaLoaiNhanVien" HeaderText="Ma Loai Nhan Vien" SortExpression="[MaLoaiNhanVien]"  />
				<data:BoundRadioButtonField DataField="KhoaTaiKhoan" HeaderText="Khoa Tai Khoan" SortExpression="[KhoaTaiKhoan]"  />
				<asp:BoundField DataField="MaTrinhDoChinhTri" HeaderText="Ma Trinh Do Chinh Tri" SortExpression="[MaTrinhDoChinhTri]"  />
				<asp:BoundField DataField="MaTrinhDoTinHoc" HeaderText="Ma Trinh Do Tin Hoc" SortExpression="[MaTrinhDoTinHoc]"  />
				<asp:BoundField DataField="MaTrinhDoNgoaiNgu" HeaderText="Ma Trinh Do Ngoai Ngu" SortExpression="[MaTrinhDoNgoaiNgu]"  />
				<asp:BoundField DataField="MaTrinhDoSuPham" HeaderText="Ma Trinh Do Su Pham" SortExpression="[MaTrinhDoSuPham]"  />
				<asp:BoundField DataField="SoDiDong" HeaderText="So Di Dong" SortExpression="[SoDiDong]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="MaTinhTrang" HeaderText="Ma Tinh Trang" SortExpression="[MaTinhTrang]"  />
				<asp:BoundField DataField="MatKhau" HeaderText="Mat Khau" SortExpression="[MatKhau]"  />
				<asp:BoundField DataField="Ho" HeaderText="Ho" SortExpression="[Ho]"  />
				<asp:BoundField DataField="NgaySinh" HeaderText="Ngay Sinh" SortExpression="[NgaySinh]"  />
				<asp:BoundField DataField="Ten" HeaderText="Ten" SortExpression="[Ten]"  />
				<asp:BoundField DataField="TenDem" HeaderText="Ten Dem" SortExpression="[TenDem]"  />
				<asp:BoundField DataField="MaDonVi" HeaderText="Ma Don Vi" SortExpression="[MaDonVi]"  />
				<asp:BoundField DataField="MaTonGiao" HeaderText="Ma Ton Giao" SortExpression="[MaTonGiao]"  />
				<asp:BoundField DataField="MaDanToc" HeaderText="Ma Dan Toc" SortExpression="[MaDanToc]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="MaNguoiLap" HeaderText="Ma Nguoi Lap" SortExpression="[MaNguoiLap]"  />
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
				<data:BoundRadioButtonField DataField="GioiTinh" HeaderText="Gioi Tinh" SortExpression="[GioiTinh]"  />
				<asp:BoundField DataField="DiaChi" HeaderText="Dia Chi" SortExpression="[DiaChi]"  />
				<asp:BoundField DataField="HinhAnh" HeaderText="Hinh Anh" SortExpression="[HinhAnh]"  />
				<asp:BoundField DataField="NgayKetThucHopDong" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Ket Thuc Hop Dong" SortExpression="[NgayKetThucHopDong]"  />
				<asp:BoundField DataField="ThuongTru" HeaderText="Thuong Tru" SortExpression="[ThuongTru]"  />
				<asp:BoundField DataField="DienThoai" HeaderText="Dien Thoai" SortExpression="[DienThoai]"  />
				<asp:BoundField DataField="Email" HeaderText="Email" SortExpression="[Email]"  />
				<asp:BoundField DataField="NoiLamViec" HeaderText="Noi Lam Viec" SortExpression="[NoiLamViec]"  />
				<asp:BoundField DataField="NgayCap" HeaderText="Ngay Cap" SortExpression="[NgayCap]"  />
				<asp:BoundField DataField="Cmnd" HeaderText="Cmnd" SortExpression="[Cmnd]"  />
				<asp:BoundField DataField="NoiSinh" HeaderText="Noi Sinh" SortExpression="[NoiSinh]"  />
				<asp:BoundField DataField="NoiCap" HeaderText="Noi Cap" SortExpression="[NoiCap]"  />
				<asp:BoundField DataField="NgayKyHopDong" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Ky Hop Dong" SortExpression="[NgayKyHopDong]"  />
				<asp:BoundField DataField="NgayVaoDoanDang" HeaderText="Ngay Vao Doan Dang" SortExpression="[NgayVaoDoanDang]"  />
				<data:BoundRadioButtonField DataField="DoanDang" HeaderText="Doan Dang" SortExpression="[DoanDang]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVienChoDuyetHoSo Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVienChoDuyetHoSo" OnClientClick="javascript:location.href='GiangVienChoDuyetHoSoEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienChoDuyetHoSoDataSource ID="GiangVienChoDuyetHoSoDataSource" runat="server"
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
		</data:GiangVienChoDuyetHoSoDataSource>
	    		
</asp:Content>



