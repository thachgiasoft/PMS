<%@ Control Language="C#" ClassName="KetQuaCacKhoanChiKhacFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTien" runat="server" Text="Thanh Tien:" AssociatedControlID="dataThanhTien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTien" Text='<%# Bind("ThanhTien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTien" runat="server" Display="Dynamic" ControlToValidate="dataThanhTien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTienMotTiet" runat="server" Text="Tien Mot Tiet:" AssociatedControlID="dataTienMotTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTienMotTiet" Text='<%# Bind("TienMotTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTienMotTiet" runat="server" Display="Dynamic" ControlToValidate="dataTienMotTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongThanhTien" runat="server" Text="Tong Thanh Tien:" AssociatedControlID="dataTongThanhTien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongThanhTien" Text='<%# Bind("TongThanhTien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongThanhTien" runat="server" Display="Dynamic" ControlToValidate="dataTongThanhTien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTienGiangNgoaiGio" runat="server" Text="Tien Giang Ngoai Gio:" AssociatedControlID="dataTienGiangNgoaiGio" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTienGiangNgoaiGio" Text='<%# Bind("TienGiangNgoaiGio") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTienGiangNgoaiGio" runat="server" Display="Dynamic" ControlToValidate="dataTienGiangNgoaiGio" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhiCongTac" runat="server" Text="Phi Cong Tac:" AssociatedControlID="dataPhiCongTac" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhiCongTac" Text='<%# Bind("PhiCongTac") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataPhiCongTac" runat="server" Display="Dynamic" ControlToValidate="dataPhiCongTac" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaSo" runat="server" Text="Ma So:" AssociatedControlID="dataMaSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaSo" Text='<%# Bind("MaSo") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLop" runat="server" Text="Lop:" AssociatedControlID="dataLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLop" Text='<%# Bind("Lop") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVienQuanLy" runat="server" Text="Ma Giang Vien Quan Ly:" AssociatedControlID="dataMaGiangVienQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVienQuanLy" Text='<%# Bind("MaGiangVienQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDung" runat="server" Text="Noi Dung:" AssociatedControlID="dataNoiDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDung" Text='<%# Bind("NoiDung") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgay" runat="server" Text="Ngay:" AssociatedControlID="dataNgay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgay" Text='<%# Bind("Ngay", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgay" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


