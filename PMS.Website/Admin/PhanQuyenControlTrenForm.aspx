<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="PhanQuyenControlTrenForm.aspx.cs" Inherits="PhanQuyenControlTrenForm" Title="PhanQuyenControlTrenForm List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Phan Quyen Control Tren Form List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="PhanQuyenControlTrenFormDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_PhanQuyenControlTrenForm.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:BoundRadioButtonField DataField="KhongDuocPhepCapNhat" HeaderText="Khong Duoc Phep Cap Nhat" SortExpression="[KhongDuocPhepCapNhat]"  />
				<asp:BoundField DataField="TenForm" HeaderText="Ten Form" SortExpression="[TenForm]"  />
				<asp:BoundField DataField="MaTaiKhoan" HeaderText="Ma Tai Khoan" SortExpression="[MaTaiKhoan]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No PhanQuyenControlTrenForm Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnPhanQuyenControlTrenForm" OnClientClick="javascript:location.href='PhanQuyenControlTrenFormEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:PhanQuyenControlTrenFormDataSource ID="PhanQuyenControlTrenFormDataSource" runat="server"
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
		</data:PhanQuyenControlTrenFormDataSource>
	    		
</asp:Content>



