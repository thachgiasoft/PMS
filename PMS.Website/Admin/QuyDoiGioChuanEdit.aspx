<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="QuyDoiGioChuanEdit.aspx.cs" Inherits="QuyDoiGioChuanEdit" Title="QuyDoiGioChuan Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Quy Doi Gio Chuan - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaQuyDoi" runat="server" DataSourceID="QuyDoiGioChuanDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/QuyDoiGioChuanFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/QuyDoiGioChuanFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>QuyDoiGioChuan not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:QuyDoiGioChuanDataSource ID="QuyDoiGioChuanDataSource" runat="server"
			SelectMethod="GetByMaQuyDoi"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaQuyDoi" QueryStringField="MaQuyDoi" Type="String" />

			</Parameters>
		</data:QuyDoiGioChuanDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewKhoiLuongCacCongViecKhac1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKhoiLuongCacCongViecKhac1_SelectedIndexChanged"			 			 
			DataSourceID="KhoiLuongCacCongViecKhacDataSource1"
			DataKeyNames="Id, MaLoaiCongViec"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KhoiLuongCacCongViecKhac.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]" />				
				<data:HyperLinkField HeaderText="Ma Loai Cong Viec" DataNavigateUrlFormatString="QuyDoiGioChuanEdit.aspx?MaQuyDoi={0}" DataNavigateUrlFields="MaQuyDoi" DataContainer="MaLoaiCongViecSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="MaDonViTinh" HeaderText="Ma Don Vi Tinh" SortExpression="[MaDonViTinh]" />				
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]" />				
				<asp:BoundField DataField="HeSoNhan" HeaderText="He So Nhan" SortExpression="[HeSoNhan]" />				
				<asp:BoundField DataField="GioChuanCongThemTrenMotTiet" HeaderText="Gio Chuan Cong Them Tren Mot Tiet" SortExpression="[GioChuanCongThemTrenMotTiet]" />				
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]" />				
				<asp:BoundField DataField="MaNhom" HeaderText="Ma Nhom" SortExpression="[MaNhom]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="HeSoQuyDoi" HeaderText="He So Quy Doi" SortExpression="[HeSoQuyDoi]" />				
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]" />				
				<asp:BoundField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="HeSoChucDanhKhoiLuongKhac" HeaderText="He So Chuc Danh Khoi Luong Khac" SortExpression="[HeSoChucDanhKhoiLuongKhac]" />				
				<asp:BoundField DataField="DotThanhToan" HeaderText="Dot Thanh Toan" SortExpression="[DotThanhToan]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Khoi Luong Cac Cong Viec Khac Found! </b>
				<asp:HyperLink runat="server" ID="hypKhoiLuongCacCongViecKhac" NavigateUrl="~/admin/KhoiLuongCacCongViecKhacEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KhoiLuongCacCongViecKhacDataSource ID="KhoiLuongCacCongViecKhacDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KhoiLuongCacCongViecKhacProperty Name="QuyDoiGioChuan"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KhoiLuongCacCongViecKhacFilter  Column="MaLoaiCongViec" QueryStringField="MaQuyDoi" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KhoiLuongCacCongViecKhacDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewKhoanQuyDoi2" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKhoanQuyDoi2_SelectedIndexChanged"			 			 
			DataSourceID="KhoanQuyDoiDataSource2"
			DataKeyNames="MaKhoan"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KhoanQuyDoi.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Quy Doi" DataNavigateUrlFormatString="QuyDoiGioChuanEdit.aspx?MaQuyDoi={0}" DataNavigateUrlFields="MaQuyDoi" DataContainer="MaQuyDoiSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="TuKhoan" HeaderText="Tu Khoan" SortExpression="[TuKhoan]" />				
				<asp:BoundField DataField="DenKhoan" HeaderText="Den Khoan" SortExpression="[DenKhoan]" />				
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]" />				
				<asp:BoundField DataField="ThuTu" HeaderText="Thu Tu" SortExpression="[ThuTu]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Khoan Quy Doi Found! </b>
				<asp:HyperLink runat="server" ID="hypKhoanQuyDoi" NavigateUrl="~/admin/KhoanQuyDoiEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KhoanQuyDoiDataSource ID="KhoanQuyDoiDataSource2" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KhoanQuyDoiProperty Name="QuyDoiGioChuan"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KhoanQuyDoiFilter  Column="MaQuyDoi" QueryStringField="MaQuyDoi" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KhoanQuyDoiDataSource>		
		
		<br />
		

</asp:Content>

