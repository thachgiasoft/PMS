<%@ Control Language="C#" ClassName="TietNghiaVuFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietNghiaVuCongTacKhacSauGiamTru" runat="server" Text="Tiet Nghia Vu Cong Tac Khac Sau Giam Tru:" AssociatedControlID="dataTietNghiaVuCongTacKhacSauGiamTru" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietNghiaVuCongTacKhacSauGiamTru" Text='<%# Bind("TietNghiaVuCongTacKhacSauGiamTru") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietNghiaVuCongTacKhacSauGiamTru" runat="server" Display="Dynamic" ControlToValidate="dataTietNghiaVuCongTacKhacSauGiamTru" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChot" runat="server" Text="Chot:" AssociatedControlID="dataChot" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataChot" SelectedValue='<%# Bind("Chot") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietNghiaVuCongTacKhac" runat="server" Text="Tiet Nghia Vu Cong Tac Khac:" AssociatedControlID="dataTietNghiaVuCongTacKhac" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietNghiaVuCongTacKhac" Text='<%# Bind("TietNghiaVuCongTacKhac") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietNghiaVuCongTacKhac" runat="server" Display="Dynamic" ControlToValidate="dataTietNghiaVuCongTacKhac" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiamTruKhac" runat="server" Text="Ma Giam Tru Khac:" AssociatedControlID="dataMaGiamTruKhac" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaGiamTruKhac" DataSourceID="MaGiamTruKhacGiamTruDinhMucDataSource" DataTextField="NoiDungGiamTru" DataValueField="MaQuanLy" SelectedValue='<%# Bind("MaGiamTruKhac") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:GiamTruDinhMucDataSource ID="MaGiamTruKhacGiamTruDinhMucDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietGiamTruKhac" runat="server" Text="So Tiet Giam Tru Khac:" AssociatedControlID="dataSoTietGiamTruKhac" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietGiamTruKhac" Text='<%# Bind("SoTietGiamTruKhac") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietGiamTruKhac" runat="server" Display="Dynamic" ControlToValidate="dataSoTietGiamTruKhac" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietGiamKhacGiangDay" runat="server" Text="Tiet Giam Khac Giang Day:" AssociatedControlID="dataTietGiamKhacGiangDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietGiamKhacGiangDay" Text='<%# Bind("TietGiamKhacGiangDay") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietGiamKhacGiangDay" runat="server" Display="Dynamic" ControlToValidate="dataTietGiamKhacGiangDay" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietGiamKhacNckh" runat="server" Text="Tiet Giam Khac Nckh:" AssociatedControlID="dataTietGiamKhacNckh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietGiamKhacNckh" Text='<%# Bind("TietGiamKhacNckh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietGiamKhacNckh" runat="server" Display="Dynamic" ControlToValidate="dataTietGiamKhacNckh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioChuanGiangDayChuyenSangNckh" runat="server" Text="Gio Chuan Giang Day Chuyen Sang Nckh:" AssociatedControlID="dataGioChuanGiangDayChuyenSangNckh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioChuanGiangDayChuyenSangNckh" Text='<%# Bind("GioChuanGiangDayChuyenSangNckh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioChuanGiangDayChuyenSangNckh" runat="server" Display="Dynamic" ControlToValidate="dataGioChuanGiangDayChuyenSangNckh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietNghiaVuGiangDay" runat="server" Text="Tiet Nghia Vu Giang Day:" AssociatedControlID="dataTietNghiaVuGiangDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietNghiaVuGiangDay" Text='<%# Bind("TietNghiaVuGiangDay") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietNghiaVuGiangDay" runat="server" Display="Dynamic" ControlToValidate="dataTietNghiaVuGiangDay" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietNghiaVuNckh" runat="server" Text="Tiet Nghia Vu Nckh:" AssociatedControlID="dataTietNghiaVuNckh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietNghiaVuNckh" Text='<%# Bind("TietNghiaVuNckh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietNghiaVuNckh" runat="server" Display="Dynamic" ControlToValidate="dataTietNghiaVuNckh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocVi" Text='<%# Bind("MaHocVi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocVi" runat="server" Display="Dynamic" ControlToValidate="dataMaHocVi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietGioiHan" runat="server" Text="Tiet Gioi Han:" AssociatedControlID="dataTietGioiHan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietGioiHan" Text='<%# Bind("TietGioiHan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietGioiHan" runat="server" Display="Dynamic" ControlToValidate="dataTietGioiHan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu2" runat="server" Text="Ghi Chu2:" AssociatedControlID="dataGhiChu2" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu2" Text='<%# Bind("GhiChu2") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietNghiaVu" runat="server" Text="So Tiet Nghia Vu:" AssociatedControlID="dataSoTietNghiaVu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietNghiaVu" Text='<%# Bind("SoTietNghiaVu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietNghiaVu" runat="server" Display="Dynamic" ControlToValidate="dataSoTietNghiaVu" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataGhiChu" SelectedValue='<%# Bind("GhiChu") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


