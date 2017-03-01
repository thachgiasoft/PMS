<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="CauHinhChotGioEdit.aspx.cs" Inherits="CauHinhChotGioEdit" Title="CauHinhChotGio Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Cau Hinh Chot Gio - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaCauHinhChotGio" runat="server" DataSourceID="CauHinhChotGioDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/CauHinhChotGioFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/CauHinhChotGioFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>CauHinhChotGio not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:CauHinhChotGioDataSource ID="CauHinhChotGioDataSource" runat="server"
			SelectMethod="GetByMaCauHinhChotGio"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaCauHinhChotGio" QueryStringField="MaCauHinhChotGio" Type="String" />

			</Parameters>
		</data:CauHinhChotGioDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewKhoiLuongGiangDayCaoDang1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKhoiLuongGiangDayCaoDang1_SelectedIndexChanged"			 			 
			DataSourceID="KhoiLuongGiangDayCaoDangDataSource1"
			DataKeyNames="MaKhoiLuongCaoDang"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KhoiLuongGiangDayCaoDang.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="MaGiangVienQuanLy" HeaderText="Ma Giang Vien Quan Ly" SortExpression="[MaGiangVienQuanLy]" />				
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" />				
				<asp:BoundField DataField="SiSoLop" HeaderText="Si So Lop" SortExpression="[SiSoLop]" />				
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]" />				
				<asp:BoundField DataField="TietThucDayLt" HeaderText="Tiet Thuc Day Lt" SortExpression="[TietThucDayLT]" />				
				<asp:BoundField DataField="TietThucDayTh" HeaderText="Tiet Thuc Day Th" SortExpression="[TietThucDayTH]" />				
				<data:HyperLinkField HeaderText="Ma Cau Hinh Chot Gio" DataNavigateUrlFormatString="CauHinhChotGioEdit.aspx?MaCauHinhChotGio={0}" DataNavigateUrlFields="MaCauHinhChotGio" DataContainer="MaCauHinhChotGioSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="TenLopHocPhan" HeaderText="Ten Lop Hoc Phan" SortExpression="[TenLopHocPhan]" />				
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]" />				
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]" />				
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Khoi Luong Giang Day Cao Dang Found! </b>
				<asp:HyperLink runat="server" ID="hypKhoiLuongGiangDayCaoDang" NavigateUrl="~/admin/KhoiLuongGiangDayCaoDangEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KhoiLuongGiangDayCaoDangDataSource ID="KhoiLuongGiangDayCaoDangDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KhoiLuongGiangDayCaoDangProperty Name="CauHinhChotGio"/> 
					<%--<data:KhoiLuongGiangDayCaoDangProperty Name="KhoiLuongQuyDoiCaoDangCollection" />--%>
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KhoiLuongGiangDayCaoDangFilter  Column="MaCauHinhChotGio" QueryStringField="MaCauHinhChotGio" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KhoiLuongGiangDayCaoDangDataSource>		
		
		<br />
		

</asp:Content>

