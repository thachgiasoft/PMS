<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DanhMucNghienCuuKhoaHoc.aspx.cs" Inherits="DanhMucNghienCuuKhoaHoc" Title="DanhMucNghienCuuKhoaHoc List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Danh Muc Nghien Cuu Khoa Hoc List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="DanhMucNghienCuuKhoaHocDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_DanhMucNghienCuuKhoaHoc.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<data:HyperLinkField HeaderText="Ma Loai Nckh" DataNavigateUrlFormatString="LoaiNghienCuuKhoaHocEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaLoaiNckhSource" DataTextField="MaLoaiNckh" />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="TenNghienCuuKhoaHoc" HeaderText="Ten Nghien Cuu Khoa Hoc" SortExpression="[TenNghienCuuKhoaHoc]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No DanhMucNghienCuuKhoaHoc Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnDanhMucNghienCuuKhoaHoc" OnClientClick="javascript:location.href='DanhMucNghienCuuKhoaHocEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:DanhMucNghienCuuKhoaHocDataSource ID="DanhMucNghienCuuKhoaHocDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:DanhMucNghienCuuKhoaHocProperty Name="LoaiNghienCuuKhoaHoc"/> 
					<%--<data:DanhMucNghienCuuKhoaHocProperty Name="GiangVienNghienCuuKhCollection" />--%>
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:DanhMucNghienCuuKhoaHocDataSource>
	    		
</asp:Content>



