<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DinhMucGioChuanToiThieuTheoChucVu.aspx.cs" Inherits="DinhMucGioChuanToiThieuTheoChucVu" Title="DinhMucGioChuanToiThieuTheoChucVu List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Dinh Muc Gio Chuan Toi Thieu Theo Chuc Vu List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="DinhMucGioChuanToiThieuTheoChucVuDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_DinhMucGioChuanToiThieuTheoChucVu.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SoTietNghiaVu" HeaderText="So Tiet Nghia Vu" SortExpression="[SoTietNghiaVu]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<data:HyperLinkField HeaderText="Id Quy Mo" DataNavigateUrlFormatString="DanhMucQuyMoEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="IdQuyMoSource" DataTextField="MaQuyMo" />
				<asp:BoundField DataField="NhomGiangVien" HeaderText="Nhom Giang Vien" SortExpression="[NhomGiangVien]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="PhanTramGiamTru" HeaderText="Phan Tram Giam Tru" SortExpression="[PhanTramGiamTru]"  />
				<data:HyperLinkField HeaderText="Ma Chuc Vu" DataNavigateUrlFormatString="ChucVuEdit.aspx?MaChucVu={0}" DataNavigateUrlFields="MaChucVu" DataContainer="MaChucVuSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No DinhMucGioChuanToiThieuTheoChucVu Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnDinhMucGioChuanToiThieuTheoChucVu" OnClientClick="javascript:location.href='DinhMucGioChuanToiThieuTheoChucVuEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:DinhMucGioChuanToiThieuTheoChucVuDataSource ID="DinhMucGioChuanToiThieuTheoChucVuDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:DinhMucGioChuanToiThieuTheoChucVuProperty Name="ChucVu"/> 
					<data:DinhMucGioChuanToiThieuTheoChucVuProperty Name="DanhMucQuyMo"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:DinhMucGioChuanToiThieuTheoChucVuDataSource>
	    		
</asp:Content>



