<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="SiSoLopHocPhan.aspx.cs" Inherits="SiSoLopHocPhan" Title="SiSoLopHocPhan List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Si So Lop Hoc Phan List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="SiSoLopHocPhanDataSource"
				DataKeyNames="ScheduleStudyUnitId"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_SiSoLopHocPhan.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="ScheduleStudyUnitId" HeaderText="Schedule Study Unit Id" SortExpression="[ScheduleStudyUnitID]" ReadOnly="True" />
				<asp:BoundField DataField="SiSoLop" HeaderText="Si So Lop" SortExpression="[SiSoLop]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No SiSoLopHocPhan Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnSiSoLopHocPhan" OnClientClick="javascript:location.href='SiSoLopHocPhanEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:SiSoLopHocPhanDataSource ID="SiSoLopHocPhanDataSource" runat="server"
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
		</data:SiSoLopHocPhanDataSource>
	    		
</asp:Content>



