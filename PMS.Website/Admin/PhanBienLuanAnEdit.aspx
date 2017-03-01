<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="PhanBienLuanAnEdit.aspx.cs" Inherits="PhanBienLuanAnEdit" Title="PhanBienLuanAn Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Phan Bien Luan An - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaGiangVien, NamHoc, HocKy, Loai" runat="server" DataSourceID="PhanBienLuanAnDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/PhanBienLuanAnFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/PhanBienLuanAnFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>PhanBienLuanAn not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:PhanBienLuanAnDataSource ID="PhanBienLuanAnDataSource" runat="server"
			SelectMethod="GetByMaGiangVienNamHocHocKyLoai"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaGiangVien" QueryStringField="MaGiangVien" Type="String" />
<asp:QueryStringParameter Name="NamHoc" QueryStringField="NamHoc" Type="String" />
<asp:QueryStringParameter Name="HocKy" QueryStringField="HocKy" Type="String" />
<asp:QueryStringParameter Name="Loai" QueryStringField="Loai" Type="String" />

			</Parameters>
		</data:PhanBienLuanAnDataSource>
		
		<br />


</asp:Content>

