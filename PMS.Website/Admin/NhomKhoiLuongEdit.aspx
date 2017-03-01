<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NhomKhoiLuongEdit.aspx.cs" Inherits="NhomKhoiLuongEdit" Title="NhomKhoiLuong Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nhom Khoi Luong - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaNhom" runat="server" DataSourceID="NhomKhoiLuongDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomKhoiLuongFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomKhoiLuongFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>NhomKhoiLuong not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:NhomKhoiLuongDataSource ID="NhomKhoiLuongDataSource" runat="server"
			SelectMethod="GetByMaNhom"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaNhom" QueryStringField="MaNhom" Type="String" />

			</Parameters>
		</data:NhomKhoiLuongDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewLoaiKhoiLuong1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewLoaiKhoiLuong1_SelectedIndexChanged"			 			 
			DataSourceID="LoaiKhoiLuongDataSource1"
			DataKeyNames="MaLoaiKhoiLuong"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_LoaiKhoiLuong.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Nhom" DataNavigateUrlFormatString="NhomKhoiLuongEdit.aspx?MaNhom={0}" DataNavigateUrlFields="MaNhom" DataContainer="MaNhomSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="TenLoaiKhoiLuong" HeaderText="Ten Loai Khoi Luong" SortExpression="[TenLoaiKhoiLuong]" />				
				<asp:BoundField DataField="NghiaVu" HeaderText="Nghia Vu" SortExpression="[NghiaVu]" />				
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Loai Khoi Luong Found! </b>
				<asp:HyperLink runat="server" ID="hypLoaiKhoiLuong" NavigateUrl="~/admin/LoaiKhoiLuongEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:LoaiKhoiLuongDataSource ID="LoaiKhoiLuongDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:LoaiKhoiLuongProperty Name="NhomKhoiLuong"/> 
					<%--<data:LoaiKhoiLuongProperty Name="QuyDoiGioChuanCollection" />--%>
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:LoaiKhoiLuongFilter  Column="MaNhom" QueryStringField="MaNhom" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:LoaiKhoiLuongDataSource>		
		
		<br />
		

</asp:Content>

