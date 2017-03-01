<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienEdit.aspx.cs" Inherits="GiangVienEdit" Title="GiangVien Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaGiangVien" runat="server" DataSourceID="GiangVienDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>GiangVien not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:GiangVienDataSource ID="GiangVienDataSource" runat="server"
			SelectMethod="GetByMaGiangVien"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaGiangVien" QueryStringField="MaGiangVien" Type="String" />

			</Parameters>
		</data:GiangVienDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewTietNoKyTruoc1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewTietNoKyTruoc1_SelectedIndexChanged"			 			 
			DataSourceID="TietNoKyTruocDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_TietNoKyTruoc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="SoTietNoKyTruoc" HeaderText="So Tiet No Ky Truoc" SortExpression="[SoTietNoKyTruoc]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="TietNoKhac" HeaderText="Tiet No Khac" SortExpression="[TietNoKhac]" />				
				<asp:BoundField DataField="NamHocGoc" HeaderText="Nam Hoc Goc" SortExpression="[NamHocGoc]" />				
				<asp:BoundField DataField="TietNoNcKh" HeaderText="Tiet No Nc Kh" SortExpression="[TietNoNcKh]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="LayTuDong" HeaderText="Lay Tu Dong" SortExpression="[LayTuDong]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Tiet No Ky Truoc Found! </b>
				<asp:HyperLink runat="server" ID="hypTietNoKyTruoc" NavigateUrl="~/admin/TietNoKyTruocEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:TietNoKyTruocDataSource ID="TietNoKyTruocDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:TietNoKyTruocProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:TietNoKyTruocFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:TietNoKyTruocDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewKcqKhoiLuongKhac2" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKcqKhoiLuongKhac2_SelectedIndexChanged"			 			 
			DataSourceID="KcqKhoiLuongKhacDataSource2"
			DataKeyNames="MaKhoiLuong"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KcqKhoiLuongKhac.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="LoaiHocPhan" HeaderText="Loai Hoc Phan" SortExpression="[LoaiHocPhan]" />				
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" />				
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]" />				
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]" />				
				<asp:BoundField DataField="MaNhom" HeaderText="Ma Nhom" SortExpression="[MaNhom]" />				
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]" />				
				<asp:BoundField DataField="SoTuan" HeaderText="So Tuan" SortExpression="[SoTuan]" />				
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]" />				
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]" />				
				<asp:BoundField DataField="DienGiai" HeaderText="Dien Giai" SortExpression="[DienGiai]" />				
				<asp:BoundField DataField="PhanLoai" HeaderText="Phan Loai" SortExpression="[PhanLoai]" />				
				<asp:BoundField DataField="NgayTao" HeaderText="Ngay Tao" SortExpression="[NgayTao]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Kcq Khoi Luong Khac Found! </b>
				<asp:HyperLink runat="server" ID="hypKcqKhoiLuongKhac" NavigateUrl="~/admin/KcqKhoiLuongKhacEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KcqKhoiLuongKhacDataSource ID="KcqKhoiLuongKhacDataSource2" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KcqKhoiLuongKhacProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KcqKhoiLuongKhacFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KcqKhoiLuongKhacDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewThuLaoThoaThuan3" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewThuLaoThoaThuan3_SelectedIndexChanged"			 			 
			DataSourceID="ThuLaoThoaThuanDataSource3"
			DataKeyNames="MaThuLao"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_ThuLaoThoaThuan.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="MaHeDaoTao" HeaderText="Ma He Dao Tao" SortExpression="[MaHeDaoTao]" />				
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]" />				
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Thu Lao Thoa Thuan Found! </b>
				<asp:HyperLink runat="server" ID="hypThuLaoThoaThuan" NavigateUrl="~/admin/ThuLaoThoaThuanEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:ThuLaoThoaThuanDataSource ID="ThuLaoThoaThuanDataSource3" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ThuLaoThoaThuanProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:ThuLaoThoaThuanFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:ThuLaoThoaThuanDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewGiangVienCamKetKhongTruThue4" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienCamKetKhongTruThue4_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienCamKetKhongTruThueDataSource4"
			DataKeyNames="MaGiangVien, NamHoc, HocKy"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienCamKetKhongTruThue.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Cam Ket Khong Tru Thue Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienCamKetKhongTruThue" NavigateUrl="~/admin/GiangVienCamKetKhongTruThueEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienCamKetKhongTruThueDataSource ID="GiangVienCamKetKhongTruThueDataSource4" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienCamKetKhongTruThueProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienCamKetKhongTruThueFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienCamKetKhongTruThueDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewThamDinhLuanVanThacSy5" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewThamDinhLuanVanThacSy5_SelectedIndexChanged"			 			 
			DataSourceID="ThamDinhLuanVanThacSyDataSource5"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_ThamDinhLuanVanThacSy.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]" />				
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]" />				
				<asp:BoundField DataField="SoTien" HeaderText="So Tien" SortExpression="[SoTien]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Tham Dinh Luan Van Thac Sy Found! </b>
				<asp:HyperLink runat="server" ID="hypThamDinhLuanVanThacSy" NavigateUrl="~/admin/ThamDinhLuanVanThacSyEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:ThamDinhLuanVanThacSyDataSource ID="ThamDinhLuanVanThacSyDataSource5" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ThamDinhLuanVanThacSyProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:ThamDinhLuanVanThacSyFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:ThamDinhLuanVanThacSyDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewThoiGianLamViecCuaNhanVien6" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewThoiGianLamViecCuaNhanVien6_SelectedIndexChanged"			 			 
			DataSourceID="ThoiGianLamViecCuaNhanVienDataSource6"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_ThoiGianLamViecCuaNhanVien.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="NoiDung" HeaderText="Noi Dung" SortExpression="[NoiDung]" />				
				<asp:BoundField DataField="TuNgay" HeaderText="Tu Ngay" SortExpression="[TuNgay]" />				
				<asp:BoundField DataField="DenNgay" HeaderText="Den Ngay" SortExpression="[DenNgay]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="MaGiamTruDinhMuc" HeaderText="Ma Giam Tru Dinh Muc" SortExpression="[MaGiamTruDinhMuc]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Thoi Gian Lam Viec Cua Nhan Vien Found! </b>
				<asp:HyperLink runat="server" ID="hypThoiGianLamViecCuaNhanVien" NavigateUrl="~/admin/ThoiGianLamViecCuaNhanVienEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:ThoiGianLamViecCuaNhanVienDataSource ID="ThoiGianLamViecCuaNhanVienDataSource6" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ThoiGianLamViecCuaNhanVienProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:ThoiGianLamViecCuaNhanVienFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:ThoiGianLamViecCuaNhanVienDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewGiangVienHoatDongQuanLy7" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienHoatDongQuanLy7_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienHoatDongQuanLyDataSource7"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienHoatDongQuanLy.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<data:HyperLinkField HeaderText="Ma Hoat Dong Quan Ly" DataNavigateUrlFormatString="DanhMucHoatDongQuanLyEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaHoatDongQuanLySource" DataTextField="MaHoatDong" />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]" />				
				<asp:BoundField DataField="NoiDungCongViec" HeaderText="Noi Dung Cong Viec" SortExpression="[NoiDungCongViec]" />				
				<asp:BoundField DataField="NgayThucHien" HeaderText="Ngay Thuc Hien" SortExpression="[NgayThucHien]" />				
				<asp:BoundField DataField="SoPhut" HeaderText="So Phut" SortExpression="[SoPhut]" />				
				<asp:BoundField DataField="HeSoQuyDoi" HeaderText="He So Quy Doi" SortExpression="[HeSoQuyDoi]" />				
				<asp:BoundField DataField="XacNhan" HeaderText="Xac Nhan" SortExpression="[XacNhan]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Hoat Dong Quan Ly Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienHoatDongQuanLy" NavigateUrl="~/admin/GiangVienHoatDongQuanLyEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienHoatDongQuanLyDataSource ID="GiangVienHoatDongQuanLyDataSource7" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienHoatDongQuanLyProperty Name="DanhMucHoatDongQuanLy"/> 
					<data:GiangVienHoatDongQuanLyProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienHoatDongQuanLyFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienHoatDongQuanLyDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewKhoiLuongKhac8" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKhoiLuongKhac8_SelectedIndexChanged"			 			 
			DataSourceID="KhoiLuongKhacDataSource8"
			DataKeyNames="MaKhoiLuong"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KhoiLuongKhac.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="LoaiHocPhan" HeaderText="Loai Hoc Phan" SortExpression="[LoaiHocPhan]" />				
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" />				
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]" />				
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]" />				
				<asp:BoundField DataField="MaNhom" HeaderText="Ma Nhom" SortExpression="[MaNhom]" />				
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]" />				
				<asp:BoundField DataField="SoTuan" HeaderText="So Tuan" SortExpression="[SoTuan]" />				
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]" />				
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]" />				
				<asp:BoundField DataField="DienGiai" HeaderText="Dien Giai" SortExpression="[DienGiai]" />				
				<asp:BoundField DataField="PhanLoai" HeaderText="Phan Loai" SortExpression="[PhanLoai]" />				
				<asp:BoundField DataField="NgayTao" HeaderText="Ngay Tao" SortExpression="[NgayTao]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Khoi Luong Khac Found! </b>
				<asp:HyperLink runat="server" ID="hypKhoiLuongKhac" NavigateUrl="~/admin/KhoiLuongKhacEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KhoiLuongKhacDataSource ID="KhoiLuongKhacDataSource8" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KhoiLuongKhacProperty Name="GiangVien"/> 
					<%--<data:KhoiLuongKhacProperty Name="ChiTietKhoiLuongCollection" />--%>
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KhoiLuongKhacFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KhoiLuongKhacDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewCoVanHocTap9" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewCoVanHocTap9_SelectedIndexChanged"			 			 
			DataSourceID="CoVanHocTapDataSource9"
			DataKeyNames="MaCoVan"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_CoVanHocTap.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]" />				
				<asp:BoundField DataField="MaKhoaHoc" HeaderText="Ma Khoa Hoc" SortExpression="[MaKhoaHoc]" />				
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]" />				
				<asp:BoundField DataField="SoTien" HeaderText="So Tien" SortExpression="[SoTien]" />				
				<asp:BoundField DataField="NgayTao" HeaderText="Ngay Tao" SortExpression="[NgayTao]" />				
				<asp:BoundField DataField="TrangThai" HeaderText="Trang Thai" SortExpression="[TrangThai]" />				
				<asp:BoundField DataField="SiSo" HeaderText="Si So" SortExpression="[SiSo]" />				
				<asp:BoundField DataField="DanhGiaHoanThanh" HeaderText="Danh Gia Hoan Thanh" SortExpression="[DanhGiaHoanThanh]" />				
				<asp:BoundField DataField="NgayKetThuc" HeaderText="Ngay Ket Thuc" SortExpression="[NgayKetThuc]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="Nhom" HeaderText="Nhom" SortExpression="[Nhom]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Co Van Hoc Tap Found! </b>
				<asp:HyperLink runat="server" ID="hypCoVanHocTap" NavigateUrl="~/admin/CoVanHocTapEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:CoVanHocTapDataSource ID="CoVanHocTapDataSource9" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:CoVanHocTapProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:CoVanHocTapFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:CoVanHocTapDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewGiangVienNghienCuuKh10" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienNghienCuuKh10_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienNghienCuuKhDataSource10"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienNghienCuuKh.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<data:HyperLinkField HeaderText="Ma Nckh" DataNavigateUrlFormatString="DanhMucNghienCuuKhoaHocEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaNckhSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]" />				
				<asp:BoundField DataField="NgayHieuLuc" HeaderText="Ngay Hieu Luc" SortExpression="[NgayHieuLuc]" />				
				<asp:BoundField DataField="TrangThai" HeaderText="Trang Thai" SortExpression="[TrangThai]" />				
				<asp:BoundField DataField="NgayHetHieuLuc" HeaderText="Ngay Het Hieu Luc" SortExpression="[NgayHetHieuLuc]" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="TenNckh" HeaderText="Ten Nckh" SortExpression="[TenNckh]" />				
				<asp:BoundField DataField="GioGiangChuyenSangNckh" HeaderText="Gio Giang Chuyen Sang Nckh" SortExpression="[GioGiangChuyenSangNckh]" />				
				<asp:BoundField DataField="NgayNhap" HeaderText="Ngay Nhap" SortExpression="[NgayNhap]" />				
				<asp:BoundField DataField="SoLuongThanhVien" HeaderText="So Luong Thanh Vien" SortExpression="[SoLuongThanhVien]" />				
				<data:HyperLinkField HeaderText="Ma Vai Tro" DataNavigateUrlFormatString="VaiTroEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaVaiTroSource" DataTextField="MaVaiTro" />
				<asp:BoundField DataField="DuKien" HeaderText="Du Kien" SortExpression="[DuKien]" />				
				<asp:BoundField DataField="XacNhan" HeaderText="Xac Nhan" SortExpression="[XacNhan]" />				
				<asp:BoundField DataField="NgayXacNhan" HeaderText="Ngay Xac Nhan" SortExpression="[NgayXacNhan]" />				
				<data:HyperLinkField HeaderText="Muc Do Hoan Thanh" DataNavigateUrlFormatString="MucDoHoanThanhNckhEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MucDoHoanThanhSource" DataTextField="MaQuanLy" />
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Nghien Cuu Kh Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienNghienCuuKh" NavigateUrl="~/admin/GiangVienNghienCuuKhEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienNghienCuuKhDataSource ID="GiangVienNghienCuuKhDataSource10" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienNghienCuuKhProperty Name="DanhMucNghienCuuKhoaHoc"/> 
					<data:GiangVienNghienCuuKhProperty Name="GiangVien"/> 
					<data:GiangVienNghienCuuKhProperty Name="VaiTro"/> 
					<data:GiangVienNghienCuuKhProperty Name="MucDoHoanThanhNckh"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienNghienCuuKhFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienNghienCuuKhDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewGiangVienChucVu11" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienChucVu11_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienChucVuDataSource11"
			DataKeyNames="MaQuanLy, MaGiangVien, MaChucVu"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienChucVu.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<data:HyperLinkField HeaderText="Ma Chuc Vu" DataNavigateUrlFormatString="ChucVuEdit.aspx?MaChucVu={0}" DataNavigateUrlFields="MaChucVu" DataContainer="MaChucVuSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NgayHieuLuc" HeaderText="Ngay Hieu Luc" SortExpression="[NgayHieuLuc]" />				
				<asp:BoundField DataField="NgayHetHieuLuc" HeaderText="Ngay Het Hieu Luc" SortExpression="[NgayHetHieuLuc]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Chuc Vu Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienChucVu" NavigateUrl="~/admin/GiangVienChucVuEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienChucVuDataSource ID="GiangVienChucVuDataSource11" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienChucVuProperty Name="ChucVu"/> 
					<data:GiangVienChucVuProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienChucVuFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienChucVuDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewXetDuyetDeCuongLuanVanCaoHoc12" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewXetDuyetDeCuongLuanVanCaoHoc12_SelectedIndexChanged"			 			 
			DataSourceID="XetDuyetDeCuongLuanVanCaoHocDataSource12"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_XetDuyetDeCuongLuanVanCaoHoc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="MaKhoaHoc" HeaderText="Ma Khoa Hoc" SortExpression="[MaKhoaHoc]" />				
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]" />				
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]" />				
				<asp:BoundField DataField="ThanhTien" HeaderText="Thanh Tien" SortExpression="[ThanhTien]" />				
				<asp:BoundField DataField="Thue" HeaderText="Thue" SortExpression="[Thue]" />				
				<asp:BoundField DataField="ThucLinh" HeaderText="Thuc Linh" SortExpression="[ThucLinh]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Xet Duyet De Cuong Luan Van Cao Hoc Found! </b>
				<asp:HyperLink runat="server" ID="hypXetDuyetDeCuongLuanVanCaoHoc" NavigateUrl="~/admin/XetDuyetDeCuongLuanVanCaoHocEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:XetDuyetDeCuongLuanVanCaoHocDataSource ID="XetDuyetDeCuongLuanVanCaoHocDataSource12" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:XetDuyetDeCuongLuanVanCaoHocProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:XetDuyetDeCuongLuanVanCaoHocFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:XetDuyetDeCuongLuanVanCaoHocDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewKetQuaTinh13" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKetQuaTinh13_SelectedIndexChanged"			 			 
			DataSourceID="KetQuaTinhDataSource13"
			DataKeyNames="MaKetQua"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KetQuaTinh.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="TietNghiaVu" HeaderText="Tiet Nghia Vu" SortExpression="[TietNghiaVu]" />				
				<asp:BoundField DataField="TietGioiHan" HeaderText="Tiet Gioi Han" SortExpression="[TietGioiHan]" />				
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]" />				
				<asp:BoundField DataField="NgayTao" HeaderText="Ngay Tao" SortExpression="[NgayTao]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Ket Qua Tinh Found! </b>
				<asp:HyperLink runat="server" ID="hypKetQuaTinh" NavigateUrl="~/admin/KetQuaTinhEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KetQuaTinhDataSource ID="KetQuaTinhDataSource13" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KetQuaTinhProperty Name="GiangVien"/> 
					<%--<data:KetQuaTinhProperty Name="KhoiLuongGiangDayCollection" />--%>
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KetQuaTinhFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KetQuaTinhDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewThoiGianNghiTamThoiCuaGiangVien14" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewThoiGianNghiTamThoiCuaGiangVien14_SelectedIndexChanged"			 			 
			DataSourceID="ThoiGianNghiTamThoiCuaGiangVienDataSource14"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_ThoiGianNghiTamThoiCuaGiangVien.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="NoiDung" HeaderText="Noi Dung" SortExpression="[NoiDung]" />				
				<asp:BoundField DataField="TuNgay" HeaderText="Tu Ngay" SortExpression="[TuNgay]" />				
				<asp:BoundField DataField="DenNgay" HeaderText="Den Ngay" SortExpression="[DenNgay]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="MaGiamTruDinhMuc" HeaderText="Ma Giam Tru Dinh Muc" SortExpression="[MaGiamTruDinhMuc]" />				
				<asp:BoundField DataField="GioChuanHk01" HeaderText="Gio Chuan Hk01" SortExpression="[GioChuanHk01]" />				
				<asp:BoundField DataField="GioChuanHk02" HeaderText="Gio Chuan Hk02" SortExpression="[GioChuanHk02]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Thoi Gian Nghi Tam Thoi Cua Giang Vien Found! </b>
				<asp:HyperLink runat="server" ID="hypThoiGianNghiTamThoiCuaGiangVien" NavigateUrl="~/admin/ThoiGianNghiTamThoiCuaGiangVienEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:ThoiGianNghiTamThoiCuaGiangVienDataSource ID="ThoiGianNghiTamThoiCuaGiangVienDataSource14" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ThoiGianNghiTamThoiCuaGiangVienProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:ThoiGianNghiTamThoiCuaGiangVienFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:ThoiGianNghiTamThoiCuaGiangVienDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewGiangVienTinhLuongThinhGiang15" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienTinhLuongThinhGiang15_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienTinhLuongThinhGiangDataSource15"
			DataKeyNames="MaGiangVien, NamHoc, HocKy, MaCauHinhChotGio, MaMonHoc, MaLopSinhVien"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienTinhLuongThinhGiang.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Tinh Luong Thinh Giang Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienTinhLuongThinhGiang" NavigateUrl="~/admin/GiangVienTinhLuongThinhGiangEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienTinhLuongThinhGiangDataSource ID="GiangVienTinhLuongThinhGiangDataSource15" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienTinhLuongThinhGiangProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienTinhLuongThinhGiangFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienTinhLuongThinhGiangDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewGiangVienChuyenMon16" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienChuyenMon16_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienChuyenMonDataSource16"
			DataKeyNames="MaPhanCong"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienChuyenMon.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]" />				
				<asp:BoundField DataField="NgayPhanCong" HeaderText="Ngay Phan Cong" SortExpression="[NgayPhanCong]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Chuyen Mon Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienChuyenMon" NavigateUrl="~/admin/GiangVienChuyenMonEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienChuyenMonDataSource ID="GiangVienChuyenMonDataSource16" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienChuyenMonProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienChuyenMonFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienChuyenMonDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewBangPhuTroiNamHoc17" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewBangPhuTroiNamHoc17_SelectedIndexChanged"			 			 
			DataSourceID="BangPhuTroiNamHocDataSource17"
			DataKeyNames="MaGiangVien, NamHoc"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_BangPhuTroiNamHoc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="SoTietNckhTrungCap" HeaderText="So Tiet Nckh Trung Cap" SortExpression="[SoTietNCKH_TrungCap]" />				
				<asp:BoundField DataField="SoTietNckhCaoDang" HeaderText="So Tiet Nckh Cao Dang" SortExpression="[SoTietNCKH_CaoDang]" />				
				<asp:BoundField DataField="GioThiHk1" HeaderText="Gio Thi Hk1" SortExpression="[GioThiHK1]" />				
				<asp:BoundField DataField="GioThiHk2" HeaderText="Gio Thi Hk2" SortExpression="[GioThiHK2]" />				
				<asp:BoundField DataField="TietQuyDoiHuongDanGvTinhNguyen" HeaderText="Tiet Quy Doi Huong Dan Gv Tinh Nguyen" SortExpression="[TietQuyDoiHuongDanGvTinhNguyen]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Bang Phu Troi Nam Hoc Found! </b>
				<asp:HyperLink runat="server" ID="hypBangPhuTroiNamHoc" NavigateUrl="~/admin/BangPhuTroiNamHocEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:BangPhuTroiNamHocDataSource ID="BangPhuTroiNamHocDataSource17" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:BangPhuTroiNamHocProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:BangPhuTroiNamHocFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:BangPhuTroiNamHocDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewTietNghiaVu18" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewTietNghiaVu18_SelectedIndexChanged"			 			 
			DataSourceID="TietNghiaVuDataSource18"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_TietNghiaVu.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]" />				
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]" />				
				<asp:BoundField DataField="SoTietNghiaVu" HeaderText="So Tiet Nghia Vu" SortExpression="[SoTietNghiaVu]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="TietGioiHan" HeaderText="Tiet Gioi Han" SortExpression="[TietGioiHan]" />				
				<asp:BoundField DataField="GhiChu2" HeaderText="Ghi Chu2" SortExpression="[GhiChu2]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<data:HyperLinkField HeaderText="Ma Giam Tru Khac" DataNavigateUrlFormatString="GiamTruDinhMucEdit.aspx?MaQuanLy={0}" DataNavigateUrlFields="MaQuanLy" DataContainer="MaGiamTruKhacSource" DataTextField="NoiDungGiamTru" />
				<asp:BoundField DataField="SoTietGiamTruKhac" HeaderText="So Tiet Giam Tru Khac" SortExpression="[SoTietGiamTruKhac]" />				
				<asp:BoundField DataField="TietNghiaVuCongTacKhac" HeaderText="Tiet Nghia Vu Cong Tac Khac" SortExpression="[TietNghiaVuCongTacKhac]" />				
				<asp:BoundField DataField="TietNghiaVuCongTacKhacSauGiamTru" HeaderText="Tiet Nghia Vu Cong Tac Khac Sau Giam Tru" SortExpression="[TietNghiaVuCongTacKhacSauGiamTru]" />				
				<asp:BoundField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]" />				
				<asp:BoundField DataField="TietNghiaVuGiangDay" HeaderText="Tiet Nghia Vu Giang Day" SortExpression="[TietNghiaVuGiangDay]" />				
				<asp:BoundField DataField="TietNghiaVuNckh" HeaderText="Tiet Nghia Vu Nckh" SortExpression="[TietNghiaVuNckh]" />				
				<asp:BoundField DataField="GioChuanGiangDayChuyenSangNckh" HeaderText="Gio Chuan Giang Day Chuyen Sang Nckh" SortExpression="[GioChuanGiangDayChuyenSangNckh]" />				
				<asp:BoundField DataField="TietGiamKhacGiangDay" HeaderText="Tiet Giam Khac Giang Day" SortExpression="[TietGiamKhacGiangDay]" />				
				<asp:BoundField DataField="TietGiamKhacNckh" HeaderText="Tiet Giam Khac Nckh" SortExpression="[TietGiamKhacNckh]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Tiet Nghia Vu Found! </b>
				<asp:HyperLink runat="server" ID="hypTietNghiaVu" NavigateUrl="~/admin/TietNghiaVuEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:TietNghiaVuDataSource ID="TietNghiaVuDataSource18" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:TietNghiaVuProperty Name="GiamTruDinhMuc"/> 
					<data:TietNghiaVuProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:TietNghiaVuFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:TietNghiaVuDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewGiangVienMocTangLuong19" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienMocTangLuong19_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienMocTangLuongDataSource19"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienMocTangLuong.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="MocTangLuong" HeaderText="Moc Tang Luong" SortExpression="[MocTangLuong]" />				
				<asp:BoundField DataField="ThoiGianTangLuong" HeaderText="Thoi Gian Tang Luong" SortExpression="[ThoiGianTangLuong]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Moc Tang Luong Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienMocTangLuong" NavigateUrl="~/admin/GiangVienMocTangLuongEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienMocTangLuongDataSource ID="GiangVienMocTangLuongDataSource19" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienMocTangLuongProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienMocTangLuongFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienMocTangLuongDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewGiangVienGiamTruDinhMuc20" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienGiamTruDinhMuc20_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienGiamTruDinhMucDataSource20"
			DataKeyNames="MaQuanLy"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienGiamTruDinhMuc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<data:HyperLinkField HeaderText="Ma Giam Tru" DataNavigateUrlFormatString="GiamTruDinhMucEdit.aspx?MaQuanLy={0}" DataNavigateUrlFields="MaQuanLy" DataContainer="MaGiamTruSource" DataTextField="NoiDungGiamTru" />
				<asp:BoundField DataField="PhanTramGiamTru" HeaderText="Phan Tram Giam Tru" SortExpression="[PhanTramGiamTru]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Giam Tru Dinh Muc Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienGiamTruDinhMuc" NavigateUrl="~/admin/GiangVienGiamTruDinhMucEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienGiamTruDinhMucDataSource ID="GiangVienGiamTruDinhMucDataSource20" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienGiamTruDinhMucProperty Name="GiamTruDinhMuc"/> 
					<data:GiangVienGiamTruDinhMucProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienGiamTruDinhMucFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienGiamTruDinhMucDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewGiangVienHoatDongNgoaiGiangDay21" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienHoatDongNgoaiGiangDay21_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienHoatDongNgoaiGiangDayDataSource21"
			DataKeyNames="MaQuanLy"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienHoatDongNgoaiGiangDay.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<data:HyperLinkField HeaderText="Ma Hoat Dong" DataNavigateUrlFormatString="HoatDongNgoaiGiangDayEdit.aspx?MaQuanLy={0}" DataNavigateUrlFields="MaQuanLy" DataContainer="MaHoatDongSource" DataTextField="TenHoatDong" />
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]" />				
				<asp:BoundField DataField="NgayChiTra" HeaderText="Ngay Chi Tra" SortExpression="[NgayChiTra]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Hoat Dong Ngoai Giang Day Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienHoatDongNgoaiGiangDay" NavigateUrl="~/admin/GiangVienHoatDongNgoaiGiangDayEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienHoatDongNgoaiGiangDayDataSource ID="GiangVienHoatDongNgoaiGiangDayDataSource21" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienHoatDongNgoaiGiangDayProperty Name="GiangVien"/> 
					<data:GiangVienHoatDongNgoaiGiangDayProperty Name="HoatDongNgoaiGiangDay"/> 
					<%--<data:GiangVienHoatDongNgoaiGiangDayProperty Name="QuyDoiHoatDongNgoaiGiangDayCollection" />--%>
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienHoatDongNgoaiGiangDayFilter  Column="MaGiangVien" QueryStringField="MaGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienHoatDongNgoaiGiangDayDataSource>		
		
		<br />
		

</asp:Content>

