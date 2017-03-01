<%@ Control Language="C#" ClassName="HeSoCoSoFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataThoiGianHoc" runat="server" Text="Thoi Gian Hoc:" AssociatedControlID="dataThoiGianHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThoiGianHoc" Text='<%# Bind("ThoiGianHoc") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayKtApDung" runat="server" Text="Ngay Kt Ap Dung:" AssociatedControlID="dataNgayKtApDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayKtApDung" Text='<%# Bind("NgayKtApDung", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayKtApDung" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayBdApDung" runat="server" Text="Ngay Bd Ap Dung:" AssociatedControlID="dataNgayBdApDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayBdApDung" Text='<%# Bind("NgayBdApDung", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayBdApDung" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaCoSo" runat="server" Text="Ma Co So:" AssociatedControlID="dataMaCoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaCoSo" Text='<%# Bind("MaCoSo") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThuTu" runat="server" Text="Thu Tu:" AssociatedControlID="dataThuTu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThuTu" Text='<%# Bind("ThuTu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThuTu" runat="server" Display="Dynamic" ControlToValidate="dataThuTu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


