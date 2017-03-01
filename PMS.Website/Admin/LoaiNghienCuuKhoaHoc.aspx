<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiNghienCuuKhoaHoc.aspx.cs" Inherits="LoaiNghienCuuKhoaHoc" Title="LoaiNghienCuuKhoaHoc List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Nghien Cuu Khoa Hoc List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="LoaiNghienCuuKhoaHocDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_LoaiNghienCuuKhoaHoc.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="ChuTriDeTaiHuong" HeaderText="Chu Tri De Tai Huong" SortExpression="[ChuTriDeTaiHuong]"  />
				<asp:BoundField DataField="ThanhVienHuong" HeaderText="Thanh Vien Huong" SortExpression="[ThanhVienHuong]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="MaLoaiNckh" HeaderText="Ma Loai Nckh" SortExpression="[MaLoaiNCKH]"  />
				<asp:BoundField DataField="TenLoaiNckh" HeaderText="Ten Loai Nckh" SortExpression="[TenLoaiNCKH]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No LoaiNghienCuuKhoaHoc Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnLoaiNghienCuuKhoaHoc" OnClientClick="javascript:location.href='LoaiNghienCuuKhoaHocEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:LoaiNghienCuuKhoaHocDataSource ID="LoaiNghienCuuKhoaHocDataSource" runat="server"
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
		</data:LoaiNghienCuuKhoaHocDataSource>
	    		
</asp:Content>



