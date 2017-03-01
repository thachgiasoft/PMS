<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NhomQuyenEdit.aspx.cs" Inherits="NhomQuyenEdit" Title="NhomQuyen Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nhom Quyen - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaNhomQuyen" runat="server" DataSourceID="NhomQuyenDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomQuyenFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomQuyenFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>NhomQuyen not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:NhomQuyenDataSource ID="NhomQuyenDataSource" runat="server"
			SelectMethod="GetByMaNhomQuyen"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaNhomQuyen" QueryStringField="MaNhomQuyen" Type="String" />

			</Parameters>
		</data:NhomQuyenDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewTaiKhoan1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewTaiKhoan1_SelectedIndexChanged"			 			 
			DataSourceID="TaiKhoanDataSource1"
			DataKeyNames="MaTaiKhoan"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_TaiKhoan.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Nhom Quyen" DataNavigateUrlFormatString="NhomQuyenEdit.aspx?MaNhomQuyen={0}" DataNavigateUrlFields="MaNhomQuyen" DataContainer="MaNhomQuyenSource" DataTextField="TenNhomQuyen" />
				<asp:BoundField DataField="TenDangNhap" HeaderText="Ten Dang Nhap" SortExpression="[TenDangNhap]" />				
				<asp:BoundField DataField="MatKhau" HeaderText="Mat Khau" SortExpression="[MatKhau]" />				
				<asp:BoundField DataField="HoTen" HeaderText="Ho Ten" SortExpression="[HoTen]" />				
				<asp:BoundField DataField="TenMayTinh" HeaderText="Ten May Tinh" SortExpression="[TenMayTinh]" />				
				<asp:BoundField DataField="DuongDan" HeaderText="Duong Dan" SortExpression="[DuongDan]" />				
				<asp:BoundField DataField="PhienBan" HeaderText="Phien Ban" SortExpression="[PhienBan]" />				
				<asp:BoundField DataField="NgayDangNhap" HeaderText="Ngay Dang Nhap" SortExpression="[NgayDangNhap]" />				
				<asp:BoundField DataField="TrangThai" HeaderText="Trang Thai" SortExpression="[TrangThai]" />				
				<asp:BoundField DataField="SkinName" HeaderText="Skin Name" SortExpression="[SkinName]" />				
				<asp:BoundField DataField="NgayTao" HeaderText="Ngay Tao" SortExpression="[NgayTao]" />				
				<asp:BoundField DataField="ResetPassWordGv" HeaderText="Reset Pass Word Gv" SortExpression="[ResetPassWordGv]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Tai Khoan Found! </b>
				<asp:HyperLink runat="server" ID="hypTaiKhoan" NavigateUrl="~/admin/TaiKhoanEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:TaiKhoanDataSource ID="TaiKhoanDataSource1" runat="server" SelectMethod="Find"
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
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:TaiKhoanFilter  Column="MaNhomQuyen" QueryStringField="MaNhomQuyen" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:TaiKhoanDataSource>		
		
		<br />
		

</asp:Content>

