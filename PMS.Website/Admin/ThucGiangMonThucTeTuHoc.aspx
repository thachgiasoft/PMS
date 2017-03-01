<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThucGiangMonThucTeTuHoc.aspx.cs" Inherits="ThucGiangMonThucTeTuHoc" Title="ThucGiangMonThucTeTuHoc List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thuc Giang Mon Thuc Te Tu Hoc List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThucGiangMonThucTeTuHocDataSource"
				DataKeyNames="MaQuanLy"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThucGiangMonThucTeTuHoc.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<data:HyperLinkField HeaderText="Ma He So Cong Viec" DataNavigateUrlFormatString="HeSoCongViecEdit.aspx?MaHeSo={0}" DataNavigateUrlFields="MaHeSo" DataContainer="MaHeSoCongViecSource" DataTextField="Stt" />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThucGiangMonThucTeTuHoc Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThucGiangMonThucTeTuHoc" OnClientClick="javascript:location.href='ThucGiangMonThucTeTuHocEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThucGiangMonThucTeTuHocDataSource ID="ThucGiangMonThucTeTuHocDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ThucGiangMonThucTeTuHocProperty Name="HeSoCongViec"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:ThucGiangMonThucTeTuHocDataSource>
	    		
</asp:Content>



