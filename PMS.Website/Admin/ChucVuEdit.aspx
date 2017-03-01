<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ChucVuEdit.aspx.cs" Inherits="ChucVuEdit" Title="ChucVu Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Chuc Vu - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaChucVu" runat="server" DataSourceID="ChucVuDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ChucVuFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ChucVuFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>ChucVu not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:ChucVuDataSource ID="ChucVuDataSource" runat="server"
			SelectMethod="GetByMaChucVu"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaChucVu" QueryStringField="MaChucVu" Type="String" />

			</Parameters>
		</data:ChucVuDataSource>
		
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
						<data:DinhMucGioChuanToiThieuTheoChucVuFilter  Column="MaChucVu" QueryStringField="MaChucVu" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:DinhMucGioChuanToiThieuTheoChucVuDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewGiangVienChucVu2" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienChucVu2_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienChucVuDataSource2"
			DataKeyNames="MaQuanLy, MaGiangVien, MaChucVu"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienChucVu.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<data:HyperLinkField HeaderText="Ma Chuc Vu" DataNavigateUrlFormatString="ChucVuEdit.aspx?MaChucVu={0}" DataNavigateUrlFields="MaChucVu" DataContainer="MaChucVuSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NgayHieuLuc" HeaderText="Ngay Hieu Luc" SortExpression="[NgayHieuLuc]" />				
				<asp:BoundField DataField="NgayHetHieuLuc" HeaderText="Ngay Het Hieu Luc" SortExpression="[NgayHetHieuLuc]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Chuc Vu Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienChucVu" NavigateUrl="~/admin/GiangVienChucVuEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienChucVuDataSource ID="GiangVienChucVuDataSource2" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienChucVuProperty Name="ChucVu"/> 
					<data:GiangVienChucVuProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienChucVuFilter  Column="MaChucVu" QueryStringField="MaChucVu" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienChucVuDataSource>		
		
		<br />
		

</asp:Content>

