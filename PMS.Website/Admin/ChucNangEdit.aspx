<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ChucNangEdit.aspx.cs" Inherits="ChucNangEdit" Title="ChucNang Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Chuc Nang - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Id" runat="server" DataSourceID="ChucNangDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ChucNangFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ChucNangFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>ChucNang not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:ChucNangDataSource ID="ChucNangDataSource" runat="server"
			SelectMethod="GetById"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="String" />

			</Parameters>
		</data:ChucNangDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewChucNang1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewChucNang1_SelectedIndexChanged"			 			 
			DataSourceID="ChucNangDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_ChucNang.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Parent Id" DataNavigateUrlFormatString="ChucNangEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="ParentIdSource" DataTextField="PhanLoai" />
				<asp:BoundField DataField="PhanLoai" HeaderText="Phan Loai" SortExpression="[PhanLoai]" />				
				<asp:BoundField DataField="Menu" HeaderText="Menu" SortExpression="[Menu]" />				
				<asp:BoundField DataField="BeginGroup" HeaderText="Begin Group" SortExpression="[BeginGroup]" />				
				<asp:BoundField DataField="RibbonStyle" HeaderText="Ribbon Style" SortExpression="[RibbonStyle]" />				
				<asp:BoundField DataField="DataLayout" HeaderText="Data Layout" SortExpression="[DataLayout]" />				
				<asp:BoundField DataField="TenChucNang" HeaderText="Ten Chuc Nang" SortExpression="[TenChucNang]" />				
				<asp:BoundField DataField="TenForm" HeaderText="Ten Form" SortExpression="[TenForm]" />				
				<asp:BoundField DataField="HinhAnh" HeaderText="Hinh Anh" SortExpression="[HinhAnh]" />				
				<asp:BoundField DataField="ThuTu" HeaderText="Thu Tu" SortExpression="[ThuTu]" />				
				<asp:BoundField DataField="TenPhuongThuc" HeaderText="Ten Phuong Thuc" SortExpression="[TenPhuongThuc]" />				
				<asp:BoundField DataField="ThamSo" HeaderText="Tham So" SortExpression="[ThamSo]" />				
				<asp:BoundField DataField="KieuForm" HeaderText="Kieu Form" SortExpression="[KieuForm]" />				
				<asp:BoundField DataField="TrangThai" HeaderText="Trang Thai" SortExpression="[TrangThai]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Chuc Nang Found! </b>
				<asp:HyperLink runat="server" ID="hypChucNang" NavigateUrl="~/admin/ChucNangEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:ChucNangDataSource ID="ChucNangDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ChucNangProperty Name="ChucNang"/> 
					<%--<data:ChucNangProperty Name="NhomChucNangCollection" />--%>
					<%--<data:ChucNangProperty Name="MaNhomQuyenNhomQuyenCollection_From_NhomChucNang" />--%>
					<%--<data:ChucNangProperty Name="ChucNangCollection" />--%>
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:ChucNangFilter  Column="ParentId" QueryStringField="Id" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:ChucNangDataSource>		
		
		<br />
		

</asp:Content>

