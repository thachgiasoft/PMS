<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ChucNang.aspx.cs" Inherits="ChucNang" Title="ChucNang List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Chuc Nang List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ChucNangDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ChucNang.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:HyperLinkField HeaderText="Parent Id" DataNavigateUrlFormatString="ChucNangEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="ParentIdSource" DataTextField="PhanLoai" />
				<asp:BoundField DataField="PhanLoai" HeaderText="Phan Loai" SortExpression="[PhanLoai]"  />
				<data:BoundRadioButtonField DataField="Menu" HeaderText="Menu" SortExpression="[Menu]"  />
				<data:BoundRadioButtonField DataField="BeginGroup" HeaderText="Begin Group" SortExpression="[BeginGroup]"  />
				<data:BoundRadioButtonField DataField="RibbonStyle" HeaderText="Ribbon Style" SortExpression="[RibbonStyle]"  />
				<asp:BoundField DataField="DataLayout" HeaderText="Data Layout" SortExpression="[DataLayout]"  />
				<asp:BoundField DataField="TenChucNang" HeaderText="Ten Chuc Nang" SortExpression="[TenChucNang]"  />
				<asp:BoundField DataField="TenForm" HeaderText="Ten Form" SortExpression="[TenForm]"  />
				<asp:BoundField DataField="HinhAnh" HeaderText="Hinh Anh" SortExpression="[HinhAnh]"  />
				<asp:BoundField DataField="ThuTu" HeaderText="Thu Tu" SortExpression="[ThuTu]"  />
				<asp:BoundField DataField="TenPhuongThuc" HeaderText="Ten Phuong Thuc" SortExpression="[TenPhuongThuc]"  />
				<asp:BoundField DataField="ThamSo" HeaderText="Tham So" SortExpression="[ThamSo]"  />
				<asp:BoundField DataField="KieuForm" HeaderText="Kieu Form" SortExpression="[KieuForm]"  />
				<data:BoundRadioButtonField DataField="TrangThai" HeaderText="Trang Thai" SortExpression="[TrangThai]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ChucNang Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnChucNang" OnClientClick="javascript:location.href='ChucNangEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ChucNangDataSource ID="ChucNangDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ChucNangProperty Name="ChucNang"/> 
					<%--<data:ChucNangProperty Name="NhomChucNangCollection" />--%>
					<%--<data:ChucNangProperty Name="MaNhomQuyenNhomQuyenCollection_From_NhomChucNang" />--%>
					<%--<data:ChucNangProperty Name="ChucNangCollection" />--%>
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:ChucNangDataSource>
	    		
</asp:Content>



