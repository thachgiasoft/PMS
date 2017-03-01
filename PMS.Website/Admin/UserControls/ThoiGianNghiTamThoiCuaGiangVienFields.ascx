<%@ Control Language="C#" ClassName="ThoiGianNghiTamThoiCuaGiangVienFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiamTruDinhMuc" runat="server" Text="Ma Giam Tru Dinh Muc:" AssociatedControlID="dataMaGiamTruDinhMuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiamTruDinhMuc" Text='<%# Bind("MaGiamTruDinhMuc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiamTruDinhMuc" runat="server" Display="Dynamic" ControlToValidate="dataMaGiamTruDinhMuc" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
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
        <td class="literal"><asp:Label ID="lbldataGioChuanHk02" runat="server" Text="Gio Chuan Hk02:" AssociatedControlID="dataGioChuanHk02" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioChuanHk02" Text='<%# Bind("GioChuanHk02") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioChuanHk02" runat="server" Display="Dynamic" ControlToValidate="dataGioChuanHk02" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioChuanHk01" runat="server" Text="Gio Chuan Hk01:" AssociatedControlID="dataGioChuanHk01" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioChuanHk01" Text='<%# Bind("GioChuanHk01") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioChuanHk01" runat="server" Display="Dynamic" ControlToValidate="dataGioChuanHk01" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTuNgay" runat="server" Text="Tu Ngay:" AssociatedControlID="dataTuNgay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTuNgay" Text='<%# Bind("TuNgay", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataTuNgay" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDung" runat="server" Text="Noi Dung:" AssociatedControlID="dataNoiDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDung" Text='<%# Bind("NoiDung") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaGiangVien" DataSourceID="MaGiangVienGiangVienDataSource" DataTextField="MaDanToc" DataValueField="MaGiangVien" SelectedValue='<%# Bind("MaGiangVien") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:GiangVienDataSource ID="MaGiangVienGiangVienDataSource" runat="server" SelectMethod="GetAll"  />
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
        <td class="literal"><asp:Label ID="lbldataDenNgay" runat="server" Text="Den Ngay:" AssociatedControlID="dataDenNgay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDenNgay" Text='<%# Bind("DenNgay", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataDenNgay" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


