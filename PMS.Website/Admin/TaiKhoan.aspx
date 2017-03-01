<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="TaiKhoan.aspx.cs" Inherits="TaiKhoan" Title="TaiKhoan List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Tai Khoan List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="TaiKhoanDataSource"
				DataKeyNames="MaTaiKhoan"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_TaiKhoan.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:BoundRadioButtonField DataField="ResetPassWordGv" HeaderText="Reset Pass Word Gv" SortExpression="[ResetPassWordGv]"  />
				<data:HyperLinkField HeaderText="Ma Nhom Quyen" DataNavigateUrlFormatString="NhomQuyenEdit.aspx?MaNhomQuyen={0}" DataNavigateUrlFields="MaNhomQuyen" DataContainer="MaNhomQuyenSource" DataTextField="TenNhomQuyen" />
				<asp:BoundField DataField="TenDangNhap" HeaderText="Ten Dang Nhap" SortExpression="[TenDangNhap]"  />
				<asp:BoundField DataField="MatKhau" HeaderText="Mat Khau" SortExpression="[MatKhau]"  />
				<asp:BoundField DataField="HoTen" HeaderText="Ho Ten" SortExpression="[HoTen]"  />
				<asp:BoundField DataField="TenMayTinh" HeaderText="Ten May Tinh" SortExpression="[TenMayTinh]"  />
				<asp:BoundField DataField="DuongDan" HeaderText="Duong Dan" SortExpression="[DuongDan]"  />
				<asp:BoundField DataField="PhienBan" HeaderText="Phien Ban" SortExpression="[PhienBan]"  />
				<asp:BoundField DataField="NgayDangNhap" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Dang Nhap" SortExpression="[NgayDangNhap]"  />
				<data:BoundRadioButtonField DataField="TrangThai" HeaderText="Trang Thai" SortExpression="[TrangThai]"  />
				<asp:BoundField DataField="SkinName" HeaderText="Skin Name" SortExpression="[SkinName]"  />
				<asp:BoundField DataField="NgayTao" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Tao" SortExpression="[NgayTao]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No TaiKhoan Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnTaiKhoan" OnClientClick="javascript:location.href='TaiKhoanEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:TaiKhoanDataSource ID="TaiKhoanDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:TaiKhoanProperty Name="NhomQuyen"/> 
					<%--<data:TaiKhoanProperty Name="UserIdTaiKhoanCollection_From_HeThong" />--%>
					<%--<data:TaiKhoanProperty Name="HeThongCollectionGetByParentId" />--%>
					<%--<data:TaiKhoanProperty Name="ParentIdTaiKhoanCollection_From_HeThong" />--%>
					<%--<data:TaiKhoanProperty Name="HeThongCollectionGetByUserId" />--%>
					<%--<data:TaiKhoanProperty Name="GiangVienCollection" />--%>
					<%--<data:TaiKhoanProperty Name="ReportTemplateCollection" />--%>
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:TaiKhoanDataSource>
	    		
</asp:Content>



