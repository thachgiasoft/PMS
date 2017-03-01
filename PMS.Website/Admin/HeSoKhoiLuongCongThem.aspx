<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoKhoiLuongCongThem.aspx.cs" Inherits="HeSoKhoiLuongCongThem" Title="HeSoKhoiLuongCongThem List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Khoi Luong Cong Them List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="HeSoKhoiLuongCongThemDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_HeSoKhoiLuongCongThem.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="Stt" HeaderText="Stt" SortExpression="[Stt]"  />
				<asp:BoundField DataField="TuSoTiet" HeaderText="Tu So Tiet" SortExpression="[TuSoTiet]"  />
				<asp:BoundField DataField="DenSoTiet" HeaderText="Den So Tiet" SortExpression="[DenSoTiet]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No HeSoKhoiLuongCongThem Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnHeSoKhoiLuongCongThem" OnClientClick="javascript:location.href='HeSoKhoiLuongCongThemEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:HeSoKhoiLuongCongThemDataSource ID="HeSoKhoiLuongCongThemDataSource" runat="server"
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
		</data:HeSoKhoiLuongCongThemDataSource>
	    		
</asp:Content>



