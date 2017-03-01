<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiKhoiLuongEdit.aspx.cs" Inherits="LoaiKhoiLuongEdit" Title="LoaiKhoiLuong Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Khoi Luong - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLoaiKhoiLuong" runat="server" DataSourceID="LoaiKhoiLuongDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiKhoiLuongFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiKhoiLuongFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LoaiKhoiLuong not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LoaiKhoiLuongDataSource ID="LoaiKhoiLuongDataSource" runat="server"
			SelectMethod="GetByMaLoaiKhoiLuong"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLoaiKhoiLuong" QueryStringField="MaLoaiKhoiLuong" Type="String" />

			</Parameters>
		</data:LoaiKhoiLuongDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewQuyDoiGioChuan1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewQuyDoiGioChuan1_SelectedIndexChanged"			 			 
			DataSourceID="QuyDoiGioChuanDataSource1"
			DataKeyNames="MaQuyDoi"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_QuyDoiGioChuan.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Don Vi" DataNavigateUrlFormatString="DonViTinhEdit.aspx?MaDonVi={0}" DataNavigateUrlFields="MaDonVi" DataContainer="MaDonViSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]" />				
				<asp:BoundField DataField="TenQuyDoi" HeaderText="Ten Quy Doi" SortExpression="[TenQuyDoi]" />				
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]" />				
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]" />				
				<asp:BoundField DataField="CongDon" HeaderText="Cong Don" SortExpression="[CongDon]" />				
				<asp:BoundField DataField="LoaiQuyDoi" HeaderText="Loai Quy Doi" SortExpression="[LoaiQuyDoi]" />				
				<asp:BoundField DataField="ThuTu" HeaderText="Thu Tu" SortExpression="[ThuTu]" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<data:HyperLinkField HeaderText="Ma Loai Khoi Luong" DataNavigateUrlFormatString="LoaiKhoiLuongEdit.aspx?MaLoaiKhoiLuong={0}" DataNavigateUrlFields="MaLoaiKhoiLuong" DataContainer="MaLoaiKhoiLuongSource" DataTextField="TenLoaiKhoiLuong" />
				<asp:BoundField DataField="CoSuDungHeSoChucDanh" HeaderText="Co Su Dung He So Chuc Danh" SortExpression="[CoSuDungHeSoChucDanh]" />				
				<asp:BoundField DataField="NhomMonHoc" HeaderText="Nhom Mon Hoc" SortExpression="[NhomMonHoc]" />				
				<asp:BoundField DataField="KhoaNhapLieu" HeaderText="Khoa Nhap Lieu" SortExpression="[KhoaNhapLieu]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Quy Doi Gio Chuan Found! </b>
				<asp:HyperLink runat="server" ID="hypQuyDoiGioChuan" NavigateUrl="~/admin/QuyDoiGioChuanEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:QuyDoiGioChuanDataSource ID="QuyDoiGioChuanDataSource1" runat="server" SelectMethod="Find"
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
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:QuyDoiGioChuanFilter  Column="MaLoaiKhoiLuong" QueryStringField="MaLoaiKhoiLuong" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:QuyDoiGioChuanDataSource>		
		
		<br />
		

</asp:Content>

