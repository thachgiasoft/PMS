<%@ Control Language="C#" ClassName="KetQuaTinhTheoTuanFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietNghiaVu" runat="server" Text="Tiet Nghia Vu:" AssociatedControlID="dataTietNghiaVu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietNghiaVu" Text='<%# Bind("TietNghiaVu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietNghiaVu" runat="server" Display="Dynamic" ControlToValidate="dataTietNghiaVu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietGioiHan" runat="server" Text="Tiet Gioi Han:" AssociatedControlID="dataTietGioiHan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietGioiHan" Text='<%# Bind("TietGioiHan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietGioiHan" runat="server" Display="Dynamic" ControlToValidate="dataTietGioiHan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayTao" runat="server" Text="Ngay Tao:" AssociatedControlID="dataNgayTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayTao" Text='<%# Bind("NgayTao", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayTao" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTuan" runat="server" Text="Tuan:" AssociatedControlID="dataTuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTuan" Text='<%# Bind("Tuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTuan" runat="server" Display="Dynamic" ControlToValidate="dataTuan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNam" runat="server" Text="Nam:" AssociatedControlID="dataNam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNam" Text='<%# Bind("Nam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataNam" runat="server" Display="Dynamic" ControlToValidate="dataNam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


