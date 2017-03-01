<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LopHocPhanBacDaoTao.aspx.cs" Inherits="LopHocPhanBacDaoTao" Title="LopHocPhanBacDaoTao List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Lop Hoc Phan Bac Dao Tao List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="LopHocPhanBacDaoTaoDataSource"
				DataKeyNames="MaLopHocPhan, MaHeSoBacDaoTao"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_LopHocPhanBacDaoTao.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:HyperLinkField HeaderText="Ma He So Bac Dao Tao" DataNavigateUrlFormatString="HeSoBacDaoTaoEdit.aspx?MaHeSo={0}" DataNavigateUrlFields="MaHeSo" DataContainer="MaHeSoBacDaoTaoSource" DataTextField="Stt" />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" ReadOnly="True" />
			</Columns>
			<EmptyDataTemplate>
				<b>No LopHocPhanBacDaoTao Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnLopHocPhanBacDaoTao" OnClientClick="javascript:location.href='LopHocPhanBacDaoTaoEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:LopHocPhanBacDaoTaoDataSource ID="LopHocPhanBacDaoTaoDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:LopHocPhanBacDaoTaoProperty Name="HeSoBacDaoTao"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:LopHocPhanBacDaoTaoDataSource>
	    		
</asp:Content>



