<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NoiDungCongViecQuanLy.aspx.cs" Inherits="NoiDungCongViecQuanLy" Title="NoiDungCongViecQuanLy List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Noi Dung Cong Viec Quan Ly List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="NoiDungCongViecQuanLyDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_NoiDungCongViecQuanLy.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NoiDung" HeaderText="Noi Dung" SortExpression="[NoiDung]"  />
				<data:HyperLinkField HeaderText="Ma Cong Viec" DataNavigateUrlFormatString="DanhMucHoatDongQuanLyEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaCongViecSource" DataTextField="MaHoatDong" />
			</Columns>
			<EmptyDataTemplate>
				<b>No NoiDungCongViecQuanLy Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnNoiDungCongViecQuanLy" OnClientClick="javascript:location.href='NoiDungCongViecQuanLyEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:NoiDungCongViecQuanLyDataSource ID="NoiDungCongViecQuanLyDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:NoiDungCongViecQuanLyProperty Name="DanhMucHoatDongQuanLy"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:NoiDungCongViecQuanLyDataSource>
	    		
</asp:Content>



