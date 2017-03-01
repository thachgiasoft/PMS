﻿<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DuTruGioGiangKhiCoLopHocPhan.aspx.cs" Inherits="DuTruGioGiangKhiCoLopHocPhan" Title="DuTruGioGiangKhiCoLopHocPhan List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Du Tru Gio Giang Khi Co Lop Hoc Phan List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="DuTruGioGiangKhiCoLopHocPhanDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_DuTruGioGiangKhiCoLopHocPhan.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MaNhomMonHoc" HeaderText="Ma Nhom Mon Hoc" SortExpression="[MaNhomMonHoc]"  />
				<asp:BoundField DataField="HeSoBacDaoTao" HeaderText="He So Bac Dao Tao" SortExpression="[HeSoBacDaoTao]"  />
				<asp:BoundField DataField="TenLoaiHocPhan" HeaderText="Ten Loai Hoc Phan" SortExpression="[TenLoaiHocPhan]"  />
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]"  />
				<asp:BoundField DataField="HeSoLopDong" HeaderText="He So Lop Dong" SortExpression="[HeSoLopDong]"  />
				<asp:BoundField DataField="SoTietQuyDoi" HeaderText="So Tiet Quy Doi" SortExpression="[SoTietQuyDoi]"  />
				<asp:BoundField DataField="MaDonVi" HeaderText="Ma Don Vi" SortExpression="[MaDonVi]"  />
				<asp:BoundField DataField="HeSoMonThucTap" HeaderText="He So Mon Thuc Tap" SortExpression="[HeSoMonThucTap]"  />
				<asp:BoundField DataField="HeSoCoVanHocTap" HeaderText="He So Co Van Hoc Tap" SortExpression="[HeSoCoVanHocTap]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="TenLopHocPhan" HeaderText="Ten Lop Hoc Phan" SortExpression="[TenLopHocPhan]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="SiSo" HeaderText="Si So" SortExpression="[SiSo]"  />
				<asp:BoundField DataField="MaLoaiHocPhan" HeaderText="Ma Loai Hoc Phan" SortExpression="[MaLoaiHocPhan]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No DuTruGioGiangKhiCoLopHocPhan Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnDuTruGioGiangKhiCoLopHocPhan" OnClientClick="javascript:location.href='DuTruGioGiangKhiCoLopHocPhanEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:DuTruGioGiangKhiCoLopHocPhanDataSource ID="DuTruGioGiangKhiCoLopHocPhanDataSource" runat="server"
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
		</data:DuTruGioGiangKhiCoLopHocPhanDataSource>
	    		
</asp:Content>


