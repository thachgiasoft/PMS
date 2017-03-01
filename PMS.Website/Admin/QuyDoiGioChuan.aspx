<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="QuyDoiGioChuan.aspx.cs" Inherits="QuyDoiGioChuan" Title="QuyDoiGioChuan List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Quy Doi Gio Chuan List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="QuyDoiGioChuanDataSource"
				DataKeyNames="MaQuyDoi"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_QuyDoiGioChuan.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<data:BoundRadioButtonField DataField="KhoaNhapLieu" HeaderText="Khoa Nhap Lieu" SortExpression="[KhoaNhapLieu]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<data:BoundRadioButtonField DataField="CoSuDungHeSoChucDanh" HeaderText="Co Su Dung He So Chuc Danh" SortExpression="[CoSuDungHeSoChucDanh]"  />
				<asp:BoundField DataField="NhomMonHoc" HeaderText="Nhom Mon Hoc" SortExpression="[NhomMonHoc]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<data:HyperLinkField HeaderText="Ma Loai Khoi Luong" DataNavigateUrlFormatString="LoaiKhoiLuongEdit.aspx?MaLoaiKhoiLuong={0}" DataNavigateUrlFields="MaLoaiKhoiLuong" DataContainer="MaLoaiKhoiLuongSource" DataTextField="TenLoaiKhoiLuong" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<data:HyperLinkField HeaderText="Ma Don Vi" DataNavigateUrlFormatString="DonViTinhEdit.aspx?MaDonVi={0}" DataNavigateUrlFields="MaDonVi" DataContainer="MaDonViSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="TenQuyDoi" HeaderText="Ten Quy Doi" SortExpression="[TenQuyDoi]"  />
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]"  />
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<data:BoundRadioButtonField DataField="CongDon" HeaderText="Cong Don" SortExpression="[CongDon]"  />
				<asp:BoundField DataField="LoaiQuyDoi" HeaderText="Loai Quy Doi" SortExpression="[LoaiQuyDoi]"  />
				<asp:BoundField DataField="ThuTu" HeaderText="Thu Tu" SortExpression="[ThuTu]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No QuyDoiGioChuan Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnQuyDoiGioChuan" OnClientClick="javascript:location.href='QuyDoiGioChuanEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:QuyDoiGioChuanDataSource ID="QuyDoiGioChuanDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:QuyDoiGioChuanProperty Name="DonViTinh"/> 
					<data:QuyDoiGioChuanProperty Name="LoaiKhoiLuong"/> 
					<%--<data:QuyDoiGioChuanProperty Name="KhoiLuongCacCongViecKhacCollection" />--%>
					<%--<data:QuyDoiGioChuanProperty Name="KhoanQuyDoiCollection" />--%>
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:QuyDoiGioChuanDataSource>
	    		
</asp:Content>



