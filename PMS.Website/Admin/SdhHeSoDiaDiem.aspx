<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="SdhHeSoDiaDiem.aspx.cs" Inherits="SdhHeSoDiaDiem" Title="SdhHeSoDiaDiem List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Sdh He So Dia Diem List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="SdhHeSoDiaDiemDataSource"
				DataKeyNames="MaHeSo"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_SdhHeSoDiaDiem.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
				<asp:BoundField DataField="TienXeDiaDiem" HeaderText="Tien Xe Dia Diem" SortExpression="[TienXeDiaDiem]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="HeSoDiaDiem" HeaderText="He So Dia Diem" SortExpression="[HeSoDiaDiem]"  />
				<asp:BoundField DataField="Stt" HeaderText="Stt" SortExpression="[Stt]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="TenDiaDiem" HeaderText="Ten Dia Diem" SortExpression="[TenDiaDiem]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No SdhHeSoDiaDiem Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnSdhHeSoDiaDiem" OnClientClick="javascript:location.href='SdhHeSoDiaDiemEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:SdhHeSoDiaDiemDataSource ID="SdhHeSoDiaDiemDataSource" runat="server"
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
		</data:SdhHeSoDiaDiemDataSource>
	    		
</asp:Content>



