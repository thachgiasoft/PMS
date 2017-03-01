<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ReportManagerments.aspx.cs" Inherits="ReportManagerments" Title="ReportManagerments List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Report Managerments List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ReportManagermentsDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ReportManagerments.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="Note1" HeaderText="Note1" SortExpression="[Note1]"  />
				<asp:BoundField DataField="Note2" HeaderText="Note2" SortExpression="[Note2]"  />
				<asp:BoundField DataField="Note3" HeaderText="Note3" SortExpression="[Note3]"  />
				<asp:BoundField DataField="ReportName" HeaderText="Report Name" SortExpression="[ReportName]"  />
				<asp:BoundField DataField="Storeprocedure" HeaderText="Storeprocedure" SortExpression="[Storeprocedure]"  />
				<asp:BoundField DataField="FileName" HeaderText="File Name" SortExpression="[FileName]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ReportManagerments Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnReportManagerments" OnClientClick="javascript:location.href='ReportManagermentsEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ReportManagermentsDataSource ID="ReportManagermentsDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
		>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:ReportManagermentsDataSource>
	    		
</asp:Content>



