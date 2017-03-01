<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DanhGiaCoVanHocTap.aspx.cs" Inherits="DanhGiaCoVanHocTap" Title="DanhGiaCoVanHocTap List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Danh Gia Co Van Hoc Tap List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="DanhGiaCoVanHocTapDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_DanhGiaCoVanHocTap.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="PhanTramHuongThu" HeaderText="Phan Tram Huong Thu" SortExpression="[PhanTramHuongThu]"  />
				<asp:BoundField DataField="NoiDungDanhGia" HeaderText="Noi Dung Danh Gia" SortExpression="[NoiDungDanhGia]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No DanhGiaCoVanHocTap Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnDanhGiaCoVanHocTap" OnClientClick="javascript:location.href='DanhGiaCoVanHocTapEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:DanhGiaCoVanHocTapDataSource ID="DanhGiaCoVanHocTapDataSource" runat="server"
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
		</data:DanhGiaCoVanHocTapDataSource>
	    		
</asp:Content>



