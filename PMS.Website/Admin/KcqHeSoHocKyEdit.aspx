<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqHeSoHocKyEdit.aspx.cs" Inherits="KcqHeSoHocKyEdit" Title="KcqHeSoHocKy Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq He So Hoc Ky - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaHocKy" runat="server" DataSourceID="KcqHeSoHocKyDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqHeSoHocKyFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqHeSoHocKyFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqHeSoHocKy not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqHeSoHocKyDataSource ID="KcqHeSoHocKyDataSource" runat="server"
			SelectMethod="GetByMaHocKy"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaHocKy" QueryStringField="MaHocKy" Type="String" />

			</Parameters>
		</data:KcqHeSoHocKyDataSource>
		
		<br />

		

</asp:Content>

