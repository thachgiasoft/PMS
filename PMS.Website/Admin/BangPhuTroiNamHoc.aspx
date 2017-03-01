<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="BangPhuTroiNamHoc.aspx.cs" Inherits="BangPhuTroiNamHoc" Title="BangPhuTroiNamHoc List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Bang Phu Troi Nam Hoc List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="BangPhuTroiNamHocDataSource"
				DataKeyNames="MaGiangVien, NamHoc"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_BangPhuTroiNamHoc.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="TietQuyDoiHuongDanGvTinhNguyen" HeaderText="Tiet Quy Doi Huong Dan Gv Tinh Nguyen" SortExpression="[TietQuyDoiHuongDanGvTinhNguyen]"  />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" ReadOnly="True" />
				<asp:BoundField DataField="SoTietNckhTrungCap" HeaderText="So Tiet Nckh Trung Cap" SortExpression="[SoTietNCKH_TrungCap]"  />
				<asp:BoundField DataField="SoTietNckhCaoDang" HeaderText="So Tiet Nckh Cao Dang" SortExpression="[SoTietNCKH_CaoDang]"  />
				<asp:BoundField DataField="GioThiHk1" HeaderText="Gio Thi Hk1" SortExpression="[GioThiHK1]"  />
				<asp:BoundField DataField="GioThiHk2" HeaderText="Gio Thi Hk2" SortExpression="[GioThiHK2]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No BangPhuTroiNamHoc Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnBangPhuTroiNamHoc" OnClientClick="javascript:location.href='BangPhuTroiNamHocEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:BangPhuTroiNamHocDataSource ID="BangPhuTroiNamHocDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:BangPhuTroiNamHocProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:BangPhuTroiNamHocDataSource>
	    		
</asp:Content>



