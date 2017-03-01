<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NamHocHienThiThuLaoLenWeb.aspx.cs" Inherits="NamHocHienThiThuLaoLenWeb" Title="NamHocHienThiThuLaoLenWeb List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nam Hoc Hien Thi Thu Lao Len Web List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="NamHocHienThiThuLaoLenWebDataSource"
				DataKeyNames="NamHoc, HocKy"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_NamHocHienThiThuLaoLenWeb.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:BoundRadioButtonField DataField="Chon" HeaderText="Chon" SortExpression="[Chon]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" ReadOnly="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" ReadOnly="True" />
			</Columns>
			<EmptyDataTemplate>
				<b>No NamHocHienThiThuLaoLenWeb Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnNamHocHienThiThuLaoLenWeb" OnClientClick="javascript:location.href='NamHocHienThiThuLaoLenWebEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:NamHocHienThiThuLaoLenWebDataSource ID="NamHocHienThiThuLaoLenWebDataSource" runat="server"
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
		</data:NamHocHienThiThuLaoLenWebDataSource>
	    		
</asp:Content>



