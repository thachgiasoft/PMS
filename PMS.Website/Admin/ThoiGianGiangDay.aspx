<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThoiGianGiangDay.aspx.cs" Inherits="ThoiGianGiangDay" Title="ThoiGianGiangDay List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thoi Gian Giang Day List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThoiGianGiangDayDataSource"
				DataKeyNames="NamHoc, HocKy"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThoiGianGiangDay.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayBatDau" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Bat Dau" SortExpression="[NgayBatDau]"  />
				<asp:BoundField DataField="NgayKetThuc" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Ket Thuc" SortExpression="[NgayKetThuc]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" ReadOnly="True" />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" ReadOnly="True" />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThoiGianGiangDay Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThoiGianGiangDay" OnClientClick="javascript:location.href='ThoiGianGiangDayEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThoiGianGiangDayDataSource ID="ThoiGianGiangDayDataSource" runat="server"
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
		</data:ThoiGianGiangDayDataSource>
	    		
</asp:Content>



