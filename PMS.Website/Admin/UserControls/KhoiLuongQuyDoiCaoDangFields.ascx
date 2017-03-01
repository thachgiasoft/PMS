<%@ Control Language="C#" ClassName="KhoiLuongQuyDoiCaoDangFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQuyDoiLt" runat="server" Text="Tiet Quy Doi Lt:" AssociatedControlID="dataTietQuyDoiLt" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQuyDoiLt" Text='<%# Bind("TietQuyDoiLt") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQuyDoiLt" runat="server" Display="Dynamic" ControlToValidate="dataTietQuyDoiLt" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQuyDoiTh" runat="server" Text="Tiet Quy Doi Th:" AssociatedControlID="dataTietQuyDoiTh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQuyDoiTh" Text='<%# Bind("TietQuyDoiTh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQuyDoiTh" runat="server" Display="Dynamic" ControlToValidate="dataTietQuyDoiTh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongTietQuyDoi" runat="server" Text="Tong Tiet Quy Doi:" AssociatedControlID="dataTongTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongTietQuyDoi" Text='<%# Bind("TongTietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataTongTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaKhoiLuongCaoDang" runat="server" Text="Ma Khoi Luong Cao Dang:" AssociatedControlID="dataMaKhoiLuongCaoDang" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaKhoiLuongCaoDang" DataSourceID="MaKhoiLuongCaoDangKhoiLuongGiangDayCaoDangDataSource" DataTextField="MaGiangVienQuanLy" DataValueField="MaKhoiLuongCaoDang" SelectedValue='<%# Bind("MaKhoiLuongCaoDang") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:KhoiLuongGiangDayCaoDangDataSource ID="MaKhoiLuongCaoDangKhoiLuongGiangDayCaoDangDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiGiangVien" runat="server" Text="Ma Loai Giang Vien:" AssociatedControlID="dataMaLoaiGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiGiangVien" Text='<%# Bind("MaLoaiGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaLoaiGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocVi" Text='<%# Bind("MaHocVi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocVi" runat="server" Display="Dynamic" ControlToValidate="dataMaHocVi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


