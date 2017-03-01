<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NoiDungDanhGia.aspx.cs" Inherits="NoiDungDanhGia" Title="NoiDungDanhGia List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Noi Dung Danh Gia List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="NoiDungDanhGiaDataSource"
				DataKeyNames="MaQuanLy"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_NoiDungDanhGia.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SoThuTu" HeaderText="So Thu Tu" SortExpression="[SoThuTu]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]" ReadOnly="True" />
				<asp:BoundField DataField="TenNoiDungDanhGia" HeaderText="Ten Noi Dung Danh Gia" SortExpression="[TenNoiDungDanhGia]"  />
				<asp:BoundField DataField="VietTat" HeaderText="Viet Tat" SortExpression="[VietTat]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No NoiDungDanhGia Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnNoiDungDanhGia" OnClientClick="javascript:location.href='NoiDungDanhGiaEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:NoiDungDanhGiaDataSource ID="NoiDungDanhGiaDataSource" runat="server"
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
		</data:NoiDungDanhGiaDataSource>
	    		
</asp:Content>



