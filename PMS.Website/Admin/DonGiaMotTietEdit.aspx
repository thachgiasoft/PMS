<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DonGiaMotTietEdit.aspx.cs" Inherits="DonGiaMotTietEdit" Title="DonGiaMotTiet Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Don Gia Mot Tiet - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaHocHam, MaHocVi" runat="server" DataSourceID="DonGiaMotTietDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DonGiaMotTietFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DonGiaMotTietFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>DonGiaMotTiet not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:DonGiaMotTietDataSource ID="DonGiaMotTietDataSource" runat="server"
			SelectMethod="GetByMaHocHamMaHocVi"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaHocHam" QueryStringField="MaHocHam" Type="String" />
<asp:QueryStringParameter Name="MaHocVi" QueryStringField="MaHocVi" Type="String" />

			</Parameters>
		</data:DonGiaMotTietDataSource>
		
		<br />


</asp:Content>

