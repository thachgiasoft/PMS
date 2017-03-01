<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienNghienCuuKh.aspx.cs" Inherits="GiangVienNghienCuuKh" Title="GiangVienNghienCuuKh List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Nghien Cuu Kh List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienNghienCuuKhDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVienNghienCuuKh.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GioGiangChuyenSangNckh" HeaderText="Gio Giang Chuyen Sang Nckh" SortExpression="[GioGiangChuyenSangNckh]"  />
				<asp:BoundField DataField="NgayNhap" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Nhap" SortExpression="[NgayNhap]"  />
				<data:HyperLinkField HeaderText="Muc Do Hoan Thanh" DataNavigateUrlFormatString="MucDoHoanThanhNckhEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MucDoHoanThanhSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="TenNckh" HeaderText="Ten Nckh" SortExpression="[TenNckh]"  />
				<asp:BoundField DataField="SoLuongThanhVien" HeaderText="So Luong Thanh Vien" SortExpression="[SoLuongThanhVien]"  />
				<data:BoundRadioButtonField DataField="XacNhan" HeaderText="Xac Nhan" SortExpression="[XacNhan]"  />
				<asp:BoundField DataField="NgayXacNhan" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Xac Nhan" SortExpression="[NgayXacNhan]"  />
				<data:HyperLinkField HeaderText="Ma Vai Tro" DataNavigateUrlFormatString="VaiTroEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaVaiTroSource" DataTextField="MaVaiTro" />
				<data:BoundRadioButtonField DataField="DuKien" HeaderText="Du Kien" SortExpression="[DuKien]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<data:HyperLinkField HeaderText="Ma Nckh" DataNavigateUrlFormatString="DanhMucNghienCuuKhoaHocEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaNckhSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NgayHieuLuc" HeaderText="Ngay Hieu Luc" SortExpression="[NgayHieuLuc]"  />
				<data:BoundRadioButtonField DataField="TrangThai" HeaderText="Trang Thai" SortExpression="[TrangThai]"  />
				<asp:BoundField DataField="NgayHetHieuLuc" HeaderText="Ngay Het Hieu Luc" SortExpression="[NgayHetHieuLuc]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVienNghienCuuKh Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVienNghienCuuKh" OnClientClick="javascript:location.href='GiangVienNghienCuuKhEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienNghienCuuKhDataSource ID="GiangVienNghienCuuKhDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienNghienCuuKhProperty Name="DanhMucNghienCuuKhoaHoc"/> 
					<data:GiangVienNghienCuuKhProperty Name="GiangVien"/> 
					<data:GiangVienNghienCuuKhProperty Name="VaiTro"/> 
					<data:GiangVienNghienCuuKhProperty Name="MucDoHoanThanhNckh"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:GiangVienNghienCuuKhDataSource>
	    		
</asp:Content>



