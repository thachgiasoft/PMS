<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="QuyMoKhoa.aspx.cs" Inherits="QuyMoKhoa" Title="QuyMoKhoa List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Quy Mo Khoa List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="QuyMoKhoaDataSource"
				DataKeyNames="MaKhoa"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_QuyMoKhoa.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<data:HyperLinkField HeaderText="Id Quy Mo" DataNavigateUrlFormatString="DanhMucQuyMoEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="IdQuyMoSource" DataTextField="MaQuyMo" />
				<asp:BoundField DataField="MaKhoa" HeaderText="Ma Khoa" SortExpression="[MaKhoa]" ReadOnly="True" />
			</Columns>
			<EmptyDataTemplate>
				<b>No QuyMoKhoa Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnQuyMoKhoa" OnClientClick="javascript:location.href='QuyMoKhoaEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:QuyMoKhoaDataSource ID="QuyMoKhoaDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:QuyMoKhoaProperty Name="DanhMucQuyMo"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:QuyMoKhoaDataSource>
	    		
</asp:Content>



