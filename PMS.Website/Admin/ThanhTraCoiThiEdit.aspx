<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThanhTraCoiThiEdit.aspx.cs" Inherits="ThanhTraCoiThiEdit" Title="ThanhTraCoiThi Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thanh Tra Coi Thi - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Examination, MaCanBoCoiThi" runat="server" DataSourceID="ThanhTraCoiThiDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ThanhTraCoiThiFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ThanhTraCoiThiFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>ThanhTraCoiThi not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:ThanhTraCoiThiDataSource ID="ThanhTraCoiThiDataSource" runat="server"
			SelectMethod="GetByExaminationMaCanBoCoiThi"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Examination" QueryStringField="Examination" Type="String" />
<asp:QueryStringParameter Name="MaCanBoCoiThi" QueryStringField="MaCanBoCoiThi" Type="String" />

			</Parameters>
		</data:ThanhTraCoiThiDataSource>
		
		<br />


</asp:Content>

