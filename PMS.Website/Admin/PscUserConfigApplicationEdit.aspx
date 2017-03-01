<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="PscUserConfigApplicationEdit.aspx.cs" Inherits="PscUserConfigApplicationEdit" Title="PscUserConfigApplication Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Psc User Config Application - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="StaffId, ConfigName" runat="server" DataSourceID="PscUserConfigApplicationDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/PscUserConfigApplicationFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/PscUserConfigApplicationFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>PscUserConfigApplication not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:PscUserConfigApplicationDataSource ID="PscUserConfigApplicationDataSource" runat="server"
			SelectMethod="GetByStaffIdConfigName"
		>
			<Parameters>
				<asp:QueryStringParameter Name="StaffId" QueryStringField="StaffId" Type="String" />
<asp:QueryStringParameter Name="ConfigName" QueryStringField="ConfigName" Type="String" />

			</Parameters>
		</data:PscUserConfigApplicationDataSource>
		
		<br />


</asp:Content>

