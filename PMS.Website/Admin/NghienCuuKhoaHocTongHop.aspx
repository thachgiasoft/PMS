<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NghienCuuKhoaHocTongHop.aspx.cs" Inherits="NghienCuuKhoaHocTongHop" Title="NghienCuuKhoaHocTongHop List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nghien Cuu Khoa Hoc Tong Hop List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="NghienCuuKhoaHocTongHopDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_NghienCuuKhoaHocTongHop.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SoTietDuocTru" HeaderText="So Tiet Duoc Tru" SortExpression="[SoTietDuocTru]"  />
				<asp:BoundField DataField="Tong" HeaderText="Tong" SortExpression="[Tong]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="SoTietChuyenSangKySau" HeaderText="So Tiet Chuyen Sang Ky Sau" SortExpression="[SoTietChuyenSangKySau]"  />
				<asp:BoundField DataField="SoTietThucHien" HeaderText="So Tiet Thuc Hien" SortExpression="[SoTietThucHien]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="SoTietKyTruocChuyenSang" HeaderText="So Tiet Ky Truoc Chuyen Sang" SortExpression="[SoTietKyTruocChuyenSang]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No NghienCuuKhoaHocTongHop Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnNghienCuuKhoaHocTongHop" OnClientClick="javascript:location.href='NghienCuuKhoaHocTongHopEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:NghienCuuKhoaHocTongHopDataSource ID="NghienCuuKhoaHocTongHopDataSource" runat="server"
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
		</data:NghienCuuKhoaHocTongHopDataSource>
	    		
</asp:Content>



