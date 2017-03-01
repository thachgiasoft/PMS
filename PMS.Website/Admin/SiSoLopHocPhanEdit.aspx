<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="SiSoLopHocPhanEdit.aspx.cs" Inherits="SiSoLopHocPhanEdit" Title="SiSoLopHocPhan Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Si So Lop Hoc Phan - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="ScheduleStudyUnitId" runat="server" DataSourceID="SiSoLopHocPhanDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/SiSoLopHocPhanFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/SiSoLopHocPhanFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>SiSoLopHocPhan not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:SiSoLopHocPhanDataSource ID="SiSoLopHocPhanDataSource" runat="server"
			SelectMethod="GetByScheduleStudyUnitId"
		>
			<Parameters>
				<asp:QueryStringParameter Name="ScheduleStudyUnitId" QueryStringField="ScheduleStudyUnitId" Type="String" />

			</Parameters>
		</data:SiSoLopHocPhanDataSource>
		
		<br />

		

</asp:Content>

