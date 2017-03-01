<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="BangPhuTroiGioDayGiangVienEdit.aspx.cs" Inherits="BangPhuTroiGioDayGiangVienEdit" Title="BangPhuTroiGioDayGiangVien Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Bang Phu Troi Gio Day Giang Vien - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaGiangVien" runat="server" DataSourceID="BangPhuTroiGioDayGiangVienDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/BangPhuTroiGioDayGiangVienFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/BangPhuTroiGioDayGiangVienFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>BangPhuTroiGioDayGiangVien not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:BangPhuTroiGioDayGiangVienDataSource ID="BangPhuTroiGioDayGiangVienDataSource" runat="server"
			SelectMethod="GetByMaGiangVien"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaGiangVien" QueryStringField="MaGiangVien" Type="String" />

			</Parameters>
		</data:BangPhuTroiGioDayGiangVienDataSource>
		
		<br />

		

</asp:Content>

