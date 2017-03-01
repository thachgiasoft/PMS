<%@ Control Language="C#" ClassName="GiangVienThayDoiHocViFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayHieuLuc" runat="server" Text="Ngay Hieu Luc:" AssociatedControlID="dataNgayHieuLuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayHieuLuc" Text='<%# Bind("NgayHieuLuc", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayHieuLuc" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
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
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocViCu" runat="server" Text="Ma Hoc Vi Cu:" AssociatedControlID="dataMaHocViCu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocViCu" Text='<%# Bind("MaHocViCu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocViCu" runat="server" Display="Dynamic" ControlToValidate="dataMaHocViCu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
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


