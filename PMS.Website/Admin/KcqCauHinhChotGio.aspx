<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqCauHinhChotGio.aspx.cs" Inherits="KcqCauHinhChotGio" Title="KcqCauHinhChotGio List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Cau Hinh Chot Gio List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KcqCauHinhChotGioDataSource"
				DataKeyNames="MaCauHinhChotGio"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KcqCauHinhChotGio.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:BoundRadioButtonField DataField="IsLocked" HeaderText="Is Locked" SortExpression="[IsLocked]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="DenNgay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Den Ngay" SortExpression="[DenNgay]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="TenQuanLy" HeaderText="Ten Quan Ly" SortExpression="[TenQuanLy]"  />
				<asp:BoundField DataField="TuNgay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Tu Ngay" SortExpression="[TuNgay]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KcqCauHinhChotGio Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKcqCauHinhChotGio" OnClientClick="javascript:location.href='KcqCauHinhChotGioEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KcqCauHinhChotGioDataSource ID="KcqCauHinhChotGioDataSource" runat="server"
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
		</data:KcqCauHinhChotGioDataSource>
	    		
</asp:Content>



