<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DanhMucHoatDongQuanLy.aspx.cs" Inherits="DanhMucHoatDongQuanLy" Title="DanhMucHoatDongQuanLy List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Danh Muc Hoat Dong Quan Ly List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="DanhMucHoatDongQuanLyDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_DanhMucHoatDongQuanLy.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<data:BoundRadioButtonField DataField="HienThiLenWeb" HeaderText="Hien Thi Len Web" SortExpression="[HienThiLenWeb]"  />
				<asp:BoundField DataField="MaHoatDong" HeaderText="Ma Hoat Dong" SortExpression="[MaHoatDong]"  />
				<asp:BoundField DataField="TenHoatDong" HeaderText="Ten Hoat Dong" SortExpression="[TenHoatDong]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No DanhMucHoatDongQuanLy Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnDanhMucHoatDongQuanLy" OnClientClick="javascript:location.href='DanhMucHoatDongQuanLyEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:DanhMucHoatDongQuanLyDataSource ID="DanhMucHoatDongQuanLyDataSource" runat="server"
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
		</data:DanhMucHoatDongQuanLyDataSource>
	    		
</asp:Content>



