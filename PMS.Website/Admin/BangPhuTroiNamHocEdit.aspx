<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="BangPhuTroiNamHocEdit.aspx.cs" Inherits="BangPhuTroiNamHocEdit" Title="BangPhuTroiNamHoc Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Bang Phu Troi Nam Hoc - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaGiangVien, NamHoc" runat="server" DataSourceID="BangPhuTroiNamHocDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/BangPhuTroiNamHocFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/BangPhuTroiNamHocFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>BangPhuTroiNamHoc not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:BangPhuTroiNamHocDataSource ID="BangPhuTroiNamHocDataSource" runat="server"
			SelectMethod="GetByMaGiangVienNamHoc"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaGiangVien" QueryStringField="MaGiangVien" Type="String" />
<asp:QueryStringParameter Name="NamHoc" QueryStringField="NamHoc" Type="String" />

			</Parameters>
		</data:BangPhuTroiNamHocDataSource>
		
		<br />


</asp:Content>

