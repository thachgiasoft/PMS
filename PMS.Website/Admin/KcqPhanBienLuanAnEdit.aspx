<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqPhanBienLuanAnEdit.aspx.cs" Inherits="KcqPhanBienLuanAnEdit" Title="KcqPhanBienLuanAn Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Phan Bien Luan An - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaGiangVien, NamHoc, HocKy, Loai" runat="server" DataSourceID="KcqPhanBienLuanAnDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqPhanBienLuanAnFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqPhanBienLuanAnFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqPhanBienLuanAn not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqPhanBienLuanAnDataSource ID="KcqPhanBienLuanAnDataSource" runat="server"
			SelectMethod="GetByMaGiangVienNamHocHocKyLoai"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaGiangVien" QueryStringField="MaGiangVien" Type="String" />
<asp:QueryStringParameter Name="NamHoc" QueryStringField="NamHoc" Type="String" />
<asp:QueryStringParameter Name="HocKy" QueryStringField="HocKy" Type="String" />
<asp:QueryStringParameter Name="Loai" QueryStringField="Loai" Type="String" />

			</Parameters>
		</data:KcqPhanBienLuanAnDataSource>
		
		<br />


</asp:Content>

