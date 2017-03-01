<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DonGiaMotTiet.aspx.cs" Inherits="DonGiaMotTiet" Title="DonGiaMotTiet List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Don Gia Mot Tiet List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="DonGiaMotTietDataSource"
				DataKeyNames="MaHocHam, MaHocVi"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_DonGiaMotTiet.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="DonGiaMotTiet" HeaderText="Don Gia Mot Tiet" SortExpression="[DonGiaMotTiet]"  />
				<asp:BoundField DataField="TenHocVi" HeaderText="Ten Hoc Vi" SortExpression="[TenHocVi]"  />
				<asp:BoundField DataField="TenHocHam" HeaderText="Ten Hoc Ham" SortExpression="[TenHocHam]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]" ReadOnly="True" />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]" ReadOnly="True" />
			</Columns>
			<EmptyDataTemplate>
				<b>No DonGiaMotTiet Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnDonGiaMotTiet" OnClientClick="javascript:location.href='DonGiaMotTietEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:DonGiaMotTietDataSource ID="DonGiaMotTietDataSource" runat="server"
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
		</data:DonGiaMotTietDataSource>
	    		
</asp:Content>



