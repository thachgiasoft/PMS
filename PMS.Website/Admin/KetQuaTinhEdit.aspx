<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KetQuaTinhEdit.aspx.cs" Inherits="KetQuaTinhEdit" Title="KetQuaTinh Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Ket Qua Tinh - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKetQua" runat="server" DataSourceID="KetQuaTinhDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KetQuaTinhFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KetQuaTinhFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KetQuaTinh not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KetQuaTinhDataSource ID="KetQuaTinhDataSource" runat="server"
			SelectMethod="GetByMaKetQua"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKetQua" QueryStringField="MaKetQua" Type="String" />

			</Parameters>
		</data:KetQuaTinhDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewKhoiLuongGiangDay1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKhoiLuongGiangDay1_SelectedIndexChanged"			 			 
			DataSourceID="KhoiLuongGiangDayDataSource1"
			DataKeyNames="MaKhoiLuong"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KhoiLuongGiangDay.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Ket Qua" DataNavigateUrlFormatString="KetQuaTinhEdit.aspx?MaKetQua={0}" DataNavigateUrlFields="MaKetQua" DataContainer="MaKetQuaSource" DataTextField="HocKy" />
				<asp:BoundField DataField="MaToaNha" HeaderText="Ma Toa Nha" SortExpression="[MaToaNha]" />				
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" />				
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]" />				
				<asp:BoundField DataField="MaNhom" HeaderText="Ma Nhom" SortExpression="[MaNhom]" />				
				<asp:BoundField DataField="LoaiHocPhan" HeaderText="Loai Hoc Phan" SortExpression="[LoaiHocPhan]" />				
				<asp:BoundField DataField="PhanLoai" HeaderText="Phan Loai" SortExpression="[PhanLoai]" />				
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]" />				
				<asp:BoundField DataField="DienGiai" HeaderText="Dien Giai" SortExpression="[DienGiai]" />				
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]" />				
				<asp:BoundField DataField="SoTinChi" HeaderText="So Tin Chi" SortExpression="[SoTinChi]" />				
				<asp:BoundField DataField="SiSoLop" HeaderText="Si So Lop" SortExpression="[SiSoLop]" />				
				<asp:BoundField DataField="SoNhom" HeaderText="So Nhom" SortExpression="[SoNhom]" />				
				<asp:BoundField DataField="MaDiaDiem" HeaderText="Ma Dia Diem" SortExpression="[MaDiaDiem]" />				
				<asp:BoundField DataField="NgayBatDau" HeaderText="Ngay Bat Dau" SortExpression="[NgayBatDau]" />				
				<asp:BoundField DataField="NgayKetThuc" HeaderText="Ngay Ket Thuc" SortExpression="[NgayKetThuc]" />				
				<asp:BoundField DataField="ChatLuongCao" HeaderText="Chat Luong Cao" SortExpression="[ChatLuongCao]" />				
				<asp:BoundField DataField="NgoaiGio" HeaderText="Ngoai Gio" SortExpression="[NgoaiGio]" />				
				<asp:BoundField DataField="TrongGio" HeaderText="Trong Gio" SortExpression="[TrongGio]" />				
				<asp:BoundField DataField="HeSoLopDong" HeaderText="He So Lop Dong" SortExpression="[HeSoLopDong]" />				
				<asp:BoundField DataField="HeSoCoSo" HeaderText="He So Co So" SortExpression="[HeSoCoSo]" />				
				<asp:BoundField DataField="HeSoHocKy" HeaderText="He So Hoc Ky" SortExpression="[HeSoHocKy]" />				
				<asp:BoundField DataField="HeSoThanhPhan" HeaderText="He So Thanh Phan" SortExpression="[HeSoThanhPhan]" />				
				<asp:BoundField DataField="HeSoTrongGio" HeaderText="He So Trong Gio" SortExpression="[HeSoTrongGio]" />				
				<asp:BoundField DataField="HeSoNgoaiGio" HeaderText="He So Ngoai Gio" SortExpression="[HeSoNgoaiGio]" />				
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]" />				
				<asp:BoundField DataField="LoaiHocKy" HeaderText="Loai Hoc Ky" SortExpression="[LoaiHocKy]" />				
				<asp:BoundField DataField="ThoiKhoaBieu" HeaderText="Thoi Khoa Bieu" SortExpression="[ThoiKhoaBieu]" />				
				<asp:BoundField DataField="NgayTao" HeaderText="Ngay Tao" SortExpression="[NgayTao]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Khoi Luong Giang Day Found! </b>
				<asp:HyperLink runat="server" ID="hypKhoiLuongGiangDay" NavigateUrl="~/admin/KhoiLuongGiangDayEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KhoiLuongGiangDayDataSource ID="KhoiLuongGiangDayDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KhoiLuongGiangDayProperty Name="KetQuaTinh"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KhoiLuongGiangDayFilter  Column="MaKetQua" QueryStringField="MaKetQua" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KhoiLuongGiangDayDataSource>		
		
		<br />
		

</asp:Content>

