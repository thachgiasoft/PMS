<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoTroCapTheoKhoaEdit.aspx.cs" Inherits="HeSoTroCapTheoKhoaEdit" Title="HeSoTroCapTheoKhoa Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Tro Cap Theo Khoa - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoa" runat="server" DataSourceID="HeSoTroCapTheoKhoaDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoTroCapTheoKhoaFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoTroCapTheoKhoaFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>HeSoTroCapTheoKhoa not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:HeSoTroCapTheoKhoaDataSource ID="HeSoTroCapTheoKhoaDataSource" runat="server"
			SelectMethod="GetByMaKhoa"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoa" QueryStringField="MaKhoa" Type="String" />

			</Parameters>
		</data:HeSoTroCapTheoKhoaDataSource>
		
		<br />

		

</asp:Content>

