<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuLaoHuongDanCuoiKhoa.aspx.cs" Inherits="ThuLaoHuongDanCuoiKhoa" Title="ThuLaoHuongDanCuoiKhoa List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Lao Huong Dan Cuoi Khoa List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThuLaoHuongDanCuoiKhoaDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThuLaoHuongDanCuoiKhoa.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="ThanhTienNoGioChuan" HeaderText="Thanh Tien No Gio Chuan" SortExpression="[ThanhTienNoGioChuan]"  />
				<asp:BoundField DataField="Thue" HeaderText="Thue" SortExpression="[Thue]"  />
				<asp:BoundField DataField="SoTietNoGioChuan" HeaderText="So Tiet No Gio Chuan" SortExpression="[SoTietNoGioChuan]"  />
				<asp:BoundField DataField="SoLuongThamGiaHoiDongTotNghiep" HeaderText="So Luong Tham Gia Hoi Dong Tot Nghiep" SortExpression="[SoLuongThamGiaHoiDongTotNghiep]"  />
				<asp:BoundField DataField="ThanhTienThamGiaHoiDongTotNghiep" HeaderText="Thanh Tien Tham Gia Hoi Dong Tot Nghiep" SortExpression="[ThanhTienThamGiaHoiDongTotNghiep]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="ChotKhoiLuong" HeaderText="Chot Khoi Luong" SortExpression="[ChotKhoiLuong]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="ThucLanh" HeaderText="Thuc Lanh" SortExpression="[ThucLanh]"  />
				<asp:BoundField DataField="NoiDung" HeaderText="Noi Dung" SortExpression="[NoiDung]"  />
				<asp:BoundField DataField="ThanhTienKhoaLuanChuyenDeTotNghiep" HeaderText="Thanh Tien Khoa Luan Chuyen De Tot Nghiep" SortExpression="[ThanhTienKhoaLuanChuyenDeTotNghiep]"  />
				<asp:BoundField DataField="DotChiTra" HeaderText="Dot Chi Tra" SortExpression="[DotChiTra]"  />
				<asp:BoundField DataField="HuongDanVietBaoCaoTotNghiep" HeaderText="Huong Dan Viet Bao Cao Tot Nghiep" SortExpression="[HuongDanVietBaoCaoTotNghiep]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="MaGiangVienQuanLy" HeaderText="Ma Giang Vien Quan Ly" SortExpression="[MaGiangVienQuanLy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="SoTietQuyDoi" HeaderText="So Tiet Quy Doi" SortExpression="[SoTietQuyDoi]"  />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
				<asp:BoundField DataField="PhanBienKhoaLuanTotNghiep" HeaderText="Phan Bien Khoa Luan Tot Nghiep" SortExpression="[PhanBienKhoaLuanTotNghiep]"  />
				<asp:BoundField DataField="HuongDanChuyenDeThucTapTotNghiep" HeaderText="Huong Dan Chuyen De Thuc Tap Tot Nghiep" SortExpression="[HuongDanChuyenDeThucTapTotNghiep]"  />
				<asp:BoundField DataField="HuongDanKhoaLuanTotNghiep" HeaderText="Huong Dan Khoa Luan Tot Nghiep" SortExpression="[HuongDanKhoaLuanTotNghiep]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThuLaoHuongDanCuoiKhoa Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThuLaoHuongDanCuoiKhoa" OnClientClick="javascript:location.href='ThuLaoHuongDanCuoiKhoaEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThuLaoHuongDanCuoiKhoaDataSource ID="ThuLaoHuongDanCuoiKhoaDataSource" runat="server"
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
		</data:ThuLaoHuongDanCuoiKhoaDataSource>
	    		
</asp:Content>



