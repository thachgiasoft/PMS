<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongQuyDoi.aspx.cs" Inherits="KhoiLuongQuyDoi" Title="KhoiLuongQuyDoi List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Quy Doi List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KhoiLuongQuyDoiDataSource"
				DataKeyNames="MaKhoiLuongQuyDoi"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KhoiLuongQuyDoi.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]"  />
				<asp:BoundField DataField="SoTietThucTeQuyDoi" HeaderText="So Tiet Thuc Te Quy Doi" SortExpression="[SoTietThucTeQuyDoi]"  />
				<asp:BoundField DataField="HeSoQuyDoiThucHanhSangLyThuyet" HeaderText="He So Quy Doi Thuc Hanh Sang Ly Thuyet" SortExpression="[HeSoQuyDoiThucHanhSangLyThuyet]"  />
				<asp:BoundField DataField="LoaiLop" HeaderText="Loai Lop" SortExpression="[LoaiLop]"  />
				<asp:BoundField DataField="HeSoNgoaiGio" HeaderText="He So Ngoai Gio" SortExpression="[HeSoNgoaiGio]"  />
				<asp:BoundField DataField="HeSoCoSo" HeaderText="He So Co So" SortExpression="[HeSoCoSo]"  />
				<asp:BoundField DataField="HeSoBacDaoTao" HeaderText="He So Bac Dao Tao" SortExpression="[HeSoBacDaoTao]"  />
				<asp:BoundField DataField="HeSoCongViec" HeaderText="He So Cong Viec" SortExpression="[HeSoCongViec]"  />
				<asp:BoundField DataField="HeSoNgonNgu" HeaderText="He So Ngon Ngu" SortExpression="[HeSoNgonNgu]"  />
				<asp:BoundField DataField="HeSoLopDong" HeaderText="He So Lop Dong" SortExpression="[HeSoLopDong]"  />
				<asp:BoundField DataField="HeSoChucDanhChuyenMon" HeaderText="He So Chuc Danh Chuyen Mon" SortExpression="[HeSoChucDanhChuyenMon]"  />
				<asp:BoundField DataField="HeSoNienCheTinChi" HeaderText="He So Nien Che Tin Chi" SortExpression="[HeSoNienCheTinChi]"  />
				<asp:BoundField DataField="HeSoMonMoi" HeaderText="He So Mon Moi" SortExpression="[HeSoMonMoi]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="HeSoKhoiNganh" HeaderText="He So Khoi Nganh" SortExpression="[HeSoKhoiNganh]"  />
				<asp:BoundField DataField="MucThanhToan" HeaderText="Muc Thanh Toan" SortExpression="[MucThanhToan]"  />
				<asp:BoundField DataField="HeSoLuong" HeaderText="He So Luong" SortExpression="[HeSoLuong]"  />
				<asp:BoundField DataField="HeSoThinhGiangMonChuyenNganh" HeaderText="He So Thinh Giang Mon Chuyen Nganh" SortExpression="[HeSoThinhGiangMonChuyenNganh]"  />
				<asp:BoundField DataField="HeSoClcCntn" HeaderText="He So Clc Cntn" SortExpression="[HeSoClcCntn]"  />
				<asp:BoundField DataField="NgonNguGiangDay" HeaderText="Ngon Ngu Giang Day" SortExpression="[NgonNguGiangDay]"  />
				<asp:BoundField DataField="HeSoTroCap" HeaderText="He So Tro Cap" SortExpression="[HeSoTroCap]"  />
				<asp:BoundField DataField="HeSoTroCapGiangDay" HeaderText="He So Tro Cap Giang Day" SortExpression="[HeSoTroCapGiangDay]"  />
				<asp:BoundField DataField="SoTinChi" HeaderText="So Tin Chi" SortExpression="[SoTinChi]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]"  />
				<asp:BoundField DataField="LoaiHocPhan" HeaderText="Loai Hoc Phan" SortExpression="[LoaiHocPhan]"  />
				<asp:BoundField DataField="MaLoaiHocPhan" HeaderText="Ma Loai Hoc Phan" SortExpression="[MaLoaiHocPhan]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<data:HyperLinkField HeaderText="Ma Khoi Luong Giang Day" DataNavigateUrlFormatString="KhoiLuongGiangDayChiTietEdit.aspx?MaKhoiLuong={0}" DataNavigateUrlFields="MaKhoiLuong" DataContainer="MaKhoiLuongGiangDaySource" DataTextField="MaLichHoc" />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="MaKhoaHoc" HeaderText="Ma Khoa Hoc" SortExpression="[MaKhoaHoc]"  />
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]"  />
				<asp:BoundField DataField="MaKhoa" HeaderText="Ma Khoa" SortExpression="[MaKhoa]"  />
				<asp:BoundField DataField="MaPhongHoc" HeaderText="Ma Phong Hoc" SortExpression="[MaPhongHoc]"  />
				<asp:BoundField DataField="MaNhomMonHoc" HeaderText="Ma Nhom Mon Hoc" SortExpression="[MaNhomMonHoc]"  />
				<asp:BoundField DataField="NgayDay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Day" SortExpression="[NgayDay]"  />
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]"  />
				<asp:BoundField DataField="MaBuoiHoc" HeaderText="Ma Buoi Hoc" SortExpression="[MaBuoiHoc]"  />
				<asp:BoundField DataField="TietBatDau" HeaderText="Tiet Bat Dau" SortExpression="[TietBatDau]"  />
				<asp:BoundField DataField="TinhTrang" HeaderText="Tinh Trang" SortExpression="[TinhTrang]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KhoiLuongQuyDoi Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKhoiLuongQuyDoi" OnClientClick="javascript:location.href='KhoiLuongQuyDoiEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KhoiLuongQuyDoiDataSource ID="KhoiLuongQuyDoiDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KhoiLuongQuyDoiProperty Name="KhoiLuongGiangDayChiTiet"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:KhoiLuongQuyDoiDataSource>
	    		
</asp:Content>



