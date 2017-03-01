<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoCongViecEdit.aspx.cs" Inherits="HeSoCongViecEdit" Title="HeSoCongViec Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Cong Viec - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaHeSo" runat="server" DataSourceID="HeSoCongViecDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoCongViecFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoCongViecFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>HeSoCongViec not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:HeSoCongViecDataSource ID="HeSoCongViecDataSource" runat="server"
			SelectMethod="GetByMaHeSo"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaHeSo" QueryStringField="MaHeSo" Type="String" />

			</Parameters>
		</data:HeSoCongViecDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewThucGiangMonThucTeTuHoc1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewThucGiangMonThucTeTuHoc1_SelectedIndexChanged"			 			 
			DataSourceID="ThucGiangMonThucTeTuHocDataSource1"
			DataKeyNames="MaQuanLy"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_ThucGiangMonThucTeTuHoc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" />				
				<data:HyperLinkField HeaderText="Ma He So Cong Viec" DataNavigateUrlFormatString="HeSoCongViecEdit.aspx?MaHeSo={0}" DataNavigateUrlFields="MaHeSo" DataContainer="MaHeSoCongViecSource" DataTextField="Stt" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Thuc Giang Mon Thuc Te Tu Hoc Found! </b>
				<asp:HyperLink runat="server" ID="hypThucGiangMonThucTeTuHoc" NavigateUrl="~/admin/ThucGiangMonThucTeTuHocEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:ThucGiangMonThucTeTuHocDataSource ID="ThucGiangMonThucTeTuHocDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ThucGiangMonThucTeTuHocProperty Name="HeSoCongViec"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:ThucGiangMonThucTeTuHocFilter  Column="MaHeSoCongViec" QueryStringField="MaHeSo" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:ThucGiangMonThucTeTuHocDataSource>		
		
		<br />
		

</asp:Content>

