<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiNghienCuuKhoaHocEdit.aspx.cs" Inherits="LoaiNghienCuuKhoaHocEdit" Title="LoaiNghienCuuKhoaHoc Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Nghien Cuu Khoa Hoc - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Id" runat="server" DataSourceID="LoaiNghienCuuKhoaHocDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiNghienCuuKhoaHocFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiNghienCuuKhoaHocFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LoaiNghienCuuKhoaHoc not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LoaiNghienCuuKhoaHocDataSource ID="LoaiNghienCuuKhoaHocDataSource" runat="server"
			SelectMethod="GetById"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="String" />

			</Parameters>
		</data:LoaiNghienCuuKhoaHocDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewDanhMucNghienCuuKhoaHoc1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewDanhMucNghienCuuKhoaHoc1_SelectedIndexChanged"			 			 
			DataSourceID="DanhMucNghienCuuKhoaHocDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_DanhMucNghienCuuKhoaHoc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]" />				
				<asp:BoundField DataField="TenNghienCuuKhoaHoc" HeaderText="Ten Nghien Cuu Khoa Hoc" SortExpression="[TenNghienCuuKhoaHoc]" />				
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<data:HyperLinkField HeaderText="Ma Loai Nckh" DataNavigateUrlFormatString="LoaiNghienCuuKhoaHocEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaLoaiNckhSource" DataTextField="MaLoaiNckh" />
			</Columns>
			<EmptyDataTemplate>
				<b>No Danh Muc Nghien Cuu Khoa Hoc Found! </b>
				<asp:HyperLink runat="server" ID="hypDanhMucNghienCuuKhoaHoc" NavigateUrl="~/admin/DanhMucNghienCuuKhoaHocEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:DanhMucNghienCuuKhoaHocDataSource ID="DanhMucNghienCuuKhoaHocDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:DanhMucNghienCuuKhoaHocProperty Name="LoaiNghienCuuKhoaHoc"/> 
					<%--<data:DanhMucNghienCuuKhoaHocProperty Name="GiangVienNghienCuuKhCollection" />--%>
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:DanhMucNghienCuuKhoaHocFilter  Column="MaLoaiNckh" QueryStringField="Id" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:DanhMucNghienCuuKhoaHocDataSource>		
		
		<br />
		

</asp:Content>

