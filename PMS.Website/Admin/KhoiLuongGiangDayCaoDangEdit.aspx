<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongGiangDayCaoDangEdit.aspx.cs" Inherits="KhoiLuongGiangDayCaoDangEdit" Title="KhoiLuongGiangDayCaoDang Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Giang Day Cao Dang - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoiLuongCaoDang" runat="server" DataSourceID="KhoiLuongGiangDayCaoDangDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongGiangDayCaoDangFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongGiangDayCaoDangFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KhoiLuongGiangDayCaoDang not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KhoiLuongGiangDayCaoDangDataSource ID="KhoiLuongGiangDayCaoDangDataSource" runat="server"
			SelectMethod="GetByMaKhoiLuongCaoDang"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoiLuongCaoDang" QueryStringField="MaKhoiLuongCaoDang" Type="String" />

			</Parameters>
		</data:KhoiLuongGiangDayCaoDangDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewKhoiLuongQuyDoiCaoDang1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewKhoiLuongQuyDoiCaoDang1_SelectedIndexChanged"			 			 
			DataSourceID="KhoiLuongQuyDoiCaoDangDataSource1"
			DataKeyNames="MaKhoiLuongQuyDoiCaoDang"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_KhoiLuongQuyDoiCaoDang.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="TietQuyDoiLt" HeaderText="Tiet Quy Doi Lt" SortExpression="[TietQuyDoiLT]" />				
				<asp:BoundField DataField="TietQuyDoiTh" HeaderText="Tiet Quy Doi Th" SortExpression="[TietQuyDoiTH]" />				
				<asp:BoundField DataField="TongTietQuyDoi" HeaderText="Tong Tiet Quy Doi" SortExpression="[TongTietQuyDoi]" />				
				<data:HyperLinkField HeaderText="Ma Khoi Luong Cao Dang" DataNavigateUrlFormatString="KhoiLuongGiangDayCaoDangEdit.aspx?MaKhoiLuongCaoDang={0}" DataNavigateUrlFields="MaKhoiLuongCaoDang" DataContainer="MaKhoiLuongCaoDangSource" DataTextField="MaGiangVienQuanLy" />
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]" />				
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]" />				
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Khoi Luong Quy Doi Cao Dang Found! </b>
				<asp:HyperLink runat="server" ID="hypKhoiLuongQuyDoiCaoDang" NavigateUrl="~/admin/KhoiLuongQuyDoiCaoDangEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:KhoiLuongQuyDoiCaoDangDataSource ID="KhoiLuongQuyDoiCaoDangDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KhoiLuongQuyDoiCaoDangProperty Name="KhoiLuongGiangDayCaoDang"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:KhoiLuongQuyDoiCaoDangFilter  Column="MaKhoiLuongCaoDang" QueryStringField="MaKhoiLuongCaoDang" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:KhoiLuongQuyDoiCaoDangDataSource>		
		
		<br />
		

</asp:Content>

