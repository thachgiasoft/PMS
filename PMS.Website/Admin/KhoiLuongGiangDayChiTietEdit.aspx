<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongGiangDayChiTietEdit.aspx.cs" Inherits="KhoiLuongGiangDayChiTietEdit" Title="KhoiLuongGiangDayChiTiet Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Giang Day Chi Tiet - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoiLuong" runat="server" DataSourceID="KhoiLuongGiangDayChiTietDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongGiangDayChiTietFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongGiangDayChiTietFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KhoiLuongGiangDayChiTiet not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KhoiLuongGiangDayChiTietDataSource ID="KhoiLuongGiangDayChiTietDataSource" runat="server"
			SelectMethod="GetByMaKhoiLuong"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoiLuong" QueryStringField="MaKhoiLuong" Type="String" />

			</Parameters>
		</data:KhoiLuongGiangDayChiTietDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewKhoiLuongQuyDoi1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKhoiLuongQuyDoi1_SelectedIndexChanged"			 			 
			DataSourceID="KhoiLuongQuyDoiDataSource1"
			DataKeyNames="MaKhoiLuongQuyDoi"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KhoiLuongQuyDoi.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Khoi Luong Giang Day" DataNavigateUrlFormatString="KhoiLuongGiangDayChiTietEdit.aspx?MaKhoiLuong={0}" DataNavigateUrlFields="MaKhoiLuong" DataContainer="MaKhoiLuongGiangDaySource" DataTextField="MaLichHoc" />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]" />				
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]" />				
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]" />				
				<asp:BoundField DataField="SoTinChi" HeaderText="So Tin Chi" SortExpression="[SoTinChi]" />				
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]" />				
				<asp:BoundField DataField="MaLoaiHocPhan" HeaderText="Ma Loai Hoc Phan" SortExpression="[MaLoaiHocPhan]" />				
				<asp:BoundField DataField="LoaiHocPhan" HeaderText="Loai Hoc Phan" SortExpression="[LoaiHocPhan]" />				
				<asp:BoundField DataField="MaBuoiHoc" HeaderText="Ma Buoi Hoc" SortExpression="[MaBuoiHoc]" />				
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]" />				
				<asp:BoundField DataField="TietBatDau" HeaderText="Tiet Bat Dau" SortExpression="[TietBatDau]" />				
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]" />				
				<asp:BoundField DataField="TinhTrang" HeaderText="Tinh Trang" SortExpression="[TinhTrang]" />				
				<asp:BoundField DataField="NgayDay" HeaderText="Ngay Day" SortExpression="[NgayDay]" />				
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]" />				
				<asp:BoundField DataField="MaKhoaHoc" HeaderText="Ma Khoa Hoc" SortExpression="[MaKhoaHoc]" />				
				<asp:BoundField DataField="MaKhoa" HeaderText="Ma Khoa" SortExpression="[MaKhoa]" />				
				<asp:BoundField DataField="MaNhomMonHoc" HeaderText="Ma Nhom Mon Hoc" SortExpression="[MaNhomMonHoc]" />				
				<asp:BoundField DataField="MaPhongHoc" HeaderText="Ma Phong Hoc" SortExpression="[MaPhongHoc]" />				
				<asp:BoundField DataField="HeSoCongViec" HeaderText="He So Cong Viec" SortExpression="[HeSoCongViec]" />				
				<asp:BoundField DataField="HeSoBacDaoTao" HeaderText="He So Bac Dao Tao" SortExpression="[HeSoBacDaoTao]" />				
				<asp:BoundField DataField="HeSoNgonNgu" HeaderText="He So Ngon Ngu" SortExpression="[HeSoNgonNgu]" />				
				<asp:BoundField DataField="HeSoChucDanhChuyenMon" HeaderText="He So Chuc Danh Chuyen Mon" SortExpression="[HeSoChucDanhChuyenMon]" />				
				<asp:BoundField DataField="HeSoLopDong" HeaderText="He So Lop Dong" SortExpression="[HeSoLopDong]" />				
				<asp:BoundField DataField="HeSoCoSo" HeaderText="He So Co So" SortExpression="[HeSoCoSo]" />				
				<asp:BoundField DataField="SoTietThucTeQuyDoi" HeaderText="So Tiet Thuc Te Quy Doi" SortExpression="[SoTietThucTeQuyDoi]" />				
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]" />				
				<asp:BoundField DataField="HeSoQuyDoiThucHanhSangLyThuyet" HeaderText="He So Quy Doi Thuc Hanh Sang Ly Thuyet" SortExpression="[HeSoQuyDoiThucHanhSangLyThuyet]" />				
				<asp:BoundField DataField="HeSoNgoaiGio" HeaderText="He So Ngoai Gio" SortExpression="[HeSoNgoaiGio]" />				
				<asp:BoundField DataField="LoaiLop" HeaderText="Loai Lop" SortExpression="[LoaiLop]" />				
				<asp:BoundField DataField="HeSoClcCntn" HeaderText="He So Clc Cntn" SortExpression="[HeSoClcCntn]" />				
				<asp:BoundField DataField="HeSoThinhGiangMonChuyenNganh" HeaderText="He So Thinh Giang Mon Chuyen Nganh" SortExpression="[HeSoThinhGiangMonChuyenNganh]" />				
				<asp:BoundField DataField="NgonNguGiangDay" HeaderText="Ngon Ngu Giang Day" SortExpression="[NgonNguGiangDay]" />				
				<asp:BoundField DataField="HeSoTroCapGiangDay" HeaderText="He So Tro Cap Giang Day" SortExpression="[HeSoTroCapGiangDay]" />				
				<asp:BoundField DataField="HeSoTroCap" HeaderText="He So Tro Cap" SortExpression="[HeSoTroCap]" />				
				<asp:BoundField DataField="HeSoLuong" HeaderText="He So Luong" SortExpression="[HeSoLuong]" />				
				<asp:BoundField DataField="HeSoMonMoi" HeaderText="He So Mon Moi" SortExpression="[HeSoMonMoi]" />				
				<asp:BoundField DataField="HeSoNienCheTinChi" HeaderText="He So Nien Che Tin Chi" SortExpression="[HeSoNienCheTinChi]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="MucThanhToan" HeaderText="Muc Thanh Toan" SortExpression="[MucThanhToan]" />				
				<asp:BoundField DataField="HeSoKhoiNganh" HeaderText="He So Khoi Nganh" SortExpression="[HeSoKhoiNganh]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Khoi Luong Quy Doi Found! </b>
				<asp:HyperLink runat="server" ID="hypKhoiLuongQuyDoi" NavigateUrl="~/admin/KhoiLuongQuyDoiEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KhoiLuongQuyDoiDataSource ID="KhoiLuongQuyDoiDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KhoiLuongQuyDoiProperty Name="KhoiLuongGiangDayChiTiet"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KhoiLuongQuyDoiFilter  Column="MaKhoiLuongGiangDay" QueryStringField="MaKhoiLuong" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KhoiLuongQuyDoiDataSource>		
		
		<br />
		

</asp:Content>

