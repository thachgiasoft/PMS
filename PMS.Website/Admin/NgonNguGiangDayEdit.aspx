<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NgonNguGiangDayEdit.aspx.cs" Inherits="NgonNguGiangDayEdit" Title="NgonNguGiangDay Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Ngon Ngu Giang Day - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaNgonNgu" runat="server" DataSourceID="NgonNguGiangDayDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NgonNguGiangDayFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NgonNguGiangDayFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>NgonNguGiangDay not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:NgonNguGiangDayDataSource ID="NgonNguGiangDayDataSource" runat="server"
			SelectMethod="GetByMaNgonNgu"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaNgonNgu" QueryStringField="MaNgonNgu" Type="String" />

			</Parameters>
		</data:NgonNguGiangDayDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewDonGia1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewDonGia1_SelectedIndexChanged"			 			 
			DataSourceID="DonGiaDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_DonGia.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]" />				
				<data:HyperLinkField HeaderText="Ma Loai Giang Vien" DataNavigateUrlFormatString="LoaiGiangVienEdit.aspx?MaLoaiGiangVien={0}" DataNavigateUrlFields="MaLoaiGiangVien" DataContainer="MaLoaiGiangVienSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Hoc Ham" DataNavigateUrlFormatString="HocHamEdit.aspx?MaHocHam={0}" DataNavigateUrlFields="MaHocHam" DataContainer="MaHocHamSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Hoc Vi" DataNavigateUrlFormatString="HocViEdit.aspx?MaHocVi={0}" DataNavigateUrlFields="MaHocVi" DataContainer="MaHocViSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="DonGiaClc" HeaderText="Don Gia Clc" SortExpression="[DonGiaClc]" />				
				<asp:BoundField DataField="HeSoQuyDoiChatLuong" HeaderText="He So Quy Doi Chat Luong" SortExpression="[HeSoQuyDoiChatLuong]" />				
				<asp:BoundField DataField="DonGiaTrongChuan" HeaderText="Don Gia Trong Chuan" SortExpression="[DonGiaTrongChuan]" />				
				<asp:BoundField DataField="DonGiaNgoaiChuan" HeaderText="Don Gia Ngoai Chuan" SortExpression="[DonGiaNgoaiChuan]" />				
				<asp:BoundField DataField="MaHinhThucDaoTao" HeaderText="Ma Hinh Thuc Dao Tao" SortExpression="[MaHinhThucDaoTao]" />				
				<asp:BoundField DataField="BacDaoTao" HeaderText="Bac Dao Tao" SortExpression="[BacDaoTao]" />				
				<data:HyperLinkField HeaderText="Ngon Ngu Giang Day" DataNavigateUrlFormatString="NgonNguGiangDayEdit.aspx?MaNgonNgu={0}" DataNavigateUrlFields="MaNgonNgu" DataContainer="NgonNguGiangDaySource" DataTextField="TenNgonNgu" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Nhom Mon" DataNavigateUrlFormatString="NhomMonHocEdit.aspx?MaNhomMon={0}" DataNavigateUrlFields="MaNhomMon" DataContainer="MaNhomMonSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NhomMonHoc" HeaderText="Nhom Mon Hoc" SortExpression="[NhomMonHoc]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Don Gia Found! </b>
				<asp:HyperLink runat="server" ID="hypDonGia" NavigateUrl="~/admin/DonGiaEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:DonGiaDataSource ID="DonGiaDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:DonGiaProperty Name="NhomMonHoc"/> 
					<data:DonGiaProperty Name="HocHam"/> 
					<data:DonGiaProperty Name="HocVi"/> 
					<data:DonGiaProperty Name="LoaiGiangVien"/> 
					<data:DonGiaProperty Name="NgonNguGiangDay"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:DonGiaFilter  Column="NgonNguGiangDay" QueryStringField="MaNgonNgu" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:DonGiaDataSource>		
		
		<br />
		

</asp:Content>

