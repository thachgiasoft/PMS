<%@ Control Language="C#" ClassName="KetQuaTinhFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaGiangVien" DataSourceID="MaGiangVienGiangVienDataSource" DataTextField="MaDanToc" DataValueField="MaGiangVien" SelectedValue='<%# Bind("MaGiangVien") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:GiangVienDataSource ID="MaGiangVienGiangVienDataSource" runat="server" SelectMethod="GetAll"  />
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
        <td class="literal"><asp:Label ID="lbldataDonGia" runat="server" Text="Don Gia:" AssociatedControlID="dataDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGia" Text='<%# Bind("DonGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGia" runat="server" Display="Dynamic" ControlToValidate="dataDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayTao" runat="server" Text="Ngay Tao:" AssociatedControlID="dataNgayTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayTao" Text='<%# Bind("NgayTao", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayTao" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


