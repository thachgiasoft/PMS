<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoNgay.aspx.cs" Inherits="HeSoNgay" Title="HeSoNgay List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Ngay List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="HeSoNgayDataSource"
				DataKeyNames="MaHeSo"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_HeSoNgay.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="TenHeSo" HeaderText="Ten He So" SortExpression="[TenHeSo]"  />
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<asp:BoundField DataField="TietBatDau" HeaderText="Tiet Bat Dau" SortExpression="[TietBatDau]"  />
				<asp:BoundField DataField="TietKetThuc" HeaderText="Tiet Ket Thuc" SortExpression="[TietKetThuc]"  />
				<data:BoundRadioButtonField DataField="TietNghiaVu" HeaderText="Tiet Nghia Vu" SortExpression="[TietNghiaVu]"  />
				<data:BoundRadioButtonField DataField="TrongGio" HeaderText="Trong Gio" SortExpression="[TrongGio]"  />
				<asp:BoundField DataField="MaBuoi" HeaderText="Ma Buoi" SortExpression="[MaBuoi]"  />
				<asp:BoundField DataField="TenBuoi" HeaderText="Ten Buoi" SortExpression="[TenBuoi]"  />
				<asp:BoundField DataField="ThuTu" HeaderText="Thu Tu" SortExpression="[ThuTu]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No HeSoNgay Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnHeSoNgay" OnClientClick="javascript:location.href='HeSoNgayEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:HeSoNgayDataSource ID="HeSoNgayDataSource" runat="server"
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
		</data:HeSoNgayDataSource>
	    		
</asp:Content>



