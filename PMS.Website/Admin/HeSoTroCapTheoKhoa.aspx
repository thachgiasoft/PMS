<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoTroCapTheoKhoa.aspx.cs" Inherits="HeSoTroCapTheoKhoa" Title="HeSoTroCapTheoKhoa List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Tro Cap Theo Khoa List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="HeSoTroCapTheoKhoaDataSource"
				DataKeyNames="MaKhoa"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_HeSoTroCapTheoKhoa.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<asp:BoundField DataField="TenKhoa" HeaderText="Ten Khoa" SortExpression="[TenKhoa]"  />
				<asp:BoundField DataField="MaKhoa" HeaderText="Ma Khoa" SortExpression="[MaKhoa]" ReadOnly="True" />
			</Columns>
			<EmptyDataTemplate>
				<b>No HeSoTroCapTheoKhoa Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnHeSoTroCapTheoKhoa" OnClientClick="javascript:location.href='HeSoTroCapTheoKhoaEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:HeSoTroCapTheoKhoaDataSource ID="HeSoTroCapTheoKhoaDataSource" runat="server"
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
		</data:HeSoTroCapTheoKhoaDataSource>
	    		
</asp:Content>



