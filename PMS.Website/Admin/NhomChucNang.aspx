<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NhomChucNang.aspx.cs" Inherits="NhomChucNang" Title="NhomChucNang List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nhom Chuc Nang List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="NhomChucNangDataSource"
				DataKeyNames="MaChucNang, MaNhomQuyen"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_NhomChucNang.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:HyperLinkField HeaderText="Ma Chuc Nang" DataNavigateUrlFormatString="ChucNangEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaChucNangSource" DataTextField="PhanLoai" />
				<data:HyperLinkField HeaderText="Ma Nhom Quyen" DataNavigateUrlFormatString="NhomQuyenEdit.aspx?MaNhomQuyen={0}" DataNavigateUrlFields="MaNhomQuyen" DataContainer="MaNhomQuyenSource" DataTextField="TenNhomQuyen" />
				<asp:BoundField DataField="DuLieu" HeaderText="Du Lieu" SortExpression="[DuLieu]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No NhomChucNang Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnNhomChucNang" OnClientClick="javascript:location.href='NhomChucNangEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:NhomChucNangDataSource ID="NhomChucNangDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:NhomChucNangProperty Name="NhomQuyen"/> 
					<data:NhomChucNangProperty Name="ChucNang"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:NhomChucNangDataSource>
	    		
</asp:Content>



