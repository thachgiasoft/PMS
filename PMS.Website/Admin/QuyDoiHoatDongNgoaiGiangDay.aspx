<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="QuyDoiHoatDongNgoaiGiangDay.aspx.cs" Inherits="QuyDoiHoatDongNgoaiGiangDay" Title="QuyDoiHoatDongNgoaiGiangDay List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Quy Doi Hoat Dong Ngoai Giang Day List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="QuyDoiHoatDongNgoaiGiangDayDataSource"
				DataKeyNames="MaQuanLy"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_QuyDoiHoatDongNgoaiGiangDay.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SoTien" HeaderText="So Tien" SortExpression="[SoTien]"  />
				<asp:BoundField DataField="SoTietQuyDoi" HeaderText="So Tiet Quy Doi" SortExpression="[SoTietQuyDoi]"  />
				<data:HyperLinkField HeaderText="Ma Hoat Dong Ngoai Giang Day" DataNavigateUrlFormatString="GiangVienHoatDongNgoaiGiangDayEdit.aspx?MaQuanLy={0}" DataNavigateUrlFields="MaQuanLy" DataContainer="MaHoatDongNgoaiGiangDaySource" DataTextField="NamHoc" />
			</Columns>
			<EmptyDataTemplate>
				<b>No QuyDoiHoatDongNgoaiGiangDay Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnQuyDoiHoatDongNgoaiGiangDay" OnClientClick="javascript:location.href='QuyDoiHoatDongNgoaiGiangDayEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:QuyDoiHoatDongNgoaiGiangDayDataSource ID="QuyDoiHoatDongNgoaiGiangDayDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:QuyDoiHoatDongNgoaiGiangDayProperty Name="GiangVienHoatDongNgoaiGiangDay"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:QuyDoiHoatDongNgoaiGiangDayDataSource>
	    		
</asp:Content>



