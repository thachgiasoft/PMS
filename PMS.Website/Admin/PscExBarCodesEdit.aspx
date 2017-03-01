<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="PscExBarCodesEdit.aspx.cs" Inherits="PscExBarCodesEdit" Title="PscExBarCodes Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Psc Ex Bar Codes - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLopHocPhan, KyThi, LanThi, BarCode" runat="server" DataSourceID="PscExBarCodesDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/PscExBarCodesFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/PscExBarCodesFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>PscExBarCodes not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:PscExBarCodesDataSource ID="PscExBarCodesDataSource" runat="server"
			SelectMethod="GetByMaLopHocPhanKyThiLanThiBarCode"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLopHocPhan" QueryStringField="MaLopHocPhan" Type="String" />
<asp:QueryStringParameter Name="KyThi" QueryStringField="KyThi" Type="String" />
<asp:QueryStringParameter Name="LanThi" QueryStringField="LanThi" Type="String" />
<asp:QueryStringParameter Name="BarCode" QueryStringField="BarCode" Type="String" />

			</Parameters>
		</data:PscExBarCodesDataSource>
		
		<br />


</asp:Content>

