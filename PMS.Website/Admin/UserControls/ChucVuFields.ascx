<%@ Control Language="C#" ClassName="ChucVuFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayBdApDung" runat="server" Text="Ngay Bd Ap Dung:" AssociatedControlID="dataNgayBdApDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayBdApDung" Text='<%# Bind("NgayBdApDung", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayBdApDung" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayKtApDung" runat="server" Text="Ngay Kt Ap Dung:" AssociatedControlID="dataNgayKtApDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayKtApDung" Text='<%# Bind("NgayKtApDung", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayKtApDung" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCongDonKiemNhiem" runat="server" Text="Cong Don Kiem Nhiem:" AssociatedControlID="dataCongDonKiemNhiem" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataCongDonKiemNhiem" SelectedValue='<%# Bind("CongDonKiemNhiem") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDinhMucToiThieu" runat="server" Text="Dinh Muc Toi Thieu:" AssociatedControlID="dataDinhMucToiThieu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDinhMucToiThieu" Text='<%# Bind("DinhMucToiThieu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDinhMucToiThieu" runat="server" Display="Dynamic" ControlToValidate="dataDinhMucToiThieu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHrmid" runat="server" Text="Hrmid:" AssociatedControlID="dataHrmid" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataHrmid" Value='<%# Bind("Hrmid") %>'></asp:HiddenField>
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
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaQuanLy" runat="server" Display="Dynamic" ControlToValidate="dataMaQuanLy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenChucVu" runat="server" Text="Ten Chuc Vu:" AssociatedControlID="dataTenChucVu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenChucVu" Text='<%# Bind("TenChucVu") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanTramGio" runat="server" Text="Phan Tram Gio:" AssociatedControlID="dataPhanTramGio" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanTramGio" Text='<%# Bind("PhanTramGio") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataPhanTramGio" runat="server" Display="Dynamic" ControlToValidate="dataPhanTramGio" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguongTiet" runat="server" Text="Nguong Tiet:" AssociatedControlID="dataNguongTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguongTiet" Text='<%# Bind("NguongTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataNguongTiet" runat="server" Display="Dynamic" ControlToValidate="dataNguongTiet" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
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


