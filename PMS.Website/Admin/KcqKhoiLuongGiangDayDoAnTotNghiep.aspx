<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqKhoiLuongGiangDayDoAnTotNghiep.aspx.cs" Inherits="KcqKhoiLuongGiangDayDoAnTotNghiep" Title="KcqKhoiLuongGiangDayDoAnTotNghiep List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Khoi Luong Giang Day Do An Tot Nghiep List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KcqKhoiLuongGiangDayDoAnTotNghiepDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KcqKhoiLuongGiangDayDoAnTotNghiep.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SoTinChi" HeaderText="So Tin Chi" SortExpression="[SoTinChi]"  />
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]"  />
				<asp:BoundField DataField="Nhom" HeaderText="Nhom" SortExpression="[Nhom]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="SiSo" HeaderText="Si So" SortExpression="[SiSo]"  />
				<data:BoundRadioButtonField DataField="LopClc" HeaderText="Lop Clc" SortExpression="[LopClc]"  />
				<asp:BoundField DataField="MaHocPhan" HeaderText="Ma Hoc Phan" SortExpression="[MaHocPhan]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KcqKhoiLuongGiangDayDoAnTotNghiep Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKcqKhoiLuongGiangDayDoAnTotNghiep" OnClientClick="javascript:location.href='KcqKhoiLuongGiangDayDoAnTotNghiepEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KcqKhoiLuongGiangDayDoAnTotNghiepDataSource ID="KcqKhoiLuongGiangDayDoAnTotNghiepDataSource" runat="server"
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
		</data:KcqKhoiLuongGiangDayDoAnTotNghiepDataSource>
	    		
</asp:Content>



