<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ChotKhoiLuongGiangDay.aspx.cs" Inherits="ChotKhoiLuongGiangDay" Title="ChotKhoiLuongGiangDay List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Chot Khoi Luong Giang Day List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ChotKhoiLuongGiangDayDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ChotKhoiLuongGiangDay.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:BoundRadioButtonField DataField="DoAnTotNghiep" HeaderText="Do An Tot Nghiep" SortExpression="[DoAnTotNghiep]"  />
				<data:BoundRadioButtonField DataField="KhoiLuongKhac" HeaderText="Khoi Luong Khac" SortExpression="[KhoiLuongKhac]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<data:BoundRadioButtonField DataField="DoAnMonHoc" HeaderText="Do An Mon Hoc" SortExpression="[DoAnMonHoc]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<data:BoundRadioButtonField DataField="LyThuyetThucHanh" HeaderText="Ly Thuyet Thuc Hanh" SortExpression="[LyThuyetThucHanh]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ChotKhoiLuongGiangDay Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnChotKhoiLuongGiangDay" OnClientClick="javascript:location.href='ChotKhoiLuongGiangDayEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ChotKhoiLuongGiangDayDataSource ID="ChotKhoiLuongGiangDayDataSource" runat="server"
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
		</data:ChotKhoiLuongGiangDayDataSource>
	    		
</asp:Content>



