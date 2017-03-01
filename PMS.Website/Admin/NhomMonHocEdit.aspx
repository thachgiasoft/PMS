<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NhomMonHocEdit.aspx.cs" Inherits="NhomMonHocEdit" Title="NhomMonHoc Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nhom Mon Hoc - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaNhomMon" runat="server" DataSourceID="NhomMonHocDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomMonHocFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomMonHocFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>NhomMonHoc not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:NhomMonHocDataSource ID="NhomMonHocDataSource" runat="server"
			SelectMethod="GetByMaNhomMon"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaNhomMon" QueryStringField="MaNhomMon" Type="String" />

			</Parameters>
		</data:NhomMonHocDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewPhanNhomMonHoc1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewPhanNhomMonHoc1_SelectedIndexChanged"			 			 
			DataSourceID="PhanNhomMonHocDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_PhanNhomMonHoc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]" />				
				<asp:BoundField DataField="MaLoaiHocPhan" HeaderText="Ma Loai Hoc Phan" SortExpression="[MaLoaiHocPhan]" />				
				<data:HyperLinkField HeaderText="Ma Nhom Mon Hoc" DataNavigateUrlFormatString="NhomMonHocEdit.aspx?MaNhomMon={0}" DataNavigateUrlFields="MaNhomMon" DataContainer="MaNhomMonHocSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Phan Nhom Mon Hoc Found! </b>
				<asp:HyperLink runat="server" ID="hypPhanNhomMonHoc" NavigateUrl="~/admin/PhanNhomMonHocEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:PhanNhomMonHocDataSource ID="PhanNhomMonHocDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:PhanNhomMonHocProperty Name="NhomMonHoc"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:PhanNhomMonHocFilter  Column="MaNhomMonHoc" QueryStringField="MaNhomMon" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:PhanNhomMonHocDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewKcqPhanNhomMonHoc2" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKcqPhanNhomMonHoc2_SelectedIndexChanged"			 			 
			DataSourceID="KcqPhanNhomMonHocDataSource2"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KcqPhanNhomMonHoc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]" />				
				<asp:BoundField DataField="MaLoaiHocPhan" HeaderText="Ma Loai Hoc Phan" SortExpression="[MaLoaiHocPhan]" />				
				<data:HyperLinkField HeaderText="Ma Nhom Mon Hoc" DataNavigateUrlFormatString="NhomMonHocEdit.aspx?MaNhomMon={0}" DataNavigateUrlFields="MaNhomMon" DataContainer="MaNhomMonHocSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Kcq Phan Nhom Mon Hoc Found! </b>
				<asp:HyperLink runat="server" ID="hypKcqPhanNhomMonHoc" NavigateUrl="~/admin/KcqPhanNhomMonHocEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KcqPhanNhomMonHocDataSource ID="KcqPhanNhomMonHocDataSource2" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KcqPhanNhomMonHocProperty Name="NhomMonHoc"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KcqPhanNhomMonHocFilter  Column="MaNhomMonHoc" QueryStringField="MaNhomMon" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KcqPhanNhomMonHocDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewDonGia3" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewDonGia3_SelectedIndexChanged"			 			 
			DataSourceID="DonGiaDataSource3"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_DonGia.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]" />				
				<data:HyperLinkField HeaderText="Ma Loai Giang Vien" DataNavigateUrlFormatString="LoaiGiangVienEdit.aspx?MaLoaiGiangVien={0}" DataNavigateUrlFields="MaLoaiGiangVien" DataContainer="MaLoaiGiangVienSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Hoc Ham" DataNavigateUrlFormatString="HocHamEdit.aspx?MaHocHam={0}" DataNavigateUrlFields="MaHocHam" DataContainer="MaHocHamSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Hoc Vi" DataNavigateUrlFormatString="HocViEdit.aspx?MaHocVi={0}" DataNavigateUrlFields="MaHocVi" DataContainer="MaHocViSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="DonGiaClc" HeaderText="Don Gia Clc" SortExpression="[DonGiaClc]" />				
				<asp:BoundField DataField="HeSoQuyDoiChatLuong" HeaderText="He So Quy Doi Chat Luong" SortExpression="[HeSoQuyDoiChatLuong]" />				
				<asp:BoundField DataField="DonGiaTrongChuan" HeaderText="Don Gia Trong Chuan" SortExpression="[DonGiaTrongChuan]" />				
				<asp:BoundField DataField="DonGiaNgoaiChuan" HeaderText="Don Gia Ngoai Chuan" SortExpression="[DonGiaNgoaiChuan]" />				
				<asp:BoundField DataField="MaHinhThucDaoTao" HeaderText="Ma Hinh Thuc Dao Tao" SortExpression="[MaHinhThucDaoTao]" />				
				<asp:BoundField DataField="BacDaoTao" HeaderText="Bac Dao Tao" SortExpression="[BacDaoTao]" />				
				<data:HyperLinkField HeaderText="Ngon Ngu Giang Day" DataNavigateUrlFormatString="NgonNguGiangDayEdit.aspx?MaNgonNgu={0}" DataNavigateUrlFields="MaNgonNgu" DataContainer="NgonNguGiangDaySource" DataTextField="TenNgonNgu" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Nhom Mon" DataNavigateUrlFormatString="NhomMonHocEdit.aspx?MaNhomMon={0}" DataNavigateUrlFields="MaNhomMon" DataContainer="MaNhomMonSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NhomMonHoc" HeaderText="Nhom Mon Hoc" SortExpression="[NhomMonHoc]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Don Gia Found! </b>
				<asp:HyperLink runat="server" ID="hypDonGia" NavigateUrl="~/admin/DonGiaEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:DonGiaDataSource ID="DonGiaDataSource3" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:DonGiaProperty Name="NhomMonHoc"/> 
					<data:DonGiaProperty Name="HocHam"/> 
					<data:DonGiaProperty Name="HocVi"/> 
					<data:DonGiaProperty Name="LoaiGiangVien"/> 
					<data:DonGiaProperty Name="NgonNguGiangDay"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:DonGiaFilter  Column="MaNhomMon" QueryStringField="MaNhomMon" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:DonGiaDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewSdhPhanNhomMonHoc4" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewSdhPhanNhomMonHoc4_SelectedIndexChanged"			 			 
			DataSourceID="SdhPhanNhomMonHocDataSource4"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_SdhPhanNhomMonHoc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]" />				
				<asp:BoundField DataField="MaLoaiHocPhan" HeaderText="Ma Loai Hoc Phan" SortExpression="[MaLoaiHocPhan]" />				
				<data:HyperLinkField HeaderText="Ma Nhom Mon Hoc" DataNavigateUrlFormatString="NhomMonHocEdit.aspx?MaNhomMon={0}" DataNavigateUrlFields="MaNhomMon" DataContainer="MaNhomMonHocSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Sdh Phan Nhom Mon Hoc Found! </b>
				<asp:HyperLink runat="server" ID="hypSdhPhanNhomMonHoc" NavigateUrl="~/admin/SdhPhanNhomMonHocEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:SdhPhanNhomMonHocDataSource ID="SdhPhanNhomMonHocDataSource4" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:SdhPhanNhomMonHocProperty Name="NhomMonHoc"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:SdhPhanNhomMonHocFilter  Column="MaNhomMonHoc" QueryStringField="MaNhomMon" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:SdhPhanNhomMonHocDataSource>		
		
		<br />
		

</asp:Content>

