<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoBacDaoTaoEdit.aspx.cs" Inherits="HeSoBacDaoTaoEdit" Title="HeSoBacDaoTao Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Bac Dao Tao - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaHeSo" runat="server" DataSourceID="HeSoBacDaoTaoDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoBacDaoTaoFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoBacDaoTaoFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>HeSoBacDaoTao not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:HeSoBacDaoTaoDataSource ID="HeSoBacDaoTaoDataSource" runat="server"
			SelectMethod="GetByMaHeSo"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaHeSo" QueryStringField="MaHeSo" Type="String" />

			</Parameters>
		</data:HeSoBacDaoTaoDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewLopHocPhanBacDaoTao1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewLopHocPhanBacDaoTao1_SelectedIndexChanged"			 			 
			DataSourceID="LopHocPhanBacDaoTaoDataSource1"
			DataKeyNames="MaLopHocPhan, MaHeSoBacDaoTao"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_LopHocPhanBacDaoTao.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma He So Bac Dao Tao" DataNavigateUrlFormatString="HeSoBacDaoTaoEdit.aspx?MaHeSo={0}" DataNavigateUrlFields="MaHeSo" DataContainer="MaHeSoBacDaoTaoSource" DataTextField="Stt" />
			</Columns>
			<EmptyDataTemplate>
				<b>No Lop Hoc Phan Bac Dao Tao Found! </b>
				<asp:HyperLink runat="server" ID="hypLopHocPhanBacDaoTao" NavigateUrl="~/admin/LopHocPhanBacDaoTaoEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:LopHocPhanBacDaoTaoDataSource ID="LopHocPhanBacDaoTaoDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:LopHocPhanBacDaoTaoProperty Name="HeSoBacDaoTao"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:LopHocPhanBacDaoTaoFilter  Column="MaHeSoBacDaoTao" QueryStringField="MaHeSo" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:LopHocPhanBacDaoTaoDataSource>		
		
		<br />
		

</asp:Content>

