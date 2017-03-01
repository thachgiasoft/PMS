<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongKhacEdit.aspx.cs" Inherits="KhoiLuongKhacEdit" Title="KhoiLuongKhac Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Khac - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoiLuong" runat="server" DataSourceID="KhoiLuongKhacDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongKhacFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongKhacFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KhoiLuongKhac not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KhoiLuongKhacDataSource ID="KhoiLuongKhacDataSource" runat="server"
			SelectMethod="GetByMaKhoiLuong"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoiLuong" QueryStringField="MaKhoiLuong" Type="String" />

			</Parameters>
		</data:KhoiLuongKhacDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewChiTietKhoiLuong1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewChiTietKhoiLuong1_SelectedIndexChanged"			 			 
			DataSourceID="ChiTietKhoiLuongDataSource1"
			DataKeyNames="MaChiTiet"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_ChiTietKhoiLuong.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Khoi Luong" DataNavigateUrlFormatString="KhoiLuongKhacEdit.aspx?MaKhoiLuong={0}" DataNavigateUrlFields="MaKhoiLuong" DataContainer="MaKhoiLuongSource" DataTextField="LoaiHocPhan" />
				<asp:BoundField DataField="MaSinhVien" HeaderText="Ma Sinh Vien" SortExpression="[MaSinhVien]" />				
				<asp:BoundField DataField="NgayTao" HeaderText="Ngay Tao" SortExpression="[NgayTao]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Chi Tiet Khoi Luong Found! </b>
				<asp:HyperLink runat="server" ID="hypChiTietKhoiLuong" NavigateUrl="~/admin/ChiTietKhoiLuongEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:ChiTietKhoiLuongDataSource ID="ChiTietKhoiLuongDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ChiTietKhoiLuongProperty Name="KhoiLuongKhac"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:ChiTietKhoiLuongFilter  Column="MaKhoiLuong" QueryStringField="MaKhoiLuong" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:ChiTietKhoiLuongDataSource>		
		
		<br />
		

</asp:Content>

