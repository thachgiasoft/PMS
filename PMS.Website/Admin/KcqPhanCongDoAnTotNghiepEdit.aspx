<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqPhanCongDoAnTotNghiepEdit.aspx.cs" Inherits="KcqPhanCongDoAnTotNghiepEdit" Title="KcqPhanCongDoAnTotNghiep Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Phan Cong Do An Tot Nghiep - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLopHocPhan, MaSinhVien" runat="server" DataSourceID="KcqPhanCongDoAnTotNghiepDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqPhanCongDoAnTotNghiepFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqPhanCongDoAnTotNghiepFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqPhanCongDoAnTotNghiep not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqPhanCongDoAnTotNghiepDataSource ID="KcqPhanCongDoAnTotNghiepDataSource" runat="server"
			SelectMethod="GetByMaLopHocPhanMaSinhVien"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLopHocPhan" QueryStringField="MaLopHocPhan" Type="String" />
<asp:QueryStringParameter Name="MaSinhVien" QueryStringField="MaSinhVien" Type="String" />

			</Parameters>
		</data:KcqPhanCongDoAnTotNghiepDataSource>
		
		<br />


</asp:Content>

