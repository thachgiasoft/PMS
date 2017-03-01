<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DinhMucGioChuan.aspx.cs" Inherits="DinhMucGioChuan" Title="DinhMucGioChuan List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Dinh Muc Gio Chuan List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="DinhMucGioChuanDataSource"
				DataKeyNames="MaDinhMuc"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_DinhMucGioChuan.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="TongDinhMuc" HeaderText="Tong Dinh Muc" SortExpression="[TongDinhMuc]"  />
				<asp:BoundField DataField="TuHeSoLuong" HeaderText="Tu He So Luong" SortExpression="[TuHeSoLuong]"  />
				<asp:BoundField DataField="DenHeSoLuong" HeaderText="Den He So Luong" SortExpression="[DenHeSoLuong]"  />
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<asp:BoundField DataField="PhanLoaiGiangVien" HeaderText="Phan Loai Giang Vien" SortExpression="[PhanLoaiGiangVien]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
				<asp:BoundField DataField="DinhMucMonHoc" HeaderText="Dinh Muc Mon Hoc" SortExpression="[DinhMucMonHoc]"  />
				<asp:BoundField DataField="Stt" HeaderText="Stt" SortExpression="[STT]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="DinhMucMonGdtcQp" HeaderText="Dinh Muc Mon Gdtc Qp" SortExpression="[DinhMucMonGdtcQp]"  />
				<asp:BoundField DataField="MaBacLuong" HeaderText="Ma Bac Luong" SortExpression="[MaBacLuong]"  />
				<asp:BoundField DataField="DinhMucHoatDongChuyenMonKhac" HeaderText="Dinh Muc Hoat Dong Chuyen Mon Khac" SortExpression="[DinhMucHoatDongChuyenMonKhac]"  />
				<asp:BoundField DataField="DinhMucNckh" HeaderText="Dinh Muc Nckh" SortExpression="[DinhMucNckh]"  />
				<asp:BoundField DataField="HeSoLuongTangThem" HeaderText="He So Luong Tang Them" SortExpression="[HeSoLuongTangThem]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No DinhMucGioChuan Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnDinhMucGioChuan" OnClientClick="javascript:location.href='DinhMucGioChuanEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:DinhMucGioChuanDataSource ID="DinhMucGioChuanDataSource" runat="server"
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
		</data:DinhMucGioChuanDataSource>
	    		
</asp:Content>



