<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HoatDongNgoaiGiangDayEdit.aspx.cs" Inherits="HoatDongNgoaiGiangDayEdit" Title="HoatDongNgoaiGiangDay Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Hoat Dong Ngoai Giang Day - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaQuanLy" runat="server" DataSourceID="HoatDongNgoaiGiangDayDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HoatDongNgoaiGiangDayFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HoatDongNgoaiGiangDayFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>HoatDongNgoaiGiangDay not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:HoatDongNgoaiGiangDayDataSource ID="HoatDongNgoaiGiangDayDataSource" runat="server"
			SelectMethod="GetByMaQuanLy"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaQuanLy" QueryStringField="MaQuanLy" Type="String" />

			</Parameters>
		</data:HoatDongNgoaiGiangDayDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewGiangVienHoatDongNgoaiGiangDay1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienHoatDongNgoaiGiangDay1_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienHoatDongNgoaiGiangDayDataSource1"
			DataKeyNames="MaQuanLy"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienHoatDongNgoaiGiangDay.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<data:HyperLinkField HeaderText="Ma Hoat Dong" DataNavigateUrlFormatString="HoatDongNgoaiGiangDayEdit.aspx?MaQuanLy={0}" DataNavigateUrlFields="MaQuanLy" DataContainer="MaHoatDongSource" DataTextField="TenHoatDong" />
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]" />				
				<asp:BoundField DataField="NgayChiTra" HeaderText="Ngay Chi Tra" SortExpression="[NgayChiTra]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Hoat Dong Ngoai Giang Day Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienHoatDongNgoaiGiangDay" NavigateUrl="~/admin/GiangVienHoatDongNgoaiGiangDayEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienHoatDongNgoaiGiangDayDataSource ID="GiangVienHoatDongNgoaiGiangDayDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienHoatDongNgoaiGiangDayProperty Name="GiangVien"/> 
					<data:GiangVienHoatDongNgoaiGiangDayProperty Name="HoatDongNgoaiGiangDay"/> 
					<%--<data:GiangVienHoatDongNgoaiGiangDayProperty Name="QuyDoiHoatDongNgoaiGiangDayCollection" />--%>
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienHoatDongNgoaiGiangDayFilter  Column="MaHoatDong" QueryStringField="MaQuanLy" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienHoatDongNgoaiGiangDayDataSource>		
		
		<br />
		

</asp:Content>

