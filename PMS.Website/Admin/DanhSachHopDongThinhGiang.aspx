<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DanhSachHopDongThinhGiang.aspx.cs" Inherits="DanhSachHopDongThinhGiang" Title="DanhSachHopDongThinhGiang List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Danh Sach Hop Dong Thinh Giang List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="DanhSachHopDongThinhGiangDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_DanhSachHopDongThinhGiang.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="HeSoLopDong" HeaderText="He So Lop Dong" SortExpression="[HeSoLopDong]"  />
				<asp:BoundField DataField="TongSoTietTrenTuan" HeaderText="Tong So Tiet Tren Tuan" SortExpression="[TongSoTietTrenTuan]"  />
				<asp:BoundField DataField="TrangThaiHoSo" HeaderText="Trang Thai Ho So" SortExpression="[TrangThaiHoSo]"  />
				<asp:BoundField DataField="SiSo" HeaderText="Si So" SortExpression="[SiSo]"  />
				<asp:BoundField DataField="SoTietThucHanhTrenTuan" HeaderText="So Tiet Thuc Hanh Tren Tuan" SortExpression="[SoTietThucHanhTrenTuan]"  />
				<asp:BoundField DataField="SoNhomThucHanh" HeaderText="So Nhom Thuc Hanh" SortExpression="[SoNhomThucHanh]"  />
				<asp:BoundField DataField="HeSoQuyDoiThucHanh" HeaderText="He So Quy Doi Thuc Hanh" SortExpression="[HeSoQuyDoiThucHanh]"  />
				<asp:BoundField DataField="SoTietLyThuyetTrenTuan" HeaderText="So Tiet Ly Thuyet Tren Tuan" SortExpression="[SoTietLyThuyetTrenTuan]"  />
				<asp:BoundField DataField="TongSoTiet" HeaderText="Tong So Tiet" SortExpression="[TongSoTiet]"  />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
				<data:BoundRadioButtonField DataField="IsLock" HeaderText="Is Lock" SortExpression="[IsLock]"  />
				<data:BoundRadioButtonField DataField="DaXacNhan" HeaderText="Da Xac Nhan" SortExpression="[DaXacNhan]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="TongGiaTriHopDong" HeaderText="Tong Gia Tri Hop Dong" SortExpression="[TongGiaTriHopDong]"  />
				<asp:BoundField DataField="DonViTienTe" HeaderText="Don Vi Tien Te" SortExpression="[DonViTienTe]"  />
				<asp:BoundField DataField="Thue" HeaderText="Thue" SortExpression="[Thue]"  />
				<asp:BoundField DataField="GiaTriHopDongConLai" HeaderText="Gia Tri Hop Dong Con Lai" SortExpression="[GiaTriHopDongConLai]"  />
				<asp:BoundField DataField="SoTietThucHanh" HeaderText="So Tiet Thuc Hanh" SortExpression="[SoTietThucHanh]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="SoCmnd" HeaderText="So Cmnd" SortExpression="[SoCmnd]"  />
				<asp:BoundField DataField="ChuyenNganh" HeaderText="Chuyen Nganh" SortExpression="[ChuyenNganh]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
				<asp:BoundField DataField="NgaySinh" HeaderText="Ngay Sinh" SortExpression="[NgaySinh]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HoTen" HeaderText="Ho Ten" SortExpression="[HoTen]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="MaSoThue" HeaderText="Ma So Thue" SortExpression="[MaSoThue]"  />
				<asp:BoundField DataField="NgayBatDau" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Bat Dau" SortExpression="[NgayBatDau]"  />
				<asp:BoundField DataField="MaDonVi" HeaderText="Ma Don Vi" SortExpression="[MaDonVi]"  />
				<asp:BoundField DataField="SoTietLyThuyet" HeaderText="So Tiet Ly Thuyet" SortExpression="[SoTietLyThuyet]"  />
				<asp:BoundField DataField="NgayKetThuc" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Ket Thuc" SortExpression="[NgayKetThuc]"  />
				<asp:BoundField DataField="SoHopDong" HeaderText="So Hop Dong" SortExpression="[SoHopDong]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="CoQuanCongTac" HeaderText="Co Quan Cong Tac" SortExpression="[CoQuanCongTac]"  />
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No DanhSachHopDongThinhGiang Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnDanhSachHopDongThinhGiang" OnClientClick="javascript:location.href='DanhSachHopDongThinhGiangEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:DanhSachHopDongThinhGiangDataSource ID="DanhSachHopDongThinhGiangDataSource" runat="server"
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
		</data:DanhSachHopDongThinhGiangDataSource>
	    		
</asp:Content>



