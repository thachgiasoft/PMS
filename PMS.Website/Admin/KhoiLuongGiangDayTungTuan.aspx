<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongGiangDayTungTuan.aspx.cs" Inherits="KhoiLuongGiangDayTungTuan" Title="KhoiLuongGiangDayTungTuan List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Giang Day Tung Tuan List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KhoiLuongGiangDayTungTuanDataSource"
				DataKeyNames="MaKhoiLuong"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KhoiLuongGiangDayTungTuan.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MaToaNha" HeaderText="Ma Toa Nha" SortExpression="[MaToaNha]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]"  />
				<asp:BoundField DataField="MaNhom" HeaderText="Ma Nhom" SortExpression="[MaNhom]"  />
				<asp:BoundField DataField="LoaiHocPhan" HeaderText="Loai Hoc Phan" SortExpression="[LoaiHocPhan]"  />
				<asp:BoundField DataField="PhanLoai" HeaderText="Phan Loai" SortExpression="[PhanLoai]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="DienGiai" HeaderText="Dien Giai" SortExpression="[DienGiai]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="SoTinChi" HeaderText="So Tin Chi" SortExpression="[SoTinChi]"  />
				<asp:BoundField DataField="SiSoLop" HeaderText="Si So Lop" SortExpression="[SiSoLop]"  />
				<asp:BoundField DataField="SoNhom" HeaderText="So Nhom" SortExpression="[SoNhom]"  />
				<asp:BoundField DataField="MaDiaDiem" HeaderText="Ma Dia Diem" SortExpression="[MaDiaDiem]"  />
				<asp:BoundField DataField="NgayBatDau" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Bat Dau" SortExpression="[NgayBatDau]"  />
				<asp:BoundField DataField="NgayKetThuc" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Ket Thuc" SortExpression="[NgayKetThuc]"  />
				<asp:BoundField DataField="ChatLuongCao" HeaderText="Chat Luong Cao" SortExpression="[ChatLuongCao]"  />
				<asp:BoundField DataField="NgoaiGio" HeaderText="Ngoai Gio" SortExpression="[NgoaiGio]"  />
				<asp:BoundField DataField="TrongGio" HeaderText="Trong Gio" SortExpression="[TrongGio]"  />
				<asp:BoundField DataField="HeSoLopDong" HeaderText="He So Lop Dong" SortExpression="[HeSoLopDong]"  />
				<asp:BoundField DataField="HeSoCoSo" HeaderText="He So Co So" SortExpression="[HeSoCoSo]"  />
				<asp:BoundField DataField="HeSoHocKy" HeaderText="He So Hoc Ky" SortExpression="[HeSoHocKy]"  />
				<asp:BoundField DataField="HeSoThanhPhan" HeaderText="He So Thanh Phan" SortExpression="[HeSoThanhPhan]"  />
				<asp:BoundField DataField="HeSoTrongGio" HeaderText="He So Trong Gio" SortExpression="[HeSoTrongGio]"  />
				<asp:BoundField DataField="HeSoNgoaiGio" HeaderText="He So Ngoai Gio" SortExpression="[HeSoNgoaiGio]"  />
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]"  />
				<asp:BoundField DataField="LoaiHocKy" HeaderText="Loai Hoc Ky" SortExpression="[LoaiHocKy]"  />
				<asp:BoundField DataField="ThoiKhoaBieu" HeaderText="Thoi Khoa Bieu" SortExpression="[ThoiKhoaBieu]"  />
				<asp:BoundField DataField="NgayTao" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Tao" SortExpression="[NgayTao]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="Tuan" HeaderText="Tuan" SortExpression="[Tuan]"  />
				<asp:BoundField DataField="Nam" HeaderText="Nam" SortExpression="[Nam]"  />
				<asp:BoundField DataField="NgayDay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Day" SortExpression="[NgayDay]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KhoiLuongGiangDayTungTuan Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKhoiLuongGiangDayTungTuan" OnClientClick="javascript:location.href='KhoiLuongGiangDayTungTuanEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KhoiLuongGiangDayTungTuanDataSource ID="KhoiLuongGiangDayTungTuanDataSource" runat="server"
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
		</data:KhoiLuongGiangDayTungTuanDataSource>
	    		
</asp:Content>



