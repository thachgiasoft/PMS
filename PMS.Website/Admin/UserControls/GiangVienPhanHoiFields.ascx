<%@ Control Language="C#" ClassName="GiangVienPhanHoiFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayPhanHoi" runat="server" Text="Ngay Phan Hoi:" AssociatedControlID="dataNgayPhanHoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayPhanHoi" Text='<%# Bind("NgayPhanHoi", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayPhanHoi" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTraLoiPhanHoi" runat="server" Text="Tra Loi Phan Hoi:" AssociatedControlID="dataTraLoiPhanHoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTraLoiPhanHoi" Text='<%# Bind("TraLoiPhanHoi") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiTraLoi" runat="server" Text="Nguoi Tra Loi:" AssociatedControlID="dataNguoiTraLoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiTraLoi" Text='<%# Bind("NguoiTraLoi") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayTraLoi" runat="server" Text="Ngay Tra Loi:" AssociatedControlID="dataNgayTraLoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayTraLoi" Text='<%# Bind("NgayTraLoi", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayTraLoi" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDungPhanHoi" runat="server" Text="Noi Dung Phan Hoi:" AssociatedControlID="dataNoiDungPhanHoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDungPhanHoi" Text='<%# Bind("NoiDungPhanHoi") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataHoTen" runat="server" Text="Ho Ten:" AssociatedControlID="dataHoTen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHoTen" Text='<%# Bind("HoTen") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVienQuanLy" runat="server" Text="Ma Giang Vien Quan Ly:" AssociatedControlID="dataMaGiangVienQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVienQuanLy" Text='<%# Bind("MaGiangVienQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


