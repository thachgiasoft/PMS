<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqQuyDoiGioChuanEdit.aspx.cs" Inherits="KcqQuyDoiGioChuanEdit" Title="KcqQuyDoiGioChuan Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Quy Doi Gio Chuan - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaQuyDoi" runat="server" DataSourceID="KcqQuyDoiGioChuanDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqQuyDoiGioChuanFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqQuyDoiGioChuanFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqQuyDoiGioChuan not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqQuyDoiGioChuanDataSource ID="KcqQuyDoiGioChuanDataSource" runat="server"
			SelectMethod="GetByMaQuyDoi"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaQuyDoi" QueryStringField="MaQuyDoi" Type="String" />

			</Parameters>
		</data:KcqQuyDoiGioChuanDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewKcqKhoanQuyDoi1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKcqKhoanQuyDoi1_SelectedIndexChanged"			 			 
			DataSourceID="KcqKhoanQuyDoiDataSource1"
			DataKeyNames="MaKhoan"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KcqKhoanQuyDoi.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Quy Doi" DataNavigateUrlFormatString="KcqQuyDoiGioChuanEdit.aspx?MaQuyDoi={0}" DataNavigateUrlFields="MaQuyDoi" DataContainer="MaQuyDoiSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="TuKhoan" HeaderText="Tu Khoan" SortExpression="[TuKhoan]" />				
				<asp:BoundField DataField="DenKhoan" HeaderText="Den Khoan" SortExpression="[DenKhoan]" />				
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]" />				
				<asp:BoundField DataField="ThuTu" HeaderText="Thu Tu" SortExpression="[ThuTu]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Kcq Khoan Quy Doi Found! </b>
				<asp:HyperLink runat="server" ID="hypKcqKhoanQuyDoi" NavigateUrl="~/admin/KcqKhoanQuyDoiEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KcqKhoanQuyDoiDataSource ID="KcqKhoanQuyDoiDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KcqKhoanQuyDoiProperty Name="KcqQuyDoiGioChuan"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KcqKhoanQuyDoiFilter  Column="MaQuyDoi" QueryStringField="MaQuyDoi" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KcqKhoanQuyDoiDataSource>		
		
		<br />
		

</asp:Content>

