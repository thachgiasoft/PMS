<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThanhTraTheoThoiKhoaBieuEdit.aspx.cs" Inherits="ThanhTraTheoThoiKhoaBieuEdit" Title="ThanhTraTheoThoiKhoaBieu Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thanh Tra Theo Thoi Khoa Bieu - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLichHoc, MaCanBoGiangDay" runat="server" DataSourceID="ThanhTraTheoThoiKhoaBieuDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ThanhTraTheoThoiKhoaBieuFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ThanhTraTheoThoiKhoaBieuFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>ThanhTraTheoThoiKhoaBieu not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:ThanhTraTheoThoiKhoaBieuDataSource ID="ThanhTraTheoThoiKhoaBieuDataSource" runat="server"
			SelectMethod="GetByMaLichHocMaCanBoGiangDay"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLichHoc" QueryStringField="MaLichHoc" Type="String" />
<asp:QueryStringParameter Name="MaCanBoGiangDay" QueryStringField="MaCanBoGiangDay" Type="String" />

			</Parameters>
		</data:ThanhTraTheoThoiKhoaBieuDataSource>
		
		<br />


</asp:Content>

