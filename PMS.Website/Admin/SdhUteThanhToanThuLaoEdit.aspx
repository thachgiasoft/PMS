<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="SdhUteThanhToanThuLaoEdit.aspx.cs" Inherits="SdhUteThanhToanThuLaoEdit" Title="SdhUteThanhToanThuLao Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Sdh Ute Thanh Toan Thu Lao - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="IdKhoiLuongQuyDoi" runat="server" DataSourceID="SdhUteThanhToanThuLaoDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/SdhUteThanhToanThuLaoFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/SdhUteThanhToanThuLaoFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>SdhUteThanhToanThuLao not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:SdhUteThanhToanThuLaoDataSource ID="SdhUteThanhToanThuLaoDataSource" runat="server"
			SelectMethod="GetByIdKhoiLuongQuyDoi"
		>
			<Parameters>
				<asp:QueryStringParameter Name="IdKhoiLuongQuyDoi" QueryStringField="IdKhoiLuongQuyDoi" Type="String" />

			</Parameters>
		</data:SdhUteThanhToanThuLaoDataSource>
		
		<br />

		

</asp:Content>

