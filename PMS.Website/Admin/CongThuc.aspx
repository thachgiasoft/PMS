<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="CongThuc.aspx.cs" Inherits="CongThuc" Title="CongThuc List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Cong Thuc List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="CongThucDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_CongThuc.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="Col07" HeaderText="Col07" SortExpression="[Col07]"  />
				<asp:BoundField DataField="Col06" HeaderText="Col06" SortExpression="[Col06]"  />
				<asp:BoundField DataField="Col05" HeaderText="Col05" SortExpression="[Col05]"  />
				<asp:BoundField DataField="UpdateStaff" HeaderText="Update Staff" SortExpression="[UpdateStaff]"  />
				<asp:BoundField DataField="UpdateDate" HeaderText="Update Date" SortExpression="[UpdateDate]"  />
				<asp:BoundField DataField="Col08" HeaderText="Col08" SortExpression="[Col08]"  />
				<asp:BoundField DataField="Col01" HeaderText="Col01" SortExpression="[Col01]"  />
				<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="[Name]"  />
				<asp:BoundField DataField="YearStudy" HeaderText="Year Study" SortExpression="[YearStudy]"  />
				<asp:BoundField DataField="Col04" HeaderText="Col04" SortExpression="[Col04]"  />
				<asp:BoundField DataField="Col03" HeaderText="Col03" SortExpression="[Col03]"  />
				<asp:BoundField DataField="Col02" HeaderText="Col02" SortExpression="[Col02]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No CongThuc Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnCongThuc" OnClientClick="javascript:location.href='CongThucEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:CongThucDataSource ID="CongThucDataSource" runat="server"
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
		</data:CongThucDataSource>
	    		
</asp:Content>



