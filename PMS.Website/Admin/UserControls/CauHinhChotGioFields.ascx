<%@ Control Language="C#" ClassName="CauHinhChotGioFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanTramHeSoCongThem" runat="server" Text="Phan Tram He So Cong Them:" AssociatedControlID="dataPhanTramHeSoCongThem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanTramHeSoCongThem" Text='<%# Bind("PhanTramHeSoCongThem") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataPhanTramHeSoCongThem" runat="server" Display="Dynamic" ControlToValidate="dataPhanTramHeSoCongThem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanTramDonGia" runat="server" Text="Phan Tram Don Gia:" AssociatedControlID="dataPhanTramDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanTramDonGia" Text='<%# Bind("PhanTramDonGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataPhanTramDonGia" runat="server" Display="Dynamic" ControlToValidate="dataPhanTramDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTinhVaoCaNam" runat="server" Text="Tinh Vao Ca Nam:" AssociatedControlID="dataTinhVaoCaNam" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTinhVaoCaNam" SelectedValue='<%# Bind("TinhVaoCaNam") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCoTinhNckh" runat="server" Text="Co Tinh Nckh:" AssociatedControlID="dataCoTinhNckh" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataCoTinhNckh" SelectedValue='<%# Bind("CoTinhNckh") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenQuanLy" runat="server" Text="Ten Quan Ly:" AssociatedControlID="dataTenQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenQuanLy" Text='<%# Bind("TenQuanLy") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTuNgay" runat="server" Text="Tu Ngay:" AssociatedControlID="dataTuNgay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTuNgay" Text='<%# Bind("TuNgay", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataTuNgay" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDenNgay" runat="server" Text="Den Ngay:" AssociatedControlID="dataDenNgay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDenNgay" Text='<%# Bind("DenNgay", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataDenNgay" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataIsLocked" runat="server" Text="Is Locked:" AssociatedControlID="dataIsLocked" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataIsLocked" SelectedValue='<%# Bind("IsLocked") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataNamHoc" runat="server" Display="Dynamic" ControlToValidate="dataNamHoc" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataHocKy" runat="server" Display="Dynamic" ControlToValidate="dataHocKy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


