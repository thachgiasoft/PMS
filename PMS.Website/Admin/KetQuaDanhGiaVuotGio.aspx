<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KetQuaDanhGiaVuotGio.aspx.cs" Inherits="KetQuaDanhGiaVuotGio" Title="KetQuaDanhGiaVuotGio List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Ket Qua Danh Gia Vuot Gio List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KetQuaDanhGiaVuotGioDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KetQuaDanhGiaVuotGio.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="PhanTramDanhGia" HeaderText="Phan Tram Danh Gia" SortExpression="[PhanTramDanhGia]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="DanhGiaThoiGianThucHien" HeaderText="Danh Gia Thoi Gian Thuc Hien" SortExpression="[DanhGiaThoiGianThucHien]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="ThoiGianLamViecQuyDinh" HeaderText="Thoi Gian Lam Viec Quy Dinh" SortExpression="[ThoiGianLamViecQuyDinh]"  />
				<data:HyperLinkField HeaderText="Ma Noi Dung Danh Gia" DataNavigateUrlFormatString="NoiDungDanhGiaEdit.aspx?MaQuanLy={0}" DataNavigateUrlFields="MaQuanLy" DataContainer="MaNoiDungDanhGiaSource" DataTextField="TenNoiDungDanhGia" />
			</Columns>
			<EmptyDataTemplate>
				<b>No KetQuaDanhGiaVuotGio Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKetQuaDanhGiaVuotGio" OnClientClick="javascript:location.href='KetQuaDanhGiaVuotGioEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KetQuaDanhGiaVuotGioDataSource ID="KetQuaDanhGiaVuotGioDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KetQuaDanhGiaVuotGioProperty Name="NoiDungDanhGia"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:KetQuaDanhGiaVuotGioDataSource>
	    		
</asp:Content>



