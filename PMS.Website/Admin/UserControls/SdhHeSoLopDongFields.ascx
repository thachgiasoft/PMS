<%@ Control Language="C#" ClassName="SdhHeSoLopDongFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKyApDung" runat="server" Text="Hoc Ky Ap Dung:" AssociatedControlID="dataHocKyApDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKyApDung" Text='<%# Bind("HocKyApDung") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiKhoiLuong" runat="server" Text="Ma Loai Khoi Luong:" AssociatedControlID="dataMaLoaiKhoiLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiKhoiLuong" Text='<%# Bind("MaLoaiKhoiLuong") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayKtApDung" runat="server" Text="Ngay Kt Ap Dung:" AssociatedControlID="dataNgayKtApDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayKtApDung" Text='<%# Bind("NgayKtApDung", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayKtApDung" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayBdApDung" runat="server" Text="Ngay Bd Ap Dung:" AssociatedControlID="dataNgayBdApDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayBdApDung" Text='<%# Bind("NgayBdApDung", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayBdApDung" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaBacDaoTao" runat="server" Text="Ma Bac Dao Tao:" AssociatedControlID="dataMaBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaBacDaoTao" Text='<%# Bind("MaBacDaoTao") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaQuanLy" runat="server" Display="Dynamic" ControlToValidate="dataMaQuanLy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataStt" runat="server" Text="Stt:" AssociatedControlID="dataStt" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataStt" Text='<%# Bind("Stt") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataStt" runat="server" Display="Dynamic" ControlToValidate="dataStt" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomMonHoc" runat="server" Text="Ma Nhom Mon Hoc:" AssociatedControlID="dataMaNhomMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhomMonHoc" Text='<%# Bind("MaNhomMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDenKhoan" runat="server" Text="Den Khoan:" AssociatedControlID="dataDenKhoan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDenKhoan" Text='<%# Bind("DenKhoan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDenKhoan" runat="server" Display="Dynamic" ControlToValidate="dataDenKhoan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTuKhoan" runat="server" Text="Tu Khoan:" AssociatedControlID="dataTuKhoan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTuKhoan" Text='<%# Bind("TuKhoan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTuKhoan" runat="server" Display="Dynamic" ControlToValidate="dataTuKhoan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


