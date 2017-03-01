﻿<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LopHocPhanGiangBangTiengNuocNgoai.aspx.cs" Inherits="LopHocPhanGiangBangTiengNuocNgoai" Title="LopHocPhanGiangBangTiengNuocNgoai List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Lop Hoc Phan Giang Bang Tieng Nuoc Ngoai List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="LopHocPhanGiangBangTiengNuocNgoaiDataSource"
				DataKeyNames="MaLopHocPhan"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_LopHocPhanGiangBangTiengNuocNgoai.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NgonNgu" HeaderText="Ngon Ngu" SortExpression="[NgonNgu]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" ReadOnly="True" />
				<data:BoundRadioButtonField DataField="Chon" HeaderText="Chon" SortExpression="[Chon]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No LopHocPhanGiangBangTiengNuocNgoai Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnLopHocPhanGiangBangTiengNuocNgoai" OnClientClick="javascript:location.href='LopHocPhanGiangBangTiengNuocNgoaiEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:LopHocPhanGiangBangTiengNuocNgoaiDataSource ID="LopHocPhanGiangBangTiengNuocNgoaiDataSource" runat="server"
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
		</data:LopHocPhanGiangBangTiengNuocNgoaiDataSource>
	    		
</asp:Content>


