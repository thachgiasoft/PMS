<%@ Control Language="C#" ClassName="KcqPhanCongDoAnTotNghiepFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataGiangVienPhanBien2" runat="server" Text="Giang Vien Phan Bien2:" AssociatedControlID="dataGiangVienPhanBien2" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGiangVienPhanBien2" Text='<%# Bind("GiangVienPhanBien2") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGiangVienPhanBien2" runat="server" Display="Dynamic" ControlToValidate="dataGiangVienPhanBien2" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGiangVienPhanBien1" runat="server" Text="Giang Vien Phan Bien1:" AssociatedControlID="dataGiangVienPhanBien1" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGiangVienPhanBien1" Text='<%# Bind("GiangVienPhanBien1") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGiangVienPhanBien1" runat="server" Display="Dynamic" ControlToValidate="dataGiangVienPhanBien1" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayCapNhat" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaSinhVien" runat="server" Text="Ma Sinh Vien:" AssociatedControlID="dataMaSinhVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaSinhVien" Text='<%# Bind("MaSinhVien") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaSinhVien" runat="server" Display="Dynamic" ControlToValidate="dataMaSinhVien" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLopHocPhan" runat="server" Display="Dynamic" ControlToValidate="dataMaLopHocPhan" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGiangVienHuongDan" runat="server" Text="Giang Vien Huong Dan:" AssociatedControlID="dataGiangVienHuongDan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGiangVienHuongDan" Text='<%# Bind("GiangVienHuongDan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGiangVienHuongDan" runat="server" Display="Dynamic" ControlToValidate="dataGiangVienHuongDan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHoTen" runat="server" Text="Ho Ten:" AssociatedControlID="dataHoTen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHoTen" Text='<%# Bind("HoTen") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


