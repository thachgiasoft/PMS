<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="History.aspx.cs" Inherits="History" Title="History List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">History List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="HistoryDataSource"
				DataKeyNames="HistoryId"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_History.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="ComputerName" HeaderText="Computer Name" SortExpression="[ComputerName]"  />
				<asp:BoundField DataField="UpdatedDate" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Updated Date" SortExpression="[UpdatedDate]"  />
				<asp:BoundField DataField="Username" HeaderText="Username" SortExpression="[Username]"  />
				<asp:BoundField DataField="OldProfessor" HeaderText="Old Professor" SortExpression="[OldProfessor]"  />
				<asp:BoundField DataField="NewProfessor" HeaderText="New Professor" SortExpression="[NewProfessor]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No History Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnHistory" OnClientClick="javascript:location.href='HistoryEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:HistoryDataSource ID="HistoryDataSource" runat="server"
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
		</data:HistoryDataSource>
	    		
</asp:Content>



