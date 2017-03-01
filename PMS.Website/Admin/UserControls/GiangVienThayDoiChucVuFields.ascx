<%@ Control Language="C#" ClassName="GiangVienThayDoiChucVuFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayHetHieuLuc" runat="server" Text="Ngay Het Hieu Luc:" AssociatedControlID="dataNgayHetHieuLuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayHetHieuLuc" Text='<%# Bind("NgayHetHieuLuc", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayHetHieuLuc" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayCapNhat" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUser" runat="server" Text="User:" AssociatedControlID="dataUser" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUser" Text='<%# Bind("User") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayHieuLuc" runat="server" Text="Ngay Hieu Luc:" AssociatedControlID="dataNgayHieuLuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayHieuLuc" Text='<%# Bind("NgayHieuLuc", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayHieuLuc" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaChucVuCu" runat="server" Text="Ma Chuc Vu Cu:" AssociatedControlID="dataMaChucVuCu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaChucVuCu" Text='<%# Bind("MaChucVuCu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaChucVuCu" runat="server" Display="Dynamic" ControlToValidate="dataMaChucVuCu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaChucVu" runat="server" Text="Ma Chuc Vu:" AssociatedControlID="dataMaChucVu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaChucVu" Text='<%# Bind("MaChucVu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaChucVu" runat="server" Display="Dynamic" ControlToValidate="dataMaChucVu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


