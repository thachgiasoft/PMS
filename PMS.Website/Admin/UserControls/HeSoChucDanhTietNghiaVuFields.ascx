<%@ Control Language="C#" ClassName="HeSoChucDanhTietNghiaVuFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietNghiaVuMonGdtc" runat="server" Text="So Tiet Nghia Vu Mon Gdtc:" AssociatedControlID="dataSoTietNghiaVuMonGdtc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietNghiaVuMonGdtc" Text='<%# Bind("SoTietNghiaVuMonGdtc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietNghiaVuMonGdtc" runat="server" Display="Dynamic" ControlToValidate="dataSoTietNghiaVuMonGdtc" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLuongTangThem" runat="server" Text="He So Luong Tang Them:" AssociatedControlID="dataHeSoLuongTangThem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLuongTangThem" Text='<%# Bind("HeSoLuongTangThem") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLuongTangThem" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLuongTangThem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
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
        <td class="literal"><asp:Label ID="lbldataGiangDaySauDaiHoc" runat="server" Text="Giang Day Sau Dai Hoc:" AssociatedControlID="dataGiangDaySauDaiHoc" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataGiangDaySauDaiHoc" SelectedValue='<%# Bind("GiangDaySauDaiHoc") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayBdApDung" runat="server" Text="Ngay Bd Ap Dung:" AssociatedControlID="dataNgayBdApDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayBdApDung" Text='<%# Bind("NgayBdApDung", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayBdApDung" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaHocHam" DataSourceID="MaHocHamHocHamDataSource" DataTextField="MaQuanLy" DataValueField="MaHocHam" SelectedValue='<%# Bind("MaHocHam") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:HocHamDataSource ID="MaHocHamHocHamDataSource" runat="server" SelectMethod="GetAll"  />
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
        <td class="literal"><asp:Label ID="lbldataSoTietNghiaVu" runat="server" Text="So Tiet Nghia Vu:" AssociatedControlID="dataSoTietNghiaVu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietNghiaVu" Text='<%# Bind("SoTietNghiaVu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietNghiaVu" runat="server" Display="Dynamic" ControlToValidate="dataSoTietNghiaVu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaHocVi" DataSourceID="MaHocViHocViDataSource" DataTextField="MaQuanLy" DataValueField="MaHocVi" SelectedValue='<%# Bind("MaHocVi") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:HocViDataSource ID="MaHocViHocViDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


