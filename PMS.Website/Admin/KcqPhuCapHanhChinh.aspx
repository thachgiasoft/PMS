<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqPhuCapHanhChinh.aspx.cs" Inherits="KcqPhuCapHanhChinh" Title="KcqPhuCapHanhChinh List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Phu Cap Hanh Chinh List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KcqPhuCapHanhChinhDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KcqPhuCapHanhChinh.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SoThangTruPhuCapHanhChinh" HeaderText="So Thang Tru Phu Cap Hanh Chinh" SortExpression="[SoThangTruPhuCapHanhChinh]"  />
				<asp:BoundField DataField="DonGiaPhuCapHanhChinh" HeaderText="Don Gia Phu Cap Hanh Chinh" SortExpression="[DonGiaPhuCapHanhChinh]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KcqPhuCapHanhChinh Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKcqPhuCapHanhChinh" OnClientClick="javascript:location.href='KcqPhuCapHanhChinhEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KcqPhuCapHanhChinhDataSource ID="KcqPhuCapHanhChinhDataSource" runat="server"
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
		</data:KcqPhuCapHanhChinhDataSource>
	    		
</asp:Content>



