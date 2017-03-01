<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoTinChiEdit.aspx.cs" Inherits="HeSoTinChiEdit" Title="HeSoTinChi Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Tin Chi - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaHeDaoTao, MaBacDaoTao, MaLoaiGiangVien" runat="server" DataSourceID="HeSoTinChiDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoTinChiFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoTinChiFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>HeSoTinChi not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:HeSoTinChiDataSource ID="HeSoTinChiDataSource" runat="server"
			SelectMethod="GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaHeDaoTao" QueryStringField="MaHeDaoTao" Type="String" />
<asp:QueryStringParameter Name="MaBacDaoTao" QueryStringField="MaBacDaoTao" Type="String" />
<asp:QueryStringParameter Name="MaLoaiGiangVien" QueryStringField="MaLoaiGiangVien" Type="String" />

			</Parameters>
		</data:HeSoTinChiDataSource>
		
		<br />


</asp:Content>

