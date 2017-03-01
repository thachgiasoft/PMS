<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienThayDoiHocHamEdit.aspx.cs" Inherits="GiangVienThayDoiHocHamEdit" Title="GiangVienThayDoiHocHam Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Thay Doi Hoc Ham - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaQuanLy" runat="server" DataSourceID="GiangVienThayDoiHocHamDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienThayDoiHocHamFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienThayDoiHocHamFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>GiangVienThayDoiHocHam not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:GiangVienThayDoiHocHamDataSource ID="GiangVienThayDoiHocHamDataSource" runat="server"
			SelectMethod="GetByMaQuanLy"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaQuanLy" QueryStringField="MaQuanLy" Type="String" />

			</Parameters>
		</data:GiangVienThayDoiHocHamDataSource>
		
		<br />

		

</asp:Content>

