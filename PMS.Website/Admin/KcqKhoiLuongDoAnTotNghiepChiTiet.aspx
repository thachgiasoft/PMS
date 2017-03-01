<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqKhoiLuongDoAnTotNghiepChiTiet.aspx.cs" Inherits="KcqKhoiLuongDoAnTotNghiepChiTiet" Title="KcqKhoiLuongDoAnTotNghiepChiTiet List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Khoi Luong Do An Tot Nghiep Chi Tiet List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KcqKhoiLuongDoAnTotNghiepChiTietDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KcqKhoiLuongDoAnTotNghiepChiTiet.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
				<asp:BoundField DataField="SoLuongHuongDan" HeaderText="So Luong Huong Dan" SortExpression="[SoLuongHuongDan]"  />
				<asp:BoundField DataField="MaLoaiHocPhan" HeaderText="Ma Loai Hoc Phan" SortExpression="[MaLoaiHocPhan]"  />
				<data:BoundRadioButtonField DataField="LopClc" HeaderText="Lop Clc" SortExpression="[LopClc]"  />
				<asp:BoundField DataField="MaDot" HeaderText="Ma Dot" SortExpression="[MaDot]"  />
				<asp:BoundField DataField="MaDiaDiem" HeaderText="Ma Dia Diem" SortExpression="[MaDiaDiem]"  />
				<asp:BoundField DataField="HeSoHocKy" HeaderText="He So Hoc Ky" SortExpression="[HeSoHocKy]"  />
				<asp:BoundField DataField="SoTien" HeaderText="So Tien" SortExpression="[SoTien]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
				<asp:BoundField DataField="SoTinChi" HeaderText="So Tin Chi" SortExpression="[SoTinChi]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="HoTen" HeaderText="Ho Ten" SortExpression="[HoTen]"  />
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]"  />
				<asp:BoundField DataField="Nhom" HeaderText="Nhom" SortExpression="[Nhom]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KcqKhoiLuongDoAnTotNghiepChiTiet Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKcqKhoiLuongDoAnTotNghiepChiTiet" OnClientClick="javascript:location.href='KcqKhoiLuongDoAnTotNghiepChiTietEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KcqKhoiLuongDoAnTotNghiepChiTietDataSource ID="KcqKhoiLuongDoAnTotNghiepChiTietDataSource" runat="server"
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
		</data:KcqKhoiLuongDoAnTotNghiepChiTietDataSource>
	    		
</asp:Content>



