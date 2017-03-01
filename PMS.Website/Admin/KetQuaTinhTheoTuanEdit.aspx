<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KetQuaTinhTheoTuanEdit.aspx.cs" Inherits="KetQuaTinhTheoTuanEdit" Title="KetQuaTinhTheoTuan Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Ket Qua Tinh Theo Tuan - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKetQua" runat="server" DataSourceID="KetQuaTinhTheoTuanDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KetQuaTinhTheoTuanFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KetQuaTinhTheoTuanFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KetQuaTinhTheoTuan not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KetQuaTinhTheoTuanDataSource ID="KetQuaTinhTheoTuanDataSource" runat="server"
			SelectMethod="GetByMaKetQua"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKetQua" QueryStringField="MaKetQua" Type="String" />

			</Parameters>
		</data:KetQuaTinhTheoTuanDataSource>
		
		<br />

		

</asp:Content>

