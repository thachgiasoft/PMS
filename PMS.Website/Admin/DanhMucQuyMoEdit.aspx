<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DanhMucQuyMoEdit.aspx.cs" Inherits="DanhMucQuyMoEdit" Title="DanhMucQuyMo Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Danh Muc Quy Mo - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Id" runat="server" DataSourceID="DanhMucQuyMoDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DanhMucQuyMoFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DanhMucQuyMoFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>DanhMucQuyMo not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:DanhMucQuyMoDataSource ID="DanhMucQuyMoDataSource" runat="server"
			SelectMethod="GetById"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="String" />

			</Parameters>
		</data:DanhMucQuyMoDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewDinhMucGioChuanToiThieuTheoChucVu1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewDinhMucGioChuanToiThieuTheoChucVu1_SelectedIndexChanged"			 			 
			DataSourceID="DinhMucGioChuanToiThieuTheoChucVuDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_DinhMucGioChuanToiThieuTheoChucVu.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Chuc Vu" DataNavigateUrlFormatString="ChucVuEdit.aspx?MaChucVu={0}" DataNavigateUrlFields="MaChucVu" DataContainer="MaChucVuSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="PhanTramGiamTru" HeaderText="Phan Tram Giam Tru" SortExpression="[PhanTramGiamTru]" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="SoTietNghiaVu" HeaderText="So Tiet Nghia Vu" SortExpression="[SoTietNghiaVu]" />				
				<asp:BoundField DataField="NhomGiangVien" HeaderText="Nhom Giang Vien" SortExpression="[NhomGiangVien]" />				
				<data:HyperLinkField HeaderText="Id Quy Mo" DataNavigateUrlFormatString="DanhMucQuyMoEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="IdQuyMoSource" DataTextField="MaQuyMo" />
			</Columns>
			<EmptyDataTemplate>
				<b>No Dinh Muc Gio Chuan Toi Thieu Theo Chuc Vu Found! </b>
				<asp:HyperLink runat="server" ID="hypDinhMucGioChuanToiThieuTheoChucVu" NavigateUrl="~/admin/DinhMucGioChuanToiThieuTheoChucVuEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:DinhMucGioChuanToiThieuTheoChucVuDataSource ID="DinhMucGioChuanToiThieuTheoChucVuDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:DinhMucGioChuanToiThieuTheoChucVuProperty Name="ChucVu"/> 
					<data:DinhMucGioChuanToiThieuTheoChucVuProperty Name="DanhMucQuyMo"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:DinhMucGioChuanToiThieuTheoChucVuFilter  Column="IdQuyMo" QueryStringField="Id" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:DinhMucGioChuanToiThieuTheoChucVuDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewQuyMoKhoa2" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewQuyMoKhoa2_SelectedIndexChanged"			 			 
			DataSourceID="QuyMoKhoaDataSource2"
			DataKeyNames="MaKhoa"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_QuyMoKhoa.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Id Quy Mo" DataNavigateUrlFormatString="DanhMucQuyMoEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="IdQuyMoSource" DataTextField="MaQuyMo" />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Quy Mo Khoa Found! </b>
				<asp:HyperLink runat="server" ID="hypQuyMoKhoa" NavigateUrl="~/admin/QuyMoKhoaEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:QuyMoKhoaDataSource ID="QuyMoKhoaDataSource2" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:QuyMoKhoaProperty Name="DanhMucQuyMo"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:QuyMoKhoaFilter  Column="IdQuyMo" QueryStringField="Id" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:QuyMoKhoaDataSource>		
		
		<br />
		

</asp:Content>

