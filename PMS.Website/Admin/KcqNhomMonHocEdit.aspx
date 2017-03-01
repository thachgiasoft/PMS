<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqNhomMonHocEdit.aspx.cs" Inherits="KcqNhomMonHocEdit" Title="KcqNhomMonHoc Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Nhom Mon Hoc - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaNhomMon" runat="server" DataSourceID="KcqNhomMonHocDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqNhomMonHocFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqNhomMonHocFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqNhomMonHoc not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqNhomMonHocDataSource ID="KcqNhomMonHocDataSource" runat="server"
			SelectMethod="GetByMaNhomMon"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaNhomMon" QueryStringField="MaNhomMon" Type="String" />

			</Parameters>
		</data:KcqNhomMonHocDataSource>
		
		<br />

		

</asp:Content>

