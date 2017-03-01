<%@ Control Language="C#" ClassName="KcqUteKhoiLuongQuyDoiFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoGioThucGiangTrenLop" runat="server" Text="So Gio Thuc Giang Tren Lop:" AssociatedControlID="dataSoGioThucGiangTrenLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoGioThucGiangTrenLop" Text='<%# Bind("SoGioThucGiangTrenLop") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoGioThucGiangTrenLop" runat="server" Display="Dynamic" ControlToValidate="dataSoGioThucGiangTrenLop" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayCapNhat" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoHocKy" runat="server" Text="He So Hoc Ky:" AssociatedControlID="dataHeSoHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoHocKy" Text='<%# Bind("HeSoHocKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoHocKy" runat="server" Display="Dynamic" ControlToValidate="dataHeSoHocKy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoGioChuanTinhThem" runat="server" Text="So Gio Chuan Tinh Them:" AssociatedControlID="dataSoGioChuanTinhThem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoGioChuanTinhThem" Text='<%# Bind("SoGioChuanTinhThem") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoGioChuanTinhThem" runat="server" Display="Dynamic" ControlToValidate="dataSoGioChuanTinhThem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLopDongLyThuyet" runat="server" Text="He So Lop Dong Ly Thuyet:" AssociatedControlID="dataHeSoLopDongLyThuyet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLopDongLyThuyet" Text='<%# Bind("HeSoLopDongLyThuyet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLopDongLyThuyet" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLopDongLyThuyet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataIdKhoiLuongGiangDay" runat="server" Text="Id Khoi Luong Giang Day:" AssociatedControlID="dataIdKhoiLuongGiangDay" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataIdKhoiLuongGiangDay" DataSourceID="IdKhoiLuongGiangDayKcqUteKhoiLuongGiangDayDataSource" DataTextField="MaMonHoc" DataValueField="Id" SelectedValue='<%# Bind("IdKhoiLuongGiangDay") %>' AppendNullItem="true" Required="true" NullItemText="< Please Choose ...>" ErrorText="Required" />
					<data:KcqUteKhoiLuongGiangDayDataSource ID="IdKhoiLuongGiangDayKcqUteKhoiLuongGiangDayDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQuyDoi" runat="server" Text="Tiet Quy Doi:" AssociatedControlID="dataTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQuyDoi" Text='<%# Bind("TietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLopDongThTnTt" runat="server" Text="He So Lop Dong Th Tn Tt:" AssociatedControlID="dataHeSoLopDongThTnTt" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLopDongThTnTt" Text='<%# Bind("HeSoLopDongThTnTt") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLopDongThTnTt" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLopDongThTnTt" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


