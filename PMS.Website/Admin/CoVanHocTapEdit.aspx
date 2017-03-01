<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="CoVanHocTapEdit.aspx.cs" Inherits="CoVanHocTapEdit" Title="CoVanHocTap Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Co Van Hoc Tap - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaCoVan" runat="server" DataSourceID="CoVanHocTapDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/CoVanHocTapFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/CoVanHocTapFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>CoVanHocTap not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:CoVanHocTapDataSource ID="CoVanHocTapDataSource" runat="server"
			SelectMethod="GetByMaCoVan"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaCoVan" QueryStringField="MaCoVan" Type="String" />

			</Parameters>
		</data:CoVanHocTapDataSource>
		
		<br />

		

</asp:Content>

