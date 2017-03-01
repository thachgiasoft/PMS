<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="TienCongTacPhiEdit.aspx.cs" Inherits="TienCongTacPhiEdit" Title="TienCongTacPhi Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Tien Cong Tac Phi - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaCoSo" runat="server" DataSourceID="TienCongTacPhiDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/TienCongTacPhiFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/TienCongTacPhiFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>TienCongTacPhi not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:TienCongTacPhiDataSource ID="TienCongTacPhiDataSource" runat="server"
			SelectMethod="GetByMaCoSo"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaCoSo" QueryStringField="MaCoSo" Type="String" />

			</Parameters>
		</data:TienCongTacPhiDataSource>
		
		<br />

		

</asp:Content>

