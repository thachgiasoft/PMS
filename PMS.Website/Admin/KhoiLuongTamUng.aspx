<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongTamUng.aspx.cs" Inherits="KhoiLuongTamUng" Title="KhoiLuongTamUng List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Tam Ung List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KhoiLuongTamUngDataSource"
				DataKeyNames="MaKhoiLuong"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KhoiLuongTamUng.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="LoaiHocKy" HeaderText="Loai Hoc Ky" SortExpression="[LoaiHocKy]"  />
				<asp:BoundField DataField="MaKhoaHoc" HeaderText="Ma Khoa Hoc" SortExpression="[MaKhoaHoc]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="NamThu" HeaderText="Nam Thu" SortExpression="[NamThu]"  />
				<asp:BoundField DataField="MaKhoa" HeaderText="Ma Khoa" SortExpression="[MaKhoa]"  />
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]"  />
				<asp:BoundField DataField="MaPhongHoc" HeaderText="Ma Phong Hoc" SortExpression="[MaPhongHoc]"  />
				<asp:BoundField DataField="MaNhomMonHoc" HeaderText="Ma Nhom Mon Hoc" SortExpression="[MaNhomMonHoc]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
				<asp:BoundField DataField="DotImport" HeaderText="Dot Import" SortExpression="[DotImport]"  />
				<data:BoundRadioButtonField DataField="LopHocPhanChuyenNganh" HeaderText="Lop Hoc Phan Chuyen Nganh" SortExpression="[LopHocPhanChuyenNganh]"  />
				<asp:BoundField DataField="NgonNguGiangDay" HeaderText="Ngon Ngu Giang Day" SortExpression="[NgonNguGiangDay]"  />
				<data:BoundRadioButtonField DataField="DaoTaoTinChi" HeaderText="Dao Tao Tin Chi" SortExpression="[DaoTaoTinChi]"  />
				<asp:BoundField DataField="MaChucVu" HeaderText="Ma Chuc Vu" SortExpression="[MaChucVu]"  />
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="MaHinhThucDaoTao" HeaderText="Ma Hinh Thuc Dao Tao" SortExpression="[MaHinhThucDaoTao]"  />
				<asp:BoundField DataField="NgayDay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Day" SortExpression="[NgayDay]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="Nhom" HeaderText="Nhom" SortExpression="[Nhom]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
				<asp:BoundField DataField="MaQuanLyGv" HeaderText="Ma Quan Ly Gv" SortExpression="[MaQuanLyGv]"  />
				<asp:BoundField DataField="MaLichHoc" HeaderText="Ma Lich Hoc" SortExpression="[MaLichHoc]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="SoTinChi" HeaderText="So Tin Chi" SortExpression="[SoTinChi]"  />
				<asp:BoundField DataField="TietBatDau" HeaderText="Tiet Bat Dau" SortExpression="[TietBatDau]"  />
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]"  />
				<asp:BoundField DataField="TinhTrang" HeaderText="Tinh Trang" SortExpression="[TinhTrang]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="MaLoaiHocPhan" HeaderText="Ma Loai Hoc Phan" SortExpression="[MaLoaiHocPhan]"  />
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]"  />
				<asp:BoundField DataField="MaBuoiHoc" HeaderText="Ma Buoi Hoc" SortExpression="[MaBuoiHoc]"  />
				<asp:BoundField DataField="LoaiHocPhan" HeaderText="Loai Hoc Phan" SortExpression="[LoaiHocPhan]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KhoiLuongTamUng Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKhoiLuongTamUng" OnClientClick="javascript:location.href='KhoiLuongTamUngEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KhoiLuongTamUngDataSource ID="KhoiLuongTamUngDataSource" runat="server"
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
		</data:KhoiLuongTamUngDataSource>
	    		
</asp:Content>



