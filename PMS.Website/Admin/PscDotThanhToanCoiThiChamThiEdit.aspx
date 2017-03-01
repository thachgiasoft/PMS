<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="PscDotThanhToanCoiThiChamThiEdit.aspx.cs" Inherits="PscDotThanhToanCoiThiChamThiEdit" Title="PscDotThanhToanCoiThiChamThi Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Psc Dot Thanh Toan Coi Thi Cham Thi - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaDot" runat="server" DataSourceID="PscDotThanhToanCoiThiChamThiDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/PscDotThanhToanCoiThiChamThiFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/PscDotThanhToanCoiThiChamThiFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>PscDotThanhToanCoiThiChamThi not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:PscDotThanhToanCoiThiChamThiDataSource ID="PscDotThanhToanCoiThiChamThiDataSource" runat="server"
			SelectMethod="GetByMaDot"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaDot" QueryStringField="MaDot" Type="String" />

			</Parameters>
		</data:PscDotThanhToanCoiThiChamThiDataSource>
		
		<br />

		

</asp:Content>

