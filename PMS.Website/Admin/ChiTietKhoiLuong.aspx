<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ChiTietKhoiLuong.aspx.cs" Inherits="ChiTietKhoiLuong" Title="ChiTietKhoiLuong List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Chi Tiet Khoi Luong List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ChiTietKhoiLuongDataSource"
				DataKeyNames="MaChiTiet"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ChiTietKhoiLuong.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:HyperLinkField HeaderText="Ma Khoi Luong" DataNavigateUrlFormatString="KhoiLuongKhacEdit.aspx?MaKhoiLuong={0}" DataNavigateUrlFields="MaKhoiLuong" DataContainer="MaKhoiLuongSource" DataTextField="LoaiHocPhan" />
				<asp:BoundField DataField="MaSinhVien" HeaderText="Ma Sinh Vien" SortExpression="[MaSinhVien]"  />
				<asp:BoundField DataField="NgayTao" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Tao" SortExpression="[NgayTao]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ChiTietKhoiLuong Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnChiTietKhoiLuong" OnClientClick="javascript:location.href='ChiTietKhoiLuongEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ChiTietKhoiLuongDataSource ID="ChiTietKhoiLuongDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ChiTietKhoiLuongProperty Name="KhoiLuongKhac"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:ChiTietKhoiLuongDataSource>
	    		
</asp:Content>



