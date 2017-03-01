<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqNhomKhoiLuongEdit.aspx.cs" Inherits="KcqNhomKhoiLuongEdit" Title="KcqNhomKhoiLuong Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Nhom Khoi Luong - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaNhom" runat="server" DataSourceID="KcqNhomKhoiLuongDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqNhomKhoiLuongFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqNhomKhoiLuongFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqNhomKhoiLuong not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqNhomKhoiLuongDataSource ID="KcqNhomKhoiLuongDataSource" runat="server"
			SelectMethod="GetByMaNhom"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaNhom" QueryStringField="MaNhom" Type="String" />

			</Parameters>
		</data:KcqNhomKhoiLuongDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewKcqLoaiKhoiLuong1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKcqLoaiKhoiLuong1_SelectedIndexChanged"			 			 
			DataSourceID="KcqLoaiKhoiLuongDataSource1"
			DataKeyNames="MaLoaiKhoiLuong"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KcqLoaiKhoiLuong.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Nhom" DataNavigateUrlFormatString="KcqNhomKhoiLuongEdit.aspx?MaNhom={0}" DataNavigateUrlFields="MaNhom" DataContainer="MaNhomSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="TenLoaiKhoiLuong" HeaderText="Ten Loai Khoi Luong" SortExpression="[TenLoaiKhoiLuong]" />				
				<asp:BoundField DataField="NghiaVu" HeaderText="Nghia Vu" SortExpression="[NghiaVu]" />				
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Kcq Loai Khoi Luong Found! </b>
				<asp:HyperLink runat="server" ID="hypKcqLoaiKhoiLuong" NavigateUrl="~/admin/KcqLoaiKhoiLuongEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KcqLoaiKhoiLuongDataSource ID="KcqLoaiKhoiLuongDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KcqLoaiKhoiLuongProperty Name="KcqNhomKhoiLuong"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KcqLoaiKhoiLuongFilter  Column="MaNhom" QueryStringField="MaNhom" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KcqLoaiKhoiLuongDataSource>		
		
		<br />
		

</asp:Content>

