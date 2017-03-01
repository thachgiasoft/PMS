<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NoiDungDanhGiaEdit.aspx.cs" Inherits="NoiDungDanhGiaEdit" Title="NoiDungDanhGia Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Noi Dung Danh Gia - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaQuanLy" runat="server" DataSourceID="NoiDungDanhGiaDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NoiDungDanhGiaFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NoiDungDanhGiaFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>NoiDungDanhGia not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:NoiDungDanhGiaDataSource ID="NoiDungDanhGiaDataSource" runat="server"
			SelectMethod="GetByMaQuanLy"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaQuanLy" QueryStringField="MaQuanLy" Type="String" />

			</Parameters>
		</data:NoiDungDanhGiaDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewKetQuaDanhGiaVuotGio1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKetQuaDanhGiaVuotGio1_SelectedIndexChanged"			 			 
			DataSourceID="KetQuaDanhGiaVuotGioDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KetQuaDanhGiaVuotGio.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]" />				
				<data:HyperLinkField HeaderText="Ma Noi Dung Danh Gia" DataNavigateUrlFormatString="NoiDungDanhGiaEdit.aspx?MaQuanLy={0}" DataNavigateUrlFields="MaQuanLy" DataContainer="MaNoiDungDanhGiaSource" DataTextField="TenNoiDungDanhGia" />
				<asp:BoundField DataField="ThoiGianLamViecQuyDinh" HeaderText="Thoi Gian Lam Viec Quy Dinh" SortExpression="[ThoiGianLamViecQuyDinh]" />				
				<asp:BoundField DataField="DanhGiaThoiGianThucHien" HeaderText="Danh Gia Thoi Gian Thuc Hien" SortExpression="[DanhGiaThoiGianThucHien]" />				
				<asp:BoundField DataField="PhanTramDanhGia" HeaderText="Phan Tram Danh Gia" SortExpression="[PhanTramDanhGia]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Ket Qua Danh Gia Vuot Gio Found! </b>
				<asp:HyperLink runat="server" ID="hypKetQuaDanhGiaVuotGio" NavigateUrl="~/admin/KetQuaDanhGiaVuotGioEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KetQuaDanhGiaVuotGioDataSource ID="KetQuaDanhGiaVuotGioDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KetQuaDanhGiaVuotGioProperty Name="NoiDungDanhGia"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KetQuaDanhGiaVuotGioFilter  Column="MaNoiDungDanhGia" QueryStringField="MaQuanLy" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KetQuaDanhGiaVuotGioDataSource>		
		
		<br />
		

</asp:Content>

