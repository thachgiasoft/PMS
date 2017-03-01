<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeThong.aspx.cs" Inherits="HeThong" Title="HeThong List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He Thong List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="HeThongDataSource"
				DataKeyNames="UserId, ParentId"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_HeThong.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:HyperLinkField HeaderText="User Id" DataNavigateUrlFormatString="TaiKhoanEdit.aspx?MaTaiKhoan={0}" DataNavigateUrlFields="MaTaiKhoan" DataContainer="UserIdSource" DataTextField="TenDangNhap" />
				<data:HyperLinkField HeaderText="Parent Id" DataNavigateUrlFormatString="TaiKhoanEdit.aspx?MaTaiKhoan={0}" DataNavigateUrlFields="MaTaiKhoan" DataContainer="ParentIdSource" DataTextField="TenDangNhap" />
			</Columns>
			<EmptyDataTemplate>
				<b>No HeThong Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnHeThong" OnClientClick="javascript:location.href='HeThongEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:HeThongDataSource ID="HeThongDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:HeThongProperty Name="TaiKhoan"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:HeThongDataSource>
	    		
</asp:Content>



