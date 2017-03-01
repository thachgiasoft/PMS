<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqKhoanQuyDoi.aspx.cs" Inherits="KcqKhoanQuyDoi" Title="KcqKhoanQuyDoi List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Khoan Quy Doi List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KcqKhoanQuyDoiDataSource"
				DataKeyNames="MaKhoan"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KcqKhoanQuyDoi.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<asp:BoundField DataField="ThuTu" HeaderText="Thu Tu" SortExpression="[ThuTu]"  />
				<asp:BoundField DataField="DenKhoan" HeaderText="Den Khoan" SortExpression="[DenKhoan]"  />
				<data:HyperLinkField HeaderText="Ma Quy Doi" DataNavigateUrlFormatString="KcqQuyDoiGioChuanEdit.aspx?MaQuyDoi={0}" DataNavigateUrlFields="MaQuyDoi" DataContainer="MaQuyDoiSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="TuKhoan" HeaderText="Tu Khoan" SortExpression="[TuKhoan]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KcqKhoanQuyDoi Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKcqKhoanQuyDoi" OnClientClick="javascript:location.href='KcqKhoanQuyDoiEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KcqKhoanQuyDoiDataSource ID="KcqKhoanQuyDoiDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KcqKhoanQuyDoiProperty Name="KcqQuyDoiGioChuan"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:KcqKhoanQuyDoiDataSource>
	    		
</asp:Content>



