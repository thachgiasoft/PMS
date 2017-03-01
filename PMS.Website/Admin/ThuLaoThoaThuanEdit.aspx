<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuLaoThoaThuanEdit.aspx.cs" Inherits="ThuLaoThoaThuanEdit" Title="ThuLaoThoaThuan Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Lao Thoa Thuan - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaThuLao" runat="server" DataSourceID="ThuLaoThoaThuanDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ThuLaoThoaThuanFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ThuLaoThoaThuanFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>ThuLaoThoaThuan not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:ThuLaoThoaThuanDataSource ID="ThuLaoThoaThuanDataSource" runat="server"
			SelectMethod="GetByMaThuLao"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaThuLao" QueryStringField="MaThuLao" Type="String" />

			</Parameters>
		</data:ThuLaoThoaThuanDataSource>
		
		<br />

		

</asp:Content>

