<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienHoSoEdit.aspx.cs" Inherits="GiangVienHoSoEdit" Title="GiangVienHoSo Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Ho So - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaHoSo, MaGiangVien" runat="server" DataSourceID="GiangVienHoSoDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienHoSoFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienHoSoFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>GiangVienHoSo not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:GiangVienHoSoDataSource ID="GiangVienHoSoDataSource" runat="server"
			SelectMethod="GetByMaHoSoMaGiangVien"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaHoSo" QueryStringField="MaHoSo" Type="String" />
<asp:QueryStringParameter Name="MaGiangVien" QueryStringField="MaGiangVien" Type="String" />

			</Parameters>
		</data:GiangVienHoSoDataSource>
		
		<br />


</asp:Content>

