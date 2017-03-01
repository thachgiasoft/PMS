<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NhomHoatDongNgoaiGiangDay.aspx.cs" Inherits="NhomHoatDongNgoaiGiangDay" Title="NhomHoatDongNgoaiGiangDay List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nhom Hoat Dong Ngoai Giang Day List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="NhomHoatDongNgoaiGiangDayDataSource"
				DataKeyNames="MaNhom"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_NhomHoatDongNgoaiGiangDay.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="OrderBy" HeaderText="Order By" SortExpression="[OrderBy]"  />
				<asp:BoundField DataField="MaNhom" HeaderText="Ma Nhom" SortExpression="[MaNhom]" ReadOnly="True" />
				<asp:BoundField DataField="TenNhom" HeaderText="Ten Nhom" SortExpression="[TenNhom]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No NhomHoatDongNgoaiGiangDay Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnNhomHoatDongNgoaiGiangDay" OnClientClick="javascript:location.href='NhomHoatDongNgoaiGiangDayEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:NhomHoatDongNgoaiGiangDayDataSource ID="NhomHoatDongNgoaiGiangDayDataSource" runat="server"
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
		</data:NhomHoatDongNgoaiGiangDayDataSource>
	    		
</asp:Content>



