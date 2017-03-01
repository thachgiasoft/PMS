<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HinhThucDaoTao.aspx.cs" Inherits="HinhThucDaoTao" Title="HinhThucDaoTao List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Hinh Thuc Dao Tao List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="HinhThucDaoTaoDataSource"
				DataKeyNames="MaHinhThucDaoTao"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_HinhThucDaoTao.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="HeSoNhanDonGia" HeaderText="He So Nhan Don Gia" SortExpression="[HeSoNhanDonGia]"  />
				<data:BoundRadioButtonField DataField="TinhGioChuan" HeaderText="Tinh Gio Chuan" SortExpression="[TinhGioChuan]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="MaHinhThucDaoTao" HeaderText="Ma Hinh Thuc Dao Tao" SortExpression="[MaHinhThucDaoTao]" ReadOnly="True" />
				<asp:BoundField DataField="TenHinhThucDaoTao" HeaderText="Ten Hinh Thuc Dao Tao" SortExpression="[TenHinhThucDaoTao]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No HinhThucDaoTao Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnHinhThucDaoTao" OnClientClick="javascript:location.href='HinhThucDaoTaoEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:HinhThucDaoTaoDataSource ID="HinhThucDaoTaoDataSource" runat="server"
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
		</data:HinhThucDaoTaoDataSource>
	    		
</asp:Content>



