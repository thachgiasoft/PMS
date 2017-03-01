<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoNgonNguEdit.aspx.cs" Inherits="HeSoNgonNguEdit" Title="HeSoNgonNgu Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Ngon Ngu - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaHeSo" runat="server" DataSourceID="HeSoNgonNguDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoNgonNguFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoNgonNguFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>HeSoNgonNgu not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:HeSoNgonNguDataSource ID="HeSoNgonNguDataSource" runat="server"
			SelectMethod="GetByMaHeSo"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaHeSo" QueryStringField="MaHeSo" Type="String" />

			</Parameters>
		</data:HeSoNgonNguDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewGiangVienLopHocPhan1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienLopHocPhan1_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienLopHocPhanDataSource1"
			DataKeyNames="MaGiangVien, MaLopHocPhan"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienLopHocPhan.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma He So Nn" DataNavigateUrlFormatString="HeSoNgonNguEdit.aspx?MaHeSo={0}" DataNavigateUrlFields="MaHeSo" DataContainer="MaHeSoNnSource" DataTextField="Stt" />
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Lop Hoc Phan Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienLopHocPhan" NavigateUrl="~/admin/GiangVienLopHocPhanEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienLopHocPhanDataSource ID="GiangVienLopHocPhanDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienLopHocPhanProperty Name="HeSoNgonNgu"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienLopHocPhanFilter  Column="MaHeSoNn" QueryStringField="MaHeSo" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienLopHocPhanDataSource>		
		
		<br />
		

</asp:Content>

