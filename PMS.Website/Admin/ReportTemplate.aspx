<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ReportTemplate.aspx.cs" Inherits="ReportTemplate" Title="ReportTemplate List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Report Template List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ReportTemplateDataSource"
				DataKeyNames="ReportId"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ReportTemplate.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="ReportId" HeaderText="Report Id" SortExpression="[ReportID]" ReadOnly="True" />
				<data:HyperLinkField HeaderText="User Id" DataNavigateUrlFormatString="TaiKhoanEdit.aspx?MaTaiKhoan={0}" DataNavigateUrlFields="MaTaiKhoan" DataContainer="UserIdSource" DataTextField="TenDangNhap" />
				<asp:BoundField DataField="DuLieu" HeaderText="Du Lieu" SortExpression="[DuLieu]"  />
				<asp:BoundField DataField="NgayTao" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Tao" SortExpression="[NgayTao]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ReportTemplate Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnReportTemplate" OnClientClick="javascript:location.href='ReportTemplateEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ReportTemplateDataSource ID="ReportTemplateDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ReportTemplateProperty Name="TaiKhoan"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:ReportTemplateDataSource>
	    		
</asp:Content>



